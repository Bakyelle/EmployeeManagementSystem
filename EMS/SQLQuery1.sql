CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(20) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(20) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);


	SELECT * FROM Users;

	Insert into Users(Username,Password)values("Admin","123");

	drop table Employee;

CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Firstname NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10)  NOT NULL,
    PhoneNumber NVARCHAR(15) UNIQUE NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    Position NVARCHAR(100) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Picture VARBINARY(MAX), -- To store image data 
    Salary DECIMAL(10,2) NULL, 
    InsertDate DATETIME DEFAULT GETDATE(),
    UpdateDate DATETIME NULL,
    DeleteDate DATETIME NULL
);

SELECT * FROM Employee;

Alter table Employees
Add  Status Varchar(10) 



