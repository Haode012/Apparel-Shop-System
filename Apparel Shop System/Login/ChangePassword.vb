Imports System.Data.SqlClient
Public Class ChangePassword
    Public Property strUserId As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Dim dialogRes As DialogResult

        dialogRes = MessageBox.Show("Are you sure you want to cancel ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogRes = DialogResult.Yes = True Then
            txtNewPasswd.Text = ""
            txtUserID.Text = ""
            txtConfirmPasswd.Text = ""
            txtOldPasswd.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = strPassName
        txtOldPasswd.Text = "LOL"

        Dim sqlCommand As SqlCommand
        Dim strQuery As String
        Dim userPassword As String

        If OpenConnection() = True Then
            strQuery = "Select * From Staff where Name=@Name"
            sqlCommand = New SqlCommand(strQuery, conn)
            sqlCommand.Parameters.AddWithValue("@Name", strPassName)
            sqlCommand.ExecuteNonQuery()
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                'userName = reader("Name").ToString
                'If userName.Equals(txtUserID.Text) Then
                userPassword = reader("Password").ToString

                txtOldPasswd.Text = userPassword
                'End If
            End If
        Else
            MessageBox.Show("Not connected", "Aiyo")
        End If
        CloseConnection()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPasswd.CheckedChanged
        If chkShowPasswd.Checked = True Then
            txtOldPasswd.PasswordChar = ""
            txtNewPasswd.PasswordChar = ""
            txtConfirmPasswd.PasswordChar = ""
        Else
            txtOldPasswd.PasswordChar = "*"
            txtNewPasswd.PasswordChar = "*"
            txtConfirmPasswd.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure you want to cancel the change password process", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txtNewPasswd.Text = ""
            txtConfirmPasswd.Text = ""
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeNewPassword()
    End Sub
    Private Sub ChangeNewPassword()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strNewPassword As String = txtNewPasswd.Text
        Dim strCnfirmNewPassword As String = txtConfirmPasswd.Text


        If strNewPassword = "" Or strCnfirmNewPassword = "" Then
            MessageBox.Show("Please input all the fields", "Validation")
        ElseIf strNewPassword <> strCnfirmNewPassword Then
            MessageBox.Show("Password is not matching", "Validation")
        ElseIf strNewPassword.Equals(txtNewPasswd.Text) Then
            MessageBox.Show("Your new password cannot be the same as your current password", "Validation", MessageBoxButtons.OK,
MessageBoxIcon.Error)
            txtNewPasswd.Text = ""
            txtConfirmPasswd.Text = ""
        Else
            If OpenConnection() = True Then
                strSql = "Update Staff SET Password =@Password Where Name=@Name"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@Name", txtUserID.Text)
                MySqlCommand.Parameters.AddWithValue("@Password", txtConfirmPasswd.Text)
                MySqlCommand.ExecuteNonQuery()
                MessageBox.Show("Password Reset Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Not connected", "Unable to reset password")
            End If
            CloseConnection()
        End If
    End Sub
End Class