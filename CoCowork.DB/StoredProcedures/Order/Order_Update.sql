CREATE PROC dbo.Order_Update
	@Id int,
	@ClientId int,
	@TotalPrice int,
	@IsPaid bit,
	@IsCanceled bit
AS
BEGIN
	update dbo.[Order]
	set ClientId = @ClientId,
		TotalPrice = @TotalPrice,
		IsPaid = @IsPaid,
		IsCanceled = @IsCanceled
    where id = @Id
END
