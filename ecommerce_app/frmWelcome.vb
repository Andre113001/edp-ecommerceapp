Imports MySql.Data.MySqlClient

Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim username As String = fetch_user(frmLogin.TextBox1.Text)
        lbUsername.Text = username

        Connect_To_DB()
        Dim sql As String = "SELECT * FROM products"
        Dim dataAdapter As New MySqlDataAdapter(sql, conn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, "products")
        conn.Close()
        dgProducts.DataSource = dataSet.Tables("products")
        dgProducts.ReadOnly = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        conn.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim quant As Integer
        quant = Convert.ToDecimal(lblQuantity.Text)
        quant += 1
        lblQuantity.Text = quant.ToString()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim quant As Integer
        quant = Convert.ToDecimal(lblQuantity.Text)
        quant -= 1
        If (quant > 0) Then
            lblQuantity.Text = quant.ToString()
        Else
            MsgBox("Quantity cannot be less than 0")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productId As String = dgProducts.SelectedRows(0).Cells(0).Value.ToString
    End Sub
End Class