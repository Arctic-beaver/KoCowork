CREATE PROC dbo.Place_Insert
	@MiniOfficeId int,
	@PricePerDay int,
	@PriceFixedPerDay int
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
