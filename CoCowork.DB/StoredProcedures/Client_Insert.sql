CREATE PROC dbo.Client_Insert
	@Name varchar, 
	@Date DateTime,
	@Email varchar,
	@Phone varchar,
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	insert into dbo.Client
		(Name, 
		Date, 
		Email,
		Phone,
		PaperAmount,
		PaperEndDay)
	values 
		(@Name, 
		@Date, 
		@Email,
		@Phone,
		@PaperAmount,
		@PaperEndDay)
END
