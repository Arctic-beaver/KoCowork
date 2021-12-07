CREATE PROC dbo.Client_SelectById	
	@Id int
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
	where Id =@Id
END
