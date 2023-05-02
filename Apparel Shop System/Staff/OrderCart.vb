Imports System.Data.SqlClient
Imports System.IO


Public Class OrderCart
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private i As Integer
    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        Dim cmd As New SqlCommand("select memberId from Membership", con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbMemberID.Items.Add(reader("memberId"))
        End While
        reader.Close()

        display_all_record()

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductItem.Close()
        Membership.Close()
    End Sub

    Public Sub display_all_record()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Cart"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvOrderCart.DataSource = dt

        dgvOrderCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvOrderCart.Columns
            col.Width = 157 ' Set the width of each column to 157
        Next

        cmbMemberID.SelectedIndex = -1

    End Sub

    Private Sub picRefresh_Click(sender As Object, e As EventArgs) Handles picRefresh.Click
        display_all_record()
    End Sub

    Private Sub dgvOrderCart_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderCart.CellDoubleClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()



            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this Cart Item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If result = DialogResult.OK Then
                i = Convert.ToInt32(dgvOrderCart.SelectedCells.Item(0).Value.ToString())

                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from Cart where cartId=" & i & ""
                cmd.ExecuteNonQuery()

                MessageBox.Show("Cart Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub



    Private Sub cmbMemberID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMemberID.SelectedIndexChanged




        'Get the selected cart ID
        Dim selectedMemberId As String = cmbMemberID.Text

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        If selectedMemberId = "" Then
            lblMemberName.Text = ""
        Else
            'Create a SQL command to select only the rows with the selected product ID
            Dim sql As String = "SELECT * FROM Membership WHERE memberId = @MemberID"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@MemberID", selectedMemberId)
            'Execute the SQL command and read the result
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                'Set the lblMemberName.Text with the memberName from the selected row
                lblMemberName.Text = reader("memberName").ToString()
            Else
                'If no row is returned, clear the lblMemberName.Text
                lblMemberName.Text = ""
            End If
            reader.Close()

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
        Dim membershipID As String = cmbMemberID.Text
        Dim membershipName As String = lblMemberName.Text
        args.ShowMembershipDetails(membershipID, membershipName)
        With payment
            .TopLevel = False
            Me.Controls.Add(payment)
            .BringToFront()
            .Show()
        End With

    End Sub

End Class