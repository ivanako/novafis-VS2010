Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Security.Permissions

Friend Class Win32API
    '// C# representation of the IMalloc interface
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000002-0000-0000-C000-000000000046")> _
    Public Interface IMalloc
        <PreserveSig()> Function Alloc(ByVal cb As Integer) As IntPtr
        <PreserveSig()> Function Realloc(ByVal pv As IntPtr, ByVal cb As Integer) As IntPtr
        <PreserveSig()> Sub Free(ByVal pv As IntPtr)
        <PreserveSig()> Function GetSize(ByVal pv As IntPtr) As Integer
        <PreserveSig()> Function DidAlloc(ByVal pv As IntPtr) As Integer
        <PreserveSig()> Sub HeapMinimize()
    End Interface

    <DllImport("User32.DLL")> Public Shared Function GetActiveWindow() As IntPtr

    End Function

    Public Class Shell32
        '// Styles used in the BROWSEINFO.ulFlags field
        <Flags()> Public Enum BffStyles
            RestrictToFilesystem = &H1    '// BIF_RETURNONLYFSDIRS
            RestrictToDomain = &H2        '// BIF_DONTGOBELOWDOMAIN
            RestrictToSubfolders = &H8    '// BIF_RETURNFSANCESTORS
            ShowTextBox = &H10            '// BIF_EDITBOX
            ValidateSelection = &H20      '// BIF_VALIDATE
            NewDialogStyle = &H40         '// BIF_NEWDIALOGSTYLE
            BrowseForComputer = &H1000    '// BIF_BROWSEFORCOMPUTER
            BrowseForPrinter = &H2000     '// BIF_BROWSEFORPRINTER
            BrowseForEverything = &H4000  '// BIF_BROWSEINCLUDEFILES
        End Enum

        '// Delegate type used in BROWSEINFO.lpfn field
        Public Delegate Function BFFCALLBACK(ByVal hwnd As IntPtr, ByVal uMsg As UInt32, ByVal lParam As IntPtr, ByVal lpData As IntPtr) As Integer

        'Private Declare Function lstrcat Lib "kernel32" Alias "lstrcatA" (ByVal lpString1 As String, ByVal lpString2 As String) As Integer

        <StructLayout(LayoutKind.Sequential)> Public Structure BROWSEINFO
            Public hwndOwner As IntPtr
            Public pidlRoot As IntPtr
            Public pszDisplayName As IntPtr
            <MarshalAs(UnmanagedType.LPTStr)> Public lpszTitle As String
            Public ulFlags As Integer
            <MarshalAs(UnmanagedType.FunctionPtr)> Public lpfn As BFFCALLBACK
            Public lParam As IntPtr
            Public iImage As Integer
        End Structure

        <DllImport("Shell32.DLL")> Public Shared Function SHGetMalloc(ByRef ppMalloc As IMalloc) As Integer

        End Function

        <DllImport("Shell32.DLL")> Public Shared Function SHGetSpecialFolderLocation(ByVal hwndOwner As IntPtr, ByVal nFolder As Integer, ByRef ppidl As IntPtr) As Integer

        End Function

        <DllImport("Shell32.DLL")> Public Shared Function SHGetPathFromIDList(ByVal pidl As IntPtr, ByVal Path As StringBuilder) As Integer

        End Function

        <DllImport("Shell32.DLL", CharSet:=CharSet.Auto)> Public Shared Function SHBrowseForFolder(ByRef bi As BROWSEINFO) As IntPtr

        End Function
    End Class
End Class

