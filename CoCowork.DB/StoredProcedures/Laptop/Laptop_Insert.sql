CREATE PROCEDURE [dbo].[Laptop_Insert]
	@Name varchar(30),
	@Number int,
	@PricePerMonth int,
	@Description nvarchar(200)
AS
BEGIN
	insert into dbo.Laptop
		(Name,
		Number,
		PricePerMonth,
		Description)
	values 
		(@Name,
		@Number,
		@PricePerMonth,
		@Description)
SELECT SCOPE_IDENTITY()
END
