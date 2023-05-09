Public Class ProductMaintenance

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        DailySalesReportViewer.Close()
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
        If strPosition = "Manager" Then
            With CreateProduct
                .TopLevel = False
                Me.Controls.Add(CreateProduct)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to create new product", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If strPosition = "Manager" Then
            With UpdateProduct
                .TopLevel = False
                Me.Controls.Add(UpdateProduct)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to update product", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If strPosition = "Manager" Then
            With DeleteProduct
                .TopLevel = False
                Me.Controls.Add(DeleteProduct)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to delete product", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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