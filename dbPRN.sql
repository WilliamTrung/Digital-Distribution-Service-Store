--DROP TABLE
DROP TABLE tblProducts
DROP TABLE tblCategories
DROP TABLE tblOrderDetails
DROP TABLE tblOrders
--CREATE TABLE
CREATE TABLE tblCategories(
	categoryId INT IDENTITY(0,1) PRIMARY KEY ,
	categoryName NVARCHAR(100) NOT NULL
)
CREATE TABLE tblProducts(
	productId INT IDENTITY(0,1) PRIMARY KEY ,
	productName NVARCHAR(100) NOT NULL,
	productQuantity INT NOT NULL,
	productPrice NUMERIC(10) NOT NULL,
	categoryId INT REFERENCES tblCategories
)
CREATE TABLE tblOrders(
	orderId INT IDENTITY(0,1) PRIMARY KEY,
	orderDate DATETIME NOT NULL,
	orderTotal NUMERIC(20) NOT NULL
)
CREATE TABLE tblOrderDetails(
	orderDetail INT IDENTITY(0,1) PRIMARY KEY,
	orderId INT REFERENCES tblOrders,
	productId INT REFERENCES tblProducts,
	quantity INT NOT NULL,
	price NUMERIC(10) NOT NULL
)
--INSERT VALUES
INSERT INTO tblCategories(categoryName) VALUES ('RPG')
INSERT INTO tblCategories(categoryName) VALUES ('Casual')
INSERT INTO tblCategories(categoryName) VALUES ('Soul-like')

