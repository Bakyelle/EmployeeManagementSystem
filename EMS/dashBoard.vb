Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DashboardForm
    Inherits UserControl

    Private ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"

    ' Constructor
    Public Sub New()
        InitializeComponent()
        displayTE()
        displayAE()
        displayIE()

        ' Configure and start the timer
        Timer1.Interval = 5000 ' Refresh every 5 seconds
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Enabled = True
    End Sub

    ' Timer tick event to refresh data every 5 seconds
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshData()
    End Sub

    ' Refresh the displayed data
    Public Sub RefreshData()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf RefreshData))
            Return
        End If
        displayTE()
        displayAE()
        displayIE()
    End Sub

    ' Display total employees
    Public Sub displayTE()
        Try
            Using connect As New SqlConnection(connectionString)
                connect.Open()
                Dim selectData As String = "SELECT COUNT(EmployeeID) FROM Employee WHERE DeleteDate IS NULL"

                Using cmd As New SqlCommand(selectData, connect)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    DashTE.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display active employees
    Public Sub displayAE()
        Try
            Using connect As New SqlConnection(connectionString)
                connect.Open()
                Dim selectData As String = "SELECT COUNT(EmployeeID) FROM Employee WHERE status = @status AND DeleteDate IS NULL"

                Using cmd As New SqlCommand(selectData, connect)
                    cmd.Parameters.AddWithValue("@status", "Active")
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    DashAE.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display inactive employees
    Public Sub displayIE()
        Try
            Using connect As New SqlConnection(connectionString)
                connect.Open()
                Dim selectData As String = "SELECT COUNT(EmployeeID) FROM Employee WHERE status = @status AND DeleteDate IS NULL"

                Using cmd As New SqlCommand(selectData, connect)
                    cmd.Parameters.AddWithValue("@status", "Inactive")
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    DashIE.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
