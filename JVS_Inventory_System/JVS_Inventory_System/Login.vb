﻿

Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub userName_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged




    End Sub

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click
        opencon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM `log_in` WHERE usertype = '" & userType.SelectedItem & "'and username = '" & userName.Text & "'and password = '" & pass.Text & "'"
        cmd.Prepare()
        adapter = New MySqlDataAdapter(cmd)
        table = New DataTable
        adapter.Fill(table)
        con.Close()


        If table.Rows.Count > 0 Then
            MessageBox.Show("Welcome " + table.Rows(0)(2) + "!")

            If userType.SelectedIndex = 0 Then
                'tentative showing form1'
                Dim a As New Form1
                a.Show()
                Me.Hide()

            Else Dim u As New Form1
                'tentative showing form1'
                u.Show()
                Me.Hide()

            End If

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub USERNAME_ENTER(sender As Object, e As EventArgs) Handles userName.Enter
        If userName.Text = "USERNAME" Then
            userName.Text = ""
            userName.ForeColor = Color.Black
        End If

    End Sub

    Private Sub USERNAME_LEAVE(sender As Object, e As EventArgs) Handles userName.Leave
        If userName.Text = "" Then
            userName.Text = "USERNAME"
            userName.ForeColor = Color.Silver

        End If
    End Sub

    Private Sub PASSWORD_ENTER(sender As Object, e As EventArgs) Handles pass.Enter

        If pass.Text = "PASSWORD"  Then
            pass.Text = ""
            pass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PASSWORD_LEAVE(sender As Object, e As EventArgs) Handles pass.Leave

        If pass.Text = "" Then
            pass.Text = "PASSWORD"
            pass.ForeColor = Color.Silver
        End If
    End Sub


End Class