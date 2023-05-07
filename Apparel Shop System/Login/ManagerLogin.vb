Imports System.Data.SqlClient
Public Class ManagerLogin
    Dim strUserId As String
    Dim strPassword As String
    Dim strName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()
    End Sub

    Private Sub Login()
        strUserId = txtUserId.Text
        strPassword = txtPassword.Text
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim position As String
        Dim strStatus As String
        Dim fullName As String
        Dim strName = txtUserId.Text
        Dim strPasswd = txtPassword.Text
        Dim dbPasswd As String
        'For userID to show in staff Management'
        strPassName = strUserId
        If strName = "" Or strPasswd = "" Then
            MessageBox.Show("Please input all the fields", "Validation")
        Else
            If OpenConnection() = True Then
                Try
                    'strSql = "SELECT Name,Position,Status,Password From NewStaff Where Name = @name and Password= @Password"
                    strSql = "SELECT Name,Position,Status,Password From Staff Where StaffID = @StaffID"
                    '"Select* From Users WHERE Name = @Name AND Position = @Position"
                    MySqlCommand = New SqlCommand(strSql, conn)

                    MySqlCommand.Parameters.AddWithValue("@StaffID", txtUserId.Text)
                    'MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                    Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        fullName = reader("Name").ToString
                        strFullName = fullName
                        position = reader("Position").ToString
                        strStatus = reader("Status").ToString
                        dbPasswd = reader("Password").ToString
                        strPosition = position
                        'Pass log in username to staff management form
                        'dbPasswd = reader("Name").ToString
                        If strStatus = "Active" Then
                            If position = "Manager" Or position = "Assistant Manager" Then
                                If dbPasswd.Equals(strPasswd) Then
                                    CloseConnection()
                                    Me.Hide()

                                    ManagerHomepage.ShowDialog()
                                Else
                                    MessageBox.Show("Password is invalid", "Unable to login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txtPassword.Focus()
                                End If
                            Else
                                MessageBox.Show("Only Manager will be allowed to login", "Unable to login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txtUserId.Text = ""
                                txtPassword.Text = ""
                            End If
                        Else
                            MessageBox.Show("Account is inactive", "Unable to login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtUserId.Text = ""
                            txtPassword.Text = ""
                            txtUserId.Focus()
                        End If
                    Else
                        MessageBox.Show("Please check the information you have entered properly", "Unable to login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUserId.Focus()
                    End If
                Catch e As Exception
                    MessageBox.Show("Error Retrieving information", "Exeption error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            CloseConnection()
        End If


    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserId.Focus()
        'txtPassword.Focus = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ForgotPassword.Show()
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
            chkShow.Text = "Hide Password"
        ElseIf chkShow.Checked = False Then
            txtPassword.PasswordChar = "*"
            chkShow.Text = "Show Password"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Main.Show()
    End Sub
End Class
