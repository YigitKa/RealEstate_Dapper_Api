-- CREATE DATABASE DbDapperRealEstate
-- USE DbDapperRealEstate

/* CREATE TABLE Category 
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50),
    CategoryStatus bit
)
*/
 /*
CREATE TABLE Product 
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100),
    Price DECIMAL(18,2),
    CoverImage NVARCHAR(250),
    City NVARCHAR(100),
    District NVARCHAR(100),
    Address NVARCHAR(500),
    Description NVARCHAR(MAX),
    ProductCategory INT,
)
*/
/*
CREATE TABLE ProductDetails
(
    ProductDetailID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT,
    ProductSize INT,
    BedroomCount TINYINT,
    BathCount TINYINT,
    RoomCount TINYINT,
    GarageSize TINYINT,
    BuildYear CHAR(4),
    Price DECIMAL (18,2),
    Location NVARCHAR(500),
    VideoURL NVARCHAR(500)
)
*/
/*
CREATE TABLE Client
(
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Title NVARCHAR(100),
    Comment NVARCHAR(2000)
)
*/
/*
CREATE TABLE Employee 
(
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Title NVARCHAR(100),
    Phone NVARCHAR(100),
    Mail NVARCHAR(100),
    ImageURL NVARCHAR(100),
    Status BIT
)
*/
/*
ALTER TABLE ProductDetails
ADD FOREIGN KEY (ProductID) REFERENCES Product(ProductID);

ALTER TABLE Product
ADD FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);



ALTER TABLE Product
ADD FOREIGN KEY (ProductCategory) REFERENCES Category(CategoryID);

*/

/*
CREATE TABLE WhoWeAreDetail
(
    WhoWeAreDetailID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100),
    SubTitle NVARCHAR(100),
    Description1 NVARCHAR(500),
    Description2 NVARCHAR(500),
)
*/

/*
CREATE TABLE Services
(
    ServiceID INT PRIMARY KEY IDENTITY(1,1),
    ServiceName NVARCHAR(100),
    ServiceStatus bit,
)
*/