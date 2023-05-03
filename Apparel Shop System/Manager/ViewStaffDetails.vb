Imports System.Data.SqlClient
Public Class ViewStaffDetails
    Public strSelectedStaffId As String

    Private Sub ViewStaffDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strName As String
        Dim strStaffID As String
        Dim strIcNo As String
        Dim strAddress As String
        Dim strPhoneNumber As String
        Dim strStatus As String
        Dim strStartDate As String
        Dim strPosition As String
        Dim strDateOfBirth As String
        Dim strEndDate As String
        'Dim strName As String


        If OpenConnection() = True Then
            strSql = "Select * From Staff where StaffId =@StaffId"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@StaffId", strSelectedStaffId)
            Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                strStaffID = reader("StaffID").ToString
                If strStaffID.Equals(strSelectedStaffId) Then
                    strName = reader("Name").ToString
                    strIcNo = reader("IcNo").ToString
                    strAddress = reader("Address").ToString
                    strPhoneNumber = reader("PhoneNumber").ToString
                    strStartDate = reader("StartDate").ToString
                    strStatus = reader("Status").ToString
                    strPosition = reader("Position").ToString
                    strDateOfBirth = reader("DateOfBirth").ToString
                    strEndDate = reader("EndDate").ToString
                    lblViewStaffName.Text = strName
                    lblViewStaffId.Text = strStaffID
                    lblViewStaffPhoneNum.Text = strPhoneNumber
                    lblViewStaffIC.Text = strIcNo
                    lblViewStaffPosition.Text = strPosition
                    lblViewStaffStatus.Text = strStatus
                    lblViewStaffStartDate.Text = strStartDate
                    lblViewStaffDob.Text = strDateOfBirth
                    lblViewStaffEndDate.Text = strEndDate
                    CloseConnection()
                End If
            End If
        End If
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