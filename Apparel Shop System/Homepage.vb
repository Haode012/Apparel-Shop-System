Public Class Homepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With Home
            .TopLevel = False
            panelShow.Controls.Add(Home)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
