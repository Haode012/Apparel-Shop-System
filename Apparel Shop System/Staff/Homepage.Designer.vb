<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnChangeSecret = New System.Windows.Forms.Button()
        Me.btnChangePassowrd = New System.Windows.Forms.Button()
        Me.btnOrderHistory = New System.Windows.Forms.Button()
        Me.btnMyCart = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnMembership = New System.Windows.Forms.Button()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelShow = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.leftPanel.SuspendLayout()
        Me.imagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelShow.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.LightCyan
        Me.leftPanel.Controls.Add(Me.btnLogOut)
        Me.leftPanel.Controls.Add(Me.btnChangeSecret)
        Me.leftPanel.Controls.Add(Me.btnChangePassowrd)
        Me.leftPanel.Controls.Add(Me.btnOrderHistory)
        Me.leftPanel.Controls.Add(Me.btnMyCart)
        Me.leftPanel.Controls.Add(Me.btnProduct)
        Me.leftPanel.Controls.Add(Me.btnMembership)
        Me.leftPanel.Controls.Add(Me.imagePanel)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(250, 1055)
        Me.leftPanel.TabIndex = 2
        '
        'btnLogOut
        '
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Image = Global.Apparel_Shop_System.My.Resources.Resources.log_out_icon
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 526)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(250, 46)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "&Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnChangeSecret
        '
        Me.btnChangeSecret.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangeSecret.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnChangeSecret.FlatAppearance.BorderSize = 0
        Me.btnChangeSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeSecret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeSecret.ForeColor = System.Drawing.Color.Black
        Me.btnChangeSecret.Image = Global.Apparel_Shop_System.My.Resources.Resources.secret_icon
        Me.btnChangeSecret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeSecret.Location = New System.Drawing.Point(0, 442)
        Me.btnChangeSecret.Name = "btnChangeSecret"
        Me.btnChangeSecret.Size = New System.Drawing.Size(250, 84)
        Me.btnChangeSecret.TabIndex = 21
        Me.btnChangeSecret.Text = "C&hange Secret " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Question " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        Me.btnChangeSecret.UseVisualStyleBackColor = True
        '
        'btnChangePassowrd
        '
        Me.btnChangePassowrd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangePassowrd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnChangePassowrd.FlatAppearance.BorderSize = 0
        Me.btnChangePassowrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassowrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassowrd.ForeColor = System.Drawing.Color.Black
        Me.btnChangePassowrd.Image = Global.Apparel_Shop_System.My.Resources.Resources.change_password_icon1
        Me.btnChangePassowrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassowrd.Location = New System.Drawing.Point(0, 373)
        Me.btnChangePassowrd.Name = "btnChangePassowrd"
        Me.btnChangePassowrd.Size = New System.Drawing.Size(250, 69)
        Me.btnChangePassowrd.TabIndex = 20
        Me.btnChangePassowrd.Text = "&Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.btnChangePassowrd.UseVisualStyleBackColor = True
        '
        'btnOrderHistory
        '
        Me.btnOrderHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrderHistory.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOrderHistory.FlatAppearance.BorderSize = 0
        Me.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderHistory.ForeColor = System.Drawing.Color.Black
        Me.btnOrderHistory.Image = Global.Apparel_Shop_System.My.Resources.Resources.order_history_icon
        Me.btnOrderHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderHistory.Location = New System.Drawing.Point(0, 327)
        Me.btnOrderHistory.Name = "btnOrderHistory"
        Me.btnOrderHistory.Size = New System.Drawing.Size(250, 46)
        Me.btnOrderHistory.TabIndex = 7
        Me.btnOrderHistory.Text = "&Order History"
        Me.btnOrderHistory.UseVisualStyleBackColor = True
        '
        'btnMyCart
        '
        Me.btnMyCart.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMyCart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMyCart.FlatAppearance.BorderSize = 0
        Me.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyCart.ForeColor = System.Drawing.Color.Black
        Me.btnMyCart.Image = Global.Apparel_Shop_System.My.Resources.Resources.cart_icon
        Me.btnMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyCart.Location = New System.Drawing.Point(0, 281)
        Me.btnMyCart.Name = "btnMyCart"
        Me.btnMyCart.Size = New System.Drawing.Size(250, 46)
        Me.btnMyCart.TabIndex = 6
        Me.btnMyCart.Text = "&My Cart"
        Me.btnMyCart.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.Black
        Me.btnProduct.Image = Global.Apparel_Shop_System.My.Resources.Resources.category_icon
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.Location = New System.Drawing.Point(0, 235)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(250, 46)
        Me.btnProduct.TabIndex = 5
        Me.btnProduct.Text = "&Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnMembership
        '
        Me.btnMembership.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMembership.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMembership.FlatAppearance.BorderSize = 0
        Me.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembership.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembership.ForeColor = System.Drawing.Color.Black
        Me.btnMembership.Image = Global.Apparel_Shop_System.My.Resources.Resources.membership_icon
        Me.btnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembership.Location = New System.Drawing.Point(0, 189)
        Me.btnMembership.Name = "btnMembership"
        Me.btnMembership.Size = New System.Drawing.Size(250, 46)
        Me.btnMembership.TabIndex = 4
        Me.btnMembership.Text = "&Membership"
        Me.btnMembership.UseVisualStyleBackColor = True
        '
        'imagePanel
        '
        Me.imagePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.imagePanel.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.sky
        Me.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagePanel.Controls.Add(Me.Label1)
        Me.imagePanel.Controls.Add(Me.lblUsername)
        Me.imagePanel.Controls.Add(Me.PictureBox1)
        Me.imagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.imagePanel.Location = New System.Drawing.Point(0, 0)
        Me.imagePanel.Name = "imagePanel"
        Me.imagePanel.Size = New System.Drawing.Size(250, 189)
        Me.imagePanel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome back, Staff"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(23, 151)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(209, 24)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Staff Name"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.staff_users
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(250, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 1055)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(260, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1664, 10)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(260, 1045)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1664, 10)
        Me.Panel4.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1914, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 1035)
        Me.Panel2.TabIndex = 7
        '
        'panelShow
        '
        Me.panelShow.Controls.Add(Me.lblWelcome)
        Me.panelShow.Controls.Add(Me.PictureBox2)
        Me.panelShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelShow.Location = New System.Drawing.Point(260, 10)
        Me.panelShow.Name = "panelShow"
        Me.panelShow.Size = New System.Drawing.Size(1654, 1035)
        Me.panelShow.TabIndex = 8
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(136, 318)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1381, 398)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome to YJRCH Apperal Shop System"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Apparel_Shop_System.My.Resources.Resources.apperal_shop
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1654, 1035)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.panelShow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.leftPanel)
        Me.MaximizeBox = False
        Me.Name = "Homepage"
        Me.Text = "YJRCH Apperal Shop System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.leftPanel.ResumeLayout(False)
        Me.imagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelShow.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As Panel
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents imagePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelShow As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMyCart As Button
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnChangeSecret As Button
    Friend WithEvents btnChangePassowrd As Button
End Class
