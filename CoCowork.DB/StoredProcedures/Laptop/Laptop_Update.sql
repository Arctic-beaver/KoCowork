CREATE PROCEDURE [dbo].[Laptop_Update]
	@Id int,
	@Name varchar(30),
	@Number int,
	@PricePerMonth int,
	@Description nvarchar(200)
AS
BEGIN
	update dbo.Laptop
	set Name = @Name,
		Number = @Number,
		PricePerMonth = @PricePerMonth,
		Description = @Description
	where Id = @Id
END
