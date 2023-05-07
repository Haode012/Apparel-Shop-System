Imports System.Data.SqlClient

Public Class UpdateOrderStatus
    Public strSelectedOrderId As String

    Private Sub UpdateOrderStatus_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim strOrderId As String
        Dim strProductId As String
        Dim strProductName As String
        Dim strReceiptId As String
        Dim strMemberId As String
        Dim strUnitPrice As String
        Dim strQuantity As String
        Dim strPromotion As String
        Dim strAmount As String
        Dim strOrderDate As String
        Dim strPaymentMethod As String
        Dim strStatus As String
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()
            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From OrderHistory where orderId =@OrderId"
                cmd.Parameters.AddWithValue("@OrderId", strSelectedOrderId)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()


                    strOrderId = reader("orderId").ToString
                    strProductId = reader("productId").ToString
                    strProductName = reader("productName").ToString
                    strMemberId = reader("memberId").ToString
                    strReceiptId = reader("receiptId").ToString
                    strUnitPrice = reader("unitPrice").ToString
                    strPromotion = reader("promotion").ToString
                    strStatus = reader("status").ToString
                    strQuantity = reader("quantity").ToString
                    strAmount = reader("amount").ToString
                    strPaymentMethod = reader("paymentMethod").ToString
                    strOrderDate = reader("orderDate").ToString

                    lblOrderId.Text = strOrderId
                    lblProductId.Text = strProductId
                    lblProductName.Text = strProductName
                    lblMemberId.Text = strMemberId
                    lblReceiptId.Text = strReceiptId
                    lblUnitPrice.Text = strUnitPrice
                    lblPromotion.Text = strPromotion
                    lblStatus.Text = strStatus
                    lblQuantity.Text = strQuantity
                    lblAmount.Text = strAmount
                    lblPaymentMethod.Text = strPaymentMethod
                    lblOrderDate.Text = strOrderDate

                End If
                CloseConnection()
            End Using
        End Using
        If lblStatus.Text.Trim() = "Cancelled" Then
            btnCancel.Enabled = False
            btnCancel.Text = "Cancelled"
        End If


    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()

            Dim selectCmd As New SqlCommand("SELECT productId, productStock FROM Product WHERE productId = @productId", con)


            selectCmd.Parameters.AddWithValue("@productId", lblProductId.Text)

            Dim reader As SqlDataReader = selectCmd.ExecuteReader()
            If reader.Read() Then

                Dim currentStock As String = reader("productStock")

                lblStock.Text = currentStock.ToString()
                con.Close()
            End If
        End Using

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()
            Dim updateCmd As String = "UPDATE Product SET productStock = @productStock WHERE productId = @productId"
            Using cmd As New SqlCommand(updateCmd, con)
                'con.Open()
                cmd.Parameters.AddWithValue("@productStock", (Integer.Parse(lblStock.Text.ToString) + Integer.Parse(lblQuantity.Text)).ToString)
                cmd.Parameters.AddWithValue("@productId", lblProductId.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()
            Dim updateCmd As String = "UPDATE OrderHistory SET status = @Status WHERE orderId = @OrderId"
            Using cmd As New SqlCommand(updateCmd, con)
                'con.Open()
                cmd.Parameters.AddWithValue("@Status", "Cancelled")
                cmd.Parameters.AddWithValue("@orderId", lblOrderId.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Me.Close()



    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductItem.Close()
        OrderCart.Close()
        Payment.Close()
        Membership.Close()
        OrderHistory.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class