<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataLoading
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
        Me.dgViewItem = New System.Windows.Forms.DataGridView()
        Me.tbFileDir = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        CType(Me.dgViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgViewItem
        '
        Me.dgViewItem.AllowUserToAddRows = False
        Me.dgViewItem.AllowUserToDeleteRows = False
        Me.dgViewItem.AllowUserToResizeColumns = False
        Me.dgViewItem.AllowUserToResizeRows = False
        Me.dgViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewItem.Enabled = False
        Me.dgViewItem.Location = New System.Drawing.Point(12, 102)
        Me.dgViewItem.Name = "dgViewItem"
        Me.dgViewItem.ReadOnly = True
        Me.dgViewItem.Size = New System.Drawing.Size(651, 266)
        Me.dgViewItem.TabIndex = 0
        '
        'tbFileDir
        '
        Me.tbFileDir.Location = New System.Drawing.Point(12, 67)
        Me.tbFileDir.Name = "tbFileDir"
        Me.tbFileDir.ReadOnly = True
        Me.tbFileDir.Size = New System.Drawing.Size(544, 20)
        Me.tbFileDir.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(562, 62)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 29)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(502, 385)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(161, 41)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "Upload to database"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Batch Upload"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(365, 385)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(131, 41)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'frmDataLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 450)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbFileDir)
        Me.Controls.Add(Me.dgViewItem)
        Me.Name = "frmDataLoading"
        Me.Text = "Upload to Database"
        CType(Me.dgViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgViewItem As DataGridView
    Friend WithEvents tbFileDir As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackup As Button
End Class
