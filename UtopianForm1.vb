Imports System.IO

Public Class UtopianForm1
    Private Sub UtopianForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UtopianForm1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://www.utopian.io/"
        Process.Start(webAddress)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        ' USB
        If ComboBox6.Text = "USB Flash Drive" Then
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "usbstick", False, System.Text.Encoding.ASCII)
        End If

        ' Logitech
        If ComboBox6.Text = "Logitech" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "utopian", False, System.Text.Encoding.ASCII)
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "logitech", False, System.Text.Encoding.ASCII)
        End If

        ' Sonoff
        If ComboBox6.Text = "Sonoff" Then
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "sonoff", False, System.Text.Encoding.ASCII)
        End If

        ' Arduino
        If ComboBox6.Text = "Arduino" Then
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "arduino", False, System.Text.Encoding.ASCII)
        End If

        ' Philips Hue
        If ComboBox6.Text = "Philips Hue" Then
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "philipshue", False, System.Text.Encoding.ASCII)
        End If

        ' Philips Hue
        If ComboBox6.Text = "Webcam" Then
            My.Computer.FileSystem.WriteAllText("config\utopiandevice.txt", "webcam", False, System.Text.Encoding.ASCII)
        End If

        Shell("visualizerutopian.bat", vbNormalFocus)

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

End Class