﻿CREATE TABLE [dbo].[KeysTable]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Key] UNIQUEIDENTIFIER NOT NULL, 
	[ReaderType] CHAR(32) NOT NULL, 
	[ReaderKeyHashValue] CHAR(32) NOT NULL, 
	[CreatedTime] DATETIME NULL, 
	[OperationMan] NVARCHAR(10) NULL
)
