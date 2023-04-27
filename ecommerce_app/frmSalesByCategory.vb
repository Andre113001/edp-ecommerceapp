Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class frmSalesByCategory
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub frmSalesByCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Admin_Function(dg:=dgPbC, tableName:="productsalesbycategory")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        export_excel(dgName:=dgPbC, directory:="C:\Users\1130m\Documents\School Works\BSIT 3B - 2nd Semester\IT 120 - EDP\Try\ecommerce_app\export\Templates\Product Sales by Category Template.xlsx", type:="Product Sales by Category")
    End Sub
End Class