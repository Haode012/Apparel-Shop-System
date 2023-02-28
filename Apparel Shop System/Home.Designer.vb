<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1612, 46)
        Me.Panel1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(552, 110)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(549, 45)
        Me.txtSearch.TabIndex = 2
        '
        'picSearch
        '
        Me.picSearch.Image = Global.Apparel_Shop_System.My.Resources.Resources.search_icon
        Me.picSearch.Location = New System.Drawing.Point(1107, 110)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(46, 45)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 3
        Me.picSearch.TabStop = False
        '
        'picDelete
        '
        Me.picDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.picDelete.Image = Global.Apparel_Shop_System.My.Resources.Resources.close
        Me.picDelete.Location = New System.Drawing.Point(1566, 0)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(46, 46)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 0
        Me.picDelete.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1612, 966)
        Me.Controls.Add(Me.picSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents picSearch As PictureBox
End Class
