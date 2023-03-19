Public Class Homepage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With Home
            .TopLevel = False
            panelShow.Controls.Add(Home)
            .BringToFront()
            .Show()
        End With

        MenuItemDetails.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        With MenuItem
            .TopLevel = False
            panelShow.Controls.Add(MenuItem)
            .BringToFront()
            .Show()
        End With

        MenuItemDetails.Close()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
