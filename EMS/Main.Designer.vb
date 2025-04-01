<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GreetUser = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Salary_btn = New System.Windows.Forms.Button()
        Me.AddEmployee_btn = New System.Windows.Forms.Button()
        Me.Dashboard_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DashboardForm1 = New EMS.DashboardForm()
        Me.EmployeesForm1 = New EMS.EmployeesForm()
        Me.SalaryForm1 = New EMS.SalaryForm()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1287, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Managament System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 41)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.BtnLogin)
        Me.Panel2.Controls.Add(Me.Salary_btn)
        Me.Panel2.Controls.Add(Me.AddEmployee_btn)
        Me.Panel2.Controls.Add(Me.Dashboard_btn)
        Me.Panel2.Controls.Add(Me.GreetUser)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 662)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 606)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LOGOUT"
        '
        'GreetUser
        '
        Me.GreetUser.AutoSize = True
        Me.GreetUser.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreetUser.Location = New System.Drawing.Point(110, 176)
        Me.GreetUser.Name = "GreetUser"
        Me.GreetUser.Size = New System.Drawing.Size(109, 17)
        Me.GreetUser.TabIndex = 3
        Me.GreetUser.Text = "Welcome,User"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DashboardForm1)
        Me.Panel3.Controls.Add(Me.EmployeesForm1)
        Me.Panel3.Controls.Add(Me.SalaryForm1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(318, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1013, 662)
        Me.Panel3.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Image = Global.EMS.My.Resources.Resources.icons8_logout_rounded_up_filled_25px
        Me.BtnLogin.Location = New System.Drawing.Point(18, 592)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(45, 41)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Salary_btn
        '
        Me.Salary_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Salary_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salary_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Salary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salary_btn.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary_btn.Image = Global.EMS.My.Resources.Resources.icons8_Salary_male_30px
        Me.Salary_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salary_btn.Location = New System.Drawing.Point(55, 415)
        Me.Salary_btn.Name = "Salary_btn"
        Me.Salary_btn.Size = New System.Drawing.Size(223, 56)
        Me.Salary_btn.TabIndex = 3
        Me.Salary_btn.Text = "Salary"
        Me.Salary_btn.UseVisualStyleBackColor = False
        '
        'AddEmployee_btn
        '
        Me.AddEmployee_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.AddEmployee_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddEmployee_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AddEmployee_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddEmployee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddEmployee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmployee_btn.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmployee_btn.Image = Global.EMS.My.Resources.Resources.icons8_employee_card_30px
        Me.AddEmployee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddEmployee_btn.Location = New System.Drawing.Point(55, 315)
        Me.AddEmployee_btn.Name = "AddEmployee_btn"
        Me.AddEmployee_btn.Size = New System.Drawing.Size(223, 57)
        Me.AddEmployee_btn.TabIndex = 2
        Me.AddEmployee_btn.Text = "    Add Employee"
        Me.AddEmployee_btn.UseVisualStyleBackColor = False
        '
        'Dashboard_btn
        '
        Me.Dashboard_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard_btn.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_btn.Image = Global.EMS.My.Resources.Resources.icons8_dashboard_30px
        Me.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard_btn.Location = New System.Drawing.Point(55, 225)
        Me.Dashboard_btn.Name = "Dashboard_btn"
        Me.Dashboard_btn.Size = New System.Drawing.Size(223, 55)
        Me.Dashboard_btn.TabIndex = 1
        Me.Dashboard_btn.Text = "DashBoard"
        Me.Dashboard_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMS.My.Resources.Resources.icons8_employee_card_100px
        Me.PictureBox1.Location = New System.Drawing.Point(90, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DashboardForm1
        '
        Me.DashboardForm1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardForm1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DashboardForm1.Name = "DashboardForm1"
        Me.DashboardForm1.Size = New System.Drawing.Size(4052, 2241)
        Me.DashboardForm1.TabIndex = 2
        '
        'EmployeesForm1
        '
        Me.EmployeesForm1.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesForm1.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeesForm1.Name = "EmployeesForm1"
        Me.EmployeesForm1.Size = New System.Drawing.Size(1013, 662)
        Me.EmployeesForm1.TabIndex = 1
        '
        'SalaryForm1
        '
        Me.SalaryForm1.Location = New System.Drawing.Point(0, 0)
        Me.SalaryForm1.Margin = New System.Windows.Forms.Padding(2)
        Me.SalaryForm1.Name = "SalaryForm1"
        Me.SalaryForm1.Size = New System.Drawing.Size(1013, 662)
        Me.SalaryForm1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 637)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Version 1.1"
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1331, 703)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GreetUser As Label
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents Salary_btn As Button
    Friend WithEvents AddEmployee_btn As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Dashboard1 As DashboardForm
    Friend WithEvents SalaryForm1 As SalaryForm
    Friend WithEvents EmployeesForm1 As EmployeesForm
    Friend WithEvents DashboardForm1 As DashboardForm
    Friend WithEvents Label3 As Label
End Class
