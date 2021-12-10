CREATE PROCEDURE [dbo].[Laptop_Update]
	@Id int,
	@Name varchar(30),
	@Amount int,
	@PricePerMonth int,
	@Description nvarchar(200)
AS
BEGIN
	update dbo.Laptop
	set Name = @Name,
		Amount = @Amount,
		PricePerMonth = @PricePerMonth,
		Description = @Description
	where Id = @Id
END
