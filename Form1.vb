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

        ' load the blinklength set by the user and diplay it in ComboBox2

        ComboBox2.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklength.txt")
        ComboBox2.Text = CStr(ComboBox2.Tag)

        ' load the blinklength set by the user and diplay it in ComboBox2

        ' TrackBar1.Tag = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\blinklength.txt")
        ' TrackBar1.Value = CStr(TrackBar1.Tag)

        ' load steemprice from coinmarketcap.com on startup

        Shell("c:\blinkit\bat\steemprice.bat")
        Threading.Thread.Sleep(4600) ' 500 milliseconds = 0.5 seconds
        RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\steempricestriped.txt")
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\sbdpricestriped.txt")
        Shell("c:\blinkit\bat\blink.bat")


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
        Shell("c:\blinkit\bat\steemprice.bat")
        Threading.Thread.Sleep(8000) ' 500 milliseconds = 0.5 seconds
        RichTextBox2.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\steempricestriped.txt")
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("c:\blinkit\config\sbdpricestriped.txt")
        Shell("c:\blinkit\bat\blink.bat")
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

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("c:\blinkit\bat\posts.bat", vbNormalFocus)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start("notepad.exe", "c:\blinkit\bat\posts.bat")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Label5_Click_2(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
