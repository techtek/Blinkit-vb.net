Imports System.IO


Public Class SteempricevisualizerForm1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Connect to serial device arduino, only used for Arduino devices
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





    Private Sub SteempricevisualizerForm1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub






    'loop Blink the selected device 
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick



        If TextBox3.BackColor = Color.Green Or TextBox4.BackColor = Color.Green Then
            Shell("bat\sound.bat", AppWinStyle.Hide)



            ' USB
            If ComboBox6.Text = "USB Flash Drive" Then
                Shell("blink.bat", AppWinStyle.Hide)
            End If

            ' Logitech
            If ComboBox6.Text = "Logitech" Then
                My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "steem", False, System.Text.Encoding.ASCII)
                Shell("logitechblink.exe", AppWinStyle.Hide)
                Shell("logitechlcd.exe", AppWinStyle.Hide)
            End If

            ' Sonoff
            If ComboBox6.Text = "Sonoff" Then
                Shell("bat\blinksonoff.bat", AppWinStyle.Hide)
            End If

            ' Arduino
            If ComboBox6.Text = "Arduino" Then
                If SerialPort.IsOpen Then
                    SerialPort.Write("u")

                    SerialPort.Close()
                Else
                    ConnectSerial()
                    SerialPort.Write("u")

                    SerialPort.Close()
                End If
            End If

            ' Philips Hue
            If ComboBox6.Text = "Philips Hue" Then
                Shell("blinkphilipshue.bat", AppWinStyle.Hide)
            End If

            ' Webcam
            If ComboBox6.Text = "Webcam" Then
                Shell("blinkwebcamled.bat", AppWinStyle.Hide)
            End If

        End If






    End Sub

    ' Start Blinkit Button4, starts Timer 1 and in it BackgroundWorker1, get price & update price ticker labels
    ' If Steem or SBS price alert label was pressed (textbox.visable) then enable the related timer that will check the coinmakretcap price with the price alarm price
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()

        ' show the stop link label to stop the Price Alarm action
        LinkLabel5.Visible = True

        If TextBox1.Visible = True Then
            ' Enable the STEEM Price Timer3 that makes the devices blink 
            Timer3.Enabled = True
        End If

        If TextBox2.Visible = True Then
            ' Enable the SBD Price Timer4 that makes the devices blink 
            Timer4.Enabled = True
        End If
    End Sub


    ' Price alert Steem, compare the set price alarm with the Coinmarketcap price and display a Green or Red notification in the result box
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim steempricealert As String
        Dim steemprice As String

        steempricealert = TextBox1.Text.Trim()
        steemprice = Label4.Text.Trim()

        ' Compare if the set price alert for the Steem price is, or is bigger or smaller than the price from Coinmarketcap 
        If steempricealert >= steemprice Then
            TextBox3.BackColor = Color.Red ' make the result box Red
        End If

        If steempricealert <= steemprice Then
            TextBox3.BackColor = Color.Green ' make the result box Green
        End If
    End Sub


    ' Price alert SBD, compare the set price alarm with the Coinmarketcap price and display a Green or Red notification in the result box
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        Dim sbdpricealert As String
        Dim sbdprice As String

        sbdpricealert = TextBox2.Text.Trim()
        sbdprice = Label1.Text.Trim()

        ' Compare if the set price alert for the SBD price is, or is bigger or smaller than the price from Coinmarketcap 
        If sbdpricealert >= sbdprice Then
            TextBox4.BackColor = Color.Red ' make the result box Red
        End If

        If sbdpricealert <= sbdprice Then
            TextBox4.BackColor = Color.Green ' make the result box Green
        End If
    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        GroupBox1.Visible = True
        LinkLabel4.Visible = True
        Label6.Visible = True
        TextBox1.Visible = True
        TextBox3.Visible = True

        Label8.Visible = False
        TextBox2.Visible = False
        TextBox4.Visible = False

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        GroupBox1.Visible = True
        LinkLabel4.Visible = True
        Label6.Visible = False
        TextBox1.Visible = False
        TextBox3.Visible = False

        Label8.Visible = True
        TextBox2.Visible = True
        TextBox4.Visible = True
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        GroupBox1.Visible = False
        LinkLabel4.Visible = False

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Timer3.Stop()
        Timer4.Stop()
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
    End Sub



    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim webAddress As String = "https://www.coinmarketcap.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://steemit.com/"
        Process.Start(webAddress)
    End Sub


    ' Loop and get the price and update the Price ticker labels 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Display the downloaded Steem and SBD price in the price ticker label4 and label1
        Label4.Text = My.Computer.FileSystem.ReadAllText("config\steempricestriped.txt").Trim()
        Label1.Text = My.Computer.FileSystem.ReadAllText("config\sbdpricestriped.txt").Trim()

        ' Start BackgroundWorker1 wich runs Coinprice.bat outside of the interface thread, to prevent the interface from freezing while the program waits for the price to update
        BackgroundWorker1.RunWorkerAsync()

    End Sub


    ' BackgroundWorker1 will update the Coin price outside of the main thread, to prevent the interface from freezing, process.start is used to be able to hide the coinprice.bat screen
    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Using process As Process = New Process
            process.StartInfo.FileName = "bat\coinprice.bat"

            process.StartInfo.Arguments = ""

            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardError = False
            process.StartInfo.RedirectStandardOutput = False
            process.StartInfo.CreateNoWindow = True

            process.Start()
            process.WaitForExit()


        End Using
    End Sub


End Class