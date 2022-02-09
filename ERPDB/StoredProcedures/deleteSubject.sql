CREATE PROCEDURE [dbo].[deleteSubject]
	@SubjectId INT
AS
	DELETE FROM Subjects WHERE Id = @SubjectId

