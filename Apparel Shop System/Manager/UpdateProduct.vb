Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class UpdateProduct
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private dblPrice As Double
    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        Dim cmd As New SqlCommand("SELECT productID FROM Product", con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbProductID.Items.Add(reader("productID"))
        End While
        reader.Close()

        If cmbProductID.Text = "" Then
            enabledFalse()
        End If

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

            enabledTrue()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim stock As Integer = 0
            Dim price As Double
            Dim gender As String = ""
            Dim size As String = ""

            ' Create a new CultureInfo object for Malaysia
            Dim myCultureInfo As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("ms-MY")

            ' Set the currency symbol to "RM"
            myCultureInfo.NumberFormat.CurrencySymbol = "RM"

            If radMale.Checked Then
                gender = "Male"
            ElseIf radFemale.Checked Then
                gender = "Female"
            End If

            If radS.Checked Then
                size = "S"
            ElseIf radM.Checked Then
                size = "M"
            ElseIf radL.Checked Then
                size = "L"
            ElseIf radXL.Checked Then
                size = "XL"
            End If

            'validation
            If cmbProductID.Text = "" Then
                MessageBox.Show("Please choose a Product ID", "Missing Product ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtProductName.Text = "" Then
                MessageBox.Show("Please enter Product Name", "Missing Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf IsNumeric(txtProductName.Text) Then
                MessageBox.Show("Product Name cannot contain only digit number", "Invalid Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(gender) Then
                MessageBox.Show("Please select a Product Gender" & vbCrLf & "Option 1: Male" & vbCrLf & "Option 2: Female", "Missing Product Gender", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cmbProductCategory.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a Product Category" & vbCrLf & "Option 1: Shirt" & vbCrLf & "Option 2: Pant" & vbCrLf & "Option 3: Shoe" & vbCrLf & "Option 4: Sock", "Missing Product Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(size) Then
                MessageBox.Show("Please select a Product Size" & vbCrLf & "Option 1: S" & vbCrLf & "Option 2: M" & vbCrLf & "Option 3: L" & vbCrLf & "Option 4: XL", "Missing Product Size", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtProductDescription.Text = "" Then
                MessageBox.Show("Please enter Product Description", "Missing Product Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf IsNumeric(txtProductDescription.Text) Then
                MessageBox.Show("Product Description cannot contain only digit number", "Invalid Product Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not Double.TryParse(txtProductPrice.Text, price) Then
                MessageBox.Show("Product Price cannot be empty, not letter and must remove RM first", "Missing or Invalid Product Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If txtProductStock.Text = "" Then
                    MessageBox.Show("Please enter Product Stock", "Missing Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf IsInputChar(txtProductStock.Text) Then
                    MessageBox.Show("Product Stock cannot contain letter", "Invalid Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Not Integer.TryParse(txtProductStock.Text, stock) OrElse stock < 1 Then
                    MessageBox.Show("Product Stock must be more than 1", "Invalid Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf picImage.Image Is Nothing Then
                    MessageBox.Show("Please select a Product Image", "Missing Product Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dblPrice = Double.Parse(txtProductPrice.Text)
                    txtProductPrice.Text = dblPrice.ToString("C2", myCultureInfo)

                    Dim ms As New MemoryStream
                    picImage.Image.Save(ms, picImage.Image.RawFormat)
                    Dim img As Byte() = ms.ToArray()
                    Dim imgBase64 As String = Convert.ToBase64String(img)


                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                    con.Open()


                    cmd = con.CreateCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "UPDATE Product SET productName='" + txtProductName.Text + "', productGender='" + gender + "', productCategory='" + cmbProductCategory.Text + "', productSize='" + size + "', productDescription='" + txtProductDescription.Text + "', productPrice='" + txtProductPrice.Text + "', productStock='" + txtProductStock.Text + "', productImage=@Image WHERE productId=" & cmbProductID.Text & ""
                    cmd.Parameters.AddWithValue("@Image", img)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    clearData()
                    enabledFalse()

                End If
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
    End Sub

    Public Sub enabledTrue()
        txtProductName.Enabled = True
        grpProductGender.Enabled = True
        cmbProductCategory.Enabled = True
        grpProductSize.Enabled = True
        txtProductDescription.Enabled = True
        txtProductPrice.Enabled = True
        txtProductStock.Enabled = True
        btnChoose.Enabled = True
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

    Private Function IsInputChar(ByVal inputString As String) As Boolean
        Dim regex As Regex = New Regex("^[0-9]+$")
        Return Not regex.IsMatch(inputString)
    End Function

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