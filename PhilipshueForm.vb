﻿Public Class PhilipshueForm



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
        ComboBox4.Tag = My.Computer.FileSystem.ReadAllText("bat\config\blinklengthphilipshue.txt")
        ComboBox4.Text = CStr(ComboBox4.Tag)

        ' Display the saved philips hue ip and id in the textboxes
        TextBox3.Text = My.Computer.FileSystem.ReadAllText("bat\config\philipshueip.txt")
        TextBox2.Text = My.Computer.FileSystem.ReadAllText("bat\config\philipshueid.txt")

        ' Display the saved notification sound in ComboBox7
        ComboBox7.Text = My.Computer.FileSystem.ReadAllText("config\sound.txt")

        ' display the default action
        ComboBox6.Text = "Steem Account Upvotes"

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PhilipshueForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ' Test Blink the Philips Hue Light
        Shell("blinkphilipshue.bat")
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
        My.Computer.FileSystem.WriteAllText("bat\config\blinklengthphilipshue.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

        ' Save ip 
        My.Computer.FileSystem.WriteAllText("bat\config\philipshueip.txt", TextBox3.Text, False, System.Text.Encoding.ASCII)

        ' Save id 
        My.Computer.FileSystem.WriteAllText("bat\config\philipshueid.txt", TextBox2.Text, False, System.Text.Encoding.ASCII)

        ' Save selected sound file
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' Start to look for new upvotes/followers/posts
        If ComboBox6.Text = "Steem Account Upvotes" Then

            Shell("bat\upvotesphilipshue.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then

            Shell("bat\followersphilipshue.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then

            Shell("bat\postsphilipshue.bat", vbNormalFocus)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Open the Utopian Upvote Bot Visualizer UtopianForm1, when the Utopian Button6 is pressed
        UtopianForm1.Show()
        UtopianForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Philips Hue"
        UtopianForm1.ComboBox6.Text = "Philips Hue"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Open the SteemMakers Upvote Bot Visualizer SteemmakerForm1, when the Steemmaker Button6 is pressed
        SteemmakersForm1.Show()
        SteemmakersForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Philips Hue"
        SteemmakersForm1.ComboBox6.Text = "Philips Hue"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open the Steem Price Visualizer SteempricevisualizerForm1, when Steem Button6 is pressed
        SteempricevisualizerForm1.Show()
        SteempricevisualizerForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Philips Hue"
        SteempricevisualizerForm1.ComboBox6.Text = "Philips Hue"
    End Sub
End Class