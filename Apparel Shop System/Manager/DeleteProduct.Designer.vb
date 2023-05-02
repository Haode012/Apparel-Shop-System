<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteProduct))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbProductID = New System.Windows.Forms.ComboBox()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.grpProductSize = New System.Windows.Forms.GroupBox()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.radS = New System.Windows.Forms.RadioButton()
        Me.radXL = New System.Windows.Forms.RadioButton()
        Me.radL = New System.Windows.Forms.RadioButton()
        Me.grpProductGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.cmbProductCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProductSize.SuspendLayout()
        Me.grpProductGender.SuspendLayout()
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
        'txtProductPrice
        '
        Me.txtProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductPrice.Location = New System.Drawing.Point(468, 678)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(246, 45)
        Me.txtProductPrice.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 678)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 38)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Product Price:"
        '
        'cmbProductID
        '
        Me.cmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductID.FormattingEnabled = True
        Me.cmbProductID.Location = New System.Drawing.Point(466, 223)
        Me.cmbProductID.Name = "cmbProductID"
        Me.cmbProductID.Size = New System.Drawing.Size(216, 39)
        Me.cmbProductID.TabIndex = 111
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(934, 274)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(598, 512)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 110
        Me.picImage.TabStop = False
        '
        'grpProductSize
        '
        Me.grpProductSize.Controls.Add(Me.radM)
        Me.grpProductSize.Controls.Add(Me.radS)
        Me.grpProductSize.Controls.Add(Me.radXL)
        Me.grpProductSize.Controls.Add(Me.radL)
        Me.grpProductSize.Location = New System.Drawing.Point(468, 444)
        Me.grpProductSize.Name = "grpProductSize"
        Me.grpProductSize.Size = New System.Drawing.Size(285, 66)
        Me.grpProductSize.TabIndex = 109
        Me.grpProductSize.TabStop = False
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radM.Location = New System.Drawing.Point(83, 21)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(59, 36)
        Me.radM.TabIndex = 54
        Me.radM.TabStop = True
        Me.radM.Text = "M"
        Me.radM.UseVisualStyleBackColor = True
        '
        'radS
        '
        Me.radS.AutoSize = True
        Me.radS.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radS.Location = New System.Drawing.Point(22, 21)
        Me.radS.Name = "radS"
        Me.radS.Size = New System.Drawing.Size(55, 36)
        Me.radS.TabIndex = 53
        Me.radS.TabStop = True
        Me.radS.Text = "S"
        Me.radS.UseVisualStyleBackColor = True
        '
        'radXL
        '
        Me.radXL.AutoSize = True
        Me.radXL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radXL.Location = New System.Drawing.Point(205, 21)
        Me.radXL.Name = "radXL"
        Me.radXL.Size = New System.Drawing.Size(71, 36)
        Me.radXL.TabIndex = 56
        Me.radXL.TabStop = True
        Me.radXL.Text = "XL"
        Me.radXL.UseVisualStyleBackColor = True
        '
        'radL
        '
        Me.radL.AutoSize = True
        Me.radL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radL.Location = New System.Drawing.Point(148, 21)
        Me.radL.Name = "radL"
        Me.radL.Size = New System.Drawing.Size(52, 36)
        Me.radL.TabIndex = 55
        Me.radL.TabStop = True
        Me.radL.Text = "L"
        Me.radL.UseVisualStyleBackColor = True
        '
        'grpProductGender
        '
        Me.grpProductGender.BackColor = System.Drawing.Color.Transparent
        Me.grpProductGender.Controls.Add(Me.radFemale)
        Me.grpProductGender.Controls.Add(Me.radMale)
        Me.grpProductGender.Location = New System.Drawing.Point(468, 325)
        Me.grpProductGender.Name = "grpProductGender"
        Me.grpProductGender.Size = New System.Drawing.Size(248, 68)
        Me.grpProductGender.TabIndex = 108
        Me.grpProductGender.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(116, 26)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(98, 29)
        Me.radFemale.TabIndex = 17
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(24, 26)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(76, 29)
        Me.radMale.TabIndex = 16
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 38)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Product Size:"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(468, 516)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(423, 156)
        Me.txtProductDescription.TabIndex = 106
        '
        'cmbProductCategory
        '
        Me.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductCategory.FormattingEnabled = True
        Me.cmbProductCategory.Items.AddRange(New Object() {"Shirt", "Pant", "Shoe", "Sock"})
        Me.cmbProductCategory.Location = New System.Drawing.Point(468, 399)
        Me.cmbProductCategory.Name = "cmbProductCategory"
        Me.cmbProductCategory.Size = New System.Drawing.Size(248, 39)
        Me.cmbProductCategory.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 38)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Product Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 38)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Product Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 38)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Product Gender:"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(466, 274)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(425, 45)
        Me.txtProductName.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 38)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 38)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Product ID:"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(318, 90)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 98
        Me.lblWelcome.Text = "Delete Product"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(468, 869)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(329, 65)
        Me.btnDelete.TabIndex = 118
        Me.btnDelete.Text = "&Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnChoose
        '
        Me.btnChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.Location = New System.Drawing.Point(468, 802)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(205, 51)
        Me.btnChoose.TabIndex = 117
        Me.btnChoose.Text = "&Choose an Image"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 792)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 38)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Product Image:"
        '
        'txtProductStock
        '
        Me.txtProductStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductStock.Location = New System.Drawing.Point(470, 736)
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.Size = New System.Drawing.Size(100, 45)
        Me.txtProductStock.TabIndex = 115
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 736)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 38)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Product Stock:"
        '
        'DeleteProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProductStock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbProductID)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.grpProductSize)
        Me.Controls.Add(Me.grpProductGender)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtProductDescription)
        Me.Controls.Add(Me.cmbProductCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteProduct"
        Me.Text = "DeleteProduct"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProductSize.ResumeLayout(False)
        Me.grpProductSize.PerformLayout()
        Me.grpProductGender.ResumeLayout(False)
        Me.grpProductGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbProductID As ComboBox
    Friend WithEvents picImage As PictureBox
    Friend WithEvents grpProductSize As GroupBox
    Friend WithEvents radM As RadioButton
    Friend WithEvents radS As RadioButton
    Friend WithEvents radXL As RadioButton
    Friend WithEvents radL As RadioButton
    Friend WithEvents grpProductGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnChoose As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents Label7 As Label
End Class
