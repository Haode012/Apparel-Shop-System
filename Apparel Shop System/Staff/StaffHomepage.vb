Public Class StaffHomepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuMaintenance.Close()
    End Sub

    Private Sub btnMenuMaintenance_Click(sender As Object, e As EventArgs) Handles btnMenuMaintenance.Click
        With MenuMaintenance
            .TopLevel = False
            panelShow.Controls.Add(MenuMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMenuMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnMenuMaintenanceBig.Click
        With MenuMaintenance
            .TopLevel = False
            panelShow.Controls.Add(MenuMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub


End Class