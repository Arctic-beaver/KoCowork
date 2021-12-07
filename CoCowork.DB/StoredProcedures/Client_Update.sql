CREATE PROC dbo.Client_Update
	@Id int,
	@Name varchar, 
	@DateBirth date,
	@Phone varchar,
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