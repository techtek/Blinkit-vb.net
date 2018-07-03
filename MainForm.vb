Public Class MainForm

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()



        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Property ButtonUSBclicked As Object



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show the USB stick form
        UsbForm.Show()
        UsbForm.BringToFront()

        ' Hide the main form when the USB stick screen is shown
        Me.Hide()
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Show the Arduino form
        ArduinoForm.Show()
        ArduinoForm.BringToFront()

        ' Hide the main form when the Arduino screen is shown
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Show the Philips hue form
        PhilipshueForm.Show()
        PhilipshueForm.BringToFront()

        ' Hide the main form when the Philips hue screen is shown
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Show the Sonoff form
        SonoffForm.Show()
        SonoffForm.BringToFront()

        ' Hide the main form when the Sonoff screen is shown
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Show the Webcam form
        WebcamForm.Show()
        WebcamForm.BringToFront()

        ' Hide the main form when the Webcam screen is shown
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Blink USB stick LED when the Blinkit logo is clicked
        Shell("bat\blink.bat", vbNormalFocus)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://steemit.com/@techtek"
        Process.Start(webAddress)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Show the Webcam form
        LogitechForm.Show()
        LogitechForm.BringToFront()

        ' Hide the main form when the Webcam screen is shown
        Me.Hide()
    End Sub
End Class


