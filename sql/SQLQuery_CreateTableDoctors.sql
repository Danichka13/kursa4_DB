DROP TABLE Doctors 

CREATE TABLE Doctors
(
Id INT PRIMARY KEY IDENTITY,
FIO nvarchar(100) not null,
licensy int not null,
)

INSERT INTO Doctors (FIO, licensy)
VALUES
('Иванов Иван Иванович', 1),
('Петров Пётр Петрович', 3)

SELECT * FROM Doctors