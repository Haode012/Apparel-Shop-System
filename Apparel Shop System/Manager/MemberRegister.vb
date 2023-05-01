Imports System.Data.SqlClient
Imports System.Net.Mail
Imports Membership
Public Class MemberRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrEmpty(txtMemberName.Text) Then
            MessageBox.Show("Please enter a your name")
            Return
        End If

        If IsNumeric(txtMemberName.Text) Then
            MessageBox.Show("Please enter a valid Name")
            Return
        End If

        If String.IsNullOrEmpty(txtMemberPhoneNumber.Text) Or Not IsNumeric(txtMemberPhoneNumber.Text) Or txtMemberPhoneNumber.Text.Length < 10 Or txtMemberPhoneNumber.Text.Length > 11 Then
            MessageBox.Show("Please enter a valid member phone number (10 or 11 digits)")
            Return
        End If

        If Not IsValidEmail(txtMemberEmail.Text) Then
            MessageBox.Show("Please enter a valid email")
            Return
        End If

        If String.IsNullOrEmpty(txtMemberIC.Text) Or Not IsNumeric(txtMemberIC.Text) Or txtMemberIC.Text.Length <> 12 Then
            MessageBox.Show("Please enter a valid member IC number (12 digits)")
            Return
        End If

        Dim registrationDate As String = DateTime.Now.ToString()
        Dim memberStatus As String = "Active"

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        Dim query As String = "INSERT INTO [Membership] ([memberName], [memberIC], [memberPhoneNumber], [memberEmail], [memberRegistrationDate], [memberStatus]) VALUES (@memberName, @memberIC, @memberPhoneNumber, @memberEmail, @memberRegistrationDate, @memberStatus)"
        Dim selectSql As String = "SELECT COUNT(*) FROM Membership WHERE memberEmail = @memberEmail"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                Using selectCommand As New SqlCommand(selectSql, connection)
                    selectCommand.Parameters.AddWithValue("@memberEmail", txtMemberEmail.Text)

                    connection.Open()
                    Dim count As Integer = CInt(selectCommand.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Email already exists in database!")
                        Exit Sub
                    End If
                End Using
                command.Parameters.AddWithValue("@memberName", txtMemberName.Text)
                command.Parameters.AddWithValue("@memberIC", txtMemberIC.Text)
                command.Parameters.AddWithValue("@memberPhoneNumber", txtMemberPhoneNumber.Text)
                command.Parameters.AddWithValue("@memberEmail", txtMemberEmail.Text)
                command.Parameters.AddWithValue("@memberRegistrationDate", registrationDate)
                command.Parameters.AddWithValue("@memberStatus", "Active")

                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Member registered successfully")
        MembershipMaintenance.RefreshData()

    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(txtMemberName.Text) Then
            MessageBox.Show("Please enter a your name")
            Return True
        End If
        If IsNumeric(txtMemberName.Text) Then
            MessageBox.Show("Please enter a valid Name")
        End If
        If String.IsNullOrEmpty(txtMemberIC.Text) Or Not IsNumeric(txtMemberIC.Text) Or txtMemberIC.Text.Length <> 12 Then
            MessageBox.Show("Please enter a valid member IC number (12 digits)")
            Return True
        End If

        If String.IsNullOrEmpty(txtMemberPhoneNumber.Text) Or Not IsNumeric(txtMemberPhoneNumber.Text) Or txtMemberPhoneNumber.Text.Length < 10 Or txtMemberPhoneNumber.Text.Length > 11 Then
            MessageBox.Show("Please enter a valid member phone number (10 or 11 digits)")
            Return True
        End If

        If Not IsValidEmail(txtMemberEmail.Text) Then
            MessageBox.Show("Please enter a valid member email address")
            Return True
        End If
        Return True
    End Function
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return addr.Address = email
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function CheckEmailExists(email As String) As Boolean
        Dim result As Boolean = False
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        Dim conn As New SqlConnection(connString)
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Membership WHERE memberEmail=@Email", conn)
        cmd.Parameters.AddWithValue("@Email", email)

        Try
            conn.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            If count > 0 Then
                result = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking email: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return result
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
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

    Private Sub txtMemberIC_TextChanged(sender As Object, e As EventArgs) Handles txtMemberIC.TextChanged

    End Sub

    Private Sub txtMemberPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMemberPhoneNumber.TextChanged

    End Sub

    Private Sub txtMemberEmail_TextChanged(sender As Object, e As EventArgs) Handles txtMemberEmail.TextChanged

    End Sub

    Private Sub txtMemberName_TextChanged(sender As Object, e As EventArgs) Handles txtMemberName.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblMemberPhoneNumber_Click(sender As Object, e As EventArgs) Handles lblMemberPhoneNumber.Click

    End Sub

    Private Sub lblMemberID_Click(sender As Object, e As EventArgs) Handles lblMemberID.Click

    End Sub

    Private Sub lblMemberName_Click(sender As Object, e As EventArgs) Handles lblMemberName.Click

    End Sub


End Class