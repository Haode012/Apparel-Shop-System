<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderHistory))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtgAllOrder = New System.Windows.Forms.DataGridView()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnDisplayOrder = New System.Windows.Forms.Button()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearchOrder = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgAllOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(1076, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'dtgAllOrder
        '
        Me.dtgAllOrder.AllowUserToAddRows = False
        Me.dtgAllOrder.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgAllOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAllOrder.Location = New System.Drawing.Point(176, 435)
        Me.dtgAllOrder.Name = "dtgAllOrder"
        Me.dtgAllOrder.RowHeadersWidth = 51
        Me.dtgAllOrder.RowTemplate.Height = 24
        Me.dtgAllOrder.Size = New System.Drawing.Size(1334, 463)
        Me.dtgAllOrder.TabIndex = 120
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(379, 81)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 121
        Me.lblWelcome.Text = "Order History"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplayOrder
        '
        Me.btnDisplayOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayOrder.ForeColor = System.Drawing.Color.Transparent
        Me.btnDisplayOrder.Location = New System.Drawing.Point(1181, 314)
        Me.btnDisplayOrder.Name = "btnDisplayOrder"
        Me.btnDisplayOrder.Size = New System.Drawing.Size(329, 65)
        Me.btnDisplayOrder.TabIndex = 122
        Me.btnDisplayOrder.Text = "&Display All Orders"
        Me.btnDisplayOrder.UseVisualStyleBackColor = False
        '
        'lblTotalCount
        '
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(171, 901)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(354, 27)
        Me.lblTotalCount.TabIndex = 123
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picBack)
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 125
        '
        'txtSearchOrder
        '
        Me.txtSearchOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchOrder.Location = New System.Drawing.Point(316, 10)
        Me.txtSearchOrder.Name = "txtSearchOrder"
        Me.txtSearchOrder.Size = New System.Drawing.Size(425, 45)
        Me.txtSearchOrder.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 32)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Product name :"
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Apparel_Shop_System.My.Resources.Resources.search_icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(690, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(51, 45)
        Me.btnSearch.TabIndex = 121
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(316, 130)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(425, 39)
        Me.cmbStatus.TabIndex = 123
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPaymentMethod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSearchOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(382, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 212)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(316, 76)
        Me.cmbPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(425, 39)
        Me.cmbPaymentMethod.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 32)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Payment method :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Status :"
        '
        'OrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotalCount)
        Me.Controls.Add(Me.btnDisplayOrder)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.dtgAllOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderHistory"
        Me.Text = "OrderHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgAllOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtgAllOrder As DataGridView
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDisplayOrder As Button
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchOrder As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
