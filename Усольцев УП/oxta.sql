use OxtaPark4
Create table Post
(
id_post int primary key identity,
NamePost nvarchar(40),
)



Create table Employes
(
id_Emp int primary key identity,
Lastname nvarchar(40),
Name nvarchar(40),
Patronyme nvarchar(40),
id_pos int,
foreign key(id_pos) references Post(id_post),
Login nvarchar(40),
Password nvarchar(40),

)



Create table HistoryEnter
(
id_History int primary key identity,
id_Emplo int,
foreign key(id_Emplo) references Employes(id_Emp),
datetimehistory datetime,
typeentry nvarchar(10), -- Тип входа
)



Create table Client
(
id_Client int primary key identity,
Lastname nvarchar(40),
Name nvarchar(40),
Patronyme nvarchar(40),
CodeClient int,
Passport nvarchar(50),
Datebirth date,
Adress nvarchar(80),
Email nvarchar(40),
Password nvarchar(40),
)

Create table Service -- Услуги
(
id_Serv int primary key identity,
NameService nvarchar(40),
codeservice nvarchar(20),
Cost money,-- стоимость
)

Create table StatusOrder
(
id_StatusOrd int primary key identity,
NameStatus nvarchar(40)
)


Create table Orderr
(
id_Order int primary key identity,
CodeOrder nvarchar(80),
DateCreate date,
Timecreate time,
CodeClient int,
id_Status int,
foreign key(id_Status) references StatusOrder(id_StatusOrd),
DateClose date, 
RentalTime nvarchar(15), -- Время проката
)

create table OrderService
(
id_OrderServ int primary key identity,
id_Order int,
foreign key(id_Order) references Orderr(id_Order),
id_Servic int,
foreign key(id_Servic) references Service(id_Serv)
)