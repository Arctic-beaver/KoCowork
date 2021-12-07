CREATE PROC dbo.TypeOfRoom_SelectById	
	@Id int
AS
BEGIN
	select
		id,
		name
	from dbo.TypeOfRoom
	where id =@Id
END
