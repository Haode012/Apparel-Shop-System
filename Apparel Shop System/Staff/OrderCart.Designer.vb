﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderCart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpOrderCart = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picCancel = New System.Windows.Forms.PictureBox()
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.btnNotMembership = New System.Windows.Forms.Button()
        Me.btnPayAsMembership = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbMemberName = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.dgvOrderCart = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOrderCart.SuspendLayout()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOrderCart
        '
        Me.grpOrderCart.Controls.Add(Me.Label3)
        Me.grpOrderCart.Controls.Add(Me.picCancel)
        Me.grpOrderCart.Controls.Add(Me.lblMemberId)
        Me.grpOrderCart.Controls.Add(Me.btnNotMembership)
        Me.grpOrderCart.Controls.Add(Me.btnPayAsMembership)
        Me.grpOrderCart.Controls.Add(Me.Label10)
        Me.grpOrderCart.Controls.Add(Me.cmbMemberName)
        Me.grpOrderCart.Location = New System.Drawing.Point(274, 178)
        Me.grpOrderCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOrderCart.Name = "grpOrderCart"
        Me.grpOrderCart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOrderCart.Size = New System.Drawing.Size(1100, 168)
        Me.grpOrderCart.TabIndex = 119
        Me.grpOrderCart.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 32)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Member Id :"
        '
        'picCancel
        '
        Me.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCancel.Image = Global.Apparel_Shop_System.My.Resources.Resources.cancel_icon_new
        Me.picCancel.Location = New System.Drawing.Point(580, 35)
        Me.picCancel.Name = "picCancel"
        Me.picCancel.Size = New System.Drawing.Size(44, 41)
        Me.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCancel.TabIndex = 91
        Me.picCancel.TabStop = False
        '
        'lblMemberId
        '
        Me.lblMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.Location = New System.Drawing.Point(303, 97)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(262, 29)
        Me.lblMemberId.TabIndex = 90
        Me.lblMemberId.Text = "--"
        Me.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNotMembership
        '
        Me.btnNotMembership.BackColor = System.Drawing.Color.Red
        Me.btnNotMembership.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotMembership.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNotMembership.Location = New System.Drawing.Point(736, 94)
        Me.btnNotMembership.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNotMembership.Name = "btnNotMembership"
        Me.btnNotMembership.Size = New System.Drawing.Size(329, 65)
        Me.btnNotMembership.TabIndex = 88
        Me.btnNotMembership.Text = "&Not Membership"
        Me.btnNotMembership.UseVisualStyleBackColor = False
        '
        'btnPayAsMembership
        '
        Me.btnPayAsMembership.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPayAsMembership.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayAsMembership.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPayAsMembership.Location = New System.Drawing.Point(736, 0)
        Me.btnPayAsMembership.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayAsMembership.Name = "btnPayAsMembership"
        Me.btnPayAsMembership.Size = New System.Drawing.Size(329, 65)
        Me.btnPayAsMembership.TabIndex = 87
        Me.btnPayAsMembership.Text = "&Pay As Membership"
        Me.btnPayAsMembership.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(228, 32)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Member Name :"
        '
        'cmbMemberName
        '
        Me.cmbMemberName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMemberName.FormattingEnabled = True
        Me.cmbMemberName.Location = New System.Drawing.Point(303, 35)
        Me.cmbMemberName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMemberName.Name = "cmbMemberName"
        Me.cmbMemberName.Size = New System.Drawing.Size(262, 39)
        Me.cmbMemberName.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 115
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
        'lblTotalCount
        '
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(156, 954)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(354, 38)
        Me.lblTotalCount.TabIndex = 122
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources._335_3354780_icon_02_green_shopping_cart_icon
        Me.PictureBox1.Location = New System.Drawing.Point(1034, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 118
        Me.PictureBox1.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(378, 55)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 121
        Me.lblWelcome.Text = "Order Cart"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStock
        '
        Me.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(20, 106)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(262, 29)
        Me.lblStock.TabIndex = 120
        Me.lblStock.Text = "--"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStock.Visible = False
        '
        'dgvOrderCart
        '
        Me.dgvOrderCart.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderCart.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrderCart.Location = New System.Drawing.Point(146, 378)
        Me.dgvOrderCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOrderCart.Name = "dgvOrderCart"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderCart.RowHeadersWidth = 20
        Me.dgvOrderCart.RowTemplate.Height = 200
        Me.dgvOrderCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderCart.Size = New System.Drawing.Size(1327, 480)
        Me.dgvOrderCart.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-8, 172)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 116
        '
        'OrderCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.grpOrderCart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotalCount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.dgvOrderCart)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderCart"
        Me.Text = "OrderCart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpOrderCart.ResumeLayout(False)
        Me.grpOrderCart.PerformLayout()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOrderCart As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picCancel As PictureBox
    Friend WithEvents lblMemberId As Label
    Friend WithEvents btnNotMembership As Button
    Friend WithEvents btnPayAsMembership As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbMemberName As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents dgvOrderCart As DataGridView
    Friend WithEvents Label1 As Label
End Class
