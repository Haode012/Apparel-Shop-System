Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO

Public Class Payment
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader



    Public Property MembershipID As String
        Get
            Return lblMembershipID.Text
        End Get
        Set(value As String)
            lblMembershipID.Text = value
        End Set
    End Property
    Public Property MembershipName As String
        Get
            Return lblMembershipName.Text
        End Get
        Set(value As String)
            lblMembershipName.Text = value
        End Set
    End Property
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        ShowMembershipDetails(MembershipID, MembershipName)
        display_all_record()
        display_all_record2()
        cmbExpirationMonthYear()
        strMemberId = lblMembershipID.Text.ToString
        strMemberName = lblMembershipName.Text.ToString

    End Sub
    Public Sub ShowMembershipDetails(MembershipID As String, MembershipName As String)
        lblMembershipID.Text = MembershipID
        lblMembershipID2.Text = MembershipID
        lblMembershipName.Text = MembershipName
        lblMembershipName2.Text = MembershipName

    End Sub
    Public Sub display_all_record2()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Cart"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        dgvTng.DataSource = dt
        dgvTng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvTng.Columns
            col.Width = 140 ' Set the width of each column to 157
        Next

        ' Calculate the total price
        Dim discount As Decimal = 0.2
        Dim totalPrice As Decimal = 0
        Dim totalPriceD As Decimal = 0
        For Each row As DataRow In dt.Rows
            Dim quantity As Integer = CInt(row("productQuantity"))
            Dim priceString As String = row("productPrice").ToString()
            priceString = priceString.Replace("RM", "") ' Remove "RM" from the string
            Dim price As Decimal = Decimal.Parse(priceString)

            Dim memberId As String = lblMembershipID.Text.ToString

            If lblMembershipID.Text.ToString = "" AndAlso lblMembershipID2.Text.ToString = "" Then
                Dim rowTotalPrice As Decimal = quantity * price
                totalPrice += rowTotalPrice
            Else
                Dim rowTotalPrice As Decimal = quantity * price
                totalPriceD += rowTotalPrice
                totalPrice = totalPriceD * (1 - discount)
            End If
        Next

        ' Display the total price in a label or textbox
        Dim nfi As New System.Globalization.NumberFormatInfo()
        nfi.CurrencySymbol = "RM" ' Replace with "RM" 
        lblTotalAmount1.Text = totalPrice.ToString("C", nfi)

        totalAmount = totalPrice.ToString("0.00")


    End Sub

    Public Sub display_all_record()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Cart"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)

        dgvMasterCard.DataSource = dt

        dgvMasterCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvMasterCard.Columns
            col.Width = 140 ' Set the width of each column to 157
        Next

        ' Calculate the total price
        Dim discount As Decimal = 0.2
        Dim totalPrice As Decimal = 0
        Dim totalPriceD As Decimal = 0
        For Each row As DataRow In dt.Rows
            Dim quantity As Integer = CInt(row("productQuantity"))
            Dim priceString As String = row("productPrice").ToString()
            priceString = priceString.Replace("RM", "") ' Remove "RM" from the string
            Dim price As Decimal = Decimal.Parse(priceString)

            Dim memberId As String = lblMembershipID.Text.ToString

            If lblMembershipID.Text.ToString = "" AndAlso lblMembershipID2.Text.ToString = "" Then
                Dim rowTotalPrice As Decimal = quantity * price
                totalPrice += rowTotalPrice
            Else
                Dim rowTotalPrice As Decimal = quantity * price
                totalPriceD += rowTotalPrice
                totalPrice = totalPriceD * (1 - discount)
            End If
        Next

        ' Display the total price in a label or textbox
        Dim nfi As New System.Globalization.NumberFormatInfo()
        nfi.CurrencySymbol = "RM" ' Replace with "RM" 
        lblTotalAmount.Text = totalPrice.ToString("C", nfi)

        totalAmount = totalPrice.ToString("0.00")


    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub



    Private Function ValidateMastercardNumber(cardNumber As String) As Boolean
        If Not (cardNumber.Length = 16 AndAlso cardNumber.StartsWith("5")) Then
            Return False
        End If

        'Reverse the card number
        Dim reversedCardNumber As String = StrReverse(cardNumber)

        'Calculate the sum of the digits, starting from the second digit
        Dim sum As Integer = 0
        For i As Integer = 1 To reversedCardNumber.Length - 1 Step 2
            Dim digit As Integer = CInt(reversedCardNumber(i).ToString())
            digit *= 2
            If digit > 9 Then
                digit = digit - 9
            End If
            sum += digit
        Next

        'Add the sum of the remaining digits to the sum
        For i As Integer = 0 To reversedCardNumber.Length - 1 Step 2
            sum += CInt(reversedCardNumber(i).ToString())
        Next

        'Check if the sum is a multiple of 10
        Return (sum Mod 10 = 0)
    End Function

    Private Function ValidateCVV(cvvNumber As String) As Boolean
        If Not (cvvNumber.Length = 3 AndAlso IsNumeric(cvvNumber)) Then
            Return False
        End If

        Return True
    End Function

    Private Function ValidateCardHolder(cardHolderName As String) As Boolean
        Return Not String.IsNullOrEmpty(cardHolderName)
    End Function

    Private Function ValidateExpirationDate(expirationDate As String) As String
        Dim format As String = "MM/yy"
        Dim result As DateTime
        If Not DateTime.TryParseExact(expirationDate, format, Nothing, DateTimeStyles.None, result) Then
            Return ""
        End If

        Dim month As Integer = result.Month
        Dim year As Integer = result.Year

        ' Return the month and year as a string in the format "MM/YY"
        Return month.ToString("00") & "/" & year.ToString("yy")


    End Function

    Private Sub cmbExpirationMonthYear()
        'Clear existing items
        cmbExpirationMonth.Items.Clear()
        cmbExpirationYear.Items.Clear()

        'Add months
        For i As Integer = 1 To 12
            cmbExpirationMonth.Items.Add(i.ToString("00"))
        Next

        'Add years
        Dim currentYear As Integer = DateTime.Now.Year Mod 100 'get the last 2 digits of the current year
        For i As Integer = currentYear To currentYear + 10
            cmbExpirationYear.Items.Add(i.ToString("00")) 'format the year with 2 digits
        Next

        'Select the current month and year by default
        cmbExpirationMonth.SelectedItem = DateTime.Now.ToString("MM")
        cmbExpirationYear.SelectedItem = currentYear.ToString("00")

    End Sub







    Private Sub picDelete_Click_1(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Membership.Close()
        ProductItem.Close()
        OrderCart.Close()
        OrderHistory.Close()


    End Sub



    Private Sub btnPaySuccessful_Click(sender As Object, e As EventArgs) Handles btnPaySuccessful.Click
        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        Dim length As Integer = 10
        Dim id As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While id.IndexOf(character) <> -1
            id += character
        Next
        Dim paymentId As String = "P" + id


        Dim PaymentReceipt As New PaymentReceipt()
        btnPaySuccessful.Tag = PaymentReceipt

        Dim args As PaymentReceipt = DirectCast(sender.Tag, PaymentReceipt)


        Dim sql As String = "INSERT INTO OrderHistory(productId,productName,receiptId,memberId,unitPrice,quantity,promotion,amount,orderDate,paymentMethod,status) " &
                    "SELECT productId,productName,@ReceiptId,@MemberId,productPrice,productQuantity,promotionDiscount,totalPrice, CONVERT(nvarchar(19), GETDATE(), 120),@PaymentMethod, @Status " &
                    "FROM Cart"

        Dim sql2 As String = "DELETE FROM Cart"

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@ReceiptId", paymentId)
                'cmd.Parameters.AddWithValue("@Amount", )
                cmd.Parameters.AddWithValue("@MemberId", lblMembershipID.Text)
                cmd.Parameters.AddWithValue("@PaymentMethod", "Touch n Go eWallet")
                cmd.Parameters.AddWithValue("@Status", "Sold")


                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Order successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using

        'Dim sql2 As String = "INSERT INTO OrderHistory(paymentId) VALUE (@paymentId)"

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            Using cmd As New SqlCommand(sql2, con)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using



        args.ShowPaymentReceipt(paymentId)

        With PaymentReceipt
            .TopLevel = False
            Me.Controls.Add(PaymentReceipt)
            .BringToFront()
            .Show()
        End With




    End Sub



    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cardNumber As String = mskCardNumber.Text
        Dim cvvNumber As String = mskCVV.Text
        Dim expirationDate As String = cmbExpirationMonth.Text & "/" & cmbExpirationYear.Text
        Dim cardHolderName As String = txtCardHolder.Text
        Dim isCardNumberValid As Boolean = ValidateMastercardNumber(cardNumber)
        Dim isCVVValid As Boolean = ValidateCVV(cvvNumber)
        'Dim expirationDateString As String = ValidateExpirationDate(expirationDate)
        Dim isCardHolderValid As Boolean = ValidateCardHolder(cardHolderName)

        lblExpirationDate.Text = expirationDate


        If Not ValidateCardHolder(cardHolderName) Then
            MessageBox.Show("Card holder name is not valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCardHolder.Focus()
            Exit Sub
        End If

        If Not ValidateCVV(cvvNumber) Then
            MessageBox.Show("CVV is not valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mskCardNumber.Focus()
            Exit Sub
        End If


        Dim expirationDateString As String = ValidateExpirationDate(expirationDate)

        If String.IsNullOrEmpty(expirationDateString) Then


            MessageBox.Show("Expiration date is not valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbExpirationMonth.Focus()
            Exit Sub
        End If

        If Not ValidateMastercardNumber(cardNumber) Then

            'valid input eg, 5555555555554444
            MessageBox.Show("Card Number is not valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mskCardNumber.Focus()
            Exit Sub
        End If


        MessageBox.Show("All information is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        Dim length As Integer = 10
        Dim id As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While id.IndexOf(character) <> -1
            id += character
        Next
        Dim paymentId As String = "P" + id


        Dim PaymentReceipt As New PaymentReceipt()
        btnSubmit.Tag = PaymentReceipt

        Dim args As PaymentReceipt = DirectCast(sender.Tag, PaymentReceipt)


        Dim sql As String = "INSERT INTO OrderHistory(productId,productName,receiptId,memberId,unitPrice,quantity,promotion,amount,orderDate,paymentMethod,status) " &
                    "SELECT productId,productName,@ReceiptId,@MemberId,productPrice,productQuantity,promotionDiscount,totalPrice, CONVERT(nvarchar(19), GETDATE(), 120),@PaymentMethod, @Status " &
                    "FROM Cart"

        Dim sql2 As String = "DELETE FROM Cart"

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@ReceiptId", paymentId)
                'cmd.Parameters.AddWithValue("@Amount", )
                cmd.Parameters.AddWithValue("@MemberId", lblMembershipID.Text)
                cmd.Parameters.AddWithValue("@PaymentMethod", "Mastercard")
                cmd.Parameters.AddWithValue("@Status", "Sold")


                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using

        'Dim sql2 As String = "INSERT INTO OrderHistory(paymentId) VALUE (@paymentId)"




        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            Using cmd As New SqlCommand(sql2, con)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using


        args.ShowPaymentReceipt(paymentId)



        With PaymentReceipt
            .TopLevel = False
            Me.Controls.Add(PaymentReceipt)
            .BringToFront()
            .Show()
        End With
    End Sub


End Class