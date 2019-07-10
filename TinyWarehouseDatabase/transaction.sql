CREATE TABLE [dbo].[transaction]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [transaction_id] NVARCHAR(50) NOT NULL, 
    [part_id] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES part(Id), 
    [quantity] INT NOT NULL, 
    [transaction_date] DATE NOT NULL, 
    [transaction_type] BIT NOT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id of either the receiving or shipping paper',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'transaction',
    @level2type = N'COLUMN',
    @level2name = N'transaction_id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'false = shipping, true = receiving',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'transaction',
    @level2type = N'COLUMN',
    @level2name = N'transaction_type'