Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class OrderHistory

    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private status As String
    Private Sub dtgAllOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAllOrder.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        UpdateOrderStatus.strSelectedOrderId = CStr(dtgAllOrder.Rows(intNo).Cells(0).Value)
        With UpdateOrderStatus
            .TopLevel = False
            Me.Controls.Add(UpdateOrderStatus)
            .BringToFront()
            .Show()
        End With
        Load()
        refresh()
    End Sub



    Private Shadows Sub Load()

        Dim dt As New DataTable()
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()

            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select orderId, productId,productName,receiptId,memberId,unitPrice,quantity,promotion,amount,orderDate,paymentMethod,status From OrderHistory"

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                dtgAllOrder.DataSource = dt
                lblTotalCount.Text = "Number of orders:" + dtgAllOrder.Rows.Count.ToString
                'End If
            End Using
            con.Close()
        End Using
        refresh()
    End Sub

    Private Sub btnDisplayOrder_Click(sender As Object, e As EventArgs) Handles btnDisplayOrder.Click
        SearchOrder()
    End Sub





    Private Sub SearchOrder()
        Dim dt As New DataTable()
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()

            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select orderId,productId,productName,receiptId,memberId,unitPrice,quantity,promotion,amount,orderDate,paymentMethod,status From OrderHistory where productName like '%" + txtSearchOrder.Text + "%' AND status = @Status "
                cmd.Parameters.AddWithValue("@Status", lblStatus.Text.ToString)

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                dtgAllOrder.DataSource = dt
            End Using
            CloseConnection()



        End Using

    End Sub

    Private Sub refresh()
        Try
            If dtgAllOrder.Rows.Count > 0 Then
                For i As Integer = 0 To dtgAllOrder.Rows.Count - 1
                    Dim status As String = dtgAllOrder.Rows(i).Cells("Status").Value.ToString().Trim()
                    If status = "Sold" Then
                        For j As Integer = 0 To dtgAllOrder.Columns.Count - 1
                            With dtgAllOrder.Rows(i).Cells(j).Style
                                .BackColor = Color.Green
                                .ForeColor = Color.White
                            End With
                        Next
                    Else
                        For j As Integer = 0 To dtgAllOrder.Columns.Count - 1
                            With dtgAllOrder.Rows(i).Cells(j).Style
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
    End Sub


    Private Sub ManageOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Load()


        cmbStatus.Items.Add("Cancelled")
        cmbStatus.Items.Add("Sold")

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SearchOrder()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductItem.Close()
        OrderCart.Close()
        Membership.Close()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        Dim selectedStatus = cmbStatus.Text


        If selectedStatus = "Sold" Then
            lblStatus.Text = "Sold"
        Else
            lblStatus.Text = "Cancelled"
        End If


    End Sub


End Class