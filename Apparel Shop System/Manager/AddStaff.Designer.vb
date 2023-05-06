<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStaff))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtIcNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtStaffSecretQuestionAns = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboSecretQues = New System.Windows.Forms.ComboBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.comboStaffPosition = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.dtpJoinedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1654, 46)
        Me.Panel1.TabIndex = 7
        '
        'mtxtPhoneNumber
        '
        Me.mtxtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.mtxtPhoneNumber.Location = New System.Drawing.Point(360, 243)
        Me.mtxtPhoneNumber.Mask = "000-00000000"
        Me.mtxtPhoneNumber.Name = "mtxtPhoneNumber"
        Me.mtxtPhoneNumber.Size = New System.Drawing.Size(588, 45)
        Me.mtxtPhoneNumber.TabIndex = 58
        '
        'mtxtIcNo
        '
        Me.mtxtIcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.mtxtIcNo.Location = New System.Drawing.Point(360, 67)
        Me.mtxtIcNo.Mask = "000000-00-0000"
        Me.mtxtIcNo.Name = "mtxtIcNo"
        Me.mtxtIcNo.Size = New System.Drawing.Size(588, 45)
        Me.mtxtIcNo.TabIndex = 57
        '
        'txtStaffSecretQuestionAns
        '
        Me.txtStaffSecretQuestionAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSecretQuestionAns.Location = New System.Drawing.Point(359, 544)
        Me.txtStaffSecretQuestionAns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffSecretQuestionAns.Name = "txtStaffSecretQuestionAns"
        Me.txtStaffSecretQuestionAns.Size = New System.Drawing.Size(588, 45)
        Me.txtStaffSecretQuestionAns.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 549)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(319, 37)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Secret Question Ans:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(254, 37)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Secret Question:"
        '
        'cboSecretQues
        '
        Me.cboSecretQues.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.cboSecretQues.FormattingEnabled = True
        Me.cboSecretQues.Items.AddRange(New Object() {"What is your favorite car ?", "What is your favorite song ?", "What is your favorite basketball team ?"})
        Me.cboSecretQues.Location = New System.Drawing.Point(360, 486)
        Me.cboSecretQues.Name = "cboSecretQues"
        Me.cboSecretQues.Size = New System.Drawing.Size(588, 46)
        Me.cboSecretQues.TabIndex = 51
        '
        'lblStaffID
        '
        Me.lblStaffID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.lblStaffID.Location = New System.Drawing.Point(360, 364)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(588, 45)
        Me.lblStaffID.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(706, 722)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 69)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 37)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "IC NO:"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(359, 722)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(241, 69)
        Me.btnCreate.TabIndex = 34
        Me.btnCreate.Text = "Create Staff"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(359, 662)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(588, 45)
        Me.txtConfirmPassword.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 662)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 37)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Confirm Password:"
        '
        'comboStaffPosition
        '
        Me.comboStaffPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboStaffPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStaffPosition.FormattingEnabled = True
        Me.comboStaffPosition.Items.AddRange(New Object() {"Manager", "Assistant Manager", "Salesperson", "Cashier", "Janitor", ""})
        Me.comboStaffPosition.Location = New System.Drawing.Point(360, 435)
        Me.comboStaffPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.comboStaffPosition.Name = "comboStaffPosition"
        Me.comboStaffPosition.Size = New System.Drawing.Size(588, 33)
        Me.comboStaffPosition.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date Of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 37)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Home Address:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(359, 605)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(588, 45)
        Me.txtPassword.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 37)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 605)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 37)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 37)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 37)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Position:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 667)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 37)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Joined Date:"
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(360, 13)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(588, 45)
        Me.txtStaffName.TabIndex = 22
        '
        'dtpJoinedDate
        '
        Me.dtpJoinedDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpJoinedDate.Location = New System.Drawing.Point(360, 307)
        Me.dtpJoinedDate.MaximumSize = New System.Drawing.Size(400, 200)
        Me.dtpJoinedDate.MinimumSize = New System.Drawing.Size(40, 40)
        Me.dtpJoinedDate.Name = "dtpJoinedDate"
        Me.dtpJoinedDate.Size = New System.Drawing.Size(400, 40)
        Me.dtpJoinedDate.TabIndex = 27
        '
        'dtpDob
        '
        Me.dtpDob.CustomFormat = "MM/dd/yyyy"
        Me.dtpDob.Location = New System.Drawing.Point(360, 129)
        Me.dtpDob.MaximumSize = New System.Drawing.Size(400, 200)
        Me.dtpDob.MinimumSize = New System.Drawing.Size(40, 40)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(400, 40)
        Me.dtpDob.TabIndex = 24
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeAddress.Location = New System.Drawing.Point(360, 182)
        Me.txtHomeAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(588, 45)
        Me.txtHomeAddress.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.mtxtPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.mtxtIcNo)
        Me.GroupBox2.Controls.Add(Me.txtStaffSecretQuestionAns)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboSecretQues)
        Me.GroupBox2.Controls.Add(Me.lblStaffID)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.comboStaffPosition)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtStaffName)
        Me.GroupBox2.Controls.Add(Me.dtpJoinedDate)
        Me.GroupBox2.Controls.Add(Me.dtpDob)
        Me.GroupBox2.Controls.Add(Me.txtHomeAddress)
        Me.GroupBox2.Location = New System.Drawing.Point(581, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1340, 934)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 49)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1654, 107)
        Me.lblWelcome.TabIndex = 51
        Me.lblWelcome.Text = "Add Staff"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.Image = Global.Apparel_Shop_System.My.Resources.Resources.add_staff
        Me.PictureBox1.Location = New System.Drawing.Point(26, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 592)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
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
        'AddStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStaff"
        Me.Text = "AddStaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents mtxtPhoneNumber As MaskedTextBox
    Friend WithEvents mtxtIcNo As MaskedTextBox
    Friend WithEvents txtStaffSecretQuestionAns As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboSecretQues As ComboBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents comboStaffPosition As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents dtpJoinedDate As DateTimePicker
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents txtHomeAddress As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblWelcome As Label
End Class
