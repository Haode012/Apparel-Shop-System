﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberRegister))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtMemberIC = New System.Windows.Forms.TextBox()
        Me.txtMemberPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtMemberEmail = New System.Windows.Forms.TextBox()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMemberPhoneNumber = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMemberAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.TabIndex = 8
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.LightCyan
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(294, 78)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1091, 113)
        Me.lblWelcome.TabIndex = 61
        Me.lblWelcome.Text = "Membership Register Form"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMemberIC
        '
        Me.txtMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberIC.Location = New System.Drawing.Point(755, 389)
        Me.txtMemberIC.Name = "txtMemberIC"
        Me.txtMemberIC.Size = New System.Drawing.Size(291, 45)
        Me.txtMemberIC.TabIndex = 69
        '
        'txtMemberPhoneNumber
        '
        Me.txtMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberPhoneNumber.Location = New System.Drawing.Point(755, 327)
        Me.txtMemberPhoneNumber.Name = "txtMemberPhoneNumber"
        Me.txtMemberPhoneNumber.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberPhoneNumber.TabIndex = 68
        '
        'txtMemberEmail
        '
        Me.txtMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberEmail.Location = New System.Drawing.Point(755, 276)
        Me.txtMemberEmail.Name = "txtMemberEmail"
        Me.txtMemberEmail.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberEmail.TabIndex = 67
        '
        'txtMemberName
        '
        Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(755, 225)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberName.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 38)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Member IC :"
        '
        'lblMemberPhoneNumber
        '
        Me.lblMemberPhoneNumber.AutoSize = True
        Me.lblMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberPhoneNumber.Location = New System.Drawing.Point(297, 334)
        Me.lblMemberPhoneNumber.Name = "lblMemberPhoneNumber"
        Me.lblMemberPhoneNumber.Size = New System.Drawing.Size(382, 38)
        Me.lblMemberPhoneNumber.TabIndex = 64
        Me.lblMemberPhoneNumber.Text = "Member Phone Number :"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(435, 276)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(244, 38)
        Me.lblMemberID.TabIndex = 63
        Me.lblMemberID.Text = "Member Email :"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.Location = New System.Drawing.Point(429, 225)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(250, 38)
        Me.lblMemberName.TabIndex = 62
        Me.lblMemberName.Text = "Member Name :"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(524, 538)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(157, 53)
        Me.btnRegister.TabIndex = 72
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(741, 538)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 53)
        Me.btnCancel.TabIndex = 73
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtMemberAddress
        '
        Me.txtMemberAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberAddress.Location = New System.Drawing.Point(755, 450)
        Me.txtMemberAddress.Name = "txtMemberAddress"
        Me.txtMemberAddress.Size = New System.Drawing.Size(291, 45)
        Me.txtMemberAddress.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 38)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Member Address :"
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
        'MemberRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.txtMemberAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtMemberIC)
        Me.Controls.Add(Me.txtMemberPhoneNumber)
        Me.Controls.Add(Me.txtMemberEmail)
        Me.Controls.Add(Me.txtMemberName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMemberPhoneNumber)
        Me.Controls.Add(Me.lblMemberID)
        Me.Controls.Add(Me.lblMemberName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberRegister"
        Me.Text = "MemberRegister"
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
    Friend WithEvents txtMemberIC As TextBox
    Friend WithEvents txtMemberPhoneNumber As TextBox
    Friend WithEvents txtMemberEmail As TextBox
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMemberPhoneNumber As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents lblMemberName As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMemberAddress As TextBox
    Friend WithEvents Label1 As Label
End Class
