<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.userType = New System.Windows.Forms.ComboBox()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.log_in = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.JVS_Inventory_System.My.Resources.Resources.icons8_circled_user_male_skin_type_5_64
        Me.PictureBox2.Location = New System.Drawing.Point(596, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JVS_Inventory_System.My.Resources.Resources._213965982_978436666253882_1246474777397895940_n
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 461)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'userType
        '
        Me.userType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userType.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.userType.FormattingEnabled = True
        Me.userType.Items.AddRange(New Object() {"Admin", "User"})
        Me.userType.Location = New System.Drawing.Point(586, 224)
        Me.userType.Name = "userType"
        Me.userType.Size = New System.Drawing.Size(121, 23)
        Me.userType.TabIndex = 2
        Me.userType.Text = "ACCOUNT TYPE"
        '
        'userName
        '
        Me.userName.AccessibleName = ""
        Me.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userName.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.ForeColor = System.Drawing.Color.Silver
        Me.userName.Location = New System.Drawing.Point(563, 253)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(170, 25)
        Me.userName.TabIndex = 4
        Me.userName.Text = "USERNAME"
        Me.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.Silver
        Me.pass.Location = New System.Drawing.Point(563, 284)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(170, 25)
        Me.pass.TabIndex = 4
        Me.pass.Text = "PASSWORD"
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pass.UseSystemPasswordChar = True
        '
        'log_in
        '
        Me.log_in.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.log_in.FlatAppearance.BorderSize = 0
        Me.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_in.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_in.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.log_in.Location = New System.Drawing.Point(563, 315)
        Me.log_in.Name = "log_in"
        Me.log_in.Size = New System.Drawing.Size(170, 25)
        Me.log_in.TabIndex = 5
        Me.log_in.Text = "LOG-IN"
        Me.log_in.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(785, 461)
        Me.Controls.Add(Me.log_in)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.userType)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents userType As ComboBox
    Friend WithEvents userName As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents log_in As Button
End Class
