<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reorder_Points
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.REORDER_GRID = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FSIS_PRC_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_TRH_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_QTY_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_ID_HOLD = New System.Windows.Forms.Label()
        Me.RO_HEAD_LBL = New System.Windows.Forms.Label()
        Me.COL1_TT_LBL = New System.Windows.Forms.Label()
        Me.COL2_TT_LBL = New System.Windows.Forms.Label()
        CType(Me.REORDER_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(18, 390)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 3)
        Me.Panel2.TabIndex = 36
        '
        'REORDER_GRID
        '
        Me.REORDER_GRID.AllowUserToAddRows = False
        Me.REORDER_GRID.AllowUserToDeleteRows = False
        Me.REORDER_GRID.AllowUserToResizeColumns = False
        Me.REORDER_GRID.AllowUserToResizeRows = False
        Me.REORDER_GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.REORDER_GRID.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.REORDER_GRID.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.REORDER_GRID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.REORDER_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.REORDER_GRID.DefaultCellStyle = DataGridViewCellStyle8
        Me.REORDER_GRID.Location = New System.Drawing.Point(18, 47)
        Me.REORDER_GRID.Name = "REORDER_GRID"
        Me.REORDER_GRID.ReadOnly = True
        Me.REORDER_GRID.RowHeadersVisible = False
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.REORDER_GRID.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.REORDER_GRID.Size = New System.Drawing.Size(849, 338)
        Me.REORDER_GRID.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FSIS_PRC_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_TRH_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_QTY_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_ID_HOLD)
        Me.Panel1.Controls.Add(Me.RO_HEAD_LBL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Panel1.MinimumSize = New System.Drawing.Size(400, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 40)
        Me.Panel1.TabIndex = 34
        '
        'FSIS_PRC_HOLD
        '
        Me.FSIS_PRC_HOLD.AutoSize = True
        Me.FSIS_PRC_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_PRC_HOLD.Location = New System.Drawing.Point(365, 20)
        Me.FSIS_PRC_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSIS_PRC_HOLD.Name = "FSIS_PRC_HOLD"
        Me.FSIS_PRC_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSIS_PRC_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSIS_PRC_HOLD.TabIndex = 34
        Me.FSIS_PRC_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSIS_PRC_HOLD.Visible = False
        '
        'FSIS_TRH_HOLD
        '
        Me.FSIS_TRH_HOLD.AutoSize = True
        Me.FSIS_TRH_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_TRH_HOLD.Location = New System.Drawing.Point(365, 4)
        Me.FSIS_TRH_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSIS_TRH_HOLD.Name = "FSIS_TRH_HOLD"
        Me.FSIS_TRH_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSIS_TRH_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSIS_TRH_HOLD.TabIndex = 33
        Me.FSIS_TRH_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSIS_TRH_HOLD.Visible = False
        '
        'FSIS_QTY_HOLD
        '
        Me.FSIS_QTY_HOLD.AutoSize = True
        Me.FSIS_QTY_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_QTY_HOLD.Location = New System.Drawing.Point(375, 20)
        Me.FSIS_QTY_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSIS_QTY_HOLD.Name = "FSIS_QTY_HOLD"
        Me.FSIS_QTY_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSIS_QTY_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSIS_QTY_HOLD.TabIndex = 32
        Me.FSIS_QTY_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSIS_QTY_HOLD.Visible = False
        '
        'FSIS_ID_HOLD
        '
        Me.FSIS_ID_HOLD.AutoSize = True
        Me.FSIS_ID_HOLD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSIS_ID_HOLD.Location = New System.Drawing.Point(375, 4)
        Me.FSIS_ID_HOLD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FSIS_ID_HOLD.Name = "FSIS_ID_HOLD"
        Me.FSIS_ID_HOLD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FSIS_ID_HOLD.Size = New System.Drawing.Size(2, 16)
        Me.FSIS_ID_HOLD.TabIndex = 17
        Me.FSIS_ID_HOLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSIS_ID_HOLD.Visible = False
        '
        'RO_HEAD_LBL
        '
        Me.RO_HEAD_LBL.AutoSize = True
        Me.RO_HEAD_LBL.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RO_HEAD_LBL.ForeColor = System.Drawing.SystemColors.Control
        Me.RO_HEAD_LBL.Location = New System.Drawing.Point(1, 6)
        Me.RO_HEAD_LBL.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.RO_HEAD_LBL.Name = "RO_HEAD_LBL"
        Me.RO_HEAD_LBL.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.RO_HEAD_LBL.Size = New System.Drawing.Size(206, 28)
        Me.RO_HEAD_LBL.TabIndex = 31
        Me.RO_HEAD_LBL.Text = "LOW STOCK ITEMS"
        Me.RO_HEAD_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COL1_TT_LBL
        '
        Me.COL1_TT_LBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.COL1_TT_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COL1_TT_LBL.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL1_TT_LBL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.COL1_TT_LBL.Location = New System.Drawing.Point(600, 396)
        Me.COL1_TT_LBL.Margin = New System.Windows.Forms.Padding(0)
        Me.COL1_TT_LBL.Name = "COL1_TT_LBL"
        Me.COL1_TT_LBL.Size = New System.Drawing.Size(66, 40)
        Me.COL1_TT_LBL.TabIndex = 38
        Me.COL1_TT_LBL.Text = "Label4"
        Me.COL1_TT_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COL2_TT_LBL
        '
        Me.COL2_TT_LBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.COL2_TT_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COL2_TT_LBL.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COL2_TT_LBL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.COL2_TT_LBL.Location = New System.Drawing.Point(751, 396)
        Me.COL2_TT_LBL.Margin = New System.Windows.Forms.Padding(0)
        Me.COL2_TT_LBL.Name = "COL2_TT_LBL"
        Me.COL2_TT_LBL.Size = New System.Drawing.Size(96, 40)
        Me.COL2_TT_LBL.TabIndex = 37
        Me.COL2_TT_LBL.Text = "Label2"
        Me.COL2_TT_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reorder_Points
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(884, 460)
        Me.Controls.Add(Me.COL1_TT_LBL)
        Me.Controls.Add(Me.COL2_TT_LBL)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.REORDER_GRID)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(900, 499)
        Me.MinimumSize = New System.Drawing.Size(900, 499)
        Me.Name = "Reorder_Points"
        Me.Text = "Reorder_Points"
        CType(Me.REORDER_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents REORDER_GRID As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FSIS_PRC_HOLD As Label
    Friend WithEvents FSIS_TRH_HOLD As Label
    Friend WithEvents FSIS_QTY_HOLD As Label
    Friend WithEvents FSIS_ID_HOLD As Label
    Friend WithEvents RO_HEAD_LBL As Label
    Friend WithEvents COL1_TT_LBL As Label
    Friend WithEvents COL2_TT_LBL As Label
End Class
