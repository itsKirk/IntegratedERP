CREATE PROCEDURE [dbo].[editBank]
	@Id INT,
	@Name NVARCHAR(255)
AS
	UPDATE Banks SET [Name] = @Name WHERE Id = @Id
