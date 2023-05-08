<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberSearchResult2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberSearchResult2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.TxtMemberEmail = New System.Windows.Forms.TextBox()
        Me.lblSearchMemberEmail = New System.Windows.Forms.Label()
        Me.TxtMemberSearchName = New System.Windows.Forms.TextBox()
        Me.LblMemberSearchName = New System.Windows.Forms.Label()
        Me.TxtMemberRegistrationDate = New System.Windows.Forms.TextBox()
        Me.TxtSearchMemberPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtSearchMemberIC = New System.Windows.Forms.TextBox()
        Me.TxtSearchMemberID = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblSearchMemberStatus = New System.Windows.Forms.Label()
        Me.lblSearchMemberRegistrationDate = New System.Windows.Forms.Label()
        Me.lblSearchMemberPhoneNumber = New System.Windows.Forms.Label()
        Me.lblSearchMemberIC = New System.Windows.Forms.Label()
        Me.lblSearchMemberId = New System.Windows.Forms.Label()
        Me.txtSearchMemberAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMemberStatus = New System.Windows.Forms.ComboBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.TabIndex = 9
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(226, 88)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1091, 113)
        Me.lblWelcome.TabIndex = 62
        Me.lblWelcome.Text = "Membership Search Result"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtMemberEmail
        '
        Me.TxtMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMemberEmail.Location = New System.Drawing.Point(701, 387)
        Me.TxtMemberEmail.Name = "TxtMemberEmail"
        Me.TxtMemberEmail.ReadOnly = True
        Me.TxtMemberEmail.Size = New System.Drawing.Size(407, 45)
        Me.TxtMemberEmail.TabIndex = 78
        '
        'lblSearchMemberEmail
        '
        Me.lblSearchMemberEmail.AutoSize = True
        Me.lblSearchMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberEmail.Location = New System.Drawing.Point(399, 393)
        Me.lblSearchMemberEmail.Name = "lblSearchMemberEmail"
        Me.lblSearchMemberEmail.Size = New System.Drawing.Size(226, 38)
        Me.lblSearchMemberEmail.TabIndex = 77
        Me.lblSearchMemberEmail.Text = "MemberEmail:"
        '
        'TxtMemberSearchName
        '
        Me.TxtMemberSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMemberSearchName.Location = New System.Drawing.Point(701, 285)
        Me.TxtMemberSearchName.Name = "TxtMemberSearchName"
        Me.TxtMemberSearchName.Size = New System.Drawing.Size(411, 45)
        Me.TxtMemberSearchName.TabIndex = 76
        '
        'LblMemberSearchName
        '
        Me.LblMemberSearchName.AutoSize = True
        Me.LblMemberSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMemberSearchName.Location = New System.Drawing.Point(399, 291)
        Me.LblMemberSearchName.Name = "LblMemberSearchName"
        Me.LblMemberSearchName.Size = New System.Drawing.Size(232, 38)
        Me.LblMemberSearchName.TabIndex = 75
        Me.LblMemberSearchName.Text = "MemberName:"
        '
        'TxtMemberRegistrationDate
        '
        Me.TxtMemberRegistrationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMemberRegistrationDate.Location = New System.Drawing.Point(701, 491)
        Me.TxtMemberRegistrationDate.Name = "TxtMemberRegistrationDate"
        Me.TxtMemberRegistrationDate.ReadOnly = True
        Me.TxtMemberRegistrationDate.Size = New System.Drawing.Size(407, 45)
        Me.TxtMemberRegistrationDate.TabIndex = 73
        '
        'TxtSearchMemberPhoneNumber
        '
        Me.TxtSearchMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchMemberPhoneNumber.Location = New System.Drawing.Point(701, 440)
        Me.TxtSearchMemberPhoneNumber.Name = "TxtSearchMemberPhoneNumber"
        Me.TxtSearchMemberPhoneNumber.Size = New System.Drawing.Size(407, 45)
        Me.TxtSearchMemberPhoneNumber.TabIndex = 72
        '
        'txtSearchMemberIC
        '
        Me.txtSearchMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMemberIC.Location = New System.Drawing.Point(701, 336)
        Me.txtSearchMemberIC.Name = "txtSearchMemberIC"
        Me.txtSearchMemberIC.Size = New System.Drawing.Size(407, 45)
        Me.txtSearchMemberIC.TabIndex = 71
        '
        'TxtSearchMemberID
        '
        Me.TxtSearchMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchMemberID.Location = New System.Drawing.Point(701, 234)
        Me.TxtSearchMemberID.Name = "TxtSearchMemberID"
        Me.TxtSearchMemberID.ReadOnly = True
        Me.TxtSearchMemberID.Size = New System.Drawing.Size(407, 45)
        Me.TxtSearchMemberID.TabIndex = 70
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(676, 683)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(181, 61)
        Me.btnReturn.TabIndex = 69
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(462, 683)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(187, 61)
        Me.btnUpdate.TabIndex = 68
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblSearchMemberStatus
        '
        Me.lblSearchMemberStatus.AutoSize = True
        Me.lblSearchMemberStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberStatus.Location = New System.Drawing.Point(389, 548)
        Me.lblSearchMemberStatus.Name = "lblSearchMemberStatus"
        Me.lblSearchMemberStatus.Size = New System.Drawing.Size(238, 38)
        Me.lblSearchMemberStatus.TabIndex = 67
        Me.lblSearchMemberStatus.Text = "MemberStatus:"
        '
        'lblSearchMemberRegistrationDate
        '
        Me.lblSearchMemberRegistrationDate.AutoSize = True
        Me.lblSearchMemberRegistrationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberRegistrationDate.Location = New System.Drawing.Point(239, 494)
        Me.lblSearchMemberRegistrationDate.Name = "lblSearchMemberRegistrationDate"
        Me.lblSearchMemberRegistrationDate.Size = New System.Drawing.Size(388, 38)
        Me.lblSearchMemberRegistrationDate.TabIndex = 66
        Me.lblSearchMemberRegistrationDate.Text = "MemberRegistrationDate:"
        '
        'lblSearchMemberPhoneNumber
        '
        Me.lblSearchMemberPhoneNumber.AutoSize = True
        Me.lblSearchMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberPhoneNumber.Location = New System.Drawing.Point(265, 443)
        Me.lblSearchMemberPhoneNumber.Name = "lblSearchMemberPhoneNumber"
        Me.lblSearchMemberPhoneNumber.Size = New System.Drawing.Size(355, 38)
        Me.lblSearchMemberPhoneNumber.TabIndex = 65
        Me.lblSearchMemberPhoneNumber.Text = "MemberPhoneNumber:"
        '
        'lblSearchMemberIC
        '
        Me.lblSearchMemberIC.AutoSize = True
        Me.lblSearchMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberIC.Location = New System.Drawing.Point(455, 342)
        Me.lblSearchMemberIC.Name = "lblSearchMemberIC"
        Me.lblSearchMemberIC.Size = New System.Drawing.Size(177, 38)
        Me.lblSearchMemberIC.TabIndex = 64
        Me.lblSearchMemberIC.Text = "MemberIC:"
        '
        'lblSearchMemberId
        '
        Me.lblSearchMemberId.AutoSize = True
        Me.lblSearchMemberId.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMemberId.Location = New System.Drawing.Point(458, 234)
        Me.lblSearchMemberId.Name = "lblSearchMemberId"
        Me.lblSearchMemberId.Size = New System.Drawing.Size(177, 38)
        Me.lblSearchMemberId.TabIndex = 63
        Me.lblSearchMemberId.Text = "MemberID:"
        '
        'txtSearchMemberAddress
        '
        Me.txtSearchMemberAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMemberAddress.Location = New System.Drawing.Point(699, 606)
        Me.txtSearchMemberAddress.Name = "txtSearchMemberAddress"
        Me.txtSearchMemberAddress.Size = New System.Drawing.Size(407, 45)
        Me.txtSearchMemberAddress.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 606)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 38)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "MemberAddress:"
        '
        'cboMemberStatus
        '
        Me.cboMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemberStatus.FormattingEnabled = True
        Me.cboMemberStatus.Items.AddRange(New Object() {"Active", "Deactive"})
        Me.cboMemberStatus.Location = New System.Drawing.Point(699, 548)
        Me.cboMemberStatus.Name = "cboMemberStatus"
        Me.cboMemberStatus.Size = New System.Drawing.Size(407, 46)
        Me.cboMemberStatus.TabIndex = 81
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
        'MemberSearchResult2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.cboMemberStatus)
        Me.Controls.Add(Me.txtSearchMemberAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMemberEmail)
        Me.Controls.Add(Me.lblSearchMemberEmail)
        Me.Controls.Add(Me.TxtMemberSearchName)
        Me.Controls.Add(Me.LblMemberSearchName)
        Me.Controls.Add(Me.TxtMemberRegistrationDate)
        Me.Controls.Add(Me.TxtSearchMemberPhoneNumber)
        Me.Controls.Add(Me.txtSearchMemberIC)
        Me.Controls.Add(Me.TxtSearchMemberID)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSearchMemberStatus)
        Me.Controls.Add(Me.lblSearchMemberRegistrationDate)
        Me.Controls.Add(Me.lblSearchMemberPhoneNumber)
        Me.Controls.Add(Me.lblSearchMemberIC)
        Me.Controls.Add(Me.lblSearchMemberId)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberSearchResult2"
        Me.Text = "MemberSearchResult"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents TxtMemberEmail As TextBox
    Friend WithEvents lblSearchMemberEmail As Label
    Friend WithEvents TxtMemberSearchName As TextBox
    Friend WithEvents LblMemberSearchName As Label
    Friend WithEvents TxtMemberRegistrationDate As TextBox
    Friend WithEvents TxtSearchMemberPhoneNumber As TextBox
    Friend WithEvents txtSearchMemberIC As TextBox
    Friend WithEvents TxtSearchMemberID As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblSearchMemberStatus As Label
    Friend WithEvents lblSearchMemberRegistrationDate As Label
    Friend WithEvents lblSearchMemberPhoneNumber As Label
    Friend WithEvents lblSearchMemberIC As Label
    Friend WithEvents lblSearchMemberId As Label
    Friend WithEvents txtSearchMemberAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMemberStatus As ComboBox
End Class
