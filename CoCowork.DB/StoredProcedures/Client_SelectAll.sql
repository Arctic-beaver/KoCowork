CREATE PROC dbo.Client_SelectAll
AS
BEGIN
	select
		Id,
		Name,
		Date,
		Email,
		Phone,
		PaperAmount,
		PaperEndDay
	from dbo.Client
END
