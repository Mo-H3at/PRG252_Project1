
CREATE PROCEDURE SPInsertNewJetDetails
		@newJet varchar(50),
		@newFuelTankCapacity int,
		@newHeight decimal(18, 2),
		@newMaxWeight decimal(18, 2),
		@newSpeed decimal(18, 2),
		@newInventory int

AS
BEGIN
	INSERT INTO tblReport(JetModel,FuelTankCapacity,Height,MaxWeight,Speed,InventoryID)
	VALUES (@newJet,@newFuelTankCapacity,@newHeight,@newMaxWeight,@newSpeed,@newInventory)
END
GO

CREATE PROCEDURE SPUpdateFuel
		@idToUpdate int,
		@fuelLevelToUpdate int

AS
BEGIN
	UPDATE tblJet
	Set FuelTankCapacity = @fuelLevelToUpdate
	WHERE JetID = @idToUpdate
END
GO

CREATE PROCEDURE SPInsertObstacle
		@DescriptionToAdd varchar(MAX),
		@RangeToAdd int

AS
BEGIN
	INSERT INTO tblObstacles(Description,Range)
	VALUES (@DescriptionToAdd,@RangeToAdd)
	
END
GO