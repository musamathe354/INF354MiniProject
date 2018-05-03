--DROP DATABASE furnitureShop
CREATE DATABASE furnitureShop

USE furnitureShop


CREATE TABLE ClientTitle
(
	CT_ID int identity(01,1) PRIMARY KEY NOT NULL,
	Title VARCHAR(5)
)

--DROP TABLE Client

CREATE TABLE Client
(
	C_ID int identity(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(255) NOT NULL,
	Surname VARCHAR(255) NOT NULL,
	IDNum int NOT NULL,
	
	CT_ID INT REFERENCES ClientTitle(CT_ID) NOT NULL
)

CREATE TABLE FurnitureType
(
	FT_ID int identity(1,1) PRIMARY KEY NOT NULL,
	Furn_Type VARCHAR(255)
)

CREATE TABLE Furniture
(
	F_ID int identity(1,1) PRIMARY KEY NOT NULL,
	F_Name VARCHAR(255),
	Quantity int,
	FT_ID INT REFERENCES FurnitureType(FT_ID)
)

INSERT INTO ClientTitle(Title)
VALUES ('Mr'), ('Miss')

INSERT INTO Client(Name,Surname,IDNum,CT_ID)
VALUES ('Musa','Mathe', 0897856, 1)

INSERT INTO FurnitureType(Furn_Type)
VALUES ('Kitchen'), ('Living Room')

INSERT INTO Furniture(F_Name, Quantity, FT_ID)
VALUES ('Lounge table', 18, 1)

SELECT * FROM ClientTitle
GO

SELECT * FROM Client
GO

SELECT * FROM FurnitureType
GO

SELECT * FROM Furniture
GO

