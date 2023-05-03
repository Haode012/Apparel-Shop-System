<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnManagerLogin = New System.Windows.Forms.Button()
        Me.btnStaffLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnManagerLogin
        '
        Me.btnManagerLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnManagerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagerLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.btnManagerLogin.Location = New System.Drawing.Point(268, 207)
        Me.btnManagerLogin.Name = "btnManagerLogin"
        Me.btnManagerLogin.Size = New System.Drawing.Size(300, 51)
        Me.btnManagerLogin.TabIndex = 14
        Me.btnManagerLogin.Text = "Manager Login"
        Me.btnManagerLogin.UseVisualStyleBackColor = False
        '
        'btnStaffLogin
        '
        Me.btnStaffLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStaffLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.btnStaffLogin.Location = New System.Drawing.Point(268, 319)
        Me.btnStaffLogin.Name = "btnStaffLogin"
        Me.btnStaffLogin.Size = New System.Drawing.Size(300, 51)
        Me.btnStaffLogin.TabIndex = 15
        Me.btnStaffLogin.Text = "Staff Login"
        Me.btnStaffLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightCyan
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(0, -1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(799, 87)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "WELCOME TO YJRCH APPAREL SHOP SYSTEM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Choose Manager Login Or Staff Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Or"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnStaffLogin)
        Me.Controls.Add(Me.btnManagerLogin)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManagerLogin As Button
    Friend WithEvents btnStaffLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
