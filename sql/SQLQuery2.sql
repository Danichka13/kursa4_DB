DROP TABLE IF EXISTS Orders, Supplier

CREATE TABLE Supplier
(
Id INT PRIMARY KEY IDENTITY,
FIO NVARCHAR(100) NOT NULL,
SuppGoods NVARCHAR(200) NOT NULL
)

INSERT INTO Supplier (FIO, SuppGoods)
VALUES
('Васнецов Иван Игоревич', 'Раносепт, Миролла, Офломедил, Бунти, Спазмалгон'),
('Пушкин Сергей Петрович', 'Витамишка, Визин, МультиБ, Генферон'),
('Изюмов Георгий Альбертович', 'Арбидол, Супрастин, Витамишка, Смазмалгон')


CREATE TABLE Orders
(
Id INT PRIMARY KEY IDENTITY,
Date DATE NOT NULL,
Summ INT NOT NULL,
Id_Supplier INT FOREIGN KEY REFERENCES Supplier(Id) ON DELETE CASCADE
)

INSERT INTO Orders (Date, Summ, Id_Supplier)
VALUES
('17.06.2023', 15200, 3),
('17.06.2023', 20300, 1),
('17.06.2023', 7530, 3),
('17.06.2023', 32000, 2),
('17.06.2023', 24100, 1)