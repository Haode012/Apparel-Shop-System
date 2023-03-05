﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class MenuMaintenance

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private dblPrice As Double

    Private Sub MenuMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        display_data()
    End Sub

    Public Sub display_data()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Product"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.Width = 200 ' Set the width of each column to 200
        Next
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click


        Try
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
            If txtProductName.Text = "" Then
                MessageBox.Show("Please enter Product Name", "Invalid Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf IsNumeric(txtProductName.Text) Then
                MessageBox.Show("Product Name cannot contain only digit number", "Invalid Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(gender) Then
                MessageBox.Show("Please select a Product Gender", "Invalid Product Gender", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cmbProductCategory.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a Product Category", "Invalid Product Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(size) Then
                MessageBox.Show("Please select a Product Size", "Invalid Product Size", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtProductDescription.Text = "" Then
                MessageBox.Show("Please enter Product Description", "Invalid Product Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf IsNumeric(txtProductDescription.Text) Then
                MessageBox.Show("Product Description cannot contain only digit number", "Invalid Product Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not Double.TryParse(txtProductPrice.Text, price) Then
                    MessageBox.Show("Product Price cannot be empty, not letter and must remove RM first", "Invalid Product Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If txtProductStock.Text = "" Then
                        MessageBox.Show("Please enter Product Stock", "Invalid Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf IsInputChar(txtProductStock.Text) Then
                        MessageBox.Show("Product Stock cannot contain letter", "Invalid Product Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf picImage.Image Is Nothing Then
                        MessageBox.Show("Please select a Product Image", "Invalid Product Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        dblPrice = Double.Parse(txtProductPrice.Text)
                        txtProductPrice.Text = dblPrice.ToString("C2", myCultureInfo)

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

                            display_data()

                            MessageBox.Show("Record created successfully!", "Success")

                        End Using
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearData()
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
        txtSearch.Text = ""
        txtProductName.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Product where productId=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                txtProductID.Text = dr.GetInt32(0).ToString()
                txtProductName.Text = dr.GetString(1).ToString()

                If dr.GetString(2).ToString() = "Male" Then
                    radMale.Checked = True
                ElseIf dr.GetString(2).ToString() = "Female" Then
                    radFemale.Checked = True
                End If

                cmbProductCategory.Text = dr.GetString(3).ToString()

                If dr.GetString(4).ToString() = "S" Then
                    radS.Checked = True
                ElseIf dr.GetString(4).ToString() = "M" Then
                    radM.Checked = True
                ElseIf dr.GetString(4).ToString() = "L" Then
                    radL.Checked = True
                ElseIf dr.GetString(4).ToString() = "XL" Then
                    radXL.Checked = True
                End If

                txtProductDescription.Text = dr.GetString(5).ToString()
                txtProductPrice.Text = dr.GetString(6).ToString()
                txtProductStock.Text = dr.GetString(7).ToString()

                Dim imageData As Byte() = DirectCast(dr.GetValue(8), Byte())
                Using ms As New MemoryStream(imageData)
                    picImage.Image = Image.FromStream(ms)
                End Using

            End While

        Catch ex As Exception
            MessageBox.Show("Empty Data", "Error")
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            ' Create a new CultureInfo object for Malaysia
            Dim myCultureInfo As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("ms-MY")

            ' Set the currency symbol to "RM"
            myCultureInfo.NumberFormat.CurrencySymbol = "RM"

            dblPrice = Double.Parse(txtProductPrice.Text)
            txtProductPrice.Text = dblPrice.ToString("C2", myCultureInfo)

            Dim gender As String = ""

            If radMale.Checked Then
                gender = "Male"
            ElseIf radFemale.Checked Then
                gender = "Female"
            Else
                MessageBox.Show("Please select a Product Gender", "Error")
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
                MessageBox.Show("Please select a Product Size", "Error")
                Return
            End If

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
            cmd.CommandText = "UPDATE Product SET productName='" + txtProductName.Text + "', productGender='" + gender + "', productCategory='" + cmbProductCategory.Text + "', productSize='" + size + "', productDescription='" + txtProductDescription.Text + "', productPrice='" + txtProductPrice.Text + "', productStock='" + txtProductStock.Text + "', productImage=@Image WHERE productId=" & i & ""
            cmd.Parameters.AddWithValue("@Image", img)
            cmd.ExecuteNonQuery()

            display_data()
            MessageBox.Show("Record updated successfully!", "Success")

        Catch ex As Exception
            MessageBox.Show("Product Price should not have letter and remove RM", "Error")
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()


            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Product where productId='" + txtProductID.Text + "'"
            cmd.ExecuteNonQuery()

            display_data()
            MessageBox.Show("Record deleted successfully!", "Success")

        Catch ex As Exception
            MessageBox.Show("Error", "Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Product where productId='" + txtSearch.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        display_data()
    End Sub

    Private Function IsInputChar(ByVal inputString As String) As Boolean
        Dim regex As Regex = New Regex("^[0-9]+$")
        Return Not regex.IsMatch(inputString)
    End Function
End Class