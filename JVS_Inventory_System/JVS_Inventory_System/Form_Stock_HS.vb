Public Class Form_Stock_HS

    Private Sub Form_Stock_HS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FSHS_ITEM_TBX_TextChanged(sender As Object, e As EventArgs) Handles FSHS_ITEM_TBX.TextChanged

        tableload("SELECT `ITEM_ID` as ID, `ITEM_NAME` as Name, `ITEM_BRAND` as Brand, `VARIANT` as Variant FROM `products` WHERE ITEM_NAME LIKE '%" & FSHS_ITEM_TBX.Text & "%' OR ITEM_BRAND LIKE '%" & FSHS_ITEM_TBX.Text & "%' OR VARIANT LIKE '%" & FSHS_ITEM_TBX.Text & "%'", SEARCH_GRID)
        strconn.Close()

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

End Class