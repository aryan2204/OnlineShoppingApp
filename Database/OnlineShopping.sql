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
Retailer_Email nvarchar(30),
password varchar(10)
);
-----------------------------------------------------

ALTER TABLE AdminDetails
  ALTER COLUMN username nvarchar(20);

  ALTER TABLE AdminDetails
  ALTER COLUMN password nvarchar(20);


insert into AdminDetails values(101,'Babu Rao','Mike911','qwerty@1')

insert into AdminDetails values(102,'Gopal','JamesBond20','random@123')

----------------------------------------------------

ALTER TABLE CutomerInfo
  ALTER COLUMN User_Name  nvarchar(20);

ALTER TABLE CutomerInfo
  ALTER COLUMN UserEmail nvarchar(30);

  ALTER TABLE CutomerInfo
  ALTER COLUMN Pass nvarchar(20);

    ALTER TABLE CutomerInfo
  ALTER COLUMN Address nvarchar(50);




  select * from CutomerInfo

insert into CutomerInfo values('Sam Wilson','samwilson12@gmail.com','9509578945','NightFury@90','40-wilson park, Manhatten,XYZ')
insert into CutomerInfo values('David Warner','warerdavid12@gmail.com','7854957945','Australia@90','10-Patrik Road,Melbourne,Australia')
