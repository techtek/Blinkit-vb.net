<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebcamForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebcamForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Blinkit.My.Resources.Resources.webcam
        Me.PictureBox1.Location = New System.Drawing.Point(4, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Myriad Pro", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Sound"
        '
        'Button32
        '
        Me.Button32.BackgroundImage = CType(resources.GetObject("Button32.BackgroundImage"), System.Drawing.Image)
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button32.Font = New System.Drawing.Font("Myriad Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.ForeColor = System.Drawing.Color.White
        Me.Button32.Location = New System.Drawing.Point(291, 233)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(43, 24)
        Me.Button32.TabIndex = 119
        Me.Button32.Text = "Off"
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackgroundImage = CType(resources.GetObject("Button33.BackgroundImage"), System.Drawing.Image)
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button33.Font = New System.Drawing.Font("Myriad Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.ForeColor = System.Drawing.Color.White
        Me.Button33.Location = New System.Drawing.Point(247, 233)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(43, 24)
        Me.Button33.TabIndex = 118
        Me.Button33.Text = "On"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'ComboBox7
        '
        Me.ComboBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox7.Font = New System.Drawing.Font("Myriad Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.ForeColor = System.Drawing.Color.White
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.ItemHeight = 16
        Me.ComboBox7.Items.AddRange(New Object() {"SpaceGlitters.wav", "ToasterDing.wav", "Succession.wav", "DripEcho.wav", "UserPreset1.wav", "UserPreset2.wav"})
        Me.ComboBox7.Location = New System.Drawing.Point(128, 233)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(117, 24)
        Me.ComboBox7.TabIndex = 117
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(128, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 24)
        Me.TextBox1.TabIndex = 116
        Me.TextBox1.Text = "username"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Blinkit.My.Resources.Resources.Button
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Myriad Pro Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(37, 570)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(432, 35)
        Me.Button4.TabIndex = 108
        Me.Button4.Text = "Start Blinkit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Myriad Pro", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Steem user"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Myriad Pro", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 18)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Action"
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.DropDownWidth = 150
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Myriad Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.ForeColor = System.Drawing.Color.White
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Steem Account Upvotes", "Steem Account Followers", "Steem Account Posts"})
        Me.ComboBox6.Location = New System.Drawing.Point(128, 263)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(206, 28)
        Me.ComboBox6.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Time"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Myriad Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.White
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox4.Location = New System.Drawing.Point(128, 167)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(58, 28)
        Me.ComboBox4.TabIndex = 2
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(402, 315)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(36, 17)
        Me.LinkLabel4.TabIndex = 1
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Save"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(438, 315)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(32, 17)
        Me.LinkLabel3.TabIndex = 122
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Test"
        '
        'lstDevices
        '
        Me.lstDevices.BackColor = System.Drawing.Color.White
        Me.lstDevices.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.ForeColor = System.Drawing.Color.Black
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 16
        Me.lstDevices.Location = New System.Drawing.Point(37, 336)
        Me.lstDevices.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(430, 84)
        Me.lstDevices.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Myriad Pro", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Mode"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Myriad Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Picture", "LED"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(117, 28)
        Me.ComboBox1.TabIndex = 125
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(351, 130)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 93)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 127
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Myriad Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Available Devices"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.Blinkit.My.Resources.Resources.ButtonB1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(329, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 78)
        Me.Button2.TabIndex = 131
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.Blinkit.My.Resources.Resources.ButtonB1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(183, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 78)
        Me.Button1.TabIndex = 130
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImage = Global.Blinkit.My.Resources.Resources.ButtonB1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(37, 648)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 78)
        Me.Button6.TabIndex = 129
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Blinkit.My.Resources.Resources.Button
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Myriad Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(37, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(432, 29)
        Me.Button3.TabIndex = 132
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'WebcamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blinkit.My.Resources.Resources.backround_051
        Me.ClientSize = New System.Drawing.Size(506, 757)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WebcamForm"
        Me.Text = "Blinkit - Webcam"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents lstDevices As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
End Class
