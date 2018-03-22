Imports System
Imports System.IO




Public Class Form1







    Sub New()




        ' load the username and diplay it in textbox1
        InitializeComponent()

        TextBox1.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\username.txt")
        TextBox1.Text = CStr(TextBox1.Tag)








        ' Update the Avatar picturebox when the program starts
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\avatar.txt")

        PictureBox5.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader)))





        ' load the drive and diplay it in ComboBox1

        ComboBox1.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\drive.txt")
        ComboBox1.Text = CStr(ComboBox1.Tag)

        ComboBox2.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\drive2.txt")
        ComboBox2.Text = CStr(ComboBox2.Tag)

        ComboBox3.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\drive3.txt")
        ComboBox3.Text = CStr(ComboBox3.Tag)


        ' load the blinklength and diplay it in TrackBar

        TrackBar1.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklength.txt")
        TrackBar1.Value = CStr(TrackBar1.Tag)

        TrackBar2.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklength2.txt")
        TrackBar2.Value = CStr(TrackBar2.Tag)

        TrackBar3.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklength3.txt")
        TrackBar3.Value = CStr(TrackBar3.Tag)

        TrackBar4.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklengthsonoff.txt")
        TrackBar4.Value = CStr(TrackBar4.Tag)


        ' load the by the user selected color of the stick's LED and display the color in a textbox
        ' USBSTICK 1
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Green" Then
            RichTextBox4.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Blue" Then
            RichTextBox4.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Yellow" Then
            RichTextBox4.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Orange" Then
            RichTextBox4.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Red" Then
            RichTextBox4.BackColor = Color.Red
        End If

        ' USBSTICK 2
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Green" Then
            RichTextBox5.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Blue" Then
            RichTextBox5.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Yellow" Then
            RichTextBox5.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Orange" Then
            RichTextBox5.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Red" Then
            RichTextBox5.BackColor = Color.Red
        End If



        ' USBSTICK 3
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Green" Then
            RichTextBox8.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Blue" Then
            RichTextBox8.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Yellow" Then
            RichTextBox8.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Orange" Then
            RichTextBox8.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Red" Then
            RichTextBox8.BackColor = Color.Red
        End If

        ' Display the saved sonoff ip in the textbox
        TextBox4.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\sonoffip.txt")


        ' download and display the coin price from coinmarketcap.com on startup

        Shell("c:\blinkit\bat\coinprice.bat")
        Threading.Thread.Sleep(4600) ' 500 milliseconds = 0.5 seconds
        RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\steempricestriped.txt")
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\sbdpricestriped.txt")
        RichTextBox6.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1pricestriped.txt")
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2pricestriped.txt")
        Shell("c:\blinkit\bat\blink.bat")

        GroupBox11.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")
        TextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")

        GroupBox9.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")
        TextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")


        ' Get coin icon URL and put it in "icon1url"
        Dim icon1url As String
        icon1url = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\pricepreset1iconurl.txt")

        ' Update the picturebox with the saved coin icon
        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(icon1url)))


        ' Get coin icon URL and put it in "icon2url"
        Dim icon2url As String
        icon2url = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\pricepreset2iconurl.txt")

        ' Update the picturebox when Save is pressed 
        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(icon2url)))



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








    Private Sub OnTextBoxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("c:\blinkit\bat\upvotes.bat", vbNormalFocus)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Shell("c:\blinkit\bat\blink.bat")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("c:\blinkit\bat\blink.bat")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("c:\blinkit\bat\blink.bat")
        Shell("c:\blinkit\bat\bleep.bat")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\upvotes.bat")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("c:\blinkit\bat\followers.bat", vbNormalFocus)
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Shell("c:\blinkit\bat\bleep.bat")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://steemit.com/@techtek"
        Process.Start(webAddress)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click






        ' Download Coin prices
        Shell("c:\blinkit\bat\coinprice.bat")
            Threading.Thread.Sleep(5000) ' 500 milliseconds = 0.5 seconds
            ' RichTextBox2.Text = "Updating..."
            ' RichTextBox1.Text = "Updating..."
            Shell("c:\blinkit\bat\coinprice.bat")
            Threading.Thread.Sleep(5000) ' 500 milliseconds = 0.5 seconds

            RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\steempricestriped.txt")
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\sbdpricestriped.txt")
        RichTextBox6.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1pricestriped.txt")
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2pricestriped.txt")

        ' update the labels of the presets with the saved data from pricepresets1.txt
        GroupBox11.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")
        TextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")

        GroupBox9.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")
        TextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")





    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub


    Private Sub RichTextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\followers.bat")
    End Sub

    Private Sub LinkLabel4_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\blink.bat")
    End Sub

    Private Sub LinkLabel5_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\bleep.bat")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Save the username from the textBox to username.txt
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\username.txt", TextBox1.Text, False, System.Text.Encoding.ASCII)

        ' Make URL to get the user Avatar Image
        Shell("c:\blinkit\bat\avatarurl.bat")

        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Get User Avatar URL and put it in "Filereader2"
        Dim fileReader2 As String
        fileReader2 = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\avatar.txt")

        ' Update the Avatar picturebox when Save is pressed 
        PictureBox5.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader2)))


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\drive.txt", ComboBox1.Text, False, System.Text.Encoding.ASCII)
        ' My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength.txt", TrackBar1.Value, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\usbstick1color.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)


        ' load the by the user selected color of the stick's LED and display the color in a textbox
        ' USBSTICK 1
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Green" Then
            RichTextBox4.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Blue" Then
            RichTextBox4.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Yellow" Then
            RichTextBox4.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Orange" Then
            RichTextBox4.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick1color.txt") = "Red" Then
            RichTextBox4.BackColor = Color.Red
        End If




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("c:\blinkit\bat\posts.bat", vbNormalFocus)
    End Sub



    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\posts.bat")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Label5_Click_2(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        '

        If Label6.Text = "View More" Then
            Label6.Text = "View Less"
            Me.Size = New System.Drawing.Size(820, 695)

        ElseIf Label6.Text = "View Less" Then
            Label6.Text = "View More"
            Me.Size = New System.Drawing.Size(356, 695)

        End If





    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        ' Save the coin  from the textBox to pricepreset1price.txt
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\pricepreset1.txt", TextBox2.Text, False, System.Text.Encoding.ASCII)


        ' Download Coin prices
        Shell("c:\blinkit\bat\coinprice.bat")
        Threading.Thread.Sleep(8000) ' 500 milliseconds = 0.5 seconds
        Shell("c:\blinkit\bat\coinprice.bat")
        Threading.Thread.Sleep(2000) ' 500 milliseconds = 0.5 seconds
        RichTextBox6.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1pricestriped.txt")
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2pricestriped.txt")

        ' update the labels of the presets with the saved data from pricepresets1.txt
        GroupBox11.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")
        TextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")

        GroupBox9.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")
        TextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")


        ' Make URL to get the coin icon
        Shell("c:\blinkit\bat\coinpreset1iconurl.bat")

        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Get coin icon URL and put it in "icon1url"
        Dim icon1url As String
        icon1url = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\pricepreset1iconurl.txt")

        ' Update the picturebox when Save is pressed 
        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(icon1url)))




    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Shell("c:\blinkit\bat\blink2.bat")
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Shell("c:\blinkit\bat\blink3.bat")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\drive2.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)
        ' My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength2.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength2.txt", TrackBar2.Value, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\usbstick2color.txt", ComboBox5.Text, False, System.Text.Encoding.ASCII)

        ' load the by the user selected color of the stick's LED and display the color in a textbox
        ' USBSTICK 2
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Green" Then
            RichTextBox5.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Blue" Then
            RichTextBox5.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Yellow" Then
            RichTextBox5.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Orange" Then
            RichTextBox5.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick2color.txt") = "Red" Then
            RichTextBox5.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\drive3.txt", ComboBox3.Text, False, System.Text.Encoding.ASCII)
        ' My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength3.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklength3.txt", TrackBar3.Value, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\usbstick3color.txt", ComboBox6.Text, False, System.Text.Encoding.ASCII)

        ' load the by the user selected color of the stick's LED and display the color in a textbox
        ' USBSTICK 3
        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Green" Then
            RichTextBox8.BackColor = Color.Green
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Blue" Then
            RichTextBox8.BackColor = Color.Blue
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Yellow" Then
            RichTextBox8.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Orange" Then
            RichTextBox8.BackColor = Color.Orange
        End If

        If My.Computer.FileSystem.ReadAllText("c:\blinkit\config\usbstick3color.txt") = "Red" Then
            RichTextBox8.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        ' Save the coin  from the textBox to pricepreset1price.txt
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\pricepreset2.txt", TextBox3.Text, False, System.Text.Encoding.ASCII)


        ' Download Coin prices
        Shell("c:\blinkit\bat\coinprice.bat")
        Threading.Thread.Sleep(8000) ' 500 milliseconds = 0.5 seconds
        Shell("c:\blinkit\bat\coinprice.bat")
        Threading.Thread.Sleep(2000) ' 500 milliseconds = 0.5 seconds
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2pricestriped.txt")

        ' update the labels of the presets with the saved data from pricepresets1.txt
        GroupBox11.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")
        TextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset1.txt")

        GroupBox9.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")
        TextBox3.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\pricepreset2.txt")
        Shell("c:\blinkit\bat\blink.bat")

        ' Make URL to get the coin icon
        Shell("c:\blinkit\bat\coinpreset2iconurl.bat")

        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Get coin icon URL and put it in "icon2url"
        Dim icon2url As String
        icon2url = My.Computer.FileSystem.ReadAllText("C:\blinkit\config\pricepreset2iconurl.txt")

        ' Update the picturebox when Save is pressed 
        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(icon2url)))



    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Shell("c:\blinkit\bat\upvotes2.bat", vbNormalFocus)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Shell("c:\blinkit\bat\upvotes3.bat", vbNormalFocus)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Shell("c:\blinkit\bat\followers2.bat", vbNormalFocus)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Shell("c:\blinkit\bat\followers3.bat", vbNormalFocus)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Shell("c:\blinkit\bat\posts2.bat", vbNormalFocus)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Shell("c:\blinkit\bat\posts3.bat", vbNormalFocus)
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\upvotes2.bat")
    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\upvotes3.bat")
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\followers2.bat")
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\followers3.bat")
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\posts2.bat")
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\posts3.bat")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\blink2.bat")
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\blink3.bat")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Shell("c:\blinkit\bat\sound.bat")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Me.WebBrowser1.Navigate("http://192.168.178.200/cm?cmnd=power%20on")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\sonoffip.txt", TextBox4.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("c:\blinkit\config\blinklengthsonoff.txt", TrackBar4.Value, False, System.Text.Encoding.ASCII)


    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Shell("c:\blinkit\bat\blinksonoff.bat")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.WebBrowser1.Navigate("http://192.168.178.200/cm?cmnd=power%20off")
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\blinksonoff.bat")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Shell("c:\blinkit\bat\postssonoff.bat")
    End Sub
End Class





