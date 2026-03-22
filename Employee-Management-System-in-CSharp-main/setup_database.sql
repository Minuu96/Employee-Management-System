-- Create the employee database if it doesn't exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'employee')
BEGIN
    CREATE DATABASE employee;
END
GO

USE employee;
GO

-- Create users table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
BEGIN
    CREATE TABLE users (
        id INT PRIMARY KEY IDENTITY(1,1),
        username NVARCHAR(100) NOT NULL,
        password NVARCHAR(100) NOT NULL,
        date_register DATE NULL
    );
END
GO

-- Create employees table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'employees')
BEGIN
    CREATE TABLE employees (
        id INT PRIMARY KEY IDENTITY(1,1),
        employee_id NVARCHAR(50) NOT NULL,
        full_name NVARCHAR(150) NOT NULL,
        gender NVARCHAR(20) NULL,
        contact_number NVARCHAR(50) NULL,
        position NVARCHAR(100) NULL,
        image NVARCHAR(500) NULL,
        salary INT NULL,
        status NVARCHAR(50) NULL,
        date_added DATETIME NULL,
        delete_date DATETIME NULL
    );
END
GO

-- Create salary table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'salary')
BEGIN
    CREATE TABLE salary (
        id INT PRIMARY KEY IDENTITY(1,1),
        employee_id NVARCHAR(50) NOT NULL,
        basic_salary INT NULL,
        allowance INT NULL,
        deduction INT NULL,
        net_salary INT NULL,
        date_issued DATETIME NULL
    );
END
GO
