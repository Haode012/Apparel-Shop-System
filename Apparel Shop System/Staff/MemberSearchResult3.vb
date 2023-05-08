Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class MemberSearchResult3

    Private sqlConnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
    Private sqlCommand As SqlCommand
    Public Sub New(memberID As Integer, memberName As String, memberIC As String, memberPhoneNumber As String, memberEmail As String, memberRegistrationDate As String, memberStatus As String, memberAddress As String)
        InitializeComponent()

        TxtSearchMemberID.Text = memberID.ToString()
        TxtMemberSearchName.Text = memberName
        txtSearchMemberIC.Text = memberIC
        TxtSearchMemberPhoneNumber.Text = memberPhoneNumber
        TxtMemberEmail.Text = memberEmail
        TxtMemberRegistrationDate.Text = memberRegistrationDate
        cboMemberStatus.Text = memberStatus
        txtSearchMemberAddress.Text = memberAddress

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrEmpty(TxtMemberSearchName.Text) Then
                MessageBox.Show("Please enter your name", "Empty Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsNumeric(TxtMemberSearchName.Text) Then
                MessageBox.Show("Please enter a valid Name", "Invalid Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(txtSearchMemberIC.Text) Or Not IsNumeric(txtSearchMemberIC.Text) Or txtSearchMemberIC.Text.Length <> 12 Then
                MessageBox.Show("Please enter a valid member IC number (12 digits)", "Invalid IC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(TxtSearchMemberPhoneNumber.Text) Or Not IsNumeric(TxtSearchMemberPhoneNumber.Text) Or TxtSearchMemberPhoneNumber.Text.Length < 10 Or TxtSearchMemberPhoneNumber.Text.Length > 11 Then
                MessageBox.Show("Please enter a valid member phone number (10 or 11 digits)", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(txtSearchMemberAddress.Text) Then
                MessageBox.Show("Please enter Address ", "Empty Address", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim memberId As Integer = Integer.Parse(TxtSearchMemberID.Text)
            Dim memberName As String = TxtMemberSearchName.Text
            Dim memberIC As String = txtSearchMemberIC.Text
            Dim memberPhoneNumber As String = TxtSearchMemberPhoneNumber.Text
            Dim memberEmail As String = TxtMemberEmail.Text
            Dim memberStatus As String = cboMemberStatus.Text
            Dim memberAddress As String = txtSearchMemberAddress.Text
            Dim query As String = "UPDATE Membership SET memberName = @memberName, memberIC = @memberIC, memberPhoneNumber = @memberPhoneNumber, memberEmail = @memberEmail, memberStatus = @memberStatus, memberAddress =@memberAddress WHERE memberID = @memberID"
            Using cmd As New SqlCommand(query, sqlConnection)
                cmd.Parameters.AddWithValue("@memberID", memberId)
                cmd.Parameters.AddWithValue("@memberName", memberName)
                cmd.Parameters.AddWithValue("@memberIC", memberIC)
                cmd.Parameters.AddWithValue("@memberPhoneNumber", memberPhoneNumber)
                cmd.Parameters.AddWithValue("@memberEmail", memberEmail)
                cmd.Parameters.AddWithValue("@memberStatus", memberStatus)
                cmd.Parameters.AddWithValue("@memberAddress", memberAddress)
                sqlConnection.Open()
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Member updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MembershipMaintenance.RefreshData()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Membership.RefreshData()
        Me.Close()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Membership.RefreshData()
        Me.Close()
        Membership.Close()
        ProductItem.Close()
        OrderCart.Close()
        OrderHistory.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Membership.RefreshData()
        Me.Close()
    End Sub


End Class