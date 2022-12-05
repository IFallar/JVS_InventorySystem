

Imports MySql.Data.MySqlClient

Public Class Login

    Dim acc_id As String
    Dim acc_type As String
    Dim userpass As String
    Dim valid As Boolean = True

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `acc_id`,`usertype`, `acc_pass` FROM `account` WHERE usertype = '" & userType.SelectedItem & "' and CONCAT(`acc_fn`, ' ' , `acc_ln`) = '" & userName.Text & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                acc_id = cmdreader.GetValue(0)
                acc_type = cmdreader.GetValue(1)
                userpass = cmdreader.GetValue(2)
                valid = True

            Catch ex As System.InvalidCastException

                MessageBox.Show("Account Does Not Exist")

            End Try

        End While

        cmdreader.Close()
        con.Close()

        If pass.Text = userpass Then



            If acc_type = "admin" Then

                Dim a As New Form1

                Form1.acc_name_lbl.Text = userName.Text
                Form1.acc_type_lbl.Text = userType.SelectedItem
                Form1.GlobalVariables.logged_priv = 0
                Form1.GlobalVariables.UserID = acc_id
                Form1.GlobalVariables.logged = 1
                MessageBox.Show("Welcome " + userName.Text + "!")

                Me.Hide()

                userName.Text = "USERNAME"
                userName.ForeColor = Color.Silver
                pass.Text = "PASSWORD"
                pass.ForeColor = Color.Silver
                userType.Text = "ACCOUNT TYPE"
                PictureBox2.Image = My.Resources.account_ico

                Form1.Show_Home()

            ElseIf acc_type = "user" Then

                Dim a As New Form1

                Form1.acc_name_lbl.Text = userName.Text
                Form1.acc_type_lbl.Text = userType.SelectedItem
                Form1.GlobalVariables.logged_priv = 1
                Form1.GlobalVariables.UserID = acc_id
                Form1.GlobalVariables.logged = 1
                MessageBox.Show("Welcome " + userName.Text + "!")

                Me.Hide()

                userName.Text = "USERNAME"
                userName.ForeColor = Color.Silver
                pass.Text = "PASSWORD"
                pass.ForeColor = Color.Silver
                userType.Text = "ACCOUNT TYPE"
                PictureBox2.Image = My.Resources.account_ico

                Form1.Show_Home()

            End If

        Else

            MessageBox.Show("Invalid Credentials")

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
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub userType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userType.SelectedIndexChanged

        If userType.Text = "User" Then
            PictureBox2.Image = My.Resources.usericon
        ElseIf userType.Text = "Admin" Then
            PictureBox2.Image = My.Resources.Admin
        Else
            PictureBox2.Image = My.Resources.account_ico
        End If

    End Sub

End Class