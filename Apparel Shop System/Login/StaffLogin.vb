
Public Class StaffLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill up all the fields", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            Homepage.Show()
        End If
    End Sub
End Class
