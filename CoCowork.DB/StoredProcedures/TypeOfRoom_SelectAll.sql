CREATE PROC dbo.TypeOfRoom_SelectAll
AS
BEGIN
	select
		id,
		name
	from dbo.TypeOfRoom
END
