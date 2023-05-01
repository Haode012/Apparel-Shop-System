Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class AddStaff
    Private addStaff As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim strName As String
        'Dim strIcNo As String
        ' Dim strHomeAddress As String
        'Dim strId As String

        ' strName = txtStaffName.Text
        ' strIcNo = txtIcNo.Text
        ' strHomeAddress = txtHomeAddress.Text
        ' strId = "S101"
        '' Dim s As New Staff
        ' s.FullName = strName
        ' s.HomeAddress = strHomeAddress
        ' s.Id = strId

        ' Dim db As New DatabaseStaffDataContext()
        'db.Staffs.InsertOnSubmit(s)
        'db.SubmitChanges()

        ' 4: Show a message box to indicate insertion done
        ' MessageBox.Show("Customer [" & strName & "] inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        AddNewStaff()
    End Sub

    Private Sub AddNewStaff()
        Dim err As New StringBuilder()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strSql2 As String
        Dim MySqlCommandCheck As New SqlCommand
        Dim ctr As Control = Nothing
        Dim strPassword As String = txtPassword.Text
        Dim strconfirmPassword As String = txtConfirmPassword.Text
        Dim icNumber As String

        If strPassword = "" Or strPassword = "Password" Then
            MessageBox.Show("Please enter the password", "Error")
        ElseIf strPassword <> strconfirmPassword Then
            MessageBox.Show("Password not matching", "Error")
        Else
            'Try
            If OpenConnection() = True Then
                strSql2 = "Select * From Staff Where IcNo= @IcNo"
                MySqlCommandCheck = New SqlCommand(strSql2, conn)
                MySqlCommandCheck.Parameters.AddWithValue("@IcNo", txtIcNo.Text)
                Dim reader As SqlDataReader = MySqlCommandCheck.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    MessageBox.Show("Ic Number exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    reader.Close()
                    strSql = "Insert Into Staff(Name,Address,PhoneNumber,DateOfBirth,startDate,endDate,IcNo,Position,Status,Password)Values(@Name,@Address,@PhoneNumber,@DateOfBirth,@startDate,@endDate,@IcNo,@Position,@Status,@Password)"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    'MySqlCommand.Parameters.AddWithValue("@Id", 6)
                    MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
                    MySqlCommand.Parameters.AddWithValue("@Address", txtHomeAddress.Text)
                    MySqlCommand.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    MySqlCommand.Parameters.AddWithValue("@DateOfBirth", dtpDob.Value.ToLongDateString)
                    MySqlCommand.Parameters.AddWithValue("@startDate", dtpJoinedDate.Value.ToLongDateString)
                    MySqlCommand.Parameters.AddWithValue("@endDate", "-")
                    MySqlCommand.Parameters.AddWithValue("@IcNo", txtIcNo.Text)
                    MySqlCommand.Parameters.AddWithValue("@Position", comboStaffPosition.Text)
                    MySqlCommand.Parameters.AddWithValue("@Status", "Active")
                    MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                    MySqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record Added.", "Add Record")
                    Me.Close()
                    StaffMaintenance.RefreshDataGridView()
                End If
            Else
                MessageBox.Show("Wrong Ruth", "GG")
            End If
        End If
        CloseConnection()
        ' Catch
        '  MessageBox.Show("Check the data", "Error")
        ' End Try
    End Sub

    Private Sub txtHomeAddress_TextChanged(sender As Object, e As EventArgs) Handles txtHomeAddress.TextChanged

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub


End Class