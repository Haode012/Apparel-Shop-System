Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class PaymentReceipt
    Public Property PaymentId As String
        Get
            Return lblPaymentId.Text
        End Get
        Set(value As String)
            lblPaymentId.Text = value
        End Set
    End Property

    Public Sub ShowPaymentReceipt(PaymentId As String)
        'Display the product details in the UI

        lblPaymentId.Text = PaymentId
    End Sub


    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\USERS\HP\SOURCE\REPOS\HAODE012\APPAREL-SHOP-SYSTEM\APPAREL SHOP SYSTEM\APPARELSHOPSYSTEMDATABASE.MDF"";Integrated Security=True")
    Private cmd As New SqlCommand
    Private Sub PaymentReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim receiptDate As String = String.Format(
"{0:dd-MMMM-yyyy}", DateTime.Now
)
        lblDate.Text = receiptDate
        lblTotalAmount1.Text = totalAmount.ToString

        If strMemberId.ToString = "" Then
            lblDiscount.Text = "-"
            lblMemberId.Text = "-"
            lblMemberName.Text = "-"
        Else
            lblDiscount.Text = "20"
            lblMemberId.Text = strMemberId.ToString
            lblMemberName.Text = strMemberName.ToString

        End If




        display_all_record(PaymentId)



    End Sub


    Public Sub display_all_record(paymentId As String)

        con.Open()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select productId,productName,unitPrice,quantity,promotion,amount from OrderHistory where receiptId = @ReceiptId"




        cmd.Parameters.AddWithValue("@ReceiptId", paymentId)


        cmd.ExecuteNonQuery()




        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvReceipt.DataSource = dt

        dgvReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvReceipt.Columns
            col.Width = 160 ' Set the width of each column to 157
        Next

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Membership.Close()
        ProductItem.Close()
        OrderCart.Close()
        Payment.Close()
        OrderHistory.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Create a new PrintDocument object
        Dim printDoc As New PrintDocument()

        ' Add an event handler for the PrintPage event
        AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage
        PrintPreviewDialog1.Document = PrintDocument1

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        ' Show the PrintDialog and get the user's selected printer and print settings
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the printer and print settings for the PrintDocument object
            printDoc.PrinterSettings = PrintDialog1.PrinterSettings
            printDoc.DefaultPageSettings.Landscape = True

            ' Start the printing process
            printDoc.Print()
        End If

        Me.Close()
        ProductItem.Close()
        Payment.Close()
        OrderCart.Close()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dgv As DataGridView = dgvReceipt
        Dim printFont As New Font("Arial", 10)
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim rightMargin As Single = e.MarginBounds.Right
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin
        Dim cellBounds As RectangleF
        Dim row As DataGridViewRow
        Dim cell As DataGridViewCell

        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12)
        Dim fntBody As New Font("Consolas", 10)
        ' (2) Prepare header and sub-header
        Dim strHeader As String = "RECEIPT"
        Dim strSubHeader As String = String.Format(
"Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim strSubHeader2 As String = "RECEIPT#" + lblPaymentId.Text.ToString
        Dim strSubHeader3 As String = "CONTACT US : 011-1234 5678"
        Dim strSubHeader4 As String = "ADDRESS :Jalan Genting Kelang, Setapak,
53300 Kuala Lumpur."
        Dim strSubHeader5 As String = "MEMBER ID :" + strMemberId.ToString
        Dim strSubHeader6 As String = "MEMBER NAME :" + strMemberName.ToString

        Dim strTotalAmount As String = "Total amount(RM) = " + totalAmount
        Dim strDiscount As String = "Discount(%) = " + lblDiscount.Text.ToString


        ' (3) Print header and sub-header

        'Dim headerPicture As New RectangleF(rightMargin, yPos, 500, 100)
        'e.Graphics.DrawImage(My.Resources.apperal_shop, headerPicture)
        'yPos += fntHeader.Height + 10 ' add spacing between headerPicture and header

        e.Graphics.DrawImage(My.Resources.apperal_shop, 20, 0, 80, 100)


        Dim headerBounds As New RectangleF(leftMargin, yPos, 500, fntHeader.Height)
        e.Graphics.DrawString(strHeader, fntHeader, Brushes.Purple, headerBounds)

        yPos += fntHeader.Height + 10 ' add spacing between header and subheader

        Dim subHeaderBounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader, fntSubHeader, Brushes.Black, subHeaderBounds)
        yPos += fntSubHeader.Height ' adjust yPos to next row of subheader

        Dim subHeader2Bounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader2, fntSubHeader, Brushes.Black, subHeader2Bounds)
        yPos += fntSubHeader.Height + 10 ' add spacing between subheader and table

        Dim subHeader3Bounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader3, fntSubHeader, Brushes.Black, subHeader3Bounds)
        yPos += fntSubHeader.Height + 20 ' add spacing between subheader and table

        Dim subHeader4Bounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader4, fntSubHeader, Brushes.Black, subHeader4Bounds)
        yPos += fntSubHeader.Height + 20 ' add spacing between subheader and table

        Dim subHeader5Bounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader5, fntSubHeader, Brushes.Black, subHeader5Bounds)
        yPos += fntSubHeader.Height + 20 ' add spacing between subheader and table

        Dim subHeader6Bounds As New RectangleF(leftMargin, yPos, 500, fntSubHeader.Height)
        e.Graphics.DrawString(strSubHeader6, fntSubHeader, Brushes.Black, subHeader6Bounds)
        yPos += fntSubHeader.Height + 20 ' add spacing between subheader and table



        ' Set the pen for the border color and thickness
        Dim pen As New Pen(Color.Black, 1)

        ' Draw the column headers
        For Each column As DataGridViewColumn In dgv.Columns
            cellBounds = New RectangleF(leftMargin, yPos, column.Width, printFont.Height)
            e.Graphics.DrawString(column.HeaderText, printFont, Brushes.Black, cellBounds)
            ' Draw the top border
            e.Graphics.DrawLine(pen, leftMargin, yPos + printFont.Height, leftMargin + column.Width, yPos + printFont.Height)
            leftMargin += column.Width
        Next

        ' Draw the rows of data
        For i As Integer = 0 To dgv.Rows.Count - 1
            row = dgv.Rows(i)
            leftMargin = e.MarginBounds.Left
            yPos += printFont.Height

            For Each cell In row.Cells
                cellBounds = New RectangleF(leftMargin, yPos, cell.OwningColumn.Width, printFont.Height)
                If (cell.Value <> Nothing) Then
                    e.Graphics.DrawString(cell.Value.ToString(), printFont, Brushes.Black, cellBounds)
                    ' Draw the left, right, and bottom borders
                    e.Graphics.DrawRectangle(pen, leftMargin, yPos, cell.OwningColumn.Width, printFont.Height)
                End If
                leftMargin += cell.OwningColumn.Width

            Next
            ' Draw the top border for each row
            e.Graphics.DrawLine(pen, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos)
        Next
        yPos += printFont.Height + 20

        Dim totalAmountLeft As Single = e.MarginBounds.Left + 670

        Dim totalAmountBounds2 As New RectangleF(totalAmountLeft, yPos, e.MarginBounds.Right - totalAmountLeft, printFont.Height)
        e.Graphics.DrawString(strDiscount, printFont, Brushes.Black, totalAmountBounds2)
        yPos += printFont.Height + 20

        Dim totalAmountBounds3 As New RectangleF(totalAmountLeft, yPos, e.MarginBounds.Right - totalAmountLeft, printFont.Height)
        e.Graphics.DrawString(strTotalAmount, printFont, Brushes.Black, totalAmountBounds3)




    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub


End Class