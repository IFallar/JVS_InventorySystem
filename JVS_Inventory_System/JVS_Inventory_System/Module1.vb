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
    'create function used in settings'

    Public Sub create(ByRef sql As String)
        Try
            strconn.Open()

            With cmd
                .Connection = strconn
                .CommandText = sql
                res = cmd.ExecuteNonQuery
                If res = 0 Then
                    MessageBox.Show("Failed to add data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data successfully added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    'update function used in settings'
    Public Sub update(ByRef sql As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
                res = cmd.ExecuteNonQuery
                If res = 0 Then
                    MessageBox.Show("Failed to update data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data successfully updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    'delete function used in settings'
    Public Sub delete(ByRef sql As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
                res = cmd.ExecuteNonQuery
                If res = 0 Then
                    MessageBox.Show("Failed to delete data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data successfully deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), ByVal item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

End Module
