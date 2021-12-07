CREATE PROC dbo.Client_SelectById	
	@Id int
AS
BEGIN
	select
		id,
		name,
		dateBirth,
		email,
		phone,
		paperAmount,
		paperEndDay
	from dbo.Client
	where id =@Id
END
