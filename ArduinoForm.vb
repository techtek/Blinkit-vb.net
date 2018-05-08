Imports System.IO

Public Class ArduinoForm
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form5_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    Private Sub ConnectSerial()

        Try
            SerialPort.BaudRate = My.Computer.FileSystem.ReadAllText("config\arduinobaudrate.txt")
            SerialPort.PortName = My.Computer.FileSystem.ReadAllText("config\arduinocomport.txt")
            SerialPort.Open()
        Catch
            SerialPort.Close()
        End Try

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Display the saved Arduino COM port 
        ComboBox1.Text = My.Computer.FileSystem.ReadAllText("config\arduinocomport.txt")

        ' Display the saved Arduino Baudrate
        ComboBox2.Text = My.Computer.FileSystem.ReadAllText("config\arduinobaudrate.txt")

        ' Display the saved soundfile 
        ComboBox7.Text = My.Computer.FileSystem.ReadAllText("config\sound.txt")

        ' Display the saved number of blink for led1
        ComboBox4.Text = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled1.txt")

        ' Display the saved number of blink for led2
        ComboBox10.Text = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled2.txt")

        ' Display the saved number of blink for led3
        ComboBox13.Text = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled3.txt")


        ' Display the saved blink delay for led1
        ComboBox5.Text = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled1.txt")

        ' Display the saved blink delay for led2
        ComboBox9.Text = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled2.txt")

        ' Display the saved blink delay for led3
        ComboBox12.Text = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled3.txt")

        ' Update the Avatar picturebox when the program starts
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config\avatar.txt")

        PictureBox6.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(fileReader)))

        ' load the username and diplay it in textbox1
        RichTextBox1.Tag = My.Computer.FileSystem.ReadAllText("config\username.txt")
        RichTextBox1.Text = CStr(RichTextBox1.Tag)

        ' Display the saved mode
        If My.Computer.FileSystem.ReadAllText("config\arduinomode.txt") = "m1" Then
            ComboBox3.Text = "3x Single colour LED"
        End If

        If My.Computer.FileSystem.ReadAllText("config\arduinomode.txt") = "m2" Then
            ComboBox3.Text = "3x RGB LED"
        End If






    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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

        ' Save the mode from the ComboBox to arduinomode.txt
        If ComboBox3.Text = "3x Single colour LED" Then
            My.Computer.FileSystem.WriteAllText("config\arduinomode.txt", "m1", False, System.Text.Encoding.ASCII)
        End If

        If ComboBox3.Text = "3x RGB LED" Then
            My.Computer.FileSystem.WriteAllText("config\arduinomode.txt", "m2", False, System.Text.Encoding.ASCII)
        End If



        ' Save the number of blinks for led1 in config file arduinonumberofblinksled1.txt
        My.Computer.FileSystem.WriteAllText("config\arduinonumberofblinksled1.txt", ComboBox4.Text, False, System.Text.Encoding.ASCII)

        ' Save the number of blinks for led2 in config file arduinonumberofblinksled2.txt
        My.Computer.FileSystem.WriteAllText("config\arduinonumberofblinksled2.txt", ComboBox10.Text, False, System.Text.Encoding.ASCII)

        ' Save the number of blinks for led3 in config file arduinonumberofblinksled3.txt
        My.Computer.FileSystem.WriteAllText("config\arduinonumberofblinksled3.txt", ComboBox13.Text, False, System.Text.Encoding.ASCII)


        ' Save the blink delay for led1 in config file arduinoblinkdelayled1.txt
        My.Computer.FileSystem.WriteAllText("config\arduinoblinkdelayled1.txt", ComboBox5.Text, False, System.Text.Encoding.ASCII)

        ' Save the blink delay for led2 in config file arduinoblinkdelayled2.txt
        My.Computer.FileSystem.WriteAllText("config\arduinoblinkdelayled2.txt", ComboBox9.Text, False, System.Text.Encoding.ASCII)

        ' Save the blink delay for led3 in config file arduinoblinkdelayled3.txt
        My.Computer.FileSystem.WriteAllText("config\arduinoblinkdelayled3.txt", ComboBox12.Text, False, System.Text.Encoding.ASCII)



        ' Save the Arduino COM port inside the config file arduinocomport.txt
        My.Computer.FileSystem.WriteAllText("config\arduinocomport.txt", ComboBox1.Text, False, System.Text.Encoding.ASCII)

        ' Save the Arduino baudrate inside the config file arduinobaudrate.txt
        My.Computer.FileSystem.WriteAllText("config\arduinobaudrate.txt", ComboBox2.Text, False, System.Text.Encoding.ASCII)





        ' Sleep 3 second to let the files update
        Threading.Thread.Sleep(3000) ' 3000 milliseconds = 3.0 seconds

        ' Send the mode to the Arduino / it is done two times because the Arduino can have issues when the first command is send 
        Shell("arduinomode.exe")

        ' Sleep 1 second to let the files update
        Threading.Thread.Sleep(3000) ' 1000 milliseconds = 1.0 seconds

        ' Send the mode to the Arduino
        Shell("arduinomode.exe")

        ' Sleep 1 second to let the files update
        Threading.Thread.Sleep(3000) ' 1000 milliseconds = 1.0 seconds




        ' Send the number of blinks and delay value to the Arduino

        Dim numberofblinksled1 As String = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled1.txt")
        Dim numberofblinksled2 As String = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled2.txt")
        Dim numberofblinksled3 As String = My.Computer.FileSystem.ReadAllText("config\arduinonumberofblinksled3.txt")

        My.Computer.FileSystem.WriteAllText("config\arduinocommand.txt", "n" & numberofblinksled1 & Space(1) & "n" & numberofblinksled2 & Space(1) & "n" & numberofblinksled3, False, System.Text.Encoding.ASCII)

        ' Send the command to the Arduino
        Shell("arduinosendcommand.exe")

        ' Sleep 1 second to let the files update
        Threading.Thread.Sleep(3000) ' 1000 milliseconds = 1.0 seconds

        ' Send the delay value to the Arduino

        Dim blinkdelayled1 As String = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled1.txt")
        Dim blinkdelayled2 As String = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled2.txt")
        Dim blinkdelayled3 As String = My.Computer.FileSystem.ReadAllText("config\arduinoblinkdelayled3.txt")

        My.Computer.FileSystem.WriteAllText("config\arduinocommand.txt", "d" & blinkdelayled1 & Space(1) & "d" & blinkdelayled2 & Space(1) & "d" & blinkdelayled3, False, System.Text.Encoding.ASCII)

        ' Send the command to the Arduino
        Shell("arduinosendcommand.exe")






    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Show the Arduino Console form
        ArduinoConsoleForm.Show()
        ArduinoConsoleForm.BringToFront()


        ' Hide the main form when the USB stick screen is shown
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("upvotesarduino.bat", vbNormalFocus)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Shell("followersarduino.bat", vbNormalFocus)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("postsarduino.bat", vbNormalFocus)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button33.Text, False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText("config\sound.txt", ComboBox7.Text, False, System.Text.Encoding.ASCII)
        Shell("bat\sound.bat")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        My.Computer.FileSystem.WriteAllText("config\soundsetting.txt", Button32.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        If SerialPort.IsOpen Then
            SerialPort.Write("u")

            SerialPort.Close()
        Else
            ConnectSerial()
            SerialPort.Write("u")

            SerialPort.Close()
        End If



    End Sub



    Private Sub ArduinoForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        SerialPort.Close()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If SerialPort.IsOpen Then
            SerialPort.Write("p")

            SerialPort.Close()
        Else
            ConnectSerial()
            SerialPort.Write("p")

            SerialPort.Close()
        End If


    End Sub
End Class