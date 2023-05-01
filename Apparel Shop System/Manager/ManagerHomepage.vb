Public Class ManagerHomepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        StaffMaintenance.Close()
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

        DisplayProduct.Close()
        CreateProduct.Close()
        UpdateProduct.Close()
        DeleteProduct.Close()
        ProductReportViewer.Close()
    End Sub

    Private Sub btnStaffMaintenance_Click(sender As Object, e As EventArgs) Handles btnStaffMaintenance.Click
        With StaffMaintenance
            .TopLevel = False
            panelShow.Controls.Add(StaffMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnStaffMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnStaffMaintenanceBig.Click
        With StaffMaintenance
            .TopLevel = False
            panelShow.Controls.Add(StaffMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ManagerHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = strPassName
    End Sub
End Class