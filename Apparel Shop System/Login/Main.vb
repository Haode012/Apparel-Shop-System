Public Class Main
    Private Sub btnManagerLogin_Click(sender As Object, e As EventArgs) Handles btnManagerLogin.Click
        Me.Hide()
        ManagerLogin.Show()
    End Sub

    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        Me.Hide()
        StaffLogin.Show()
    End Sub
End Class