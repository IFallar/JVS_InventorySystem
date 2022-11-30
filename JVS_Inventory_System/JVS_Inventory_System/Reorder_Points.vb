Public Class Reorder_Points

    Dim USE_QUERY As String

    Public Sub ColumnSum(QUERY As String)

        opencon()

        cmd.Connection = con
        cmd.CommandText = USE_QUERY
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                COL1_TT_LBL.Text = cmdreader.GetValue(0)
                COL2_TT_LBL.Text = "P" & cmdreader.GetValue(1) & ""

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub VALUE_GRID_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles REORDER_GRID.DataBindingComplete

        REORDER_GRID.Columns(0).Width = 160
        REORDER_GRID.Columns(1).Width = 100
        REORDER_GRID.Columns(2).Width = 80
        REORDER_GRID.Columns(3).Width = 80
        REORDER_GRID.Columns(4).Width = 80
        REORDER_GRID.Columns(5).Width = 80
        REORDER_GRID.Columns(6).Width = 70
        REORDER_GRID.Columns(7).Width = 80
        REORDER_GRID.Columns(8).Width = 100

        REORDER_GRID.RowTemplate.MinimumHeight = 30

    End Sub

    Private Sub Reorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '++++++++++++++++ SET MAIN TABLE VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        tableload("SELECT CONCAT(`ITEM_NAME`, ' | ' , `VARIANT`) AS 'ITEM', `PREV_ORDER` AS 'REACHED THRESHOLD', DATEDIFF(`LAST_STOCK`, `PREV_ORDER`) AS 'DAYS TO LOW / OUT STOCK', `PRV_ORDQ` AS 'LAST ORDER QTY.', `STOCK_STATUS` AS 'STOCK LEVEL', CONCAT(`QUANTITY`, '/' , `THRESHOLD`) as 'ON HAND/ THRESHOLD', (`THRESHOLD` - `QUANTITY`) AS 'TO ORDER', `UNIT_PRICE` AS 'UNIT COST', ((`THRESHOLD` - `QUANTITY`) * UNIT_PRICE) AS 'REORDER COST' FROM `products` WHERE STOCK_STATUS = 'LOW STOCK' OR STOCK_STATUS = 'OUT OF STOCK'", REORDER_GRID)
        strconn.Close()

        USE_QUERY = "SELECT  SUM(`THRESHOLD` - `QUANTITY`) AS 'TO ORDER', SUM((`THRESHOLD` - `QUANTITY`) * UNIT_PRICE) AS 'REORDER COST' FROM `products` WHERE STOCK_STATUS = 'LOW STOCK' OR 'OUT OF STOCK'"
        ColumnSum(USE_QUERY)

    End Sub



End Class