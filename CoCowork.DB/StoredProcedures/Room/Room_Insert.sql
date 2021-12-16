﻿CREATE PROC dbo.Room_Insert
	@Type int,
	@AmountOfPeople int,
	@PricePerHour decimal(10,2),
	@Name varchar
AS
BEGIN
	insert into dbo.Room
		(TypeId,
		AmountOfPeople,
		PricePerHour, 
		[Name])
	values 
		(@Type,
		@AmountOfPeople,
		@PricePerHour,
		@Name)
END
