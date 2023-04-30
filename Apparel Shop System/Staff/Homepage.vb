﻿Public Class Homepage
    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        With Membership
            .TopLevel = False
            panelShow.Controls.Add(Membership)
            .BringToFront()
            .Show()
        End With

        ProductItemDetails.Close()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With ProductItem
            .TopLevel = False
            panelShow.Controls.Add(ProductItem)
            .BringToFront()
            .Show()
        End With

        ProductItemDetails.Close()
    End Sub

End Class
