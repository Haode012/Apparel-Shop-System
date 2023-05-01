Imports System.Data.SqlClient

Public Class ProductReportViewer

    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
    Private cmd As New SqlCommand
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

    Private Sub ProductReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        sql = "select * from Product"

        Try
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Product")
            Dim report As New ProductCrystalReport
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        con.Close()
    End Sub

End Class