-- DELETING DATABASES
/*USE master
GO
ALTER DATABASE [TaxiCompany1] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
ALTER DATABASE [TaxiCompany2] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
DROP DATABASE [TaxiCompany1]
DROP DATABASE [TaxiCompany2]
GO*/

/*USE TaxiCompany1;
CREATE TABLE AdminUsers
(
	id int IDENTITY(1,1) NOT NULL,
	userName nvarchar(100) NOT NULL,
	userPassword nvarchar(100) NOT NULL
	CONSTRAINT PK_AdminID PRIMARY KEY (id)
)

GO

INSERT INTO AdminUsers
VALUES	(N'admin', N'admin')

GO*/

USE TaxiCompany2;

-- Car Types Table
CREATE TABLE CarTypes
(
	CarTypeID int IDENTITY(1,1) not null,
	CarTypeName nvarchar(100) not null,
	CONSTRAINT PK_CarTypeID PRIMARY KEY (CarTypeID)
)

-- Cars Table
CREATE TABLE Cars
(
	CarID int IDENTITY(1,1) not null,
	CarType_id int not null,
	CarColor nvarchar(50) not null,
	CarNumber int not null,
	CONSTRAINT PK_CarID PRIMARY KEY(CarID),
	CONSTRAINT FK_Cars_CarTypes FOREIGN KEY (CarType_id) REFERENCES dbo.CarTypes(CarTypeID)	
)

-- Drivers Table
CREATE TABLE Drivers
(
	DriverID int IDENTITY(1,1) not null,
	DriverName nvarchar(100) not null,	
	Car_id int not null,	
	Available bit not null,
	CONSTRAINT PK_DriverID PRIMARY KEY(DriverID),
	CONSTRAINT FK_Drivers_Cars FOREIGN KEY (Car_id) REFERENCES dbo.Cars(CarID)	
)

ALTER TABLE Drivers
ADD CONSTRAINT def_driver_available DEFAULT 1 FOR[Available]

-- Orders Table
CREATE TABLE Orders
(
	OrderID int IDENTITY(1,1) not null,
	OrderTrackingNumber int not null,
	ClientName nvarchar(100) null,
	Destination_From nvarchar(100) not null,
	Destination_To nvarchar(100) null,
	PreferredCarTypeName nvarchar(100) null,
	OnlyThisCarType bit not null,
	AssignedDriver_id int null,
	OrderStatus int not null,
	CONSTRAINT PK_OrderID PRIMARY KEY(OrderID),	
	CONSTRAINT FK_Orders_Drivers FOREIGN KEY (AssignedDriver_id) REFERENCES dbo.Drivers(DriverID)
)

ALTER TABLE Orders
ADD CONSTRAINT def_order_status DEFAULT 0 FOR[OrderStatus]

ALTER TABLE Orders
ADD CONSTRAINT def_value_onlyThisCar DEFAULT 0 FOR[OnlyThisCarType]

GO

-- CREATING VIEW
CREATE VIEW DriversView
AS
SELECT DriverID, DriverName, CarTypeName, CarColor, CarNumber, Available
FROM Drivers as d
JOIN Cars as c ON d.Car_id = c.CarID 
JOIN CarTypes as ct ON ct.CarTypeID = c.CarType_id

GO

CREATE VIEW OrdersView
AS
SELECT 1 AS CompanyID ,*
	FROM (
		SELECT	OrderID,
				OrderTrackingNumber,
				ClientName,
				Destination_From,
				Destination_To,
				PreferredCarTypeName,
				OnlyThisCarType,
				DriverID,
				DriverName,
				CarTypeName,
				CarColor,
				CarNumber,
				OrderStatus
		FROM TaxiCompany1.dbo.Orders AS orders
		LEFT OUTER JOIN (
			SELECT DriverID, DriverName, CarTypeName, CarColor, CarNumber
			FROM TaxiCompany1.dbo.Drivers as d
			JOIN TaxiCompany1.dbo.Cars as c ON d.Car_id = c.CarID 
			JOIN TaxiCompany1.dbo.CarTypes as ct ON ct.CarTypeID = c.CarType_id
		) AS drivers ON orders.AssignedDriver_id = drivers.DriverID
	) AS taxi1Table
