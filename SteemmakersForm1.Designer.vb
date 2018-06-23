<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SteemmakersForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteemmakersForm1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Blinkit.My.Resources.Resources.Steemmakerslogo_01
        Me.PictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Myriad Pro Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(145, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Upvote Bot - Visualizer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 25)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Device to Blink"
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.Color.White
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.DropDownWidth = 150
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Myriad Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.ForeColor = System.Drawing.Color.Black
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"USB Flash Drive", "Sonoff", "Philips Hue", "Arduino", "Webcam", "Logitech"})
        Me.ComboBox6.Location = New System.Drawing.Point(187, 429)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(280, 28)
        Me.ComboBox6.TabIndex = 61
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Myriad Pro Light", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(35, 548)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(432, 77)
        Me.Button4.TabIndex = 60
        Me.Button4.Text = "Start Blinkit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkOrchid
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel1.Font = New System.Drawing.Font("Myriad Pro Light", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 728)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(242, 21)
        Me.LinkLabel1.TabIndex = 64
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.steemmakers.com"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Blinkit.My.Resources.Resources.c_description__shadow
        Me.PictureBox2.Location = New System.Drawing.Point(-125, 488)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(822, 208)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'SteemmakersForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blinkit.My.Resources.Resources.SteemMakers_Background_Image
        Me.ClientSize = New System.Drawing.Size(506, 757)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SteemmakersForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blinkit - Steemmakers Bot Visualizer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
