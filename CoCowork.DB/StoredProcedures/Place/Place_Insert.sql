CREATE PROC dbo.Place_Insert
	@MiniOfficeId int,
	@Number int,
	@PricePerDay decimal(10,2),
	@PriceFixedPerDay decimal(10,2),
	@Description nvarchar(200)
AS
BEGIN
	insert into dbo.Place
		(
			MiniOfficeId, 
			Number,
			PricePerDay, 
			PriceFixedPerDay,
			Description
		)
	values 
		(
			@MiniOfficeId,
			@Number,
			@PricePerDay,
			@PriceFixedPerDay,
			@Description
		)
SELECT SCOPE_IDENTITY()
END
