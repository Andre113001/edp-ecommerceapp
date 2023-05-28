<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chckPassword = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbConPass = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblErrorEmail = New System.Windows.Forms.Label()
        Me.lblErrorUsername = New System.Windows.Forms.Label()
        Me.lblErrorPass = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(23, 124)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(323, 31)
        Me.tbEmail.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirm Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(21, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chckPassword
        '
        Me.chckPassword.AutoSize = True
        Me.chckPassword.Location = New System.Drawing.Point(21, 445)
        Me.chckPassword.Name = "chckPassword"
        Me.chckPassword.Size = New System.Drawing.Size(102, 17)
        Me.chckPassword.TabIndex = 7
        Me.chckPassword.Text = "Show Password"
        Me.chckPassword.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(17, 532)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(185, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already have an account? Login here"
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(21, 297)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(323, 30)
        Me.tbPass.TabIndex = 9
        Me.tbPass.UseSystemPasswordChar = True
        '
        'tbConPass
        '
        Me.tbConPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConPass.Location = New System.Drawing.Point(22, 381)
        Me.tbConPass.Name = "tbConPass"
        Me.tbConPass.Size = New System.Drawing.Size(323, 30)
        Me.tbConPass.TabIndex = 10
        Me.tbConPass.UseSystemPasswordChar = True
        '
        'tbUsername
        '
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(23, 210)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(323, 31)
        Me.tbUsername.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Username"
        '
        'lblErrorEmail
        '
        Me.lblErrorEmail.AutoSize = True
        Me.lblErrorEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblErrorEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmail.Location = New System.Drawing.Point(20, 158)
        Me.lblErrorEmail.Name = "lblErrorEmail"
        Me.lblErrorEmail.Size = New System.Drawing.Size(64, 13)
        Me.lblErrorEmail.TabIndex = 13
        Me.lblErrorEmail.Text = "* Error Email"
        '
        'lblErrorUsername
        '
        Me.lblErrorUsername.AutoSize = True
        Me.lblErrorUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblErrorUsername.ForeColor = System.Drawing.Color.Red
        Me.lblErrorUsername.Location = New System.Drawing.Point(20, 244)
        Me.lblErrorUsername.Name = "lblErrorUsername"
        Me.lblErrorUsername.Size = New System.Drawing.Size(87, 13)
        Me.lblErrorUsername.TabIndex = 15
        Me.lblErrorUsername.Text = "* Error Username"
        '
        'lblErrorPass
        '
        Me.lblErrorPass.AutoSize = True
        Me.lblErrorPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblErrorPass.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPass.Location = New System.Drawing.Point(20, 414)
        Me.lblErrorPass.Name = "lblErrorPass"
        Me.lblErrorPass.Size = New System.Drawing.Size(85, 13)
        Me.lblErrorPass.TabIndex = 16
        Me.lblErrorPass.Text = "* Error Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ecommerce_app.My.Resources.Resources.icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(341, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 83)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 573)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblErrorPass)
        Me.Controls.Add(Me.lblErrorUsername)
        Me.Controls.Add(Me.lblErrorEmail)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbConPass)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.chckPassword)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegister"
        Me.Text = "Register to CartMe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chckPassword As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbConPass As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblErrorEmail As Label
    Friend WithEvents lblErrorUsername As Label
    Friend WithEvents lblErrorPass As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
