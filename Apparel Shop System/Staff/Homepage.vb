Public Class Homepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With Home
            .TopLevel = False
            panelShow.Controls.Add(Home)
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
