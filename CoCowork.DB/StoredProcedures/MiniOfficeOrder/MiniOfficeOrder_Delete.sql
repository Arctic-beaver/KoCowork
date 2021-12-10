CREATE PROC dbo.MiniOfficeOrder_Delete
	@Id int
AS
BEGIN
	delete from dbo.MiniOfficeOrder
	where Id = @Id
END