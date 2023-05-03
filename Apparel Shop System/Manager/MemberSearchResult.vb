Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class MemberSearchResult

    Private sqlConnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
    Private sqlCommand As SqlCommand
    Public Sub New(memberID As Integer, memberName As String, memberIC As String, memberPhoneNumber As String, memberEmail As String, memberRegistrationDate As String, memberStatus As String)
        InitializeComponent()

        TxtSearchMemberID.Text = memberID.ToString()
        TxtMemberSearchName.Text = memberName
        txtSearchMemberIC.Text = memberIC
        TxtSearchMemberPhoneNumber.Text = memberPhoneNumber
        TxtMemberEmail.Text = memberEmail
        TxtMemberRegistrationDate.Text = memberRegistrationDate
        TxtMemberStatus.Text = memberStatus
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrEmpty(TxtMemberSearchName.Text) Then
                MessageBox.Show("Please enter a your name")
                Return
            End If
            If IsNumeric(TxtMemberSearchName.Text) Then
                MessageBox.Show("Please enter a valid Name")
            End If
            If String.IsNullOrEmpty(txtSearchMemberIC.Text) Or Not IsNumeric(txtSearchMemberIC.Text) Or txtSearchMemberIC.Text.Length <> 12 Then
                MessageBox.Show("Please enter a valid member IC number (12 digits)")
                Return
            End If

            If String.IsNullOrEmpty(TxtSearchMemberPhoneNumber.Text) Or Not IsNumeric(TxtSearchMemberPhoneNumber.Text) Or TxtSearchMemberPhoneNumber.Text.Length < 10 Or TxtSearchMemberPhoneNumber.Text.Length > 11 Then
                MessageBox.Show("Please enter a valid member phone number (10 or 11 digits)")
                Return
            End If

            Dim memberId As Integer = Integer.Parse(TxtSearchMemberID.Text)
            Dim memberName As String = TxtMemberSearchName.Text
            Dim memberIC As String = txtSearchMemberIC.Text
            Dim memberPhoneNumber As String = TxtSearchMemberPhoneNumber.Text
            Dim memberEmail As String = TxtMemberEmail.Text
            Dim memberStatus As String = TxtMemberStatus.Text

            Dim query As String = "UPDATE Membership SET memberName = @memberName, memberIC = @memberIC, memberPhoneNumber = @memberPhoneNumber, memberEmail = @memberEmail, memberStatus = @memberStatus WHERE memberID = @memberID"
            Using cmd As New SqlCommand(query, sqlConnection)
                cmd.Parameters.AddWithValue("@memberID", memberId)
                cmd.Parameters.AddWithValue("@memberName", memberName)
                cmd.Parameters.AddWithValue("@memberIC", memberIC)
                cmd.Parameters.AddWithValue("@memberPhoneNumber", memberPhoneNumber)
                cmd.Parameters.AddWithValue("@memberEmail", memberEmail)
                cmd.Parameters.AddWithValue("@memberStatus", memberStatus)
                sqlConnection.Open()
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Member updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MembershipMaintenance.RefreshDataGridView()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub


End Class