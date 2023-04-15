Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub chckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckPassword.CheckedChanged
        If chckPassword.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM users WHERE Email=@Email AND Password=@Password", conn)
            cmd.Parameters.AddWithValue("Email", TextBox1.Text.Trim)
            cmd.Parameters.AddWithValue("Password", TextBox2.Text.Trim)
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader

            If reader.Read Then
                frmWelcome.Show()
                Me.Hide()
                conn.Close()
            Else
                MsgBox("Incorrect Email or Password")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
