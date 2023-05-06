Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class StaffMaintenance
    Dim strCurrentStaff As String
    Dim strFiredStaff As String
    Dim strCurrentUser As String
    Public Property StringPassName As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If strPosition = "Manager" Then
            With AddStaff
                .TopLevel = False
                Me.Controls.Add(AddStaff)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to add new staff", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub StaffMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Public Sub RefreshDataGridView()
        Load()
    End Sub

    Private Shadows Sub Load()

        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        'If OpenConnection() = True Then
        strSql = "Select StaffID,Name,IcNo,Address,DateOfBirth,PhoneNumber,StartDate,EndDate,Position,Status From Staff"
        MySqlCommand = New SqlCommand(strSql, conn)
        Dim adapter As New SqlDataAdapter(MySqlCommand)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        dtgAllStaff.DataSource = dataTable
        'dtgAllStaff.DataSource = "lololol"
        lblRecords.Text = "Number of records:" + dtgAllStaff.Rows.Count.ToString
        'End If
        Try
            If dtgAllStaff.Rows.Count > 0 Then
                For i As Integer = 0 To dtgAllStaff.Rows.Count - 1
                    Dim status As String = dtgAllStaff.Rows(i).Cells("Status").Value.ToString().Trim()
                    If status = "Active" Then
                        For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                            With dtgAllStaff.Rows(i).Cells(j).Style
                                .BackColor = Color.Green
                                .ForeColor = Color.White
                            End With
                        Next
                    Else
                        For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                            With dtgAllStaff.Rows(i).Cells(j).Style
                                .BackColor = Color.Red
                                .ForeColor = Color.White
                            End With
                        Next
                    End If

                Next
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString())
        End Try
        'End If
    End Sub

    Friend Function selectedRowID() As String
        Dim strId As String
        strId = dtgAllStaff.SelectedRows(0).Cells(0).ToString
        Return strId
    End Function

    Private Sub chkStaffInfoList_SelectedIndexChanged(sender As Object, e As EventArgs)

        If chkStaffInfoList.SelectedItem.ToString = "Staff ID" Then
            dtgAllStaff.Columns(0).Visible = False
        Else
            dtgAllStaff.Columns(0).Visible = True
            dtgAllStaff.Columns(1).Visible = True
            dtgAllStaff.Columns(2).Visible = True
            dtgAllStaff.Columns(3).Visible = True
            dtgAllStaff.Columns(4).Visible = True
            dtgAllStaff.Columns(5).Visible = True
            dtgAllStaff.Columns(6).Visible = True
        End If

    End Sub

    Private Sub searchFilter()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strName As String


        If OpenConnection() = True Then
            strSql = "Select StaffID,Name,IcNo,Address,DateOfBirth,PhoneNumber,StartDate,EndDate,Position,Status From Staff where Name like '%" + txtFilterV.Text + "%'"
            MySqlCommand = New SqlCommand(strSql, conn)

            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            dtgAllStaff.DataSource = dataTable

            CloseConnection()
        End If

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        searchFilter()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If strPosition = "Manager" Then
            CloseConnection()
            With FireStaffvb
                .TopLevel = False
                Me.Controls.Add(FireStaffvb)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to access fire staff", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If strPosition = "Manager" Then
            With UpdateStaffDetails
                .TopLevel = False
                Me.Controls.Add(UpdateStaffDetails)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Only manager is allowed to access update staff details", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtFilterV_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtgAllStaff_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAllStaff.CellDoubleClick
        'AddStaff.Show()
        Dim intNo As Integer = e.RowIndex
        Try
            ViewStaffDetails.strSelectedStaffId = CStr(dtgAllStaff.Rows(intNo).Cells(0).Value)
            ViewStaffDetails.Show()
            Load()
        Catch ex As ArgumentOutOfRangeException
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim user As New ChangePassword
        user.strUserId = strPassName
        ChangePassword.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        ' Dim i As Integer
        'For i = 0 To 7
        'dtgAllStaff.Columns(i).Visible = True
        ' Next
        Load()
        cbDropDownList.SelectedIndex = -1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PrintDocumentStaff.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocumentStaff
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocumentStaff_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentStaff.PrintPage
        Dim mRow As Integer = 0
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim newpage As Boolean = True
        Dim fntHeader As New Font("Arial", 28, FontStyle.Bold Or FontStyle.Underline)
        Dim fntNextSubHeader As New Font("Arial", 13, FontStyle.Regular)
        Dim strHeader As String = "STAFF REPORT OF APPARELL SHOP SYSTEM“
        Dim reportGenerateUser As String = "Report Generate By: " & strPassName & "Position: ".PadLeft(90) & strPosition
        Dim reportGenerateUserPosition As String = "Position: " + strPosition
        Dim reportGeneratedTimeDate As String = "Report Generated At: " + strDate
        Dim body As New System.Text.StringBuilder

        With dtgAllStaff
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim recTable As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, recTable.Left, recTable.Top, recTable.Width, recTable.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(dtgAllStaff.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, recTable, fmt)
                    Else
                        e.Graphics.DrawString(dtgAllStaff.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, recTable, fmt)
                    End If
                    x += recTable.Width
                    h = Math.Max(h, recTable.Height)
                Next
                If newpage Then
                    newpage = False
                Else
                    mRow += 1
                End If
                y += h
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With

        body.AppendLine("Report Generated By: " & reportGenerateUser)

        With e.Graphics
            .DrawString(strHeader, fntHeader, Brushes.Black, 100, 0)
            .DrawString(reportGenerateUser, fntNextSubHeader, Brushes.Black, 100, 50)
            .DrawString(reportGeneratedTimeDate, fntNextSubHeader, Brushes.Black, 100, 70)
            ' .DrawString(reportGeneratedTimeDate, fntBottom, Brushes.Black, 500, 500)
            '.DrawImage(My.Resources.background, 0, 0, 80, 100)
        End With
    End Sub

    Private Sub showInactiveUsersOnly()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        strSql = "Select StaffID,Name,IcNo,Address,DateOfBirth,PhoneNumber,StartDate,EndDate,Position,Status From Staff where Status = 'Inactive'"

        Try
            If cbDropDownList.SelectedItem = "Inactive" Then
                MySqlCommand = New SqlCommand(strSql, conn)

                Dim adapter As New SqlDataAdapter(MySqlCommand)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dtgAllStaff.DataSource = dataTable
                strFiredStaff = "Fired Staff"
                lblRecords.Text = "Number of records:" + dtgAllStaff.Rows.Count.ToString
                If dtgAllStaff.Rows.Count > 0 Then
                    For i As Integer = 0 To dtgAllStaff.Rows.Count - 1
                        Dim status As String = dtgAllStaff.Rows(i).Cells("Status").Value.ToString().Trim()
                        If status = "Inactive" Then
                            For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                                With dtgAllStaff.Rows(i).Cells(j).Style
                                    .BackColor = Color.Red
                                    .ForeColor = Color.White
                                End With
                            Next
                        Else
                            For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                                With dtgAllStaff.Rows(i).Cells(j).Style
                                    .BackColor = Color.White
                                    .ForeColor = Color.Black
                                End With
                            Next
                        End If

                    Next
                End If
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString())
        End Try

    End Sub

    Private Sub showActiveUsersOnly()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        strSql = "Select StaffID,Name,IcNo,Address,DateOfBirth,PhoneNumber,StartDate,EndDate,Position,Status From Staff where Status = 'Active'"

        If cbDropDownList.SelectedItem = "Active" Then
            MySqlCommand = New SqlCommand(strSql, conn)

            Dim adapter As New SqlDataAdapter(MySqlCommand)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            dtgAllStaff.DataSource = dataTable
            strCurrentStaff = "Current Employed Staff"
            lblRecords.Text = "Number of records:" + dtgAllStaff.Rows.Count.ToString

            Try
                If dtgAllStaff.Rows.Count > 0 Then
                    For i As Integer = 0 To dtgAllStaff.Rows.Count - 1
                        Dim status As String = dtgAllStaff.Rows(i).Cells("Status").Value.ToString().Trim()
                        If status = "Active" Then
                            For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                                With dtgAllStaff.Rows(i).Cells(j).Style
                                    .BackColor = Color.Green
                                    .ForeColor = Color.White
                                End With
                            Next
                        Else
                            For j As Integer = 0 To dtgAllStaff.Columns.Count - 1
                                With dtgAllStaff.Rows(i).Cells(j).Style
                                    .BackColor = Color.Red
                                    .ForeColor = Color.White
                                End With
                            Next
                        End If

                    Next
                End If
            Catch e As Exception
                MessageBox.Show(e.ToString())
            End Try
        End If

    End Sub



    Private Sub cbDropDownList_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cbDropDownList.SelectedIndex = 0 Then
            showActiveUsersOnly()
        ElseIf cbDropDownList.SelectedIndex = 1 Then
            showInactiveUsersOnly()
        Else
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        LoadFiredStaffBasedOnDate()
    End Sub

    Private Sub LoadFiredStaffBasedOnDate()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        strSql = "SELECT StaffID, Name, IcNo, Address, DateOfBirth, PhoneNumber, StartDate, EndDate, Position, Status FROM Staff WHERE Status = 'Inactive'AND EndDate Between @DateStart AND @DateEnd"
        'strSql = "SELECT * FROM NewestStaff WHERE Convert(datetime,[EndDate],110) BETWEEN Convert(datetime,@FromDate,103) AND Convert(datetime,@ToDate,103)"
        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@DateStart", dtpFrom.Value)
        MySqlCommand.Parameters.AddWithValue("@DateEnd", dtpTo.Value)
        Dim adapter As New SqlDataAdapter(MySqlCommand)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        dtgAllStaff.DataSource = dataTable
        strCurrentStaff = "Current Employed Staff"
        lblRecords.Text = "Number of records:" + dtgAllStaff.Rows.Count.ToString
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ChangeSecretQuestionAndAnswer.Show()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
    End Sub

End Class