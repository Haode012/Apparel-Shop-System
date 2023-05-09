Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Public Class PromotionMaintenance

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        cboPromotionStatus.SelectedItem = "All"
        con.Open()
        BindData()

    End Sub

    Private Sub BindData()

        cmd = con.CreateCommand
        Dim strName As String = txtSearchBox.Text
        Dim strStatus As String = cboPromotionStatus.Text

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text

        If strStatus = "All" Then
            cmd.CommandText = "SELECT * FROM Promotion WHERE promotionName LIKE @name"
        Else
            cmd.CommandText = "SELECT * FROM Promotion WHERE promotionName LIKE @name AND promotionStatus = @status"
            cmd.Parameters.AddWithValue("@status", strStatus)
        End If

        cmd.Parameters.AddWithValue("@name", "%" & strName & "%")

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvPromotionList.DataSource = dt
        dgvPromotionList.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        dgvPromotionList.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15)

        dgvPromotionList.Columns("promotionName").HeaderText = "Promotion Name"
        dgvPromotionList.Columns("promotionDescription").HeaderText = "Description"
        dgvPromotionList.Columns("promotionDiscount").HeaderText = "Discount (%)"
        dgvPromotionList.Columns("promotionStart").HeaderText = "Date Start"
        dgvPromotionList.Columns("promotionEnd").HeaderText = "Date End"
        dgvPromotionList.Columns("promotionStatus").HeaderText = "Status"


        dgvPromotionList.Columns("promotionId").Visible = False
        dgvPromotionList.Columns("createBy").Visible = False
        dgvPromotionList.Columns("modifiedBy").Visible = False
        dgvPromotionList.Columns("creationDay").Visible = False
        dgvPromotionList.Columns("modifiedDay").Visible = False

        lblCountRecord.Text = String.Format("{0} record(s) found", dgvPromotionList.Rows.Count)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If strPosition = "Manager" Then
            With Promotion_Add
                .TopLevel = False
                Me.Controls.Add(Promotion_Add)
                .BringToFront()
                .Show()
            End With
            BindData()
        Else
            MessageBox.Show("Only manager is allowed to create promotion", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub dgvPromotionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromotionList.CellDoubleClick

        Dim intNo As Integer = e.RowIndex

        If intNo > -1 Then
            Dim strid As String = CStr(dgvPromotionList.Rows(intNo).Cells(0).Value)
            Promotion_Details.strSelectedId = strid
            With Promotion_Details
                .TopLevel = False
                Me.Controls.Add(Promotion_Details)
                .BringToFront()
                .Show()
            End With
            BindData()
        End If
    End Sub

    Private Sub docsPromotion_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docsPromotion.PrintPage

        ' (1) Fonts
        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12)
        Dim fntBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header
        Dim strHeader As String = "Promotion Report"
        Dim strSubHeader As String = String.Format(
        "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now
    )

        ' (3) Prepare body
        Dim body As New StringBuilder()
        Dim totalApply As Integer = 0

        ' (4) Query data from database
        Using cmd As New SqlCommand("SELECT * FROM Promotion", con)
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            ' (5) Generate table
            Dim tbl As New DataTable()
            tbl.Columns.Add("Promotion ID", GetType(Integer))
            tbl.Columns.Add("Promotion Name", GetType(String))
            tbl.Columns.Add("Discount", GetType(String))
            tbl.Columns.Add("Start Date", GetType(DateTime))
            tbl.Columns.Add("End Date", GetType(DateTime))
            tbl.Columns.Add("Status", GetType(String))
            tbl.Columns.Add("Total Apply", GetType(Integer))

            For Each row As DataRow In dt.Rows
                Dim promoId As Integer = row.Field(Of Integer)("promotionId")
                Dim promoName As String = row.Field(Of String)("promotionName")
                Dim promoDiscount As String = row.Field(Of String)("promotionDiscount")
                Dim startDate As DateTime = row.Field(Of DateTime)("promotionStart")
                Dim endDate As DateTime = row.Field(Of DateTime)("promotionEnd")
                Dim status As String = row.Field(Of String)("promotionStatus")

                ' Count total apply from PromotionProduct table
                Using cmd2 As New SqlCommand("SELECT COUNT(*) FROM PromotionProduct WHERE promotionId = @promoId", con)
                    cmd2.Parameters.AddWithValue("@promoId", promoId)
                    totalApply = cmd2.ExecuteScalar()
                End Using

                ' Add data to table
                tbl.Rows.Add(promoId, promoName, promoDiscount, startDate, endDate, status, totalApply)
            Next

            ' (6) Format table and append to body
            Dim rowHeight As Integer = 35
            Dim colWidths() As Integer = {80, 200, 80, 100, 100, 80, 80}
            Dim totalWidth As Integer = colWidths.Sum()
            Dim xPos As Integer = e.MarginBounds.Left
            Dim yPos As Integer = e.MarginBounds.Top + 100
            Dim rowPos As Integer = yPos
            Dim colPos As Integer = xPos

            For Each col As DataColumn In tbl.Columns
                Dim headerRect As New Rectangle(colPos, rowPos, colWidths(col.Ordinal), rowHeight)
                e.Graphics.FillRectangle(Brushes.LightGray, headerRect)
                e.Graphics.DrawRectangle(Pens.Black, headerRect)
                e.Graphics.DrawString(col.ColumnName, fntBody, Brushes.Black, headerRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                colPos += colWidths(col.Ordinal)
            Next

            rowPos += rowHeight

            For Each row As DataRow In tbl.Rows
                colPos = xPos

                For Each col As DataColumn In tbl.Columns
                    Dim cellRect As New Rectangle(colPos, rowPos, colWidths(col.Ordinal), rowHeight)
                    e.Graphics.DrawRectangle(Pens.Black, cellRect)

                    If TypeOf row(col.ColumnName) Is DateTime Then
                        e.Graphics.DrawString(Convert.ToDateTime(row(col.ColumnName)).ToString("dd/MM/yyyy"), fntBody, Brushes.Black, cellRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    Else
                        e.Graphics.DrawString(row(col.ColumnName).ToString(), fntBody, Brushes.Black, cellRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    End If
                    colPos += colWidths(col.Ordinal)
                Next

                rowPos += rowHeight
            Next

            ' (7) Append table to body
            body.AppendLine()
            body.AppendLine()

            For Each row As DataRow In tbl.Rows
                For Each col As DataColumn In tbl.Columns
                    body.Append(row(col.ColumnName))
                    body.Append(vbTab)
                Next

                body.AppendLine()
            Next
        End Using


        ' (8) Print report
        e.Graphics.DrawString(strHeader, fntHeader, Brushes.Black, New PointF(e.MarginBounds.Left, e.MarginBounds.Top))
        e.Graphics.DrawString(strSubHeader, fntSubHeader, Brushes.Black, New PointF(e.MarginBounds.Left, e.MarginBounds.Top + 50))

    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        dlgPreview.Document = docsPromotion
        dlgPreview.ShowDialog(Me)

    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        BindData()

    End Sub

    Private Sub cboPromotionStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPromotionStatus.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        txtSearchBox.Text = ""
        cboPromotionStatus.SelectedItem = "All"
        BindData()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        MembershipMaintenance.Close()
        DailySalesReportViewer.Close()
    End Sub
End Class