Public Class Form_Stock_IS

    Dim Current As Boolean = False
    Dim NEW_STATUS As String = ""

    Public Sub Stock_Function()

        Dim ID As String = Form1.GlobalVariables.Selected_Item
        Dim ITEM_INIT As Integer = FSIS_QTY_HOLD.Text
        Dim THRESHOLD As Integer = FSIS_TRH_HOLD.Text
        Dim UNIT_PRICE As Integer = FSIS_PRC_HOLD.Text

        Dim FINAL_AMOUNT As Integer
        Dim NEW_TOTAL As Integer

        Dim regDate As Date = Date.Now()
        Dim ITEM_ADD_DATE = regDate.ToString("yyyy\-MM\-dd")

        Try

            If FSIS_HEAD_LBL.Text = "RESTOCK" Then
                FINAL_AMOUNT = ITEM_INIT + STOCK_AMOUNT
            Else
                If STOCK_AMOUNT > ITEM_INIT Then
                    MsgBox("Exceeds Inventory Quantity.", MsgBoxStyle.OkOnly, "Insufficient Stock")
                    Exit Sub
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

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "UPDATE `products` SET `QUANTITY`='" & FINAL_AMOUNT & "',`STOCK_STATUS`='" & NEW_STATUS & "',`TOTAL_PRICE`='" & NEW_TOTAL & "',`LAST_STOCK`='" & ITEM_ADD_DATE & "',`PRV_ORDQ`='" & STOCK_AMOUNT & "' WHERE `ITEM_ID` = '" & ID & "'; UPDATE `latest_date` SET `last_restock`='" & ITEM_ADD_DATE & "' WHERE 1"
            cmd.ExecuteNonQuery()
            MsgBox("Success", MsgBoxStyle.OkOnly, "Action Confirmation")
            strconn.Close()


            Form1.Load_Table_Main()
            Form1.Set_Home_Value()

        Catch ex As Exception

            MsgBox("Please Enter a number!", MsgBoxStyle.OkOnly, "Incomplete Information")

        End Try



    End Sub

    Private Sub Form_Stock_IS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `ITEM_NAME`, `QUANTITY`, `THRESHOLD`, `UNIT_PRICE` FROM `products` WHERE `ITEM_ID` = '" & Form1.GlobalVariables.Selected_Item & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                FSIS_ITEM_TBX.Text = cmdreader.GetString(0)
                FSIS_QTY_HOLD.Text = cmdreader.GetString(1)
                FSIS_TRH_HOLD.Text = cmdreader.GetString(2)
                FSIS_PRC_HOLD.Text = cmdreader.GetString(3)

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

        FSIS_NUM_TBX.Text = 0

        If FSIS_TRH_HOLD.Text > FSIS_QTY_HOLD.Text Then
            Current = True
        End If

    End Sub

    Dim STOCK_AMOUNT As Integer

    Private Sub FSIS_SAVE_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_SAVE_BTN.Click

        If Current = True And NEW_STATUS IsNot "Normal" And FSIS_HEAD_LBL.Text IsNot "RESTOCK" Then
            Form1.Get_LastDate(Form1.GlobalVariables.Selected_Item)
        End If

        STOCK_AMOUNT = FSIS_NUM_TBX.Text

        Stock_Function()

        If FSIS_HEAD_LBL.Text = "RESTOCK" Then
            Form1.Add_Log(2, STOCK_AMOUNT, Form1.GlobalVariables.Selected_Item)
        Else
            Form1.Add_Log(3, STOCK_AMOUNT, Form1.GlobalVariables.Selected_Item)
        End If

    

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

    Private Sub FSIS_CNC_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_CNC_BTN.Click

        Try
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class