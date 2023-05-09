Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FireStaffvb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firedDate As Date = dtpStaffFireDate.Value
        Dim joinedDate As Date = txtStaffStartDate.Text
        If firedDate < joinedDate Then
            MessageBox.Show("Can't assign date before the staff join date to fire", "Fire Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpStaffFireDate.Value = Today.Date
        Else
            'addFiredStaffToDatabase()
            deleteStaff()
            loadTheStaff()

        End If
    End Sub

    Private Sub deleteStaff()
        Dim intDeleteCount As Integer
        Dim selectedID As String
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim selectedStaffIndex = cbId.SelectedItem
        Dim firedDate As Date = dtpStaffFireDate.Value
        Dim joinedDate As Date = txtStaffStartDate.Text
        Dim rowView As DataRowView = DirectCast(cbId.SelectedItem, DataRowView)
        selectedID = rowView("StaffID")



        Try
                If OpenConnection() = True Then
                    strSql = "Update Staff SET Status =@Status,EndDate = @EndDate Where StaffID=@StaffID"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@Status", "Inactive")
                    MySqlCommand.Parameters.AddWithValue("@StaffID", selectedID)
                    MySqlCommand.Parameters.AddWithValue("@EndDate", firedDate)
                    intDeleteCount = MySqlCommand.ExecuteNonQuery()
                    StaffMaintenance.RefreshDataGridView()
                    MessageBox.Show("Staff has been successfully fired", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                    ' loadTheStaff()
                    'currentRow = 0
                    'Me.Close()
                    'UpdateDatabase_Load(Nothing, Nothing)
                Else
                    MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Check the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        CloseConnection()
    End Sub

    Private Sub addFiredStaffToDatabase()
        Dim selectedID As String
        Dim rowView As DataRowView = DirectCast(cbId.SelectedItem, DataRowView)
        selectedID = rowView("StaffID")
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim ctr As Control = Nothing
        Dim dateOfBirth As Date = dtpStaffFireDate.Value
        Try
            If OpenConnection() = True Then
                strSql = "Insert Into FiredStaff(StaffId,Name,Address,PhoneNumber,DateOfBirth,startDate,endDate,IcNo,Position,Status,FiredReason)Values(@StaffId,@Name,@Address,@PhoneNumber,@DateOfBirth,@startDate,@endDate,@IcNo,@Position,@Status,@FiredReason)"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@StaffId", selectedID)
                MySqlCommand.Parameters.AddWithValue("@Name", txtStaffName.Text)
                MySqlCommand.Parameters.AddWithValue("@Address", txtStaffAddress.Text)
                MySqlCommand.Parameters.AddWithValue("@PhoneNumber", mtxtPhoneNumber.Text)
                MySqlCommand.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text)
                MySqlCommand.Parameters.AddWithValue("@startDate", txtStaffStartDate.Text)
                MySqlCommand.Parameters.AddWithValue("@endDate", dateOfBirth)
                MySqlCommand.Parameters.AddWithValue("@IcNo", mtxtIcNo.Text)
                MySqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text)
                MySqlCommand.Parameters.AddWithValue("@Status", "Inactive")
                MySqlCommand.Parameters.AddWithValue("@FiredReason", txtStaffLeavingReason.Text)
                MySqlCommand.ExecuteNonQuery()
            Else
                MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Check the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CloseConnection()
    End Sub

    Private Sub FireStaffvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTheStaff()
    End Sub

    Private Sub cbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbId.SelectedIndexChanged
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String = ""
        Dim selectedID As String
        Dim selectedName As String = ""
        Dim address As String = ""
        Dim phoneNum As String = ""
        Dim startDate As String = ""
        Dim dob As String = ""
        Dim icNo As String = ""
        Dim position As String = ""
        Try
            If OpenConnection() = True Then
                ' Check if a valid item is selected
                If cbId.SelectedIndex >= 0 Then
                    ' Fetch the selected row view
                    Dim rowView As DataRowView = DirectCast(cbId.SelectedItem, DataRowView)

                    ' Extract the ID from the row view
                    selectedID = (rowView("StaffID"))

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


                        txtStaffName.Text = selectedName
                        mtxtIcNo.Text = icNo
                        txtStaffAddress.Text = address
                        txtPosition.Text = position
                        mtxtPhoneNumber.Text = phoneNum
                        txtDateOfBirth.Text = dob
                        txtStaffStartDate.Text = startDate
                    End If

                    reader.Close()
                End If
                ' Else
                'MessageBox.Show("No Data inside database", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Check the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CloseConnection()
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

    'Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        StaffManagement.Show()
    '    Else
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Reset()
        cbId.SelectedIndex = -1
        txtStaffName.Text = ""
        mtxtIcNo.Text = ""
        txtStaffAddress.Text = ""
        txtPosition.Text = ""
        mtxtPhoneNumber.Text = ""
        txtDateOfBirth.Text = ""
        txtStaffStartDate.Text = ""
        txtStaffLeavingReason.Text = ""
    End Sub

    Private Sub loadTheStaff()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        'If OpenConnection() = True Then
        Try
            'Only retrieve staff members that are active to fire and no admin(Manager)'
            strSql = "Select * From Staff where Status = 'Active'AND position!='Manager' AND position!='Assistant Manager'"
            MySqlCommand = New SqlCommand(strSql, conn)
            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            cbId.DataSource = dataTable
            cbId.DisplayMember = "StaffID"
            'txtStaffName.Text = dataTable(0)(1)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message & vbCrLf & "Stack trace: " & ex.StackTrace)
        End Try
        'End If
        'CloseConnection()
    End Sub

    Private Sub dtpStaffFireDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStaffFireDate.ValueChanged

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