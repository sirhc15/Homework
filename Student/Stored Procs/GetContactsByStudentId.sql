USE [Student]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GetContactsByStudentId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[GetContactsByStudentId]
GO

CREATE PROCEDURE [dbo].[GetContactsByStudentId]
(
	@StudentId INT
)
AS
	
BEGIN
	SELECT * FROM [dbo].[Contact] WHERE StudentId = @StudentId
END
