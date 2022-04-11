create table Customer (
	ID int primary key identity,
	Name nvarchar(100) not null,
	INN bigint not null,
	Address nvarchar(255)
);

create table Account (
	ID int primary key identity,
	Account decimal(20,0) not null,
	Name varchar(100),
	BIK int not null,
	Balance decimal(17, 2) not null,
	CustomerID int not null,
	foreign key (CustomerID) references Customer (ID) on delete cascade
);

