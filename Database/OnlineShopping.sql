Create database [Online Shopping]
use [Online Shopping]


CREATE TABLE ProducteDetails (
ProdID int NOT NULL PRIMARY KEY,
Product_Name nvarchar(10) NOT NULL,
Quantity int NOT NULL, 
Price float NOT NULL,
Prod_Description nvarchar(20) NOT NULL
);

Create Table CutomerInfo(
User_Name nvarchar(10) NOT NULL,
UserEmail nvarchar(20) Not null,
MobileNumber nvarchar(10) NOT NULL,
UID Int Identity(101,1) NOT NULL,
Pass nvarchar(1) NOT NULL,
Address varchar(30)
)


create table AdminDetails
(
AdminID int PRIMARY KEY,
AdminName nvarchar(10),
username varchar(10),
password varchar(10)
);

create table RetailorDetails
(
RetailorID int PRIMARY KEY,
RetailorName nvarchar(10),
Rusername varchar(10),
password varchar(10)
);
