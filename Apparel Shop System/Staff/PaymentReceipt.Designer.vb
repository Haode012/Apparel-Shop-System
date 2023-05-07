<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentReceipt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalAmount1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvReceipt = New System.Windows.Forms.DataGridView()
        Me.lblPaymentId = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.picBack)
        Me.Panel1.Controls.Add(Me.picDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 107
        '
        'lblTotalAmount1
        '
        Me.lblTotalAmount1.AutoSize = True
        Me.lblTotalAmount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount1.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAmount1.Location = New System.Drawing.Point(1279, 821)
        Me.lblTotalAmount1.Name = "lblTotalAmount1"
        Me.lblTotalAmount1.Size = New System.Drawing.Size(346, 40)
        Me.lblTotalAmount1.TabIndex = 112
        Me.lblTotalAmount1.Text = "lblTotalAmountReceipt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(941, 823)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 38)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Total Amount(RM):"
        '
        'dgvReceipt
        '
        Me.dgvReceipt.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReceipt.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvReceipt.Location = New System.Drawing.Point(150, 339)
        Me.dgvReceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReceipt.Name = "dgvReceipt"
        Me.dgvReceipt.ReadOnly = True
        Me.dgvReceipt.RowHeadersWidth = 20
        Me.dgvReceipt.RowTemplate.Height = 24
        Me.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReceipt.Size = New System.Drawing.Size(1319, 411)
        Me.dgvReceipt.TabIndex = 110
        '
        'lblPaymentId
        '
        Me.lblPaymentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentId.Location = New System.Drawing.Point(1368, 297)
        Me.lblPaymentId.Name = "lblPaymentId"
        Me.lblPaymentId.Size = New System.Drawing.Size(126, 38)
        Me.lblPaymentId.TabIndex = 109
        Me.lblPaymentId.Text = "lblPaymentId"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(387, 110)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 108
        Me.lblWelcome.Text = "Payment Receipt"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Location = New System.Drawing.Point(1198, 909)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(329, 65)
        Me.btnPrint.TabIndex = 113
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1247, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 38)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Receipt :"
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 38)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Date :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(291, 297)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 25)
        Me.lblDate.TabIndex = 115
        Me.lblDate.Text = "date"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(1279, 764)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(55, 40)
        Me.lblDiscount.TabIndex = 118
        Me.lblDiscount.Text = "20"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1033, 764)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 38)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Discount(%):"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 38)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "MemberID :"
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.Location = New System.Drawing.Point(302, 250)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(99, 25)
        Me.lblMemberId.TabIndex = 119
        Me.lblMemberId.Text = "memberId"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(430, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 38)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Member Name :"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.Location = New System.Drawing.Point(616, 250)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(135, 25)
        Me.lblMemberName.TabIndex = 121
        Me.lblMemberName.Text = "memberName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(1148, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'picBack
        '
        Me.picBack.Dock = System.Windows.Forms.DockStyle.Left
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(46, 46)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 4
        Me.picBack.TabStop = False
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
        'PaymentReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMemberName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMemberId)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotalAmount1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvReceipt)
        Me.Controls.Add(Me.lblPaymentId)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentReceipt"
        Me.Text = "PaymentReceipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblTotalAmount1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvReceipt As DataGridView
    Friend WithEvents lblPaymentId As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMemberId As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMemberName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
