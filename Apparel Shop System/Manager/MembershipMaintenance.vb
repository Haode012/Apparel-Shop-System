Imports System.Data.SqlClient

Public Class MembershipMaintenance
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With MemberRegister
            .TopLevel = False
            Me.Controls.Add(MemberRegister)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        PromotionMaintenance.Close()
        DailySalesReportViewer.Close()
    End Sub

    Private Sub MemberMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Me.MembershipTableAdapter.Fill(Me.ApparelShopSystemDataset.Membership)
        LoadData()
    End Sub

    Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        Dim memberID As Integer = CInt(dgvList.Rows(e.RowIndex).Cells(0).Value)
        Dim memberName As String = dgvList.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim memberIC As String = dgvList.Rows(e.RowIndex).Cells(2).Value.ToString()
        Dim memberPhoneNumber As String = dgvList.Rows(e.RowIndex).Cells(3).Value.ToString()
        Dim memberEmail As String = dgvList.Rows(e.RowIndex).Cells(4).Value.ToString()
        Dim memberRegistrationDate As String = dgvList.Rows(e.RowIndex).Cells(5).Value.ToString()
        Dim memberStatus As String = dgvList.Rows(e.RowIndex).Cells(6).Value.ToString()
        Dim memberAddress As String = dgvList.Rows(e.RowIndex).Cells(7).Value.ToString()
        Dim memberDetailsForm As New MemberSearchResult2(memberID, memberName, memberIC, memberPhoneNumber, memberEmail, memberRegistrationDate, memberStatus, memberAddress)
        With memberDetailsForm
            .TopLevel = False
            Me.Controls.Add(memberDetailsForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LoadData()
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            Dim da As New SqlDataAdapter("SELECT * FROM Membership", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvList.DataSource = dt
        End Using
    End Sub
    Public Sub RefreshData()
        LoadData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim searchValue As String = txtSearch.Text.Trim()

        If String.IsNullOrWhiteSpace(searchValue) Then
            DirectCast(dgvList.DataSource, DataTable).DefaultView.RowFilter = ""
            Return
        End If

        Dim filterExpression As String = $"memberName LIKE '%{searchValue}%'"
        DirectCast(dgvList.DataSource, DataTable).DefaultView.RowFilter = filterExpression

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim rowsToPrint As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvList.Rows
            If row.IsNewRow = False Then
                Dim regDate As Date = row.Cells("MemberRegistrationDateDataGridViewTextBoxColumn").Value
                If regDate.Month = DateTime.Now.Month And regDate.Year = DateTime.Now.Year Then
                    rowsToPrint.Add(row)
                End If
            End If
        Next

        'PrintPreviewDialog1.ShowDialog()


        'Dim docReport As New Printing.PrintDocument()
        'docReport.DefaultPageSettings.PaperSize = New Printing.PaperSize("A4", 827, 1169)


        'AddHandler docReport.PrintPage, Sub(sender2, e2)
        '                                    Dim colHeaderFont As New Font("Arial", 10, FontStyle.Bold)
        '                                    Dim colHeaderBrush As New SolidBrush(Color.Black)
        '                                    Dim colHeaderYPos As Single = 200
        '                                    Dim currentPageNumber As Integer = 1
        '                                    Dim totalPages As Integer = Math.Ceiling(rowsToPrint.Count / 30) ' Change 30 to the number of rows you want to print per page
        '                                    Dim currentMonth As Integer = DateTime.Now.Month
        '                                    Dim currentYear As Integer = DateTime.Now.Year

        '                                    ' Generate an array of column positions based on the number of columns in DGVMemberMainMemberList
        '                                    Dim colPositions(DGVMemberMainMemberList.Columns.Count - 1) As Single
        '                                    For i As Integer = 0 To DGVMemberMainMemberList.Columns.Count - 1
        '                                        Dim col As DataGridViewColumn = DGVMemberMainMemberList.Columns(i)
        '                                        colPositions(i) = If(i = 0, e2.MarginBounds.Left, colPositions(i - 1) + e2.Graphics.MeasureString(col.HeaderText, colHeaderFont).Width + 20)
        '                                    Next

        '                                    e2.Graphics.DrawString("Monthly Registration Report", New Font("Arial", 14), Brushes.Black, New PointF(100, 100))
        '                                    e2.Graphics.DrawString(DateTime.Now.ToString(), New Font("Arial", 10), Brushes.Black, New PointF(100, 150))
        '                                    e2.Graphics.DrawLine(Pens.Black, New Point(100, 200), New Point(700, 200))
        '                                    Dim pageNumberText As String = "Page " & currentPageNumber & " of " & totalPages
        '                                    e2.Graphics.DrawString(pageNumberText, New Font("Arial", 10), Brushes.Black, New PointF(600, 50))

        '                                    For i As Integer = 0 To DGVMemberMainMemberList.Columns.Count - 1
        '                                        Dim col As DataGridViewColumn = DGVMemberMainMemberList.Columns(i)
        '                                        Dim colHeaderText As String = col.HeaderText
        '                                        Dim colHeaderWidth As Single = e2.Graphics.MeasureString(colHeaderText, colHeaderFont).Width
        '                                        e2.Graphics.DrawString(colHeaderText, colHeaderFont, colHeaderBrush, colPositions(i), colHeaderYPos)
        '                                    Next

        '                                    Dim rowFont As New Font("Arial", 8)
        '                                    Dim rowBrush As New SolidBrush(Color.Black)
        '                                    Dim rowYPos As Single = colHeaderYPos + 100
        '                                    Dim cellWidth As Single = e2.MarginBounds.Width / DGVMemberMainMemberList.Columns.Count


        PrintPreviewDialog1.ShowDialog()
        Dim docReport As New Printing.PrintDocument()
        PrintPreviewDialog1.Document = docReport
        docReport.DefaultPageSettings.PaperSize = New Printing.PaperSize("A4", 1169, 827) ' swap width and height for landscape
        docReport.DefaultPageSettings.Landscape = True ' set landscape orientation
        AddHandler docReport.PrintPage, Sub(sender2, e2)
                                            Dim colHeaderFont As New Font("Arial", 10, FontStyle.Bold)
                                            Dim colHeaderBrush As New SolidBrush(Color.Black)
                                            Dim colHeaderXPos As Single = 80
                                            Dim colHeaderYPos As Single = 200
                                            Dim currentPageNumber As Integer = 1
                                            Dim totalPages As Integer = 10

                                            e2.Graphics.DrawString("Monthly Registration Report", New Font("Arial", 14), Brushes.Black, New PointF(100, 100))
                                            e2.Graphics.DrawString(DateTime.Now.ToString(), New Font("Arial", 10), Brushes.Black, New PointF(100, 150))
                                            e2.Graphics.DrawLine(Pens.Black, New Point(100, 200), New Point(1000, 200)) ' adjust the endpoint of the line
                                            Dim pageNumberText As String = "Page " & currentPageNumber & " of " & totalPages
                                            e2.Graphics.DrawString(pageNumberText, New Font("Arial", 10), Brushes.Black, New PointF(900, 50)) ' adjust the position of the page number

                                            For Each col As DataGridViewColumn In dgvList.Columns
                                                Dim colHeaderWidth As Single = e2.Graphics.MeasureString(col.HeaderText, colHeaderFont).Width
                                                e2.Graphics.DrawString(col.HeaderText, colHeaderFont, colHeaderBrush, colHeaderXPos, colHeaderYPos)
                                                colHeaderXPos += colHeaderWidth + 20
                                            Next

                                            Dim rowFont As New Font("Arial", 8)
                                            Dim rowBrush As New SolidBrush(Color.Black)
                                            Dim rowXPos As Single = e2.MarginBounds.Left
                                            Dim rowYPos As Single = colHeaderYPos + 100
                                            Dim cellWidth As Single = e2.Graphics.MeasureString(cellWidth.ToString(), rowFont).Width
                                            For Each row As DataGridViewRow In dgvList.Rows
                                                rowXPos = e2.MarginBounds.Left

                                                For Each cell As DataGridViewCell In row.Cells
                                                    If Not cell.Value Is Nothing Then
                                                        cellWidth = e2.Graphics.MeasureString(cell.Value.ToString(), rowFont).Width
                                                        e2.Graphics.DrawString(cell.Value.ToString(), rowFont, rowBrush, rowXPos, rowYPos)
                                                        rowXPos += cellWidth + 20
                                                    End If


                                                Next
                                                rowYPos += 30
                                            Next
                                            e2.HasMorePages = False


                                        End Sub
    End Sub
End Class