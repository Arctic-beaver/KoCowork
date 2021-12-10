CREATE PROC dbo.RoomOrder_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		RoomId,
		OrderId,
		StartDate,
		EndDate,
		SubtotalPrice
	from dbo.RoomOrder
	where id =@Id
END
