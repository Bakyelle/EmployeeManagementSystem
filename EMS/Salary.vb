Imports System.Data.SqlClient
Imports System.IO

Public Class SalaryForm
    Inherits UserControl

    Private ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"
    Private WithEvents refreshTimer As New Timer()

    Public Sub New()
        InitializeComponent()
        displayEmployees()
        disableFields()

        ' Attach DataGridView CellClick event
        AddHandler DataGridView1.CellClick, AddressOf dataGridView1_CellClick

        ' Start auto-refresh
        refreshTimer.Interval = 5000 ' Refresh every 5 seconds
        refreshTimer.Start()
    End Sub

    ' Auto-refresh DataGridView every few seconds
    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        displayEmployees()
    End Sub

    Public Sub disableFields()
        txtEmployeeID.Enabled = False
        txtFirstname.Enabled = False
        txtSurname.Enabled = False
        CboPosition.Enabled = False
    End Sub

    Public Sub displayEmployees()
        Try
            Using connect As New SqlConnection(connectionString)
                connect.Open()
                Dim cmd As New SqlCommand("SELECT EmployeeID, Firstname, Surname, Position, Salary FROM Employee WHERE DeleteDate IS NULL", connect)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub salary_updateBtn_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(txtEmployeeID.Text) OrElse String.IsNullOrEmpty(txtSalary.Text) Then
            MessageBox.Show("Please enter a valid Salary", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim check As DialogResult = MessageBox.Show($"Are you sure you want to UPDATE Employee ID: {txtEmployeeID.Text.Trim()}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If check <> DialogResult.Yes Then Return

        Try
            Dim salary As Decimal
            If Not Decimal.TryParse(txtSalary.Text.Trim(), salary) Then
                MessageBox.Show("Invalid salary format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using connect As New SqlConnection(connectionString)
                connect.Open()
                Dim updateData As String = "UPDATE Employee SET Salary = @salary WHERE EmployeeID = @employeeID"
                Using cmd As New SqlCommand(updateData, connect)
                    cmd.Parameters.AddWithValue("@salary", salary)
                    cmd.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text.Trim())

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        displayEmployees()
                        clearFields()
                    Else
                        MessageBox.Show("No records were updated. Employee ID may not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub clearFields()
        txtEmployeeID.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        CboPosition.Text = ""
        txtSalary.Text = ""
    End Sub

    ' Handle DataGridView row click to populate textboxes
    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Return ' Ignore header row clicks

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtEmployeeID.Text = If(row.Cells("EmployeeID").Value?.ToString(), "")
        txtFirstname.Text = If(row.Cells("Firstname").Value?.ToString(), "")
        txtSurname.Text = If(row.Cells("Surname").Value?.ToString(), "")
        CboPosition.Text = If(row.Cells("Position").Value?.ToString(), "")
        txtSalary.Text = If(row.Cells("Salary").Value?.ToString(), "")
    End Sub

    Private Sub salary_clearBtn_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clearFields()
    End Sub
End Class
