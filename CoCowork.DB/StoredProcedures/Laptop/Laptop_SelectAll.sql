CREATE PROCEDURE [dbo].[Laptop_SelectAll]
AS
BEGIN
	select
		Id,
		Name,
		Number,
		PricePerMonth,
		Description
	from dbo.Laptop
END
