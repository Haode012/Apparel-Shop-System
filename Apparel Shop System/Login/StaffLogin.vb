Imports System.Data.SqlClient
Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Login()
        'strUserId = txtUserId.Text
        'strPassword = txtPassword.Text
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim position As String
        Dim strStatus As String
        Dim strName = txtStaffId.Text
        Dim strPasswd = txtPassword.Text
        Dim dbPasswd As String
        'For userID to show in staff Management'
        ' strPassName = strUserId
        If strName = "" And strPasswd = "" Then
            MessageBox.Show("Please input all the fields", "Validation")
        Else
            If OpenConnection() = True Then
                'strSql = "SELECT Name,Position,Status,Password From NewStaff Where Name = @name and Password= @Password"
                strSql = "SELECT Name,Position,Status,Password From Staff Where Name = @name"
                '"Select* From Users WHERE Name = @Name AND Position = @Position"
                MySqlCommand = New SqlCommand(strSql, conn)

                MySqlCommand.Parameters.AddWithValue("@Name", txtStaffId.Text)
                'MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    position = reader("Position").ToString
                    strStatus = reader("Status").ToString
                    dbPasswd = reader("Password").ToString
                    'Pass log in username to staff management form
                    'dbPasswd = reader("Name").ToString
                    If dbPasswd.Equals(strPasswd) Then
                        If strStatus = "Active" Then
                            If position <> "Admin" Then
                                CloseConnection()
                                Me.Hide()
                                Homepage.ShowDialog()
                            Else
                                MessageBox.Show("Only Staff will be able to login", "Unable to login")
                            End If
                        Else
                            MessageBox.Show("Your account is inactive", "Unable to login")
                            txtStaffId.Text = ""
                            txtPassword.Text = ""
                            txtStaffId.Focus()
                        End If
                    Else
                        MessageBox.Show("Your password is invalid", "Unable to login")
                    End If
                End If
            End If
            CloseConnection()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ForgotPassword.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub
End Class
