CREATE PROC dbo.Client_Insert
	@Name varchar, 
	@DateBirth DateTime,
	@Email varchar,
	@Phone varchar,
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	insert into dbo.Client
		(Name, 
		DateBirth, 
		Email,
		Phone,
		PaperAmount,
		PaperEndDay)
	values 
		(@Name, 
		@DateBirth, 
		@Email,
		@Phone,
		@PaperAmount,
		@PaperEndDay)
END
