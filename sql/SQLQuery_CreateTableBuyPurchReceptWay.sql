DROP TABLE IF EXISTS ProductBuy, Purchase, Buyer, Recept, WayOfUse

CREATE TABLE WayOfUse
(
Id INT PRIMARY KEY,
Way NVARCHAR(150) not null,
)

INSERT INTO WayOfUse (Id, Way)
VALUES
(1, 'По одной таблетке, 3 раза в день, после еды'),
(2, 'По две таблетки, 1 раза в день, во время еды'),
(3, 'По две таблетки, 2 раза в день, натощак'),
(4, 'По одной таблетке, 5 раз в день')



CREATE TABLE Recept
(
Id INT PRIMARY KEY,
FIO_Doctor NVARCHAR(100) NOT NULL,
Diagnos nvarchar(100) NOT NULL,
WayOfUseCode INT FOREIGN KEY REFERENCES WayOfUse(Id) ON DELETE CASCADE,
)

INSERT INTO Recept (Id, FIO_Doctor, Diagnos, WayOfUseCode)
VALUES
(1, 'Иванов Иван Иванович', 'Бронхит', 2),
(2, 'Петров Пётр Петрович', 'Нехватка витамина Б', 4),
(3, 'Петров Пётр Петрович', 'Сердечная недостаточность', 3),
(4, 'Петров Пётр Петрович', 'Сыпь', 1)


CREATE TABLE Buyer
(
Id INT PRIMARY KEY IDENTITY,
FIO NVARCHAR(100) NOT NULL,
PhoneNumber VARCHAR(20) UNIQUE NOT NULL,
Age INT CHECK(Age > 0 AND Age < 100),
ReceptCode INT FOREIGN KEY REFERENCES Recept(Id) ON DELETE CASCADE,
KolvoGoods INT NOT NULL,
)

INSERT INTO Buyer (FIO, PhoneNumber, Age, ReceptCode, KolvoGoods)
VALUES
('Иванов Андрей Сергеевич', 89272834119, 34, 1, 2),
('Алматов Пётр Евгеньевич', 89605142810, 58, 2, 4),
('Исмаилов Сергей Валерьевич', +79375855738, 19, 2, 3),
('Бугуров Артём Петрович', 89029403295, 27, 1, 3),
('Васин Данила Сергеевич', +79275906090, 26, 1, 6),
('Урский Альберт Трофимович', +79892381910, 64, 2, 1),
('Петров Сергей Андреевич', 89600142748, 70, 2, 1)



CREATE TABLE Purchase
(
Id INT PRIMARY KEY IDENTITY,
BuyerId INT FOREIGN KEY REFERENCES Buyer(Id) ON DELETE CASCADE,
Summ INT NOT NULL
)

INSERT INTO Purchase (BuyerId, Summ)
VALUES
(1, 570),
(4, 1053),
(5, 2100),
(7, 315),
(2, 1790)

CREATE TABLE ProductBuy
(
PurchaseId INT FOREIGN KEY REFERENCES Purchase (Id) ON DELETE CASCADE,
ProductNumber INT FOREIGN KEY REFERENCES Product (Number),
PRIMARY KEY(PurchaseId, ProductNumber)
)

INSERT INTO ProductBuy(PurchaseId,ProductNumber)
VALUES
(1,170310101),
(1,170310202),
(1,170310304),
(2,170313302),
(2,170310106),
(3,170317302),
(3,170317304),
(3,170318101),
(4,170318202),
(4,170318205),
(5,170310201)