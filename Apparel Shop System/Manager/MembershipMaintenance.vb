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
    End Sub

    Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        Dim memberID As Integer = CInt(dgvList.Rows(e.RowIndex).Cells(0).Value)
        Dim memberName As String = dgvList.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim memberIC As String = dgvList.Rows(e.RowIndex).Cells(2).Value.ToString()
        Dim memberPhoneNumber As String = dgvList.Rows(e.RowIndex).Cells(3).Value.ToString()
        Dim memberEmail As String = dgvList.Rows(e.RowIndex).Cells(4).Value.ToString()
        Dim memberRegistrationDate As String = dgvList.Rows(e.RowIndex).Cells(5).Value.ToString()
        Dim memberStatus As String = dgvList.Rows(e.RowIndex).Cells(6).Value.ToString()

        Dim memberDetailsForm As New MemberSearchResult(memberID, memberName, memberIC, memberPhoneNumber, memberEmail, memberRegistrationDate, memberStatus)
        With memberDetailsForm
            .TopLevel = False
            Me.Controls.Add(memberDetailsForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LoadData()
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
            ' create a new SqlDataAdapter for selecting data from the database
            Dim da As New SqlDataAdapter("SELECT * FROM Membership", con)

            ' create a new DataTable
            Dim dt As New DataTable()

            ' fill the DataTable with the data from the database
            da.Fill(dt)

            ' bind the DataTable to the DataGridView
            dgvList.DataSource = dt
        End Using
    End Sub
    Public Sub RefreshData()
        LoadData()
    End Sub

    Private Sub MembershipMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApparelShopSystemDataset.Membership' table. You can move, or remove it, as needed.
        Me.MembershipTableAdapter.Fill(Me.ApparelShopSystemDataset.Membership)

    End Sub
End Class