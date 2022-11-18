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
        Me.FSIS_ADD_BTN = New System.Windows.Forms.Button()
        Me.FSIS_MIN_BTN = New System.Windows.Forms.Button()
        Me.FSIS_CNC_BTN = New System.Windows.Forms.Button()
        Me.FSIS_SAVE_BTN = New System.Windows.Forms.Button()
        Me.FSIS_NUM_TBX = New System.Windows.Forms.TextBox()
        Me.FAI_L_ITEM_NAME = New System.Windows.Forms.Label()
        Me.SEARCH_GRID = New System.Windows.Forms.DataGridView()
        Me.FSHS_ITEM_TBX = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SEARCH_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(400, 40)
        Me.Panel1.MinimumSize = New System.Drawing.Size(500, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 40)
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
        'FSIS_ADD_BTN
        '
        Me.FSIS_ADD_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSIS_ADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSIS_ADD_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_ADD_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSIS_ADD_BTN.Location = New System.Drawing.Point(149, 237)
        Me.FSIS_ADD_BTN.Name = "FSIS_ADD_BTN"
        Me.FSIS_ADD_BTN.Size = New System.Drawing.Size(25, 35)
        Me.FSIS_ADD_BTN.TabIndex = 39
        Me.FSIS_ADD_BTN.Text = "+"
        Me.FSIS_ADD_BTN.UseVisualStyleBackColor = False
        '
        'FSIS_MIN_BTN
        '
        Me.FSIS_MIN_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSIS_MIN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSIS_MIN_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_MIN_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSIS_MIN_BTN.Location = New System.Drawing.Point(12, 237)
        Me.FSIS_MIN_BTN.Name = "FSIS_MIN_BTN"
        Me.FSIS_MIN_BTN.Size = New System.Drawing.Size(25, 35)
        Me.FSIS_MIN_BTN.TabIndex = 38
        Me.FSIS_MIN_BTN.Text = "-"
        Me.FSIS_MIN_BTN.UseVisualStyleBackColor = False
        '
        'FSIS_CNC_BTN
        '
        Me.FSIS_CNC_BTN.BackColor = System.Drawing.Color.DarkRed
        Me.FSIS_CNC_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.FSIS_CNC_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.FSIS_CNC_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSIS_CNC_BTN.ForeColor = System.Drawing.SystemColors.Control
        Me.FSIS_CNC_BTN.Location = New System.Drawing.Point(279, 237)
        Me.FSIS_CNC_BTN.Name = "FSIS_CNC_BTN"
        Me.FSIS_CNC_BTN.Size = New System.Drawing.Size(75, 35)
        Me.FSIS_CNC_BTN.TabIndex = 37
        Me.FSIS_CNC_BTN.Text = "CANCEL"
        Me.FSIS_CNC_BTN.UseVisualStyleBackColor = False
        '
        'FSIS_SAVE_BTN
        '
        Me.FSIS_SAVE_BTN.BackColor = System.Drawing.Color.Green
        Me.FSIS_SAVE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.FSIS_SAVE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.FSIS_SAVE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSIS_SAVE_BTN.ForeColor = System.Drawing.SystemColors.Control
        Me.FSIS_SAVE_BTN.Location = New System.Drawing.Point(360, 237)
        Me.FSIS_SAVE_BTN.Name = "FSIS_SAVE_BTN"
        Me.FSIS_SAVE_BTN.Size = New System.Drawing.Size(75, 35)
        Me.FSIS_SAVE_BTN.TabIndex = 36
        Me.FSIS_SAVE_BTN.Text = "SAVE"
        Me.FSIS_SAVE_BTN.UseVisualStyleBackColor = False
        '
        'FSIS_NUM_TBX
        '
        Me.FSIS_NUM_TBX.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_NUM_TBX.Location = New System.Drawing.Point(43, 237)
        Me.FSIS_NUM_TBX.MaximumSize = New System.Drawing.Size(100, 35)
        Me.FSIS_NUM_TBX.MinimumSize = New System.Drawing.Size(100, 35)
        Me.FSIS_NUM_TBX.Name = "FSIS_NUM_TBX"
        Me.FSIS_NUM_TBX.Size = New System.Drawing.Size(100, 35)
        Me.FSIS_NUM_TBX.TabIndex = 35
        Me.FSIS_NUM_TBX.Text = "0"
        Me.FSIS_NUM_TBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.SEARCH_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SEARCH_GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.SEARCH_GRID.BackgroundColor = System.Drawing.SystemColors.Control
        Me.SEARCH_GRID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SEARCH_GRID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SEARCH_GRID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SEARCH_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SEARCH_GRID.ColumnHeadersVisible = False
        Me.SEARCH_GRID.Location = New System.Drawing.Point(12, 96)
        Me.SEARCH_GRID.Margin = New System.Windows.Forms.Padding(0)
        Me.SEARCH_GRID.Name = "SEARCH_GRID"
        Me.SEARCH_GRID.Size = New System.Drawing.Size(423, 138)
        Me.SEARCH_GRID.TabIndex = 42
        '
        'FSHS_ITEM_TBX
        '
        Me.FSHS_ITEM_TBX.Font = New System.Drawing.Font("Roobert Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_ITEM_TBX.Location = New System.Drawing.Point(12, 69)
        Me.FSHS_ITEM_TBX.Name = "FSHS_ITEM_TBX"
        Me.FSHS_ITEM_TBX.Size = New System.Drawing.Size(423, 27)
        Me.FSHS_ITEM_TBX.TabIndex = 43
        '
        'Form_Stock_HS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 284)
        Me.Controls.Add(Me.FSHS_ITEM_TBX)
        Me.Controls.Add(Me.SEARCH_GRID)
        Me.Controls.Add(Me.FAI_L_ITEM_NAME)
        Me.Controls.Add(Me.FSIS_ADD_BTN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FSIS_MIN_BTN)
        Me.Controls.Add(Me.FSIS_CNC_BTN)
        Me.Controls.Add(Me.FSIS_NUM_TBX)
        Me.Controls.Add(Me.FSIS_SAVE_BTN)
        Me.Name = "Form_Stock_HS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Stock_HS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SEARCH_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FSHS_PRC_HOLD As Label
    Friend WithEvents FSHS_TRH_HOLD As Label
    Friend WithEvents FSHS_QTY_HOLD As Label
    Friend WithEvents FSHS_ID_HOLD As Label
    Friend WithEvents FSHS_HEAD_LBL As Label
    Friend WithEvents FSIS_ADD_BTN As Button
    Friend WithEvents FSIS_MIN_BTN As Button
    Friend WithEvents FSIS_CNC_BTN As Button
    Friend WithEvents FSIS_SAVE_BTN As Button
    Friend WithEvents FSIS_NUM_TBX As TextBox
    Friend WithEvents FAI_L_ITEM_NAME As Label
    Friend WithEvents SEARCH_GRID As DataGridView
    Friend WithEvents FSHS_ITEM_TBX As TextBox
End Class
