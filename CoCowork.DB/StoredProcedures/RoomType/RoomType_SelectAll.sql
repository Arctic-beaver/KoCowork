CREATE PROC dbo.RoomType_SelectAll
AS
BEGIN
	select
		Id,
		Name
	from dbo.RoomType
END
