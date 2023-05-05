Imports System.Data.SqlClient
Imports System.IO


Public Class OrderCart
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private i As Integer

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        Try
            con.Open()

            If cmbMemberName.Text <> "" Then
            Else
                If cmbMemberName.Text = "" Then
                    btnPayAsMembership.Enabled = False

                End If
            End If

            Dim cmd As New SqlCommand("select memberName from Membership", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbMemberName.Items.Add(reader("memberName"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        display_all_record()

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductItem.Close()
        Membership.Close()
    End Sub

    Public Sub display_all_record()

        Dim dt As New DataTable()



        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()

            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from Cart"

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        dgvOrderCart.DataSource = dt

        dgvOrderCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvOrderCart.Columns
            col.Width = 145 ' Set the width of each column to 157
        Next

        cmbMemberName.SelectedIndex = -1

        'If cmbMemberName.Text <> "" Then
        'Else
        '    If cmbMemberName.Text = "" Then
        '        btnPayAsMembership.Enabled = False
        '    End If
        'End If


        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Cart", con)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                ' Enable the button
                btnNotMembership.Enabled = True
            Else
                ' Disable the button
                btnNotMembership.Enabled = False
                btnPayAsMembership.Enabled = False
            End If
        End Using

    End Sub





    Private Sub picRefresh_Click(sender As Object, e As EventArgs) Handles picRefresh.Click
        display_all_record()
    End Sub





    Private Sub cmbMemberName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMemberName.SelectedIndexChanged



        Dim selectedMemberName As String = cmbMemberName.Text

        If selectedMemberName = "" Then
            lblMemberId.Text = ""
            btnPayAsMembership.Enabled = False
        Else
            Try
                Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
                    con.Open()
                    ' Execute SQL commands here




                    Dim sql As String = "SELECT * FROM Membership WHERE memberName = @MemberName"
                    Dim cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@MemberName", selectedMemberName)
                    'Execute the SQL command and read the result
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        'Set the lblMemberId.Text with the memberName from the selected row
                        lblMemberId.Text = reader("memberId").ToString()
                    Else
                        'If no row is returned, clear the lblMemberName.Text
                        lblMemberId.Text = ""
                    End If
                    reader.Close()
                    con.Close()
                End Using
            Catch ex As Exception

            End Try
        End If



        If cmbMemberName.Text = "" Then
        Else
            If cmbMemberName.Text <> "" Then
                btnPayAsMembership.Enabled = True

            End If
        End If

    End Sub



    Private Sub btnNotMembership_Click(sender As Object, e As EventArgs) Handles btnNotMembership.Click


        With Payment
            .TopLevel = False
            Me.Controls.Add(Payment)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnPayAsMembership_Click(sender As Object, e As EventArgs) Handles btnPayAsMembership.Click

        Dim payment As New Payment()
        btnPayAsMembership.Tag = payment

        Dim args As Payment = DirectCast(sender.Tag, Payment)
        Dim membershipID As String = lblMemberId.Text
        Dim membershipName As String = cmbMemberName.Text

        'Dim cmbValue As String = cmbMemberName.Text.ToString

        If cmbMemberName.Text = "" Then
        Else
            If cmbMemberName.Text <> "" Then
                btnPayAsMembership.Enabled = True

            End If
        End If

        args.ShowMembershipDetails(membershipID, membershipName)

        With payment
            .TopLevel = False
            Me.Controls.Add(payment)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        display_all_record()
    End Sub
    Private Sub dgvOrderCart_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOrderCart.CellMouseClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If



            con.Open()

            Dim selectedRowIndex As Integer = e.RowIndex

            ' Dim cartId As Integer = dgvOrderCart.Rows(selectedRowIndex).Cells("cartId").Value
            Dim productId As Integer = dgvOrderCart.Rows(selectedRowIndex).Cells("productId").Value
            Dim productQuantity As Integer = dgvOrderCart.Rows(selectedRowIndex).Cells("productQuantity").Value
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this Cart Item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)








            If result = DialogResult.OK Then
                i = Convert.ToInt32(dgvOrderCart.SelectedCells.Item(0).Value.ToString())

                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from Cart where cartId=" & i & ""
                cmd.ExecuteNonQuery()

                MessageBox.Show("Cart Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                display_all_record()
            End If


            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
                con.Open()

                Dim selectCmd As New SqlCommand("SELECT productId, productStock FROM Product WHERE productId = @productId", con)


                selectCmd.Parameters.AddWithValue("@productId", productId)

                Dim reader As SqlDataReader = selectCmd.ExecuteReader()
                If reader.Read() Then

                    Dim currentStock As String = reader("productStock")

                    lblStock.Text = currentStock.ToString()
                    con.Close()
                End If
            End Using

            Update(productId, productQuantity)



        Catch ex As Exception
            MessageBox.Show("Cart is empty..", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try



    End Sub
    Private Sub Update(productId As Integer, productQuantity As Integer)

        Dim updateCmd As String = "UPDATE Product SET productStock = @productStock WHERE productId = @productId"
        Using cmd As New SqlCommand(updateCmd, con)
            'con.Open()
            cmd.Parameters.AddWithValue("@productStock", (Integer.Parse(lblStock.Text.ToString) + productQuantity).ToString)
            cmd.Parameters.AddWithValue("@productId", productId)
            cmd.ExecuteNonQuery()
        End Using

    End Sub

    Private Sub picCancel_Click(sender As Object, e As EventArgs) Handles picCancel.Click
        display_all_record()
    End Sub
End Class