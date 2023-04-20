Imports System.Data.SqlClient
Imports System.IO
Public Class ProductItemDetails

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Property ProductImage As Image
        Get
            Return picProductImage.Image
        End Get
        Set(ByVal value As Image)
            picProductImage.Image = value
        End Set
    End Property
    Public Property ProductID As String
        Get
            Return lblProductID.Text
        End Get
        Set(value As String)
            lblProductID.Text = value
        End Set
    End Property

    Public Property ProductName As String
        Get
            Return lblProductName.Text
        End Get
        Set(value As String)
            lblProductName.Text = value
        End Set
    End Property

    Public Property ProductGender As String
        Get
            Return lblProductGender.Text
        End Get
        Set(value As String)
            lblProductGender.Text = value
        End Set
    End Property

    Public Property ProductCategory As String
        Get
            Return lblProductCategory.Text
        End Get
        Set(value As String)
            lblProductCategory.Text = value
        End Set
    End Property
    Public Property ProductSize As String
        Get
            Return lblProductSize.Text
        End Get
        Set(value As String)
            lblProductSize.Text = value
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return lblProductDescription.Text
        End Get
        Set(value As String)
            lblProductDescription.Text = value
        End Set
    End Property

    Public Property ProductPrice As String
        Get
            Return lblProductPrice.Text
        End Get
        Set(value As String)
            lblProductPrice.Text = value
        End Set
    End Property

    Public Property ProductStock As String
        Get
            Return lblProductStock.Text
        End Get
        Set(value As String)
            lblProductStock.Text = value
        End Set
    End Property


    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Home.Close()
        ProductItem.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub MenuItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowProductDetails(ProductImage, ProductID, ProductName, ProductGender, ProductCategory, ProductSize, ProductDescription, ProductPrice, ProductStock)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
    End Sub

    Public Sub ShowProductDetails(ProductImage As Image, ProductId As String, ProductName As String, ProductGender As String, ProductCategory As String, ProductSize As String, ProductDescription As String, ProductPrice As String, ProductStock As String)
        'Display the product details in the UI
        picProductImage.Image = ProductImage
        lblProductID.Text = ProductId
        lblProductName.Text = ProductName
        lblProductGender.Text = ProductGender
        lblProductCategory.Text = ProductCategory
        lblProductSize.Text = ProductSize
        lblProductDescription.Text = ProductDescription
        lblProductPrice.Text = ProductPrice
        lblProductStock.Text = ProductStock
        lblProductQuantity.Text = ProductStock
    End Sub

    Private Sub picRemove_Click(sender As Object, e As EventArgs) Handles picRemove.Click

        Dim currentValue As Integer
        currentValue = Integer.Parse(lblProductQuantity.Text)
        If currentValue > 1 Then
            lblProductQuantity.Text = (currentValue - 1).ToString()
        End If

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            Dim ms As New MemoryStream
            picProductImage.Image.Save(ms, picProductImage.Image.RawFormat)
            Dim img As Byte() = ms.ToArray()
            Dim imgBase64 As String = Convert.ToBase64String(img)

            lblProductStock.Text = lblProductStock.Text - lblProductQuantity.Text

            If lblProductStock.Text = 0 Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM Product WHERE productId=@id"
                cmd.Parameters.AddWithValue("@id", lblProductID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted product successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                ProductItem.Close()
            Else
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Product SET productStock=@stock WHERE productId=@id"
                cmd.Parameters.AddWithValue("@stock", lblProductStock.Text)
                cmd.Parameters.AddWithValue("@id", lblProductID.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                ProductItem.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

End Class