Public Class Form_Stock_IS

    Private Sub Form_Stock_IS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form1.Get_ITMNAME()
        FSIS_NUM_TBX.Text = 0

    End Sub

    Private Sub FSIS_SAVE_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_SAVE_BTN.Click

        Dim STOCK_AMOUNT As Integer

        Dim ID As String = FSIS_ID_HOLD.Text
        Dim ITEM_INIT As Integer = FSIS_QTY_HOLD.Text
        Dim THRESHOLD As Integer = FSIS_TRH_HOLD.Text
        Dim UNIT_PRICE As Integer = FSIS_PRC_HOLD.Text

        STOCK_AMOUNT = FSIS_NUM_TBX.Text

        Dim FINAL_AMOUNT As Integer
        Dim NEW_TOTAL As Integer
        Dim NEW_STATUS As String = ""

        Dim regDate As Date = Date.Now()
        Dim ITEM_ADD_DATE = regDate.ToString("yyyy\-MM\-dd")

        Try

            If FSIS_HEAD_LBL.Text = "RESTOCK" Then
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

        cmd.CommandText = "UPDATE `products` SET `QUANTITY`='" & FINAL_AMOUNT & "',`STOCK_STATUS`='" & NEW_STATUS & "',`TOTAL_PRICE`='" & NEW_TOTAL & "',`LAST_STOCK`='" & ITEM_ADD_DATE & "' WHERE `ITEM_ID` = '" & ID & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Success", MsgBoxStyle.OkOnly, "Action Confirmation")
        strconn.Close()

        Form1.Load_Table_Main()
        Form1.Set_Home_Value()

    End Sub

    Private Sub FSIS_ADD_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_ADD_BTN.Click

        If FSIS_NUM_TBX.Text = Nothing Then
            FSIS_NUM_TBX.Text = 1
        Else
            Dim R_Value As Integer = FSIS_NUM_TBX.Text
            R_Value = R_Value + 1
            FSIS_NUM_TBX.Text = R_Value
        End If

    End Sub

    Private Sub FSIS_MIN_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_MIN_BTN.Click

        If FSIS_NUM_TBX.Text = Nothing Then
            FSIS_NUM_TBX.Text = 0
        ElseIf FSIS_NUM_TBX.Text = 0 Then
            FSIS_NUM_TBX.Text = 0
        Else
            Dim R_Value As Integer = FSIS_NUM_TBX.Text
            R_Value = R_Value - 1
            FSIS_NUM_TBX.Text = R_Value
        End If

    End Sub

End Class