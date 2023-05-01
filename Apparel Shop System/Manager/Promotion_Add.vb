Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Promotion_Add

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Promotion_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


    'Private Sub txtTitle_Validating(sender As Object, e As CancelEventArgs) Handles txtPromotionName.Validating

    '    Dim strtitle As String = txtPromotionName.Text

    '    If strtitle = "" Then
    '        Err.SetError(txtPromotionName, "Title cannot be empty")
    '        e.Cancel = True
    '    Else
    '        Err.SetError(txtPromotionName, Nothing)
    '    End If

    'End Sub

    'Private Sub txtDesc_Validating(sender As Object, e As CancelEventArgs) Handles txtDesc.Validating

    '    Dim strDecs As String = txtDesc.Text

    '    If strDecs = "" Then
    '        Err.SetError(txtDesc, "Title cannot be empty")
    '        e.Cancel = True
    '    Else
    '        Err.SetError(txtDesc, Nothing)
    '    End If
    'End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Me.Close()

    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dtpEnding_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnding.ValueChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub dtpStarting_ValueChanged(sender As Object, e As EventArgs) Handles dtpStarting.ValueChanged

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