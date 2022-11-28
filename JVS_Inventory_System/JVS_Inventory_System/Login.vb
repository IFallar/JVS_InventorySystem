

Imports MySql.Data.MySqlClient

Public Class Login

    Dim acc_id As String
    Dim usetype As String
    Dim usename As String
    Dim userpass As String
    Dim valid As Boolean = False

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `acc_id`,`usertype`, CONCAT(`acc_fn`, ' ' , `acc_ln`) as `UserName`, `acc_pass` FROM `account` WHERE usertype = '" & userType.SelectedItem & "' and CONCAT(`acc_fn`, ' ' , `acc_ln`) = '" & userName.Text & "' and acc_pass = '" & pass.Text & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                acc_id = cmdreader.GetValue(0)
                usetype = cmdreader.GetValue(1)
                usename = cmdreader.GetValue(2)
                userpass = cmdreader.GetValue(3)
                valid = True

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

        If valid = True Then
            MessageBox.Show("Welcome " + usename + "!")

            If userType.SelectedIndex = 0 Then
                'tentative showing form1'
                Dim a As New Form1

                a.acc_name_lbl.Text = userName.Text
                a.acc_type_lbl.Text = userType.SelectedItem
                Form1.GlobalVariables.UserID = acc_id
                Form1.GlobalVariables.logged = 1

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