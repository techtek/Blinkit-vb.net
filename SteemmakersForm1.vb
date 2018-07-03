Public Class SteemmakersForm1
    Private Sub SteemmakersForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub SteemmakersForm1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
        MainForm.BringToFront()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://www.steemmakers.com"
        Process.Start(webAddress)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        ' USB
        If ComboBox6.Text = "USB Flash Drive" Then
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "usbstick", False, System.Text.Encoding.ASCII)
        End If

        ' Logitech
        If ComboBox6.Text = "Logitech" Then
            My.Computer.FileSystem.WriteAllText("config\logitechaction.txt", "steemmakers", False, System.Text.Encoding.ASCII)
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "logitech", False, System.Text.Encoding.ASCII)
        End If

        ' Sonoff
        If ComboBox6.Text = "Sonoff" Then
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "sonoff", False, System.Text.Encoding.ASCII)
        End If

        ' Arduino
        If ComboBox6.Text = "Arduino" Then
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "arduino", False, System.Text.Encoding.ASCII)
        End If

        ' Philips Hue
        If ComboBox6.Text = "Philips Hue" Then
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "philipshue", False, System.Text.Encoding.ASCII)
        End If

        ' Webcam
        If ComboBox6.Text = "Webcam" Then
            My.Computer.FileSystem.WriteAllText("config\steemmakersdevice.txt", "webcam", False, System.Text.Encoding.ASCII)
        End If

        Shell("visualizersteemmakers.bat", vbNormalFocus)

    End Sub


End Class