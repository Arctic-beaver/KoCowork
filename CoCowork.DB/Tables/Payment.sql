CREATE TABLE [dbo].[Payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Amount] int NOT NULL,
	[PaymentDate] DateTime,
	[OrderId] int NOT NULL, 
)
