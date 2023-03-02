Public Class MenuMaintenance
    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            picImage.Image = Image.FromFile(openFileDialog.FileName)
        End If

    End Sub
End Class