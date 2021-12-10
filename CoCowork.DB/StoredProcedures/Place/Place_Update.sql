CREATE PROC dbo.Place_Update
	@Id int,
	@MiniOfficeId int,
	@PricePerDay decimal(10,2),
	@PriceFixedPerDay decimal(10,2)
AS
BEGIN
	update dbo.Place
	set 
	    PricePerDay = @PricePerDay,
		PriceFixedPerDay = @PriceFixedPerDay
    where Id = @Id
END