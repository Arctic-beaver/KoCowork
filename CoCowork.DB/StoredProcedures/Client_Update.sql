CREATE PROC dbo.Client_Update
	@Id int,
	@Name varchar, 
	@Date DateTime,
	@Phone varchar,
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	update dbo.Client
	set Name = @Name, 
		Date = @Date,
		Phone = @Phone,
		PaperAmount = @PaperAmount,
		PaperEndDay = @PaperEndDay
    where Id = @Id
END