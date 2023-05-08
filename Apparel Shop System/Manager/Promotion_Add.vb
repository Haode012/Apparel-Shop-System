Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class Promotion_Add

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim strManager As String = strFullName
        Dim now As DateTime = DateTime.Now

        Dim strTitle As String = txtPromotionName.Text
        Dim strDesc As String = txtDesc.Text

        Dim status As String
        If DateTime.Now < dtpStarting.Value Then
            status = "Pending"
        ElseIf DateTime.Now > dtpEnding.Value Then
            status = "Ended"
        Else
            status = "Started"
        End If

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If String.IsNullOrEmpty(txtPromotionName.Text) Then
            err.AppendLine("- Please Enter Promotion Name")
            ctr = If(ctr, txtPromotionName)
        End If

        If String.IsNullOrEmpty(txtDesc.Text) Then
            err.AppendLine("- Please Enter Promotion Description")
            ctr = If(ctr, txtDesc)
        End If

        Dim discount As Double
        If String.IsNullOrEmpty(txtDiscount.Text) Then
            err.AppendLine("- Please enter discount percentage.")
            ctr = If(ctr, txtDiscount)
        ElseIf Not Double.TryParse(txtDiscount.Text, discount) Then
            err.AppendLine("- Please enter a valid discount percentage (must be a number).")
            ctr = If(ctr, txtDiscount)
        ElseIf discount <= 0 Then
            err.AppendLine("- Discount percentage must be greater than 0.")
            ctr = If(ctr, txtDiscount)
        ElseIf discount >= 100 Then
            err.AppendLine("- Discount percentage cannot greater or equal to 100.")
            ctr = If(ctr, txtDiscount)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ctr.Focus()
            Return
        End If

        con.Close()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        con = New SqlConnection(connectionString)
        con.Open()

        Dim sql As String = "INSERT INTO Promotion (promotionName, promotionDescription, promotionStart, promotionEnd, createBy, creationDay, promotionDiscount, promotionStatus) VALUES (@Name, @Desc, @Start, @End, @createBy, @creationDay, @Discount, @Status)"
        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@Name", txtPromotionName.Text)
            cmd.Parameters.AddWithValue("@Desc", txtDesc.Text)
            cmd.Parameters.AddWithValue("@Start", dtpStarting.Value)
            cmd.Parameters.AddWithValue("@End", dtpEnding.Value)
            cmd.Parameters.AddWithValue("@createBy", strManager)
            cmd.Parameters.AddWithValue("@creationDay", now)

            If Not txtDiscount.Text.Contains("%") Then
                txtDiscount.Text &= "%"
            End If

            cmd.Parameters.AddWithValue("@Discount", txtDiscount.Text)
            cmd.Parameters.AddWithValue("@Status", status)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Promotion created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End Using

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