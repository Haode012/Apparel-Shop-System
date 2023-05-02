<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStaffDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStaffDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStaffDob = New System.Windows.Forms.TextBox()
        Me.txtStaffJoinedDate = New System.Windows.Forms.TextBox()
        Me.txtStaffPosition = New System.Windows.Forms.TextBox()
        Me.cbStaffMembers = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboStaffPosition = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpStaffJoinedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStaffPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStaffHomeAddress = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.txtStaffIc = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 6
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
        Me.lblWelcome.Location = New System.Drawing.Point(0, 49)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1651, 146)
        Me.lblWelcome.TabIndex = 37
        Me.lblWelcome.Text = "Update Staff Details"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStaffDob)
        Me.GroupBox1.Controls.Add(Me.txtStaffJoinedDate)
        Me.GroupBox1.Controls.Add(Me.txtStaffPosition)
        Me.GroupBox1.Controls.Add(Me.cbStaffMembers)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.comboStaffPosition)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStaffID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpStaffJoinedDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStaffPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtStaffHomeAddress)
        Me.GroupBox1.Controls.Add(Me.txtStaffName)
        Me.GroupBox1.Controls.Add(Me.dtpDob)
        Me.GroupBox1.Controls.Add(Me.txtStaffIc)
        Me.GroupBox1.Location = New System.Drawing.Point(403, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1221, 718)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'txtStaffDob
        '
        Me.txtStaffDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffDob.Location = New System.Drawing.Point(361, 233)
        Me.txtStaffDob.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffDob.Name = "txtStaffDob"
        Me.txtStaffDob.ReadOnly = True
        Me.txtStaffDob.Size = New System.Drawing.Size(311, 45)
        Me.txtStaffDob.TabIndex = 64
        '
        'txtStaffJoinedDate
        '
        Me.txtStaffJoinedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffJoinedDate.Location = New System.Drawing.Point(361, 501)
        Me.txtStaffJoinedDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffJoinedDate.Name = "txtStaffJoinedDate"
        Me.txtStaffJoinedDate.ReadOnly = True
        Me.txtStaffJoinedDate.Size = New System.Drawing.Size(322, 45)
        Me.txtStaffJoinedDate.TabIndex = 63
        '
        'txtStaffPosition
        '
        Me.txtStaffPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPosition.Location = New System.Drawing.Point(361, 562)
        Me.txtStaffPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffPosition.Name = "txtStaffPosition"
        Me.txtStaffPosition.ReadOnly = True
        Me.txtStaffPosition.Size = New System.Drawing.Size(322, 45)
        Me.txtStaffPosition.TabIndex = 61
        '
        'cbStaffMembers
        '
        Me.cbStaffMembers.FormattingEnabled = True
        Me.cbStaffMembers.Location = New System.Drawing.Point(361, 42)
        Me.cbStaffMembers.Name = "cbStaffMembers"
        Me.cbStaffMembers.Size = New System.Drawing.Size(290, 24)
        Me.cbStaffMembers.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 37)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Select Staff:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Staff IC No:"
        '
        'comboStaffPosition
        '
        Me.comboStaffPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboStaffPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStaffPosition.FormattingEnabled = True
        Me.comboStaffPosition.Items.AddRange(New Object() {"Admin", "Cashier", "Salesperson", "Janitor", ""})
        Me.comboStaffPosition.Location = New System.Drawing.Point(876, 562)
        Me.comboStaffPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.comboStaffPosition.Name = "comboStaffPosition"
        Me.comboStaffPosition.Size = New System.Drawing.Size(322, 33)
        Me.comboStaffPosition.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 37)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Staff Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 574)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 37)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Staff Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 37)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Staff Date Of Birth:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(361, 636)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 53)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Update Staff Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(313, 37)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Staff Home Address:"
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(361, 436)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(322, 45)
        Me.txtStaffID.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 37)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Staff Phone Number:"
        '
        'dtpStaffJoinedDate
        '
        Me.dtpStaffJoinedDate.Location = New System.Drawing.Point(876, 508)
        Me.dtpStaffJoinedDate.MaximumSize = New System.Drawing.Size(400, 200)
        Me.dtpStaffJoinedDate.MinimumSize = New System.Drawing.Size(40, 40)
        Me.dtpStaffJoinedDate.Name = "dtpStaffJoinedDate"
        Me.dtpStaffJoinedDate.Size = New System.Drawing.Size(322, 40)
        Me.dtpStaffJoinedDate.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 37)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Staff ID:"
        '
        'txtStaffPhoneNumber
        '
        Me.txtStaffPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPhoneNumber.Location = New System.Drawing.Point(361, 369)
        Me.txtStaffPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffPhoneNumber.Name = "txtStaffPhoneNumber"
        Me.txtStaffPhoneNumber.Size = New System.Drawing.Size(322, 45)
        Me.txtStaffPhoneNumber.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 506)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(271, 37)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Staff Joined Date:"
        '
        'txtStaffHomeAddress
        '
        Me.txtStaffHomeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffHomeAddress.Location = New System.Drawing.Point(361, 291)
        Me.txtStaffHomeAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffHomeAddress.Name = "txtStaffHomeAddress"
        Me.txtStaffHomeAddress.Size = New System.Drawing.Size(472, 45)
        Me.txtStaffHomeAddress.TabIndex = 47
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(361, 93)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(322, 45)
        Me.txtStaffName.TabIndex = 44
        '
        'dtpDob
        '
        Me.dtpDob.Location = New System.Drawing.Point(876, 235)
        Me.dtpDob.MaximumSize = New System.Drawing.Size(400, 200)
        Me.dtpDob.MinimumSize = New System.Drawing.Size(40, 40)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(322, 40)
        Me.dtpDob.TabIndex = 46
        '
        'txtStaffIc
        '
        Me.txtStaffIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffIc.Location = New System.Drawing.Point(361, 161)
        Me.txtStaffIc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffIc.Name = "txtStaffIc"
        Me.txtStaffIc.Size = New System.Drawing.Size(311, 45)
        Me.txtStaffIc.TabIndex = 45
        '
        'UpdateStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateStaffDetails"
        Me.Text = "UpdateStaffDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStaffDob As TextBox
    Friend WithEvents txtStaffJoinedDate As TextBox
    Friend WithEvents txtStaffPosition As TextBox
    Friend WithEvents cbStaffMembers As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comboStaffPosition As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpStaffJoinedDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStaffPhoneNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStaffHomeAddress As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents txtStaffIc As TextBox
End Class
