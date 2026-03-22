CREATE DATABASE QuanLySinhVienDB;
GO

USE QuanLySinhVienDB;
GO

CREATE TABLE Account (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Class NVARCHAR(50),
    BirthDate DATE
);
GO

INSERT INTO Account (Username, Password) VALUES (N'admin', N'123456');
GO

INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Tran Minh Tuan', N'KTPM01', '2003-02-14');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Le Hoang Nam',   N'KTPM02', '2003-11-05');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Vo Thi Lan',     N'HTTT01', '2004-06-22');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Bui Duc Huy',    N'KTPM01', '2003-09-30');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Dang Phuong Mai',N'HTTT02', '2004-04-18');
GO
