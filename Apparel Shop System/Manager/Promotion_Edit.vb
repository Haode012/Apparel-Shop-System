Imports System.Data.SqlClient
Imports System.Text
Public Class Promotion_Edit

    Public strSelectedId As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Promotion_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()

    End Sub

    Public Sub FillData()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        con = New SqlConnection(connectionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Promotion WHERE promotionId = @promotionId"
        cmd.Parameters.AddWithValue("@promotionId", strSelectedId)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            ' Fill data into textboxes
            txtPromotionName.Text = reader("promotionName").ToString()
            txtPromotionDescription.Text = reader("promotionDescription").ToString()
            dtStartDate.Value = Convert.ToDateTime(reader("promotionStart"))
            dtEndDate.Value = Convert.ToDateTime(reader("promotionEnd"))
            txtDiscount.Text = reader("promotionDiscount").ToString()
            cboStatus.Text = reader("promotionStatus").ToString()

        End If

        reader.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim now As DateTime = DateTime.Now
        Dim editor As String = "Manager1"


        If String.IsNullOrEmpty(txtPromotionName.Text) Then
            err.AppendLine("- Please Enter Promotion Name")
            ctr = If(ctr, txtPromotionName)
        End If

        If String.IsNullOrEmpty(txtPromotionDescription.Text) Then
            err.AppendLine("- Please Enter Promotion Description")
            ctr = If(ctr, txtPromotionDescription)
        End If

        If String.IsNullOrEmpty(txtDiscount.Text) Then
            err.AppendLine("- Please Enter discount percentage")
            ctr = If(ctr, txtDiscount)
        End If

        If cboStatus.SelectedItem Is Nothing Then
            err.AppendLine("- Please select a status")
            ctr = If(ctr, cboStatus)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        con.Close()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        con = New SqlConnection(connectionString)
        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Promotion SET promotionName = @promotionName, promotionDescription = @promotionDescription, promotionDiscount = @promotionDiscount, promotionStart = @promotionStart, promotionEnd = @promotionEnd, modifiedDay = @modifiedDay, modifiedBy = @modifiedBy, promotionStatus = @promotionStatus WHERE promotionId = @promotionId"
        cmd.Parameters.AddWithValue("@promotionName", txtPromotionName.Text)
        cmd.Parameters.AddWithValue("@promotionDescription", txtPromotionDescription.Text)
        cmd.Parameters.AddWithValue("@promotionStart", dtStartDate.Value)
        cmd.Parameters.AddWithValue("@promotionEnd", dtEndDate.Value)
        If Not txtDiscount.Text.Contains("%") Then
            txtDiscount.Text &= "%"
        End If
        cmd.Parameters.AddWithValue("@promotionDiscount", txtDiscount.Text)
        cmd.Parameters.AddWithValue("@modifiedDay", now)
        cmd.Parameters.AddWithValue("@modifiedBy", editor)
        cmd.Parameters.AddWithValue("@promotionStatus", cboStatus.SelectedItem)
        cmd.Parameters.AddWithValue("@promotionId", strSelectedId)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Promotion updated successfully.")
        Else
            MessageBox.Show("Failed to update promotion.")
        End If
        con.Close()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        Promotion_Details.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class