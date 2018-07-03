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

        ' Display the logitech LED dll path in RichTextBox2
        RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("config\logitechpath.txt")

        ' Display the logitech LCD dll path in RichTextBox2
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText("config\logitechpathlcd.txt")

        ' Display the logitech Device in ComBobox5
        ComboBox5.Text = My.Computer.FileSystem.ReadAllText("config\logitechdevice.txt")


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

        ' display the default Mode (LED, LCD, LED,LCD) into Combobox4
        ComboBox4.Text = My.Computer.FileSystem.ReadAllText("config\logitechmode.txt")

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

        ' Save the location of the Logitech LED DLL into logitechpath.txt
        My.Computer.FileSystem.WriteAllText("config\logitechpath.txt", RichTextBox2.Text, False, System.Text.Encoding.ASCII)

        ' Save the location of the Logitech LCD DLL into logitechpathlcd.txt
        My.Computer.FileSystem.WriteAllText("config\logitechpathlcd.txt", RichTextBox3.Text, False, System.Text.Encoding.ASCII)

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

        ' Save the mode ("LED", "LCD", "LED & LCD") set by the user with combobox4 into logitechmode.txt
        My.Computer.FileSystem.WriteAllText("config\logitechmode.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

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
        ' Test Blink label  to blink the logitech device with logitechblink.exe


        If ComboBox4.Text = "LED" Then
            Shell("logitechblink.exe", AppWinStyle.Hide)
        End If

        If ComboBox4.Text = "LCD" Then
            Shell("logitechlcd.exe", AppWinStyle.Hide)
        End If

        If ComboBox4.Text = "LED,LCD" Then
            Shell("logitechblink.exe", AppWinStyle.Hide)
            Shell("logitechlcd.exe", AppWinStyle.Hide)
        End If

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Start to look for new upvotes/followers/posts by starting the related bat script
        If ComboBox6.Text = "Steem Account Upvotes" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "upvote", False, System.Text.Encoding.ASCII)
            Shell("upvoteslogitech.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "follower", False, System.Text.Encoding.ASCII)
            Shell("followerslogitech.bat", vbNormalFocus)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "post", False, System.Text.Encoding.ASCII)
            Shell("postslogitech.bat", vbNormalFocus)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Open the Utopian Upvote Bot Visualizer UtopianForm1, when the Utopian Button6 is pressed
        UtopianForm1.Show()
        UtopianForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Logitech"
        UtopianForm1.ComboBox6.Text = "Logitech"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Open the SteemMakers Upvote Bot Visualizer SteemmakerForm1, when the Steemmaker Button6 is pressed
        SteemmakersForm1.Show()
        SteemmakersForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Logitech"
        SteemmakersForm1.ComboBox6.Text = "Logitech"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open the Steem Price Visualizer SteempricevisualizerForm1, when Steem Button6 is pressed
        SteempricevisualizerForm1.Show()
        SteempricevisualizerForm1.BringToFront()

        ' Hide the device settings form
        Me.Hide()

        ' change the default device in ComboBox6 to "Logitech"
        SteempricevisualizerForm1.ComboBox6.Text = "Logitech"
    End Sub








    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

        If ComboBox4.Text = "LED" Then

            ' Save the mode ("LED", "LCD", "LED & LCD") set by the user with combobox4 into logitechmode.txt
            My.Computer.FileSystem.WriteAllText("config\logitechmode.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

            Panel1.Visible = True
        End If


        If ComboBox4.Text = "LCD" Then

            ' Save the mode ("LED", "LCD", "LED & LCD") set by the user with combobox4 into logitechmode.txt
            My.Computer.FileSystem.WriteAllText("config\logitechmode.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

            Panel1.Visible = False
        End If


        If ComboBox4.Text = "LED,LCD" Then

            ' Save the mode ("LED", "LCD", "LED & LCD") set by the user with combobox4 into logitechmode.txt
            My.Computer.FileSystem.WriteAllText("config\logitechmode.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

            Panel1.Visible = True
        End If


    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged

        If ComboBox6.Text = "Steem Account Upvotes" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "upvote", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox6.Text = "Steem Account Followers" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "follower", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox6.Text = "Steem Account Posts" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "post", False, System.Text.Encoding.ASCII)
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

        If ComboBox5.Text = "G11" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg11
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"


            ' Hide the colour dropdown menu combobox3 and label3, this devices is monochrome
            ComboBox3.Visible = False
            Label3.Visible = False

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G11", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G13" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg13
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Items.Add("LCD")
            ComboBox4.Items.Add("LED,LCD")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G13", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G15" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.LogitechG15
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Items.Add("LCD")
            ComboBox4.Items.Add("LED,LCD")
            ComboBox4.Text = "LED"

            ' Hide the colour dropdown menu combobox3 and label3, this devices is monochrome
            ComboBox3.Visible = False
            Label3.Visible = False

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G15", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G19" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg19
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G19", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G19s" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg19s
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G19s", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G105" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg105
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Hide the colour dropdown menu combobox3 and label3, this devices is monochrome
            ComboBox3.Visible = False
            Label3.Visible = False

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G105", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G110" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg110
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G110", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G300" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg300
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G300", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G303" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg303
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G303", False, System.Text.Encoding.ASCII)
        End If


        If ComboBox5.Text = "G510" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg510
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Items.Add("LCD")
            ComboBox4.Items.Add("LED,LCD")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G510", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G510s" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg510s
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G510s", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G600" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg600
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G600", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G610" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg610
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Hide the colour dropdown menu combobox3 and label3, this devices is monochrome
            ComboBox3.Visible = False
            Label3.Visible = False

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G610", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G633" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg633
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G633", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G710+" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg710_
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Hide the colour dropdown menu combobox3 and label3, this devices is monochrome
            ComboBox3.Visible = False
            Label3.Visible = False

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G710+", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G633" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg633
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G633", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G810" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg810
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G810", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G900" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg900
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G900", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G910" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitech_orion_spark_wall_e1522722019129
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G910", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox5.Text = "G933" Then
            ' Change the Logitech model picture, to the selected model, and show the Mode it supports in ComboBox4
            PictureBox2.Image = Blinkit.My.Resources.Resources.logitechg933
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("LED")
            ComboBox4.Text = "LED"

            ' Show the colour dropdown menu combobox3, this devices supports RGB colours
            ComboBox3.Visible = True
            ComboBox3.Text = "Green" ' show the first colour value 
            Label3.Visible = True

            ' Save the chosen Logitech model inside logitechdeivce.txt
            My.Computer.FileSystem.WriteAllText("config\logitechdevice.txt", "G933", False, System.Text.Encoding.ASCII)
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        ' Toggle the visability ON for DLL paths and labels located on panel2
        If LinkLabel1.LinkColor = Color.LightGray Then
            LinkLabel1.LinkColor = Color.White
            Panel2.Visible = True

            ' Toggle the visability OFF for  DLL paths and labels located on panel2
        ElseIf LinkLabel1.LinkColor = Color.White Then
            LinkLabel1.LinkColor = Color.LightGray
            Panel2.Visible = False

        End If
    End Sub
End Class


