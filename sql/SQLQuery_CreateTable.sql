

create table Dir_wayUse(
Code int primary key,
Way_use nvarchar(200) not null,
)



create table Doctors(
Id int primary key,
FIO nvarchar(100) not null,
Licensy nvarchar(100) not null,
)



create table Recept(
Code int primary key,
Id_doctor int REFERENCES Doctors (Id),
Diagnos nvarchar(50) not null,
Kolvo_lek int not null,
Code_way INT REFERENCES Dir_wayUse (Code),
Kolvo_tovar tinyint not null,
)



create table Buyer(
Id int primary key,
FIO nvarchar(100) not null,
Phone_num varchar(12) not null,
Age int not null,
Code_recept INT REFERENCES Recept (Code),
Kolvo_tovar tinyint not null,
)


create table Dir_suppGoods(
Id int primary key,
)

create table Providers(
Id int primary key,
Name nvarchar(100) not null,
Id_suppGoods int foreign key references Dir_suppGoods (Id),

)

create table Supp_providerGoods(
Id_suppGoods int foreign key references Dir_suppGoods (Id),
Id_provider int foreign key references Providers (Id),
Price int not null,
)

create table Orders(
Id int primary key,
Date date not null,
sum_order int not null,
id_provider int foreign key references Providers(Id),
)


create table Purchases(
Id int primary key,
Id_buyer int references Buyer (Id),
Sum_purch int not null,
Id_order int references Orders (Id),
)



create table Products_category(
Code int primary key,
Name nvarchar(150) not null,
kolvo_goods int not null,
)

create table Products_subcategory(
Code int primary key,
Code_category int foreign key references Products_category(Code),
Name nvarchar(150) not null,
kolvo_goods int not null,
)

create table Products_group(
Code int primary key,
Code_subcategory int foreign key references Products_subcategory(Code),
Name nvarchar(150) not null,
kolvo_goods int not null,
)

create table Goods(
id int primary key,
Name nvarchar(100) not null,
Price int not null,
Expir_date date not null,
Creator nvarchar(100) not null,
Code_productGroup int foreign key references Products_group(Code),
Options nvarchar(200) not null,
)

create table Buying_goods(
Id_purch int foreign key references Purchases(Id) primary key,
Id_good int primary key references Goods(Id),

)
