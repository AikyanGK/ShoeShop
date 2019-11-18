create database ShoeShop
use ShoeShop

create table Shoes
(
	 productCode int primary key,
	 model varchar(50),
	 stocks int,
	 price money,
)
insert into Shoes (productCode, model, stocks, price)

values (0,'Beijing', 50, 300.00),
	   (1, 'Taipei', 50, 300.00),
	   (2, 'Tokyo', 50, 300.00),
	   (3, 'Shanghai', 50, 300.00),
	   (4, 'Guangzhou', 50, 300.00),
	   (5 ,'Houston', 50, 300.00),
	   (6, 'Los Angeles', 50, 300.00),
	   (7, 'Manila', 50, 300.00),
	   (8, 'New York', 50, 300.00),
	   (9, 'Berlin', 50, 300.00),
	   (10, 'Miami', 50, 300.00);

update Shoes
set price = 6500.00