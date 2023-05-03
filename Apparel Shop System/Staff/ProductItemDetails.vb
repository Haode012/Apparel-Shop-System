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

    Public Property ProductPromotion As String
        Get
            Return lblProductPromotion.Text
        End Get
        Set(value As String)
            lblProductPromotion.Text = value
        End Set
    End Property


    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Membership.Close()
        ProductItem.Close()
        OrderCart.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub MenuItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowProductDetails(ProductImage, ProductID, ProductName, ProductGender, ProductCategory, ProductSize, ProductDescription, ProductPrice, ProductStock, ProductPromotion)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        Dim quantityValue As String
        quantityValue = Integer.Parse(lblProductQuantity.Text)
        quantityValue = 1
    End Sub

    Public Sub ShowProductDetails(ProductImage As Image, ProductId As String, ProductName As String, ProductGender As String, ProductCategory As String, ProductSize As String, ProductDescription As String, ProductPrice As String, ProductStock As String, ProductPromotion As String)
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
        lblProductPromotion.Text = ProductPromotion
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

                Calculation()

                Me.Close()
                ProductItem.Close()
            Else
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Product SET productStock=@stock WHERE productId=@id"
                cmd.Parameters.AddWithValue("@stock", lblProductStock.Text)
                cmd.Parameters.AddWithValue("@id", lblProductID.Text)
                cmd.ExecuteNonQuery()

                Calculation()

                Me.Close()
                ProductItem.Close()
            End If

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Calculation()
        ' Create a new CultureInfo object for Malaysia
        Dim myCultureInfo As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("ms-MY")

        ' Set the currency symbol to "RM"
        myCultureInfo.NumberFormat.CurrencySymbol = "RM"

        Dim priceString As String = lblProductPrice.Text
        Dim priceWithoutRM As String = priceString.Replace("RM", "")
        Dim price As Double = Double.Parse(priceWithoutRM)

        Dim percentageString As String = lblProductPromotion.Text
        Dim percentageWithoutS As String
        Dim percentage As Double
        Dim totalPrice As Double
        Dim quantity As Integer = lblProductQuantity.Text

        If percentageString <> "-" Then
            percentageWithoutS = percentageString.Replace("%", "")
            percentage = Double.Parse(percentageWithoutS) / 100
            totalPrice = price * percentage * quantity
            totalPrice.ToString("C2", myCultureInfo)

            addToCart()
        Else
            totalPrice = price * quantity
            totalPrice.ToString("C2", myCultureInfo)

            addToCart()
        End If


    End Sub


    Public Sub addToCart()


        Dim ms As New MemoryStream
        picProductImage.Image.Save(ms, picProductImage.Image.RawFormat)
        Dim img As Byte() = ms.ToArray()
        Dim imgBase64 As String = Convert.ToBase64String(img)

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Cart (productId, productName, productPrice, productQuantity, productImage,productPromotion) VALUES (@ProductId,@ProductName,@ProductPrice, @ProductQuantity,@ProductImage,@ProductPromotion)"

        'cmd.Parameters.AddWithValue("@CartId", "1")


        cmd.Parameters.AddWithValue("@ProductId", lblProductID.Text)

        cmd.Parameters.AddWithValue("@ProductName", lblProductName.Text)

        cmd.Parameters.AddWithValue("@ProductPrice", lblProductPrice.Text)
        cmd.Parameters.AddWithValue("@ProductQuantity", lblProductQuantity.Text)
        cmd.Parameters.AddWithValue("@ProductImage", img)
        cmd.Parameters.AddWithValue("@ProductPromotion", lblProductPromotion.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Add To Cart Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub picAdd_Click(sender As Object, e As EventArgs) Handles picAdd.Click
        Dim currentValue As Integer
        currentValue = Integer.Parse(lblProductQuantity.Text)
        If (currentValue + 1) > lblProductStock.Text Then
        End If
    End Sub

End Class