<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Valuation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FSIS_PRC_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_TRH_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_QTY_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_ID_HOLD = New System.Windows.Forms.Label()
        Me.FV_HEAD_LBL = New System.Windows.Forms.Label()
        Me.VALUE_GRID = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.VALUE_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FSIS_PRC_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_TRH_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_QTY_HOLD)
        Me.Panel1.Controls.Add(Me.FSIS_ID_HOLD)
        Me.Panel1.Controls.Add(Me.FV_HEAD_LBL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(0, 40)
        Me.Panel1.MinimumSize = New System.Drawing.Size(400, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 40)
        Me.Panel1.TabIndex = 2
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
        'FV_HEAD_LBL
        '
        Me.FV_HEAD_LBL.AutoSize = True
        Me.FV_HEAD_LBL.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FV_HEAD_LBL.ForeColor = System.Drawing.SystemColors.Control
        Me.FV_HEAD_LBL.Location = New System.Drawing.Point(1, 6)
        Me.FV_HEAD_LBL.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.FV_HEAD_LBL.Name = "FV_HEAD_LBL"
        Me.FV_HEAD_LBL.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FV_HEAD_LBL.Size = New System.Drawing.Size(68, 28)
        Me.FV_HEAD_LBL.TabIndex = 31
        Me.FV_HEAD_LBL.Text = "TEXT"
        Me.FV_HEAD_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VALUE_GRID
        '
        Me.VALUE_GRID.AllowUserToAddRows = False
        Me.VALUE_GRID.AllowUserToDeleteRows = False
        Me.VALUE_GRID.AllowUserToResizeColumns = False
        Me.VALUE_GRID.AllowUserToResizeRows = False
        Me.VALUE_GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.VALUE_GRID.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VALUE_GRID.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VALUE_GRID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VALUE_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VALUE_GRID.DefaultCellStyle = DataGridViewCellStyle2
        Me.VALUE_GRID.Location = New System.Drawing.Point(12, 47)
        Me.VALUE_GRID.Name = "VALUE_GRID"
        Me.VALUE_GRID.ReadOnly = True
        Me.VALUE_GRID.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VALUE_GRID.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.VALUE_GRID.Size = New System.Drawing.Size(760, 340)
        Me.VALUE_GRID.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(673, 400)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(583, 400)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(313, 400)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 40)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(413, 400)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 40)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(112, 49)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TOTALS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(12, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 3)
        Me.Panel2.TabIndex = 33
        '
        'Form_Valuation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VALUE_GRID)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Form_Valuation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Valuation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VALUE_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FSIS_PRC_HOLD As Label
    Friend WithEvents FSIS_TRH_HOLD As Label
    Friend WithEvents FSIS_QTY_HOLD As Label
    Friend WithEvents FSIS_ID_HOLD As Label
    Friend WithEvents FV_HEAD_LBL As Label
    Friend WithEvents VALUE_GRID As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
End Class
