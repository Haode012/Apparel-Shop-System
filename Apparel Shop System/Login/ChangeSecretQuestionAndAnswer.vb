Imports System.Data.SqlClient
Public Class ChangeSecretQuestionAndAnswer
    Private Sub ChangeSecretQuestionAndAnswer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = strPassName

        Dim strSql As String
        Dim mySqlCommand As SqlCommand
        Dim secretQuestion As String
        Dim secretAnswer As String

        If OpenConnection() = True Then
            'strSql = "SELECT Name,Position,Status,Password From NewStaff Where Name = @name and Password= @Password"
            strSql = "SELECT SecretQuestion,SecretAnswer From Staff Where StaffID = @StaffID"
            '"Select* From Users WHERE Name = @Name AND Position = @Position"
            mySqlCommand = New SqlCommand(strSql, conn)

            mySqlCommand.Parameters.AddWithValue("@StaffID", txtUserID.Text)
            'MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                secretQuestion = reader("SecretQuestion").ToString
                secretAnswer = reader("SecretAnswer").ToString
                strSecretAnswer = secretAnswer
                cboSecretQuestion.SelectedItem = secretQuestion
                txtSecretAnswer.Text = secretAnswer
            End If
        End If
        CloseConnection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changeSecretInfo()
    End Sub



    Private Sub cboSecretQuestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSecretQuestion.SelectedIndexChanged
        If cboSecretQuestion.SelectedIndex <> -1 Then
            txtSecretAnswer.Text = ""
        End If
    End Sub

    Private Sub changeSecretInfo()
        Dim strSql As String
        Dim mySqlCommand As SqlCommand
        Dim selectedQuestion As String = cboSecretQuestion.SelectedItem
        Dim newSecretAnswer As String = txtSecretAnswer.Text

        If cboSecretQuestion.SelectedIndex = -1 Then
            MessageBox.Show("Select a secret question", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtSecretAnswer.Text = "" Then
            MessageBox.Show("Please enter secret question answer", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSecretAnswer.Focus()
        ElseIf newSecretAnswer.Equals(strSecretAnswer) Then
            MessageBox.Show("New secret answer can't be the same as your current secret answer", "Secret Answer Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSecretAnswer.Focus()
        Else
            Try
                If OpenConnection() = True Then
                    'strSql = "SELECT Name,Position,Status,Password From NewStaff Where Name = @name and Password= @Password"
                    strSql = "Update Staff SET SecretQuestion=@SecretQuestion,SecretAnswer=@SecretAnswer Where StaffID = @StaffID"
                    '"Select* From Users WHERE Name = @Name AND Position = @Position"
                    mySqlCommand = New SqlCommand(strSql, conn)
                    mySqlCommand.Parameters.AddWithValue("@StaffID", txtUserID.Text)
                    mySqlCommand.Parameters.AddWithValue("@SecretQuestion", selectedQuestion)
                    mySqlCommand.Parameters.AddWithValue("@SecretAnswer", newSecretAnswer)
                    mySqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Secret Question and Answer Updated", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("No connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Please Check the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        CloseConnection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class