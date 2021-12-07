CREATE TABLE [dbo].[Payment]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Amount] int NULL,
	[PaymentDate] DateTime,
	[OrderId] int NOT NULL, 
)
