CREATE PROC dbo.Client_Insert
	@Name varchar(30), 
	@DateBirth date,
	@Email varchar(30),
	@Phone varchar(20),
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
