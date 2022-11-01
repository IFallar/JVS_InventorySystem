﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form_Add_Item

    
    Private Sub Form_Add_Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'INITIATE MODAL ================================================================================================================

        '++++++++++++++++ ADD COMBO BOX VALUES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        FAI_CBX_ITEM_BRAND.Items.Clear()

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

    End Sub

    Private Sub FAI_BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles FAI_BTN_CANCEL.Click

        Try
            Me.Close()

        Catch ex As Exception

        End Try

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

            Select Case True
                Case ITEM_INIT >= ITEM_TRHD
                    ITEM_STATUS = "NORMAL"
                Case ITEM_INIT < ITEM_TRHD
                    ITEM_STATUS = "LOW STOCK"
                Case ITEM_INIT = 0
                    ITEM_STATUS = "OUT OF STOCK"
            End Select

            Dim regDate As Date = Date.Now()
            ITEM_ADD_DATE = regDate.ToString("yyyy\-MM\-dd")

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `products`(`ITEM_ID`, `ITEM_NAME`, `ITEM_BRAND`, `VARIANT`, `UNIT_PRICE`, `QUANTITY`, `MIN_SELL`, `MAX_SELL`, `CATEGORY`, `THRESHOLD`, `STOCK_STATUS`, `REPAIR_STATUS`, `HOLDING_STATUS`, `TOTAL_PRICE`, `LAST_STOCK`) VALUES (DEFAULT,'" & ITEM_NAME & "','" & ITEM_BRAND & "','" & ITEM_MODEL & "','" & ITEM_PC & "','" & ITEM_INIT & "','" & ITEM_MIN & "','" & ITEM_MAX & "','" & ITEM_CAT & "','" & ITEM_TRHD & "','" & ITEM_STATUS & "','" & ITEM_RPS & "','" & ITEM_HLDSTAT & "','" & ITEM_TOTAL & "','" & ITEM_ADD_DATE & "'); UPDATE `latest_date` SET `last_restock`='" & ITEM_ADD_DATE & "' WHERE 1"
            cmd.ExecuteNonQuery()
            MsgBox("ITEM SUCCESSFULY ADDED", MsgBoxStyle.OkOnly, "Action Confirmation")
            strconn.Close()

            Form1.Set_Home_Value()

        Catch ex As System.InvalidCastException

            MsgBox("Please Enter all proper Information.", MsgBoxStyle.OkOnly, "Incomplete Information")

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

        Form1.Set_Home_Value()

    End Sub

    Private Sub FAI_CBX_ITEM_HLDSTAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FAI_CBX_ITEM_HLDSTAT.SelectedIndexChanged

        If FAI_CBX_ITEM_HLDSTAT.SelectedIndex = 0 Then

            FAI_TBX_TOPAY.BackColor = Color.DimGray
            FAI_TBX_TOPAY.Text() = 0
            FAI_TBX_TOPAY.ReadOnly = True

        End If

    End Sub

End Class