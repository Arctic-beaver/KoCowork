CREATE PROC dbo.Place_Update
	@Id int,
	@MiniOfficeId int,
	@PricePerDay int,
	@PriceFixedPerDay int
AS
BEGIN
	update dbo.Place
	set 
	    PricePerDay = @PricePerDay,
		PriceFixedPerDay = @PriceFixedPerDay
    where Id = @Id
END