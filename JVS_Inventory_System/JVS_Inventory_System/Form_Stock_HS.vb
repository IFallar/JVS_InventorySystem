Public Class Form_Stock_HS

    Dim QTY As Integer
    Dim TRH As Integer

    Public Sub Stock_Function()

        Dim ID As String = FSHS_ID_HOLD.Text
        Dim ITEM_INIT As Integer = FSHS_QTY_HOLD.Text
        Dim THRESHOLD As Integer = FSHS_TRH_HOLD.Text
        Dim UNIT_PRICE As Integer = FSHS_PRC_HOLD.Text


        Dim FINAL_AMOUNT As Integer
        Dim NEW_TOTAL As Integer
        Dim NEW_STATUS As String = ""

        Dim regDate As Date = Date.Now()
        Dim ITEM_ADD_DATE = regDate.ToString("yyyy\-MM\-dd")

        Try

            If FSHS_HEAD_LBL.Text = "RESTOCK" Then
                FINAL_AMOUNT = ITEM_INIT + STOCK_AMOUNT
            Else
                If STOCK_AMOUNT > ITEM_INIT Then
                    MsgBox("Exceeds Inventory Quantity.", MsgBoxStyle.OkOnly, "Insufficient Stock")
                Else
                    FINAL_AMOUNT = ITEM_INIT - STOCK_AMOUNT
                End If
            End If

            If FINAL_AMOUNT >= THRESHOLD Then
                NEW_STATUS = "NORMAL"
            ElseIf ITEM_INIT = 0 Then
                NEW_STATUS = "OUT OF STOCK"
            Else
                NEW_STATUS = "LOW STOCK"
            End If

            NEW_TOTAL = UNIT_PRICE * FINAL_AMOUNT

        Catch ex As Exception

            MsgBox("Please Enter a number!", MsgBoxStyle.OkOnly, "Incomplete Information")

        End Try

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE `products` SET `QUANTITY`='" & FINAL_AMOUNT & "',`STOCK_STATUS`='" & NEW_STATUS & "',`TOTAL_PRICE`='" & NEW_TOTAL & "',`LAST_STOCK`='" & ITEM_ADD_DATE & "' WHERE `ITEM_ID` = '" & ID & "'; UPDATE `latest_date` SET `last_restock`='" & ITEM_ADD_DATE & "' WHERE 1"
        cmd.ExecuteNonQuery()
        MsgBox("Success", MsgBoxStyle.OkOnly, "Action Confirmation")
        strconn.Close()

        Form1.Load_Table_Main()
        Form1.Set_Home_Value()

    End Sub

    Public Sub GetNum()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `ITEM_NAME`, `QUANTITY`, `THRESHOLD`, `UNIT_PRICE` FROM `products` WHERE `ITEM_ID` = '" & Selected_HS & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            QTY = cmdreader.GetValue(1)
            TRH = cmdreader.GetValue(2)

            FSHS_PRC_HOLD.Text = cmdreader.GetValue(3)

        End While

        cmdreader.Close()
        con.Close()

        FSHS_FLT4_TBX.Text = "" & QTY & " / " & TRH & ""
        FSHS_FLT5_TBX.Text = "" & QTY & " / " & TRH & ""

        FSHS_QTY_HOLD.Text = QTY
        FSHS_TRH_HOLD.Text = TRH

        If QTY >= TRH And QTY > 0 Then
            FSHS_FLT4_TBX.BackColor = Color.Green
            FSHS_FLT5_TBX.BackColor = Color.Green
        ElseIf QTY = 0 Then
            FSHS_FLT4_TBX.BackColor = Color.Red
            FSHS_FLT5_TBX.BackColor = Color.Red
        Else
            FSHS_FLT4_TBX.BackColor = Color.Orange
            FSHS_FLT5_TBX.BackColor = Color.Orange
        End If

    End Sub

    Public Sub UpdateNewStock()

        Dim NewStockVal As Integer

        If FSHS_NUM_TBX.Text = Nothing Then
            NewStockVal = 0 + QTY
        Else
            If FSHS_HEAD_LBL.Text = "RESTOCK" Then
                NewStockVal = FSHS_NUM_TBX.Text + QTY
            Else
                NewStockVal = FSHS_NUM_TBX.Text - QTY
            End If

        End If

        FSHS_FLT5_TBX.Text = "" & NewStockVal & " / " & TRH & ""

        If NewStockVal >= TRH And QTY > 0 Then
            FSHS_FLT5_TBX.BackColor = Color.Green
        ElseIf NewStockVal = 0 Then
            FSHS_FLT5_TBX.BackColor = Color.Red
        Else
            FSHS_FLT5_TBX.BackColor = Color.Orange
        End If

    End Sub

    Private Sub Form_Stock_HS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    '++++++++++++++++ SET TABLE (RUDIMENTRARY) ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub FSHS_ITEM_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_ITEM_TBX.TextChanged

        If FSHS_ITEM_TBX.Text = "" Then
            FSHS_FLT1_TBX.ReadOnly = True
            FSHS_FLT2_TBX.ReadOnly = True
            SEARCH_GRID.Visible = False
        Else
            SEARCH_GRID.Visible = True
            FSHS_FLT1_TBX.ReadOnly = False
            FSHS_FLT2_TBX.ReadOnly = False
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If

    End Sub

    Private Sub FSHS_FLT1_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.TextChanged

        If FSHS_FLT2_TBX.Text = "VARIANT" Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If


    End Sub

    Private Sub FSHS_FLT2_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.TextChanged

        If FSHS_FLT1_TBX.Text = "BRAND" Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If

    End Sub

    Private Sub SEARCH_GRID_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles SEARCH_GRID.CellBeginEdit
        If e.ColumnIndex > 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SEARCH_GRID_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles SEARCH_GRID.DataBindingComplete

        SEARCH_GRID.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        SEARCH_GRID.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        SEARCH_GRID.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        SEARCH_GRID.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        SEARCH_GRID.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub


    Dim Selected_HS As Integer = Nothing

    Private Sub SEARCH_GRID_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles SEARCH_GRID.CellValueChanged

        If (SEARCH_GRID.Columns(0).Name = "CK_COLUMN") Then

            If SEARCH_GRID.CurrentRow.Cells(0).Value = "YES" Then
                FSHS_ID_HOLD.Text = SEARCH_GRID.CurrentRow.Cells(1).Value
                Selected_HS = SEARCH_GRID.CurrentRow.Cells(1).Value
            End If

        End If

    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles SEARCH_GRID.CurrentCellDirtyStateChanged

        If (SEARCH_GRID.IsCurrentCellDirty) Then
            SEARCH_GRID.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

        FSHS_ITEM_TBX.Text = SEARCH_GRID.CurrentRow.Cells(2).Value
        FSHS_FLT1_TBX.Text = SEARCH_GRID.CurrentRow.Cells(3).Value
        FSHS_FLT2_TBX.Text = SEARCH_GRID.CurrentRow.Cells(4).Value
        SEARCH_GRID.Visible = False


        GetNum()


    End Sub

    '++++++++++++++++ PLACEHOLDER HANDLING (RUDIMENTRARY) ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub FSHS_FLT1_TBX_GotFocus(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.GotFocus

        If FSHS_FLT2_TBX.ReadOnly = False Then
            FSHS_FLT1_TBX.ForeColor = Color.Black
            FSHS_FLT1_TBX.Text = ""
        End If

    End Sub

    Private Sub FSHS_FLT1_TBX_LoseFocus(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.LostFocus

        If FSHS_FLT1_TBX.Text = "" Then
            FSHS_FLT1_TBX.ForeColor = Color.Gray
            FSHS_FLT1_TBX.Text = "BRAND"
        End If

    End Sub

    Private Sub FSHS_FLT2_TBX_GotFocus(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.GotFocus

        If FSHS_FLT2_TBX.ReadOnly = False Then
            FSHS_FLT2_TBX.ForeColor = Color.Black
            FSHS_FLT2_TBX.Text = ""
        End If


    End Sub

    Private Sub FSHS_FLT2_TBX_LoseFocus(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.LostFocus

        If FSHS_FLT2_TBX.Text = "" Then
            FSHS_FLT2_TBX.ForeColor = Color.Gray
            FSHS_FLT2_TBX.Text = "VARIANT"
        End If

    End Sub



    Private Sub FSHS_ADD_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_ADD_BTN.Click

        If FSHS_NUM_TBX.Text = Nothing Then
            FSHS_NUM_TBX.Text = 1
        Else
            Dim R_Value As Integer = FSHS_NUM_TBX.Text
            R_Value = R_Value + 1
            FSHS_NUM_TBX.Text = R_Value
        End If

    End Sub

    Private Sub FSHS_MIN_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_MIN_BTN.Click

        If FSHS_NUM_TBX.Text = Nothing Then
            FSHS_NUM_TBX.Text = 0
        ElseIf FSHS_NUM_TBX.Text = 0 Then
            FSHS_NUM_TBX.Text = 0
        Else
            Dim R_Value As Integer = FSHS_NUM_TBX.Text
            R_Value = R_Value - 1
            FSHS_NUM_TBX.Text = R_Value
        End If

    End Sub

    Private Sub FSHS_NUM_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_NUM_TBX.TextChanged

        UpdateNewStock()

    End Sub

    Dim STOCK_AMOUNT As Integer

    Private Sub FSHS_SAVE_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_SAVE_BTN.Click

        STOCK_AMOUNT = FSHS_NUM_TBX.Text
        Stock_Function()

    End Sub

    Private Sub FSHS_CNC_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_CNC_BTN.Click

        FSHS_ITEM_TBX.Text = ""
        FSHS_FLT1_TBX.Text = "BRAND"
        FSHS_FLT2_TBX.Text = "VARIANT"
        FSHS_FLT4_TBX.Text = ""
        FSHS_FLT5_TBX.Text = ""
        FSHS_NUM_TBX.Text = 0
        FSHS_NUM_TBX.BackColor = Color.Gray

        Try
            Me.Close()

        Catch ex As Exception

        End Try

        Form1.Load_Table_Main()
        Form1.Set_Home_Value()

    End Sub

End Class