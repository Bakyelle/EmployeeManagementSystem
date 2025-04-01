Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class EmployeesForm

    ' Database Connection String
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"

    ' Track if the current image is from database or newly loaded
    Private isImageFromDatabase As Boolean = False
    Private currentImageBytes As Byte() = Nothing

    ' Constructor
    Public Sub New()
        InitializeComponent()
        DisplayEmployeeData()
    End Sub

    ' Method to Display Employee Data in DataGridView
    Private Sub DisplayEmployeeData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT EmployeeID, Firstname, Surname, Gender, PhoneNumber, Address, Position, Status, Picture FROM Employee WHERE DeleteDate IS NULL"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Hide the Picture column to prevent automatic image conversion errors
                DataGridView1.DataSource = dt
                If DataGridView1.Columns.Contains("Picture") Then
                    DataGridView1.Columns("Picture").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event Handler for Add Employee Button
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If txtFirstname.Text = "" Or txtSurname.Text = "" Or CboGender.Text = "" Or txtPhonenumber.Text = "" Or
           txtAddress.Text = "" Or CboPosition.Text = "" Or CboStatus.Text = "" Or PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if Employee ID already exists
                Dim checkEmID As String = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @emID"
                Using cmd As New SqlCommand(checkEmID, connection)
                    cmd.Parameters.AddWithValue("@emID", txtEmployeeID.Text.Trim())
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Employee ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Convert Image to Byte Array with validation
                Dim imageBytes As Byte() = Nothing
                If PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        Try
                            PictureBox1.Image.Save(ms, ImageFormat.Jpeg)
                            imageBytes = ms.ToArray()
                        Catch imgEx As Exception
                            MessageBox.Show("Invalid image format. Please select a valid image.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End Try
                    End Using
                End If

                ' Insert Employee Data
                Dim insertQuery As String = "INSERT INTO Employee (Firstname, Surname, Gender, PhoneNumber, Address, Position, Status, Picture, InsertDate) 
                                           VALUES (@Firstname, @Surname, @Gender, @PhoneNumber, @Address, @Position, @Status, @Picture, @InsertDate)"
                Using cmd As New SqlCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Gender", CboGender.Text.Trim())
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhonenumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@Position", CboPosition.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", CboStatus.Text.Trim())
                    cmd.Parameters.AddWithValue("@Picture", If(imageBytes, DBNull.Value))
                    cmd.Parameters.AddWithValue("@InsertDate", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisplayEmployeeData()
            BtnClear_Click(Nothing, Nothing) ' Clear the form
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event Handler for Delete Button Click (Soft Delete)
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("Please enter Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ask for confirmation before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee record?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim deleteQuery As String = "UPDATE Employee SET DeleteDate = @DeleteDate WHERE EmployeeID = @EmployeeID"
                Using cmd As New SqlCommand(deleteQuery, connection)
                    cmd.Parameters.AddWithValue("@DeleteDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisplayEmployeeData()
            BtnClear_Click(Nothing, Nothing) ' Clear the form
        Catch ex As Exception
            MessageBox.Show("Error deleting employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event Handler for Update Button Click
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("Please enter Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ask for confirmation before updating
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this employee record?",
                                                   "Confirm Update",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Handle the image data
                Dim imageBytes As Byte() = Nothing

                If PictureBox1.Image IsNot Nothing Then
                    ' If image is from database and wasn't changed, use the original bytes
                    If isImageFromDatabase AndAlso Not PictureBox1.Image Is Nothing Then
                        imageBytes = currentImageBytes
                    Else
                        ' Convert new/changed image to bytes
                        Using ms As New MemoryStream()
                            Try
                                ' Save in JPEG format to ensure compatibility
                                PictureBox1.Image.Save(ms, ImageFormat.Jpeg)
                                imageBytes = ms.ToArray()
                            Catch imgEx As Exception
                                MessageBox.Show("Invalid image format. Please select a valid image.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End Try
                        End Using
                    End If
                End If

                ' Update Query
                Dim updateQuery As String = "UPDATE Employee SET 
                    Firstname=@Firstname, 
                    Surname=@Surname, 
                    Gender=@Gender, 
                    PhoneNumber=@PhoneNumber, 
                    Address=@Address, 
                    Position=@Position, 
                    Status=@Status, 
                    Picture=@Picture, 
                    UpdateDate=@UpdateDate 
                    WHERE EmployeeID=@EmployeeID"

                Using cmd As New SqlCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Gender", CboGender.Text.Trim())
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhonenumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@Position", CboPosition.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", CboStatus.Text.Trim())
                    cmd.Parameters.AddWithValue("@Picture", If(imageBytes, DBNull.Value))
                    cmd.Parameters.AddWithValue("@UpdateDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisplayEmployeeData()

            ' Reset the image tracking after successful update
            isImageFromDatabase = False
            currentImageBytes = Nothing

        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event Handler for Import Image Button
    Private Sub BtnImportImage_Click(sender As Object, e As EventArgs) Handles BtnLoadPicture.Click
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png",
            .Title = "Select Employee Photo"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Validate the image before loading
                Using img As Image = Image.FromFile(openFileDialog.FileName)
                    PictureBox1.Image = New Bitmap(img)
                    isImageFromDatabase = False ' Mark that this is a new image
                    currentImageBytes = Nothing
                End Using
            Catch ex As Exception
                MessageBox.Show("The selected file is not a valid image or is corrupted.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Clear Input Fields
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        ' Ask for confirmation before clearing
        If Not (txtEmployeeID.Text = "" AndAlso txtFirstname.Text = "" AndAlso txtSurname.Text = "" AndAlso
                CboGender.SelectedIndex = -1 AndAlso txtPhonenumber.Text = "" AndAlso txtAddress.Text = "" AndAlso
                CboPosition.SelectedIndex = -1 AndAlso CboStatus.SelectedIndex = -1 AndAlso PictureBox1.Image Is Nothing) Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?",
                                                       "Confirm Clear",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)

            If result = DialogResult.No Then
                Return
            End If
        End If

        ' Clear all fields
        txtEmployeeID.Clear()
        txtFirstname.Clear()
        txtSurname.Clear()
        CboGender.SelectedIndex = -1
        txtPhonenumber.Clear()
        txtAddress.Clear()
        CboPosition.SelectedIndex = -1
        CboStatus.SelectedIndex = -1
        PictureBox1.Image = Nothing
        isImageFromDatabase = False
        currentImageBytes = Nothing
    End Sub

    ' Handle cell click to populate form fields
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Populate textboxes and combo boxes with selected row data
                txtEmployeeID.Text = selectedRow.Cells("EmployeeID").Value.ToString()
                txtFirstname.Text = selectedRow.Cells("Firstname").Value.ToString()
                txtSurname.Text = selectedRow.Cells("Surname").Value.ToString()
                CboGender.Text = selectedRow.Cells("Gender").Value.ToString()
                txtPhonenumber.Text = selectedRow.Cells("PhoneNumber").Value.ToString()
                txtAddress.Text = selectedRow.Cells("Address").Value.ToString()
                CboPosition.Text = selectedRow.Cells("Position").Value.ToString()
                CboStatus.Text = selectedRow.Cells("Status").Value.ToString()

                ' Handle the Picture conversion safely
                If Not IsDBNull(selectedRow.Cells("Picture").Value) AndAlso selectedRow.Cells("Picture").Value IsNot Nothing Then
                    currentImageBytes = DirectCast(selectedRow.Cells("Picture").Value, Byte())
                    If currentImageBytes.Length > 0 Then
                        Using ms As New MemoryStream(currentImageBytes)
                            Try
                                PictureBox1.Image = Image.FromStream(ms)
                                isImageFromDatabase = True ' Mark that this image came from DB
                            Catch
                                PictureBox1.Image = Nothing
                                isImageFromDatabase = False
                                currentImageBytes = Nothing
                            End Try
                        End Using
                    Else
                        PictureBox1.Image = Nothing
                        isImageFromDatabase = False
                        currentImageBytes = Nothing
                    End If
                Else
                    PictureBox1.Image = Nothing
                    isImageFromDatabase = False
                    currentImageBytes = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged
        txtEmployeeID.Enabled=False
    End Sub

    ' Handle DataGridView errors silently
    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        ' Log error if needed (uncomment below)
        ' Debug.WriteLine("DataGridView Error: " & e.Exception.Message)
        e.ThrowException = False ' Prevent the default error dialog
    End Sub
End Class