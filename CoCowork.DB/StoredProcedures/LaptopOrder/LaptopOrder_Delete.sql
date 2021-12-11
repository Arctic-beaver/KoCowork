CREATE PROCEDURE [dbo].[LaptopOrder_Delete]
	@Id int
AS
BEGIN
	delete from dbo.LaptopOrder
	where Id = @Id
END

