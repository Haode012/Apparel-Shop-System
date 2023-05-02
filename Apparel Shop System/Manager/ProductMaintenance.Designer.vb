<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductMaintenance
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 3
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
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(392, 119)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 6
        Me.lblWelcome.Text = "Product Maintenance"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(257, 483)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(276, 60)
        Me.lblDisplay.TabIndex = 11
        Me.lblDisplay.Text = "Display Product"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreate
        '
        Me.lblCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.Location = New System.Drawing.Point(727, 481)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(276, 62)
        Me.lblCreate.TabIndex = 12
        Me.lblCreate.Text = "Create Product"
        Me.lblCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUpdate
        '
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.Location = New System.Drawing.Point(241, 819)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(276, 62)
        Me.lblUpdate.TabIndex = 13
        Me.lblUpdate.Text = "Update Product"
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDelete
        '
        Me.lblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(727, 819)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(276, 62)
        Me.lblDelete.TabIndex = 14
        Me.lblDelete.Text = "Delete Product"
        Me.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReport
        '
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(1201, 631)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(276, 62)
        Me.lblReport.TabIndex = 16
        Me.lblReport.Text = "Product Report"
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReport
        '
        Me.btnReport.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.product_report
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.Location = New System.Drawing.Point(1224, 409)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(227, 219)
        Me.btnReport.TabIndex = 15
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.delete_product
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(754, 597)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(227, 219)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.update_product
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Location = New System.Drawing.Point(263, 597)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(227, 219)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.create_product
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreate.Location = New System.Drawing.Point(754, 261)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(227, 219)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.display_product
        Me.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDisplay.Location = New System.Drawing.Point(278, 261)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(227, 219)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'ProductMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductMaintenance"
        Me.Text = "MenuMaintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblCreate As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lblDelete As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents lblReport As Label
End Class
