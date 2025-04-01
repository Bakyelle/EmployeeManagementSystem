Imports System.Data
Imports System.Data.SqlClient

Public Class EmployeeData
    ' Define Properties for Employee
    Public Property EmployeeID As Integer
    Public Property Firstname As String
    Public Property Surname As String
    Public Property Gender As String
    Public Property Phonenumber As String
    Public Property Position As String
    Public Property Status As String
    Public Property Picture As Byte() ' Use Byte array for images
    Public Property Salary As Decimal

    ' Database Connection String
    Private ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\EMS\EMS\Employee.mdf;Integrated Security=True;Connect Timeout=30"

    ' Function to Fetch Employee Data
    Public Function GetEmployeeData() As List(Of EmployeeData)
        Dim listdata As New List(Of EmployeeData)()

        Try
            ' Open SQL Connection
            Using connect As New SqlConnection(connectionString)
                connect.Open()

                ' Define SQL Query
                Dim SelectData As String = "SELECT EmployeeID, Firstname, Surname, Gender, PhoneNumber, Position, Status, Salary, Picture FROM Employee WHERE DeleteDate IS NULL"

                ' Execute Query
                Using cmd As New SqlCommand(SelectData, connect)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim ed As New EmployeeData() With {
                                .EmployeeID = If(IsDBNull(reader("EmployeeID")), 0, Convert.ToInt32(reader("EmployeeID"))),
                                .Firstname = If(IsDBNull(reader("Firstname")), String.Empty, reader("Firstname").ToString()),
                                .Surname = If(IsDBNull(reader("Surname")), String.Empty, reader("Surname").ToString()),
                                .Gender = If(IsDBNull(reader("Gender")), String.Empty, reader("Gender").ToString()),
                                .Phonenumber = If(IsDBNull(reader("PhoneNumber")), String.Empty, reader("PhoneNumber").ToString()),
                                .Position = If(IsDBNull(reader("Position")), String.Empty, reader("Position").ToString()),
                                .Status = If(IsDBNull(reader("Status")), String.Empty, reader("Status").ToString()),
                                .Salary = If(IsDBNull(reader("Salary")), 0, Convert.ToDecimal(reader("Salary")))
                            }

                            ' Check if Picture is Not Null
                            If Not IsDBNull(reader("Picture")) Then
                                ed.Picture = DirectCast(reader("Picture"), Byte())
                            End If

                            listdata.Add(ed)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return listdata
    End Function

    ' Function to Fetch Salary Data
    Public Function GetSalaryData() As List(Of EmployeeData)
        Dim listdata As New List(Of EmployeeData)()

        Try
            ' Open SQL Connection
            Using connect As New SqlConnection(connectionString)
                connect.Open()

                ' Define SQL Query
                Dim SelectData As String = "SELECT EmployeeID, Firstname, Surname, Position, Salary, Picture FROM Employee WHERE DeleteDate IS NULL"

                ' Execute Query
                Using cmd As New SqlCommand(SelectData, connect)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim ed As New EmployeeData() With {
                                .EmployeeID = If(IsDBNull(reader("EmployeeID")), 0, Convert.ToInt32(reader("EmployeeID"))),
                                .Firstname = If(IsDBNull(reader("Firstname")), String.Empty, reader("Firstname").ToString()),
                                .Surname = If(IsDBNull(reader("Surname")), String.Empty, reader("Surname").ToString()),
                                .Position = If(IsDBNull(reader("Position")), String.Empty, reader("Position").ToString()),
                                .Salary = If(IsDBNull(reader("Salary")), 0, Convert.ToDecimal(reader("Salary")))
                            }

                            ' Check if Picture is Not Null
                            If Not IsDBNull(reader("Picture")) Then
                                ed.Picture = DirectCast(reader("Picture"), Byte())
                            End If

                            listdata.Add(ed)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return listdata
    End Function
End Class
