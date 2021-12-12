CREATE PROC dbo.Client_SelectById	
	@Id int
AS
BEGIN
	select
		Id,
		FirstName,
		LastName,
		DateBirth,
		Email,
		Phone,
		PaperAmount,
		PaperEndDay
	from dbo.Client
	where Id =@Id
END
