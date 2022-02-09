CREATE PROCEDURE [dbo].[insertEditedBank]
	@Id INT,
	@Name NVARCHAR(255),
	@Remarks NVARCHAR(255)
AS
	INSERT INTO EditedBanks([Id], [Name], [Remarks])
					VALUES(@Id, @Name, @Remarks)
