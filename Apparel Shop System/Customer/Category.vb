Public Class Category
    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Home.Close()
    End Sub

    Private Sub btnShirt_Click(sender As Object, e As EventArgs) Handles btnShirt.Click
        With MenuItem
            .TopLevel = False
            Me.Controls.Add(MenuItem)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class