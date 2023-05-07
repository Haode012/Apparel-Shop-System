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
            strSql = "Select * From Staff where StaffID =@StaffID"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@StaffID", strSelectedStaffId)
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
                    lblHomeAddress.Text = strAddress
                    lblViewStaffPhoneNum.Text = strPhoneNumber
                    lblViewStaffIC.Text = strIcNo
                    lblViewStaffPosition.Text = strPosition
                    lblViewStaffStatus.Text = strStatus
                    lblViewStaffStartDate.Text = strStartDate
                    lblViewStaffDob.Text = strDateOfBirth
                    lblViewStaffEndDate.Text = strEndDate
                    reader.Close()
                End If
            End If
        End If
        CloseConnection()
    End Sub
End Class