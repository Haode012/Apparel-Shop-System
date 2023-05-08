<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromotionMaintenance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromotionMaintenance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCountRecord = New System.Windows.Forms.Label()
        Me.docsPromotion = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.dgvPromotionList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.cboPromotionStatus = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.ApparelShopSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparelShopSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 4
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
        Me.lblWelcome.Location = New System.Drawing.Point(319, 81)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1091, 113)
        Me.lblWelcome.TabIndex = 62
        Me.lblWelcome.Text = "Promotion Maintenance"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(100, 245)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(156, 70)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "CREATE"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblCountRecord
        '
        Me.lblCountRecord.AutoSize = True
        Me.lblCountRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCountRecord.Location = New System.Drawing.Point(1391, 865)
        Me.lblCountRecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountRecord.Name = "lblCountRecord"
        Me.lblCountRecord.Size = New System.Drawing.Size(164, 25)
        Me.lblCountRecord.TabIndex = 69
        Me.lblCountRecord.Text = "X record(s) found"
        '
        'docsPromotion
        '
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.Visible = False
        '
        'dgvPromotionList
        '
        Me.dgvPromotionList.AllowUserToAddRows = False
        Me.dgvPromotionList.AllowUserToDeleteRows = False
        Me.dgvPromotionList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPromotionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPromotionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotionList.Location = New System.Drawing.Point(100, 330)
        Me.dgvPromotionList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPromotionList.Name = "dgvPromotionList"
        Me.dgvPromotionList.ReadOnly = True
        Me.dgvPromotionList.RowHeadersWidth = 51
        Me.dgvPromotionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPromotionList.Size = New System.Drawing.Size(1455, 531)
        Me.dgvPromotionList.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(800, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Status:"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(408, 269)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(292, 30)
        Me.txtSearchBox.TabIndex = 73
        '
        'cboPromotionStatus
        '
        Me.cboPromotionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPromotionStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPromotionStatus.FormattingEnabled = True
        Me.cboPromotionStatus.Items.AddRange(New Object() {"All", "Pending", "Started", "Ended"})
        Me.cboPromotionStatus.Location = New System.Drawing.Point(880, 266)
        Me.cboPromotionStatus.Name = "cboPromotionStatus"
        Me.cboPromotionStatus.Size = New System.Drawing.Size(216, 33)
        Me.cboPromotionStatus.TabIndex = 74
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Apparel_Shop_System.My.Resources.Resources.refresh_icon
        Me.btnRefresh.Location = New System.Drawing.Point(1130, 257)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(54, 49)
        Me.btnRefresh.TabIndex = 75
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.AutoSize = True
        Me.Button18.Image = Global.Apparel_Shop_System.My.Resources.Resources.print_FILL0_wght400_GRAD0_opsz48
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.Location = New System.Drawing.Point(1444, 257)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(111, 54)
        Me.Button18.TabIndex = 70
        Me.Button18.Text = "&Print"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button18.UseVisualStyleBackColor = True
        '
        'PromotionMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cboPromotionStatus)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPromotionList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.lblCountRecord)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PromotionMaintenance"
        Me.Text = "m"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparelShopSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents lblCountRecord As Label
    Friend WithEvents ApparelShopSystemDataSetBindingSource As BindingSource
    Friend WithEvents docsPromotion As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents dgvPromotionList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents cboPromotionStatus As ComboBox
    Friend WithEvents btnRefresh As Button
End Class
