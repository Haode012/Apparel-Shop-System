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
        Dim strUsername = txtUsername.Text
        Dim strNewPassword = txtNewPassword.Text
        Dim strDateOfBirth = txtDateOfBirth.Text

        If strUsername = "" And strNewPassword = "" Then
            MessageBox.Show("Please input all the fields", "Validation")
        ElseIf strDateOfBirth = "" Then
            MessageBox.Show("Please input all the fields", "Validation")
        Else
            If OpenConnection() = True Then
                strSql1 = "SELECT Name,Position,Status,Password,DateOfBirth From Staff Where Name = @name"
                MySqlCommand = New SqlCommand(strSql1, conn)
                MySqlCommand.Parameters.AddWithValue("@Name", txtUsername.Text)
                MySqlCommand.ExecuteNonQuery()
                Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    readerUsername = reader("Name").ToString
                    readerDateOfBirth = reader("DateOfBirth").ToString
                    reader.Close()
                    If readerDateOfBirth.Equals(strDateOfBirth) Then
                        If strNewPassword.Length > 9 Then
                            strSql = "Update Staff SET Password =@Password Where Name=@Name AND DateOfBirth=@DateOfBirth"
                            MySqlCommand = New SqlCommand(strSql, conn)
                            MySqlCommand.Parameters.AddWithValue("@Name", txtUsername.Text)
                            MySqlCommand.Parameters.AddWithValue("@Password", txtNewPassword.Text)
                            MySqlCommand.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text)
                            MySqlCommand.ExecuteNonQuery()
                            MessageBox.Show("Password Reset Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            lblValidationPassword.Visible = True
                        End If
                    Else
                        MessageBox.Show("Date Of birth is incorrect", "Unable to reset password")
                    End If
                Else
                    lblUsernameError.Visible = True
                End If
            Else
                MessageBox.Show("Not connected", "Unable to reset password")
            End If
            CloseConnection()
        End If
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        If txtNewPassword.Text.Length > 9 Then
            lblValidationPassword.Visible = False
        Else
            lblValidationPassword.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtNewPassword.PasswordChar = ""
        ElseIf chkShow.Checked = False Then
            txtNewPassword.PasswordChar = "*"
        End If
    End Sub
End Class