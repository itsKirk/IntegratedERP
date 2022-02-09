CREATE TABLE [dbo].[EditedSubjects]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Code] NVARCHAR(10) NOT NULL, 
    [IsExaminable] BIT NOT NULL, 
    [ColorBytes] NVARCHAR(20) NOT NULL, 
    [TimeOfEdit] DATETIME NOT NULL, 
    [Remarks] NVARCHAR(255) NOT NULL
)
