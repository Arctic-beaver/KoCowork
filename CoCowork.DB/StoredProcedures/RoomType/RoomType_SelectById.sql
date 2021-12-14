CREATE PROC dbo.RoomType_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		Name
	from dbo.RoomType
	where Id =@Id
END
