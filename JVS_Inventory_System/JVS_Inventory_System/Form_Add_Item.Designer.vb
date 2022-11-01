<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Add_Item
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FAI_BTN_CANCEL = New System.Windows.Forms.Button()
        Me.FAI_BTN_RESET = New System.Windows.Forms.Button()
        Me.FAI_BTN_SAVE = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FAI_L_ITEM_MIN = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_MAX = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_PC = New System.Windows.Forms.Label()
        Me.FAI_TBX_ITEM_MIN = New System.Windows.Forms.TextBox()
        Me.FAI_TBX_ITEM_MAX = New System.Windows.Forms.TextBox()
        Me.FAI_L_ITEM_INITSTOCK = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_TRHD = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_HLDSTAT = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_TOPAY = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_CAT = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_MODEL = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_BRAND = New System.Windows.Forms.Label()
        Me.FAI_L_ITEM_NAME = New System.Windows.Forms.Label()
        Me.FAI_TBX_TOPAY = New System.Windows.Forms.TextBox()
        Me.FAI_CBX_ITEM_CAT = New System.Windows.Forms.ComboBox()
        Me.FAI_CBX_ITEM_HLDSTAT = New System.Windows.Forms.ComboBox()
        Me.FAI_CBX_ITEM_MODEL = New System.Windows.Forms.ComboBox()
        Me.FAI_CBX_ITEM_BRAND = New System.Windows.Forms.ComboBox()
        Me.FAI_TBX_ITEM_PC = New System.Windows.Forms.TextBox()
        Me.FAI_TBX_ITEM_TRHD = New System.Windows.Forms.TextBox()
        Me.FAI_TBX_ITEM_INIT = New System.Windows.Forms.TextBox()
        Me.FAI_TBX_ITEM_NAME = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(24, 14)
        Me.Label13.Margin = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(173, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "ADD NEW ITEM"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FAI_BTN_CANCEL)
        Me.Panel2.Controls.Add(Me.FAI_BTN_RESET)
        Me.Panel2.Controls.Add(Me.FAI_BTN_SAVE)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_MIN)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_MAX)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_PC)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_MIN)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_MAX)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_INITSTOCK)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_TRHD)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_HLDSTAT)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_TOPAY)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_CAT)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_MODEL)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_BRAND)
        Me.Panel2.Controls.Add(Me.FAI_L_ITEM_NAME)
        Me.Panel2.Controls.Add(Me.FAI_TBX_TOPAY)
        Me.Panel2.Controls.Add(Me.FAI_CBX_ITEM_CAT)
        Me.Panel2.Controls.Add(Me.FAI_CBX_ITEM_HLDSTAT)
        Me.Panel2.Controls.Add(Me.FAI_CBX_ITEM_MODEL)
        Me.Panel2.Controls.Add(Me.FAI_CBX_ITEM_BRAND)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_PC)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_TRHD)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_INIT)
        Me.Panel2.Controls.Add(Me.FAI_TBX_ITEM_NAME)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 356)
        Me.Panel2.TabIndex = 1
        '
        'FAI_BTN_CANCEL
        '
        Me.FAI_BTN_CANCEL.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_BTN_CANCEL.Location = New System.Drawing.Point(246, 299)
        Me.FAI_BTN_CANCEL.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.FAI_BTN_CANCEL.Name = "FAI_BTN_CANCEL"
        Me.FAI_BTN_CANCEL.Size = New System.Drawing.Size(98, 32)
        Me.FAI_BTN_CANCEL.TabIndex = 32
        Me.FAI_BTN_CANCEL.Text = "CANCEL"
        Me.FAI_BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'FAI_BTN_RESET
        '
        Me.FAI_BTN_RESET.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_BTN_RESET.Location = New System.Drawing.Point(354, 299)
        Me.FAI_BTN_RESET.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.FAI_BTN_RESET.Name = "FAI_BTN_RESET"
        Me.FAI_BTN_RESET.Size = New System.Drawing.Size(98, 32)
        Me.FAI_BTN_RESET.TabIndex = 31
        Me.FAI_BTN_RESET.Text = "RESET"
        Me.FAI_BTN_RESET.UseVisualStyleBackColor = True
        '
        'FAI_BTN_SAVE
        '
        Me.FAI_BTN_SAVE.BackColor = System.Drawing.Color.DarkGreen
        Me.FAI_BTN_SAVE.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_BTN_SAVE.ForeColor = System.Drawing.SystemColors.Control
        Me.FAI_BTN_SAVE.Location = New System.Drawing.Point(462, 299)
        Me.FAI_BTN_SAVE.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.FAI_BTN_SAVE.Name = "FAI_BTN_SAVE"
        Me.FAI_BTN_SAVE.Size = New System.Drawing.Size(98, 32)
        Me.FAI_BTN_SAVE.TabIndex = 30
        Me.FAI_BTN_SAVE.Text = "SAVE"
        Me.FAI_BTN_SAVE.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(29, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(531, 2)
        Me.Panel3.TabIndex = 29
        '
        'FAI_L_ITEM_MIN
        '
        Me.FAI_L_ITEM_MIN.AutoSize = True
        Me.FAI_L_ITEM_MIN.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_MIN.Location = New System.Drawing.Point(286, 223)
        Me.FAI_L_ITEM_MIN.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_MIN.Name = "FAI_L_ITEM_MIN"
        Me.FAI_L_ITEM_MIN.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_MIN.Size = New System.Drawing.Size(98, 16)
        Me.FAI_L_ITEM_MIN.TabIndex = 28
        Me.FAI_L_ITEM_MIN.Text = "MIN. SELL PRICE"
        Me.FAI_L_ITEM_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_MAX
        '
        Me.FAI_L_ITEM_MAX.AutoSize = True
        Me.FAI_L_ITEM_MAX.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_MAX.Location = New System.Drawing.Point(156, 223)
        Me.FAI_L_ITEM_MAX.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_MAX.Name = "FAI_L_ITEM_MAX"
        Me.FAI_L_ITEM_MAX.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_MAX.Size = New System.Drawing.Size(102, 16)
        Me.FAI_L_ITEM_MAX.TabIndex = 27
        Me.FAI_L_ITEM_MAX.Text = "MAX. SELL PRICE"
        Me.FAI_L_ITEM_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_PC
        '
        Me.FAI_L_ITEM_PC.AutoSize = True
        Me.FAI_L_ITEM_PC.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_PC.Location = New System.Drawing.Point(26, 223)
        Me.FAI_L_ITEM_PC.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_PC.Name = "FAI_L_ITEM_PC"
        Me.FAI_L_ITEM_PC.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_PC.Size = New System.Drawing.Size(105, 16)
        Me.FAI_L_ITEM_PC.TabIndex = 26
        Me.FAI_L_ITEM_PC.Text = "PURCHASE COST"
        Me.FAI_L_ITEM_PC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_TBX_ITEM_MIN
        '
        Me.FAI_TBX_ITEM_MIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_MIN.Location = New System.Drawing.Point(289, 242)
        Me.FAI_TBX_ITEM_MIN.Margin = New System.Windows.Forms.Padding(0, 3, 5, 5)
        Me.FAI_TBX_ITEM_MIN.MaximumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_MIN.MinimumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_MIN.Name = "FAI_TBX_ITEM_MIN"
        Me.FAI_TBX_ITEM_MIN.Size = New System.Drawing.Size(125, 23)
        Me.FAI_TBX_ITEM_MIN.TabIndex = 25
        '
        'FAI_TBX_ITEM_MAX
        '
        Me.FAI_TBX_ITEM_MAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_MAX.Location = New System.Drawing.Point(159, 242)
        Me.FAI_TBX_ITEM_MAX.Margin = New System.Windows.Forms.Padding(0, 3, 5, 5)
        Me.FAI_TBX_ITEM_MAX.MaximumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_MAX.MinimumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_MAX.Name = "FAI_TBX_ITEM_MAX"
        Me.FAI_TBX_ITEM_MAX.Size = New System.Drawing.Size(125, 23)
        Me.FAI_TBX_ITEM_MAX.TabIndex = 24
        '
        'FAI_L_ITEM_INITSTOCK
        '
        Me.FAI_L_ITEM_INITSTOCK.AutoSize = True
        Me.FAI_L_ITEM_INITSTOCK.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_INITSTOCK.Location = New System.Drawing.Point(26, 139)
        Me.FAI_L_ITEM_INITSTOCK.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_INITSTOCK.Name = "FAI_L_ITEM_INITSTOCK"
        Me.FAI_L_ITEM_INITSTOCK.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_INITSTOCK.Size = New System.Drawing.Size(91, 16)
        Me.FAI_L_ITEM_INITSTOCK.TabIndex = 23
        Me.FAI_L_ITEM_INITSTOCK.Text = "INITIAL STOCK"
        Me.FAI_L_ITEM_INITSTOCK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_TRHD
        '
        Me.FAI_L_ITEM_TRHD.AutoSize = True
        Me.FAI_L_ITEM_TRHD.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_TRHD.Location = New System.Drawing.Point(124, 139)
        Me.FAI_L_ITEM_TRHD.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_TRHD.Name = "FAI_L_ITEM_TRHD"
        Me.FAI_L_ITEM_TRHD.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_TRHD.Size = New System.Drawing.Size(76, 16)
        Me.FAI_L_ITEM_TRHD.TabIndex = 22
        Me.FAI_L_ITEM_TRHD.Text = "THRESHOLD"
        Me.FAI_L_ITEM_TRHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_HLDSTAT
        '
        Me.FAI_L_ITEM_HLDSTAT.AutoSize = True
        Me.FAI_L_ITEM_HLDSTAT.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_HLDSTAT.Location = New System.Drawing.Point(221, 139)
        Me.FAI_L_ITEM_HLDSTAT.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_HLDSTAT.Name = "FAI_L_ITEM_HLDSTAT"
        Me.FAI_L_ITEM_HLDSTAT.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_HLDSTAT.Size = New System.Drawing.Size(111, 16)
        Me.FAI_L_ITEM_HLDSTAT.TabIndex = 21
        Me.FAI_L_ITEM_HLDSTAT.Text = "HOLDING STATUS"
        Me.FAI_L_ITEM_HLDSTAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_TOPAY
        '
        Me.FAI_L_ITEM_TOPAY.AutoSize = True
        Me.FAI_L_ITEM_TOPAY.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_TOPAY.Location = New System.Drawing.Point(422, 139)
        Me.FAI_L_ITEM_TOPAY.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_TOPAY.Name = "FAI_L_ITEM_TOPAY"
        Me.FAI_L_ITEM_TOPAY.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_TOPAY.Size = New System.Drawing.Size(54, 16)
        Me.FAI_L_ITEM_TOPAY.TabIndex = 20
        Me.FAI_L_ITEM_TOPAY.Text = "TO PAY"
        Me.FAI_L_ITEM_TOPAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_CAT
        '
        Me.FAI_L_ITEM_CAT.AutoSize = True
        Me.FAI_L_ITEM_CAT.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_CAT.Location = New System.Drawing.Point(422, 79)
        Me.FAI_L_ITEM_CAT.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_CAT.Name = "FAI_L_ITEM_CAT"
        Me.FAI_L_ITEM_CAT.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_CAT.Size = New System.Drawing.Size(105, 16)
        Me.FAI_L_ITEM_CAT.TabIndex = 19
        Me.FAI_L_ITEM_CAT.Text = "ITEM CATEGORY"
        Me.FAI_L_ITEM_CAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_MODEL
        '
        Me.FAI_L_ITEM_MODEL.AutoSize = True
        Me.FAI_L_ITEM_MODEL.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_MODEL.Location = New System.Drawing.Point(221, 79)
        Me.FAI_L_ITEM_MODEL.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_MODEL.Name = "FAI_L_ITEM_MODEL"
        Me.FAI_L_ITEM_MODEL.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_MODEL.Size = New System.Drawing.Size(107, 16)
        Me.FAI_L_ITEM_MODEL.TabIndex = 17
        Me.FAI_L_ITEM_MODEL.Text = "MODEL/VARIANT"
        Me.FAI_L_ITEM_MODEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_BRAND
        '
        Me.FAI_L_ITEM_BRAND.AutoSize = True
        Me.FAI_L_ITEM_BRAND.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_BRAND.Location = New System.Drawing.Point(26, 79)
        Me.FAI_L_ITEM_BRAND.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_BRAND.Name = "FAI_L_ITEM_BRAND"
        Me.FAI_L_ITEM_BRAND.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_BRAND.Size = New System.Drawing.Size(49, 16)
        Me.FAI_L_ITEM_BRAND.TabIndex = 16
        Me.FAI_L_ITEM_BRAND.Text = "BRAND"
        Me.FAI_L_ITEM_BRAND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_L_ITEM_NAME
        '
        Me.FAI_L_ITEM_NAME.AutoSize = True
        Me.FAI_L_ITEM_NAME.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_L_ITEM_NAME.Location = New System.Drawing.Point(26, 16)
        Me.FAI_L_ITEM_NAME.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.FAI_L_ITEM_NAME.Name = "FAI_L_ITEM_NAME"
        Me.FAI_L_ITEM_NAME.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FAI_L_ITEM_NAME.Size = New System.Drawing.Size(74, 16)
        Me.FAI_L_ITEM_NAME.TabIndex = 15
        Me.FAI_L_ITEM_NAME.Text = "ITEM NAME"
        Me.FAI_L_ITEM_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FAI_TBX_TOPAY
        '
        Me.FAI_TBX_TOPAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_TOPAY.Location = New System.Drawing.Point(425, 157)
        Me.FAI_TBX_TOPAY.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_TBX_TOPAY.MaximumSize = New System.Drawing.Size(135, 25)
        Me.FAI_TBX_TOPAY.MinimumSize = New System.Drawing.Size(135, 25)
        Me.FAI_TBX_TOPAY.Name = "FAI_TBX_TOPAY"
        Me.FAI_TBX_TOPAY.Size = New System.Drawing.Size(135, 26)
        Me.FAI_TBX_TOPAY.TabIndex = 14
        '
        'FAI_CBX_ITEM_CAT
        '
        Me.FAI_CBX_ITEM_CAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_CBX_ITEM_CAT.FormattingEnabled = True
        Me.FAI_CBX_ITEM_CAT.Location = New System.Drawing.Point(425, 98)
        Me.FAI_CBX_ITEM_CAT.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_CBX_ITEM_CAT.MaximumSize = New System.Drawing.Size(135, 0)
        Me.FAI_CBX_ITEM_CAT.MinimumSize = New System.Drawing.Size(135, 0)
        Me.FAI_CBX_ITEM_CAT.Name = "FAI_CBX_ITEM_CAT"
        Me.FAI_CBX_ITEM_CAT.Size = New System.Drawing.Size(135, 25)
        Me.FAI_CBX_ITEM_CAT.TabIndex = 12
        '
        'FAI_CBX_ITEM_HLDSTAT
        '
        Me.FAI_CBX_ITEM_HLDSTAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_CBX_ITEM_HLDSTAT.FormattingEnabled = True
        Me.FAI_CBX_ITEM_HLDSTAT.Items.AddRange(New Object() {"OWNED", "CONSIGNED", "LOANED"})
        Me.FAI_CBX_ITEM_HLDSTAT.Location = New System.Drawing.Point(224, 157)
        Me.FAI_CBX_ITEM_HLDSTAT.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_CBX_ITEM_HLDSTAT.MaximumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_HLDSTAT.MinimumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_HLDSTAT.Name = "FAI_CBX_ITEM_HLDSTAT"
        Me.FAI_CBX_ITEM_HLDSTAT.Size = New System.Drawing.Size(190, 25)
        Me.FAI_CBX_ITEM_HLDSTAT.TabIndex = 10
        '
        'FAI_CBX_ITEM_MODEL
        '
        Me.FAI_CBX_ITEM_MODEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_CBX_ITEM_MODEL.FormattingEnabled = True
        Me.FAI_CBX_ITEM_MODEL.Location = New System.Drawing.Point(224, 98)
        Me.FAI_CBX_ITEM_MODEL.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_CBX_ITEM_MODEL.MaximumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_MODEL.MinimumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_MODEL.Name = "FAI_CBX_ITEM_MODEL"
        Me.FAI_CBX_ITEM_MODEL.Size = New System.Drawing.Size(190, 25)
        Me.FAI_CBX_ITEM_MODEL.TabIndex = 9
        '
        'FAI_CBX_ITEM_BRAND
        '
        Me.FAI_CBX_ITEM_BRAND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FAI_CBX_ITEM_BRAND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FAI_CBX_ITEM_BRAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_CBX_ITEM_BRAND.FormattingEnabled = True
        Me.FAI_CBX_ITEM_BRAND.Location = New System.Drawing.Point(29, 98)
        Me.FAI_CBX_ITEM_BRAND.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_CBX_ITEM_BRAND.MaximumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_BRAND.MinimumSize = New System.Drawing.Size(190, 0)
        Me.FAI_CBX_ITEM_BRAND.Name = "FAI_CBX_ITEM_BRAND"
        Me.FAI_CBX_ITEM_BRAND.Size = New System.Drawing.Size(190, 25)
        Me.FAI_CBX_ITEM_BRAND.TabIndex = 8
        '
        'FAI_TBX_ITEM_PC
        '
        Me.FAI_TBX_ITEM_PC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_PC.Location = New System.Drawing.Point(29, 242)
        Me.FAI_TBX_ITEM_PC.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_TBX_ITEM_PC.MaximumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_PC.MinimumSize = New System.Drawing.Size(125, 25)
        Me.FAI_TBX_ITEM_PC.Name = "FAI_TBX_ITEM_PC"
        Me.FAI_TBX_ITEM_PC.Size = New System.Drawing.Size(125, 23)
        Me.FAI_TBX_ITEM_PC.TabIndex = 5
        '
        'FAI_TBX_ITEM_TRHD
        '
        Me.FAI_TBX_ITEM_TRHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_TRHD.Location = New System.Drawing.Point(127, 157)
        Me.FAI_TBX_ITEM_TRHD.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_TBX_ITEM_TRHD.MaximumSize = New System.Drawing.Size(92, 25)
        Me.FAI_TBX_ITEM_TRHD.MinimumSize = New System.Drawing.Size(92, 25)
        Me.FAI_TBX_ITEM_TRHD.Name = "FAI_TBX_ITEM_TRHD"
        Me.FAI_TBX_ITEM_TRHD.Size = New System.Drawing.Size(92, 23)
        Me.FAI_TBX_ITEM_TRHD.TabIndex = 4
        '
        'FAI_TBX_ITEM_INIT
        '
        Me.FAI_TBX_ITEM_INIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_INIT.Location = New System.Drawing.Point(29, 157)
        Me.FAI_TBX_ITEM_INIT.Margin = New System.Windows.Forms.Padding(20, 3, 5, 5)
        Me.FAI_TBX_ITEM_INIT.MaximumSize = New System.Drawing.Size(92, 25)
        Me.FAI_TBX_ITEM_INIT.MinimumSize = New System.Drawing.Size(92, 25)
        Me.FAI_TBX_ITEM_INIT.Name = "FAI_TBX_ITEM_INIT"
        Me.FAI_TBX_ITEM_INIT.Size = New System.Drawing.Size(92, 23)
        Me.FAI_TBX_ITEM_INIT.TabIndex = 3
        '
        'FAI_TBX_ITEM_NAME
        '
        Me.FAI_TBX_ITEM_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.FAI_TBX_ITEM_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAI_TBX_ITEM_NAME.Location = New System.Drawing.Point(29, 35)
        Me.FAI_TBX_ITEM_NAME.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.FAI_TBX_ITEM_NAME.MaximumSize = New System.Drawing.Size(535, 25)
        Me.FAI_TBX_ITEM_NAME.MinimumSize = New System.Drawing.Size(385, 25)
        Me.FAI_TBX_ITEM_NAME.Name = "FAI_TBX_ITEM_NAME"
        Me.FAI_TBX_ITEM_NAME.Size = New System.Drawing.Size(531, 23)
        Me.FAI_TBX_ITEM_NAME.TabIndex = 0
        '
        'Form_Add_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(600, 450)
        Me.MinimumSize = New System.Drawing.Size(600, 450)
        Me.Name = "Form_Add_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Add_Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FAI_TBX_ITEM_NAME As TextBox
    Friend WithEvents FAI_TBX_ITEM_TRHD As TextBox
    Friend WithEvents FAI_TBX_ITEM_INIT As TextBox
    Friend WithEvents FAI_CBX_ITEM_CAT As ComboBox
    Friend WithEvents FAI_CBX_ITEM_HLDSTAT As ComboBox
    Friend WithEvents FAI_CBX_ITEM_MODEL As ComboBox
    Friend WithEvents FAI_CBX_ITEM_BRAND As ComboBox
    Friend WithEvents FAI_TBX_ITEM_PC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FAI_BTN_SAVE As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FAI_L_ITEM_MIN As Label
    Friend WithEvents FAI_L_ITEM_MAX As Label
    Friend WithEvents FAI_L_ITEM_PC As Label
    Friend WithEvents FAI_TBX_ITEM_MIN As TextBox
    Friend WithEvents FAI_TBX_ITEM_MAX As TextBox
    Friend WithEvents FAI_L_ITEM_INITSTOCK As Label
    Friend WithEvents FAI_L_ITEM_TRHD As Label
    Friend WithEvents FAI_L_ITEM_HLDSTAT As Label
    Friend WithEvents FAI_L_ITEM_TOPAY As Label
    Friend WithEvents FAI_L_ITEM_CAT As Label
    Friend WithEvents FAI_L_ITEM_MODEL As Label
    Friend WithEvents FAI_L_ITEM_BRAND As Label
    Friend WithEvents FAI_L_ITEM_NAME As Label
    Friend WithEvents FAI_TBX_TOPAY As TextBox
    Friend WithEvents FAI_BTN_CANCEL As Button
    Friend WithEvents FAI_BTN_RESET As Button
End Class
