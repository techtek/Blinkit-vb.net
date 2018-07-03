Public Class UsbForm


    Sub New()

        ' load the username and diplay it in textbox1
        InitializeComponent()

        TextBox1.Tag = My.Computer.FileSystem.ReadAllText("config\username.txt")
        TextBox1.Text = CStr(TextBox1.Tag)


        ' Update the Avatar picturebox when the program starts
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config\avatar.txt")

        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader)))

        ' Load the USB drive And diplay it in ComboBox1
        ComboBox1.Tag = My.Computer.FileSystem.ReadAllText("config\drive.txt")
        ComboBox1.Text = CStr(ComboBox1.Tag)

        ' load the number of blinks and diplay it in Combobox2
        ComboBox2.Tag = My.Computer.FileSystem.ReadAllText("config\numberofblinks.txt")
        ComboBox2.Text = CStr(ComboBox2.Tag)

        ' Display the saved notification sound in ComboBox7
        ComboBox7.Text = My.Computer.FileSystem.ReadAllText("config\sound.txt")

        ComboBox6.Text = "Steem Account Upvotes"

    End Sub


    Private Sub UsbForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get Drives and display them in listview1
        ListView1.Items.Clear()
        Dim i As Integer = 0
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim itemText As String = drive.Name
            Dim Type As String
            Dim ltr As String = drive.Name
            If drive.IsReady AndAlso drive.VolumeLabel <> "" Then
                itemText = drive.VolumeLabel
            Else
                Select Case drive.DriveType
                    Case IO.DriveType.Fixed : itemText = "Local Disk"
                    Case IO.DriveType.CDRom : itemText = "CD/DVD"
                    Case IO.DriveType.Network : itemText = "Network Drive"
                    Case IO.DriveType.Removable : itemText = "USB Flash Drive"

                End Select

            End If
            Select Case drive.DriveType
                Case IO.DriveType.Fixed : Type = "Local Disk"
                Case IO.DriveType.CDRom : Type = "CD/DVD"
                Case IO.DriveType.Network : Type = "Network Drive"
                Case IO.DriveType.Removable : Type = "USB Flash Drive"
                Case IO.DriveType.Unknown : Type = "Unknown"
            End Select
            ListView1.Items.Add(itemText)
            ListView1.Items(i).SubItems.Add(ltr)
            ListView1.Items(i).SubItems.Add(Type)
            i += 1

        Next

    End Sub



    Private Sub UsbForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader2)))


        ' Start to look for new upvotes, followers, posts etc.

        If ComboBox6.Text = "Steem Account Upvotes" Then

            Shell("upvotes.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then

            Shell("followers.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then

            Shell("posts.bat", vbNormalFocus)
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Test blink the USB LED 
        Shell("blink.bat")

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
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
        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader2)))

        ' Save selected number of blinks 
        My.Computer.FileSystem.WriteAllText("config\numberofblinks.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)

        ' Save seleted USB drive 
        My.Computer.FileSystem.WriteAllText("config\drive.txt", ComboBox1.Text, False, System.Text.Encoding.ASCII)

        ' Save selected sound file
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button33.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)
        Shell("bat\sound.bat")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button32.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Open the Utopian Upvote Bot Visualizer UtopianForm1, when the Utopian Button6 is pressed
        UtopianForm1.Show()
        UtopianForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "USB Flash Drive"
        UtopianForm1.ComboBox6.Text = "USB Flash Drive"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open the SteemMakers Upvote Bot Visualizer SteemmakerForm1, when the Steemmaker Button6 is pressed
        SteemmakersForm1.Show()
        SteemmakersForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "USB Flash Drive"
        SteemmakersForm1.ComboBox6.Text = "USB Flash Drive"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open the Steem Price Visualizer SteempricevisualizerForm1, when Steem Button6 is pressed
        SteempricevisualizerForm1.Show()
        SteempricevisualizerForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "USB Flash Drive"
        SteempricevisualizerForm1.ComboBox6.Text = "USB Flash Drive"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Refresh every second the listview1 that shows the availible drives

        ListView1.Items.Clear()
        Dim i As Integer = 0
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim itemText As String = drive.Name
            Dim Type As String
            Dim ltr As String = drive.Name
            If drive.IsReady AndAlso drive.VolumeLabel <> "" Then
                itemText = drive.VolumeLabel
            Else
                Select Case drive.DriveType
                    Case IO.DriveType.Fixed : itemText = "Local Disk"
                    Case IO.DriveType.CDRom : itemText = "CD/DVD"
                    Case IO.DriveType.Network : itemText = "Network Drive"
                    Case IO.DriveType.Removable : itemText = "USB Flash Drive"

                End Select

            End If
            Select Case drive.DriveType
                Case IO.DriveType.Fixed : Type = "Local Disk"
                Case IO.DriveType.CDRom : Type = "CD/DVD"
                Case IO.DriveType.Network : Type = "Network Drive"
                Case IO.DriveType.Removable : Type = "USB Flash Drive"
                Case IO.DriveType.Unknown : Type = "Unknown"
            End Select
            ListView1.Items.Add(itemText)
            ListView1.Items(i).SubItems.Add(ltr)
            ListView1.Items(i).SubItems.Add(Type)
            i += 1

        Next
    End Sub

End Class