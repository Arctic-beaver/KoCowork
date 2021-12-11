CREATE TABLE [dbo].[Payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Amount] int NOT NULL,
	[PaymentDate] DateTime NOT NULL,
	[OrderId] int NOT NULL, 
)
