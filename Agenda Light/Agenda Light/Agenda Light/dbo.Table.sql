CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [compromisso] VARCHAR(50) NOT NULL, 
    [data] VARCHAR(50) NOT NULL, 
    [hora] VARCHAR(50) NOT NULL, 
    [local] VARCHAR(50) NOT NULL, 
    [contato] VARCHAR(50) NULL,
)
