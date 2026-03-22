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

CREATE TABLE Class (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClassName NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    ClassId INT REFERENCES Class(Id),
    BirthDate DATE
);
GO

INSERT INTO Account (Username, Password) VALUES (N'admin', N'123456');
GO

INSERT INTO Class (ClassName) VALUES (N'KTPM01');
INSERT INTO Class (ClassName) VALUES (N'KTPM02');
INSERT INTO Class (ClassName) VALUES (N'HTTT01');
INSERT INTO Class (ClassName) VALUES (N'HTTT02');
GO

INSERT INTO Student (Name, ClassId, BirthDate) VALUES (N'Tran Minh Tuan', 1, '2003-02-14');
INSERT INTO Student (Name, ClassId, BirthDate) VALUES (N'Le Hoang Nam',   2, '2003-11-05');
INSERT INTO Student (Name, ClassId, BirthDate) VALUES (N'Vo Thi Lan',     3, '2004-06-22');
INSERT INTO Student (Name, ClassId, BirthDate) VALUES (N'Bui Duc Huy',    1, '2003-09-30');
INSERT INTO Student (Name, ClassId, BirthDate) VALUES (N'Dang Phuong Mai',4, '2004-04-18');
GO
