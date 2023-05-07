Imports System.Data.SqlClient
Public Class ForgotPassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        forgotPassword()
    End Sub

    Private Sub forgotPassword()
        Dim MySqlCommand As New SqlCommand
        Dim strSql1 As String
        Dim strSql As String
        Dim readerDateOfBirth As String
        Dim readerUsername As String
        Dim readerOldPassword As String
        Dim readerSecretQuestion As String
        Dim readerSecretQuestionAnswer As String
        Dim secretQuestion As String = cboSecretQues.SelectedItem
        Dim secretAnswer As String = txtSecretAnswer.Text
        Dim strUsername = txtUsername.Text
        Dim strNewPassword = txtNewPassword.Text
        Dim strConfrimPassword = txtConfirmPassword.Text
        ' Dim strDateOfBirth = dtpStaffDob.Value

        If strUsername = "" And strNewPassword = "" Then
            MessageBox.Show("Please input all the fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf strDateOfBirth = "" Then
            'MessageBox.Show("Please input all the fields", "Validation")
        ElseIf strNewPassword <> strConfrimPassword Then
            MessageBox.Show("Passwords are not matching", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If OpenConnection() = True Then
                Try
                    strSql1 = "SELECT StaffID,Position,Status,Password,DateOfBirth,SecretQuestion,SecretAnswer From Staff Where StaffID = @StaffID"
                    MySqlCommand = New SqlCommand(strSql1, conn)
                    MySqlCommand.Parameters.AddWithValue("@StaffID", txtUsername.Text)
                    MySqlCommand.ExecuteNonQuery()
                    Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        lblUsernameError.Visible = False
                        'readerUsername = reader("Name").ToString
                        readerSecretQuestion = reader("SecretQuestion").ToString
                        readerSecretQuestionAnswer = reader("SecretAnswer").ToString
                        readerOldPassword = reader("Password").ToString
                        reader.Close()
                        If readerSecretQuestion.Equals(secretQuestion) Then
                            If readerSecretQuestionAnswer.Equals(secretAnswer) Then
                                If strNewPassword.Length >= 9 Then
                                    If strNewPassword <> readerOldPassword Then
                                        strSql = "Update Staff SET Password =@Password Where StaffID=@StaffID"
                                        MySqlCommand = New SqlCommand(strSql, conn)
                                        MySqlCommand.Parameters.AddWithValue("@StaffID", txtUsername.Text)
                                        MySqlCommand.Parameters.AddWithValue("@Password", txtNewPassword.Text)
                                        'MySqlCommand.Parameters.AddWithValue("@DateOfBirth", secretQuestion)
                                        MySqlCommand.ExecuteNonQuery()
                                        MessageBox.Show("Password Reset Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Me.Close()
                                    Else
                                        MessageBox.Show("Your new password cannot be the same as your current password", "Validation", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
                                    End If
                                Else
                                    lblValidationPassword.Visible = True
                                End If
                            Else
                                MessageBox.Show("Secret answer was wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Secret Question was wrong", "Unable to reset password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        lblUsernameError.Visible = True
                        txtNewPassword.Text = ""
                        txtConfirmPassword.Text = ""
                        txtSecretAnswer.Text = ""
                        txtUsername.Text = ""
                        cboSecretQues.SelectedIndex = -1
                    End If
                Catch Ex As Exception
                    MessageBox.Show("Check the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Not connected", "Unable to reset password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            CloseConnection()
        End If
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        If txtNewPassword.Text.Length >= 9 AndAlso txtNewPassword.Text.Length <= 11 Then
            'lblValidationPassword.Visible = False
            lblValidationPassword.Text = "Password Moderate"
            lblValidationPassword.ForeColor = Color.Orange
            'lblValidationPassword.BackColor = Color.Gray
        ElseIf txtNewPassword.Text.Length > 11 Then
            lblValidationPassword.Text = "Password Strong"
            lblValidationPassword.ForeColor = Color.Green
        Else
            lblValidationPassword.Text = "Password Weak"
            lblValidationPassword.ForeColor = Color.Red
            lblValidationPassword.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtNewPassword.PasswordChar = ""
            txtConfirmPassword.PasswordChar = ""
            chkShow.Text = "Hide Password"
        ElseIf chkShow.Checked = False Then
            txtNewPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"
            chkShow.Text = "Show Password"
        End If
    End Sub
End Class