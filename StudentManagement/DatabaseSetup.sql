CREATE DATABASE StudentManagementDB;
GO

USE StudentManagementDB;
GO

CREATE TABLE Account (
    Id       INT            IDENTITY PRIMARY KEY,
    Username NVARCHAR(50)   NOT NULL,
    Password NVARCHAR(50)   NOT NULL
);
GO

CREATE TABLE Student (
    Id        INT            IDENTITY PRIMARY KEY,
    Name      NVARCHAR(100)  NOT NULL,
    Class     NVARCHAR(50),
    BirthDate DATE
);
GO

INSERT INTO Account (Username, Password) VALUES (N'admin', N'admin123');
GO

INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Nguyen Van A', N'CNTT01', '2003-05-15');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Tran Thi B',   N'CNTT02', '2003-08-20');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Le Van C',     N'CNTT01', '2004-01-10');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Pham Thi D',   N'CNTT03', '2003-12-25');
INSERT INTO Student (Name, Class, BirthDate) VALUES (N'Hoang Van E',  N'CNTT02', '2004-03-08');
GO
