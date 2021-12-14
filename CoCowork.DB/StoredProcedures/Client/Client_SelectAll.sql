CREATE PROC dbo.Client_SelectAll
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
END
