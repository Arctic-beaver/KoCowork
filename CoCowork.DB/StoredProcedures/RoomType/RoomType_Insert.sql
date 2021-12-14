CREATE PROC dbo.RoomType_Insert
	@Name varchar(30)
AS
BEGIN
	insert into dbo.RoomType
		(Name)
	values 
		(@Name)
END
