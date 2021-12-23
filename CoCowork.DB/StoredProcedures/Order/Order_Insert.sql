CREATE PROC dbo.Order_Insert
	@ClientId int,
	@TotalPrice int,
	@IsPaid bit,
	@IsCanceled bit
AS
BEGIN
	insert into dbo.[Order]
		(ClientId,
		TotalPrice,
		IsPaid,
		IsCanceled)
	values 
		(@ClientId,
		@TotalPrice,
		@IsPaid,
		@IsCanceled)
	select SCOPE_IDENTITY()
END
