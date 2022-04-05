CREATE TABLE [dbo].[Student]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [LastName] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [Address] VARCHAR(75) NULL, 
    [City] VARCHAR(50) NULL, 
    [State] VARCHAR(2) NULL, 
    [ZipCode] INT NULL, 
    [SchoolCode] INT NULL
)
