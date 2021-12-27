CREATE PROCEDURE [dbo].[Laptop_SelectById]
	@Id int
AS
BEGIN
	select
		Id,
		Name,
		Number,
		PricePerMonth,
		Description
	from dbo.Laptop
	where Id =@Id
END
