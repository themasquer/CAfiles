select * from products p left outer join  [Order Details] od
on p.ProductID = od.ProductID
left outer join Orders o on o.OrderID = od.OrderID

create table Country
(
	CountryID int primary key identity(1, 1),
	CountryName varchar(50) not null
)

create table City
(
	CityID int primary key identity(1, 1),
	CityName varchar(100) not null,
	CountryID int
)

insert into Country select distinct ShipCountry from [Orders] order by 1

select * from country

insert into City (CityName, CountryID) 
select distinct siparis.ShipCity,
(select ulke.CountryID from Country ulke where ulke.CountryName = siparis.ShipCountry)
from orders siparis order by ShipCity

select top 5 * from orders
select * from country
select * from city

select * from country inner join city on country.CountryID = city.CountryID

insert into City (CityName, CountryId)
select distinct ShipCity, CountryId 
from orders inner join country on orders.ShipCountry = country.CountryName
order by orders.ShipCity

truncate table City

select * from city order by cityname

alter table Orders add CountryID int
alter table Orders add CityID int

update Orders 
set Orders.CountryID = c.CountryID
from
Country c inner join Orders o on c.CountryName = o.ShipCountry

update Orders 
set Orders.CityID = c.CityID
from
City c inner join Orders o on c.CityName = o.ShipCity

select * from orders

