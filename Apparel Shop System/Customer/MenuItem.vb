Imports System.Data.SqlClient
Imports Apparel_Shop_System.MenuItemDetails
Public Class MenuItem
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private WithEvents panelShow As New Panel
    Private WithEvents picProductImage As New PictureBox
    Private WithEvents lbl1 As New Label
    Private WithEvents lblProductID As New Label
    Private WithEvents lbl2 As New Label
    Private WithEvents lblProductName As New Label
    Private WithEvents lbl3 As New Label
    Private WithEvents lblProductGender As New Label
    Private WithEvents lbl4 As New Label
    Private WithEvents lblProductCategory As New Label

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Me.Close()
        Home.Close()
        Category.Close()
    End Sub

    Private Sub MenuItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Source\Repos\Haode012\Apparel-Shop-System\Apparel Shop System\ApparelShopSystemDatabase.mdf"";Integrated Security=True"
        load_data()
    End Sub

    Public Sub load_data()
        con.Open()
        cmd = New SqlCommand("select productImage, productId, productName, productGender, productCategory, productSize, productDescription, productPrice, productStock from Product", con)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            panelShow = New Panel
            panelShow.Height = 384

            picProductImage = New PictureBox
            picProductImage.Width = 200
            picProductImage.Height = 200
            picProductImage.BackgroundImageLayout = ImageLayout.Stretch
            picProductImage.Dock = DockStyle.Top
            picProductImage.BorderStyle = BorderStyle.FixedSingle

            lbl1 = New Label
            lbl1.Width = 200
            lbl1.ForeColor = Color.Black
            lbl1.Font = New Font(lbl1.Font, FontStyle.Bold)
            lbl1.BackColor = Color.LightCyan
            lbl1.Dock = DockStyle.Bottom
            lbl1.TextAlign = ContentAlignment.MiddleCenter
            lbl1.BorderStyle = BorderStyle.FixedSingle

            lblProductID = New Label
            lblProductID.Width = 200
            lblProductID.ForeColor = Color.Black
            lblProductID.BackColor = Color.White
            lblProductID.Dock = DockStyle.Bottom
            lblProductID.TextAlign = ContentAlignment.MiddleCenter
            lblProductID.BorderStyle = BorderStyle.FixedSingle

            lbl2 = New Label
            lbl2.Width = 200
            lbl2.ForeColor = Color.Black
            lbl2.Font = New Font(lbl2.Font, FontStyle.Bold)
            lbl2.BackColor = Color.LightCyan
            lbl2.Dock = DockStyle.Bottom
            lbl2.TextAlign = ContentAlignment.MiddleCenter
            lbl2.BorderStyle = BorderStyle.FixedSingle

            lblProductName = New Label
            lblProductName.Width = 200
            lblProductName.ForeColor = Color.Black
            lblProductName.BackColor = Color.White
            lblProductName.Dock = DockStyle.Bottom
            lblProductName.TextAlign = ContentAlignment.MiddleCenter
            lblProductName.BorderStyle = BorderStyle.FixedSingle

            lbl3 = New Label
            lbl3.Width = 200
            lbl3.ForeColor = Color.Black
            lbl3.Font = New Font(lbl3.Font, FontStyle.Bold)
            lbl3.BackColor = Color.LightCyan
            lbl3.Dock = DockStyle.Bottom
            lbl3.TextAlign = ContentAlignment.MiddleCenter
            lbl3.BorderStyle = BorderStyle.FixedSingle

            lblProductGender = New Label
            lblProductGender.Width = 200
            lblProductGender.ForeColor = Color.Black
            lblProductGender.BackColor = Color.White
            lblProductGender.Dock = DockStyle.Bottom
            lblProductGender.TextAlign = ContentAlignment.MiddleCenter
            lblProductGender.BorderStyle = BorderStyle.FixedSingle

            lbl4 = New Label
            lbl4.Width = 200
            lbl4.ForeColor = Color.Black
            lbl4.Font = New Font(lbl4.Font, FontStyle.Bold)
            lbl4.BackColor = Color.LightCyan
            lbl4.Dock = DockStyle.Bottom
            lbl4.TextAlign = ContentAlignment.MiddleCenter
            lbl4.BorderStyle = BorderStyle.FixedSingle

            lblProductCategory = New Label
            lblProductCategory.Width = 200
            lblProductCategory.ForeColor = Color.Black
            lblProductCategory.BackColor = Color.White
            lblProductCategory.Dock = DockStyle.Bottom
            lblProductCategory.TextAlign = ContentAlignment.MiddleCenter
            lblProductCategory.BorderStyle = BorderStyle.FixedSingle

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            picProductImage.BackgroundImage = bitmap

            lbl1.Text = "Product ID"
            lblProductID.Text = dr.Item("productId").ToString
            lbl2.Text = "Product Name"
            lblProductName.Text = dr.Item("productName").ToString
            lbl3.Text = "Product For"
            lblProductGender.Text = dr.Item("productGender").ToString
            lbl4.Text = "Product Category"
            lblProductCategory.Text = dr.Item("productCategory").ToString

            panelShow.Controls.Add(picProductImage)
            panelShow.Controls.Add(lbl1)
            panelShow.Controls.Add(lblProductID)
            panelShow.Controls.Add(lbl2)
            panelShow.Controls.Add(lblProductName)
            panelShow.Controls.Add(lbl3)
            panelShow.Controls.Add(lblProductGender)
            panelShow.Controls.Add(lbl4)
            panelShow.Controls.Add(lblProductCategory)

            FlowLayoutPanel1.Controls.Add(panelShow)


            ' Create a new instance of the MenuItemDetails user control
            Dim menu As New MenuItemDetails()

            ' Set the ProductID and ProductName properties of the user control

            menu.ProductImage = Image.FromStream(ms)
            menu.ProductID = dr.Item("productId").ToString()
            menu.ProductName = dr.Item("productName").ToString()
            menu.ProductGender = dr.Item("productGender").ToString()
            menu.ProductCategory = dr.Item("productCategory").ToString()
            menu.ProductSize = dr.Item("productSize").ToString()
            menu.ProductDescription = dr.Item("productDescription").ToString()
            menu.ProductPrice = dr.Item("productPrice").ToString()
            menu.ProductStock = dr.Item("productStock").ToString()

            ' Set the Tag property of the picture box control to the MenuItemDetails instance
            picProductImage.Tag = menu

            ' Add a handler for the Click event of the picture box control
            AddHandler picProductImage.Click, AddressOf lblProductID_Click
        End While
        dr.Close()
        con.Close()
    End Sub

    Public Sub lblProductID_Click(sender As Object, e As EventArgs)

        Dim menu As MenuItemDetails = DirectCast(sender, PictureBox).Tag

        MenuItemDetails.ShowProductDetails(menu.ProductImage, menu.ProductID, menu.ProductName, menu.ProductGender, menu.ProductCategory, menu.ProductSize, menu.ProductDescription, menu.ProductPrice, menu.ProductStock)

        With MenuItemDetails
            .TopLevel = False
            Me.Controls.Add(MenuItemDetails)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Me.Close()
    End Sub
End Class