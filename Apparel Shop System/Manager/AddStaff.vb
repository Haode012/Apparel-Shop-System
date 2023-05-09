Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class AddStaff
    Private addStaff As Boolean = False
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        AddNewStaff()
    End Sub

    Private Sub AddNewStaff()
        Dim err As New StringBuilder()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strSql2 As String
        Dim MySqlCommandCheck As New SqlCommand
        Dim MySqlCommandCheckPhone As New SqlCommand
        Dim ctr As Control = Nothing
        Dim strPassword As String = txtPassword.Text
        Dim strconfirmPassword As String = txtConfirmPassword.Text
        Dim choosenSecretQuestion As String = cboSecretQues.SelectedItem
        Dim icNumber As String

        Dim startDate As Date = dtpJoinedDate.Value
        Dim dateOfBirth As Date = dtpDob.Value
        Dim phoneNumber As New Regex("^01[0-46-9]-\d{7,8}$")

        Dim get18Years As Integer = startDate.Year - dateOfBirth.Year



        'Staff Recruit 18 or over people'
        Dim age As Integer
        Dim ts As TimeSpan = DateTime.Now.Date - dtpDob.Value
        age = ts.TotalDays / 365

        If txtStaffName.Text = "" Then
            MessageBox.Show("Please enter the staff name", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStaffName.Focus()
        ElseIf mtxtIcNo.MaskCompleted = False Then
            MessageBox.Show("Please enter the staff Ic No correctly", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtxtIcNo.Focus()
        ElseIf txtHomeAddress.Text = "" Then
            MessageBox.Show("Please enter the staff home address", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHomeAddress.Focus()
        ElseIf phoneNumber.IsMatch(mtxtPhoneNumber.Text) = False Then
            MessageBox.Show("Invalid Phone Number", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtxtPhoneNumber.Focus()
        ElseIf comboStaffPosition.SelectedIndex = -1 Then
            MessageBox.Show("Select a position for staff", "No Choosen Position", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cboSecretQues.SelectedIndex = -1 Then
            MessageBox.Show("Please select a secret question", "Secret question was not choosen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStaffSecretQuestionAns.Text = "" Then
            MessageBox.Show("Please enter the secret question answer", "Secret question was not entered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffSecretQuestionAns.Focus()
        ElseIf strPassword = "" Or strPassword = "Password" Then
            MessageBox.Show("Please enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
        ElseIf strconfirmPassword = "" Or strconfirmPassword = "Confirm Password" Then
            MessageBox.Show("Please enter the confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Focus()
        ElseIf strPassword.Length < 9 And strconfirmPassword.Length < 9 Then
            MessageBox.Show("Password must be 9 or more characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf strconfirmPassword <> strPassword Then
            MessageBox.Show("Password not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Focus()
        ElseIf dtpDob.Value > DateTime.Today Then
            MessageBox.Show("Can't assign future date of birth for staff", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDob.Value = Today.Date
        ElseIf age < 18 Then
            MessageBox.Show("Too young to recruit", "Under Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDob.Value = DateTime.Now
        ElseIf startDate < dateOfBirth.AddYears(18) Then
            MessageBox.Show("Staff needs to be more than 18 to be recruited", "Under Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If OpenConnection() = True Then
                    strSql2 = "Select * From Staff Where IcNo= @IcNo"
                    MySqlCommandCheck = New SqlCommand(strSql2, conn)
                    MySqlCommandCheck.Parameters.AddWithValue("@IcNo", mtxtIcNo.Text)
                    Dim reader As SqlDataReader = MySqlCommandCheck.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        MessageBox.Show("Ic Number exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        reader.Close()
                        strSql2 = "Select * From Staff Where PhoneNumber = @PhoneNumber"
                        MySqlCommandCheck = New SqlCommand(strSql2, conn)
                        MySqlCommandCheck.Parameters.AddWithValue("@PhoneNumber", mtxtPhoneNumber.Text)
                        Dim reader2 As SqlDataReader = MySqlCommandCheck.ExecuteReader()
                        If reader2.HasRows Then
                            reader2.Read()
                            MessageBox.Show("Phone Number exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            reader2.Close()
                        Else
                            reader2.Close()
                            strSql = "Insert Into Staff(StaffID,Name,Address,PhoneNumber,DateOfBirth,startDate,endDate,IcNo,Position,Status,Password,SecretQuestion,SecretAnswer)Values(@StaffID,@Name,@Address,@PhoneNumber,@DateOfBirth,@startDate,NULL,@IcNo,@Position,@Status,@Password,@SecretQuestion,@SecretAnswer)"
                            MySqlCommand = New SqlCommand(strSql, conn)
                            'MySqlCommand.Parameters.AddWithValue("@Id", 6)
                            MySqlCommand.Parameters.AddWithValue("@StaffID", lblStaffID.Text)
                            MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
                            MySqlCommand.Parameters.AddWithValue("@Address", txtHomeAddress.Text)
                            MySqlCommand.Parameters.AddWithValue("@PhoneNumber", mtxtPhoneNumber.Text)
                            MySqlCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                            MySqlCommand.Parameters.AddWithValue("@startDate", startDate)
                            'MySqlCommand.Parameters.AddWithValue("@endDate", null)
                            MySqlCommand.Parameters.AddWithValue("@IcNo", mtxtIcNo.Text)
                            MySqlCommand.Parameters.AddWithValue("@Position", comboStaffPosition.Text)
                            MySqlCommand.Parameters.AddWithValue("@Status", "Active")
                            MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                            MySqlCommand.Parameters.AddWithValue("@SecretQuestion", choosenSecretQuestion)
                            MySqlCommand.Parameters.AddWithValue("@SecretAnswer", txtStaffSecretQuestionAns.Text)
                            MySqlCommand.ExecuteNonQuery()
                            MessageBox.Show("Staff Account Successfully Created.", "New Staff Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            StaffMaintenance.RefreshDataGridView()
                        End If
                    End If
                Else
                    MessageBox.Show("Connection closed", "Error Connection")
                End If
            Catch ex As Exception
                MessageBox.Show("Check the data", "Error")
            End Try
        End If
        CloseConnection()
    End Sub

    Private Sub txtHomeAddress_TextChanged(sender As Object, e As EventArgs) Handles txtHomeAddress.TextChanged

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newId As String
        'Dim stringId As String
        Dim intId As Integer
        If OpenConnection() = True Then
            Dim adpt As New SqlDataAdapter("Select StaffID from Staff", conn)
            Dim ds As New DataSet
            adpt.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                newId = "STF001"
            Else
                Dim maxStaffId As Integer = 0
                For Each row As DataRow In ds.Tables(0).Rows
                    Dim currentStaffId As Integer = Integer.Parse(row.Item(0).ToString().Substring(3))
                    If currentStaffId > maxStaffId Then
                        maxStaffId = currentStaffId
                    End If
                Next
                intId = maxStaffId + 1
                newId = String.Format("STF{0:000}", intId)

            End If
            lblStaffID.Text = newId
        End If
        CloseConnection()

        'txtPhoneNumber.Text = "exp 012-XXXXXXX"
        'txtPhoneNumber.ForeColor = Color.Gray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        StaffMaintenance.Show()
    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        Dim startDate As Date = dtpDob.Value
        dtpJoinedDate.Value = Today.Date
        'If dtpDob.Value > DateTime.Today Then
        '    MessageBox.Show("Can't assign future date of birth for staff", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    dtpDob.Value = Today.Date
        'End If
    End Sub

    Private Sub dtpJoinedDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpJoinedDate.ValueChanged
    End Sub

    'Private Sub cboSecretQues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSecretQues.SelectedIndexChanged
    '    lblSecretQuestionChoosed.Text = cboSecretQues.SelectedItem
    'End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        DailySalesReportViewer.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

End Class