Public Class ManagerHomepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ProductMaintenance.Close()
    End Sub
    Private Sub btnProductMaintenance_Click(sender As Object, e As EventArgs) Handles btnProductMaintenance.Click
        With ProductMaintenance
            .TopLevel = False
            panelShow.Controls.Add(ProductMaintenance)
            .BringToFront()
            .Show()
        End With

        DisplayProduct.Close()
        CreateProduct.Close()
        UpdateProduct.Close()
        DeleteProduct.Close()
        ProductReportViewer.Close()
    End Sub

    Private Sub btnProductMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnProductMaintenanceBig.Click
        With ProductMaintenance
            .TopLevel = False
            panelShow.Controls.Add(ProductMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class