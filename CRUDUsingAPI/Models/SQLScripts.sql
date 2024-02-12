create database B21APICRUDDB
go
use B21APICRUDDB
go
create table Category
(
Id int primary key identity,
Name varchar(50)
)
go
insert into Category values('Men'), ('Kids'), ('Women') 
go
create table Product
(
Id int primary key identity,
Name varchar(50),
Price decimal(18,2),
CategoryId int foreign key references Category(Id)
)
go
insert into Product values ('Shirt', 599, 1), ('Jeans', 799, 1)

insert into Product values  ('TShirt', 150, 2), ('Skirt', 577, 3)

go

select * from Category
select * from Product
