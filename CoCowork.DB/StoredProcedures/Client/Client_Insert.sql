CREATE PROC dbo.Client_Insert
	@FirstName varchar(20),
	@LastName varchar(20), 
	@DateBirth date,
	@Email varchar(30),
	@Phone varchar(20),
	@PaperAmount int,
	@PaperEndDay DateTime
AS
BEGIN
	insert into dbo.Client
		(FirstName,
		LastName, 
		DateBirth, 
		Email,
		Phone,
		PaperAmount,
		PaperEndDay)
	values 
		(@FirstName,
		@LastName, 
		@DateBirth, 
		@Email,
		@Phone,
		@PaperAmount,
		@PaperEndDay)
SELECT SCOPE_IDENTITY()
END
