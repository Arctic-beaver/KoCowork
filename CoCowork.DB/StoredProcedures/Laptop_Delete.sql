CREATE PROCEDURE [dbo].[Laptop_Delete]
	@Id int
AS
BEGIN
	delete from dbo.Laptop
	where Id = @Id
END