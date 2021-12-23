CREATE PROC dbo.RoomOrder_SelectById	
	@Id int
AS
BEGIN
	select
		ro.Id,
		ro.OrderId,
		ro.StartDate,
		ro.EndDate,
		ro.SubtotalPrice,
		r.Id,
		r.AmountOfPeople,
		r.PricePerHour,
		r.Type
	from dbo.RoomOrder ro
	left outer join dbo.Room r on ro.RoomId = r.Id
	where ro.Id =@Id
END
