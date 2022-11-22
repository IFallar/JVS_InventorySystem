Public Class Form_Valuation

    Dim Query_Max As String = "Select SUM(QUANTITY * UNIT_PRICE) as TOTAL, SUM(TO_PAY) as LIABILITIES, SUM(MAX_SELL - UNIT_PRICE) as 'TOTAL MARGIN', SUM(MAX_SELL * QUANTITY) as 'TOTAL VALUE' From products"
    Dim Query_Min As String = "Select SUM(QUANTITY * UNIT_PRICE) as TOTAL, SUM(TO_PAY) as LIABILITIES, SUM(MIN_SELL - UNIT_PRICE) as 'TOTAL MARGIN', SUM(MIN_SELL * QUANTITY) as 'TOTAL VALUE' From products"

    Dim USE_QUERY = Query_Max

    Public Sub ColumnSum()

        opencon()

        cmd.Connection = con
        cmd.CommandText = USE_QUERY
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

    Dim TQ_MAX = "Select ITEM_NAME AS 'PRODUCT', QUANTITY, UNIT_PRICE as 'UNIT COST', QUANTITY * UNIT_PRICE as 'TOTAL COST', TO_PAY as 'LIABILITIES', MAX_SELL as 'SELL PRICE', MAX_SELL - UNIT_PRICE as MARGIN, MAX_SELL * QUANTITY as 'FULL TOTAL' From products"
    Dim TQ_MIN = "Select ITEM_NAME AS 'PRODUCT', QUANTITY, UNIT_PRICE as 'UNIT COST', QUANTITY * UNIT_PRICE as 'TOTAL COST', TO_PAY as 'LIABILITIES', MIN_SELL as 'SELL PRICE', MIN_SELL - UNIT_PRICE as MARGIN, MIN_SELL * QUANTITY as 'FULL TOTAL' From products"

    Dim TQ_MAX_TM = "Select ITEM_NAME AS 'PRODUCT', QUANTITY, UNIT_PRICE as 'UNIT COST', QUANTITY * UNIT_PRICE as 'TOTAL COST', TO_PAY as 'LIABILITIES', MAX_SELL as 'SELL PRICE', (MAX_SELL * QUANTITY) - (QUANTITY * UNIT_PRICE) as MARGIN, MAX_SELL * QUANTITY as 'FULL TOTAL' From products"
    Dim TQ_MIN_TM = "Select ITEM_NAME AS 'PRODUCT', QUANTITY, UNIT_PRICE as 'UNIT COST', QUANTITY * UNIT_PRICE as 'TOTAL COST', TO_PAY as 'LIABILITIES', MIN_SELL as 'SELL PRICE', (MIN_SELL * QUANTITY) - (QUANTITY * UNIT_PRICE) as MARGIN, MIN_SELL * QUANTITY as 'FULL TOTAL' From products"


    Dim TQ_USE_QUERY As String = TQ_MIN

    Private Sub Form_Valuation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '++++++++++++++++ SET MAIN TABLE VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        tableload(TQ_USE_QUERY, VALUE_GRID)
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

    Private Sub PRICE_BTN_Click(sender As Object, e As EventArgs) Handles PRICE_BTN.Click

        If PRICE_BTN.Text = "Maximum" Then
            If MARGIN_BTN.Text = "Item" Then
                USE_QUERY = Query_Min
                TQ_USE_QUERY = TQ_MIN
                PRICE_BTN.Text = "Minimum"
            Else
                USE_QUERY = Query_Min
                TQ_USE_QUERY = TQ_MIN_TM
                PRICE_BTN.Text = "Minimum"
            End If

        ElseIf PRICE_BTN.Text = "Minimum" Then
            If MARGIN_BTN.Text = "Item" Then
                USE_QUERY = Query_Max
                TQ_USE_QUERY = TQ_MAX
                PRICE_BTN.Text = "Maximum"
            Else
                USE_QUERY = Query_Max
                TQ_USE_QUERY = TQ_MAX_TM
                PRICE_BTN.Text = "Maximum"
            End If

        End If

        tableload(TQ_USE_QUERY, VALUE_GRID)
        strconn.Close()

        ColumnSum()

    End Sub

    Private Sub MARGIN_BTN_Click(sender As Object, e As EventArgs) Handles MARGIN_BTN.Click

        If MARGIN_BTN.Text = "Item" Then
            If PRICE_BTN.Text = "Maximum" Then
                USE_QUERY = Query_Max
                TQ_USE_QUERY = TQ_MAX_TM
                MARGIN_BTN.Text = "Total"
            Else
                USE_QUERY = Query_Min
                TQ_USE_QUERY = TQ_MIN_TM
                MARGIN_BTN.Text = "Total"
            End If
        ElseIf MARGIN_BTN.Text = "Total" Then
            If PRICE_BTN.Text = "Maximum" Then
                USE_QUERY = Query_Max
                TQ_USE_QUERY = TQ_MAX
                MARGIN_BTN.Text = "Item"
            Else
                USE_QUERY = Query_Min
                TQ_USE_QUERY = TQ_MIN
                MARGIN_BTN.Text = "Item"
            End If

        End If

        tableload(TQ_USE_QUERY, VALUE_GRID)
        strconn.Close()

        ColumnSum()

    End Sub

End Class