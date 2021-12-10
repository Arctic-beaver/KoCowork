CREATE PROCEDURE [dbo].[LaptopOrder_SelectById]
	@Id int
AS
BEGIN
	select
		Id,
		LaptopId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.LaptopOrder
	where Id =@Id
END
