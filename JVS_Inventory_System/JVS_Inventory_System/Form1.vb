Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim tablemode As Integer = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'tableload("SELECT `item_ID`, `item_Name`, `item_Brand`, `item_Variant`, `item_Price` FROM `items` WHERE 1", DataGridView1)
        'strconn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    'BUTTON EVENTS EVENTS 

    Private Sub ITEM_BTN_MouseEnter(sender As Object, e As EventArgs) Handles ITEM_BTN.MouseEnter
        ITEM_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
    End Sub

    Private Sub ITEM_BTN_MouseLeave(sender As Object, e As EventArgs) Handles ITEM_BTN.MouseLeave
        ITEM_BTN.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub LOG_BTN_MouseEnter(sender As Object, e As EventArgs) Handles LOG_BTN.MouseEnter
        LOG_BTN.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
    End Sub

    Private Sub LOG_BTN_MouseLeave(sender As Object, e As EventArgs) Handles LOG_BTN.MouseLeave
        LOG_BTN.ForeColor = System.Drawing.Color.White
    End Sub

End Class
