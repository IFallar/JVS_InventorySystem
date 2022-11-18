Public Class Form_Stock_HS

    Public Sub GetNum()

        Dim QTY As Integer
        Dim TRH As Integer

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `QUANTITY`, `THRESHOLD` FROM `products` WHERE `ITEM_ID` = '" & Selected_HS & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                QTY = cmdreader.GetValue(0)
                TRH = cmdreader.GetValue(1)

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

        FSHS_FLT4_TBX.Text = "" & QTY & " / " & TRH & ""

        If QTY >= TRH And QTY > 0 Then
            FSHS_FLT4_TBX.BackColor = Color.Green
        ElseIf QTY = 0 Then
            FSHS_FLT4_TBX.BackColor = Color.Red
        Else
            FSHS_FLT4_TBX.BackColor = Color.Orange
        End If

    End Sub

    Private Sub Form_Stock_HS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    '++++++++++++++++ SET TABLE (RUDIMENTRARY) ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub FSHS_ITEM_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_ITEM_TBX.TextChanged

        If FSHS_ITEM_TBX.Text = "" Then
            FSHS_FLT1_TBX.ReadOnly = True
            FSHS_FLT2_TBX.ReadOnly = True
            SEARCH_GRID.Visible = False
        Else
            SEARCH_GRID.Visible = True
            FSHS_FLT1_TBX.ReadOnly = False
            FSHS_FLT2_TBX.ReadOnly = False
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If

    End Sub

    Private Sub FSHS_FLT1_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.TextChanged

        If FSHS_FLT2_TBX.Text = "VARIANT" Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If


    End Sub

    Private Sub FSHS_FLT2_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.TextChanged

        If FSHS_FLT1_TBX.Text = "BRAND" Then
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        Else
            tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant, `QUANTITY` as QUANTITY  FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' AND ITEM_BRAND LIKE '%" & FSHS_FLT1_TBX.Text & "%' AND VARIANT LIKE '%" & FSHS_FLT2_TBX.Text & "%'", SEARCH_GRID)
            strconn.Close()
        End If

    End Sub

    Private Sub SEARCH_GRID_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles SEARCH_GRID.CellBeginEdit
        If e.ColumnIndex > 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SEARCH_GRID_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles SEARCH_GRID.DataBindingComplete

        SEARCH_GRID.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        SEARCH_GRID.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        SEARCH_GRID.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        SEARCH_GRID.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        SEARCH_GRID.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub


    Dim Selected_HS As Integer = Nothing

    Private Sub SEARCH_GRID_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles SEARCH_GRID.CellValueChanged

        If (SEARCH_GRID.Columns(0).Name = "cbx_column") Then

            If SEARCH_GRID.CurrentRow.Cells(0).Value = "Yes" Then
                Selected_HS = SEARCH_GRID.CurrentRow.Cells(1).Value
            End If

        End If

    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles SEARCH_GRID.CurrentCellDirtyStateChanged

        If (SEARCH_GRID.IsCurrentCellDirty) Then
            SEARCH_GRID.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

        FSHS_ITEM_TBX.Text = SEARCH_GRID.CurrentRow.Cells(2).Value
        FSHS_FLT1_TBX.Text = SEARCH_GRID.CurrentRow.Cells(3).Value
        FSHS_FLT2_TBX.Text = SEARCH_GRID.CurrentRow.Cells(4).Value
        SEARCH_GRID.Visible = False

        GetNum()

    End Sub



    '++++++++++++++++ PLACEHOLDER HANDLING (RUDIMENTRARY) ++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub FSHS_FLT1_TBX_GotFocus(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.GotFocus

        If FSHS_FLT2_TBX.ReadOnly = False Then
            FSHS_FLT1_TBX.ForeColor = Color.Black
            FSHS_FLT1_TBX.Text = ""
        End If

    End Sub

    Private Sub FSHS_FLT1_TBX_LoseFocus(sender As Object, e As EventArgs) Handles FSHS_FLT1_TBX.LostFocus

        If FSHS_FLT1_TBX.Text = "" Then
            FSHS_FLT1_TBX.ForeColor = Color.Gray
            FSHS_FLT1_TBX.Text = "BRAND"
        End If

    End Sub

    Private Sub FSHS_FLT2_TBX_GotFocus(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.GotFocus

        If FSHS_FLT2_TBX.ReadOnly = False Then
            FSHS_FLT2_TBX.ForeColor = Color.Black
            FSHS_FLT2_TBX.Text = ""
        End If


    End Sub

    Private Sub FSHS_FLT2_TBX_LoseFocus(sender As Object, e As EventArgs) Handles FSHS_FLT2_TBX.LostFocus

        If FSHS_FLT2_TBX.Text = "" Then
            FSHS_FLT2_TBX.ForeColor = Color.Gray
            FSHS_FLT2_TBX.Text = "VARIANT"
        End If

    End Sub



    Private Sub FSHS_ADD_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_ADD_BTN.Click

        If FSHS_NUM_TBX.Text = Nothing Then
            FSHS_NUM_TBX.Text = 1
        Else
            Dim R_Value As Integer = FSHS_NUM_TBX.Text
            R_Value = R_Value + 1
            FSHS_NUM_TBX.Text = R_Value
        End If

    End Sub

    Private Sub FSHS_MIN_BTN_Click(sender As Object, e As EventArgs) Handles FSHS_MIN_BTN.Click

        If FSHS_NUM_TBX.Text = Nothing Then
            FSHS_NUM_TBX.Text = 0
        ElseIf FSHS_NUM_TBX.Text = 0 Then
            FSHS_NUM_TBX.Text = 0
        Else
            Dim R_Value As Integer = FSHS_NUM_TBX.Text
            R_Value = R_Value - 1
            FSHS_NUM_TBX.Text = R_Value
        End If

    End Sub

End Class