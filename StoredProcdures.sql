use db_OnlineShopping

alter table ProducteDetails
add BrandName nvarchar(20)

create proc UpdateProductDetails(@id int, @name nvarchar(20), @quan int, @price float, @prodDescription nvarchar(20), @brand nvarchar(20))
as 
begin 
update ProducteDetails set  Product_Name = @name, Quantity = @quan, Price=@price, Prod_Description =  @prodDescription , BrandName = @brand where ProdId = @id 
end

create proc InsertProductDetails(@id int, @name nvarchar(20), @quan int, @price float, @prodDescription nvarchar(20), @brand nvarchar(20))
as 
begin 
insert into ProducteDetails(ProdID,Product_Name,Quantity,Price, Prod_Description, BrandName) values (@id,@name,@quan,@price,@prodDescription,@brand)
end

create proc DeleteProductDetails(@id int)
as
begin 
delete from ProducteDetails where ProdID = @id 
end

create proc ViewProductDetails
as
begin 
select * from ProducteDetails
end

create proc UpdateAdminPassword(@pass nvarchar(20), @name nvarchar(20))
as 
begin 
update AdminDetails set password = @pass where username = @name
end

create proc UpdateCustomerPassword(@pass nvarchar(20), @name nvarchar(20))
as 
begin 
update CutomerInfo set Pass = @pass where User_Name = @name
end

create proc UpdateRetailerPassword(@pass nvarchar(20), @name nvarchar(20))
as 
begin 
update RetailorDetails set password = @pass where Rusername= @name
end