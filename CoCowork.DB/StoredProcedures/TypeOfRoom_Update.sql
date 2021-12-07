CREATE PROC dbo.TypeOfRoom_Update
	@Id int,
	@Name varchar(30)
AS
BEGIN
	update dbo.TypeOfRoom
	set Name = @Name
    where Id = @Id
END
