﻿CREATE PROC dbo.Room_Insert
	@Type int,
	@AmountOfPeople int,
	@PricePerHour decimal(10,2)
AS
BEGIN
	insert into dbo.Room
		(TypeId,
		AmountOfPeople,
		PricePerHour)
	values 
		(@Type,
		@AmountOfPeople,
		@PricePerHour)
END