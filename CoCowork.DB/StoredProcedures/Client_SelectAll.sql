CREATE PROC dbo.Client_SelectAll
AS
BEGIN
	select
		Id,
		Name,
		DateBirth,
		Email,
		Phone,
		PaperAmount,
		PaperEndDay
	from dbo.Client
END
