<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStaffDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewStaffDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblViewStaffStatus = New System.Windows.Forms.Label()
        Me.lblViewStaffEndDate = New System.Windows.Forms.Label()
        Me.lblViewStaffStartDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblViewStaffDob = New System.Windows.Forms.Label()
        Me.lblViewStaffIC = New System.Windows.Forms.Label()
        Me.lblViewStaffPosition = New System.Windows.Forms.Label()
        Me.lblViewStaffPhoneNum = New System.Windows.Forms.Label()
        Me.lblViewStaffName = New System.Windows.Forms.Label()
        Me.lblViewStaffId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.TabIndex = 7
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
        Me.lblWelcome.TabIndex = 38
        Me.lblWelcome.Text = "View Staff Details"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(563, 704)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 20)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Staff Status:"
        '
        'lblViewStaffStatus
        '
        Me.lblViewStaffStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffStatus.Location = New System.Drawing.Point(705, 704)
        Me.lblViewStaffStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffStatus.Name = "lblViewStaffStatus"
        Me.lblViewStaffStatus.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffStatus.TabIndex = 55
        '
        'lblViewStaffEndDate
        '
        Me.lblViewStaffEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffEndDate.Location = New System.Drawing.Point(705, 650)
        Me.lblViewStaffEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffEndDate.Name = "lblViewStaffEndDate"
        Me.lblViewStaffEndDate.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffEndDate.TabIndex = 54
        '
        'lblViewStaffStartDate
        '
        Me.lblViewStaffStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffStartDate.Location = New System.Drawing.Point(705, 593)
        Me.lblViewStaffStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffStartDate.Name = "lblViewStaffStartDate"
        Me.lblViewStaffStartDate.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffStartDate.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(563, 650)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 20)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Staff End Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(563, 593)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 20)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Staff Start Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(563, 538)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Staff Position:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(563, 476)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "IC NO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 417)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Date Of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(563, 359)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(563, 298)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Staff Name:"
        '
        'lblViewStaffDob
        '
        Me.lblViewStaffDob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffDob.Location = New System.Drawing.Point(705, 416)
        Me.lblViewStaffDob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffDob.Name = "lblViewStaffDob"
        Me.lblViewStaffDob.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffDob.TabIndex = 45
        '
        'lblViewStaffIC
        '
        Me.lblViewStaffIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffIC.Location = New System.Drawing.Point(705, 476)
        Me.lblViewStaffIC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffIC.Name = "lblViewStaffIC"
        Me.lblViewStaffIC.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffIC.TabIndex = 44
        '
        'lblViewStaffPosition
        '
        Me.lblViewStaffPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffPosition.Location = New System.Drawing.Point(705, 538)
        Me.lblViewStaffPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffPosition.Name = "lblViewStaffPosition"
        Me.lblViewStaffPosition.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffPosition.TabIndex = 43
        '
        'lblViewStaffPhoneNum
        '
        Me.lblViewStaffPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffPhoneNum.Location = New System.Drawing.Point(705, 358)
        Me.lblViewStaffPhoneNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffPhoneNum.Name = "lblViewStaffPhoneNum"
        Me.lblViewStaffPhoneNum.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffPhoneNum.TabIndex = 42
        '
        'lblViewStaffName
        '
        Me.lblViewStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffName.Location = New System.Drawing.Point(705, 297)
        Me.lblViewStaffName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffName.Name = "lblViewStaffName"
        Me.lblViewStaffName.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffName.TabIndex = 41
        '
        'lblViewStaffId
        '
        Me.lblViewStaffId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStaffId.Location = New System.Drawing.Point(705, 245)
        Me.lblViewStaffId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewStaffId.Name = "lblViewStaffId"
        Me.lblViewStaffId.Size = New System.Drawing.Size(309, 35)
        Me.lblViewStaffId.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 246)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Staff ID:"
        '
        'ViewStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblViewStaffStatus)
        Me.Controls.Add(Me.lblViewStaffEndDate)
        Me.Controls.Add(Me.lblViewStaffStartDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblViewStaffDob)
        Me.Controls.Add(Me.lblViewStaffIC)
        Me.Controls.Add(Me.lblViewStaffPosition)
        Me.Controls.Add(Me.lblViewStaffPhoneNum)
        Me.Controls.Add(Me.lblViewStaffName)
        Me.Controls.Add(Me.lblViewStaffId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewStaffDetails"
        Me.Text = "ViewStaffDetails"
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
    Friend WithEvents Label17 As Label
    Friend WithEvents lblViewStaffStatus As Label
    Friend WithEvents lblViewStaffEndDate As Label
    Friend WithEvents lblViewStaffStartDate As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblViewStaffDob As Label
    Friend WithEvents lblViewStaffIC As Label
    Friend WithEvents lblViewStaffPosition As Label
    Friend WithEvents lblViewStaffPhoneNum As Label
    Friend WithEvents lblViewStaffName As Label
    Friend WithEvents lblViewStaffId As Label
    Friend WithEvents Label1 As Label
End Class
