CREATE PROCEDURE [dbo].[LaptopOrder_Delete]
	@Id int,
	@LaptopId int,
	@OrderId int,
	@StartDate datetime,
	@EndDate datetime,
	@SubtotalPrice int
AS
BEGIN
	delete from dbo.LaptopOrder
	where Id = @Id
END

