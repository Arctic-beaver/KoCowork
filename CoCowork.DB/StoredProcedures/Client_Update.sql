CREATE PROC dbo.Client_Update
	@Id int,
	@Name varchar, 
	@DateBirth DateTime,
	@Email varchar,
	@Phone varchar,
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	update dbo.Client
	set Name = @Name, 
		DateBirth = @DateBirth,
		Email = @Email,
		Phone = @Phone,
		PaperAmount = @PaperAmount,
		PaperEndDay = @PaperEndDay
    where id = @Id
END