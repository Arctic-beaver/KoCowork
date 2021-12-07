CREATE PROC dbo.TypeOfRoom_Insert
	@Name varchar(30)
AS
BEGIN
	insert into dbo.TypeOfRoom 
		(Name)
	values 
		(@Name)
END
