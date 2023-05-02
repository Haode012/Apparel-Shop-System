<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Membership
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtMemberIC = New System.Windows.Forms.TextBox()
        Me.txtMemberPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtMemberEmail = New System.Windows.Forms.TextBox()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMemberPhoneNumber = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
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
        Me.Panel1.TabIndex = 1
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
        Me.lblWelcome.Location = New System.Drawing.Point(269, 72)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1091, 113)
        Me.lblWelcome.TabIndex = 60
        Me.lblWelcome.Text = "Membership Register Form"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(739, 503)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 53)
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(564, 503)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(157, 53)
        Me.btnRegister.TabIndex = 82
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtMemberIC
        '
        Me.txtMemberIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberIC.Location = New System.Drawing.Point(707, 402)
        Me.txtMemberIC.Name = "txtMemberIC"
        Me.txtMemberIC.Size = New System.Drawing.Size(291, 45)
        Me.txtMemberIC.TabIndex = 81
        '
        'txtMemberPhoneNumber
        '
        Me.txtMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberPhoneNumber.Location = New System.Drawing.Point(707, 340)
        Me.txtMemberPhoneNumber.Name = "txtMemberPhoneNumber"
        Me.txtMemberPhoneNumber.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberPhoneNumber.TabIndex = 80
        '
        'txtMemberEmail
        '
        Me.txtMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberEmail.Location = New System.Drawing.Point(707, 286)
        Me.txtMemberEmail.Name = "txtMemberEmail"
        Me.txtMemberEmail.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberEmail.TabIndex = 79
        '
        'txtMemberName
        '
        Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(707, 235)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(474, 45)
        Me.txtMemberName.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 38)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Member IC :"
        '
        'lblMemberPhoneNumber
        '
        Me.lblMemberPhoneNumber.AutoSize = True
        Me.lblMemberPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberPhoneNumber.Location = New System.Drawing.Point(293, 346)
        Me.lblMemberPhoneNumber.Name = "lblMemberPhoneNumber"
        Me.lblMemberPhoneNumber.Size = New System.Drawing.Size(382, 38)
        Me.lblMemberPhoneNumber.TabIndex = 76
        Me.lblMemberPhoneNumber.Text = "Member Phone Number :"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(436, 286)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(244, 38)
        Me.lblMemberID.TabIndex = 75
        Me.lblMemberID.Text = "Member Email :"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.Location = New System.Drawing.Point(431, 235)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(250, 38)
        Me.lblMemberName.TabIndex = 74
        Me.lblMemberName.Text = "Member Name :"
        '
        'Membership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
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
        Me.Name = "Membership"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtMemberIC As TextBox
    Friend WithEvents txtMemberPhoneNumber As TextBox
    Friend WithEvents txtMemberEmail As TextBox
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMemberPhoneNumber As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents lblMemberName As Label
End Class
