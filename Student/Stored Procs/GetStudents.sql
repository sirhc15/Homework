USE [Student]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GetStudents]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[GetStudents]
GO

CREATE PROCEDURE [dbo].[GetStudents]
AS
	
BEGIN
	SELECT * FROM [dbo].[Student]
END
