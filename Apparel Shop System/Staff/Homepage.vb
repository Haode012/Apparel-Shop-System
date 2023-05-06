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
        StaffLogin.txtStaffId.Text = ""
        StaffLogin.txtPassword.Text = ""
        StaffLogin.txtStaffId.Focus()
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
        lblUsername.Text = strFullName
    End Sub
    Private Sub btnChangePassowrd_Click(sender As Object, e As EventArgs) Handles btnChangePassowrd.Click
        ChangePassword.Show()
    End Sub

    Private Sub btnChangeSecret_Click(sender As Object, e As EventArgs) Handles btnChangeSecret.Click
        ChangeSecretQuestionAndAnswer.Show()
    End Sub
End Class
