Public Class PromotionMaintenance
    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
    End Sub

    Private Sub Promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        With Promotion_Add
            .TopLevel = False
            Me.Controls.Add(Promotion_Add)
            .BringToFront()
            .Show()
        End With

    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        With Promotion_Details
            .TopLevel = False
            Me.Controls.Add(Promotion_Details)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class