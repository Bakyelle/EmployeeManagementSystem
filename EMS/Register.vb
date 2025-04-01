Imports System.Data.SqlClient

Public Class Register
    Public connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Btnsignin_Click(sender As Object, e As EventArgs) Handles Btnsignin.Click
        Me.Hide()
        ScreenLogin.Show()
    End Sub

    Private Sub BtnRegSignup_Click(sender As Object, e As EventArgs) Handles BtnRegSignup.Click
        Dim username As String = txtUsernameReg.Text.Trim()
        Dim password As String = txtpasswordReg.Text.Trim()

        ' Check if fields are empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter Username and Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if the username and password already exist
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Username", username)
                    checkCmd.Parameters.AddWithValue("@PasswordHash", password)

                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This username and password combination already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' If username and password are unique, insert new record
                Dim insertQuery As String = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)"
                Using insertCmd As New SqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@Username", username)
                    insertCmd.Parameters.AddWithValue("@PasswordHash", password) ' Storing password in plain text (Not Secure)
                    insertCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpasswordReg.UseSystemPasswordChar = False
        Else
            txtpasswordReg.UseSystemPasswordChar = True
        End If
        txtpasswordReg.Focus()
    End Sub
End Class
