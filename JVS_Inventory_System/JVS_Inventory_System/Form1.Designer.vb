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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SIDE_HOME_BTN = New System.Windows.Forms.Button()
        Me.SIDE_LOG_BTN = New System.Windows.Forms.Button()
        Me.SIDE_ITEM_BTN = New System.Windows.Forms.Button()
        Me.Base_Panel = New System.Windows.Forms.Panel()
        Me.ITEM_PANEL = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ITM_SEARCH_TBX = New System.Windows.Forms.TextBox()
        Me.ITM_CAT_ITEM_CBX = New System.Windows.Forms.ComboBox()
        Me.ITM_STOCKOUT_ITEM_BTN = New System.Windows.Forms.Button()
        Me.ITM_FLT_ITEM_CBX = New System.Windows.Forms.ComboBox()
        Me.ITM_STOCKIN_ITEM_BTN = New System.Windows.Forms.Button()
        Me.ITM_SEARCH_BTN = New System.Windows.Forms.Button()
        Me.ITM_FLAG_ITEM_BTN = New System.Windows.Forms.Button()
        Me.ITM_EDIT_ITEM_BTN = New System.Windows.Forms.Button()
        Me.ITM_DELETE_ITEM_BTN = New System.Windows.Forms.Button()
        Me.ITM_ADD_ITEM_BTN = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbx_column = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOG_PANEL = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HOME_PANEL = New System.Windows.Forms.Panel()
        Me.APP_LABEL = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.INFO_LBL_ITEMS = New System.Windows.Forms.Panel()
        Me.HEADER_ITEMS = New System.Windows.Forms.Label()
        Me.VALUE_ITEMS = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.HEADER_LASTSTOCK = New System.Windows.Forms.Label()
        Me.VALUE_LASTSTOCK = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HEADER_COUNT = New System.Windows.Forms.Label()
        Me.VALUE_COUNT = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.HEADER_LOWSTOCK = New System.Windows.Forms.Label()
        Me.VALUE_LOWSTOCK = New System.Windows.Forms.Button()
        Me.DAY_LOG_PANEL = New System.Windows.Forms.Panel()
        Me.DO_LIST = New System.Windows.Forms.ListBox()
        Me.DO_LABEL = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HOME_STOCK_IN_BTN = New System.Windows.Forms.Button()
        Me.HOME_ADD_ITEM_BTN = New System.Windows.Forms.Button()
        Me.HOME_INVENTORY_LOG_BTN = New System.Windows.Forms.Button()
        Me.HOME_STOCK_OUT_BTN = New System.Windows.Forms.Button()
        Me.ITM_FLTR_BTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Base_Panel.SuspendLayout()
        Me.ITEM_PANEL.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LOG_PANEL.SuspendLayout()
        Me.HOME_PANEL.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.INFO_LBL_ITEMS.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.DAY_LOG_PANEL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SIDE_HOME_BTN)
        Me.Panel1.Controls.Add(Me.SIDE_LOG_BTN)
        Me.Panel1.Controls.Add(Me.SIDE_ITEM_BTN)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 661)
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
        Me.SIDE_HOME_BTN.Location = New System.Drawing.Point(43, 292)
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
        Me.SIDE_LOG_BTN.Location = New System.Drawing.Point(43, 440)
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
        Me.SIDE_ITEM_BTN.Location = New System.Drawing.Point(43, 366)
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
        Me.Base_Panel.Controls.Add(Me.ITEM_PANEL)
        Me.Base_Panel.Controls.Add(Me.LOG_PANEL)
        Me.Base_Panel.Controls.Add(Me.HOME_PANEL)
        Me.Base_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Base_Panel.Location = New System.Drawing.Point(223, 0)
        Me.Base_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Base_Panel.Name = "Base_Panel"
        Me.Base_Panel.Size = New System.Drawing.Size(881, 661)
        Me.Base_Panel.TabIndex = 2
        '
        'ITEM_PANEL
        '
        Me.ITEM_PANEL.Controls.Add(Me.Panel8)
        Me.ITEM_PANEL.Controls.Add(Me.ITM_FLAG_ITEM_BTN)
        Me.ITEM_PANEL.Controls.Add(Me.ITM_EDIT_ITEM_BTN)
        Me.ITEM_PANEL.Controls.Add(Me.ITM_DELETE_ITEM_BTN)
        Me.ITEM_PANEL.Controls.Add(Me.ITM_ADD_ITEM_BTN)
        Me.ITEM_PANEL.Controls.Add(Me.Panel7)
        Me.ITEM_PANEL.Controls.Add(Me.Label1)
        Me.ITEM_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITEM_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.ITEM_PANEL.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.ITEM_PANEL.Name = "ITEM_PANEL"
        Me.ITEM_PANEL.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ITEM_PANEL.Size = New System.Drawing.Size(881, 661)
        Me.ITEM_PANEL.TabIndex = 0
        Me.ITEM_PANEL.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.ITM_FLTR_BTN)
        Me.Panel8.Controls.Add(Me.ITM_SEARCH_TBX)
        Me.Panel8.Controls.Add(Me.ITM_CAT_ITEM_CBX)
        Me.Panel8.Controls.Add(Me.ITM_STOCKOUT_ITEM_BTN)
        Me.Panel8.Controls.Add(Me.ITM_FLT_ITEM_CBX)
        Me.Panel8.Controls.Add(Me.ITM_STOCKIN_ITEM_BTN)
        Me.Panel8.Controls.Add(Me.ITM_SEARCH_BTN)
        Me.Panel8.Location = New System.Drawing.Point(15, 47)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(850, 46)
        Me.Panel8.TabIndex = 16
        '
        'ITM_SEARCH_TBX
        '
        Me.ITM_SEARCH_TBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ITM_SEARCH_TBX.Font = New System.Drawing.Font("Bahnschrift", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_SEARCH_TBX.Location = New System.Drawing.Point(185, 13)
        Me.ITM_SEARCH_TBX.Margin = New System.Windows.Forms.Padding(5, 3, 0, 5)
        Me.ITM_SEARCH_TBX.MaximumSize = New System.Drawing.Size(310, 30)
        Me.ITM_SEARCH_TBX.MinimumSize = New System.Drawing.Size(310, 30)
        Me.ITM_SEARCH_TBX.Name = "ITM_SEARCH_TBX"
        Me.ITM_SEARCH_TBX.Size = New System.Drawing.Size(310, 30)
        Me.ITM_SEARCH_TBX.TabIndex = 14
        '
        'ITM_CAT_ITEM_CBX
        '
        Me.ITM_CAT_ITEM_CBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ITM_CAT_ITEM_CBX.Font = New System.Drawing.Font("Bahnschrift", 13.0!)
        Me.ITM_CAT_ITEM_CBX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ITM_CAT_ITEM_CBX.FormattingEnabled = True
        Me.ITM_CAT_ITEM_CBX.Items.AddRange(New Object() {"Brand", "Category", "Holding Status", "Repair Status", "Stock Status"})
        Me.ITM_CAT_ITEM_CBX.Location = New System.Drawing.Point(534, 13)
        Me.ITM_CAT_ITEM_CBX.Margin = New System.Windows.Forms.Padding(5, 3, 5, 10)
        Me.ITM_CAT_ITEM_CBX.MaximumSize = New System.Drawing.Size(140, 0)
        Me.ITM_CAT_ITEM_CBX.MinimumSize = New System.Drawing.Size(140, 0)
        Me.ITM_CAT_ITEM_CBX.Name = "ITM_CAT_ITEM_CBX"
        Me.ITM_CAT_ITEM_CBX.Size = New System.Drawing.Size(140, 29)
        Me.ITM_CAT_ITEM_CBX.TabIndex = 13
        Me.ITM_CAT_ITEM_CBX.Text = "Filter By:"
        '
        'ITM_STOCKOUT_ITEM_BTN
        '
        Me.ITM_STOCKOUT_ITEM_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_STOCKOUT_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_STOCKOUT_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_STOCKOUT_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_STOCKOUT_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ITM_STOCKOUT_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ITM_STOCKOUT_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_STOCKOUT_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_STOCKOUT_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_STOCKOUT_ITEM_BTN.Location = New System.Drawing.Point(-1, 13)
        Me.ITM_STOCKOUT_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.ITM_STOCKOUT_ITEM_BTN.Name = "ITM_STOCKOUT_ITEM_BTN"
        Me.ITM_STOCKOUT_ITEM_BTN.Size = New System.Drawing.Size(90, 29)
        Me.ITM_STOCKOUT_ITEM_BTN.TabIndex = 10
        Me.ITM_STOCKOUT_ITEM_BTN.Text = "STOCK OUT"
        Me.ITM_STOCKOUT_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'ITM_FLT_ITEM_CBX
        '
        Me.ITM_FLT_ITEM_CBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ITM_FLT_ITEM_CBX.Font = New System.Drawing.Font("Bahnschrift", 13.0!)
        Me.ITM_FLT_ITEM_CBX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ITM_FLT_ITEM_CBX.FormattingEnabled = True
        Me.ITM_FLT_ITEM_CBX.Location = New System.Drawing.Point(676, 13)
        Me.ITM_FLT_ITEM_CBX.Margin = New System.Windows.Forms.Padding(5, 3, 0, 10)
        Me.ITM_FLT_ITEM_CBX.MaximumSize = New System.Drawing.Size(140, 0)
        Me.ITM_FLT_ITEM_CBX.MinimumSize = New System.Drawing.Size(140, 0)
        Me.ITM_FLT_ITEM_CBX.Name = "ITM_FLT_ITEM_CBX"
        Me.ITM_FLT_ITEM_CBX.Size = New System.Drawing.Size(140, 29)
        Me.ITM_FLT_ITEM_CBX.TabIndex = 15
        Me.ITM_FLT_ITEM_CBX.Text = "Value:"
        '
        'ITM_STOCKIN_ITEM_BTN
        '
        Me.ITM_STOCKIN_ITEM_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_STOCKIN_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_STOCKIN_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_STOCKIN_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_STOCKIN_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_STOCKIN_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_STOCKIN_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_STOCKIN_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_STOCKIN_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_STOCKIN_ITEM_BTN.Location = New System.Drawing.Point(92, 13)
        Me.ITM_STOCKIN_ITEM_BTN.Margin = New System.Windows.Forms.Padding(5, 10, 0, 10)
        Me.ITM_STOCKIN_ITEM_BTN.Name = "ITM_STOCKIN_ITEM_BTN"
        Me.ITM_STOCKIN_ITEM_BTN.Size = New System.Drawing.Size(90, 29)
        Me.ITM_STOCKIN_ITEM_BTN.TabIndex = 11
        Me.ITM_STOCKIN_ITEM_BTN.Text = "STOCK IN"
        Me.ITM_STOCKIN_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'ITM_SEARCH_BTN
        '
        Me.ITM_SEARCH_BTN.BackColor = System.Drawing.Color.Green
        Me.ITM_SEARCH_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_SEARCH_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_SEARCH_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_SEARCH_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.ITM_SEARCH_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ITM_SEARCH_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_SEARCH_BTN.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_SEARCH_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_SEARCH_BTN.Location = New System.Drawing.Point(497, 13)
        Me.ITM_SEARCH_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ITM_SEARCH_BTN.Name = "ITM_SEARCH_BTN"
        Me.ITM_SEARCH_BTN.Size = New System.Drawing.Size(30, 29)
        Me.ITM_SEARCH_BTN.TabIndex = 12
        Me.ITM_SEARCH_BTN.UseVisualStyleBackColor = False
        '
        'ITM_FLAG_ITEM_BTN
        '
        Me.ITM_FLAG_ITEM_BTN.BackColor = System.Drawing.Color.Black
        Me.ITM_FLAG_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_FLAG_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_FLAG_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_FLAG_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_FLAG_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_FLAG_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_FLAG_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 11.0!)
        Me.ITM_FLAG_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_FLAG_ITEM_BTN.Location = New System.Drawing.Point(15, 541)
        Me.ITM_FLAG_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.ITM_FLAG_ITEM_BTN.Name = "ITM_FLAG_ITEM_BTN"
        Me.ITM_FLAG_ITEM_BTN.Size = New System.Drawing.Size(127, 45)
        Me.ITM_FLAG_ITEM_BTN.TabIndex = 9
        Me.ITM_FLAG_ITEM_BTN.Text = "FLAG ITEM"
        Me.ITM_FLAG_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'ITM_EDIT_ITEM_BTN
        '
        Me.ITM_EDIT_ITEM_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_EDIT_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_EDIT_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_EDIT_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_EDIT_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ITM_EDIT_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ITM_EDIT_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_EDIT_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_EDIT_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_EDIT_ITEM_BTN.Location = New System.Drawing.Point(464, 541)
        Me.ITM_EDIT_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.ITM_EDIT_ITEM_BTN.Name = "ITM_EDIT_ITEM_BTN"
        Me.ITM_EDIT_ITEM_BTN.Size = New System.Drawing.Size(127, 45)
        Me.ITM_EDIT_ITEM_BTN.TabIndex = 8
        Me.ITM_EDIT_ITEM_BTN.Text = "EDIT DETAILS"
        Me.ITM_EDIT_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'ITM_DELETE_ITEM_BTN
        '
        Me.ITM_DELETE_ITEM_BTN.BackColor = System.Drawing.Color.DarkRed
        Me.ITM_DELETE_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_DELETE_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_DELETE_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_DELETE_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ITM_DELETE_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ITM_DELETE_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_DELETE_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_DELETE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_DELETE_ITEM_BTN.Location = New System.Drawing.Point(601, 541)
        Me.ITM_DELETE_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.ITM_DELETE_ITEM_BTN.Name = "ITM_DELETE_ITEM_BTN"
        Me.ITM_DELETE_ITEM_BTN.Size = New System.Drawing.Size(127, 45)
        Me.ITM_DELETE_ITEM_BTN.TabIndex = 7
        Me.ITM_DELETE_ITEM_BTN.Text = "DELETE"
        Me.ITM_DELETE_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'ITM_ADD_ITEM_BTN
        '
        Me.ITM_ADD_ITEM_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_ADD_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_ADD_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_ADD_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_ADD_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_ADD_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ITM_ADD_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_ADD_ITEM_BTN.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_ADD_ITEM_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_ADD_ITEM_BTN.Location = New System.Drawing.Point(738, 541)
        Me.ITM_ADD_ITEM_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.ITM_ADD_ITEM_BTN.Name = "ITM_ADD_ITEM_BTN"
        Me.ITM_ADD_ITEM_BTN.Size = New System.Drawing.Size(127, 45)
        Me.ITM_ADD_ITEM_BTN.TabIndex = 6
        Me.ITM_ADD_ITEM_BTN.Text = "ADD NEW ITEM"
        Me.ITM_ADD_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Location = New System.Drawing.Point(15, 97)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(850, 431)
        Me.Panel7.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbx_column})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(1, 5, 1, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(850, 431)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(850, 431)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(850, 431)
        Me.DataGridView1.TabIndex = 0
        '
        'cbx_column
        '
        Me.cbx_column.FalseValue = "Not"
        Me.cbx_column.HeaderText = "*"
        Me.cbx_column.Name = "cbx_column"
        Me.cbx_column.TrueValue = "Yes"
        Me.cbx_column.Width = 850
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(798, 9)
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
        'HOME_PANEL
        '
        Me.HOME_PANEL.BackColor = System.Drawing.Color.White
        Me.HOME_PANEL.Controls.Add(Me.APP_LABEL)
        Me.HOME_PANEL.Controls.Add(Me.Panel6)
        Me.HOME_PANEL.Controls.Add(Me.DAY_LOG_PANEL)
        Me.HOME_PANEL.Controls.Add(Me.Panel2)
        Me.HOME_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HOME_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.HOME_PANEL.Name = "HOME_PANEL"
        Me.HOME_PANEL.Size = New System.Drawing.Size(881, 661)
        Me.HOME_PANEL.TabIndex = 0
        '
        'APP_LABEL
        '
        Me.APP_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.APP_LABEL.Font = New System.Drawing.Font("Bahnschrift SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APP_LABEL.ForeColor = System.Drawing.SystemColors.InfoText
        Me.APP_LABEL.Location = New System.Drawing.Point(11, 25)
        Me.APP_LABEL.Name = "APP_LABEL"
        Me.APP_LABEL.Size = New System.Drawing.Size(839, 80)
        Me.APP_LABEL.TabIndex = 14
        Me.APP_LABEL.Text = "JUANCHO'S VARIETY SHOP INVENTORY SYSTEM"
        Me.APP_LABEL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.INFO_LBL_ITEMS)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(11, 136)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(815, 103)
        Me.Panel6.TabIndex = 13
        '
        'INFO_LBL_ITEMS
        '
        Me.INFO_LBL_ITEMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.INFO_LBL_ITEMS.Controls.Add(Me.HEADER_ITEMS)
        Me.INFO_LBL_ITEMS.Controls.Add(Me.VALUE_ITEMS)
        Me.INFO_LBL_ITEMS.Location = New System.Drawing.Point(0, 0)
        Me.INFO_LBL_ITEMS.Name = "INFO_LBL_ITEMS"
        Me.INFO_LBL_ITEMS.Size = New System.Drawing.Size(199, 108)
        Me.INFO_LBL_ITEMS.TabIndex = 10
        '
        'HEADER_ITEMS
        '
        Me.HEADER_ITEMS.BackColor = System.Drawing.Color.Transparent
        Me.HEADER_ITEMS.Dock = System.Windows.Forms.DockStyle.Top
        Me.HEADER_ITEMS.Font = New System.Drawing.Font("Tw Cen MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEADER_ITEMS.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.HEADER_ITEMS.Location = New System.Drawing.Point(0, 0)
        Me.HEADER_ITEMS.Name = "HEADER_ITEMS"
        Me.HEADER_ITEMS.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.HEADER_ITEMS.Size = New System.Drawing.Size(199, 34)
        Me.HEADER_ITEMS.TabIndex = 10
        Me.HEADER_ITEMS.Text = "INVENTORY VALUE"
        Me.HEADER_ITEMS.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VALUE_ITEMS
        '
        Me.VALUE_ITEMS.BackColor = System.Drawing.Color.Transparent
        Me.VALUE_ITEMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VALUE_ITEMS.FlatAppearance.BorderSize = 0
        Me.VALUE_ITEMS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_ITEMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_ITEMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VALUE_ITEMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VALUE_ITEMS.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VALUE_ITEMS.ForeColor = System.Drawing.Color.Lime
        Me.VALUE_ITEMS.Location = New System.Drawing.Point(0, 34)
        Me.VALUE_ITEMS.Margin = New System.Windows.Forms.Padding(0)
        Me.VALUE_ITEMS.Name = "VALUE_ITEMS"
        Me.VALUE_ITEMS.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.VALUE_ITEMS.Size = New System.Drawing.Size(199, 74)
        Me.VALUE_ITEMS.TabIndex = 11
        Me.VALUE_ITEMS.Text = "VALUE"
        Me.VALUE_ITEMS.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VALUE_ITEMS.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.HEADER_LASTSTOCK)
        Me.Panel5.Controls.Add(Me.VALUE_LASTSTOCK)
        Me.Panel5.Location = New System.Drawing.Point(615, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(199, 108)
        Me.Panel5.TabIndex = 11
        '
        'HEADER_LASTSTOCK
        '
        Me.HEADER_LASTSTOCK.BackColor = System.Drawing.Color.Transparent
        Me.HEADER_LASTSTOCK.Dock = System.Windows.Forms.DockStyle.Top
        Me.HEADER_LASTSTOCK.Font = New System.Drawing.Font("Tw Cen MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEADER_LASTSTOCK.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.HEADER_LASTSTOCK.Location = New System.Drawing.Point(0, 0)
        Me.HEADER_LASTSTOCK.Name = "HEADER_LASTSTOCK"
        Me.HEADER_LASTSTOCK.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.HEADER_LASTSTOCK.Size = New System.Drawing.Size(199, 34)
        Me.HEADER_LASTSTOCK.TabIndex = 10
        Me.HEADER_LASTSTOCK.Text = "LAST RESTOCK"
        Me.HEADER_LASTSTOCK.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VALUE_LASTSTOCK
        '
        Me.VALUE_LASTSTOCK.BackColor = System.Drawing.Color.Transparent
        Me.VALUE_LASTSTOCK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VALUE_LASTSTOCK.FlatAppearance.BorderSize = 0
        Me.VALUE_LASTSTOCK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_LASTSTOCK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_LASTSTOCK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VALUE_LASTSTOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VALUE_LASTSTOCK.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VALUE_LASTSTOCK.ForeColor = System.Drawing.Color.Yellow
        Me.VALUE_LASTSTOCK.Location = New System.Drawing.Point(0, 34)
        Me.VALUE_LASTSTOCK.Margin = New System.Windows.Forms.Padding(0)
        Me.VALUE_LASTSTOCK.Name = "VALUE_LASTSTOCK"
        Me.VALUE_LASTSTOCK.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.VALUE_LASTSTOCK.Size = New System.Drawing.Size(199, 74)
        Me.VALUE_LASTSTOCK.TabIndex = 14
        Me.VALUE_LASTSTOCK.Text = "VALUE"
        Me.VALUE_LASTSTOCK.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VALUE_LASTSTOCK.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.HEADER_COUNT)
        Me.Panel3.Controls.Add(Me.VALUE_COUNT)
        Me.Panel3.Location = New System.Drawing.Point(205, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 108)
        Me.Panel3.TabIndex = 11
        '
        'HEADER_COUNT
        '
        Me.HEADER_COUNT.BackColor = System.Drawing.Color.Transparent
        Me.HEADER_COUNT.Dock = System.Windows.Forms.DockStyle.Top
        Me.HEADER_COUNT.Font = New System.Drawing.Font("Tw Cen MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEADER_COUNT.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.HEADER_COUNT.Location = New System.Drawing.Point(0, 0)
        Me.HEADER_COUNT.Name = "HEADER_COUNT"
        Me.HEADER_COUNT.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.HEADER_COUNT.Size = New System.Drawing.Size(199, 34)
        Me.HEADER_COUNT.TabIndex = 10
        Me.HEADER_COUNT.Text = "ITEM COUNT"
        Me.HEADER_COUNT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VALUE_COUNT
        '
        Me.VALUE_COUNT.BackColor = System.Drawing.Color.Transparent
        Me.VALUE_COUNT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VALUE_COUNT.FlatAppearance.BorderSize = 0
        Me.VALUE_COUNT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_COUNT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_COUNT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VALUE_COUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VALUE_COUNT.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VALUE_COUNT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VALUE_COUNT.Location = New System.Drawing.Point(0, 34)
        Me.VALUE_COUNT.Margin = New System.Windows.Forms.Padding(0)
        Me.VALUE_COUNT.Name = "VALUE_COUNT"
        Me.VALUE_COUNT.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.VALUE_COUNT.Size = New System.Drawing.Size(199, 74)
        Me.VALUE_COUNT.TabIndex = 12
        Me.VALUE_COUNT.Text = "VALUE"
        Me.VALUE_COUNT.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VALUE_COUNT.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.HEADER_LOWSTOCK)
        Me.Panel4.Controls.Add(Me.VALUE_LOWSTOCK)
        Me.Panel4.Location = New System.Drawing.Point(410, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(199, 108)
        Me.Panel4.TabIndex = 12
        '
        'HEADER_LOWSTOCK
        '
        Me.HEADER_LOWSTOCK.BackColor = System.Drawing.Color.Transparent
        Me.HEADER_LOWSTOCK.Dock = System.Windows.Forms.DockStyle.Top
        Me.HEADER_LOWSTOCK.Font = New System.Drawing.Font("Tw Cen MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEADER_LOWSTOCK.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.HEADER_LOWSTOCK.Location = New System.Drawing.Point(0, 0)
        Me.HEADER_LOWSTOCK.Name = "HEADER_LOWSTOCK"
        Me.HEADER_LOWSTOCK.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.HEADER_LOWSTOCK.Size = New System.Drawing.Size(199, 34)
        Me.HEADER_LOWSTOCK.TabIndex = 10
        Me.HEADER_LOWSTOCK.Text = "LOW STOCK"
        Me.HEADER_LOWSTOCK.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VALUE_LOWSTOCK
        '
        Me.VALUE_LOWSTOCK.BackColor = System.Drawing.Color.Transparent
        Me.VALUE_LOWSTOCK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VALUE_LOWSTOCK.FlatAppearance.BorderSize = 0
        Me.VALUE_LOWSTOCK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_LOWSTOCK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VALUE_LOWSTOCK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VALUE_LOWSTOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VALUE_LOWSTOCK.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VALUE_LOWSTOCK.ForeColor = System.Drawing.Color.Red
        Me.VALUE_LOWSTOCK.Location = New System.Drawing.Point(0, 34)
        Me.VALUE_LOWSTOCK.Margin = New System.Windows.Forms.Padding(0)
        Me.VALUE_LOWSTOCK.Name = "VALUE_LOWSTOCK"
        Me.VALUE_LOWSTOCK.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.VALUE_LOWSTOCK.Size = New System.Drawing.Size(199, 74)
        Me.VALUE_LOWSTOCK.TabIndex = 13
        Me.VALUE_LOWSTOCK.Text = "VALUE"
        Me.VALUE_LOWSTOCK.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VALUE_LOWSTOCK.UseVisualStyleBackColor = False
        '
        'DAY_LOG_PANEL
        '
        Me.DAY_LOG_PANEL.BackColor = System.Drawing.Color.LightGray
        Me.DAY_LOG_PANEL.Controls.Add(Me.DO_LIST)
        Me.DAY_LOG_PANEL.Controls.Add(Me.DO_LABEL)
        Me.DAY_LOG_PANEL.Location = New System.Drawing.Point(552, 284)
        Me.DAY_LOG_PANEL.Name = "DAY_LOG_PANEL"
        Me.DAY_LOG_PANEL.Size = New System.Drawing.Size(319, 377)
        Me.DAY_LOG_PANEL.TabIndex = 5
        '
        'DO_LIST
        '
        Me.DO_LIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DO_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DO_LIST.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.DO_LIST.ForeColor = System.Drawing.SystemColors.Info
        Me.DO_LIST.FormattingEnabled = True
        Me.DO_LIST.HorizontalScrollbar = True
        Me.DO_LIST.ItemHeight = 15
        Me.DO_LIST.Items.AddRange(New Object() {"EVENT 1", "EVENT 2", "EVENT 3"})
        Me.DO_LIST.Location = New System.Drawing.Point(0, 47)
        Me.DO_LIST.Name = "DO_LIST"
        Me.DO_LIST.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.DO_LIST.Size = New System.Drawing.Size(319, 330)
        Me.DO_LIST.TabIndex = 4
        '
        'DO_LABEL
        '
        Me.DO_LABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DO_LABEL.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DO_LABEL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.DO_LABEL.Location = New System.Drawing.Point(0, 0)
        Me.DO_LABEL.Name = "DO_LABEL"
        Me.DO_LABEL.Padding = New System.Windows.Forms.Padding(5)
        Me.DO_LABEL.Size = New System.Drawing.Size(319, 44)
        Me.DO_LABEL.TabIndex = 1
        Me.DO_LABEL.Text = "DAY OVERVIEW"
        Me.DO_LABEL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.HOME_STOCK_IN_BTN)
        Me.Panel2.Controls.Add(Me.HOME_ADD_ITEM_BTN)
        Me.Panel2.Controls.Add(Me.HOME_INVENTORY_LOG_BTN)
        Me.Panel2.Controls.Add(Me.HOME_STOCK_OUT_BTN)
        Me.Panel2.Location = New System.Drawing.Point(11, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 377)
        Me.Panel2.TabIndex = 3
        '
        'HOME_STOCK_IN_BTN
        '
        Me.HOME_STOCK_IN_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_STOCK_IN_BTN.BackgroundImage = CType(resources.GetObject("HOME_STOCK_IN_BTN.BackgroundImage"), System.Drawing.Image)
        Me.HOME_STOCK_IN_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_STOCK_IN_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_STOCK_IN_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_STOCK_IN_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_STOCK_IN_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_STOCK_IN_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.HOME_STOCK_IN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_STOCK_IN_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_STOCK_IN_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_STOCK_IN_BTN.Location = New System.Drawing.Point(20, 198)
        Me.HOME_STOCK_IN_BTN.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.HOME_STOCK_IN_BTN.Name = "HOME_STOCK_IN_BTN"
        Me.HOME_STOCK_IN_BTN.Size = New System.Drawing.Size(230, 160)
        Me.HOME_STOCK_IN_BTN.TabIndex = 9
        Me.HOME_STOCK_IN_BTN.Text = "ITEM IN"
        Me.HOME_STOCK_IN_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_STOCK_IN_BTN.UseVisualStyleBackColor = False
        '
        'HOME_ADD_ITEM_BTN
        '
        Me.HOME_ADD_ITEM_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_ADD_ITEM_BTN.BackgroundImage = CType(resources.GetObject("HOME_ADD_ITEM_BTN.BackgroundImage"), System.Drawing.Image)
        Me.HOME_ADD_ITEM_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_ADD_ITEM_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_ADD_ITEM_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.HOME_ADD_ITEM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_ADD_ITEM_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_ADD_ITEM_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_ADD_ITEM_BTN.Location = New System.Drawing.Point(20, 20)
        Me.HOME_ADD_ITEM_BTN.Margin = New System.Windows.Forms.Padding(20, 20, 10, 10)
        Me.HOME_ADD_ITEM_BTN.Name = "HOME_ADD_ITEM_BTN"
        Me.HOME_ADD_ITEM_BTN.Size = New System.Drawing.Size(230, 160)
        Me.HOME_ADD_ITEM_BTN.TabIndex = 7
        Me.HOME_ADD_ITEM_BTN.Text = "ADD NEW ITEM"
        Me.HOME_ADD_ITEM_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_ADD_ITEM_BTN.UseVisualStyleBackColor = False
        '
        'HOME_INVENTORY_LOG_BTN
        '
        Me.HOME_INVENTORY_LOG_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_INVENTORY_LOG_BTN.BackgroundImage = CType(resources.GetObject("HOME_INVENTORY_LOG_BTN.BackgroundImage"), System.Drawing.Image)
        Me.HOME_INVENTORY_LOG_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HOME_INVENTORY_LOG_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_INVENTORY_LOG_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.HOME_INVENTORY_LOG_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_INVENTORY_LOG_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_INVENTORY_LOG_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_INVENTORY_LOG_BTN.Location = New System.Drawing.Point(270, 20)
        Me.HOME_INVENTORY_LOG_BTN.Margin = New System.Windows.Forms.Padding(10, 20, 20, 10)
        Me.HOME_INVENTORY_LOG_BTN.Name = "HOME_INVENTORY_LOG_BTN"
        Me.HOME_INVENTORY_LOG_BTN.Size = New System.Drawing.Size(230, 160)
        Me.HOME_INVENTORY_LOG_BTN.TabIndex = 8
        Me.HOME_INVENTORY_LOG_BTN.Text = "INVENTORY LOG"
        Me.HOME_INVENTORY_LOG_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_INVENTORY_LOG_BTN.UseVisualStyleBackColor = False
        '
        'HOME_STOCK_OUT_BTN
        '
        Me.HOME_STOCK_OUT_BTN.BackColor = System.Drawing.Color.White
        Me.HOME_STOCK_OUT_BTN.BackgroundImage = CType(resources.GetObject("HOME_STOCK_OUT_BTN.BackgroundImage"), System.Drawing.Image)
        Me.HOME_STOCK_OUT_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_STOCK_OUT_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME_STOCK_OUT_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HOME_STOCK_OUT_BTN.FlatAppearance.BorderSize = 0
        Me.HOME_STOCK_OUT_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HOME_STOCK_OUT_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.HOME_STOCK_OUT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_STOCK_OUT_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_STOCK_OUT_BTN.ForeColor = System.Drawing.Color.Black
        Me.HOME_STOCK_OUT_BTN.Location = New System.Drawing.Point(270, 198)
        Me.HOME_STOCK_OUT_BTN.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.HOME_STOCK_OUT_BTN.Name = "HOME_STOCK_OUT_BTN"
        Me.HOME_STOCK_OUT_BTN.Size = New System.Drawing.Size(230, 160)
        Me.HOME_STOCK_OUT_BTN.TabIndex = 6
        Me.HOME_STOCK_OUT_BTN.Text = "ITEM OUT"
        Me.HOME_STOCK_OUT_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_STOCK_OUT_BTN.UseVisualStyleBackColor = False
        '
        'ITM_FLTR_BTN
        '
        Me.ITM_FLTR_BTN.BackColor = System.Drawing.Color.Green
        Me.ITM_FLTR_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ITM_FLTR_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ITM_FLTR_BTN.FlatAppearance.BorderSize = 0
        Me.ITM_FLTR_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.ITM_FLTR_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ITM_FLTR_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ITM_FLTR_BTN.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITM_FLTR_BTN.ForeColor = System.Drawing.Color.White
        Me.ITM_FLTR_BTN.Location = New System.Drawing.Point(820, 13)
        Me.ITM_FLTR_BTN.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ITM_FLTR_BTN.Name = "ITM_FLTR_BTN"
        Me.ITM_FLTR_BTN.Size = New System.Drawing.Size(30, 29)
        Me.ITM_FLTR_BTN.TabIndex = 16
        Me.ITM_FLTR_BTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
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
        Me.ITEM_PANEL.ResumeLayout(False)
        Me.ITEM_PANEL.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LOG_PANEL.ResumeLayout(False)
        Me.LOG_PANEL.PerformLayout()
        Me.HOME_PANEL.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.INFO_LBL_ITEMS.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.DAY_LOG_PANEL.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SIDE_LOG_BTN As Button
    Friend WithEvents SIDE_ITEM_BTN As Button
    Friend WithEvents SIDE_HOME_BTN As Button
    Friend WithEvents Base_Panel As Panel
    Friend WithEvents HOME_PANEL As Panel
    Friend WithEvents LOG_PANEL As Panel
    Friend WithEvents ITEM_PANEL As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DO_LABEL As Label
    Friend WithEvents HOME_STOCK_IN_BTN As Button
    Friend WithEvents HOME_ADD_ITEM_BTN As Button
    Friend WithEvents HOME_INVENTORY_LOG_BTN As Button
    Friend WithEvents HOME_STOCK_OUT_BTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DAY_LOG_PANEL As Panel
    Friend WithEvents DO_LIST As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents INFO_LBL_ITEMS As Panel
    Friend WithEvents VALUE_ITEMS As Button
    Friend WithEvents HEADER_ITEMS As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents VALUE_LASTSTOCK As Button
    Friend WithEvents HEADER_LASTSTOCK As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VALUE_COUNT As Button
    Friend WithEvents HEADER_COUNT As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents VALUE_LOWSTOCK As Button
    Friend WithEvents HEADER_LOWSTOCK As Label
    Friend WithEvents APP_LABEL As Label
    Friend WithEvents ITM_CAT_ITEM_CBX As ComboBox
    Friend WithEvents ITM_STOCKIN_ITEM_BTN As Button
    Friend WithEvents ITM_STOCKOUT_ITEM_BTN As Button
    Friend WithEvents ITM_FLAG_ITEM_BTN As Button
    Friend WithEvents ITM_EDIT_ITEM_BTN As Button
    Friend WithEvents ITM_DELETE_ITEM_BTN As Button
    Friend WithEvents ITM_ADD_ITEM_BTN As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ITM_SEARCH_TBX As TextBox
    Friend WithEvents ITM_FLT_ITEM_CBX As ComboBox
    Friend WithEvents ITM_SEARCH_BTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbx_column As DataGridViewCheckBoxColumn
    Friend WithEvents ITM_FLTR_BTN As Button
End Class
