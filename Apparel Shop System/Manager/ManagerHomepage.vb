Public Class ManagerHomepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
    End Sub
    Private Sub btnProductMaintenance_Click(sender As Object, e As EventArgs) Handles btnProductMaintenance.Click
        With ProductMaintenance
            .TopLevel = False
            panelShow.Controls.Add(ProductMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnProductMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnProductMaintenanceBig.Click
        With ProductMaintenance
            .TopLevel = False
            panelShow.Controls.Add(ProductMaintenance)
            .BringToFront()
            .Show()
        End With
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

    Private Sub btnMembershipMaintenance_Click(sender As Object, e As EventArgs) Handles btnMembershipMaintenance.Click
        With MembershipMaintenance
            .TopLevel = False
            panelShow.Controls.Add(MembershipMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMembershipMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnMembershipMaintenanceBig.Click
        With MembershipMaintenance
            .TopLevel = False
            panelShow.Controls.Add(MembershipMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        ManagerLogin.Show()
    End Sub

    Private Sub btnPromotionMaintenanceBig_Click(sender As Object, e As EventArgs) Handles btnPromotionMaintenanceBig.Click
        With PromotionMaintenance
            .TopLevel = False
            panelShow.Controls.Add(PromotionMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnPromotion_Click(sender As Object, e As EventArgs) Handles btnPromotion.Click
        With PromotionMaintenance
            .TopLevel = False
            panelShow.Controls.Add(PromotionMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class