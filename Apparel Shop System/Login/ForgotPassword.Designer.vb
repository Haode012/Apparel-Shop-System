<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblForgetPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(273, 242)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(306, 30)
        Me.txtNewPassword.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 245)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "New Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfBirth.Location = New System.Drawing.Point(273, 176)
        Me.txtDateOfBirth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(306, 30)
        Me.txtDateOfBirth.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 179)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 28)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Date Of Birth:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(440, 298)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(139, 44)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(218, 298)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(139, 44)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(273, 119)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(306, 30)
        Me.txtUsername.TabIndex = 18
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(28, 119)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(183, 28)
        Me.lblUsername.TabIndex = 17
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblForgetPassword
        '
        Me.lblForgetPassword.BackColor = System.Drawing.Color.LightCyan
        Me.lblForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblForgetPassword.Location = New System.Drawing.Point(-2, 0)
        Me.lblForgetPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForgetPassword.Name = "lblForgetPassword"
        Me.lblForgetPassword.Size = New System.Drawing.Size(805, 55)
        Me.lblForgetPassword.TabIndex = 16
        Me.lblForgetPassword.Text = "FORGOT PASSWORD"
        Me.lblForgetPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDateOfBirth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblForgetPassword)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblForgetPassword As Label
End Class
