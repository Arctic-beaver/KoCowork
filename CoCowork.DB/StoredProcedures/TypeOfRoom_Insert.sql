CREATE PROC dbo.TypeOfRoom_Insert
	@Name varchar
AS
BEGIN
	insert into dbo.TypeOfRoom 
		(Name)
	values 
		(@Name)
END
