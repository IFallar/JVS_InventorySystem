Imports System.ComponentModel
Public Class Form_Out_Value

    Public Sub Range_Getter()

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        tableload("SELECT log_id, COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `r_qty` AS 'CHANGE', (SELECT TIME_FORMAT(r_time, '%h:%i %p')) AS 'TIME', r_date AS 'DATE', (SELECT(SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1)) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT' AND (r_date BETWEEN '" & DateL_F & "' AND '" & DateU_F & "')", DataGridView2)
        strconn.Close()

    End Sub

    Public Sub Set_Totals(DayIV, DateL_F, DateU_F)

        If Range_Panel.Width = 10 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT SUM(`r_qty`) AS 'CHANGE', (SELECT SUM((SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1))) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT' AND  r_date >= DATE(NOW() - INTERVAL " & DayIV & " DAY)"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read

                Try

                    QTY_TT.Text = cmdreader.GetValue(0)
                    TTV_TT.Text = cmdreader.GetValue(1)

                Catch ex As System.InvalidCastException

                End Try

            End While

            cmdreader.Close()
            con.Close()

        ElseIf Range_Panel.Width = 355 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT SUM(`r_qty`) AS 'CHANGE', (SELECT SUM((SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1))) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT' AND (r_date BETWEEN '" & DateL_F & "' AND '" & DateU_F & "')"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read

                Try

                    QTY_TT.Text = cmdreader.GetValue(0)
                    TTV_TT.Text = cmdreader.GetValue(1)

                Catch ex As System.InvalidCastException

                End Try

            End While

            cmdreader.Close()
            con.Close()

        End If

    End Sub

    Private Sub Form_Out_Value_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LowerDate.Value = Date.Now()
        Upper_Date.Value = Date.Now()

        Dim Now As Date = Date.Now()
        Dim Now_F = Now.ToString("yyyy\-MM\-dd")

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        tableload("SELECT log_id, COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `r_qty` AS 'CHANGE', (SELECT TIME_FORMAT(r_time, '%h:%i %p')) AS 'TIME', r_date AS 'DATE', (SELECT(SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1)) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT'", DataGridView2)
        strconn.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT SUM(`r_qty`) AS 'CHANGE', (SELECT SUM((SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1))) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT' AND r_date >= DATE(NOW() - INTERVAL 7 DAY)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                QTY_TT.Text = cmdreader.GetValue(0)
                TTV_TT.Text = cmdreader.GetValue(1)

            Catch ex As System.InvalidCastException

                QTY_TT.Text = 0
                TTV_TT.Text = 0

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub DataGridView2_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete

        DataGridView2.RowTemplate.Resizable = False
        DataGridView2.Columns(0).Width = 0
        DataGridView2.Columns(1).Width = 150
        DataGridView2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(3).Width = 100

        DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView2.RowTemplate.MinimumHeight = 40
        DataGridView2.Sort(DataGridView2.Columns(0), ListSortDirection.Descending)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Range_Panel.Width = 10
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Range_Panel.Width = 355
    End Sub


    Private Sub LowerDate_ValueChanged(sender As Object, e As EventArgs) Handles LowerDate.ValueChanged

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        Range_Getter()

        Set_Totals(30, DateL_F, DateU_F)

    End Sub

    Private Sub Upper_Date_ValueChanged(sender As Object, e As EventArgs) Handles Upper_Date.ValueChanged

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        Range_Getter()

        Set_Totals(30, DateL_F, DateU_F)

    End Sub

    Private Sub Date_Rng_CBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Date_Rng_CBX.SelectedIndexChanged

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        Dim DayIntv As Integer

        If Date_Rng_CBX.SelectedIndex = 0 Then
            DayIntv = 7
        ElseIf Date_Rng_CBX.SelectedIndex = 1 Then
            DayIntv = 14
        ElseIf Date_Rng_CBX.SelectedIndex = 2 Then
            DayIntv = 30
        ElseIf Date_Rng_CBX.SelectedIndex = 3 Then
            DayIntv = 180
        ElseIf Date_Rng_CBX.SelectedIndex = 4 Then
            DayIntv = 365
        End If

        tableload("SELECT log_id, COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `r_qty` AS 'CHANGE', (SELECT TIME_FORMAT(r_time, '%h:%i %p')) AS 'TIME', r_date AS 'DATE', (SELECT(SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1)) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT' AND  r_date >= DATE(NOW() - INTERVAL " & DayIntv & " DAY)", DataGridView2)
        strconn.Close()

        Set_Totals(DayIntv, DateL_F, DateU_F)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LowerDate.Value = Date.Now()
        Upper_Date.Value = Date.Now()

        Dim DateL As Date = LowerDate.Value
        Dim DateL_F = DateL.ToString("yyyy\-MM\-dd")
        Dim DateU As Date = Upper_Date.Value
        Dim DateU_F = DateU.ToString("yyyy\-MM\-dd")

        Date_Rng_CBX.Text = "Range:"

        tableload("SELECT log_id, COALESCE ((SELECT CONCAT(`ITEM_NAME`, ' | ' , `VARIANT`) FROM products WHERE ITEM_ID = `r_item_id`), 'ITEM DELETED') AS 'ITEM', `r_qty` AS 'CHANGE', (SELECT TIME_FORMAT(r_time, '%h:%i %p')) AS 'TIME', r_date AS 'DATE', (SELECT(SELECT UNIT_PRICE FROM products WHERE ITEM_ID = r_item_id) * (r_qty * -1)) AS 'VALUE' FROM `transaction_log` WHERE `transaction_type` = 'STOCK OUT'", DataGridView2)
        strconn.Close()

        Set_Totals(30, DateL_F, DateU_F)

    End Sub

End Class