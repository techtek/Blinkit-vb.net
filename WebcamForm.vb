Public Class WebcamForm

    ' load wmcap
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Dim iDevice As Integer = 0
    Dim hHwnd As Integer
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Object) As Integer
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, ByVal nID As Integer) As Integer
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean

    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0
        Do
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
            If bReturn Then lstDevices.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub




    Private Sub WebcamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeviceList()
    End Sub

    Sub New()

        ' load the username and diplay it in textbox1
        InitializeComponent()

        TextBox1.Tag = My.Computer.FileSystem.ReadAllText("config\username.txt")
        TextBox1.Text = CStr(TextBox1.Tag)


        ' Update the Avatar picturebox when the program starts
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config\avatar.txt")

        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader)))

        ' load the blinklength and diplay it in Combobox4
        ComboBox4.Tag = My.Computer.FileSystem.ReadAllText("config\webcamledlength.txt")
        ComboBox4.Text = CStr(ComboBox4.Tag)

        ' load the webcam mode and display it in Combobox1
        ComboBox1.Tag = My.Computer.FileSystem.ReadAllText("config\webcammode.txt")
        ComboBox1.Text = CStr(ComboBox1.Tag)

        ' Display the saved notification sound in ComboBox7
        ComboBox7.Text = My.Computer.FileSystem.ReadAllText("config\sound.txt")

        ' display the default action
        ComboBox6.Text = "Steem Account Upvotes"

    End Sub

    Private Sub WebcamForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If ComboBox1.Text = "LED" Then

            Shell("blinkwebcamled.bat")
        End If

        If ComboBox1.Text = "Picture" Then
            Shell("webcam.exe", vbNormalFocus)

        End If



    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Save the username from the textBox to username.txt
        My.Computer.FileSystem.WriteAllText("config\username.txt", TextBox1.Text, False, System.Text.Encoding.ASCII)

        ' Make URL to get the user Avatar Image
        Shell("bat\avatarurl.bat")

        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Get User Avatar URL and put it in "Filereader2"
        Dim fileReader2 As String
        fileReader2 = My.Computer.FileSystem.ReadAllText("config\avatar.txt")

        ' Update the Avatar picturebox when Save is pressed 
        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader2)))


        ' Save Blinklength 
        My.Computer.FileSystem.WriteAllText("config\webcamledlength.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)



        ' Save Webcam Mode 
        My.Computer.FileSystem.WriteAllText("config\webcammode.txt", ComboBox1.Text, False, System.Text.Encoding.ASCII)

        ' Save selected sound file
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Start to look for new upvotes/followers/posts
        If ComboBox6.Text = "Steem Account Upvotes" Then

            Shell("upvoteswebcam.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then

            Shell("followerswebcam.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then

            Shell("postswebcam.bat", vbNormalFocus)
        End If

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button33.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)
        Shell("bat\sound.bat")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button32.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstDevices.Items.Clear()
        LoadDeviceList()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Open the Utopian Upvote Bot Visualizer UtopianForm1, when the Utopian Button6 is pressed
        UtopianForm1.Show()
        UtopianForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Webcam"
        UtopianForm1.ComboBox6.Text = "Webcam"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open the SteemMakers Upvote Bot Visualizer SteemmakerForm1, when the Steemmaker Button6 is pressed
        SteemmakersForm1.Show()
        SteemmakersForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Webcam"
        SteemmakersForm1.ComboBox6.Text = "Webcam"
    End Sub
End Class