<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnsignin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnRegSignup = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtpasswordReg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsernameReg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btnsignin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 375)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMS.My.Resources.Resources.icons8_employee_card_100px
        Me.PictureBox1.Location = New System.Drawing.Point(63, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Employee Managment System"
        '
        'Btnsignin
        '
        Me.Btnsignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Btnsignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsignin.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia
        Me.Btnsignin.FlatAppearance.BorderSize = 0
        Me.Btnsignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
        Me.Btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsignin.ForeColor = System.Drawing.Color.White
        Me.Btnsignin.Location = New System.Drawing.Point(33, 332)
        Me.Btnsignin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnsignin.Name = "Btnsignin"
        Me.Btnsignin.Size = New System.Drawing.Size(175, 28)
        Me.Btnsignin.TabIndex = 5
        Me.Btnsignin.Text = "SIGNIN"
        Me.Btnsignin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 307)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Login to an account ?"
        '
        'BtnRegSignup
        '
        Me.BtnRegSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnRegSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnRegSignup.FlatAppearance.BorderSize = 0
        Me.BtnRegSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnRegSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnRegSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegSignup.ForeColor = System.Drawing.Color.White
        Me.BtnRegSignup.Location = New System.Drawing.Point(279, 299)
        Me.BtnRegSignup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnRegSignup.Name = "BtnRegSignup"
        Me.BtnRegSignup.Size = New System.Drawing.Size(78, 28)
        Me.BtnRegSignup.TabIndex = 4
        Me.BtnRegSignup.Text = "SIGNUP"
        Me.BtnRegSignup.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(472, 274)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 23)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtpasswordReg
        '
        Me.txtpasswordReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswordReg.Location = New System.Drawing.Point(261, 233)
        Me.txtpasswordReg.Multiline = True
        Me.txtpasswordReg.Name = "txtpasswordReg"
        Me.txtpasswordReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswordReg.Size = New System.Drawing.Size(307, 32)
        Me.txtpasswordReg.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password:"
        '
        'txtUsernameReg
        '
        Me.txtUsernameReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameReg.Location = New System.Drawing.Point(262, 156)
        Me.txtUsernameReg.Multiline = True
        Me.txtUsernameReg.Name = "txtUsernameReg"
        Me.txtUsernameReg.Size = New System.Drawing.Size(305, 32)
        Me.txtUsernameReg.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Register Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(599, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 375)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRegSignup)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtpasswordReg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsernameReg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnsignin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnRegSignup As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtpasswordReg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsernameReg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
