Public Class Main
    Private dashboard As DashboardForm
    Private employees As EmployeesForm
    Private salary As SalaryForm

    ' Constructor to initialize components and forms
    Public Sub New()
        InitializeComponent()

        ' Initialize forms
        dashboard = New DashboardForm() With {.Dock = DockStyle.Fill, .Visible = False}
        employees = New EmployeesForm() With {.Dock = DockStyle.Fill, .Visible = False}
        salary = New SalaryForm() With {.Dock = DockStyle.Fill, .Visible = False}

        ' Add them to the Main form's container
        Me.Controls.Add(dashboard)
        Me.Controls.Add(employees)
        Me.Controls.Add(salary)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim check As DialogResult = MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If check = DialogResult.Yes Then
            ScreenLogin.Show()
            Me.Hide()
        End If
    End Sub

    ' Utility method to show a specific form and hide others
    Private Sub ShowForm(ByRef formToShow As UserControl)
        ' Hide all forms
        dashboard.Visible = False
        employees.Visible = False
        salary.Visible = False

        ' Show the selected form
        formToShow.Visible = True
        formToShow.BringToFront()
    End Sub

    ' Show Dashboard
    Private Sub Dashboard_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        ShowForm(dashboard)
    End Sub

    ' Show Employee Form
    Private Sub AddEmployee_btn_Click(sender As Object, e As EventArgs) Handles AddEmployee_btn.Click
        ShowForm(employees)
    End Sub

    ' Show Salary Form
    Private Sub Salary_btn_Click(sender As Object, e As EventArgs) Handles Salary_btn.Click
        ShowForm(salary)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MessageBox.Show("Built by Bakyelle David, UENR, I.T")
    End Sub
End Class
