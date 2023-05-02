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
        Me.tabPaymentMethod = New System.Windows.Forms.TabControl()
        Me.tbTouchNgo = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMembershipName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMembershipID = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgvTng = New System.Windows.Forms.DataGridView()
        Me.lblTotalAmount1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPaySuccessful = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMasterCard = New System.Windows.Forms.TabPage()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMasterCard = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.tabPaymentMethod.SuspendLayout()
        Me.tbTouchNgo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMasterCard.SuspendLayout()
        CType(Me.dgvMasterCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPaymentMethod
        '
        Me.tabPaymentMethod.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabPaymentMethod.Controls.Add(Me.tbTouchNgo)
        Me.tabPaymentMethod.Controls.Add(Me.tbMasterCard)
        Me.tabPaymentMethod.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.tabPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabPaymentMethod.ItemSize = New System.Drawing.Size(150, 60)
        Me.tabPaymentMethod.Location = New System.Drawing.Point(12, 76)
        Me.tabPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPaymentMethod.Multiline = True
        Me.tabPaymentMethod.Name = "tabPaymentMethod"
        Me.tabPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabPaymentMethod.SelectedIndex = 0
        Me.tabPaymentMethod.Size = New System.Drawing.Size(1654, 1035)
        Me.tabPaymentMethod.TabIndex = 8
        '
        'tbTouchNgo
        '
        Me.tbTouchNgo.AutoScroll = True
        Me.tbTouchNgo.BackColor = System.Drawing.Color.DodgerBlue
        Me.tbTouchNgo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbTouchNgo.Controls.Add(Me.Label5)
        Me.tbTouchNgo.Controls.Add(Me.lblMembershipName)
        Me.tbTouchNgo.Controls.Add(Me.Label3)
        Me.tbTouchNgo.Controls.Add(Me.lblMembershipID)
        Me.tbTouchNgo.Controls.Add(Me.PictureBox3)
        Me.tbTouchNgo.Controls.Add(Me.dgvTng)
        Me.tbTouchNgo.Controls.Add(Me.lblTotalAmount1)
        Me.tbTouchNgo.Controls.Add(Me.Panel1)
        Me.tbTouchNgo.Controls.Add(Me.Label6)
        Me.tbTouchNgo.Controls.Add(Me.Button2)
        Me.tbTouchNgo.Controls.Add(Me.btnPaySuccessful)
        Me.tbTouchNgo.Controls.Add(Me.PictureBox1)
        Me.tbTouchNgo.Controls.Add(Me.Label2)
        Me.tbTouchNgo.Location = New System.Drawing.Point(4, 64)
        Me.tbTouchNgo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbTouchNgo.Name = "tbTouchNgo"
        Me.tbTouchNgo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbTouchNgo.Size = New System.Drawing.Size(1646, 967)
        Me.tbTouchNgo.TabIndex = 0
        Me.tbTouchNgo.Text = "Touch'n GO E-wallet"
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
        Me.lblMembershipName.Size = New System.Drawing.Size(173, 27)
        Me.lblMembershipName.TabIndex = 79
        Me.lblMembershipName.Text = "membershipName"
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
        Me.lblMembershipID.Size = New System.Drawing.Size(140, 27)
        Me.lblMembershipID.TabIndex = 77
        Me.lblMembershipID.Text = "membershipID"
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
        Me.dgvTng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTng.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvTng.Location = New System.Drawing.Point(13, 91)
        Me.dgvTng.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTng.Name = "dgvTng"
        Me.dgvTng.ReadOnly = True
        Me.dgvTng.RowHeadersWidth = 20
        Me.dgvTng.RowTemplate.Height = 24
        Me.dgvTng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTng.Size = New System.Drawing.Size(857, 583)
        Me.dgvTng.TabIndex = 61
        '
        'lblTotalAmount1
        '
        Me.lblTotalAmount1.AutoSize = True
        Me.lblTotalAmount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount1.ForeColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount1.Location = New System.Drawing.Point(297, 718)
        Me.lblTotalAmount1.Name = "lblTotalAmount1"
        Me.lblTotalAmount1.Size = New System.Drawing.Size(235, 40)
        Me.lblTotalAmount1.TabIndex = 51
        Me.lblTotalAmount1.Text = "lblTotalAmount"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 861)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1636, 100)
        Me.Panel1.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(35, 718)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 38)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Total Amount:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(917, 698)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 58)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPaySuccessful
        '
        Me.btnPaySuccessful.BackColor = System.Drawing.Color.Green
        Me.btnPaySuccessful.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaySuccessful.ForeColor = System.Drawing.Color.White
        Me.btnPaySuccessful.Location = New System.Drawing.Point(1236, 698)
        Me.btnPaySuccessful.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPaySuccessful.Name = "btnPaySuccessful"
        Me.btnPaySuccessful.Size = New System.Drawing.Size(264, 58)
        Me.btnPaySuccessful.TabIndex = 3
        Me.btnPaySuccessful.Text = "&Pay Successful"
        Me.btnPaySuccessful.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.tng_example_QR
        Me.PictureBox1.Location = New System.Drawing.Point(917, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 551)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.tbMasterCard.Controls.Add(Me.lblTotalAmount)
        Me.tbMasterCard.Controls.Add(Me.Label4)
        Me.tbMasterCard.Controls.Add(Me.dgvMasterCard)
        Me.tbMasterCard.Controls.Add(Me.Panel2)
        Me.tbMasterCard.Controls.Add(Me.GroupBox3)
        Me.tbMasterCard.Controls.Add(Me.Label1)
        Me.tbMasterCard.Controls.Add(Me.PictureBox2)
        Me.tbMasterCard.Location = New System.Drawing.Point(4, 64)
        Me.tbMasterCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMasterCard.Name = "tbMasterCard"
        Me.tbMasterCard.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMasterCard.Size = New System.Drawing.Size(1646, 967)
        Me.tbMasterCard.TabIndex = 1
        Me.tbMasterCard.Text = "Master Card "
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(420, 689)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(235, 40)
        Me.lblTotalAmount.TabIndex = 77
        Me.lblTotalAmount.Text = "lblTotalAmount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 689)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 38)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Total Amount:"
        '
        'dgvMasterCard
        '
        Me.dgvMasterCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterCard.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvMasterCard.Location = New System.Drawing.Point(15, 82)
        Me.dgvMasterCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvMasterCard.Name = "dgvMasterCard"
        Me.dgvMasterCard.ReadOnly = True
        Me.dgvMasterCard.RowHeadersWidth = 20
        Me.dgvMasterCard.RowTemplate.Height = 24
        Me.dgvMasterCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMasterCard.Size = New System.Drawing.Size(857, 583)
        Me.dgvMasterCard.TabIndex = 74
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 861)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1636, 100)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnSubmit)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(891, 82)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(725, 478)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(48, 386)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 58)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOwner, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mskCardNumber, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(45, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(636, 158)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(3, 69)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 25)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Card Number"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 25)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Owner"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(3, 38)
        Me.txtOwner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(413, 30)
        Me.txtOwner.TabIndex = 3
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
        Me.mskCardNumber.Location = New System.Drawing.Point(3, 111)
        Me.mskCardNumber.Mask = "0000 0000 0000 0000"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(413, 30)
        Me.mskCardNumber.TabIndex = 5
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(444, 39)
        Me.MaskedTextBox2.Mask = "000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 30)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.11848!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.88152!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label33, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(45, 204)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(636, 100)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 52)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(129, 33)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(162, 52)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(95, 33)
        Me.ComboBox2.TabIndex = 8
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Card Payment"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Apparel_Shop_System.My.Resources.Resources.png_transparent_mastercard_credit_card_business_debit_card_logo_mastercard_text_service_orange
        Me.PictureBox2.Location = New System.Drawing.Point(375, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
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
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tabPaymentMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabPaymentMethod.ResumeLayout(False)
        Me.tbTouchNgo.ResumeLayout(False)
        Me.tbTouchNgo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMasterCard.ResumeLayout(False)
        Me.tbMasterCard.PerformLayout()
        CType(Me.dgvMasterCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPaymentMethod As TabControl
    Friend WithEvents tbTouchNgo As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMembershipName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMembershipID As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvTng As DataGridView
    Friend WithEvents lblTotalAmount1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPaySuccessful As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMasterCard As TabPage
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvMasterCard As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtOwner As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picBack As PictureBox
End Class
