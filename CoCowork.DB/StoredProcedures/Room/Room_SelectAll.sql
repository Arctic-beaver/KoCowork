CREATE PROC dbo.Room_SelectAll
AS
BEGIN
	select
		r.Id,
		r.AmountOfPeople,
		r.PricePerHour,
		rt.Name TypeId
	from dbo.Room r inner join dbo.RoomType rt on r.TypeId = rt.Id
END
