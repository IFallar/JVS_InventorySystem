﻿

Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub userName_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged

    End Sub

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click
        opencon()
        cmd.Connection = con
        cmd.CommandText = "SELECT `acc_id`,`usertype`, CONCAT(`acc_fn`, ' ' , `acc_ln`) as `UserName`, `acc_pass` FROM `account` WHERE usertype = '" & userType.SelectedItem & "' and CONCAT(`acc_fn`, ' ' , `acc_ln`) = '" & userName.Text & "' and acc_pass = '" & pass.Text & "'"
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

                a.acc_name_lbl.Text = userName.Text
                a.acc_type_lbl.Text = userType.SelectedItem
                Form1.GlobalVariables.UserID = table.Rows(0)(0)

                a.Show()
                Me.Hide()

            Else Dim u As New Form1
                'tentative showing form1'
                u.Show()
                Me.Hide()

            End If

        End If



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

        If pass.Text = "PASSWORD" Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

End Class