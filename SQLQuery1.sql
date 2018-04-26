--DROP DATABASE furnitureShop
CREATE DATABASE furnitureShop

CREATE TABLE ClientTitle
(
	CT_ID int identity(01,1) PRIMARY KEY NOT NULL,
	Title VARCHAR(5)
)

CREATE TABLE Client
(
	C_ID int identity(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(255) NOT NULL,
	Surname VARCHAR(255) NOT NULL,
	IDNum int NOT NULL,
	
	FOREIGN KEY (CT_ID) INT REFERENCES ClientTitle(CT_ID) NOT NULL
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
	F_Type VARCHAR(255),
	FOREIGN KEY (F_Type) REFERENCES FurnitureType(Furn_Type)
)

