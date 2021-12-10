CREATE PROC dbo.Place_Insert
	@MiniOfficeId int,
	@PricePerDay decimal(10,2),
	@PriceFixedPerDay decimal(10,2)
AS
BEGIN
	insert into dbo.Place
		(
			MiniOfficeId, 
			PricePerDay, 
			PriceFixedPerDay
		)
	values 
		(
			@MiniOfficeId,
			@PricePerDay,
			@PriceFixedPerDay
		)
END
