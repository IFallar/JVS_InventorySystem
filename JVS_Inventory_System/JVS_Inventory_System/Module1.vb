Imports MySql.Data.MySqlClient
Imports System.Runtime.CompilerServices

Module Module1

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub opencon()
        con.ConnectionString = "server=localhost;port=3306;username=root;password=;database=jvs_inventory_database"
        con.Open()
    End Sub

    Public Function strconnection() As MySqlConnection
        Dim MsqlConn As MySqlConnection
        MsqlConn = New MySqlConnection
        MsqlConn.ConnectionString = "server=localhost;port=3306;username=root;password=;database=jvs_inventory_database"
        Return MsqlConn
    End Function

    Public strconn As MySqlConnection = strconnection()
    Public res As String
    Public cmdreader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public table As New DataTable

    Public Sub tableload(ByVal sql As String, ByVal dtg As Object)

        Try
            table = New DataTable
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
            End With

            adapter.SelectCommand = cmd
            adapter.Fill(table)
            dtg.DataSource = table

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconnection.Close()
        adapter.Dispose()
    End Sub

    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), ByVal item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

    Public Sub Load_Table_RE()

        Dim Filter_Value As String = Form1.ITM_FLTVAL_ITEM_CBX.Text

        If Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 0 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE ITEM_BRAND = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()

        ElseIf Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 1 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE CATEGORY = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()

        ElseIf Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 2 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE HOLDING_STATUS = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()

        ElseIf Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 3 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = '" & Filter_Value & "'", Form1.DataGridView1)
            strconn.Close()

        ElseIf Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 4 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE STOCK_STATUS = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()

        ElseIf Form1.ITM_FLTSET_ITEM_CBX.SelectedIndex = 5 Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE SUPPLIER = '" & Filter_Value & "' AND REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `CATEGORY` as Category, `UNIT_PRICE` as 'Unit Cost', `QUANTITY` as QTY, `STOCK_STATUS` as 'Stock Level', `HOLDING_STATUS` 'Holding Status', `MAX_SELL` as 'Max Price', `TOTAL_PRICE` as Total, `LAST_STOCK` as 'Last Restock' FROM `products` WHERE REPAIR_STATUS = 'NORMAL'", Form1.DataGridView1)
            strconn.Close()
        End If

    End Sub

End Module
