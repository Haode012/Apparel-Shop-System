Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class CreateProduct
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private dblPrice As Double

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            picImage.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Try
            Dim price As Double
            Dim gender As String = ""
            Dim size As String = ""
            Dim stock As Integer = 0

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
            If txtProductName.Text = "" Then
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
                ElseIf Not Integer.TryParse(txtProductStock.Text, stock) OrElse stock < 1 OrElse stock > 10 Then
                    MessageBox.Show("Product Stock must between 1 to 10", "Invalid Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf picImage.Image Is Nothing Then
                    MessageBox.Show("Please select a Product Image", "Missing Product Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dblPrice = Double.Parse(txtProductPrice.Text)
                    txtProductPrice.Text = dblPrice.ToString("C2", myCultureInfo)



                    Dim ms As New MemoryStream
                    picImage.Image.Save(ms, picImage.Image.RawFormat)
                    Dim img As Byte() = ms.ToArray()

                    Dim sql As String = "INSERT INTO Product (productName, productGender, productCategory, productSize, productDescription, productPrice, productStock, productImage, dateCreated) VALUES (@ProductName, @Gender, @Category, @Size, @Description, @Price, @Stock, @Image, CONVERT(nvarchar(10), GETDATE(), 103))"
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

                        MessageBox.Show("Record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        clearData()
                    End Using
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub clearData()
        txtProductID.Text = ""
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
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class