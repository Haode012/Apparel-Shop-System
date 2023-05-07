Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class DeleteProduct
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private Sub DeleteProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        enabledFalse()

        Dim cmd As New SqlCommand("SELECT productID FROM Product", con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbProductID.Items.Add(reader("productID"))
        End While
        reader.Close()
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        'Get the selected product ID
        Dim selectedProductId As String = cmbProductID.Text

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Product WHERE productID = @ProductID"
        cmd.Parameters.AddWithValue("@ProductID", selectedProductId)

        'Execute the command and get the result
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        'Display the result in the text box
        If reader.Read() Then
            txtProductName.Text = reader("productName").ToString()

            Dim gender As String = reader("productGender").ToString()
            If gender = "Male" Then
                radMale.Checked = True
            Else
                radFemale.Checked = True
            End If

            cmbProductCategory.Text = reader("productCategory").ToString()

            Dim size As String = reader("productSize").ToString()
            If size = "S" Then
                radS.Checked = True
            ElseIf size = "M" Then
                radM.Checked = True
            ElseIf size = "L" Then
                radL.Checked = True
            Else
                radXL.Checked = True
            End If

            txtProductDescription.Text = reader("productDescription").ToString()

            txtProductPrice.Text = reader("productPrice").ToString()

            txtProductStock.Text = reader("productStock").ToString()

            'Get the image data from the database
            Dim imageData As Byte() = DirectCast(reader("productImage"), Byte())

            'Convert the image data to a MemoryStream
            Dim ms As New MemoryStream(imageData)

            'Set the image of the PictureBox control from the MemoryStream
            picImage.Image = Image.FromStream(ms)

        End If

        reader.Close()

    End Sub
    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            picImage.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If cmbProductID.Text = "" Then
                MessageBox.Show("Please choose a Product ID", "Missing Product ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Open()

                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from Product where productId='" + cmbProductID.Text + "'"
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmbProductID.Items.Remove(cmbProductID.SelectedItem)
                clearData()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub clearData()
        cmbProductID.SelectedIndex = -1
        txtProductName.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        cmbProductCategory.SelectedIndex = -1
        radS.Checked = False
        radM.Checked = False
        radL.Checked = False
        radXL.Checked = False
        txtProductDescription.Text = ""
        txtProductPrice.Text = ""
        txtProductStock.Text = ""
        picImage.Image = Nothing
        txtProductName.Focus()
    End Sub

    Public Sub enabledFalse()
        txtProductName.Enabled = False
        grpProductGender.Enabled = False
        cmbProductCategory.Enabled = False
        grpProductSize.Enabled = False
        txtProductDescription.Enabled = False
        txtProductPrice.Enabled = False
        txtProductStock.Enabled = False
        btnChoose.Enabled = False
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        DailySalesReportViewer.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class