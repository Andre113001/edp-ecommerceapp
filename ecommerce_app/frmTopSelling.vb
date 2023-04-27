Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class frmTopSelling
    Dim mycmd As New MySqlCommand
    Dim dadapter As MySqlDataAdapter
    Dim dtable As DataTable
    Dim objdatareader As MySqlDataReader

    Private Sub frmTopSelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Admin_Function(dg:=dgTopSelling, tableName:="topsellingproducts")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        export_excel(dgName:=dgTopSelling, directory:="C:\Users\1130m\Documents\School Works\BSIT 3B - 2nd Semester\IT 120 - EDP\Try\ecommerce_app\export\Templates\Top Selling Template.xlsx", type:="Top Selling")
    End Sub

End Class