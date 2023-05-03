<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayProductDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayProductDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductGender = New System.Windows.Forms.Label()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.lblProductSize = New System.Windows.Forms.Label()
        Me.lblProductCategory = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductStock = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.lblProductPromotion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 6
        '
        'picBack
        '
        Me.picBack.Dock = System.Windows.Forms.DockStyle.Left
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(46, 46)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 3
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
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(351, 58)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 100)
        Me.lblWelcome.TabIndex = 28
        Me.lblWelcome.Text = "Display Product Details"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 506)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 38)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Product Size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 38)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Product Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 38)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Product Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 38)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Product Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 38)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 38)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Product ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(999, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 38)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Product Image:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 773)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 38)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Product Stock:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 724)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 38)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Product Price:"
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(1006, 234)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(598, 512)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 84
        Me.picImage.TabStop = False
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(482, 178)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(134, 40)
        Me.lblProductID.TabIndex = 85
        Me.lblProductID.Text = "Label10"
        '
        'lblProductName
        '
        Me.lblProductName.AutoEllipsis = True
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(482, 233)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(500, 150)
        Me.lblProductName.TabIndex = 86
        Me.lblProductName.Text = "Label11"
        '
        'lblProductGender
        '
        Me.lblProductGender.AutoSize = True
        Me.lblProductGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGender.Location = New System.Drawing.Point(482, 394)
        Me.lblProductGender.Name = "lblProductGender"
        Me.lblProductGender.Size = New System.Drawing.Size(134, 40)
        Me.lblProductGender.TabIndex = 87
        Me.lblProductGender.Text = "Label12"
        '
        'lblProductDescription
        '
        Me.lblProductDescription.AutoEllipsis = True
        Me.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDescription.Location = New System.Drawing.Point(482, 553)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(500, 166)
        Me.lblProductDescription.TabIndex = 90
        Me.lblProductDescription.Text = "Label13"
        '
        'lblProductSize
        '
        Me.lblProductSize.AutoSize = True
        Me.lblProductSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductSize.Location = New System.Drawing.Point(482, 504)
        Me.lblProductSize.Name = "lblProductSize"
        Me.lblProductSize.Size = New System.Drawing.Size(134, 40)
        Me.lblProductSize.TabIndex = 89
        Me.lblProductSize.Text = "Label14"
        '
        'lblProductCategory
        '
        Me.lblProductCategory.AutoSize = True
        Me.lblProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCategory.Location = New System.Drawing.Point(482, 449)
        Me.lblProductCategory.Name = "lblProductCategory"
        Me.lblProductCategory.Size = New System.Drawing.Size(134, 40)
        Me.lblProductCategory.TabIndex = 88
        Me.lblProductCategory.Text = "Label15"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPrice.Location = New System.Drawing.Point(482, 724)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(134, 40)
        Me.lblProductPrice.TabIndex = 91
        Me.lblProductPrice.Text = "Label16"
        '
        'lblProductStock
        '
        Me.lblProductStock.AutoSize = True
        Me.lblProductStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductStock.Location = New System.Drawing.Point(482, 773)
        Me.lblProductStock.Name = "lblProductStock"
        Me.lblProductStock.Size = New System.Drawing.Size(134, 40)
        Me.lblProductStock.TabIndex = 92
        Me.lblProductStock.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(85, 823)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(314, 38)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Product Promotion:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(85, 864)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(233, 38)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "Date Created:"
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreated.Location = New System.Drawing.Point(484, 871)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(134, 40)
        Me.lblDateCreated.TabIndex = 96
        Me.lblDateCreated.Text = "Label20"
        '
        'lblProductPromotion
        '
        Me.lblProductPromotion.AutoSize = True
        Me.lblProductPromotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPromotion.Location = New System.Drawing.Point(484, 822)
        Me.lblProductPromotion.Name = "lblProductPromotion"
        Me.lblProductPromotion.Size = New System.Drawing.Size(134, 40)
        Me.lblProductPromotion.TabIndex = 95
        Me.lblProductPromotion.Text = "Label21"
        '
        'DisplayProductDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.lblProductPromotion)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblProductStock)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.lblProductSize)
        Me.Controls.Add(Me.lblProductCategory)
        Me.Controls.Add(Me.lblProductGender)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DisplayProductDetails"
        Me.Text = "DisplayProductDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductGender As Label
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents lblProductSize As Label
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductStock As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblDateCreated As Label
    Friend WithEvents lblProductPromotion As Label
End Class
