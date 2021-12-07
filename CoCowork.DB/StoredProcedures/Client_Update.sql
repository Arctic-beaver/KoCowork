CREATE PROC dbo.Client_Update
	@Id int,
	@Name varchar(30), 
	@DateBirth date,
	@Phone varchar(20),
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	update dbo.Client
	set Name = @Name, 
		DateBirth = @DateBirth,
		Phone = @Phone,
		PaperAmount = @PaperAmount,
		PaperEndDay = @PaperEndDay
    where Id = @Id
END