<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArduinoConsoleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArduinoConsoleForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialText = New System.Windows.Forms.RichTextBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Blinkit.My.Resources.Resources.LogoArduino
        Me.PictureBox1.Location = New System.Drawing.Point(799, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'SerialText
        '
        Me.SerialText.Location = New System.Drawing.Point(50, 90)
        Me.SerialText.Name = "SerialText"
        Me.SerialText.Size = New System.Drawing.Size(710, 148)
        Me.SerialText.TabIndex = 15
        Me.SerialText.Text = ""
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(50, 55)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(634, 22)
        Me.txtSend.TabIndex = 14
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(685, 55)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 13
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.Font = New System.Drawing.Font("Myriad Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(230, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 52)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Post"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Myriad Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(140, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 52)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Follower"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.Font = New System.Drawing.Font("Myriad Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(50, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 52)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "upvote"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ArduinoConsoleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blinkit.My.Resources.Resources.backround_051
        Me.ClientSize = New System.Drawing.Size(1072, 354)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SerialText)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.BtnSend)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ArduinoConsoleForm"
        Me.Text = "Blinkit - Arduino Console"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SerialText As RichTextBox
    Friend WithEvents txtSend As TextBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
