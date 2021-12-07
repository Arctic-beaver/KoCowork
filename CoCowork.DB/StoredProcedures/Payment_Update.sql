CREATE PROC dbo.Payment_Update
	@Id int,
	@Amount int
AS
BEGIN
	update dbo.Payment
	set Amount = @Amount
    where id = @Id
END
