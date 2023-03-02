<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMaintenance
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
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.cmbProductCategory = New System.Windows.Forms.ComboBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnChoose = New System.Windows.Forms.Button()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picDelete
        '
        Me.picDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.picDelete.Image = Global.Apparel_Shop_System.My.Resources.Resources.close
        Me.picDelete.Location = New System.Drawing.Point(1548, 0)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(46, 46)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 0
        Me.picDelete.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1594, 46)
        Me.Panel1.TabIndex = 3
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(392, 119)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 6
        Me.lblWelcome.Text = "Menu Maintenance"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product ID:"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(443, 13)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 45)
        Me.txtProductID.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(443, 70)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(248, 45)
        Me.txtProductName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 38)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Product Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 38)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Product Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 38)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 38)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Product Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 38)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Product Stock:"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(443, 140)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(98, 36)
        Me.radMale.TabIndex = 16
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(547, 140)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(131, 36)
        Me.radFemale.TabIndex = 17
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'cmbProductCategory
        '
        Me.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductCategory.FormattingEnabled = True
        Me.cmbProductCategory.Items.AddRange(New Object() {"Shirt", "Pant", "Shoe", "Sock"})
        Me.cmbProductCategory.Location = New System.Drawing.Point(443, 195)
        Me.cmbProductCategory.Name = "cmbProductCategory"
        Me.cmbProductCategory.Size = New System.Drawing.Size(248, 39)
        Me.cmbProductCategory.TabIndex = 18
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(445, 250)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(248, 45)
        Me.txtProductDescription.TabIndex = 19
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductPrice.Location = New System.Drawing.Point(445, 309)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(100, 45)
        Me.txtProductPrice.TabIndex = 20
        '
        'txtProductStock
        '
        Me.txtProductStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductStock.Location = New System.Drawing.Point(445, 363)
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.Size = New System.Drawing.Size(100, 45)
        Me.txtProductStock.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 38)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Product Image:"
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(604, 433)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(279, 218)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 23
        Me.picImage.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnChoose)
        Me.Panel2.Controls.Add(Me.picImage)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtProductStock)
        Me.Panel2.Controls.Add(Me.txtProductPrice)
        Me.Panel2.Controls.Add(Me.txtProductDescription)
        Me.Panel2.Controls.Add(Me.cmbProductCategory)
        Me.Panel2.Controls.Add(Me.radFemale)
        Me.Panel2.Controls.Add(Me.radMale)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtProductID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(155, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1335, 665)
        Me.Panel2.TabIndex = 8
        '
        'btnChoose
        '
        Me.btnChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.Location = New System.Drawing.Point(443, 433)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(142, 70)
        Me.btnChoose.TabIndex = 24
        Me.btnChoose.Text = "&Choose an Image"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'MenuMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1594, 919)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuMaintenance"
        Me.Text = "MenuMaintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents picImage As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnChoose As Button
End Class
