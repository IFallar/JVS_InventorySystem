<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LOG_BTN = New System.Windows.Forms.Button()
        Me.ITEM_BTN = New System.Windows.Forms.Button()
        Me.HOME_BTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.HOME_BTN)
        Me.Panel1.Controls.Add(Me.LOG_BTN)
        Me.Panel1.Controls.Add(Me.ITEM_BTN)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 661)
        Me.Panel1.TabIndex = 1
        '
        'LOG_BTN
        '
        Me.LOG_BTN.BackColor = System.Drawing.Color.Transparent
        Me.LOG_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOG_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LOG_BTN.FlatAppearance.BorderSize = 0
        Me.LOG_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.LOG_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.LOG_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LOG_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOG_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LOG_BTN.Location = New System.Drawing.Point(39, 494)
        Me.LOG_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LOG_BTN.Name = "LOG_BTN"
        Me.LOG_BTN.Size = New System.Drawing.Size(173, 64)
        Me.LOG_BTN.TabIndex = 4
        Me.LOG_BTN.Text = "HISTORY"
        Me.LOG_BTN.UseVisualStyleBackColor = False
        '
        'ITEM_BTN
        '
        Me.ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        Me.ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITEM_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ITEM_BTN.Location = New System.Drawing.Point(39, 420)
        Me.ITEM_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ITEM_BTN.Name = "ITEM_BTN"
        Me.ITEM_BTN.Size = New System.Drawing.Size(173, 64)
        Me.ITEM_BTN.TabIndex = 3
        Me.ITEM_BTN.Text = "ITEMS"
        Me.ITEM_BTN.UseVisualStyleBackColor = False
        '
        'HOME_BTN
        '
        Me.HOME_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HOME_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_BTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_BTN.Location = New System.Drawing.Point(39, 346)
        Me.HOME_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.HOME_BTN.Name = "HOME_BTN"
        Me.HOME_BTN.Size = New System.Drawing.Size(173, 64)
        Me.HOME_BTN.TabIndex = 5
        Me.HOME_BTN.Text = "HOME"
        Me.HOME_BTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MaximumSize = New System.Drawing.Size(1120, 700)
        Me.MinimumSize = New System.Drawing.Size(1120, 700)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LOG_BTN As Button
    Friend WithEvents ITEM_BTN As Button
    Friend WithEvents HOME_BTN As Button
End Class
