<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductItemDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductItemDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblProductItemDetails = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.lblProductQuantity = New System.Windows.Forms.Label()
        Me.lblProductSize = New System.Windows.Forms.Label()
        Me.lblProductStock = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.lblProductCategory = New System.Windows.Forms.Label()
        Me.lblProductGender = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblProductPromotion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.picAdd = New System.Windows.Forms.PictureBox()
        Me.picRemove = New System.Windows.Forms.PictureBox()
        Me.picProductImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picBack)
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 2
        '
        'picBack
        '
        Me.picBack.Dock = System.Windows.Forms.DockStyle.Left
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(46, 46)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 2
        Me.picBack.TabStop = False
        '
        'picDelete
        '
        Me.picDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.picDelete.Image = Global.Apparel_Shop_System.My.Resources.Resources.close
        Me.picDelete.Location = New System.Drawing.Point(1608, 0)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(46, 46)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 0
        Me.picDelete.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(689, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(679, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 38)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Product Size:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(673, 766)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 38)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Product Stock:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(673, 670)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 38)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Product Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(673, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 38)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Product Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(679, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 38)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Product Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(679, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 38)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Product Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(673, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 38)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Product Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(673, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 38)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Product ID:"
        '
        'lblProductItemDetails
        '
        Me.lblProductItemDetails.BackColor = System.Drawing.Color.LightCyan
        Me.lblProductItemDetails.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductItemDetails.Location = New System.Drawing.Point(300, 63)
        Me.lblProductItemDetails.Name = "lblProductItemDetails"
        Me.lblProductItemDetails.Size = New System.Drawing.Size(933, 107)
        Me.lblProductItemDetails.TabIndex = 40
        Me.lblProductItemDetails.Text = "Product Item Details"
        Me.lblProductItemDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(675, 820)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 38)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Product Quantity:"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(1314, 877)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(264, 58)
        Me.btnAddToCart.TabIndex = 42
        Me.btnAddToCart.Text = "&Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'lblProductQuantity
        '
        Me.lblProductQuantity.AutoSize = True
        Me.lblProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductQuantity.Location = New System.Drawing.Point(1099, 820)
        Me.lblProductQuantity.Name = "lblProductQuantity"
        Me.lblProductQuantity.Size = New System.Drawing.Size(81, 40)
        Me.lblProductQuantity.TabIndex = 52
        Me.lblProductQuantity.Text = "Qua"
        '
        'lblProductSize
        '
        Me.lblProductSize.AutoSize = True
        Me.lblProductSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductSize.Location = New System.Drawing.Point(1052, 451)
        Me.lblProductSize.Name = "lblProductSize"
        Me.lblProductSize.Size = New System.Drawing.Size(228, 40)
        Me.lblProductSize.TabIndex = 51
        Me.lblProductSize.Text = "lblProductSize"
        '
        'lblProductStock
        '
        Me.lblProductStock.AutoSize = True
        Me.lblProductStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductStock.Location = New System.Drawing.Point(1046, 769)
        Me.lblProductStock.Name = "lblProductStock"
        Me.lblProductStock.Size = New System.Drawing.Size(247, 40)
        Me.lblProductStock.TabIndex = 50
        Me.lblProductStock.Text = "lblProductStock"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPrice.Location = New System.Drawing.Point(1046, 673)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(239, 40)
        Me.lblProductPrice.TabIndex = 49
        Me.lblProductPrice.Text = "lblProductPrice"
        '
        'lblProductDescription
        '
        Me.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDescription.Location = New System.Drawing.Point(1046, 500)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(532, 159)
        Me.lblProductDescription.TabIndex = 48
        Me.lblProductDescription.Text = "lblProductDescription"
        '
        'lblProductCategory
        '
        Me.lblProductCategory.AutoSize = True
        Me.lblProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCategory.Location = New System.Drawing.Point(1052, 399)
        Me.lblProductCategory.Name = "lblProductCategory"
        Me.lblProductCategory.Size = New System.Drawing.Size(297, 40)
        Me.lblProductCategory.TabIndex = 47
        Me.lblProductCategory.Text = "lblProductCategory"
        '
        'lblProductGender
        '
        Me.lblProductGender.AutoSize = True
        Me.lblProductGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGender.Location = New System.Drawing.Point(1052, 344)
        Me.lblProductGender.Name = "lblProductGender"
        Me.lblProductGender.Size = New System.Drawing.Size(273, 40)
        Me.lblProductGender.TabIndex = 46
        Me.lblProductGender.Text = "lblProductGender"
        '
        'lblProductName
        '
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(1046, 251)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(532, 79)
        Me.lblProductName.TabIndex = 45
        Me.lblProductName.Text = "lblProductName"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(1046, 194)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(196, 40)
        Me.lblProductID.TabIndex = 44
        Me.lblProductID.Text = "lblProductID"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1062, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 17)
        Me.Label20.TabIndex = 43
        '
        'lblProductPromotion
        '
        Me.lblProductPromotion.AutoSize = True
        Me.lblProductPromotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPromotion.Location = New System.Drawing.Point(1046, 721)
        Me.lblProductPromotion.Name = "lblProductPromotion"
        Me.lblProductPromotion.Size = New System.Drawing.Size(312, 40)
        Me.lblProductPromotion.TabIndex = 55
        Me.lblProductPromotion.Text = "lblProductPromotion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(673, 718)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(314, 38)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Product Promotion:"
        '
        'picAdd
        '
        Me.picAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAdd.Image = Global.Apparel_Shop_System.My.Resources.Resources.add_icon1
        Me.picAdd.Location = New System.Drawing.Point(1046, 820)
        Me.picAdd.Name = "picAdd"
        Me.picAdd.Size = New System.Drawing.Size(44, 41)
        Me.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdd.TabIndex = 56
        Me.picAdd.TabStop = False
        '
        'picRemove
        '
        Me.picRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRemove.Image = CType(resources.GetObject("picRemove.Image"), System.Drawing.Image)
        Me.picRemove.Location = New System.Drawing.Point(1189, 820)
        Me.picRemove.Name = "picRemove"
        Me.picRemove.Size = New System.Drawing.Size(44, 41)
        Me.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRemove.TabIndex = 53
        Me.picRemove.TabStop = False
        '
        'picProductImage
        '
        Me.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProductImage.Location = New System.Drawing.Point(165, 251)
        Me.picProductImage.Name = "picProductImage"
        Me.picProductImage.Size = New System.Drawing.Size(474, 431)
        Me.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductImage.TabIndex = 3
        Me.picProductImage.TabStop = False
        '
        'ProductItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.picAdd)
        Me.Controls.Add(Me.lblProductPromotion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.picRemove)
        Me.Controls.Add(Me.lblProductQuantity)
        Me.Controls.Add(Me.lblProductSize)
        Me.Controls.Add(Me.lblProductStock)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.lblProductCategory)
        Me.Controls.Add(Me.lblProductGender)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblProductItemDetails)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picProductImage)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductItemDetails"
        Me.Text = "MenuItemDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picProductImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblProductItemDetails As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents lblProductQuantity As Label
    Friend WithEvents lblProductSize As Label
    Friend WithEvents lblProductStock As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents lblProductGender As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents picRemove As PictureBox
    Friend WithEvents lblProductPromotion As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents picAdd As PictureBox
End Class
