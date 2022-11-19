Public Class Form_Valuation

    Public Sub ColumnSum()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "Select SUM(QUANTITY * UNIT_PRICE) as TOTAL, SUM(TO_PAY) as LIABILITIES, SUM(MAX_SELL - UNIT_PRICE) as 'TOTAL MARGIN', SUM(MAX_SELL * QUANTITY) as 'TOTAL VALUE' From products"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                COL1_TT_LBL.Text = "P" & cmdreader.GetValue(0) & ""
                COL2_TT_LBL.Text = "P" & cmdreader.GetValue(1) & ""
                COL3_TT_LBL.Text = "P" & cmdreader.GetValue(2) & ""
                COL4_TT_LBL.Text = "P" & cmdreader.GetValue(3) & ""

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub Form_Valuation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '++++++++++++++++ SET MAIN TABLE VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        tableload("Select ITEM_NAME AS 'PRODUCT', QUANTITY, UNIT_PRICE 'UNIT COST', QUANTITY * UNIT_PRICE as 'TOTAL COST', TO_PAY 'LIABILITIES', MAX_SELL 'SELL PRICE', MAX_SELL - UNIT_PRICE as MARGIN, MAX_SELL * QUANTITY as 'FULL TOTAL' From products", VALUE_GRID)
        strconn.Close()

        ColumnSum()

    End Sub

    Private Sub VALUE_GRID_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles VALUE_GRID.DataBindingComplete

        VALUE_GRID.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        VALUE_GRID.Columns(1).Width = 80
        VALUE_GRID.Columns(2).Width = 100
        VALUE_GRID.Columns(3).Width = 100
        VALUE_GRID.Columns(4).Width = 80
        VALUE_GRID.Columns(5).Width = 90
        VALUE_GRID.Columns(6).Width = 90
        VALUE_GRID.Columns(7).Width = 100


    End Sub

End Class