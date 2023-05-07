<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promotion_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Promotion_Details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblPromoInfo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEditPromo = New System.Windows.Forms.Button()
        Me.pnlPromotionInfo = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblModifiedDate = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblModifiedBy = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCreateBy = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblPromotionDescription = New System.Windows.Forms.Label()
        Me.lblPromotionName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabPromOverview = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.tctPromotion = New System.Windows.Forms.TabControl()
        Me.tabPromotionApply = New System.Windows.Forms.TabPage()
        Me.lblCountApply = New System.Windows.Forms.Label()
        Me.lblCountProducts = New System.Windows.Forms.Label()
        Me.cboProductCategory = New System.Windows.Forms.ComboBox()
        Me.dgvApplyPromotionList = New System.Windows.Forms.DataGridView()
        Me.dgvProductList = New System.Windows.Forms.DataGridView()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblShowPromotionName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPromotionInfo.SuspendLayout()
        Me.tabPromOverview.SuspendLayout()
        Me.tctPromotion.SuspendLayout()
        Me.tabPromotionApply.SuspendLayout()
        CType(Me.dgvApplyPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 9
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
        'lblPromoInfo
        '
        Me.lblPromoInfo.AutoSize = True
        Me.lblPromoInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromoInfo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblPromoInfo.Location = New System.Drawing.Point(70, 67)
        Me.lblPromoInfo.Name = "lblPromoInfo"
        Me.lblPromoInfo.Size = New System.Drawing.Size(262, 29)
        Me.lblPromoInfo.TabIndex = 79
        Me.lblPromoInfo.Text = "Promotion Information"
        Me.lblPromoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(227, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Status"
        '
        'btnEditPromo
        '
        Me.btnEditPromo.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEditPromo.Image = Global.Apparel_Shop_System.My.Resources.Resources.edit_icon
        Me.btnEditPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditPromo.Location = New System.Drawing.Point(1336, 33)
        Me.btnEditPromo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditPromo.Name = "btnEditPromo"
        Me.btnEditPromo.Size = New System.Drawing.Size(98, 52)
        Me.btnEditPromo.TabIndex = 113
        Me.btnEditPromo.Text = "&Edit"
        Me.btnEditPromo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditPromo.UseVisualStyleBackColor = False
        '
        'pnlPromotionInfo
        '
        Me.pnlPromotionInfo.BackColor = System.Drawing.SystemColors.Control
        Me.pnlPromotionInfo.Controls.Add(Me.Label9)
        Me.pnlPromotionInfo.Controls.Add(Me.lblStatus)
        Me.pnlPromotionInfo.Controls.Add(Me.Label3)
        Me.pnlPromotionInfo.Controls.Add(Me.lblModifiedDate)
        Me.pnlPromotionInfo.Controls.Add(Me.Label20)
        Me.pnlPromotionInfo.Controls.Add(Me.lblCreationDate)
        Me.pnlPromotionInfo.Controls.Add(Me.Label17)
        Me.pnlPromotionInfo.Controls.Add(Me.lblModifiedBy)
        Me.pnlPromotionInfo.Controls.Add(Me.Label16)
        Me.pnlPromotionInfo.Controls.Add(Me.lblCreateBy)
        Me.pnlPromotionInfo.Controls.Add(Me.lblDiscount)
        Me.pnlPromotionInfo.Controls.Add(Me.lblEndDate)
        Me.pnlPromotionInfo.Controls.Add(Me.lblStartDate)
        Me.pnlPromotionInfo.Controls.Add(Me.lblPromotionDescription)
        Me.pnlPromotionInfo.Controls.Add(Me.lblPromotionName)
        Me.pnlPromotionInfo.Controls.Add(Me.Label8)
        Me.pnlPromotionInfo.Controls.Add(Me.Label7)
        Me.pnlPromotionInfo.Controls.Add(Me.Label4)
        Me.pnlPromotionInfo.Controls.Add(Me.Label5)
        Me.pnlPromotionInfo.Controls.Add(Me.Label10)
        Me.pnlPromotionInfo.Location = New System.Drawing.Point(75, 109)
        Me.pnlPromotionInfo.Name = "pnlPromotionInfo"
        Me.pnlPromotionInfo.Size = New System.Drawing.Size(1359, 378)
        Me.pnlPromotionInfo.TabIndex = 81
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(301, 324)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(346, 40)
        Me.lblStatus.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(731, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Modified Date"
        '
        'lblModifiedDate
        '
        Me.lblModifiedDate.BackColor = System.Drawing.Color.White
        Me.lblModifiedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblModifiedDate.Location = New System.Drawing.Point(869, 275)
        Me.lblModifiedDate.Name = "lblModifiedDate"
        Me.lblModifiedDate.Size = New System.Drawing.Size(346, 40)
        Me.lblModifiedDate.TabIndex = 108
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(169, 275)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 25)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Creation Day"
        '
        'lblCreationDate
        '
        Me.lblCreationDate.BackColor = System.Drawing.Color.White
        Me.lblCreationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCreationDate.Location = New System.Drawing.Point(301, 275)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(346, 40)
        Me.lblCreationDate.TabIndex = 106
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(749, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 25)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Modified By"
        '
        'lblModifiedBy
        '
        Me.lblModifiedBy.BackColor = System.Drawing.Color.White
        Me.lblModifiedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblModifiedBy.Location = New System.Drawing.Point(869, 225)
        Me.lblModifiedBy.Name = "lblModifiedBy"
        Me.lblModifiedBy.Size = New System.Drawing.Size(346, 40)
        Me.lblModifiedBy.TabIndex = 104
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(185, 225)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 25)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Created By"
        '
        'lblCreateBy
        '
        Me.lblCreateBy.BackColor = System.Drawing.Color.White
        Me.lblCreateBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCreateBy.Location = New System.Drawing.Point(301, 225)
        Me.lblCreateBy.Name = "lblCreateBy"
        Me.lblCreateBy.Size = New System.Drawing.Size(346, 40)
        Me.lblCreateBy.TabIndex = 102
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(301, 175)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(346, 40)
        Me.lblDiscount.TabIndex = 101
        '
        'lblEndDate
        '
        Me.lblEndDate.BackColor = System.Drawing.Color.White
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(869, 125)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(346, 40)
        Me.lblEndDate.TabIndex = 100
        Me.lblEndDate.Text = "Promotion Name"
        '
        'lblStartDate
        '
        Me.lblStartDate.BackColor = System.Drawing.Color.White
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(301, 125)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(346, 40)
        Me.lblStartDate.TabIndex = 99
        '
        'lblPromotionDescription
        '
        Me.lblPromotionDescription.BackColor = System.Drawing.Color.White
        Me.lblPromotionDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPromotionDescription.Location = New System.Drawing.Point(301, 75)
        Me.lblPromotionDescription.Name = "lblPromotionDescription"
        Me.lblPromotionDescription.Size = New System.Drawing.Size(914, 40)
        Me.lblPromotionDescription.TabIndex = 98
        Me.lblPromotionDescription.Text = "Description show here"
        '
        'lblPromotionName
        '
        Me.lblPromotionName.BackColor = System.Drawing.Color.White
        Me.lblPromotionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPromotionName.Location = New System.Drawing.Point(301, 25)
        Me.lblPromotionName.Name = "lblPromotionName"
        Me.lblPromotionName.Size = New System.Drawing.Size(346, 40)
        Me.lblPromotionName.TabIndex = 97
        Me.lblPromotionName.Text = "Promotion Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(170, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 25)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Discount (%)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(770, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(138, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 25)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Promotion Name"
        '
        'tabPromOverview
        '
        Me.tabPromOverview.AutoScroll = True
        Me.tabPromOverview.BackColor = System.Drawing.Color.White
        Me.tabPromOverview.Controls.Add(Me.btnEditPromo)
        Me.tabPromOverview.Controls.Add(Me.pnlPromotionInfo)
        Me.tabPromOverview.Controls.Add(Me.lblPromoInfo)
        Me.tabPromOverview.Location = New System.Drawing.Point(4, 68)
        Me.tabPromOverview.Name = "tabPromOverview"
        Me.tabPromOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPromOverview.Size = New System.Drawing.Size(1523, 614)
        Me.tabPromOverview.TabIndex = 0
        Me.tabPromOverview.Text = "Overview"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label25.Location = New System.Drawing.Point(774, 106)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(392, 29)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Apply promotion on these product"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.Image = Global.Apparel_Shop_System.My.Resources.Resources.right_icon
        Me.btnAdd.Location = New System.Drawing.Point(693, 315)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 37)
        Me.btnAdd.TabIndex = 87
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(58, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 29)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Products"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(63, 36)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(346, 36)
        Me.txtSearchBox.TabIndex = 0
        '
        'tctPromotion
        '
        Me.tctPromotion.Controls.Add(Me.tabPromOverview)
        Me.tctPromotion.Controls.Add(Me.tabPromotionApply)
        Me.tctPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tctPromotion.Location = New System.Drawing.Point(70, 216)
        Me.tctPromotion.Name = "tctPromotion"
        Me.tctPromotion.Padding = New System.Drawing.Point(40, 20)
        Me.tctPromotion.SelectedIndex = 0
        Me.tctPromotion.Size = New System.Drawing.Size(1531, 686)
        Me.tctPromotion.TabIndex = 13
        '
        'tabPromotionApply
        '
        Me.tabPromotionApply.BackColor = System.Drawing.Color.White
        Me.tabPromotionApply.Controls.Add(Me.lblCountApply)
        Me.tabPromotionApply.Controls.Add(Me.lblCountProducts)
        Me.tabPromotionApply.Controls.Add(Me.cboProductCategory)
        Me.tabPromotionApply.Controls.Add(Me.dgvApplyPromotionList)
        Me.tabPromotionApply.Controls.Add(Me.dgvProductList)
        Me.tabPromotionApply.Controls.Add(Me.Label25)
        Me.tabPromotionApply.Controls.Add(Me.btnAdd)
        Me.tabPromotionApply.Controls.Add(Me.Label22)
        Me.tabPromotionApply.Controls.Add(Me.txtSearchBox)
        Me.tabPromotionApply.Location = New System.Drawing.Point(4, 68)
        Me.tabPromotionApply.Name = "tabPromotionApply"
        Me.tabPromotionApply.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPromotionApply.Size = New System.Drawing.Size(1523, 614)
        Me.tabPromotionApply.TabIndex = 1
        Me.tabPromotionApply.Text = "Apply Product"
        '
        'lblCountApply
        '
        Me.lblCountApply.AutoSize = True
        Me.lblCountApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCountApply.Location = New System.Drawing.Point(783, 555)
        Me.lblCountApply.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountApply.Name = "lblCountApply"
        Me.lblCountApply.Size = New System.Drawing.Size(164, 25)
        Me.lblCountApply.TabIndex = 109
        Me.lblCountApply.Text = "X record(s) found"
        '
        'lblCountProducts
        '
        Me.lblCountProducts.AutoSize = True
        Me.lblCountProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCountProducts.Location = New System.Drawing.Point(63, 555)
        Me.lblCountProducts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountProducts.Name = "lblCountProducts"
        Me.lblCountProducts.Size = New System.Drawing.Size(164, 25)
        Me.lblCountProducts.TabIndex = 108
        Me.lblCountProducts.Text = "X record(s) found"
        '
        'cboProductCategory
        '
        Me.cboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductCategory.FormattingEnabled = True
        Me.cboProductCategory.Items.AddRange(New Object() {"All", "Shirt", "Pant", "Shoe", "Sock"})
        Me.cboProductCategory.Location = New System.Drawing.Point(416, 40)
        Me.cboProductCategory.Name = "cboProductCategory"
        Me.cboProductCategory.Size = New System.Drawing.Size(204, 33)
        Me.cboProductCategory.TabIndex = 105
        '
        'dgvApplyPromotionList
        '
        Me.dgvApplyPromotionList.AllowUserToAddRows = False
        Me.dgvApplyPromotionList.AllowUserToDeleteRows = False
        Me.dgvApplyPromotionList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvApplyPromotionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvApplyPromotionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvApplyPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApplyPromotionList.Location = New System.Drawing.Point(779, 148)
        Me.dgvApplyPromotionList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvApplyPromotionList.Name = "dgvApplyPromotionList"
        Me.dgvApplyPromotionList.ReadOnly = True
        Me.dgvApplyPromotionList.RowHeadersWidth = 51
        Me.dgvApplyPromotionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvApplyPromotionList.Size = New System.Drawing.Size(610, 393)
        Me.dgvApplyPromotionList.TabIndex = 104
        '
        'dgvProductList
        '
        Me.dgvProductList.AllowUserToAddRows = False
        Me.dgvProductList.AllowUserToDeleteRows = False
        Me.dgvProductList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductList.Location = New System.Drawing.Point(63, 148)
        Me.dgvProductList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProductList.Name = "dgvProductList"
        Me.dgvProductList.ReadOnly = True
        Me.dgvProductList.RowHeadersWidth = 51
        Me.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductList.Size = New System.Drawing.Size(610, 393)
        Me.dgvProductList.TabIndex = 103
        '
        'btnReturn
        '
        Me.btnReturn.Image = Global.Apparel_Shop_System.My.Resources.Resources.return_icon
        Me.btnReturn.Location = New System.Drawing.Point(88, 99)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(50, 50)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblShowPromotionName
        '
        Me.lblShowPromotionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblShowPromotionName.Location = New System.Drawing.Point(144, 149)
        Me.lblShowPromotionName.Name = "lblShowPromotionName"
        Me.lblShowPromotionName.Size = New System.Drawing.Size(510, 50)
        Me.lblShowPromotionName.TabIndex = 12
        Me.lblShowPromotionName.Text = "(Promotion Name Show Here)"
        Me.lblShowPromotionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 50)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Promotions :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Promotion_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.tctPromotion)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblShowPromotionName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Promotion_Details"
        Me.Text = "Promotion_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPromotionInfo.ResumeLayout(False)
        Me.pnlPromotionInfo.PerformLayout()
        Me.tabPromOverview.ResumeLayout(False)
        Me.tabPromOverview.PerformLayout()
        Me.tctPromotion.ResumeLayout(False)
        Me.tabPromotionApply.ResumeLayout(False)
        Me.tabPromotionApply.PerformLayout()
        CType(Me.dgvApplyPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblPromoInfo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEditPromo As Button
    Friend WithEvents pnlPromotionInfo As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblModifiedDate As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblModifiedBy As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCreateBy As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblPromotionDescription As Label
    Friend WithEvents lblPromotionName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tabPromOverview As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents tctPromotion As TabControl
    Friend WithEvents tabPromotionApply As TabPage
    Friend WithEvents lblCountApply As Label
    Friend WithEvents lblCountProducts As Label
    Friend WithEvents cboProductCategory As ComboBox
    Friend WithEvents dgvApplyPromotionList As DataGridView
    Friend WithEvents dgvProductList As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblShowPromotionName As Label
    Friend WithEvents Label1 As Label
End Class
