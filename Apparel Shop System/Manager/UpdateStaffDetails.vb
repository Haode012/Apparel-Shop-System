Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UpdateStaffDetails
    Public startDate As String = ""
    Public dob As String = ""
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateStaffDetails()
    End Sub

    Private Sub UpdateStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        'If OpenConnection() = True Then
        'Only retrieve staff members that are active to fire and no admin(Manager)'
        strSql = "Select * From Staff where Status = 'Active'AND position!='Manager'"
        MySqlCommand = New SqlCommand(strSql, conn)
        Dim adapter As New SqlDataAdapter(MySqlCommand)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        cbStaffMembers.DataSource = dataTable
        cbStaffMembers.DisplayMember = "StaffID"
        'txtStaffName.Text = dataTable(0)(1)
        'End If
        'CloseConnection()
    End Sub

    Private Sub cbStaffMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStaffMembers.SelectedIndexChanged
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = ""
        Dim selectedID As String
        Dim selectedName As String = ""
        Dim address As String = ""
        Dim phoneNum As String = ""
        'Dim startDate As String = ""
        'Dim dob As String = ""
        Dim icNo As String = ""
        Dim position As String = ""

        If OpenConnection() = True Then
            ' Check if a valid item is selected
            If cbStaffMembers.SelectedIndex >= 0 Then
                ' Fetch the selected row view
                Dim rowView As DataRowView = DirectCast(cbStaffMembers.SelectedItem, DataRowView)

                ' Extract the ID from the row view
                selectedID = rowView("StaffID")

                ' Fetch the details from the database
                Dim query As String = "SELECT Name, DateOfBirth,IcNo,Address,Position,PhoneNumber,startDate FROM Staff WHERE StaffID = @StaffID"
                Dim command As New SqlCommand(query, conn)
                command.Parameters.AddWithValue("@StaffID", selectedID)
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Read the fetched data
                If reader.HasRows Then
                    reader.Read()
                    selectedName = reader("Name").ToString()
                    address = reader("Address").ToString
                    icNo = reader("IcNo").ToString
                    position = reader("Position").ToString
                    phoneNum = reader("PhoneNumber").ToString
                    startDate = reader("startDate").ToString
                    dob = reader("DateOfBirth").ToString
                    'selectedDateOfBirth = Convert.ToDateTime(reader("DateOfBirth"))
                End If

                reader.Close()
                CloseConnection()
            End If
            ' Else
            'MessageBox.Show("No Data inside database", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

        txtStaffName.Text = selectedName
        mtxtStaffIcNo.Text = icNo
        txtStaffID.Text = selectedID
        txtStaffHomeAddress.Text = address
        txtStaffPosition.Text = position
        mtxtStaffPhoneNumber.Text = phoneNum
        dtpDob.Value = dob
        txtStaffDob.Text = dob
        dtpStaffJoinedDate.Value = startDate
        dtpDob.Value = dob
        txtStaffJoinedDate.Text = startDate
    End Sub

    Private Sub comboStaffPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboStaffPosition.SelectedIndexChanged
        txtStaffPosition.Text = comboStaffPosition.SelectedItem.ToString
    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        txtStaffDob.Text = dtpDob.Value.ToLongDateString
    End Sub

    Private Sub dtpStaffJoinedDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStaffJoinedDate.ValueChanged

        txtStaffJoinedDate.Text = dtpStaffJoinedDate.Value.ToLongDateString
    End Sub

    Private Sub UpdateStaffDetails()
        Dim intUpdateCount As Integer
        Dim MySqlCommand As New SqlCommand
        Dim MySqlCommand1 As New SqlCommand
        Dim strSql As String
        Dim strSql2 As String
        Dim selectedID As String
        Dim updatedStartDate As Date = dtpStaffJoinedDate.Value
        Dim updatedDateOfBirth As Date = dtpDob.Value
        Dim phoneNumber As New Regex("^01[0-46-9]-\d{7,8}$")
        Dim get18Years As Integer = updatedStartDate.Year - updatedDateOfBirth.Year

        Dim age As Integer
        Dim ts As TimeSpan = DateTime.Now.Date - dtpDob.Value
        age = ts.TotalDays / 365


        If txtStaffName.Text = "" Then
            MessageBox.Show("Please enter the staff name", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStaffName.Focus()
        ElseIf mtxtStaffIcNo.MaskCompleted = False Then
            mtxtStaffIcNo.Focus()
            MessageBox.Show("Please enter the staff Ic No correctly", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtStaffHomeAddress.Text = "" Then
            MessageBox.Show("Please enter the staff home address", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStaffHomeAddress.Focus()
        ElseIf mtxtStaffIcNo.Text = "" Then
            MessageBox.Show("Please enter the staff Ic No", "Error Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtxtStaffIcNo.Focus()
        ElseIf phoneNumber.IsMatch(mtxtStaffPhoneNumber.Text) = False Then
            MessageBox.Show("Invalid Phone Number", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtxtStaffPhoneNumber.Focus()
            'ElseIf comboStaffPosition.SelectedIndex = -1 Then
            '    MessageBox.Show("Select a position for staff", "No Choosen Position", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStaffPosition.Text = "" Then
            MessageBox.Show("Staff need a selected position", "No Choosen Position", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStaffJoinedDate.Text = "" Then
            MessageBox.Show("Staff joined date is empty", "No Choosen Position", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf age < 18 Then
            MessageBox.Show("Too young to recruit", "Under Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDob.Value = dob
            txtStaffDob.Text = dob
        ElseIf dtpStaffJoinedDate.Value > DateTime.Today Then
            MessageBox.Show("Can't assign future date for existing staff", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpStaffJoinedDate.Value = Today.Date
            txtStaffJoinedDate.Text = startDate
            dtpStaffJoinedDate.Focus()
        ElseIf updatedStartDate < updatedDateOfBirth.AddYears(18) Then
            MessageBox.Show("Staff needs to be more than 18 to be recruited", "Under Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If OpenConnection() = True Then
                    ' Fetch the selected row view
                    Dim rowView As DataRowView = DirectCast(cbStaffMembers.SelectedItem, DataRowView)

                    ' Extract the ID from the row view
                    selectedID = rowView("StaffID")

                    strSql2 = "Select * From Staff Where IcNo= @IcNo AND StaffID !=@StaffID"
                    MySqlCommand1 = New SqlCommand(strSql2, conn)
                    MySqlCommand1.Parameters.AddWithValue("@IcNo", mtxtStaffIcNo.Text)
                    MySqlCommand1.Parameters.AddWithValue("@StaffID", selectedID)
                    Dim reader As SqlDataReader = MySqlCommand1.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        MessageBox.Show("Ic Number exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mtxtStaffIcNo.Focus()
                    Else
                        reader.Close()
                        strSql2 = "Select * From Staff Where PhoneNumber = @PhoneNumber AND StaffID !=@StaffID"
                        MySqlCommand1 = New SqlCommand(strSql2, conn)
                        MySqlCommand1.Parameters.AddWithValue("@PhoneNumber", mtxtStaffPhoneNumber.Text)
                        MySqlCommand1.Parameters.AddWithValue("@StaffID", selectedID)
                        Dim reader2 As SqlDataReader = MySqlCommand1.ExecuteReader()
                        If reader2.HasRows Then
                            reader2.Read()
                            MessageBox.Show("Phone Number exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mtxtStaffPhoneNumber.Focus()
                            reader2.Close()
                        Else
                            reader2.Close()
                            strSql = "Update Staff SET Name =@Name, IcNo = @IcNo,DateOfBirth=@DateOfBirth,Address=@Address,Position=@Position,PhoneNumber=@PhoneNumber,startDate=@startDate where StaffID= @StaffID"
                            MySqlCommand = New SqlCommand(strSql, conn)
                            MySqlCommand.Parameters.AddWithValue("@StaffID", selectedID)
                            MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
                            MySqlCommand.Parameters.AddWithValue("@IcNo", mtxtStaffIcNo.Text)
                            MySqlCommand.Parameters.AddWithValue("@DateOfBirth", updatedDateOfBirth)
                            ' MySqlCommand.Parameters.AddWithValue("@IcNo", txtStaffIc.Text)
                            MySqlCommand.Parameters.AddWithValue("@Address", txtStaffHomeAddress.Text)
                            MySqlCommand.Parameters.AddWithValue("@Position", txtStaffPosition.Text)
                            MySqlCommand.Parameters.AddWithValue("@PhoneNumber", mtxtStaffPhoneNumber.Text)
                            MySqlCommand.Parameters.AddWithValue("@startDate", updatedStartDate)
                            intUpdateCount = MySqlCommand.ExecuteNonQuery()
                            MessageBox.Show(intUpdateCount & " record updated.!", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            StaffMaintenance.RefreshDataGridView()
                        End If
                    End If
                Else
                    MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Check the data", "Error")
            End Try
        End If
        CloseConnection()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

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