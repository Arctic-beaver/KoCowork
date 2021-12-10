CREATE PROCEDURE [dbo].[Laptop_Insert]
	@PricePerMonth int,
	@Description nvarchar(200)
AS
BEGIN
	insert into dbo.Laptop
		(PricePerMonth,
		Description)
	values 
		(@PricePerMonth,
		@Description)
END