'/// <summary>
'/// Component wrapping access to the Browse For Folder common dialog.
'/// Call the ShowDialog() method to bring the dialog up.
'/// </summary>
<ToolboxBitmap(GetType(FolderBrowser))> Public Class FolderBrowser
    Inherits Component

    Private Const MAX_PATH As Integer = 260

    '// Root node of the tree view.
    Private _startLocation As FolderID = FolderID.Desktop

    '// Browse info options
    Private publicOptions As Integer = CInt(Win32API.Shell32.BffStyles.RestrictToFilesystem) Or CInt(Win32API.Shell32.BffStyles.RestrictToDomain)
    Private privateOptions As Integer = CInt(Win32API.Shell32.BffStyles.NewDialogStyle)

    '// Description text to show.
    Private _descriptionText As String = "Seleccionar un directorio:"

    '// Folder picked by the user.
    Private _directoryPath As String = String.Empty

    '/// <summary>
    '/// Helper function used to set / reset bits in the publicOptions bitfield
    '/// </summary>
    Private Sub SetOptionField(ByVal mask As Integer, ByVal turnOn As Boolean)
        If (turnOn) Then
            publicOptions = publicOptions Or mask
        Else
            publicOptions = publicOptions And Not mask
        End If
    End Sub

    '/// <summary>
    '/// Only return file system directories. If the user selects folders
    '/// that are not part of the file system, the OK button is grayed.
    '/// </summary>
    <Category("Navigation"), _
    Description("Only return file system directories. If the user selects folders that are not part of the file system, the OK button is grayed."), _
    DefaultValue(True)> _
    Public Property OnlyFilesystem() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.RestrictToFilesystem)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.RestrictToFilesystem), Value)
        End Set
    End Property

    '/// <summary>
    '/// Include network folders below the domain level in the
    '/// dialog box's tree view control.
    '/// </summary>
    <Category("Navigation"), _
    Description("Include network folders below the domain level in the dialog box's tree view control."), _
    DefaultValue(False)> _
    Public Property ShowNetworkFolders() As Boolean
        Get
            '// note the == 0 below instead of != 0
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.RestrictToDomain)) = 0
        End Get
        Set(ByVal Value As Boolean)
            '// note the !value below
            SetOptionField(CInt(Win32API.Shell32.BffStyles.RestrictToDomain), Not Value)
        End Set
    End Property

    '/// <summary>
    '/// Only return file system ancestors. An ancestor is a subfolder that
    '/// is beneath the root folder in the namespace hierarchy. If the user
    '/// selects an ancestor of the root folder that is not part of the file system,
    '/// the OK button is grayed.
    '/// </summary>
    <Category("Navigation"), _
    Description("Only return file system ancestors. An ancestor is a subfolder that " & _
      "is beneath the root folder in the namespace hierarchy. If the user " & _
      "selects an ancestor of the root folder that is not part of the file system, " & _
      "the OK button is grayed."), _
    DefaultValue(False)> _
    Public Property OnlySubfolders() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.RestrictToSubfolders)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.RestrictToSubfolders), Value)
        End Set
    End Property
    '/// <summary>
    '/// Include an edit control in the browse dialog box that allows the user
    '/// to type the name of an item.
    '/// </summary>
    <Description("Include an edit control in the browse dialog box that allows the user to type the name of an item."), _
    DefaultValue(False)> _
    Public Property ShowTextBox() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.ShowTextBox)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.ShowTextBox), Value)
        End Set
    End Property

    '/// <summary>
    '/// If the user types an invalid name into the edit box, the browse dialog box
    '/// will call the application's BrowseCallbackProc with the BFFM_VALIDATEFAILED
    '/// message. This flag is ignored if ShowTextBox is false.
    '/// </summary>
    <Description("If the user types an invalid name into the edit box, the browse dialog box " & _
      "will call the application's BrowseCallbackProc with the BFFM_VALIDATEFAILED " & _
      "message. This flag is ignored if ShowTextBox is false."), _
    DefaultValue(False)> _
    Public Property ValidateUserInput() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.ValidateSelection)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.ValidateSelection), Value)
        End Set
    End Property

    '/// <summary>
    '/// Only return computers. If the user selects anything other than a computer,
    '/// the OK button is grayed.
    '/// </summary>
    <Category("Selection Target"), _
    Description("Only return computers. If the user selects anything other than a computer, " & _
      "the OK button is grayed."), _
    DefaultValue(False)> _
    Public Property SelectComputer() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.BrowseForComputer)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.BrowseForComputer), Value)
        End Set
    End Property

    '/// <summary>
    '/// Only return printers. If the user selects anything other than a printer,
    '/// the OK button is grayed.
    '/// </summary>
    <Category("Selection Target"), _
    Description("Only return printers. If the user selects anything other than a printer, " & _
      "the OK button is grayed."), _
    DefaultValue(False)> _
    Public Property SelectPrinter() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.BrowseForPrinter)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.BrowseForPrinter), Value)
        End Set
    End Property

    '/// <summary>
    '/// The browse dialog box will display files as well as folders.
    '/// </summary>
    <Category("Selection Target"), _
    Description("The browse dialog box will display files as well as folders."), _
    DefaultValue(False)> _
    Public Property SelectFiles() As Boolean
        Get
            Return (publicOptions & CInt(Win32API.Shell32.BffStyles.BrowseForEverything)) <> 0
        End Get
        Set(ByVal Value As Boolean)
            SetOptionField(CInt(Win32API.Shell32.BffStyles.BrowseForEverything), Value)
        End Set
    End Property

    '/// <summary>
    '/// Gets the directory path of the folder the user picked.
    '/// </summary>
    <Description("Contains the directory path of the folder the user picked.")> _
    Public ReadOnly Property DirectoryPath() As String
        Get
            Call New FileIOPermission(FileIOPermissionAccess.PathDiscovery, _directoryPath).Demand()
            Return _directoryPath
        End Get
    End Property

    '/// <summary>
    '/// Location of the root folder from which to start browsing. Only the specified
    '/// folder and any subfolders beneath it in the namespace hierarchy will appear
    '/// in the dialog box.
    '/// </summary>
    <Category("Navigation"), _
    Description("Location of the root folder from which to start browsing. Only the specified " & _
      "folder and any subfolders beneath it in the namespace hierarchy will appear " & _
      "in the dialog box."), _
    DefaultValue(GetType(FolderID), "0")> _
    Public Property StartLocation() As FolderID
        Get
            Return StartLocation
        End Get
        Set(ByVal Value As FolderID)
            Call New UIPermission(UIPermissionWindow.AllWindows).Demand()
            StartLocation = Value
        End Set
    End Property

    '/// <summary>
    '/// Description to be displayed above the folders tree view. It can provide 
    '/// instructions for selecting a folder.
    '/// </summary>
    <Description("Description to be displayed above the folders tree view. It can provide " & _
      "instructions for selecting a folder."), _
    DefaultValue("Seleccionar un directorio:")> _
    Public Property Description() As String
        Get
            Return _descriptionText
        End Get
        Set(ByVal Value As String)
            Call New UIPermission(UIPermissionWindow.AllWindows).Demand()
            If Value Is Nothing Then
                _descriptionText = String.Empty
            Else
                _descriptionText = Value
            End If
        End Set
    End Property

    '/// <summary>
    '/// Helper function that returns the IMalloc interface used by the shell.
    '/// </summary>
    Private Function GetSHMalloc() As Win32API.IMalloc
        Dim malloc As Win32API.IMalloc
        Call Win32API.Shell32.SHGetMalloc(malloc)
        Return malloc
    End Function

    '/// <summary>
    '/// Shows the folder browser dialog.
    '/// </summary>
    Public Function ShowDialog() As DialogResult
        Return ShowDialog(Nothing)
    End Function

    '/// <summary>
    '/// Shows the folder browser dialog with the specified owner window.
    '/// </summary>
    Public Function ShowDialog(ByVal owner As IWin32Window) As DialogResult
        Dim pidlRoot As IntPtr = IntPtr.Zero

        '// Get/find an owner HWND for this dialog
        Dim hWndOwner As IntPtr

        If Not (owner Is Nothing) Then
            hWndOwner = owner.Handle
        Else
            hWndOwner = Win32API.GetActiveWindow()
        End If

        '// Get the IDL for the specific startLocation
        Win32API.Shell32.SHGetSpecialFolderLocation(hWndOwner, CInt(StartLocation), pidlRoot)

        If pidlRoot.Equals(IntPtr.Zero) Then
            Return DialogResult.Cancel
            Exit Function
        End If

        Dim mergedOptions As Integer = CInt(publicOptions) Or CInt(privateOptions)

        If ((mergedOptions & CInt(Win32API.Shell32.BffStyles.NewDialogStyle)) <> 0) Then
            Application.OleRequired()
        End If

        Dim pidlRet As IntPtr = IntPtr.Zero

        Try
            '// Construct a BROWSEINFO
            Dim bi As Win32API.Shell32.BROWSEINFO = New Win32API.Shell32.BROWSEINFO()
            Dim buffer As IntPtr = Marshal.AllocHGlobal(MAX_PATH)

            bi.pidlRoot = pidlRoot
            bi.hwndOwner = hWndOwner
            bi.pszDisplayName = buffer
            bi.lpszTitle = _descriptionText
            bi.ulFlags = mergedOptions
            '// Rest of the fields are initialized to zero by constructor
            '// bi.lpfn = null;  bi.lParam = IntPtr.Zero;    bi.iImage = 0;

            '// And show the dialog
            pidlRet = Win32API.Shell32.SHBrowseForFolder(bi)

            '// Free the buffer we've allocated on the global heap
            Marshal.FreeHGlobal(buffer)

            If pidlRet.Equals(IntPtr.Zero) Then
                '// User pressed Cancel
                Return DialogResult.Cancel
                Exit Function
            End If

            '// Then retrieve the path from the IDList
            Dim sb As StringBuilder = New StringBuilder(MAX_PATH)
            If (0 = Win32API.Shell32.SHGetPathFromIDList(pidlRet, sb)) Then
                Return DialogResult.Cancel
                Exit Function
            End If

            '// Convert to a string
            _directoryPath = sb.ToString()
        Finally
            Dim malloc As Win32API.IMalloc = GetSHMalloc()
            malloc.Free(pidlRoot)

            If Not (pidlRet.Equals(IntPtr.Zero)) Then
                malloc.Free(pidlRet)
            End If
        End Try

        Return DialogResult.OK
    End Function

    '/// <summary>
    '/// Enum of CSIDLs identifying standard shell folders.
    '/// </summary>
    Public Enum FolderID
        Desktop = &H0
        Printers = &H4
        MyDocuments = &H5
        Favorites = &H6
        Recent = &H8
        SendTo = &H9
        StartMenu = &HB
        MyComputer = &H11
        NetworkNeighborhood = &H12
        Templates = &H15
        MyPictures = &H27
        NetAndDialUpConnections = &H31
    End Enum
End Class
