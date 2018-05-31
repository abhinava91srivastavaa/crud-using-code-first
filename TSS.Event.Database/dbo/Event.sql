CREATE TABLE [dbo].[Event]
(
	[Id] INT NOT NULL PRIMARY KEY Identity (1,1), 
    [Name] VARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Date] DATE NOT NULL, 
    [Vanue] NVARCHAR(50) NOT NULL, 
    [ContactPerson ] NVARCHAR(60) NOT NULL, 
    [EmailId] NVARCHAR(100) NOT NULL, 
    [CreatedDate] DATETIME NULL, 
    [UpdatedDate] DATETIME NULL
)
