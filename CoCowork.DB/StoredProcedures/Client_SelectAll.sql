CREATE PROC dbo.Client_SelectAll
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
END
