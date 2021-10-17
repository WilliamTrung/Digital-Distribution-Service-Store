--DROP TABLE
DROP TABLE tblProducts
DROP TABLE tblCatagories
DROP TABLE tblOrderDetails
DROP TABLE tblOrders
--CREATE TABLE
CREATE TABLE tblCatagories(
	catagoryId INT IDENTITY(0,1) PRIMARY KEY ,
	catagoryName NVARCHAR(100) NOT NULL
)
CREATE TABLE tblProducts(
	productId INT IDENTITY(0,1) PRIMARY KEY ,
	productName NVARCHAR(100) NOT NULL,
	productQuantity INT NOT NULL,
	productPrice NUMERIC(10) NOT NULL,
	categoryId INT REFERENCES tblCatagories
)
CREATE TABLE tblOrders(
	orderId INT IDENTITY(0,1) PRIMARY KEY,
	orderDate DATETIME NOT NULL,
	orderTotal NUMERIC(20) NOT NULL
)
CREATE TABLE tblOrderDetails(
	orderId INT REFERENCES tblOrders,
	productId INT REFERENCES tblProducts,
	quantity INT NOT NULL,
	price NUMERIC(10) NOT NULL
)
--INSERT VALUES
INSERT INTO tblCatagories(catagoryName) VALUES ('RPG')
INSERT INTO tblCatagories(catagoryName) VALUES ('Casual')
INSERT INTO tblCatagories(catagoryName) VALUES ('Soul-like')

