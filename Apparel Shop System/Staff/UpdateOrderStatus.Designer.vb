<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOrderStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateOrderStatus))
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblPromotion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblReceiptId = New System.Windows.Forms.Label()
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.lblOrderId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStock
        '
        Me.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblStock.Location = New System.Drawing.Point(94, 776)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(335, 35)
        Me.lblStock.TabIndex = 137
        Me.lblStock.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label2.Location = New System.Drawing.Point(833, 575)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 38)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Quantity :"
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblQuantity.Location = New System.Drawing.Point(1174, 574)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(309, 35)
        Me.lblQuantity.TabIndex = 135
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(877, 746)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(329, 65)
        Me.btnBack.TabIndex = 134
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(1246, 746)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(329, 65)
        Me.btnCancel.TabIndex = 133
        Me.btnCancel.Text = "&Cancel Order"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label6.Location = New System.Drawing.Point(833, 515)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 38)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Status :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label13.Location = New System.Drawing.Point(833, 434)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(281, 38)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Payment Method :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label14.Location = New System.Drawing.Point(833, 318)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 38)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Order Date :"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblStatus.Location = New System.Drawing.Point(1174, 514)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(309, 35)
        Me.lblStatus.TabIndex = 129
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblPaymentMethod.Location = New System.Drawing.Point(1174, 434)
        Me.lblPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(309, 59)
        Me.lblPaymentMethod.TabIndex = 128
        '
        'lblOrderDate
        '
        Me.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblOrderDate.Location = New System.Drawing.Point(1174, 317)
        Me.lblOrderDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(454, 77)
        Me.lblOrderDate.TabIndex = 127
        '
        'lblAmount
        '
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblAmount.Location = New System.Drawing.Point(1174, 265)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(309, 35)
        Me.lblAmount.TabIndex = 126
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label21.Location = New System.Drawing.Point(833, 266)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(220, 38)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "Amount(RM) :"
        '
        'lblPromotion
        '
        Me.lblPromotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblPromotion.Location = New System.Drawing.Point(439, 646)
        Me.lblPromotion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromotion.Name = "lblPromotion"
        Me.lblPromotion.Size = New System.Drawing.Size(335, 35)
        Me.lblPromotion.TabIndex = 124
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label12.Location = New System.Drawing.Point(125, 643)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(245, 38)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Promotion(-%) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label11.Location = New System.Drawing.Point(125, 588)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(250, 38)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Unit Price(RM) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label10.Location = New System.Drawing.Point(125, 526)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 38)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Member ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label9.Location = New System.Drawing.Point(125, 467)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 38)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Receipt ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label8.Location = New System.Drawing.Point(123, 375)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 38)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Product Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label7.Location = New System.Drawing.Point(123, 314)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 38)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Product ID:"
        '
        'lblReceiptId
        '
        Me.lblReceiptId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiptId.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblReceiptId.Location = New System.Drawing.Point(439, 470)
        Me.lblReceiptId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceiptId.Name = "lblReceiptId"
        Me.lblReceiptId.Size = New System.Drawing.Size(335, 35)
        Me.lblReceiptId.TabIndex = 117
        '
        'lblMemberId
        '
        Me.lblMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberId.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblMemberId.Location = New System.Drawing.Point(439, 529)
        Me.lblMemberId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(335, 35)
        Me.lblMemberId.TabIndex = 116
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblUnitPrice.Location = New System.Drawing.Point(437, 591)
        Me.lblUnitPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(335, 35)
        Me.lblUnitPrice.TabIndex = 115
        '
        'lblProductName
        '
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblProductName.Location = New System.Drawing.Point(437, 378)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(335, 75)
        Me.lblProductName.TabIndex = 114
        '
        'lblProductId
        '
        Me.lblProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblProductId.Location = New System.Drawing.Point(437, 317)
        Me.lblProductId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(335, 35)
        Me.lblProductId.TabIndex = 113
        '
        'lblOrderId
        '
        Me.lblOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderId.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblOrderId.Location = New System.Drawing.Point(437, 265)
        Me.lblOrderId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderId.Name = "lblOrderId"
        Me.lblOrderId.Size = New System.Drawing.Size(335, 35)
        Me.lblOrderId.TabIndex = 112
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
        Me.Panel1.TabIndex = 110
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.Label1.Location = New System.Drawing.Point(123, 262)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 38)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Order ID:"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(3, 59)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1651, 146)
        Me.lblWelcome.TabIndex = 109
        Me.lblWelcome.Text = "Update Order Status"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateOrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblPromotion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblReceiptId)
        Me.Controls.Add(Me.lblMemberId)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblProductId)
        Me.Controls.Add(Me.lblOrderId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateOrderStatus"
        Me.Text = "UpdateOrderStatus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStock As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblPromotion As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReceiptId As Label
    Friend WithEvents lblMemberId As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductId As Label
    Friend WithEvents lblOrderId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
End Class
