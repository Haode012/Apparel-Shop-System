<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershipMaintenance
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberPhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberRegistrationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparelShopSystemDataset = New Apparel_Shop_System.ApparelShopSystemDataset()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MembershipTableAdapter = New Apparel_Shop_System.ApparelShopSystemDatasetTableAdapters.MembershipTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparelShopSystemDataset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 5
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
        Me.lblWelcome.Location = New System.Drawing.Point(427, 64)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(933, 107)
        Me.lblWelcome.TabIndex = 7
        Me.lblWelcome.Text = "Membership Maintenance"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(895, 268)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(378, 38)
        Me.txtSearch.TabIndex = 13
        '
        'dgvList
        '
        Me.dgvList.AutoGenerateColumns = False
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIDDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.MemberICDataGridViewTextBoxColumn, Me.MemberPhoneNumberDataGridViewTextBoxColumn, Me.MemberEmailDataGridViewTextBoxColumn, Me.MemberRegistrationDateDataGridViewTextBoxColumn, Me.MemberStatusDataGridViewTextBoxColumn})
        Me.dgvList.DataSource = Me.MembershipBindingSource
        Me.dgvList.Location = New System.Drawing.Point(316, 318)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersWidth = 51
        Me.dgvList.RowTemplate.Height = 24
        Me.dgvList.Size = New System.Drawing.Size(1137, 464)
        Me.dgvList.TabIndex = 8
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "memberID"
        Me.MemberIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberIDDataGridViewTextBoxColumn.Width = 125
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "memberName"
        Me.MemberNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.Width = 125
        '
        'MemberICDataGridViewTextBoxColumn
        '
        Me.MemberICDataGridViewTextBoxColumn.DataPropertyName = "memberIC"
        Me.MemberICDataGridViewTextBoxColumn.HeaderText = "memberIC"
        Me.MemberICDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberICDataGridViewTextBoxColumn.Name = "MemberICDataGridViewTextBoxColumn"
        Me.MemberICDataGridViewTextBoxColumn.Width = 125
        '
        'MemberPhoneNumberDataGridViewTextBoxColumn
        '
        Me.MemberPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "memberPhoneNumber"
        Me.MemberPhoneNumberDataGridViewTextBoxColumn.HeaderText = "memberPhoneNumber"
        Me.MemberPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberPhoneNumberDataGridViewTextBoxColumn.Name = "MemberPhoneNumberDataGridViewTextBoxColumn"
        Me.MemberPhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'MemberEmailDataGridViewTextBoxColumn
        '
        Me.MemberEmailDataGridViewTextBoxColumn.DataPropertyName = "memberEmail"
        Me.MemberEmailDataGridViewTextBoxColumn.HeaderText = "memberEmail"
        Me.MemberEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberEmailDataGridViewTextBoxColumn.Name = "MemberEmailDataGridViewTextBoxColumn"
        Me.MemberEmailDataGridViewTextBoxColumn.Width = 125
        '
        'MemberRegistrationDateDataGridViewTextBoxColumn
        '
        Me.MemberRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "memberRegistrationDate"
        Me.MemberRegistrationDateDataGridViewTextBoxColumn.HeaderText = "memberRegistrationDate"
        Me.MemberRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberRegistrationDateDataGridViewTextBoxColumn.Name = "MemberRegistrationDateDataGridViewTextBoxColumn"
        Me.MemberRegistrationDateDataGridViewTextBoxColumn.Width = 125
        '
        'MemberStatusDataGridViewTextBoxColumn
        '
        Me.MemberStatusDataGridViewTextBoxColumn.DataPropertyName = "memberStatus"
        Me.MemberStatusDataGridViewTextBoxColumn.HeaderText = "memberStatus"
        Me.MemberStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MemberStatusDataGridViewTextBoxColumn.Name = "MemberStatusDataGridViewTextBoxColumn"
        Me.MemberStatusDataGridViewTextBoxColumn.Width = 125
        '
        'MembershipBindingSource
        '
        Me.MembershipBindingSource.DataMember = "Membership"
        Me.MembershipBindingSource.DataSource = Me.ApparelShopSystemDataset
        '
        'ApparelShopSystemDataset
        '
        Me.ApparelShopSystemDataset.DataSetName = "ApparelShopSystemDataset"
        Me.ApparelShopSystemDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(316, 189)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 53)
        Me.btnAdd.TabIndex = 57
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(506, 189)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(157, 53)
        Me.btnReport.TabIndex = 60
        Me.btnReport.Text = "&Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1279, 260)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(157, 53)
        Me.btnSearch.TabIndex = 61
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'MembershipTableAdapter
        '
        Me.MembershipTableAdapter.ClearBeforeFill = True
        '
        'MembershipMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1654, 1035)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MembershipMaintenance"
        Me.Text = "MembershipMaintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparelShopSystemDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents ApparelShopSystemDataset As ApparelShopSystemDataset
    Friend WithEvents MembershipBindingSource As BindingSource
    Friend WithEvents MembershipTableAdapter As ApparelShopSystemDatasetTableAdapters.MembershipTableAdapter
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberRegistrationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
