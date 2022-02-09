CREATE PROCEDURE [dbo].[getSubject]
	@SubjectId INT

AS
	SELECT * FROM Subjects WHERE Id = @SubjectId;

