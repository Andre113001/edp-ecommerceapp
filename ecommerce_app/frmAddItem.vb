Public Class frmAddItem
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(tbItemName.Text) Then
            MessageBox.Show("Please Fill-in Item Name")
        ElseIf String.IsNullOrEmpty(tbPrice.Text) Then
            MessageBox.Show("Please Fill-in Item Price")
        End If

        Dim price As Integer
        Dim category As Integer

        price = Convert.ToDouble(tbPrice.Text)

        Select Case (cbCategory.SelectedItem)
            Case "Electronics"
                category = 1
            Case "Books"
                category = 2
            Case "Home & Garden"
                category = 3
            Case "Toys & Games"
                category = 4
            Case "Sports & Outdoors"
                category = 5
            Case "Health & Beauty"
                category = 6
            Case "Clothing & Accessories"
                category = 7
            Case "Pet Supplies"
                category = 8
            Case "Office Supplies"
                category = 9
            Case "Food & Beverages"
                category = 10
            Case "11"
                category = 11
        End Select

        add_item(itemName:=tbItemName.Text, itemPrice:=price, itemCategory:=category)


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub


    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class