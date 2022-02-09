CREATE PROCEDURE [dbo].[updateSubject]
	@Name NVARCHAR(50),
	@Code NVARCHAR(10),
	@IsExaminable BIT,
	@ColorBytes NVARCHAR(15),
	@OldId INT
AS
		UPDATE Subjects SET [Name] = @Name, [Code] = @Code, [IsExaminable] = @IsExaminable
							WHERE Id = @OldId
