create database aniketaprilbatch;
use aniketaprilbatch;

create table employee(id int primary key identity,name varchar(100),email varchar(200),salary decimal(9,2), dept varchar(100));





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