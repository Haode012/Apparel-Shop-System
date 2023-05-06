Imports System.Data.SqlClient
Imports System.IO
Public Class DisplayProductDetails
    Public strSelectedProductID As String

    Private Sub DisplayProductDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strProductID As String
        Dim strProductName As String
        Dim strProductGender As String
        Dim strProductCategory As String
        Dim strProductSize As String
        Dim strProductDescription As String
        Dim strProductPrice As String
        Dim strProductStock As String
        Dim strDateCreated As String
        Dim strPromotionDiscount As String
        Dim strPromotionID As String
        Dim picProductImage As Image
        
        If OpenConnection() = True Then
            strSql = "Select * From Product where productId =@productId"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@productId", strSelectedProductID)
            Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()

                ' Retrieve image data as byte array
                Dim imageData As Byte() = CType(reader("productImage"), Byte())

                ' Create image from byte array
                Using ms As New MemoryStream(imageData)
                    picProductImage = Image.FromStream(ms)
                End Using

                strProductID = reader("productId").ToString
                If strProductID.Equals(strSelectedProductID) Then
                    strProductName = reader("productName").ToString
                    strProductGender = reader("productGender").ToString
                    strProductCategory = reader("productCategory").ToString
                    strProductSize = reader("productSize").ToString
                    strProductDescription = reader("productDescription").ToString
                    strProductPrice = reader("productPrice").ToString
                    strDateCreated = reader("dateCreated").ToString
                    strProductStock = reader("productStock").ToString
                    strPromotionID = reader("promotionId").ToString
                    strPromotionDiscount = reader("promotionDiscount").ToString
                    lblProductID.Text = strProductID
                    lblProductName.Text = strProductName
                    lblProductGender.Text = strProductGender
                    lblProductCategory.Text = strProductCategory
                    lblProductSize.Text = strProductSize
                    lblProductDescription.Text = strProductDescription
                    lblProductPrice.Text = strProductPrice
                    lblDateCreated.Text = strDateCreated
                    lblPromotionDiscount.Text = strPromotionDiscount
                    If lblPromotionDiscount.Text = "" Then
                        lblPromotionDiscount.Text = "-"
                    End If
                    lblProductStock.Text = strProductStock
                    lblPromotionID.Text = strPromotionID
                    If lblPromotionID.Text = "" Then
                        lblPromotionID.Text = "-"
                    End If
                    picImage.Image = picProductImage
                    CloseConnection()
                End If
            End If
        End If
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        DisplayProduct.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub


    Private Sub DisplayProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductName.AutoSize = False
        lblProductName.AutoEllipsis = True
    End Sub

End Class