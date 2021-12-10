CREATE PROCEDURE [dbo].[Laptop_SelectById]
	@Id int
AS
BEGIN
	select
		Id,
		Name,
		Amount,
		PricePerMonth,
		Description
	from dbo.Laptop
	where Id =@Id
END
