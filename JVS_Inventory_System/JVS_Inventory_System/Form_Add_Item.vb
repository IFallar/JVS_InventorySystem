﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form_Add_Item

    
    Private Sub Form_Add_Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'INITIATE MODAL ================================================================================================================

        '++++++++++++++++ ADD COMBO BOX VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        FAI_CBX_ITEM_BRAND.Items.Clear()
        FAI_CBX_ITEM_CAT.Items.Clear()
        FAI_CBX_ITEM_MODEL.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT BRAND_NAME FROM (brands)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_brands = cmdreader.GetString("BRAND_NAME")
            FAI_CBX_ITEM_BRAND.Items.Add(list_brands)
        End While

        cmdreader.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT variant_name FROM variants"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_variants = cmdreader.GetString("variant_name")
            FAI_CBX_ITEM_MODEL.Items.Add(list_variants)
        End While

        cmdreader.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT categories_name FROM categories"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim list_categories = cmdreader.GetString("categories_name")
            FAI_CBX_ITEM_CAT.Items.Add(list_categories)
        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub FAI_BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles FAI_BTN_CANCEL.Click

        Try
            Me.Close()

        Catch ex As Exception

        End Try

        Form1.Load_Table_Main()
        Form1.Set_Home_Value()

    End Sub

    Private Sub FAI_BTN_SAVE_Click(sender As Object, e As EventArgs) Handles FAI_BTN_SAVE.Click

        '++++++++++++++++ INPUT VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim ITEM_NAME As String
        Dim ITEM_BRAND As String
        Dim ITEM_CAT As String
        Dim ITEM_HLDSTAT As String
        Dim ITEM_MODEL As String
        Dim ITEM_RPS As String

        Dim ITEM_INIT As Integer
        Dim ITEM_TRHD As Integer
        Dim TOPAY As Integer
        Dim ITEM_PC As Integer
        Dim ITEM_MAX As Integer
        Dim ITEM_MIN As Integer

        '++++++++++++++++ GENERATED VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim ITEM_STATUS As String
        Dim ITEM_ADD_DATE As String
        Dim ITEM_TOTAL As Integer

        '++++++++++++++++ GET AND SET VALUES SECTION ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Try

            ITEM_NAME = FAI_TBX_ITEM_NAME.Text
            ITEM_BRAND = FAI_CBX_ITEM_BRAND.Text
            ITEM_CAT = FAI_CBX_ITEM_CAT.Text
            ITEM_HLDSTAT = FAI_CBX_ITEM_HLDSTAT.Text
            ITEM_MODEL = FAI_CBX_ITEM_MODEL.Text


            ITEM_INIT = FAI_TBX_ITEM_INIT.Text
            ITEM_TRHD = FAI_TBX_ITEM_TRHD.Text
            TOPAY = FAI_TBX_TOPAY.Text
            ITEM_PC = FAI_TBX_ITEM_PC.Text
            ITEM_MAX = FAI_TBX_ITEM_MAX.Text
            ITEM_MIN = FAI_TBX_ITEM_MIN.Text

            ITEM_RPS = "NORMAL"
            ITEM_TOTAL = ITEM_INIT * ITEM_PC

            Dim x As String = ""

            If ITEM_INIT >= ITEM_TRHD Then
                x = "NORMAL"
            ElseIf ITEM_INIT < ITEM_TRHD And ITEM_INIT > 0 Then
                x = "LOW STOCK"
            ElseIf ITEM_INIT = 0 Then
                x = "OUT OF STOCK"
            End If

            ITEM_STATUS = x

            Dim regDate As Date = Date.Now()
            ITEM_ADD_DATE = regDate.ToString("yyyy\-MM\-dd")

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `products`(`ITEM_ID`, `ITEM_NAME`, `ITEM_BRAND`, `VARIANT`, `UNIT_PRICE`, `QUANTITY`, `MIN_SELL`, `MAX_SELL`, `CATEGORY`, `THRESHOLD`, `STOCK_STATUS`, `REPAIR_STATUS`, `HOLDING_STATUS`, `TOTAL_PRICE`, `LAST_STOCK`) VALUES (DEFAULT,'" & ITEM_NAME & "','" & ITEM_BRAND & "','" & ITEM_MODEL & "','" & ITEM_PC & "','" & ITEM_INIT & "','" & ITEM_MIN & "','" & ITEM_MAX & "','" & ITEM_CAT & "','" & ITEM_TRHD & "','" & ITEM_STATUS & "','" & ITEM_RPS & "','" & ITEM_HLDSTAT & "','" & ITEM_TOTAL & "','" & ITEM_ADD_DATE & "'); UPDATE `latest_date` SET `last_restock`='" & ITEM_ADD_DATE & "' WHERE 1"
            cmd.ExecuteNonQuery()
            MsgBox("ITEM SUCCESSFULY ADDED", MsgBoxStyle.OkOnly, "Action Confirmation")
            strconn.Close()

            Form1.Load_Table_Main()
            Form1.Set_Home_Value()


        Catch ex As System.InvalidCastException

            MsgBox("Please Enter all necessary Information.", MsgBoxStyle.OkOnly, "Incomplete Information")

        End Try

    End Sub

    Private Sub FAI_BTN_RESET_Click(sender As Object, e As EventArgs) Handles FAI_BTN_RESET.Click

        FAI_TBX_ITEM_NAME.ResetText()
        FAI_TBX_ITEM_INIT.ResetText()
        FAI_TBX_ITEM_TRHD.ResetText()
        FAI_TBX_TOPAY.ResetText()
        FAI_TBX_ITEM_PC.ResetText()
        FAI_TBX_ITEM_MAX.ResetText()
        FAI_TBX_ITEM_MIN.ResetText()

        FAI_CBX_ITEM_BRAND.ResetText()
        FAI_CBX_ITEM_CAT.ResetText()
        FAI_CBX_ITEM_HLDSTAT.ResetText()
        FAI_CBX_ITEM_MODEL.ResetText()

        FAI_TBX_TOPAY.BackColor = Color.White
        FAI_TBX_TOPAY.ReadOnly = False

        Form1.Load_Table_Main()
        Form1.Set_Home_Value()

    End Sub

    Private Sub FAI_CBX_ITEM_HLDSTAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FAI_CBX_ITEM_HLDSTAT.SelectedIndexChanged

        If FAI_CBX_ITEM_HLDSTAT.SelectedIndex = 0 Then

            FAI_TBX_TOPAY.BackColor = Color.DimGray
            FAI_TBX_TOPAY.Text() = 0
            FAI_TBX_TOPAY.ReadOnly = True

        Else

            FAI_TBX_TOPAY.BackColor = Color.White
            FAI_TBX_TOPAY.Text() = ""
            FAI_TBX_TOPAY.ReadOnly = False

        End If

    End Sub

End Class