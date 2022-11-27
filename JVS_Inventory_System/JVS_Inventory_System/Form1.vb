Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1

    'PUBLICS ================================================================================================================

    Public Class GlobalVariables
        Public Shared UserID As Integer
        Public Shared Selected_Item As Integer
        Public Shared logged As Integer = 1
    End Class

    Dim FLD As String

    Public Sub Get_LastDate(SID As String)

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `LAST_STOCK` FROM `products` WHERE `ITEM_ID` = '" & SID & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                Dim LastDate As Date = cmdreader.GetValue(0)
                FLD = LastDate.ToString("yyyy\-MM\-dd")

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE `products` SET `PREV_ORDER` = '" & FLD & "' WHERE `ITEM_ID` = '" & SID & "'"
        cmd.ExecuteNonQuery()

        strconn.Close()

    End Sub

    Public Sub Get_ITMNAME()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `ITEM_NAME`, `QUANTITY`, `THRESHOLD`, `UNIT_PRICE` FROM `products` WHERE `ITEM_ID` = '" & GlobalVariables.Selected_Item & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        Form_Stock_IS.FSIS_ID_HOLD.Text = GlobalVariables.Selected_Item

        While cmdreader.Read

            Try

                Form_Stock_IS.FSIS_ITEM_TBX.Text = cmdreader.GetString(0)
                Form_Stock_IS.FSIS_QTY_HOLD.Text = cmdreader.GetString(1)
                Form_Stock_IS.FSIS_TRH_HOLD.Text = cmdreader.GetString(2)
                Form_Stock_IS.FSIS_PRC_HOLD.Text = cmdreader.GetString(3)

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub Edit_Details()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `ITEM_NAME`, `ITEM_BRAND`, `CATEGORY`, `VARIANT`, `UNIT_PRICE`, `QUANTITY`, `MIN_SELL`, `MAX_SELL`, `THRESHOLD`, `HOLDING_STATUS`, `SUPPLIER` FROM `products` WHERE `ITEM_ID` = '" & Form_Add_Item.FAI_TBX_ITEM_ID.Text & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Form_Add_Item.FAI_TBX_ITEM_NAME.Text = cmdreader.GetString(0)
            Form_Add_Item.FAI_CBX_ITEM_BRAND.Text = cmdreader.GetString(1)
            Form_Add_Item.FAI_CBX_ITEM_CAT.Text = cmdreader.GetString(2)
            Form_Add_Item.FAI_CBX_ITEM_MODEL.Text = cmdreader.GetString(3)
            Form_Add_Item.FAI_TBX_ITEM_PC.Text = cmdreader.GetString(4)
            Form_Add_Item.FAI_TBX_ITEM_INIT.Text = cmdreader.GetString(5)
            Form_Add_Item.FAI_TBX_ITEM_MIN.Text = cmdreader.GetString(6)
            Form_Add_Item.FAI_TBX_ITEM_MAX.Text = cmdreader.GetString(7)
            Form_Add_Item.FAI_TBX_ITEM_TRHD.Text = cmdreader.GetString(8)
            Form_Add_Item.FAI_CBX_ITEM_HLDSTAT.Text = cmdreader.GetString(9)
            Form_Add_Item.FAI_CBX_ITEM_SP.Text = cmdreader.GetString(10)
            Form_Add_Item.FAI_TBX_TOPAY.Text = 0

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub Load_Table_Main()

        Dim Filter_Value As String = Me.ITM_FLTVAL_ITEM_CBX.Text

        If Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 0 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE ITEM_BRAND = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()

        ElseIf Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 1 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE CATEGORY = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()

        ElseIf Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 2 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE HOLDING_STATUS = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()

        ElseIf Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 3 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = '" & Filter_Value & "'", Me.DataGridView1)
            strconn.Close()

        ElseIf Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 4 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE STOCK_STATUS = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()

        ElseIf Me.ITM_FLTSET_ITEM_CBX.SelectedIndex = 5 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE SUPPLIER = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = 'NORMAL'", Me.DataGridView1)
            strconn.Close()
        End If

    End Sub

    Public Sub Set_Home_Value()

        '++++++++++++++++ SET QUICK INFO VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim home_item_valuation As String
        Dim home_item_qty As Integer
        Dim home_item_lowstock As Integer
        Dim home_item_laststock As String

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT (SELECT SUM(TOTAL_PRICE) FROM products) as home_item_valuation, (Select Count(*) as home_item_qty from products) as home_item_qty, (Select Count(*) as home_item_lowstock from products WHERE STOCK_STATUS = 'LOW STOCK') as home_item_lowstock, (SELECT last_restock FROM latest_date) AS last_restock, (SELECT last_outstock FROM latest_date) AS last_outstock"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                home_item_valuation = cmdreader.GetValue(0)
                Me.VALUE_ITEMS.Text = "P" + home_item_valuation

                home_item_qty = cmdreader.GetValue(1)
                Me.VALUE_COUNT.Text = home_item_qty

                home_item_lowstock = cmdreader.GetValue(2)
                Me.VALUE_LOWSTOCK.Text = home_item_lowstock

                home_item_laststock = cmdreader.GetValue(3)
                Me.VALUE_LASTSTOCK.Text = home_item_laststock

            Catch ex As System.InvalidCastException

                VALUE_ITEMS.Text = "P0"
                VALUE_COUNT.Text = 0
                VALUE_LOWSTOCK.Text = 0
                VALUE_LASTSTOCK.Text = "DD/MM/YYYY"

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub Set_Log_Value()

        '++++++++++++++++ SET QUICK INFO VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim log_out As Integer
        Dim log_in As Integer
        Dim log_add As Integer
        Dim log_change As Integer

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT (SELECT SUM(SUBSTRING(r_qty,2, LENGTH(r_qty) -1)) FROM transaction_log WHERE transaction_type = 'Stock Out') AS 'OUT', (SELECT SUM(SUBSTRING(r_qty,2,(r_qty))) FROM transaction_log WHERE transaction_type = 'Restock') AS 'ADD', (SELECT COUNT(*) FROM transaction_log WHERE transaction_type = 'New Item') as 'New', (SELECT COUNT(*) FROM transaction_log WHERE transaction_type = 'Edited Info') AS 'Edited'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                log_out = cmdreader.GetValue(0)
                Me.TD_BTN1.Text = log_out

                log_in = cmdreader.GetValue(1)
                Me.TD_BTN2.Text = log_in

                log_add = cmdreader.GetValue(2)
                Me.TD_BTN3.Text = log_add

                log_change = cmdreader.GetValue(3)
                Me.TD_BTN4.Text = log_change

            Catch ex As System.InvalidCastException

                TD_BTN1.Text = 0
                TD_BTN2.Text = 0
                TD_BTN3.Text = 0
                TD_BTN3.Text = 0

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Public Sub UPDATE_RPR_STATUS()
        If GlobalVariables.Selected_Item = Nothing Then
            MsgBox("Select an Item to Flag.", MsgBoxStyle.OkOnly, "No Item Selected")
        Else
            Try

                opencon()

                cmd.Connection = con
                cmd.CommandText = "SELECT `ITEM_NAME` FROM products WHERE `ITEM_ID` = '" & GlobalVariables.Selected_Item & "'"
                cmd.Prepare()

                cmdreader = cmd.ExecuteReader

                While cmdreader.Read

                    Try

                        FLAGGED_ITM = cmdreader(0)
                        Dim result As DialogResult = MessageBox.Show("Mark " + FLAGGED_ITM + FLAGGED_MSG, "FLAG ITEM", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then

                            strconnection()

                            cmd.Connection = strconn
                            strconn.Open()

                            cmd.CommandText = "UPDATE `products` SET `REPAIR_STATUS`='" & FLAGGED_VAL & "' WHERE `ITEM_ID` = '" & GlobalVariables.Selected_Item & "'"
                            cmd.ExecuteNonQuery()

                            strconn.Close()

                            Load_Table_Main()
                            Set_Home_Value()

                        ElseIf result = DialogResult.No Then

                        End If

                    Catch ex As System.InvalidCastException

                    End Try

                    con.Close()

                End While

                cmdreader.Close()
                con.Close()

            Catch ex As Exception

            End Try

            con.Close()

        End If
    End Sub

    Public Sub Search_Bar()

        tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE ITEM_NAME LIKE '%" & ITM_SEARCH_TBX.Text & "%' OR ITEM_BRAND LIKE '%" & ITM_SEARCH_TBX.Text & "%' OR VARIANT LIKE '%" & ITM_SEARCH_TBX.Text & "%'", DataGridView1)
        strconn.Close()

    End Sub

    Public Sub Search_Bar_Log()

        tableload("SELECT `log_id` AS 'ID', (SELECT CONCAT(`acc_fn`, ' ' , `acc_ln`) FROM account WHERE acc_id = `r_acc_id`) AS 'USER', COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `ITEM_BRAND`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `transaction_type` AS 'ACTION', `r_qty` AS 'CHANGE', `r_time` AS 'TIME', `r_date` AS 'DATE' FROM `transaction_log` WHERE (SELECT CONCAT(`acc_fn`, ' ' , `acc_ln`) FROM account WHERE acc_id = `r_acc_id`) LIKE '%" & LOG_SEARCH_BOX.Text & "%' OR (SELECT CONCAT(`ITEM_NAME`, ' | ' , `ITEM_BRAND`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`) LIKE '%" & LOG_SEARCH_BOX.Text & "%' OR transaction_type LIKE '%" & LOG_SEARCH_BOX.Text & "%'", DataGridView2)
        strconn.Close()

    End Sub

    Public Sub LoadHistory()

        If ACT_FLT.Text = "Action:" Then
            tableload("SELECT `log_id` AS 'ID', (SELECT CONCAT(`acc_fn`, ' ' , `acc_ln`) FROM account WHERE acc_id = `r_acc_id`) AS 'USER', COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `ITEM_BRAND`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `transaction_type` AS 'ACTION', `r_qty` AS 'CHANGE', `r_time` AS 'TIME', `r_date` AS 'DATE' FROM `transaction_log` WHERE 1", Me.DataGridView2)
            strconn.Close()
        Else
            tableload("SELECT `log_id` AS 'ID', (SELECT CONCAT(`acc_fn`, ' ' , `acc_ln`) FROM account WHERE acc_id = `r_acc_id`) AS 'USER', COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `ITEM_BRAND`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `transaction_type` AS 'ACTION', `r_qty` AS 'CHANGE', `r_time` AS 'TIME', `r_date` AS 'DATE' FROM `transaction_log` WHERE transaction_type = '" & ACT_FLT.Text & "'", Me.DataGridView2)
            strconn.Close()
        End If



    End Sub

    '++++++++++++++++ LOG FUNCTIONALITY ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Public Sub Add_Log(Token As Integer, transac_qty As String, itid As Integer)

        '++++++++++++++++ VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim acc_id_log As Integer = GlobalVariables.UserID
        Dim item_id_log As Integer = itid
        Dim transaction_type As String = ""
        Dim transaction_qty As String = transac_qty
        Dim log_date As Date = Date.Now()
        Dim transaction_date = log_date.ToString("yyyy\-MM\-dd")
        Dim transaction_time As String = TimeOfDay.ToString("hh:mm")

        Dim in_out As String = ""

        If Token = 1 Then

            transaction_type = "New Item"

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'products'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                item_id_log = cmdreader.GetValue(0) - 1
            End While

            cmdreader.Close()
            con.Close()

        ElseIf Token = 2 Then

            transaction_type = "Restock"
            in_out = "+"

        ElseIf Token = 3 Then

            transaction_type = "Stock Out"
            in_out = "-"

        ElseIf Token = 4 Then

            transaction_type = "Edited Info"
            transaction_qty = "---"

        ElseIf Token = 5 Then

            transaction_type = "Item Deleted"
            transaction_qty = "---"

        ElseIf Token = 6 Then

            transaction_type = "Flagged"

        End If

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "INSERT INTO `transaction_log`(`log_id`, `r_acc_id`, `r_item_id`, `transaction_type`, `r_qty`, `r_time`, `r_date`) VALUES (DEFAULT, '" & acc_id_log & "','" & item_id_log & "','" & transaction_type & "','" & in_out & "" & transaction_qty & "','" & transaction_time & "','" & transaction_date & "')"
        cmd.ExecuteNonQuery()

        strconn.Close()


    End Sub

    'PRIVATES ================================================================================================================


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '++++++++++++++++ SET MAIN TABLE VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If GlobalVariables.logged = 0 Then
            Login.ShowDialog()
            Me.Close()
        Else

        End If

        Load_Table_Main()
        Set_Home_Value()

    End Sub

    'FORMAT TABLE AND CELLS ================================================================================================================

    '++++++++++++++++ SET SPECIFIC CELL COLORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        If e.ColumnIndex = 8 And e.Value IsNot Nothing Then
            Dim content As String = e.Value
            If content = "LOW STOCK" Then
                e.CellStyle.BackColor = Color.Orange
            ElseIf content = "OUT OF STOCK" Then
                e.CellStyle.BackColor = Color.Red
            Else
                e.CellStyle.BackColor = Color.Green
            End If
        End If

    End Sub

    '++++++++++++++++ SET CELL SIZING ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete

        DataGridView1.RowTemplate.Resizable = False
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.RowTemplate.MinimumHeight = 50

    End Sub

    Private Sub DataGridView2_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete

        DataGridView2.RowTemplate.Resizable = False
        DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView2.Columns(1).MinimumWidth = 120
        DataGridView2.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(4).Width = 140
        DataGridView2.Columns(5).Width = 90
        DataGridView2.Columns(6).Width = 90

        DataGridView2.RowTemplate.MinimumHeight = 40

    End Sub

    '++++++++++++++++ SET CELL SELECTION (RUDIMENTRARY) ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        If e.ColumnIndex > 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        If (DataGridView1.Columns(0).Name = "cbx_column") Then

            If DataGridView1.CurrentRow.Cells(0).Value = "Yes" Then
                GlobalVariables.Selected_Item = DataGridView1.CurrentRow.Cells(1).Value
            End If

        End If

    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged

        If (DataGridView1.IsCurrentCellDirty) Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    'BUTTON EVENTS ===================================================================================================================

    '++++++++++++++++ BUTTON STYLE CHANGES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub HOME_BTN_MouseEnter(sender As Object, e As EventArgs) Handles SIDE_HOME_BTN.MouseEnter
        If (SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_HOME_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        End If

    End Sub

    Private Sub HOME_BTN_MouseLeave(sender As Object, e As EventArgs) Handles SIDE_HOME_BTN.MouseLeave
        If (SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub ITEM_BTN_MouseEnter(sender As Object, e As EventArgs) Handles SIDE_ITEM_BTN.MouseEnter
        If (SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        End If

    End Sub

    Private Sub ITEM_BTN_MouseLeave(sender As Object, e As EventArgs) Handles SIDE_ITEM_BTN.MouseLeave
        If (SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub LOG_BTN_MouseEnter(sender As Object, e As EventArgs) Handles SIDE_LOG_BTN.MouseEnter
        If (SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_LOG_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        End If

    End Sub

    Private Sub LOG_BTN_MouseLeave(sender As Object, e As EventArgs) Handles SIDE_LOG_BTN.MouseLeave
        If (SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent) Then
            SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White
        End If

    End Sub

    'PANEL NAVIGATION ================================================================================================================

    '++++++++++++++++ PANEL STYLE CHANGES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub HOME_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_HOME_BTN.Click
        HOME_PANEL.Visible = True
        ITEM_PANEL.Visible = False
        LOG_PANEL.Visible = False
        PANEL_SETTINGS.Visible = False

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_SET_BTN.BackColor = System.Drawing.Color.Transparent

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White
        SIDE_SET_BTN.ForeColor = System.Drawing.Color.White


        Set_Home_Value()

    End Sub

    Private Sub ITEM_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_ITEM_BTN.Click
        HOME_PANEL.Visible = False
        ITEM_PANEL.Visible = True
        LOG_PANEL.Visible = False
        PANEL_SETTINGS.Visible = False

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.White
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_SET_BTN.BackColor = System.Drawing.Color.Transparent

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White
        SIDE_SET_BTN.ForeColor = System.Drawing.Color.White

        Load_Table_Main()

        tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = 'NORMAL'", DataGridView1)
        strconn.Close()

        Set_Home_Value()

    End Sub

    Private Sub LOG_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_LOG_BTN.Click
        HOME_PANEL.Visible = False
        ITEM_PANEL.Visible = False
        LOG_PANEL.Visible = True
        PANEL_SETTINGS.Visible = False

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.White
        SIDE_SET_BTN.BackColor = System.Drawing.Color.Transparent

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        SIDE_SET_BTN.ForeColor = System.Drawing.Color.White

        Set_Home_Value()
        DataGridView2.RowTemplate.MinimumHeight = 40
        Set_Log_Value()
        LoadHistory()

    End Sub

    Private Sub SIDE_SET_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_SET_BTN.Click

        HOME_PANEL.Visible = False
        ITEM_PANEL.Visible = False
        LOG_PANEL.Visible = False
        PANEL_SETTINGS.Visible = True

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_SET_BTN.BackColor = System.Drawing.Color.White

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White
        SIDE_SET_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)

        Set_Home_Value()

    End Sub

    'MAIN SCREEN ================================================================================================================



    '++++++++++++++++ MAIN SCREEN BUTTONS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub HOME_ADD_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles HOME_ADD_ITEM_BTN.Click

        Try
            Dim Modal As New Form_Add_Item
            Form_Add_Item.Label13.Text = "ADD NEW ITEM"
            Form_Add_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HOME_STOCK_IN_BTN_Click(sender As Object, e As EventArgs) Handles HOME_STOCK_IN_BTN.Click

        Try
            Dim Modal As New Form_Stock_HS
            Form_Stock_HS.FSHS_HEAD_LBL.Text = "RESTOCK"
            Form_Stock_HS.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HOME_STOCK_OUT_BTN_Click(sender As Object, e As EventArgs) Handles HOME_STOCK_OUT_BTN.Click

        Try
            Dim Modal As New Form_Stock_HS
            Form_Stock_HS.FSHS_HEAD_LBL.Text = "STOCK OUT"
            Form_Stock_HS.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    '++++++++++++++++ QUICK INFO BUTTONS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub VALUE_ITEMS_Click(sender As Object, e As EventArgs) Handles VALUE_ITEMS.Click

        Try
            Dim Modal As New Form_Valuation
            Form_Valuation.FV_HEAD_LBL.Text = "INVENTORY VALUE BREAKDOWN"
            Form_Valuation.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    'ITEM SCREEN ================================================================================================================

    '++++++++++++++++ ITEM SCREEN BUTTONS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub ITM_ADD_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_ADD_ITEM_BTN.Click

        Try
            Dim Modal As New Form_Add_Item
            Form_Add_Item.Label13.Text = "ADD NEW ITEM"
            Form_Add_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ITM_EDIT_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_EDIT_ITEM_BTN.Click

        If GlobalVariables.Selected_Item = Nothing Then
            MsgBox("Select an Item to Edit.", MsgBoxStyle.OkOnly, "No Item Selected")
        Else
            Try
                Dim Modal As New Form_Add_Item
                Form_Add_Item.Label13.Text = "EDIT ITEM DETAILS"
                Form_Add_Item.FAI_TBX_ITEM_ID.Text = GlobalVariables.Selected_Item
                Form_Add_Item.ShowDialog()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub ITM_DELETE_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_DELETE_ITEM_BTN.Click

        Dim TO_DELETE As String

        If GlobalVariables.Selected_Item = Nothing Then
            MsgBox("Select an Item to Edit.", MsgBoxStyle.OkOnly, "No Item Selected")
        Else
            Try

                opencon()

                cmd.Connection = con
                cmd.CommandText = "SELECT `ITEM_NAME` FROM products WHERE `ITEM_ID` = '" & GlobalVariables.Selected_Item & "'"
                cmd.Prepare()

                cmdreader = cmd.ExecuteReader

                While cmdreader.Read

                    Try

                        TO_DELETE = cmdreader(0)
                        Dim result As DialogResult = MessageBox.Show("Remove " + TO_DELETE + " from Inventory?", "DELETE ENTRY", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then

                            strconnection()

                            cmd.Connection = strconn
                            strconn.Open()

                            cmd.CommandText = "SET FOREIGN_KEY_CHECKS=0; DELETE FROM `products` WHERE `ITEM_ID` = '" & GlobalVariables.Selected_Item & "'; SET FOREIGN_KEY_CHECKS=1"
                            cmd.ExecuteNonQuery()

                            strconn.Close()

                            Load_Table_Main()
                            Set_Home_Value()

                        ElseIf result = DialogResult.No Then

                        End If

                    Catch ex As System.InvalidCastException

                    End Try

                    con.Close()

                End While

                cmdreader.Close()
                con.Close()

            Catch ex As Exception

            End Try

            con.Close()

        End If

        Add_Log(5, "--", GlobalVariables.Selected_Item)

    End Sub

    Private Sub ITM_STOCKIN_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_STOCKIN_ITEM_BTN.Click

        If GlobalVariables.Selected_Item = Nothing Then
            MsgBox("Please Select an Item.", MsgBoxStyle.OkOnly, "No Item Selected")
        Else
            Try
                Dim Modal As New Form_Stock_IS
                Form_Stock_IS.FSIS_HEAD_LBL.Text = "RESTOCK"
                Form_Stock_IS.ShowDialog()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ITM_STOCKOUT_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_STOCKOUT_ITEM_BTN.Click

        If GlobalVariables.Selected_Item = Nothing Then
            MsgBox("Please Select an Item.", MsgBoxStyle.OkOnly, "No Item Selected")
        Else
            Try
                Dim Modal As New Form_Stock_IS
                Form_Stock_IS.FSIS_HEAD_LBL.Text = "TAKE OUT ITEM"
                Form_Stock_IS.ShowDialog()

            Catch ex As Exception

            End Try
        End If

    End Sub

    '++++++++++++++++ ITEM SCREEN BUTTONS - FLAGGING ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Dim FLAGGED_ITM As String
    Dim FLAGGED_MSG As String
    Dim FLAGGED_VAL As String

    Private Sub ITM_FLAG_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_FLAG_ITEM_BTN.Click

        If ITM_FLAG_ITEM_BTN.Width = 40 Then
            ITM_FLAG_ITEM_BTN.Width = 127
            ITM_FLAG_ITEM_BTN.Text = "FLAG ITEM"
            ITM_FLAG_ITEM_BTN.BackColor = Color.Black
            ITM_FLAG_ITEM_BTN.FlatAppearance.MouseOverBackColor = Color.DimGray
            PANEL_ITEM_FLAGGING.Width = 10

        Else
            ITM_FLAG_ITEM_BTN.Width = 40
            ITM_FLAG_ITEM_BTN.Text = "X"
            ITM_FLAG_ITEM_BTN.BackColor = Color.DarkRed
            ITM_FLAG_ITEM_BTN.FlatAppearance.MouseOverBackColor = Color.Red
            PANEL_ITEM_FLAGGING.Width = 248
        End If

    End Sub

    Private Sub ITM_DMG_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_DMG_ITEM_BTN.Click

        FLAGGED_MSG = " as Damaged?"
        FLAGGED_VAL = "DAMAGED"
        UPDATE_RPR_STATUS()
        Add_Log(6, "Flagged as Damaged", GlobalVariables.Selected_Item)

    End Sub

    Private Sub ITM_DEF_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_DEF_ITEM_BTN.Click

        FLAGGED_MSG = " as Defective?"
        FLAGGED_VAL = "DEFECTIVE"
        UPDATE_RPR_STATUS()
        Add_Log(6, "Flagged as Defective", GlobalVariables.Selected_Item)

    End Sub

    Private Sub ITM_RESET_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles ITM_RESET_ITEM_BTN.Click

        FLAGGED_MSG = " as Normal?"
        FLAGGED_VAL = "NORMAL"
        UPDATE_RPR_STATUS()
        Add_Log(6, "Flagged as Normal", GlobalVariables.Selected_Item)

    End Sub

    '++++++++++++++++ SETTING FILTER FUNCTIONS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub ITM_CAT_ITEM_CBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ITM_FLTSET_ITEM_CBX.SelectedIndexChanged

        ITM_FLTVAL_ITEM_CBX.Items.Clear()
        ITM_FLTVAL_ITEM_CBX.Text = "Value"

        If ITM_FLTSET_ITEM_CBX.SelectedIndex = 0 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT BRAND_NAME FROM (brands)"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("BRAND_NAME")
                ITM_FLTVAL_ITEM_CBX.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        ElseIf ITM_FLTSET_ITEM_CBX.SelectedIndex = 1 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT categories_name FROM categories"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("categories_name")
                ITM_FLTVAL_ITEM_CBX.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        ElseIf ITM_FLTSET_ITEM_CBX.SelectedIndex = 2 Then

            ITM_FLTVAL_ITEM_CBX.Items.Add("OWNED")
            ITM_FLTVAL_ITEM_CBX.Items.Add("CONSIGNED")
            ITM_FLTVAL_ITEM_CBX.Items.Add("LOANED")

        ElseIf ITM_FLTSET_ITEM_CBX.SelectedIndex = 3 Then

            ITM_FLTVAL_ITEM_CBX.Items.Add("NORMAL")
            ITM_FLTVAL_ITEM_CBX.Items.Add("DAMAGED")
            ITM_FLTVAL_ITEM_CBX.Items.Add("DEFECTIVE")

        ElseIf ITM_FLTSET_ITEM_CBX.SelectedIndex = 4 Then

            ITM_FLTVAL_ITEM_CBX.Items.Add("NORMAL")
            ITM_FLTVAL_ITEM_CBX.Items.Add("LOW STOCK")
            ITM_FLTVAL_ITEM_CBX.Items.Add("OUT OF STOCK")

        ElseIf ITM_FLTSET_ITEM_CBX.SelectedIndex = 5 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT supplier_name FROM suppliers"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim filter_list = cmdreader.GetString("supplier_name")
                ITM_FLTVAL_ITEM_CBX.Items.Add(filter_list)
            End While

            cmdreader.Close()
            con.Close()

        End If

    End Sub

    Private Sub ITM_FLTR_BTN_Click(sender As Object, e As EventArgs) Handles ITM_FLTR_BTN.Click

        tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = 'NORMAL'", DataGridView1)
        strconn.Close()

        ITM_FLTSET_ITEM_CBX.Text = "FILTER"
        ITM_FLTVAL_ITEM_CBX.Text = "VALUE"

    End Sub

    Private Sub ITM_FLT_ITEM_CBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ITM_FLTVAL_ITEM_CBX.SelectedIndexChanged

        Dim Filter_Value As String = ITM_FLTVAL_ITEM_CBX.Text

        Load_Table_Main()

    End Sub

    '++++++++++++++++ SEARCH ITEMS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub ITM_SEARCH_TBX_TextChanged(sender As Object, e As EventArgs) Handles ITM_SEARCH_TBX.TextChanged

        Search_Bar()

    End Sub

    Private Sub LOG_SEARCH_BOX_TextChanged(sender As Object, e As EventArgs) Handles LOG_SEARCH_BOX.TextChanged

        Search_Bar_Log()

    End Sub

    Private Sub ACT_FLT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ACT_FLT.SelectedIndexChanged

        LoadHistory()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ACT_FLT.Text = "Action:"
        LoadHistory()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim LogDate As Date = DateTimePicker1.Value
        Dim NewDate = LogDate.ToString("yyyy\-MM\-dd")

        tableload("SELECT `log_id` AS 'ID', (SELECT CONCAT(`acc_fn`, ' ' , `acc_ln`) FROM account WHERE acc_id = `r_acc_id`) AS 'USER', COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `ITEM_BRAND`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `transaction_type` AS 'ACTION', `r_qty` AS 'CHANGE', `r_time` AS 'TIME', `r_date` AS 'DATE' FROM `transaction_log` WHERE r_date = '" & NewDate & "'", Me.DataGridView2)
        strconn.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    'SETTINGS ================================================================================================================

    '++++++++++++++++ SECTION ++++++++++++++++++++++++++++++++++++++++++++++++++++++

End Class
