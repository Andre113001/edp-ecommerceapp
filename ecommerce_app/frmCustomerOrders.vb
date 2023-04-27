Public Class frmCustomerOrders
    Private Sub frmCustomerOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Admin_Function(dg:=dgCustomerOrders, tableName:="customerorders")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        export_excel(dgName:=dgCustomerOrders, type:="Customer Orders", directory:="C:\Users\1130m\Documents\School Works\BSIT 3B - 2nd Semester\IT 120 - EDP\Try\ecommerce_app\export\Templates\Customer Orders Template.xlsx")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class