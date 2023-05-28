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
        login_user(email:=TextBox1.Text, password:=TextBox2.Text)
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub linkRegister_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
