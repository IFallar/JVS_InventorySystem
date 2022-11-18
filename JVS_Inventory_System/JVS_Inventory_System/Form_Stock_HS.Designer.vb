<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Stock_HS
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
        Me.FSHS_PRC_HOLD = New System.Windows.Forms.Label()
        Me.FSHS_TRH_HOLD = New System.Windows.Forms.Label()
        Me.FSHS_QTY_HOLD = New System.Windows.Forms.Label()
        Me.FSHS_ID_HOLD = New System.Windows.Forms.Label()
        Me.FSHS_HEAD_LBL = New System.Windows.Forms.Label()
        Me.FSHS_ADD_BTN = New System.Windows.Forms.Button()
        Me.FSHS_MIN_BTN = New System.Windows.Forms.Button()
        Me.FSHS_CNC_BTN = New System.Windows.Forms.Button()
        Me.FSHS_SAVE_BTN = New System.Windows.Forms.Button()
        Me.FSHS_NUM_TBX = New System.Windows.Forms.TextBox()
        Me.FAI_L_ITEM_NAME = New System.Windows.Forms.Label()
        Me.SEARCH_GRID = New System.Windows.Forms.DataGridView()
        Me.CK_COLUMN = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FSHS_ITEM_TBX = New System.Windows.Forms.TextBox()
        Me.FSHS_FLT1_TBX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FSHS_FLT2_TBX = New System.Windows.Forms.TextBox()
        Me.FSHS_FLT4_TBX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SEARCH_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FSHS_PRC_HOLD)
        Me.Panel1.Controls.Add(Me.FSHS_TRH_HOLD)
        Me.Panel1.Controls.Add(Me.FSHS_QTY_HOLD)
        Me.Panel1.Controls.Add(Me.FSHS_ID_HOLD)
        Me.Panel1.Controls.Add(Me.FSHS_HEAD_LBL)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(500, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 40)
        Me.Panel1.TabIndex = 2
        '
        'FSHS_PRC_HOLD
        '
        Me.FSHS_PRC_HOLD.AutoSize = True
        Me.FSHS_PRC_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_PRC_HOLD.Location = New System.Drawing.Point(365, 20)
        Me.FSHS_PRC_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSHS_PRC_HOLD.Name = "FSHS_PRC_HOLD"
        Me.FSHS_PRC_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSHS_PRC_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSHS_PRC_HOLD.TabIndex = 34
        Me.FSHS_PRC_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSHS_PRC_HOLD.Visible = False
        '
        'FSHS_TRH_HOLD
        '
        Me.FSHS_TRH_HOLD.AutoSize = True
        Me.FSHS_TRH_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_TRH_HOLD.Location = New System.Drawing.Point(365, 4)
        Me.FSHS_TRH_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSHS_TRH_HOLD.Name = "FSHS_TRH_HOLD"
        Me.FSHS_TRH_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSHS_TRH_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSHS_TRH_HOLD.TabIndex = 33
        Me.FSHS_TRH_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSHS_TRH_HOLD.Visible = False
        '
        'FSHS_QTY_HOLD
        '
        Me.FSHS_QTY_HOLD.AutoSize = True
        Me.FSHS_QTY_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_QTY_HOLD.Location = New System.Drawing.Point(375, 20)
        Me.FSHS_QTY_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSHS_QTY_HOLD.Name = "FSHS_QTY_HOLD"
        Me.FSHS_QTY_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSHS_QTY_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSHS_QTY_HOLD.TabIndex = 32
        Me.FSHS_QTY_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSHS_QTY_HOLD.Visible = False
        '
        'FSHS_ID_HOLD
        '
        Me.FSHS_ID_HOLD.AutoSize = True
        Me.FSHS_ID_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_ID_HOLD.Location = New System.Drawing.Point(375, 4)
        Me.FSHS_ID_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSHS_ID_HOLD.Name = "FSHS_ID_HOLD"
        Me.FSHS_ID_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSHS_ID_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSHS_ID_HOLD.TabIndex = 17
        Me.FSHS_ID_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSHS_ID_HOLD.Visible = False
        '
        'FSHS_HEAD_LBL
        '
        Me.FSHS_HEAD_LBL.AutoSize = True
        Me.FSHS_HEAD_LBL.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_HEAD_LBL.ForeColor = System.Drawing.SystemColors.Control
        Me.FSHS_HEAD_LBL.Location = New System.Drawing.Point(1, 6)
        Me.FSHS_HEAD_LBL.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.FSHS_HEAD_LBL.Name = "FSHS_HEAD_LBL"
        Me.FSHS_HEAD_LBL.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FSHS_HEAD_LBL.Size = New System.Drawing.Size(68, 28)
        Me.FSHS_HEAD_LBL.TabIndex = 31
        Me.FSHS_HEAD_LBL.Text = "TEXT"
        Me.FSHS_HEAD_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FSHS_ADD_BTN
        '
        Me.FSHS_ADD_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_ADD_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSHS_ADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_ADD_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_ADD_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSHS_ADD_BTN.Location = New System.Drawing.Point(149, 279)
        Me.FSHS_ADD_BTN.Name = "FSHS_ADD_BTN"
        Me.FSHS_ADD_BTN.Size = New System.Drawing.Size(25, 35)
        Me.FSHS_ADD_BTN.TabIndex = 39
        Me.FSHS_ADD_BTN.Text = "+"
        Me.FSHS_ADD_BTN.UseVisualStyleBackColor = False
        '
        'FSHS_MIN_BTN
        '
        Me.FSHS_MIN_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_MIN_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSHS_MIN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_MIN_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_MIN_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSHS_MIN_BTN.Location = New System.Drawing.Point(12, 279)
        Me.FSHS_MIN_BTN.Name = "FSHS_MIN_BTN"
        Me.FSHS_MIN_BTN.Size = New System.Drawing.Size(25, 35)
        Me.FSHS_MIN_BTN.TabIndex = 38
        Me.FSHS_MIN_BTN.Text = "-"
        Me.FSHS_MIN_BTN.UseVisualStyleBackColor = False
        '
        'FSHS_CNC_BTN
        '
        Me.FSHS_CNC_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_CNC_BTN.BackColor = System.Drawing.Color.DarkRed
        Me.FSHS_CNC_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.FSHS_CNC_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.FSHS_CNC_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_CNC_BTN.ForeColor = System.Drawing.SystemColors.Control
        Me.FSHS_CNC_BTN.Location = New System.Drawing.Point(259, 279)
        Me.FSHS_CNC_BTN.Name = "FSHS_CNC_BTN"
        Me.FSHS_CNC_BTN.Size = New System.Drawing.Size(75, 35)
        Me.FSHS_CNC_BTN.TabIndex = 37
        Me.FSHS_CNC_BTN.Text = "CANCEL"
        Me.FSHS_CNC_BTN.UseVisualStyleBackColor = False
        '
        'FSHS_SAVE_BTN
        '
        Me.FSHS_SAVE_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_SAVE_BTN.BackColor = System.Drawing.Color.Green
        Me.FSHS_SAVE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.FSHS_SAVE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.FSHS_SAVE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_SAVE_BTN.ForeColor = System.Drawing.SystemColors.Control
        Me.FSHS_SAVE_BTN.Location = New System.Drawing.Point(340, 279)
        Me.FSHS_SAVE_BTN.Name = "FSHS_SAVE_BTN"
        Me.FSHS_SAVE_BTN.Size = New System.Drawing.Size(75, 35)
        Me.FSHS_SAVE_BTN.TabIndex = 36
        Me.FSHS_SAVE_BTN.Text = "SAVE"
        Me.FSHS_SAVE_BTN.UseVisualStyleBackColor = False
        '
        'FSHS_NUM_TBX
        '
        Me.FSHS_NUM_TBX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_NUM_TBX.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_NUM_TBX.Location = New System.Drawing.Point(43, 279)
        Me.FSHS_NUM_TBX.MaximumSize = New System.Drawing.Size(100, 35)
        Me.FSHS_NUM_TBX.MinimumSize = New System.Drawing.Size(100, 35)
        Me.FSHS_NUM_TBX.Name = "FSHS_NUM_TBX"
        Me.FSHS_NUM_TBX.Size = New System.Drawing.Size(100, 34)
        Me.FSHS_NUM_TBX.TabIndex = 35
        Me.FSHS_NUM_TBX.Text = "0"
        Me.FSHS_NUM_TBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FAI_L_ITEM_NAME
        '
        Me.FAI_L_ITEM_NAME.AutoSize = True
        Me.FAI_L_ITEM_NAME.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_NAME.Location = New System.Drawing.Point(9, 49)
        Me.FAI_L_ITEM_NAME.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_NAME.Name = "FAI_L_ITEM_NAME"
        Me.FAI_L_ITEM_NAME.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_NAME.Size = New System.Drawing.Size(74, 16)
        Me.FAI_L_ITEM_NAME.TabIndex = 41
        Me.FAI_L_ITEM_NAME.Text = "ITEM NAME"
        Me.FAI_L_ITEM_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SEARCH_GRID
        '
        Me.SEARCH_GRID.AllowUserToAddRows = False
        Me.SEARCH_GRID.AllowUserToDeleteRows = False
        Me.SEARCH_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SEARCH_GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.SEARCH_GRID.BackgroundColor = System.Drawing.SystemColors.Window
        Me.SEARCH_GRID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SEARCH_GRID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SEARCH_GRID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SEARCH_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SEARCH_GRID.ColumnHeadersVisible = False
        Me.SEARCH_GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CK_COLUMN})
        Me.SEARCH_GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SEARCH_GRID.Location = New System.Drawing.Point(0, 0)
        Me.SEARCH_GRID.Margin = New System.Windows.Forms.Padding(0)
        Me.SEARCH_GRID.MultiSelect = False
        Me.SEARCH_GRID.Name = "SEARCH_GRID"
        Me.SEARCH_GRID.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SEARCH_GRID.RowHeadersVisible = False
        Me.SEARCH_GRID.Size = New System.Drawing.Size(403, 121)
        Me.SEARCH_GRID.TabIndex = 42
        '
        'CK_COLUMN
        '
        Me.CK_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CK_COLUMN.HeaderText = "*"
        Me.CK_COLUMN.Name = "CK_COLUMN"
        Me.CK_COLUMN.Width = 5
        '
        'FSHS_ITEM_TBX
        '
        Me.FSHS_ITEM_TBX.Font = New System.Drawing.Font("Roobert Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_ITEM_TBX.Location = New System.Drawing.Point(12, 69)
        Me.FSHS_ITEM_TBX.Name = "FSHS_ITEM_TBX"
        Me.FSHS_ITEM_TBX.Size = New System.Drawing.Size(403, 27)
        Me.FSHS_ITEM_TBX.TabIndex = 1
        '
        'FSHS_FLT1_TBX
        '
        Me.FSHS_FLT1_TBX.Font = New System.Drawing.Font("Roobert Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_FLT1_TBX.ForeColor = System.Drawing.SystemColors.GrayText
        Me.FSHS_FLT1_TBX.Location = New System.Drawing.Point(12, 119)
        Me.FSHS_FLT1_TBX.Name = "FSHS_FLT1_TBX"
        Me.FSHS_FLT1_TBX.ReadOnly = True
        Me.FSHS_FLT1_TBX.Size = New System.Drawing.Size(200, 27)
        Me.FSHS_FLT1_TBX.TabIndex = 2
        Me.FSHS_FLT1_TBX.Text = "BRAND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "NARROW BY:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FSHS_FLT2_TBX
        '
        Me.FSHS_FLT2_TBX.Font = New System.Drawing.Font("Roobert Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_FLT2_TBX.ForeColor = System.Drawing.SystemColors.GrayText
        Me.FSHS_FLT2_TBX.Location = New System.Drawing.Point(215, 119)
        Me.FSHS_FLT2_TBX.Name = "FSHS_FLT2_TBX"
        Me.FSHS_FLT2_TBX.ReadOnly = True
        Me.FSHS_FLT2_TBX.Size = New System.Drawing.Size(200, 27)
        Me.FSHS_FLT2_TBX.TabIndex = 3
        Me.FSHS_FLT2_TBX.Text = "VARIANT"
        '
        'FSHS_FLT4_TBX
        '
        Me.FSHS_FLT4_TBX.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FSHS_FLT4_TBX.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_FLT4_TBX.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FSHS_FLT4_TBX.Location = New System.Drawing.Point(421, 69)
        Me.FSHS_FLT4_TBX.Name = "FSHS_FLT4_TBX"
        Me.FSHS_FLT4_TBX.Size = New System.Drawing.Size(131, 25)
        Me.FSHS_FLT4_TBX.TabIndex = 48
        Me.FSHS_FLT4_TBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(418, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "STOCK LEVEL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.SEARCH_GRID)
        Me.Panel2.Location = New System.Drawing.Point(12, 152)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 121)
        Me.Panel2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "NEW STOCK LEVEL:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.Font = New System.Drawing.Font("Tw Cen MT", 18.0!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.Location = New System.Drawing.Point(421, 280)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 34)
        Me.TextBox1.TabIndex = 51
        '
        'Form_Stock_HS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(562, 326)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FSHS_FLT4_TBX)
        Me.Controls.Add(Me.FSHS_FLT2_TBX)
        Me.Controls.Add(Me.FSHS_FLT1_TBX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FSHS_ITEM_TBX)
        Me.Controls.Add(Me.FAI_L_ITEM_NAME)
        Me.Controls.Add(Me.FSHS_ADD_BTN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FSHS_MIN_BTN)
        Me.Controls.Add(Me.FSHS_CNC_BTN)
        Me.Controls.Add(Me.FSHS_NUM_TBX)
        Me.Controls.Add(Me.FSHS_SAVE_BTN)
        Me.Name = "Form_Stock_HS"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Stock_HS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SEARCH_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FSHS_PRC_HOLD As Label
    Friend WithEvents FSHS_TRH_HOLD As Label
    Friend WithEvents FSHS_QTY_HOLD As Label
    Friend WithEvents FSHS_ID_HOLD As Label
    Friend WithEvents FSHS_HEAD_LBL As Label
    Friend WithEvents FSHS_ADD_BTN As Button
    Friend WithEvents FSHS_MIN_BTN As Button
    Friend WithEvents FSHS_CNC_BTN As Button
    Friend WithEvents FSHS_SAVE_BTN As Button
    Friend WithEvents FSHS_NUM_TBX As TextBox
    Friend WithEvents FAI_L_ITEM_NAME As Label
    Friend WithEvents SEARCH_GRID As DataGridView
    Friend WithEvents FSHS_ITEM_TBX As TextBox
    Friend WithEvents CK_COLUMN As DataGridViewCheckBoxColumn
    Friend WithEvents FSHS_FLT1_TBX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FSHS_FLT2_TBX As TextBox
    Friend WithEvents FSHS_FLT4_TBX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
