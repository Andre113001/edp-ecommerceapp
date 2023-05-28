Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class frmRegister
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub chckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckPassword.CheckedChanged
        If chckPassword.Checked Then
            tbPass.UseSystemPasswordChar = False
            tbConPass.UseSystemPasswordChar = False
        Else
            tbPass.UseSystemPasswordChar = True
            tbConPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validate_email(tbEmail.Text) = True Then
            lblErrorEmail.Visible = False
            If tbPass.Text <> tbConPass.Text Then
                lblErrorPass.Text = "* The password does not match"
                lblErrorPass.Visible = True
            Else
                lblErrorPass.Visible = False
                'MsgBox("Proceed to Register")
                register_user(email:=tbEmail.Text, password:=tbConPass.Text, username:=tbUsername.Text)
                Me.Hide()
                frmLogin.Show()
            End If
        Else
            lblErrorEmail.Text = "* Email Address is not valid"
            lblErrorEmail.Visible = True
        End If


    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblErrorEmail.Visible = False
        lblErrorUsername.Visible = False
        lblErrorPass.Visible = False
        Me.CenterToScreen()
    End Sub
End Class