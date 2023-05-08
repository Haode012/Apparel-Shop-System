<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.tabPaymentMethod = New System.Windows.Forms.TabControl()
        Me.tbTouchNgo = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMembershipName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMembershipID = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgvTng = New System.Windows.Forms.DataGridView()
        Me.lblTotalAmount1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPaySuccessful = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMasterCard = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancelMaster = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCardHolder = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbExpirationMonth = New System.Windows.Forms.ComboBox()
        Me.cmbExpirationYear = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMasterCard = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMembershipName2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMembershipID2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaymentMethod.SuspendLayout()
        Me.tbTouchNgo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMasterCard.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvMasterCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDelete
        '
        Me.picDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.picDelete.Image = Global.Apparel_Shop_System.My.Resources.Resources.close
        Me.picDelete.Location = New System.Drawing.Point(1609, 0)
        Me.picDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(45, 46)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 0
        Me.picDelete.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.picBack)
        Me.Panel3.Controls.Add(Me.picDelete)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1654, 46)
        Me.Panel3.TabIndex = 9
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
        'tabPaymentMethod
        '
        Me.tabPaymentMethod.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabPaymentMethod.Controls.Add(Me.tbTouchNgo)
        Me.tabPaymentMethod.Controls.Add(Me.tbMasterCard)
        Me.tabPaymentMethod.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.tabPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabPaymentMethod.ItemSize = New System.Drawing.Size(150, 60)
        Me.tabPaymentMethod.Location = New System.Drawing.Point(12, 56)
        Me.tabPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPaymentMethod.Multiline = True
        Me.tabPaymentMethod.Name = "tabPaymentMethod"
        Me.tabPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabPaymentMethod.SelectedIndex = 0
        Me.tabPaymentMethod.Size = New System.Drawing.Size(1630, 923)
        Me.tabPaymentMethod.TabIndex = 10
        '
        'tbTouchNgo
        '
        Me.tbTouchNgo.AutoScroll = True
        Me.tbTouchNgo.BackColor = System.Drawing.Color.DodgerBlue
        Me.tbTouchNgo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbTouchNgo.Controls.Add(Me.PictureBox1)
        Me.tbTouchNgo.Controls.Add(Me.Label5)
        Me.tbTouchNgo.Controls.Add(Me.lblMembershipName)
        Me.tbTouchNgo.Controls.Add(Me.Label3)
        Me.tbTouchNgo.Controls.Add(Me.lblMembershipID)
        Me.tbTouchNgo.Controls.Add(Me.PictureBox3)
        Me.tbTouchNgo.Controls.Add(Me.dgvTng)
        Me.tbTouchNgo.Controls.Add(Me.lblTotalAmount1)
        Me.tbTouchNgo.Controls.Add(Me.Label6)
        Me.tbTouchNgo.Controls.Add(Me.btnCancel)
        Me.tbTouchNgo.Controls.Add(Me.btnPaySuccessful)
        Me.tbTouchNgo.Controls.Add(Me.Label2)
        Me.tbTouchNgo.Location = New System.Drawing.Point(4, 64)
        Me.tbTouchNgo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbTouchNgo.Name = "tbTouchNgo"
        Me.tbTouchNgo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbTouchNgo.Size = New System.Drawing.Size(1622, 855)
        Me.tbTouchNgo.TabIndex = 0
        Me.tbTouchNgo.Text = "Touch'n GO E-wallet"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.tng_example_QR
        Me.PictureBox1.Location = New System.Drawing.Point(12, 537)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(1104, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 32)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Name              :"
        '
        'lblMembershipName
        '
        Me.lblMembershipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembershipName.AutoSize = True
        Me.lblMembershipName.BackColor = System.Drawing.Color.LightCyan
        Me.lblMembershipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipName.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipName.Location = New System.Drawing.Point(1323, 56)
        Me.lblMembershipName.Name = "lblMembershipName"
        Me.lblMembershipName.Size = New System.Drawing.Size(2, 27)
        Me.lblMembershipName.TabIndex = 79
        Me.lblMembershipName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(1104, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 32)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Membership ID:"
        '
        'lblMembershipID
        '
        Me.lblMembershipID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembershipID.AutoSize = True
        Me.lblMembershipID.BackColor = System.Drawing.Color.LightCyan
        Me.lblMembershipID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipID.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipID.Location = New System.Drawing.Point(1323, 11)
        Me.lblMembershipID.Name = "lblMembershipID"
        Me.lblMembershipID.Size = New System.Drawing.Size(2, 27)
        Me.lblMembershipID.TabIndex = 77
        Me.lblMembershipID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Apparel_Shop_System.My.Resources.Resources.download__1_
        Me.PictureBox3.Location = New System.Drawing.Point(504, 5)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 76
        Me.PictureBox3.TabStop = False
        '
        'dgvTng
        '
        Me.dgvTng.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTng.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTng.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvTng.Location = New System.Drawing.Point(12, 106)
        Me.dgvTng.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTng.Name = "dgvTng"
        Me.dgvTng.ReadOnly = True
        Me.dgvTng.RowHeadersWidth = 20
        Me.dgvTng.RowTemplate.Height = 24
        Me.dgvTng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTng.Size = New System.Drawing.Size(1561, 411)
        Me.dgvTng.TabIndex = 61
        '
        'lblTotalAmount1
        '
        Me.lblTotalAmount1.AutoSize = True
        Me.lblTotalAmount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount1.ForeColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount1.Location = New System.Drawing.Point(1347, 537)
        Me.lblTotalAmount1.Name = "lblTotalAmount1"
        Me.lblTotalAmount1.Size = New System.Drawing.Size(235, 40)
        Me.lblTotalAmount1.TabIndex = 51
        Me.lblTotalAmount1.Text = "lblTotalAmount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(1085, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 38)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Total Amount:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(997, 685)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(264, 58)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPaySuccessful
        '
        Me.btnPaySuccessful.BackColor = System.Drawing.Color.Green
        Me.btnPaySuccessful.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaySuccessful.ForeColor = System.Drawing.Color.White
        Me.btnPaySuccessful.Location = New System.Drawing.Point(1331, 685)
        Me.btnPaySuccessful.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPaySuccessful.Name = "btnPaySuccessful"
        Me.btnPaySuccessful.Size = New System.Drawing.Size(264, 58)
        Me.btnPaySuccessful.TabIndex = 3
        Me.btnPaySuccessful.Text = "&Pay Successful"
        Me.btnPaySuccessful.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Touch n Go e-wallet Payment"
        '
        'tbMasterCard
        '
        Me.tbMasterCard.AutoScroll = True
        Me.tbMasterCard.BackColor = System.Drawing.Color.LightCoral
        Me.tbMasterCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbMasterCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbMasterCard.Controls.Add(Me.GroupBox3)
        Me.tbMasterCard.Controls.Add(Me.lblTotalAmount)
        Me.tbMasterCard.Controls.Add(Me.Label4)
        Me.tbMasterCard.Controls.Add(Me.dgvMasterCard)
        Me.tbMasterCard.Controls.Add(Me.Label7)
        Me.tbMasterCard.Controls.Add(Me.lblMembershipName2)
        Me.tbMasterCard.Controls.Add(Me.Label9)
        Me.tbMasterCard.Controls.Add(Me.lblMembershipID2)
        Me.tbMasterCard.Controls.Add(Me.Label1)
        Me.tbMasterCard.Controls.Add(Me.PictureBox2)
        Me.tbMasterCard.Controls.Add(Me.Panel2)
        Me.tbMasterCard.Location = New System.Drawing.Point(4, 64)
        Me.tbMasterCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMasterCard.Name = "tbMasterCard"
        Me.tbMasterCard.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMasterCard.Size = New System.Drawing.Size(1622, 855)
        Me.tbMasterCard.TabIndex = 1
        Me.tbMasterCard.Text = "Master Card "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.btnCancelMaster)
        Me.GroupBox3.Controls.Add(Me.btnSubmit)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(483, 714)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(725, 478)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        '
        'btnCancelMaster
        '
        Me.btnCancelMaster.BackColor = System.Drawing.Color.Red
        Me.btnCancelMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelMaster.ForeColor = System.Drawing.Color.White
        Me.btnCancelMaster.Location = New System.Drawing.Point(48, 386)
        Me.btnCancelMaster.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelMaster.Name = "btnCancelMaster"
        Me.btnCancelMaster.Size = New System.Drawing.Size(264, 58)
        Me.btnCancelMaster.TabIndex = 6
        Me.btnCancelMaster.Text = "&Cancel"
        Me.btnCancelMaster.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(417, 386)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(264, 58)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49686!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50315!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCardHolder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mskCardNumber, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.mskCVV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(45, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.57971!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.42029!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(636, 180)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(166, 25)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Cardholder Name"
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Location = New System.Drawing.Point(3, 38)
        Me.txtCardHolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(413, 30)
        Me.txtCardHolder.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(444, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 25)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "CVV"
        '
        'mskCardNumber
        '
        Me.mskCardNumber.Location = New System.Drawing.Point(3, 133)
        Me.mskCardNumber.Mask = "0000000000000000"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(413, 30)
        Me.mskCardNumber.TabIndex = 5
        '
        'mskCVV
        '
        Me.mskCVV.Location = New System.Drawing.Point(444, 39)
        Me.mskCVV.Mask = "000"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(100, 30)
        Me.mskCVV.TabIndex = 6
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(3, 89)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 25)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Card Number"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbExpirationMonth, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbExpirationYear, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label33, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblExpirationDate, 3, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(45, 229)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(636, 108)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'cmbExpirationMonth
        '
        Me.cmbExpirationMonth.FormattingEnabled = True
        Me.cmbExpirationMonth.Location = New System.Drawing.Point(3, 56)
        Me.cmbExpirationMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbExpirationMonth.Name = "cmbExpirationMonth"
        Me.cmbExpirationMonth.Size = New System.Drawing.Size(129, 33)
        Me.cmbExpirationMonth.TabIndex = 7
        '
        'cmbExpirationYear
        '
        Me.cmbExpirationYear.FormattingEnabled = True
        Me.cmbExpirationYear.Location = New System.Drawing.Point(165, 56)
        Me.cmbExpirationYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbExpirationYear.Name = "cmbExpirationYear"
        Me.cmbExpirationYear.Size = New System.Drawing.Size(95, 33)
        Me.cmbExpirationYear.TabIndex = 8
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(144, 25)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Expiration Date"
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.BackColor = System.Drawing.Color.White
        Me.lblExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpirationDate.Location = New System.Drawing.Point(307, 54)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(130, 35)
        Me.lblExpirationDate.TabIndex = 10
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(1337, 588)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(235, 40)
        Me.lblTotalAmount.TabIndex = 97
        Me.lblTotalAmount.Text = "lblTotalAmount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1074, 588)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 38)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Total Amount:"
        '
        'dgvMasterCard
        '
        Me.dgvMasterCard.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMasterCard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMasterCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterCard.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvMasterCard.Location = New System.Drawing.Point(13, 141)
        Me.dgvMasterCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvMasterCard.Name = "dgvMasterCard"
        Me.dgvMasterCard.ReadOnly = True
        Me.dgvMasterCard.RowHeadersWidth = 20
        Me.dgvMasterCard.RowTemplate.Height = 24
        Me.dgvMasterCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMasterCard.Size = New System.Drawing.Size(1561, 411)
        Me.dgvMasterCard.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(1206, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 32)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Name              :"
        '
        'lblMembershipName2
        '
        Me.lblMembershipName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembershipName2.AutoSize = True
        Me.lblMembershipName2.BackColor = System.Drawing.Color.LightCyan
        Me.lblMembershipName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipName2.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipName2.Location = New System.Drawing.Point(1425, 86)
        Me.lblMembershipName2.Name = "lblMembershipName2"
        Me.lblMembershipName2.Size = New System.Drawing.Size(2, 27)
        Me.lblMembershipName2.TabIndex = 93
        Me.lblMembershipName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(1206, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(213, 32)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Membership ID:"
        '
        'lblMembershipID2
        '
        Me.lblMembershipID2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembershipID2.AutoSize = True
        Me.lblMembershipID2.BackColor = System.Drawing.Color.LightCyan
        Me.lblMembershipID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMembershipID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipID2.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipID2.Location = New System.Drawing.Point(1425, 41)
        Me.lblMembershipID2.Name = "lblMembershipID2"
        Me.lblMembershipID2.Size = New System.Drawing.Size(2, 27)
        Me.lblMembershipID2.TabIndex = 91
        Me.lblMembershipID2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 38)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Master Card Payment"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Apparel_Shop_System.My.Resources.Resources.png_transparent_mastercard_credit_card_business_debit_card_logo_mastercard_text_service_orange
        Me.PictureBox2.Location = New System.Drawing.Point(386, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 1192)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1591, 100)
        Me.Panel2.TabIndex = 85
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.tabPaymentMethod)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaymentMethod.ResumeLayout(False)
        Me.tbTouchNgo.ResumeLayout(False)
        Me.tbTouchNgo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMasterCard.ResumeLayout(False)
        Me.tbMasterCard.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvMasterCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents tabPaymentMethod As TabControl
    Friend WithEvents tbTouchNgo As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMembershipName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMembershipID As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvTng As DataGridView
    Friend WithEvents lblTotalAmount1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPaySuccessful As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMasterCard As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancelMaster As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label30 As Label
    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbExpirationMonth As ComboBox
    Friend WithEvents cmbExpirationYear As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvMasterCard As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMembershipName2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMembershipID2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
