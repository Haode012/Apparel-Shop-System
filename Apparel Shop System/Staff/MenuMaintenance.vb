Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class MenuMaintenance

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub MenuMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim gender As String = ""

        If radMale.Checked Then
            gender = "Male"
        ElseIf radFemale.Checked Then
            gender = "Female"
        Else
            MessageBox.Show("Please select a product gender", "Error")
            Return
        End If

        Dim size As String = ""
        If radS.Checked Then
            size = "S"
        ElseIf radM.Checked Then
            size = "M"
        ElseIf radL.Checked Then
            size = "L"
        ElseIf radXL.Checked Then
            size = "XL"
        Else
            MessageBox.Show("Please select a product size", "Error")
            Return
        End If



        Dim ms As New MemoryStream
        picImage.Image.Save(ms, picImage.Image.RawFormat)
        Dim img As Byte() = ms.ToArray()

        Dim sql As String = "INSERT INTO Product (productName, productGender, productCategory, productSize, productDescription, productPrice, productStock, productImage) VALUES (@ProductName, @Gender, @Category, @Size, @Description, @Price, @Stock, @Image)"
        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@Category", cmbProductCategory.Text)
            cmd.Parameters.AddWithValue("@Size", size)
            cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text)
            cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text)
            cmd.Parameters.AddWithValue("@Stock", txtProductStock.Text)
            cmd.Parameters.AddWithValue("@Image", img)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record created successfully!", "Success")
        End Using
    End Sub


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