<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffMaintenance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentStaff = New System.Drawing.Printing.PrintDocument()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.dtgAllStaff = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilterV = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDropDownList = New System.Windows.Forms.ComboBox()
        Me.c = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.imagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgAllStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.imagePanel)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 989)
        Me.Panel2.TabIndex = 59
        '
        'imagePanel
        '
        Me.imagePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagePanel.Controls.Add(Me.PictureBox1)
        Me.imagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.imagePanel.Location = New System.Drawing.Point(0, 0)
        Me.imagePanel.Name = "imagePanel"
        Me.imagePanel.Size = New System.Drawing.Size(229, 189)
        Me.imagePanel.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.user_icon
        Me.PictureBox1.Location = New System.Drawing.Point(64, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(7, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 86)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Fire Staff"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(7, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 77)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add Staff"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(7, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 90)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Edit Staff Details"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(229, 46)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1425, 107)
        Me.lblWelcome.TabIndex = 60
        Me.lblWelcome.Text = "Staff Maintenance"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.Window
        Me.Button7.Location = New System.Drawing.Point(1299, 846)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(283, 77)
        Me.Button7.TabIndex = 101
        Me.Button7.Text = "Print Staff Report"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'lblRecords
        '
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(243, 855)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(354, 38)
        Me.lblRecords.TabIndex = 100
        Me.lblRecords.Text = "Label2"
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
        'PrintDocumentStaff
        '
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'dtgAllStaff
        '
        Me.dtgAllStaff.AllowUserToAddRows = False
        Me.dtgAllStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgAllStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAllStaff.Location = New System.Drawing.Point(246, 377)
        Me.dtgAllStaff.Name = "dtgAllStaff"
        Me.dtgAllStaff.RowHeadersWidth = 51
        Me.dtgAllStaff.RowTemplate.Height = 24
        Me.dtgAllStaff.Size = New System.Drawing.Size(1334, 463)
        Me.dtgAllStaff.TabIndex = 102
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFilterV)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(622, 83)
        Me.GroupBox3.TabIndex = 106
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Staff Name:"
        '
        'txtFilterV
        '
        Me.txtFilterV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterV.Location = New System.Drawing.Point(158, 34)
        Me.txtFilterV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilterV.Name = "txtFilterV"
        Me.txtFilterV.Size = New System.Drawing.Size(292, 30)
        Me.txtFilterV.TabIndex = 77
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSearch.Location = New System.Drawing.Point(456, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(158, 37)
        Me.btnSearch.TabIndex = 80
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbDropDownList)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 100)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search By Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Staff Status:"
        '
        'cbDropDownList
        '
        Me.cbDropDownList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDropDownList.FormattingEnabled = True
        Me.cbDropDownList.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cbDropDownList.Location = New System.Drawing.Point(158, 44)
        Me.cbDropDownList.Name = "cbDropDownList"
        Me.cbDropDownList.Size = New System.Drawing.Size(292, 33)
        Me.cbDropDownList.TabIndex = 81
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.c.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.c.Location = New System.Drawing.Point(874, 324)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(169, 41)
        Me.c.TabIndex = 103
        Me.c.Text = "&Reset Changes"
        Me.c.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(887, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 100)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fired Date"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button6.Location = New System.Drawing.Point(462, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(168, 36)
        Me.Button6.TabIndex = 90
        Me.Button6.Text = "&View"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 25)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "From:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(86, 29)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(366, 30)
        Me.dtpFrom.TabIndex = 85
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(86, 64)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(366, 30)
        Me.dtpTo.TabIndex = 86
        '
        'StaffMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgAllStaff)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffMaintenance"
        Me.Text = "StaffMaintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.imagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgAllStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents imagePanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents lblRecords As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocumentStaff As Printing.PrintDocument
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents dtgAllStaff As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilterV As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDropDownList As ComboBox
    Friend WithEvents c As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
End Class
