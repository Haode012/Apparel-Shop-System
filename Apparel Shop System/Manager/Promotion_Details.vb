Public Class Promotion_Details
    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Me.Close()

    End Sub


    Private Sub btnEditPromo_Click(sender As Object, e As EventArgs) Handles btnEditPromo.Click
        With Promotion_Edit
            .TopLevel = False
            Me.Controls.Add(Promotion_Edit)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExpendInfo_Click(sender As Object, e As EventArgs) Handles btnExpendInfo.Click
        If pnlPromotionInfo.Visible Then
            ' If the panel is visible, hide it and move up the other panels and labels
            pnlPromotionInfo.Visible = False
        Else
            ' If the panel is hidden, show it and move down the other panels and labels
            pnlPromotionInfo.Visible = True
        End If
    End Sub


End Class