USE MASTER
GO
IF exists(SELECT  *
FROM sys.databases
WHERE NAME = 'Repositories')
DROP DATABASE Repositories

GO
CREATE DATABASE Repositories;

GO
USE Repositories

GO
CREATE TABLE Folder(
    "id" INT PRIMARY KEY IDENTITY(1,1),
    "Path" VARCHAR(100)
)

GO 
CREATE TABLE Repository(
    "id" INT PRIMARY KEY IDENTITY(1,1),
    "Path" VARCHAR(100),
    "id_main_folder" INT REFERENCES Folder(id) NOT NULL
)
