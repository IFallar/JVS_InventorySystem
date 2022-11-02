Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim tablemode As Integer = 1

    'FORMAT TABLE AND CELLS ================================================================================================================

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        If e.ColumnIndex = 8 And e.Value IsNot Nothing Then
            Dim content As String = e.Value
            If content = "LOW STOCK" Then
                e.CellStyle.BackColor = Color.Orange
            ElseIf content = "OUT OF STOCK" Then
                e.CellStyle.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '++++++++++++++++ SET MAIN TABLE VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `UNIT_PRICE` as Price, `QUANTITY` as QTY, `MAX_SELL` as Max, `CATEGORY` as Category, `STOCK_STATUS` as LEvel, `HOLDING_STATUS` Holding, `TOTAL_PRICE` as Total, `LAST_STOCK` as Last FROM `products` WHERE 1", DataGridView1)
        strconn.Close()

        Set_Home_Value()

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
                VALUE_ITEMS.Text = "P" + home_item_valuation

                home_item_qty = cmdreader.GetValue(1)
                VALUE_COUNT.Text = home_item_qty

                home_item_lowstock = cmdreader.GetValue(2)
                VALUE_LOWSTOCK.Text = home_item_lowstock

                home_item_laststock = cmdreader.GetValue(3)
                VALUE_LASTSTOCK.Text = home_item_laststock

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White

    End Sub

    Private Sub ITEM_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_ITEM_BTN.Click
        HOME_PANEL.Visible = False
        ITEM_PANEL.Visible = True
        LOG_PANEL.Visible = False

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.White
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.Transparent

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.White

    End Sub

    Private Sub LOG_BTN_Click(sender As Object, e As EventArgs) Handles SIDE_LOG_BTN.Click
        HOME_PANEL.Visible = False
        ITEM_PANEL.Visible = False
        LOG_PANEL.Visible = True

        SIDE_HOME_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_ITEM_BTN.BackColor = System.Drawing.Color.Transparent
        SIDE_LOG_BTN.BackColor = System.Drawing.Color.White

        SIDE_HOME_BTN.ForeColor = System.Drawing.Color.White
        SIDE_ITEM_BTN.ForeColor = System.Drawing.Color.White
        SIDE_LOG_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)

    End Sub

    '++++++++++++++++ MAIN SCREEN BUTTONS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub Darken_BG()
        Dim ADD_ITEM_MODAL As New Form

        ADD_ITEM_MODAL.StartPosition = FormStartPosition.Manual
        ADD_ITEM_MODAL.FormBorderStyle = FormBorderStyle.None
        ADD_ITEM_MODAL.Opacity = 0.5D
        ADD_ITEM_MODAL.BackColor = Color.Black
        ADD_ITEM_MODAL.WindowState = FormWindowState.Maximized
        ADD_ITEM_MODAL.TopMost = True
        ADD_ITEM_MODAL.Location = Location
        ADD_ITEM_MODAL.ShowInTaskbar = False
        ADD_ITEM_MODAL.Show()

    End Sub 'UNUSED SNIPPETS

    Private Sub HOME_ADD_ITEM_BTN_Click(sender As Object, e As EventArgs) Handles HOME_ADD_ITEM_BTN.Click

        Dim ADD_ITEM_MODAL As New Form

        Try
            Dim Modal As New Form_Add_Item
            Form_Add_Item.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub


End Class
