Imports System.Data.SqlClient

Public Class DailySalesReportViewer
    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True")
    Private cmd As New SqlCommand

    Private Sub DailySalesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        sql = "select * from OrderHistory"

        Try
            cmd = New SqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "OrderHistory")
            Dim report As New DSRCrystalReport
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

    Private Sub picBack_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        StaffMaintenance.Close()
        ProductMaintenance.Close()
        PromotionMaintenance.Close()
        MembershipMaintenance.Close()
    End Sub
End Class