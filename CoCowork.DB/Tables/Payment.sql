CREATE TABLE [dbo].[Payment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Amount] DECIMAL(10, 2) NOT NULL,
	[PaymentDate] DateTime NOT NULL,
	[OrderId] int NOT NULL, 
    CONSTRAINT [FK_Payment_ToTable] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id]), 
)
