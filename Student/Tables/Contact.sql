CREATE TABLE [dbo].[Contact]
(
	[ContactId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StudentId] INT NULL FOREIGN KEY REFERENCES Student(StudentId), 
    [LastName] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [Relationship] VARCHAR(25) NULL, 
    [EmailAddress] VARCHAR(75) NULL, 
    [Mobile] CHAR(12) NULL, 
    [Address] VARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [State] VARCHAR(2) NULL, 
    [ZipCode] INT NULL
)
