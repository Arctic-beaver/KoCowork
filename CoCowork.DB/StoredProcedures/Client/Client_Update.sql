CREATE PROC dbo.Client_Update
	@Id int,
	@FirstName varchar(20),
	@LastName  varchar(20), 
	@DateBirth date,
	@Phone varchar(20),
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	update dbo.Client
	set FirstName = @FirstName, 
		LastName = @LastName,
		DateBirth = @DateBirth,
		Phone = @Phone,
		PaperAmount = @PaperAmount,
		PaperEndDay = @PaperEndDay
    where Id = @Id
END