﻿CREATE TABLE [dbo].[inventory]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [part_id] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES part(Id), 
    [quantity] INT NOT NULL,
	
)
