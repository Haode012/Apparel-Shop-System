Imports System.Data.SqlClient

Public Class Promotion_Details

    Public strSelectedId As String
    Public strDiscount As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Promotion_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BindData()
        DisplayAllProduct()
        BindPromotionProducts()

        cboProductCategory.SelectedItem = "All"

    End Sub

    Public Sub BindData()

        con.Close()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        con = New SqlConnection(connectionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Promotion WHERE promotionId = @promotionId"
        cmd.Parameters.AddWithValue("@promotionId", strSelectedId)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            ' Fill data into textboxes
            lblShowPromotionName.Text = reader("promotionName").ToString()
            lblPromotionName.Text = reader("promotionName").ToString()
            lblPromotionDescription.Text = reader("promotionDescription").ToString()
            lblStartDate.Text = Convert.ToDateTime(reader("promotionStart"))
            lblEndDate.Text = Convert.ToDateTime(reader("promotionEnd"))
            lblCreateBy.Text = reader("createBy").ToString()

            If Not IsDBNull(reader("modifiedBy")) Then
                lblModifiedBy.Text = reader("modifiedBy").ToString()
            Else
                lblModifiedBy.Text = "-"
            End If

            lblCreationDate.Text = Convert.ToDateTime(reader("creationDay"))
            Dim modifiedDay As Object = reader("modifiedDay")
            If Not IsDBNull(modifiedDay) Then
                lblModifiedDate.Text = Convert.ToDateTime(modifiedDay)
            Else
                lblModifiedDate.Text = "-"
            End If

            lblDiscount.Text = reader("promotionDiscount").ToString()
            strDiscount = reader("promotionDiscount").ToString()
            lblStatus.Text = reader("promotionStatus").ToString()

        End If

        reader.Close()

    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        con.Close()
    End Sub


    Private Sub btnEditPromo_Click(sender As Object, e As EventArgs) Handles btnEditPromo.Click
        If strPosition = "Manager" Then
            Promotion_Edit.strSelectedId = strSelectedId
            With Promotion_Edit
                .TopLevel = False
                Me.Controls.Add(Promotion_Edit)
                .BringToFront()
                .Show()
            End With
            BindData()
        Else
            MessageBox.Show("Only manager is allowed to add new staff", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEndPromotionNow_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to end this promotion now?", "End Promotion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Promotion SET promotionStatus = 'End' WHERE promotionId = @promotionId"
            cmd.Parameters.AddWithValue("@promotionId", strSelectedId)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Promotion ended successfully.", "Promotion Ended", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        BindData()

    End Sub

    Public Sub DisplayAllProduct()

        Dim strName As String = txtSearchBox.Text
        Dim strCategory As String = cboProductCategory.Text

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text

        If strCategory = "All" Then
            cmd.CommandText = "SELECT * FROM Product WHERE productName LIKE @name"
        Else
            cmd.CommandText = "SELECT * FROM Product WHERE productName LIKE @name AND productCategory = @category"
            cmd.Parameters.AddWithValue("@category", strCategory)
        End If

        cmd.Parameters.AddWithValue("@name", "%" & strName & "%")

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvProductList.DataSource = dt

        dgvProductList.Columns("productName").HeaderText = "Product Name"
        dgvProductList.Columns("productId").HeaderText = "Product Id"

        dgvProductList.Columns("productGender").Visible = False
        dgvProductList.Columns("productCategory").Visible = False
        dgvProductList.Columns("productSize").Visible = False
        dgvProductList.Columns("productDescription").Visible = False
        dgvProductList.Columns("productPrice").Visible = False
        dgvProductList.Columns("productStock").Visible = False
        dgvProductList.Columns("productImage").Visible = False
        dgvProductList.Columns("dateCreated").Visible = False
        dgvProductList.Columns("promotionDiscount").Visible = False
        dgvProductList.Columns("promotionId").Visible = False

        lblCountProducts.Text = String.Format("{0} record(s) found", dgvProductList.Rows.Count)

    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        DisplayAllProduct()
    End Sub

    Private Sub cboProductCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductCategory.SelectedIndexChanged
        DisplayAllProduct()
    End Sub

    Private Sub dgvProductList_DoubleClick(sender As Object, e As EventArgs) Handles dgvProductList.DoubleClick, btnAdd.Click
        'get selected Product ID
        Dim selectedProductId As Integer = dgvProductList.SelectedRows(0).Cells("productId").Value
        Dim selectedProductName As String = dgvProductList.SelectedRows(0).Cells("productName").Value

        'get selected Promotion ID
        Dim selectedPromotionId As Integer = strSelectedId

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT COUNT(*) FROM PromotionProduct WHERE productId = @productId AND promotionId <> @promotionId"
        cmd.Parameters.AddWithValue("@productId", selectedProductId)
        cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
        Dim count As Integer = CInt(cmd.ExecuteScalar())

        If count > 0 Then
            'record exist
            Dim result As DialogResult = MessageBox.Show("The selected product is already applied to another promotion. Do you want to overwrite the existing record?", "Record Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                'delete exist record
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM PromotionProduct WHERE productId = @productId AND promotionId <> @promotionId"
                cmd.Parameters.AddWithValue("@productId", selectedProductId)
                cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
                cmd.ExecuteNonQuery()

                'insert new record
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO PromotionProduct (promotionId, productId, productName) VALUES (@promotionId, @productId, @productName)"
                cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
                cmd.Parameters.AddWithValue("@productId", selectedProductId)
                cmd.Parameters.AddWithValue("@productName", selectedProductName)
                cmd.ExecuteNonQuery()

                'update Product table
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Product SET promotionId = @promotionId, promotionDiscount = @promotionDiscount WHERE productId = @productId"
                cmd.Parameters.AddWithValue("@productId", selectedProductId)
                cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
                cmd.Parameters.AddWithValue("@promotionDiscount", strDiscount)
                cmd.ExecuteNonQuery()

                BindPromotionProducts()
            End If
        Else
            'check is duplicate?
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) FROM PromotionProduct WHERE promotionId = @promotionId AND productId = @productId"
            cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
            cmd.Parameters.AddWithValue("@productId", selectedProductId)
            Dim count1 As Integer = CInt(cmd.ExecuteScalar())

            If count1 > 0 Then
                'is duplicated
                Dim result As DialogResult = MessageBox.Show("The selected product already exists in the promotion.", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'not duplicated, save record
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO PromotionProduct (promotionId, productId, productName) VALUES (@promotionId, @productId, @productName)"
                cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
                cmd.Parameters.AddWithValue("@productId", selectedProductId)
                cmd.Parameters.AddWithValue("@productName", selectedProductName)
                cmd.ExecuteNonQuery()

                'update Product table
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Product SET promotionId = @promotionId, promotionDiscount = @promotionDiscount WHERE productId = @productId"
                cmd.Parameters.AddWithValue("@productId", selectedProductId)
                cmd.Parameters.AddWithValue("@promotionId", selectedPromotionId)
                cmd.Parameters.AddWithValue("@promotionDiscount", strDiscount)
                cmd.ExecuteNonQuery()

                BindPromotionProducts()
            End If
        End If
    End Sub

    Private Sub BindPromotionProducts()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("SELECT * FROM PromotionProduct WHERE promotionId = " & strSelectedId, con)
        da.Fill(dt)
        dgvApplyPromotionList.DataSource = dt

        dgvApplyPromotionList.Columns("productName").HeaderText = "Product Name"
        dgvApplyPromotionList.Columns("productId").HeaderText = "Product Id"

        dgvApplyPromotionList.Columns("promotionProductId").Visible = False
        dgvApplyPromotionList.Columns("promotionId").Visible = False

        lblCountApply.Text = String.Format("{0} record(s) found", dgvApplyPromotionList.Rows.Count)

    End Sub

    Private Sub dgvApplyPromotionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApplyPromotionList.CellDoubleClick
        Dim selectedRowIndex As Integer = e.RowIndex
        If selectedRowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvApplyPromotionList.Rows(selectedRowIndex)
            Dim promotionProductId As Integer = CInt(row.Cells("promotionProductId").Value)

            'get productId
            Dim productId As Integer = -1
            Dim cmdGetProductId As New SqlCommand("SELECT productId FROM PromotionProduct WHERE promotionProductId = " & promotionProductId, con)
            Dim reader As SqlDataReader = cmdGetProductId.ExecuteReader()
            If reader.Read() Then
                productId = CInt(reader("productId"))
            End If
            reader.Close()

            'delete promotion product
            Dim cmdDeletePromotionProduct As New SqlCommand("DELETE FROM PromotionProduct WHERE promotionProductId = " & promotionProductId, con)
            cmdDeletePromotionProduct.ExecuteNonQuery()

            'Update product 
            If productId >= 0 Then
                Dim cmdUpdateProduct As New SqlCommand("UPDATE Product SET promotionId = NULL, promotionDiscount = NULL WHERE productId = " & productId, con)
                cmdUpdateProduct.ExecuteNonQuery()
            End If

            BindPromotionProducts()
        End If

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        ProductMaintenance.Close()
        StaffMaintenance.Close()
        MembershipMaintenance.Close()
        PromotionMaintenance.Close()
        DailySalesReportViewer.Close()
        con.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
        con.Close()
    End Sub

End Class