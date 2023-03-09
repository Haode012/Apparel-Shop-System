<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffHomepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffHomepage))
        Me.panelShow = New System.Windows.Forms.Panel()
        Me.panelMenuMaintenance = New System.Windows.Forms.Panel()
        Me.lblMenuMaintenance = New System.Windows.Forms.Label()
        Me.btnMenuMaintenanceBig = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMenuMaintenance = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelShow.SuspendLayout()
        Me.panelMenuMaintenance.SuspendLayout()
        Me.leftPanel.SuspendLayout()
        Me.imagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelShow
        '
        Me.panelShow.Controls.Add(Me.panelMenuMaintenance)
        Me.panelShow.Controls.Add(Me.lblWelcome)
        Me.panelShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelShow.Location = New System.Drawing.Point(262, 10)
        Me.panelShow.Name = "panelShow"
        Me.panelShow.Size = New System.Drawing.Size(1652, 1035)
        Me.panelShow.TabIndex = 14
        '
        'panelMenuMaintenance
        '
        Me.panelMenuMaintenance.Controls.Add(Me.lblMenuMaintenance)
        Me.panelMenuMaintenance.Controls.Add(Me.btnMenuMaintenanceBig)
        Me.panelMenuMaintenance.Location = New System.Drawing.Point(916, 347)
        Me.panelMenuMaintenance.Name = "panelMenuMaintenance"
        Me.panelMenuMaintenance.Size = New System.Drawing.Size(304, 255)
        Me.panelMenuMaintenance.TabIndex = 7
        '
        'lblMenuMaintenance
        '
        Me.lblMenuMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuMaintenance.Location = New System.Drawing.Point(15, 196)
        Me.lblMenuMaintenance.Name = "lblMenuMaintenance"
        Me.lblMenuMaintenance.Size = New System.Drawing.Size(277, 36)
        Me.lblMenuMaintenance.TabIndex = 1
        Me.lblMenuMaintenance.Text = "Menu Maintenance"
        Me.lblMenuMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMenuMaintenanceBig
        '
        Me.btnMenuMaintenanceBig.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.menu_maintenance_icon_big
        Me.btnMenuMaintenanceBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenuMaintenanceBig.Location = New System.Drawing.Point(82, 33)
        Me.btnMenuMaintenanceBig.Name = "btnMenuMaintenanceBig"
        Me.btnMenuMaintenanceBig.Size = New System.Drawing.Size(141, 142)
        Me.btnMenuMaintenanceBig.TabIndex = 0
        Me.btnMenuMaintenanceBig.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(433, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(807, 165)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Staff Panel"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(262, 1045)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1652, 10)
        Me.Panel4.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(262, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1652, 10)
        Me.Panel3.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(250, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(12, 1055)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1914, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 1055)
        Me.Panel2.TabIndex = 13
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.LightCyan
        Me.leftPanel.Controls.Add(Me.btnLogOut)
        Me.leftPanel.Controls.Add(Me.btnMenuMaintenance)
        Me.leftPanel.Controls.Add(Me.btnHome)
        Me.leftPanel.Controls.Add(Me.imagePanel)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(250, 1055)
        Me.leftPanel.TabIndex = 9
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
        Me.btnLogOut.Location = New System.Drawing.Point(0, 300)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(250, 46)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "&Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnMenuMaintenance
        '
        Me.btnMenuMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMenuMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMenuMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuMaintenance.ForeColor = System.Drawing.Color.Black
        Me.btnMenuMaintenance.Image = CType(resources.GetObject("btnMenuMaintenance.Image"), System.Drawing.Image)
        Me.btnMenuMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuMaintenance.Location = New System.Drawing.Point(0, 235)
        Me.btnMenuMaintenance.Name = "btnMenuMaintenance"
        Me.btnMenuMaintenance.Size = New System.Drawing.Size(250, 65)
        Me.btnMenuMaintenance.TabIndex = 5
        Me.btnMenuMaintenance.Text = "&Menu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "maintenance"
        Me.btnMenuMaintenance.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 189)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(250, 46)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "&Home"
        Me.btnHome.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(61, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hello,"
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
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.user_icon
        Me.PictureBox1.Location = New System.Drawing.Point(80, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'StaffHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.panelShow)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.leftPanel)
        Me.MaximizeBox = False
        Me.Name = "StaffHomepage"
        Me.Text = "YJRCH Apperal Shop System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.panelShow.ResumeLayout(False)
        Me.panelMenuMaintenance.ResumeLayout(False)
        Me.leftPanel.ResumeLayout(False)
        Me.imagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelShow As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenuMaintenance As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents imagePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents panelMenuMaintenance As Panel
    Friend WithEvents lblMenuMaintenance As Label
    Friend WithEvents btnMenuMaintenanceBig As Button
End Class
