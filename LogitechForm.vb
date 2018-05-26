Public Class LogitechForm

    Sub New()

        ' load the username and diplay it in textbox1
        InitializeComponent()

        RichTextBox1.Tag = My.Computer.FileSystem.ReadAllText("config\username.txt")
        RichTextBox1.Text = CStr(RichTextBox1.Tag)


        ' Update the saved users Avatar in the picturebox when the program starts
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config\avatar.txt")
        PictureBox6.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader)))

        ' load the number of blinks in Combobox6
        ComboBox1.Tag = My.Computer.FileSystem.ReadAllText("config\logitechnrblinks.txt")
        ComboBox1.Text = CStr(ComboBox1.Tag)

        ' Display the Blink delay in ComboBox2
        ComboBox2.Text = My.Computer.FileSystem.ReadAllText("config\logitechdelay.txt")

        ' Display the Blink delay in ComboBox2
        RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("config\logitechpath.txt")


        ' Display the saved notification sound in ComboBox7
        ComboBox7.Text = My.Computer.FileSystem.ReadAllText("config\sound.txt")

        ' display the default action
        ComboBox6.Text = "Steem Account Upvotes"

        ' display the saved blink colour from logitechcolourled.txt in Combobox3
        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "000 255 000" Then
            ComboBox3.Text = "Green"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "000 000 255" Then
            ComboBox3.Text = "Blue"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "255 000 000" Then
            ComboBox3.Text = "Red"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "255 020 000" Then
            ComboBox3.Text = "Orange"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "255 090 000" Then
            ComboBox3.Text = "Yellow"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "150 000 100" Then
            ComboBox3.Text = "Pink"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "000 255 255" Then
            ComboBox3.Text = "Aqua"
        End If

        If My.Computer.FileSystem.ReadAllText("config\logitechcolour.txt") = "255 255 255" Then
            ComboBox3.Text = "White"
        End If

    End Sub


    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Save the username from the textBox to username.txt
        My.Computer.FileSystem.WriteAllText("config\username.txt", RichTextBox1.Text, False, System.Text.Encoding.ASCII)

        ' Make URL to get the user Avatar Image
        Shell("bat\avatarurl.bat")

        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Get User Avatar URL and put it in "Filereader2"
        Dim fileReader2 As String
        fileReader2 = My.Computer.FileSystem.ReadAllText("config\avatar.txt")

        ' Update the Avatar picturebox when Save is pressed 
        PictureBox6.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader2)))

        ' Save selected sound file
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)

        ' Save number of blinks
        My.Computer.FileSystem.WriteAllText("config\logitechnrblinks.txt", ComboBox1.Text, False, System.Text.Encoding.ASCII)

        ' Save blink delay
        My.Computer.FileSystem.WriteAllText("config\logitechdelay.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)

        ' Save the location of the Logitech DLL into logitechpath.txt
        My.Computer.FileSystem.WriteAllText("config\logitechpath.txt", RichTextBox2.Text, False, System.Text.Encoding.ASCII)

        ' Save the blink colour in logitechcolourled.txt
        If ComboBox3.Text = "Green" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "000 255 000", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Blue" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "000 000 255", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Red" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "255 000 000", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Orange" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "255 020 000", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Yellow" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "255 090 000", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Violet" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "045 000 130", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Pink" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "150 000 100", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "Aqua" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "000 255 255", False, System.Text.Encoding.ASCII)
        If ComboBox3.Text = "White" Then My.Computer.FileSystem.WriteAllText("config\logitechcolour.txt", "255 255 255", False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub LogitechForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogitechForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Open the Blinkit mainscreen when the Logitech screen is closed
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        ' Save and play the notification sound
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button33.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)
        Shell("bat\sound.bat")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        ' Turn off the notification sound
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button32.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ' Blink the Logitech device by starting logitechblink.exe
        Shell("logitechblink.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Start to look for new upvotes/followers/posts by starting the related bat script
        If ComboBox6.Text = "Steem Account Upvotes" Then

            Shell("upvoteslogitech.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then

            Shell("followerslogitech.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then

            Shell("postslogitech.bat", vbNormalFocus)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class


