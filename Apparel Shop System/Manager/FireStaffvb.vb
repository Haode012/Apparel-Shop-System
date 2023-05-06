Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FireStaffvb

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If cbId.SelectedIndex = -1 Then
            MessageBox.Show("Please select a staff to fire", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'addFiredStaffToDatabase()
            deleteStaff()
        End If
    End Sub

    Private Sub deleteStaff()
        Dim intDeleteCount As Integer
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        'Later do statement where Name=@Name, Status="Active"
        If OpenConnection() = True Then
            strSql = "Update Staff SET Status =@Status,EndDate = @EndDate Where Name=@Name"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Status", "Inactive")
            MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
            MySqlCommand.Parameters.AddWithValue("@EndDate", dtpStaffFireDate.Value.ToLongDateString)
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

    Private Sub addFiredStaffToDatabase()
        Dim selectedID As Integer
        Dim rowView As DataRowView = DirectCast(cbId.SelectedItem, DataRowView)
        selectedID = Convert.ToInt32(rowView("StaffID"))
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim ctr As Control = Nothing
        If OpenConnection() = True Then
            strSql = "Insert Into FiredStaff(StaffId,Name,Address,PhoneNumber,DateOfBirth,startDate,endDate,IcNo,Position,Status,FiredReason)Values(@StaffId,@Name,@Address,@PhoneNumber,@DateOfBirth,@startDate,@endDate,@IcNo,@Position,@Status,@FiredReason)"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@StaffId", selectedID)
            MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
            MySqlCommand.Parameters.AddWithValue("@Address", txtStaffAddress.Text)

            MySqlCommand.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text)
            MySqlCommand.Parameters.AddWithValue("@startDate", txtStaffStartDate.Text)
            MySqlCommand.Parameters.AddWithValue("@endDate", dtpStaffFireDate.Value.ToLongDateString)

            MySqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text)
            MySqlCommand.Parameters.AddWithValue("@Status", "Inactive")
            MySqlCommand.Parameters.AddWithValue("@FiredReason", txtStaffLeavingReason.Text)
            MySqlCommand.ExecuteNonQuery()
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If
        CloseConnection()
    End Sub

    Private Sub FireStaffvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        If OpenConnection() = True Then
            'Only retrieve staff members that are active to fire and no admin(Manager)'
            strSql = "Select * From Staff where Status = 'Active'AND position!='Admin'"
            MySqlCommand = New SqlCommand(strSql, conn)
            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            cbId.DataSource = dataTable
            cbId.DisplayMember = "StaffID"
            'txtStaffName.Text = dataTable(0)(1)
        End If
        CloseConnection()
    End Sub

    Private Sub cbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbId.SelectedIndexChanged
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
            If cbId.SelectedIndex >= 0 Then
                ' Fetch the selected row view
                Dim rowView As DataRowView = DirectCast(cbId.SelectedItem, DataRowView)

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
        txtStaffAddress.Text = address
        txtPosition.Text = position
        txtDateOfBirth.Text = dob
        txtStaffStartDate.Text = startDate
    End Sub

    Private Sub loadData()
        cbId.Items.Clear()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        If OpenConnection() = True Then

            strSql = "Select * From Staff"
            MySqlCommand = New SqlCommand(strSql, conn)
            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            cbId.DataSource = dataTable
            cbId.DisplayMember = "Name"
            'txtStaffName.Text = dataTable(0)(1)


            CloseConnection()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Reset()
        cbId.SelectedIndex = -1
        txtStaffName.Text = ""

        txtStaffAddress.Text = ""
        txtPosition.Text = ""

        txtDateOfBirth.Text = ""
        txtStaffStartDate.Text = ""
        txtStaffLeavingReason.Text = ""
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