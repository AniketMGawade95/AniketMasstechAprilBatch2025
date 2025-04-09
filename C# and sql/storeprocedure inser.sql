create database aniketaprilbatch;
use aniketaprilbatch;

create table employee(id int primary key identity,name varchar(100),email varchar(200),salary decimal(9,2), dept varchar(100));

truncate table employee;



create procedure insertdata
@NAME varchar(100),
@EMAIL varchar(200),
@SALARY decimal(9,2),
@DEPT varchar(100)
as
begin
insert into employee values(@NAME,@EMAIL,@SALARY,@DEPT);
end


create procedure fetchdata
as
begin
select * from employee;
end

create procedure updatedata
@NAME varchar(100)=null,
@EMAIL varchar(200)=null,
@SALARY decimal(9,2)=null,
@DEPT varchar(100)=null,


@ID int=null
as 
begin
update employee set name=@NAME,email=@EMAIL,salary=@SALARY,dept=@DEPT where id=@ID;
end

create procedure deletedata
@ID int
as
begin
delete from employee where id=@ID;
end


create procedure readperticulardata
@ID int
as
begin
select * from employee where id=@ID;
end

create procedure searchemployee
@str varchar(100)
as
begin
select * from employee where name like '%'+@str+'%' or dept like '%'+@str+'%';
end


alter table employee add  netsal decimal(9,2);



create procedure addemployee
@NAME varchar(100),
@EMAIL varchar(200),
@SALARY decimal(9,2),
@DEPT varchar(100)
as
begin
declare @pf decimal(9,2)
declare @netsal decimal(9,2)
set @pf=@SALARY*0.1;
set @netsal=@SALARY-@pf;
insert into employee values(@NAME,@EMAIL,@SALARY,@DEPT,@netsal);
end



create procedure updateempdata
@NAME varchar(100)=null,
@EMAIL varchar(200)=null,
@SALARY decimal(9,2)=null,
@DEPT varchar(100)=null,
@ID int=null
as 
begin
declare @pf decimal(9,2)
declare @netsal decimal(9,2)
set @pf=@SALARY*0.1;
set @netsal=@SALARY-@pf;
update employee set name=@NAME,email=@EMAIL,salary=@SALARY,dept=@DEPT,netsal=@netsal where id=@ID;
end



create table login
(
id int primary key identity,
userid varchar(100),
email varchar(100),
pass varchar(200)
);


create procedure addlogin
@USERID varchar(100),
@EMAIL varchar(200),
@PASSWORD varchar(100)
as
begin
insert into login values(@USERID,@EMAIL,@PASSWORD);
end


create procedure signin
@username varchar(100),
@password varchar(100)
as
begin
select * from login where userid=@username and pass=@password;
end