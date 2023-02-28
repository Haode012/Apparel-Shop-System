<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelShirt = New System.Windows.Forms.Panel()
        Me.lblShirt = New System.Windows.Forms.Label()
        Me.panelPant = New System.Windows.Forms.Panel()
        Me.lblPant = New System.Windows.Forms.Label()
        Me.panelShoe = New System.Windows.Forms.Panel()
        Me.lblShoe = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblSock = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSock = New System.Windows.Forms.Button()
        Me.btnShoe = New System.Windows.Forms.Button()
        Me.btnPant = New System.Windows.Forms.Button()
        Me.btnShirt = New System.Windows.Forms.Button()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.panelShirt.SuspendLayout()
        Me.panelPant.SuspendLayout()
        Me.panelShoe.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1612, 46)
        Me.Panel1.TabIndex = 2
        '
        'panelShirt
        '
        Me.panelShirt.Controls.Add(Me.lblShirt)
        Me.panelShirt.Controls.Add(Me.btnShirt)
        Me.panelShirt.Location = New System.Drawing.Point(487, 223)
        Me.panelShirt.Name = "panelShirt"
        Me.panelShirt.Size = New System.Drawing.Size(304, 255)
        Me.panelShirt.TabIndex = 3
        '
        'lblShirt
        '
        Me.lblShirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShirt.Location = New System.Drawing.Point(112, 201)
        Me.lblShirt.Name = "lblShirt"
        Me.lblShirt.Size = New System.Drawing.Size(87, 36)
        Me.lblShirt.TabIndex = 1
        Me.lblShirt.Text = "Shirt"
        '
        'panelPant
        '
        Me.panelPant.Controls.Add(Me.lblPant)
        Me.panelPant.Controls.Add(Me.btnPant)
        Me.panelPant.Location = New System.Drawing.Point(906, 223)
        Me.panelPant.Name = "panelPant"
        Me.panelPant.Size = New System.Drawing.Size(304, 255)
        Me.panelPant.TabIndex = 4
        '
        'lblPant
        '
        Me.lblPant.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPant.Location = New System.Drawing.Point(112, 201)
        Me.lblPant.Name = "lblPant"
        Me.lblPant.Size = New System.Drawing.Size(87, 36)
        Me.lblPant.TabIndex = 1
        Me.lblPant.Text = "Pant"
        '
        'panelShoe
        '
        Me.panelShoe.Controls.Add(Me.lblShoe)
        Me.panelShoe.Controls.Add(Me.btnShoe)
        Me.panelShoe.Location = New System.Drawing.Point(487, 544)
        Me.panelShoe.Name = "panelShoe"
        Me.panelShoe.Size = New System.Drawing.Size(304, 255)
        Me.panelShoe.TabIndex = 5
        '
        'lblShoe
        '
        Me.lblShoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoe.Location = New System.Drawing.Point(112, 201)
        Me.lblShoe.Name = "lblShoe"
        Me.lblShoe.Size = New System.Drawing.Size(111, 36)
        Me.lblShoe.TabIndex = 1
        Me.lblShoe.Text = "Shoe"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblSock)
        Me.Panel5.Controls.Add(Me.btnSock)
        Me.Panel5.Location = New System.Drawing.Point(906, 544)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(304, 255)
        Me.Panel5.TabIndex = 6
        '
        'lblSock
        '
        Me.lblSock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSock.Location = New System.Drawing.Point(112, 201)
        Me.lblSock.Name = "lblSock"
        Me.lblSock.Size = New System.Drawing.Size(87, 36)
        Me.lblSock.TabIndex = 1
        Me.lblSock.Text = "Sock"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(636, 110)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(457, 55)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Choose a Category"
        '
        'btnSock
        '
        Me.btnSock.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.sock
        Me.btnSock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSock.Location = New System.Drawing.Point(82, 33)
        Me.btnSock.Name = "btnSock"
        Me.btnSock.Size = New System.Drawing.Size(141, 142)
        Me.btnSock.TabIndex = 0
        Me.btnSock.UseVisualStyleBackColor = True
        '
        'btnShoe
        '
        Me.btnShoe.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.shoe
        Me.btnShoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShoe.Location = New System.Drawing.Point(82, 33)
        Me.btnShoe.Name = "btnShoe"
        Me.btnShoe.Size = New System.Drawing.Size(141, 142)
        Me.btnShoe.TabIndex = 0
        Me.btnShoe.UseVisualStyleBackColor = True
        '
        'btnPant
        '
        Me.btnPant.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.pant
        Me.btnPant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPant.Location = New System.Drawing.Point(82, 33)
        Me.btnPant.Name = "btnPant"
        Me.btnPant.Size = New System.Drawing.Size(141, 142)
        Me.btnPant.TabIndex = 0
        Me.btnPant.UseVisualStyleBackColor = True
        '
        'btnShirt
        '
        Me.btnShirt.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.shirt
        Me.btnShirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShirt.Location = New System.Drawing.Point(82, 33)
        Me.btnShirt.Name = "btnShirt"
        Me.btnShirt.Size = New System.Drawing.Size(141, 142)
        Me.btnShirt.TabIndex = 0
        Me.btnShirt.UseVisualStyleBackColor = True
        '
        'picDelete
        '
        Me.picDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.picDelete.Image = Global.Apparel_Shop_System.My.Resources.Resources.close
        Me.picDelete.Location = New System.Drawing.Point(1566, 0)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(46, 46)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 0
        Me.picDelete.TabStop = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1612, 966)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panelShoe)
        Me.Controls.Add(Me.panelPant)
        Me.Controls.Add(Me.panelShirt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Category"
        Me.Text = "Category"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panelShirt.ResumeLayout(False)
        Me.panelPant.ResumeLayout(False)
        Me.panelShoe.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents panelShirt As Panel
    Friend WithEvents btnShirt As Button
    Friend WithEvents lblShirt As Label
    Friend WithEvents panelPant As Panel
    Friend WithEvents lblPant As Label
    Friend WithEvents btnPant As Button
    Friend WithEvents panelShoe As Panel
    Friend WithEvents lblShoe As Label
    Friend WithEvents btnShoe As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblSock As Label
    Friend WithEvents btnSock As Button
    Friend WithEvents lblTitle As Label
End Class
