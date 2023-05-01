Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class DisplayProduct
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    Private Sub DisplayProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        display_all_record()

        Dim cmd As New SqlCommand("SELECT productID FROM Product", con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbProductID.Items.Add(reader("productID"))
        End While
        reader.Close()
    End Sub

    Public Sub display_all_record()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Product"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvProduct.DataSource = dt

        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvProduct.Columns
            col.Width = 200 ' Set the width of each column to 200
        Next

        Dim count As Integer = dt.Rows.Count
        Dim productID As String = ""
        For Each row As DataRow In dt.Rows
            productID += row("productId").ToString() & vbCrLf
        Next
        MessageBox.Show(count & " records found." & vbCrLf & vbCrLf & "Product ID:" & vbCrLf & productID, "Total Products Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        'Get the selected product ID
        Dim selectedProductId As String = cmbProductID.Text

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        If selectedProductId = "" Then
            'If the combo box is empty, display all data
            display_all_record()
        Else
            'Create a SQL command to select only the rows with the selected product ID
            Dim sql As String = "SELECT * FROM Product WHERE productID = @ProductID"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ProductID", selectedProductId)

            'Create a DataTable to hold the results of the SQL query
            Dim dt As New DataTable()

            'Use a SqlDataAdapter to fill the DataTable with the results of the SQL query
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            'Bind the DataTable to the DataGridView to display the results
            dgvProduct.DataSource = dt
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Product"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvProduct.DataSource = dt

        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        For Each col As DataGridViewColumn In dgvProduct.Columns
            col.Width = 200 ' Set the width of each column to 200
        Next

        cmbProductID.SelectedIndex = -1
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class