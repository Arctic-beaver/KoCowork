CREATE PROCEDURE [dbo].[Laptop_Delete]
	@Id int = 0,
	@param2 int
AS
BEGIN
	delete from dbo.Laptop
	where Id = @Id
END
