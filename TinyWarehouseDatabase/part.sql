CREATE TABLE [dbo].[part]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [part_number] NVARCHAR(50) NOT NULL, 
    [name] NVARCHAR(100) NULL, 
    [price] DECIMAL(18, 2) NULL, 
    [description] NVARCHAR(500) NULL, 
    [weight] DECIMAL(18, 2) NULL, 
    [created_on] DATETIME NOT NULL
)
