Imports System.Data.SqlClient
Public Class UpdateStaffDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateStaffDetails()
    End Sub

    Private Sub UpdateStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        If OpenConnection() = True Then
            'Only retrieve staff members that are active to fire and no admin(Manager)'
            strSql = "Select * From Staff where Status = 'Active'AND position!='Admin'"
            MySqlCommand = New SqlCommand(strSql, conn)
            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            cbStaffMembers.DataSource = dataTable
            cbStaffMembers.DisplayMember = "StaffID"
            'txtStaffName.Text = dataTable(0)(1)
        End If
        CloseConnection()
    End Sub

    Private Sub cbStaffMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStaffMembers.SelectedIndexChanged
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = ""
        Dim selectedID As Integer
        Dim selectedName As String = ""
        Dim address As String = ""
        Dim phoneNum As String = ""
        Dim startDate As String = ""
        Dim dob As String = ""
        Dim icNo As String = ""
        Dim position As String = ""

        If OpenConnection() = True Then
            ' Check if a valid item is selected
            If cbStaffMembers.SelectedIndex >= 0 Then
                ' Fetch the selected row view
                Dim rowView As DataRowView = DirectCast(cbStaffMembers.SelectedItem, DataRowView)

                ' Extract the ID from the row view
                selectedID = Convert.ToInt32(rowView("StaffID"))

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
        txtStaffIc.Text = icNo
        txtStaffID.Text = selectedID
        txtStaffHomeAddress.Text = address
        txtStaffPosition.Text = position
        txtStaffPhoneNumber.Text = phoneNum
        txtStaffDob.Text = dob
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
        Dim intDeleteCount As Integer
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        'Later do statement where Name=@Name, Status="Active"
        If OpenConnection() = True Then
            strSql = "Update Staff SET Name =@Name, DateOfBirth=@DateOfBirth,Address=@Address,Position=@Position,PhoneNumber=@PhoneNumber,startDate=@startDate"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Name", "Inactive")
            MySqlCommand.Parameters.AddWithValue("@DateOfBirth", txtStaffName.Text)
            ' MySqlCommand.Parameters.AddWithValue("@IcNo", txtStaffIc.Text)
            MySqlCommand.Parameters.AddWithValue("@Address", txtStaffHomeAddress.Text)
            MySqlCommand.Parameters.AddWithValue("@Position", txtStaffPosition.Text)
            MySqlCommand.Parameters.AddWithValue("@PhoneNumber", txtStaffPhoneNumber.Text)
            MySqlCommand.Parameters.AddWithValue("@startDate", txtStaffJoinedDate.Text)
            intDeleteCount = MySqlCommand.ExecuteNonQuery()
            StaffMaintenance.RefreshDataGridView()
            MessageBox.Show(intDeleteCount & " record deleted.!", "Deleted Record")
            Reset()
            'currentRow = 0
            'Me.Close()
            'UpdateDatabase_Load(Nothing, Nothing)
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If
        CloseConnection()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class