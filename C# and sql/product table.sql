create table product(
pid int primary key identity,
pname varchar(100),
pcategory varchar(100),
price decimal,
pic varchar(250)
);


--for inserting 
create procedure insertproductdata
@PNAME varchar(100),
@PCATEGORY varchar(100),
@PRICE decimal,
@PIC varchar(100)

as
begin
insert into product values(@PNAME,@PCATEGORY,@PRICE,@PIC);
end

--procuct list

create procedure productlist
as
begin
select * from product;
end
