CREATE PROC dbo.TypeOfRoom_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		Name
	from dbo.TypeOfRoom
	where Id =@Id
END
