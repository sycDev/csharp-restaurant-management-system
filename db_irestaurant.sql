CREATE DATABASE db_irestaurant;

USE db_irestaurant;

CREATE TABLE users
(
userId INT PRIMARY KEY IDENTITY,
username VARCHAR(50) NOT NULL,
password VARCHAR(100) NOT NULL,
name VARCHAR(50) NOT NULL,
phone VARCHAR(20)
)

CREATE TABLE tables
(
tableId INT PRIMARY KEY IDENTITY,
tableName VARCHAR(15)
)

CREATE TABLE staff
(
staffId INT PRIMARY KEY IDENTITY,
staffName VARCHAR(50),
staffPhone VARCHAR(30),
staffRole VARCHAR(50)
)

CREATE TABLE category
(
categoryId INT PRIMARY KEY IDENTITY,
categoryName VARCHAR(50) NOT NULL
)

CREATE TABLE product
(
productId INT PRIMARY KEY IDENTITY,
productName VARCHAR(50) NOT NULL,
productPrice DECIMAL(18, 2) NOT NULL,
productImage IMAGE,
categoryId INT NOT NULL
)

CREATE TABLE orders
(
orderId INT PRIMARY KEY IDENTITY,
orderDate DATE NOT NULL,
orderTime VARCHAR (15) NOT NULL,
tableName VARCHAR (10),
waiterName VARCHAR (50),
status VARCHAR (15) NOT NULL,
orderType VARCHAR (15) NOT NULL,
total DECIMAL (18, 2) NOT NULL,
received DECIMAL (18, 2),
change DECIMAL (18, 2),
driverId INT,
customerName VARCHAR (50),
customerPhone VARCHAR (30)
)

CREATE TABLE orderDetails
(
orderDetailsId INT PRIMARY KEY IDENTITY,
orderId INT NOT NULL,
productId INT NOT NULL,
qty INT NOT NULL,
price DECIMAL(18, 2) NOT NULL,
amount DECIMAL(18, 2) NOT NULL,
)

INSERT INTO users VALUES('admin', 'Admin123', 'Admin', '016-1234567');
