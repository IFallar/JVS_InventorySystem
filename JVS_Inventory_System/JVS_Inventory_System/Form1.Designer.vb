<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SIDE_HOME_BTN = New System.Windows.Forms.Button()
        Me.SIDE_LOG_BTN = New System.Windows.Forms.Button()
        Me.SIDE_ITEM_BTN = New System.Windows.Forms.Button()
        Me.Base_Panel = New System.Windows.Forms.Panel()
        Me.HOME_PANEL = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ITEM_PANEL = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOG_PANEL = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HOME_STOCK_IO_BTN = New System.Windows.Forms.Button()
        Me.HOME_ADD_ITEM_BTN = New System.Windows.Forms.Button()
        Me.HOME_INVENTORY_LOG_BTN = New System.Windows.Forms.Button()
        Me.HOME_ITEM_LIST_BTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Base_Panel.SuspendLayout()
        Me.HOME_PANEL.SuspendLayout()
        Me.ITEM_PANEL.SuspendLayout()
        Me.LOG_PANEL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SIDE_HOME_BTN)
        Me.Panel1.Controls.Add(Me.SIDE_LOG_BTN)
        Me.Panel1.Controls.Add(Me.SIDE_ITEM_BTN)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 661)
        Me.Panel1.TabIndex = 1
        '
        'SIDE_HOME_BTN
        '
        Me.SIDE_HOME_BTN.BackColor = System.Drawing.Color.White
        Me.SIDE_HOME_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SIDE_HOME_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SIDE_HOME_BTN.FlatAppearance.BorderSize = 0
        Me.SIDE_HOME_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.SIDE_HOME_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.SIDE_HOME_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SIDE_HOME_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIDE_HOME_BTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SIDE_HOME_BTN.Location = New System.Drawing.Point(43, 346)
        Me.SIDE_HOME_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.SIDE_HOME_BTN.Name = "SIDE_HOME_BTN"
        Me.SIDE_HOME_BTN.Size = New System.Drawing.Size(181, 64)
        Me.SIDE_HOME_BTN.TabIndex = 5
        Me.SIDE_HOME_BTN.Text = "HOME"
        Me.SIDE_HOME_BTN.UseVisualStyleBackColor = False
        '
        'SIDE_LOG_BTN
        '
        Me.SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent
        Me.SIDE_LOG_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SIDE_LOG_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SIDE_LOG_BTN.FlatAppearance.BorderSize = 0
        Me.SIDE_LOG_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.SIDE_LOG_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.SIDE_LOG_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SIDE_LOG_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIDE_LOG_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SIDE_LOG_BTN.Location = New System.Drawing.Point(43, 494)
        Me.SIDE_LOG_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.SIDE_LOG_BTN.Name = "SIDE_LOG_BTN"
        Me.SIDE_LOG_BTN.Size = New System.Drawing.Size(181, 64)
        Me.SIDE_LOG_BTN.TabIndex = 4
        Me.SIDE_LOG_BTN.Text = "HISTORY"
        Me.SIDE_LOG_BTN.UseVisualStyleBackColor = False
        '
        'SIDE_ITEM_BTN
        '
        Me.SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        Me.SIDE_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SIDE_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SIDE_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.SIDE_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SIDE_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.SIDE_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SIDE_ITEM_BTN.Font = New System.Drawing.Font("Tw Cen MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIDE_ITEM_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SIDE_ITEM_BTN.Location = New System.Drawing.Point(43, 420)
        Me.SIDE_ITEM_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.SIDE_ITEM_BTN.Name = "SIDE_ITEM_BTN"
        Me.SIDE_ITEM_BTN.Size = New System.Drawing.Size(181, 64)
        Me.SIDE_ITEM_BTN.TabIndex = 3
        Me.SIDE_ITEM_BTN.Text = "ITEMS"
        Me.SIDE_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'Base_Panel
        '
        Me.Base_Panel.BackColor = System.Drawing.Color.White
        Me.Base_Panel.Controls.Add(Me.HOME_PANEL)
        Me.Base_Panel.Controls.Add(Me.ITEM_PANEL)
        Me.Base_Panel.Controls.Add(Me.LOG_PANEL)
        Me.Base_Panel.Location = New System.Drawing.Point(221, 0)
        Me.Base_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Base_Panel.Name = "Base_Panel"
        Me.Base_Panel.Size = New System.Drawing.Size(881, 661)
        Me.Base_Panel.TabIndex = 2
        '
        'HOME_PANEL
        '
        Me.HOME_PANEL.BackColor = System.Drawing.Color.White
        Me.HOME_PANEL.Controls.Add(Me.Panel2)
        Me.HOME_PANEL.Controls.Add(Me.Label2)
        Me.HOME_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HOME_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.HOME_PANEL.Name = "HOME_PANEL"
        Me.HOME_PANEL.Size = New System.Drawing.Size(881, 661)
        Me.HOME_PANEL.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HOME PANEL"
        '
        'ITEM_PANEL
        '
        Me.ITEM_PANEL.Controls.Add(Me.Label1)
        Me.ITEM_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITEM_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.ITEM_PANEL.Name = "ITEM_PANEL"
        Me.ITEM_PANEL.Size = New System.Drawing.Size(881, 661)
        Me.ITEM_PANEL.TabIndex = 0
        Me.ITEM_PANEL.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM PANEL"
        '
        'LOG_PANEL
        '
        Me.LOG_PANEL.BackColor = System.Drawing.SystemColors.Control
        Me.LOG_PANEL.Controls.Add(Me.Label3)
        Me.LOG_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LOG_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.LOG_PANEL.Name = "LOG_PANEL"
        Me.LOG_PANEL.Size = New System.Drawing.Size(881, 661)
        Me.LOG_PANEL.TabIndex = 1
        Me.LOG_PANEL.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LOG PANEL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.HOME_STOCK_IO_BTN)
        Me.Panel2.Controls.Add(Me.HOME_ADD_ITEM_BTN)
        Me.Panel2.Controls.Add(Me.HOME_INVENTORY_LOG_BTN)
        Me.Panel2.Controls.Add(Me.HOME_ITEM_LIST_BTN)
        Me.Panel2.Location = New System.Drawing.Point(11, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 377)
        Me.Panel2.TabIndex = 3
        '
        'HOME_STOCK_IO_BTN
        '
        Me.HOME_STOCK_IO_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_STOCK_IO_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_STOCK_IO_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_STOCK_IO_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_STOCK_IO_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_STOCK_IO_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HOME_STOCK_IO_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_STOCK_IO_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_STOCK_IO_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_STOCK_IO_BTN.Location = New System.Drawing.Point(20, 198)
        Me.HOME_STOCK_IO_BTN.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.HOME_STOCK_IO_BTN.Name = "HOME_STOCK_IO_BTN"
        Me.HOME_STOCK_IO_BTN.Size = New System.Drawing.Size(230, 158)
        Me.HOME_STOCK_IO_BTN.TabIndex = 9
        Me.HOME_STOCK_IO_BTN.Text = "STOCK IN AND OUT"
        Me.HOME_STOCK_IO_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_STOCK_IO_BTN.UseVisualStyleBackColor = False
        '
        'HOME_ADD_ITEM_BTN
        '
        Me.HOME_ADD_ITEM_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_ADD_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HOME_ADD_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_ADD_ITEM_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_ADD_ITEM_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_ADD_ITEM_BTN.Location = New System.Drawing.Point(270, 198)
        Me.HOME_ADD_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.HOME_ADD_ITEM_BTN.Name = "HOME_ADD_ITEM_BTN"
        Me.HOME_ADD_ITEM_BTN.Size = New System.Drawing.Size(230, 158)
        Me.HOME_ADD_ITEM_BTN.TabIndex = 7
        Me.HOME_ADD_ITEM_BTN.Text = "ADD NEW ITEM"
        Me.HOME_ADD_ITEM_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_ADD_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'HOME_INVENTORY_LOG_BTN
        '
        Me.HOME_INVENTORY_LOG_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_INVENTORY_LOG_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HOME_INVENTORY_LOG_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_INVENTORY_LOG_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_INVENTORY_LOG_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_INVENTORY_LOG_BTN.Location = New System.Drawing.Point(270, 20)
        Me.HOME_INVENTORY_LOG_BTN.Margin = New System.Windows.Forms.Padding(10, 20, 20, 10)
        Me.HOME_INVENTORY_LOG_BTN.Name = "HOME_INVENTORY_LOG_BTN"
        Me.HOME_INVENTORY_LOG_BTN.Size = New System.Drawing.Size(230, 158)
        Me.HOME_INVENTORY_LOG_BTN.TabIndex = 8
        Me.HOME_INVENTORY_LOG_BTN.Text = "INVENTORY LOG"
        Me.HOME_INVENTORY_LOG_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_INVENTORY_LOG_BTN.UseVisualStyleBackColor = False
        '
        'HOME_ITEM_LIST_BTN
        '
        Me.HOME_ITEM_LIST_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_ITEM_LIST_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_ITEM_LIST_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_ITEM_LIST_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_ITEM_LIST_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_ITEM_LIST_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HOME_ITEM_LIST_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_ITEM_LIST_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_ITEM_LIST_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_ITEM_LIST_BTN.Location = New System.Drawing.Point(20, 20)
        Me.HOME_ITEM_LIST_BTN.Margin = New System.Windows.Forms.Padding(20, 20, 10, 10)
        Me.HOME_ITEM_LIST_BTN.Name = "HOME_ITEM_LIST_BTN"
        Me.HOME_ITEM_LIST_BTN.Size = New System.Drawing.Size(230, 158)
        Me.HOME_ITEM_LIST_BTN.TabIndex = 6
        Me.HOME_ITEM_LIST_BTN.Text = "ITEMS AND PRODUCTS"
        Me.HOME_ITEM_LIST_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_ITEM_LIST_BTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Base_Panel)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MaximumSize = New System.Drawing.Size(1120, 700)
        Me.MinimumSize = New System.Drawing.Size(1120, 700)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Base_Panel.ResumeLayout(False)
        Me.HOME_PANEL.ResumeLayout(False)
        Me.HOME_PANEL.PerformLayout()
        Me.ITEM_PANEL.ResumeLayout(False)
        Me.ITEM_PANEL.PerformLayout()
        Me.LOG_PANEL.ResumeLayout(False)
        Me.LOG_PANEL.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SIDE_LOG_BTN As Button
    Friend WithEvents SIDE_ITEM_BTN As Button
    Friend WithEvents SIDE_HOME_BTN As Button
    Friend WithEvents Base_Panel As Panel
    Friend WithEvents HOME_PANEL As Panel
    Friend WithEvents LOG_PANEL As Panel
    Friend WithEvents ITEM_PANEL As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HOME_STOCK_IO_BTN As Button
    Friend WithEvents HOME_ADD_ITEM_BTN As Button
    Friend WithEvents HOME_INVENTORY_LOG_BTN As Button
    Friend WithEvents HOME_ITEM_LIST_BTN As Button
End Class
