CREATE PROCEDURE [dbo].[Laptop_Insert]
	@Name varchar(30),
	@Amount int,
	@PricePerMonth int,
	@Description nvarchar(200)
AS
BEGIN
	insert into dbo.Laptop
		(Name,
		Amount,
		PricePerMonth,
		Description)
	values 
		(@Name,
		@Amount,
		@PricePerMonth,
		@Description)
END
