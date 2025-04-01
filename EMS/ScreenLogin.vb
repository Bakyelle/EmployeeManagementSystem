Imports System.Data.SqlClient

Public Class ScreenLogin
    ' Database connection string
    Public connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"

    ' Function to validate user credentials (No hashing)
    Private Function ValidateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                ' Query to check if username and password match
                Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @Password"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password) ' Storing and comparing plain text password

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using

            Catch ex As Exception
                MessageBox.Show("Database Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    ' Close application when label is clicked
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    ' Open Register form
    Private Sub Btnsignup_Click(sender As Object, e As EventArgs) Handles Btnsignup.Click
        Register.Show()
        Me.Hide() ' Hide the login form when opening the Register form
    End Sub

    ' Toggle password visibility
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not CheckBox1.Checked
        txtpassword.Focus()
    End Sub

    ' Handle login button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        ' Check if fields are empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter a username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate user credentials
        If ValidateUser(username, password) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Redirect to another form or dashboard

            Main.Show()
            Me.Hide()
            txtUsername.Text = ""
            txtpassword.Text = ""
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
