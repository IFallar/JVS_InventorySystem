Public Class Form_Stock_IS

    Private Sub Form_Stock_IS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form1.Get_Name()

    End Sub

    Private Sub FSIS_SAVE_BTN_Click(sender As Object, e As EventArgs) Handles FSIS_SAVE_BTN.Click

        Dim STOCK_AMOUNT As Integer

        Dim ID As String = FSIS_ID_HOLD.Text
        Dim ITEM_INIT As Integer = FSIS_QTY_HOLD.Text
        Dim THRESHOLD As Integer = FSIS_TRH_HOLD.Text
        Dim UNIT_PRICE As Integer = FSIS_PRC_HOLD.Text

        Dim FINAL_AMOUNT As Integer
        Dim NEW_TOTAL As Integer
        Dim NEW_STATUS As String

        If FSIS_HEAD_LBL.Text = "RESTOCK" Then
            FINAL_AMOUNT = ITEM_INIT + STOCK_AMOUNT
        Else
            FINAL_AMOUNT = ITEM_INIT - STOCK_AMOUNT
        End If




    End Sub

End Class