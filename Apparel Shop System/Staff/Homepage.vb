Public Class Homepage
    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        With Membership
            .TopLevel = False
            panelShow.Controls.Add(Membership)
            .BringToFront()
            .Show()
        End With

        ProductItemDetails.Close()
        Payment.Close()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With ProductItem
            .TopLevel = False
            panelShow.Controls.Add(ProductItem)
            .BringToFront()
            .Show()
        End With

        ProductItemDetails.Close()
        Payment.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        StaffLogin.Show()
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        With OrderCart
            .TopLevel = False
            panelShow.Controls.Add(OrderCart)
            .BringToFront()
            .Show()
        End With

        ProductItemDetails.Close()
        Payment.Close()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = strPassStaffName
    End Sub
End Class
