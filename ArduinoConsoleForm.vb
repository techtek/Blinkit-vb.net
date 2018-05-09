Imports System.IO

Public Class ArduinoConsoleForm

    Private Sub arduinoconsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub New()
        InitializeComponent()
    End Sub

    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        If SerialPort.IsOpen Then
            SerialPort.Write(txtSend.Text)
        Else
            ConnectSerial()
            SerialPort.Write(txtSend.Text)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectSerial()
    End Sub

    Private Sub ConnectSerial()
        Try
            SerialPort.BaudRate = My.Computer.FileSystem.ReadAllText("config\arduinobaudrate.txt")
            SerialPort.PortName = My.Computer.FileSystem.ReadAllText("config\arduinocomport.txt")
            SerialPort.Open()
        Catch
            SerialPort.Close()
        End Try
    End Sub

    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)

    'display the text from the arduino into textbox SerialText
    Sub myShowStringMethod(ByVal myString As String)
        SerialText.AppendText(myString)
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim str As String = SerialPort.ReadExisting()
        Invoke(myD1, str)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SerialPort.IsOpen Then
            SerialPort.Write("u")
        Else
            ConnectSerial()
            SerialPort.Write("u")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SerialPort.IsOpen Then
            SerialPort.Write("f")
        Else
            ConnectSerial()
            SerialPort.Write("f")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SerialPort.IsOpen Then
            SerialPort.Write("p")
        Else
            ConnectSerial()
            SerialPort.Write("p")
        End If
    End Sub





    Private Sub txtSend_TextChanged(sender As Object, e As EventArgs) Handles txtSend.TextChanged

    End Sub

    Private Sub SerialText_TextChanged(sender As Object, e As EventArgs) Handles SerialText.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub




    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArduinoConsoleForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ArduinoForm.Show()
        ArduinoForm.BringToFront()

        SerialPort.Close()

    End Sub


End Class