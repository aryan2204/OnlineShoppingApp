use db_OnlineShopping

create proc UpdateProductForRetailer(@id int, @name nvarchar(20), @quan int, @price float) 
as 
begin 
update ProducteDetails set  Product_Name = @name, Quantity = @quan, Price=@price where ProdId = @id 
end

create proc DeleteProductForRetailer(@id int)
as
begin 
delete from ProducteDetails where ProdID = @id 
end

drop proc DeleteProductForRetailer

create proc DeleteProductForRetailer(@name nvarchar(20))
as
begin 
delete from ProducteDetails where Product_Name = @name
end
