Imports System.Data.SqlClient
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


    End Sub
    Public Sub ShowMembershipDetails(MembershipID As String, MembershipName As String)
        lblMembershipID.Text = MembershipID
        lblMembershipName.Text = MembershipName

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
            col.Width = 157 ' Set the width of each column to 157
        Next
        da.Fill(dt)
        dgvTng.DataSource = dt
        dgvTng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvTng.Columns
            col.Width = 157 ' Set the width of each column to 157
        Next
        ' Calculate the total price

        Dim totalPrice As Decimal = 0
        For Each row As DataRow In dt.Rows
            Dim quantity As Integer = CInt(row("productQuantity"))

            Dim priceString As String = row("productPrice").ToString()
            priceString = priceString.Replace("RM", "") ' Remove "RM" from the string
            Dim price As Decimal = Decimal.Parse(priceString)
            Dim rowTotalPrice As Decimal = quantity * price
            totalPrice += rowTotalPrice
        Next

        ' Display the total price in a label or textbox
        Dim nfi As New System.Globalization.NumberFormatInfo()
        nfi.CurrencySymbol = "RM" ' Replace with "RM" 
        lblTotalAmount.Text = totalPrice.ToString("C", nfi)
        lblTotalAmount1.Text = totalPrice.ToString("C", nfi)


    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()

    End Sub


End Class