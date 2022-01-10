CREATE PROC dbo.Place_Update
	@Id int,
	@Number int,
	@MiniOfficeId int,
	@PricePerDay decimal(10,2),
	@PriceFixedPerDay decimal(10,2),
	@Description nvarchar(200)
AS
BEGIN
	update dbo.Place
	set 
		Number = @Number,
	    Description = @Description,
	    PricePerDay = @PricePerDay,
		PriceFixedPerDay = @PriceFixedPerDay
    where Id = @Id
END