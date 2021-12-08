CREATE PROCEDURE [dbo].[Laptop_SelectAll]
	
AS
BEGIN
	select
		Id,
		PricePerMonth,
		Description
	from dbo.Laptop
END
