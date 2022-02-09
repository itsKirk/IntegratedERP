CREATE TABLE [dbo].[Subjects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Code] NVARCHAR(10) NOT NULL, 
    [IsExaminable] BIT NOT NULL, 
    [ColorBytes] NVARCHAR(20) NOT NULL
)
