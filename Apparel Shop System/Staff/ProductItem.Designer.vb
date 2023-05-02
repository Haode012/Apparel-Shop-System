<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductItem
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnSock = New System.Windows.Forms.Button()
        Me.btnShoe = New System.Windows.Forms.Button()
        Me.btnPant = New System.Windows.Forms.Button()
        Me.btnShirt = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnPromotion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 2
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(82, 312)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1462, 590)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(185, 83)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(549, 45)
        Me.txtSearch.TabIndex = 5
        '
        'btnFemale
        '
        Me.btnFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFemale.Image = Global.Apparel_Shop_System.My.Resources.Resources.Female
        Me.btnFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFemale.Location = New System.Drawing.Point(843, 8)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(260, 54)
        Me.btnFemale.TabIndex = 13
        Me.btnFemale.Text = "For Female"
        Me.btnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'btnMale
        '
        Me.btnMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMale.Image = Global.Apparel_Shop_System.My.Resources.Resources.Male
        Me.btnMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMale.Location = New System.Drawing.Point(531, 8)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(222, 54)
        Me.btnMale.TabIndex = 12
        Me.btnMale.Text = "For Male"
        Me.btnMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnSock
        '
        Me.btnSock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSock.Image = Global.Apparel_Shop_System.My.Resources.Resources.sock
        Me.btnSock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSock.Location = New System.Drawing.Point(1033, 8)
        Me.btnSock.Name = "btnSock"
        Me.btnSock.Size = New System.Drawing.Size(186, 54)
        Me.btnSock.TabIndex = 11
        Me.btnSock.Text = "Sock"
        Me.btnSock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSock.UseVisualStyleBackColor = True
        '
        'btnShoe
        '
        Me.btnShoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShoe.Image = Global.Apparel_Shop_System.My.Resources.Resources.shoe
        Me.btnShoe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShoe.Location = New System.Drawing.Point(776, 8)
        Me.btnShoe.Name = "btnShoe"
        Me.btnShoe.Size = New System.Drawing.Size(201, 54)
        Me.btnShoe.TabIndex = 10
        Me.btnShoe.Text = "Shoe"
        Me.btnShoe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShoe.UseVisualStyleBackColor = True
        '
        'btnPant
        '
        Me.btnPant.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPant.Image = Global.Apparel_Shop_System.My.Resources.Resources.pant
        Me.btnPant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPant.Location = New System.Drawing.Point(551, 8)
        Me.btnPant.Name = "btnPant"
        Me.btnPant.Size = New System.Drawing.Size(189, 54)
        Me.btnPant.TabIndex = 9
        Me.btnPant.Text = "Pant"
        Me.btnPant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPant.UseVisualStyleBackColor = True
        '
        'btnShirt
        '
        Me.btnShirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShirt.Image = Global.Apparel_Shop_System.My.Resources.Resources.shirt
        Me.btnShirt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShirt.Location = New System.Drawing.Point(350, 8)
        Me.btnShirt.Name = "btnShirt"
        Me.btnShirt.Size = New System.Drawing.Size(173, 54)
        Me.btnShirt.TabIndex = 8
        Me.btnShirt.Text = "Shirt"
        Me.btnShirt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShirt.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.search_icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(726, 83)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(51, 45)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSock)
        Me.Panel2.Controls.Add(Me.btnShirt)
        Me.Panel2.Controls.Add(Me.btnPant)
        Me.Panel2.Controls.Add(Me.btnShoe)
        Me.Panel2.Location = New System.Drawing.Point(36, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1580, 67)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCyan
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnMale)
        Me.Panel3.Controls.Add(Me.btnFemale)
        Me.Panel3.Location = New System.Drawing.Point(36, 223)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1580, 67)
        Me.Panel3.TabIndex = 15
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Transparent
        Me.btnDisplay.Location = New System.Drawing.Point(1315, 83)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(301, 54)
        Me.btnDisplay.TabIndex = 41
        Me.btnDisplay.Text = "&Display All Products"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnPromotion
        '
        Me.btnPromotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromotion.ForeColor = System.Drawing.Color.Transparent
        Me.btnPromotion.Location = New System.Drawing.Point(895, 83)
        Me.btnPromotion.Name = "btnPromotion"
        Me.btnPromotion.Size = New System.Drawing.Size(414, 54)
        Me.btnPromotion.TabIndex = 42
        Me.btnPromotion.Text = "&Display Promotion Products"
        Me.btnPromotion.UseVisualStyleBackColor = False
        '
        'ProductItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.btnPromotion)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductItem"
        Me.Text = "MenuItem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnShirt As Button
    Friend WithEvents btnPant As Button
    Friend WithEvents btnShoe As Button
    Friend WithEvents btnSock As Button
    Friend WithEvents btnMale As Button
    Friend WithEvents btnFemale As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnPromotion As Button
End Class
