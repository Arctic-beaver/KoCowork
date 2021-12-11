CREATE PROCEDURE [dbo].[Laptop_SelectAll]
AS
BEGIN
	select
		Id,
		Name,
		Amount,
		PricePerMonth,
		Description
	from dbo.Laptop
END