UNION
SELECT 2 AS CompanyID ,*
	FROM (
		SELECT	OrderID,
				OrderTrackingNumber,
				ClientName,
				Destination_From,
				Destination_To,
				PreferredCarTypeName,
				OnlyThisCarType,
				DriverID,
				DriverName,
				CarTypeName,
				CarColor,
				CarNumber,
				OrderStatus
		FROM TaxiCompany2.dbo.Orders AS orders
		LEFT OUTER JOIN (
			SELECT DriverID, DriverName, CarTypeName, CarColor, CarNumber
			FROM TaxiCompany2.dbo.Drivers as d
			JOIN TaxiCompany2.dbo.Cars as c ON d.Car_id = c.CarID 
			JOIN TaxiCompany2.dbo.CarTypes as ct ON ct.CarTypeID = c.CarType_id
		) AS drivers ON orders.AssignedDriver_id = drivers.DriverID
	) AS taxi2Table

GO

-- CREATING TRIGGERS
/*DROP TRIGGER OrderStatus_DriverAvailable*/
CREATE TRIGGER OrderStatus_DriverAvailable ON dbo.Orders
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @OrderIsExecuting AS INT = 1, @OrderIsClosed AS INT = 2;
	DECLARE @drID AS INT, @ordSt AS INT, @ordID AS INT;

	WITH a AS (
		SELECT AssignedDriver_id, OrderStatus
		FROM inserted
	)

	MERGE INTO Drivers as targetTable
	USING a as sourceTable
	ON targetTable.DriverID = sourceTable.AssignedDriver_id
	WHEN MATCHED THEN
		UPDATE SET Available = CASE sourceTable.OrderStatus
								WHEN @OrderIsExecuting THEN '0'
								WHEN @OrderIsClosed THEN '1'
								ELSE '1'
								END;
	
	UPDATE Drivers
	SET Available = 1
	WHERE NOT EXISTS(
		SELECT * FROM Orders WHERE AssignedDriver_id = Drivers.DriverID
	)

	SELECT @drID = AssignedDriver_id, @ordID = OrderID, @ordSt = OrderStatus FROM inserted
	IF @drID IS NULL AND @ordSt = 1
		UPDATE Orders
		SET OrderStatus = 0
		WHERE OrderID = @ordID
	
END;

GO

/*DROP TRIGGER OrderStatus_DriverAvailableWhenDeleted*/
CREATE TRIGGER OrderStatus_DriverAvailableWhenDeleted ON dbo.Orders
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
	WITH a AS (
		SELECT AssignedDriver_id FROM deleted
	)
	MERGE INTO Drivers AS targetTable
	USING a AS sourceTable
	ON targetTable.DriverID = sourceTable.AssignedDriver_id
	WHEN MATCHED THEN
		UPDATE SET Available = 1;
END

GO

-- CREATING STORED PROCEDURES
/*DROP PROCEDURE AddNewDriver*/
CREATE PROCEDURE AddNewDriver	@driverName AS NVARCHAR(100), 
								@carTypeName AS NVARCHAR(100), 
								@carColor AS NVARCHAR(50),
								@carNumber AS INT
AS
BEGIN
	SET NOCOUNT ON;
	-- geting carTypeID
	DECLARE @carTypeID AS INT;		

	SELECT @carTypeID = CarTypeID FROM CarTypes WHERE CarTypeName = @carTypeName
	IF @carTypeID IS NULL
		BEGIN
			DECLARE @carTypeIDTable AS TABLE (id INT)
			INSERT INTO CarTypes OUTPUT inserted.CarTypeID INTO @carTypeIDTable VALUES (@carTypeName)
			SELECT @carTypeID = id FROM @carTypeIDTable
		END
	
	-- inserting new value to Cars Table
	DECLARE @carID AS INT
	DECLARE @carIDTable AS TABLE (id INT)

	INSERT INTO Cars 
	OUTPUT inserted.CarID INTO @carIDTable
	VALUES (@carTypeID, @carColor, @carNumber)
	
	SELECT @carID = id FROM @carIDTable

	-- inserting new value to Drives Table
	INSERT INTO Drivers VALUES (@driverName, @carID, 1)
END;

GO

/*DROP PROCEDURE DeleteDriver*/
CREATE PROCEDURE DeleteDriver	@driverID INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Orders
	SET AssignedDriver_id = NULL, 
		OrderStatus = CASE OrderStatus
			WHEN 1 THEN 0
			WHEN 2 THEN 2
			ELSE 0
			END
	WHERE AssignedDriver_id = @driverID
		
	DECLARE @carID INT;
	SELECT @carID = Car_id FROM Drivers WHERE DriverID = @driverID
	DELETE FROM Drivers WHERE DriverID = @driverID
	DELETE FROM Cars WHERE CarID = @carID

END;

GO