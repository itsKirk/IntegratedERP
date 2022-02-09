CREATE TABLE [dbo].[Teachers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [RegistrationNumber] NVARCHAR(20) NULL, 
    [HudumaNumber] NVARCHAR(20) NULL, 
    [EmployerName] NVARCHAR(50) NOT NULL, 
    [StaffNumber] NVARCHAR(20) NULL, 
    [EducationLevel] NVARCHAR(50) NULL, 
    [IdNumber] NVARCHAR(20) NULL, 
    [BankName] NVARCHAR(50) NOT NULL, 
    [PINNUmber] NVARCHAR(20) NULL, 
    [AccountNumber] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(50) NULL, 
    [PhysicalAddress] NVARCHAR(50) NULL, 
    [Town] NVARCHAR(50) NOT NULL, 
    [PhoneNumber1] NVARCHAR(20) NULL, 
    [PhoneNumber2] NVARCHAR(20) NULL

)
