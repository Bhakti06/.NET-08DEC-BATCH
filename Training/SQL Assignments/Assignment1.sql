create table Product(
Id int primary key,
ProductName nvarchar(50),
UnitPrice decimal(12,2),
Package nvarchar(30),
IsDiscontinued bit
);
create table Customer(
Id int primary key,
FirstName nvarchar(40) not null,
LastName nvarchar(40),
City nvarchar(40),
Country nvarchar(40),
Phone nvarchar(20),
);

create table [Order](
Id int primary key,
OrderDate datetime not null,
OrderNumber nvarchar(10),
CustomerId int foreign key references Customer(id),
TotalAmount decimal(12,2)
);

create table OrderItem(
Id int primary key,
OrderId int foreign key references [Order](Id),
ProductId int foreign key references Product(Id),
UnitPrice decimal(12,2),
Quantity int
);

Select * from Customer

SELECT * FROM Customer WHERE Country LIKE 'A%' OR Country LIKE 'I%'

select FirstName from Customer where SUBSTRING(FirstName, 4 , 1) = 'I';