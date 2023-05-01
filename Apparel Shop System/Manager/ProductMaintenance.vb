Public Class ProductMaintenance

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        With DisplayProduct
            .TopLevel = False
            Me.Controls.Add(DisplayProduct)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        With CreateProduct
            .TopLevel = False
            Me.Controls.Add(CreateProduct)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        With UpdateProduct
            .TopLevel = False
            Me.Controls.Add(UpdateProduct)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DeleteProduct
            .TopLevel = False
            Me.Controls.Add(DeleteProduct)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        With ProductReportViewer
            .TopLevel = False
            Me.Controls.Add(ProductReportViewer)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class