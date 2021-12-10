CREATE PROC dbo.TypeOfRoom_SelectAll
AS
BEGIN
	select
		Id,
		Name
	from dbo.TypeOfRoom
END
