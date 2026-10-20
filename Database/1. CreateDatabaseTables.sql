USE [mssql2404089];
GO

-- Create Departments table:
CREATE TABLE dbo.Departments
(
	DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
	DepartmentName NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- Create Employees table:
CREATE TABLE dbo.Employees
(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(255) NOT NULL UNIQUE,
	DepartmentID INT NOT NULL,

	CONSTRAINT FK_Employees_Departments
		FOREIGN KEY (DepartmentID)
		REFERENCES dbo.Departments(DepartmentID)
);
GO

-- Create Assets table:
CREATE TABLE dbo.Assets
(
	AssetID INT IDENTITY(1,1) PRIMARY KEY,
	SystemName NVARCHAR(255) NOT NULL,
	Model NVARCHAR(150) NULL,
	Manufacturer NVARCHAR(150) NULL,
	AssetType NVARCHAR(100) NOT NULL,
	IPAddress NVARCHAR(50) NULL,
	PurchaseDate DATE NOT NULL,
	Notes NVARCHAR(MAX) NULL,
	EmployeeID INT NOT NULL,

	CONSTRAINT FK_Assets_Employees
		FOREIGN KEY (EmployeeID)
		REFERENCES dbo.Employees(EmployeeID)
);
GO

-- Insert the predefined departments
INSERT INTO dbo.Departments (DepartmentName)
VALUES ('Finance'),('HR'),('Operations'),('Sales'),('IT');
GO