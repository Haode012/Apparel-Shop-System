Module Module1

    Public decTotalAmount As Decimal
    Public totalAmount As String


    Public conn As New System.Data.SqlClient.SqlConnection
    Public Function OpenConnection() As Boolean
        Dim strMySQLConnectionString As String

        strMySQLConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        Try
            conn.ConnectionString = strMySQLConnectionString
            conn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub CloseConnection()
        conn.Close()
    End Sub
End Module
