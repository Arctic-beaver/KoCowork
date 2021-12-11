﻿CREATE PROC dbo.Room_SelectById	
	@Id int
AS
BEGIN
	select
		r.Id,
		r.TypeId,
		r.AmountOfPeople,
		r.PricePerHour,
		rt.Name
	from dbo.Room r inner join dbo.RoomType rt on r.TypeId = rt.Id
	where r.id =@Id
END
