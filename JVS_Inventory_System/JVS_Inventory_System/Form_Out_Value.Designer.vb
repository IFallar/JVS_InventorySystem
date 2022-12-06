<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Out_Value
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Out_Value))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FSIS_PRC_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_TRH_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_QTY_HOLD = New System.Windows.Forms.Label()
        Me.FSIS_ID_HOLD = New System.Windows.Forms.Label()
        Me.FV_HEAD_LBL = New System.Windows.Forms.Label()
        Me.LowerDate = New System.Windows.Forms.DateTimePicker()
        Me.Upper_Date = New System.Windows.Forms.DateTimePicker()
        Me.Range_Panel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date_Rng_CBX = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TTV_TT = New System.Windows.Forms.Label()
        Me.QTY_TT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Range_Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(12, 477)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 3)
        Me.Panel2.TabIndex = 36
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
        Me.Panel1.Size = New System.Drawing.Size(574, 40)
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
        'LowerDate
        '
        Me.LowerDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LowerDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.LowerDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LowerDate.Location = New System.Drawing.Point(17, 0)
        Me.LowerDate.Name = "LowerDate"
        Me.LowerDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LowerDate.Size = New System.Drawing.Size(127, 29)
        Me.LowerDate.TabIndex = 37
        Me.LowerDate.Value = New Date(2022, 11, 27, 0, 0, 0, 0)
        '
        'Upper_Date
        '
        Me.Upper_Date.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Upper_Date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Upper_Date.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Upper_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Upper_Date.Location = New System.Drawing.Point(147, 0)
        Me.Upper_Date.Name = "Upper_Date"
        Me.Upper_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Upper_Date.Size = New System.Drawing.Size(127, 29)
        Me.Upper_Date.TabIndex = 38
        Me.Upper_Date.Value = New Date(2022, 11, 27, 0, 0, 0, 0)
        '
        'Range_Panel
        '
        Me.Range_Panel.Controls.Add(Me.Panel5)
        Me.Range_Panel.Controls.Add(Me.Panel4)
        Me.Range_Panel.Controls.Add(Me.LowerDate)
        Me.Range_Panel.Controls.Add(Me.Upper_Date)
        Me.Range_Panel.Location = New System.Drawing.Point(12, 84)
        Me.Range_Panel.Name = "Range_Panel"
        Me.Range_Panel.Size = New System.Drawing.Size(355, 29)
        Me.Range_Panel.TabIndex = 40
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(-6, -10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(19, 46)
        Me.Panel5.TabIndex = 41
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(278, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(74, 29)
        Me.Panel4.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, -8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 44)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "RANGE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_Rng_CBX
        '
        Me.Date_Rng_CBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Date_Rng_CBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Date_Rng_CBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Date_Rng_CBX.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Date_Rng_CBX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Date_Rng_CBX.FormattingEnabled = True
        Me.Date_Rng_CBX.Items.AddRange(New Object() {"7 Days", "14 Days", "30 Days", "6 Months", "1 Year"})
        Me.Date_Rng_CBX.Location = New System.Drawing.Point(26, 84)
        Me.Date_Rng_CBX.Margin = New System.Windows.Forms.Padding(5, 3, 0, 10)
        Me.Date_Rng_CBX.MaximumSize = New System.Drawing.Size(140, 0)
        Me.Date_Rng_CBX.MinimumSize = New System.Drawing.Size(120, 0)
        Me.Date_Rng_CBX.Name = "Date_Rng_CBX"
        Me.Date_Rng_CBX.Size = New System.Drawing.Size(120, 29)
        Me.Date_Rng_CBX.TabIndex = 41
        Me.Date_Rng_CBX.Text = "Range:"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(149, 84)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(34, 29)
        Me.Panel6.TabIndex = 42
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Location = New System.Drawing.Point(149, 84)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(62, 29)
        Me.Panel8.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, -8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 44)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "DATES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(1, 5, 1, 5)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView2.MaximumSize = New System.Drawing.Size(850, 400)
        Me.DataGridView2.MinimumSize = New System.Drawing.Size(550, 200)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Bahnschrift", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView2.Size = New System.Drawing.Size(550, 352)
        Me.DataGridView2.TabIndex = 43
        Me.DataGridView2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(533, 85)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TTV_TT
        '
        Me.TTV_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTV_TT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TTV_TT.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTV_TT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TTV_TT.Location = New System.Drawing.Point(310, 498)
        Me.TTV_TT.Margin = New System.Windows.Forms.Padding(0)
        Me.TTV_TT.Name = "TTV_TT"
        Me.TTV_TT.Size = New System.Drawing.Size(252, 46)
        Me.TTV_TT.TabIndex = 45
        Me.TTV_TT.Text = "Label4"
        Me.TTV_TT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QTY_TT
        '
        Me.QTY_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QTY_TT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QTY_TT.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTY_TT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.QTY_TT.Location = New System.Drawing.Point(129, 498)
        Me.QTY_TT.Margin = New System.Windows.Forms.Padding(0)
        Me.QTY_TT.Name = "QTY_TT"
        Me.QTY_TT.Size = New System.Drawing.Size(175, 46)
        Me.QTY_TT.TabIndex = 46
        Me.QTY_TT.Text = "Label4"
        Me.QTY_TT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(310, 485)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "TOTAL VALUE:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(129, 485)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 18)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "TOTAL QUANTITY:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 485)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 59)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "TOTAL:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Out_Value
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 551)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QTY_TT)
        Me.Controls.Add(Me.TTV_TT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Range_Panel)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Date_Rng_CBX)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(590, 590)
        Me.MinimumSize = New System.Drawing.Size(590, 590)
        Me.Name = "Form_Out_Value"
        Me.Text = "RETRIEVED ITEMS REPORT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Range_Panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FSIS_PRC_HOLD As Label
    Friend WithEvents FSIS_TRH_HOLD As Label
    Friend WithEvents FSIS_QTY_HOLD As Label
    Friend WithEvents FSIS_ID_HOLD As Label
    Friend WithEvents FV_HEAD_LBL As Label
    Friend WithEvents LowerDate As DateTimePicker
    Friend WithEvents Upper_Date As DateTimePicker
    Friend WithEvents Range_Panel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Date_Rng_CBX As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TTV_TT As Label
    Friend WithEvents QTY_TT As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
