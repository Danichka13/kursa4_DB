DROP TABLE Doctors 

CREATE TABLE Doctors
(
Id INT PRIMARY KEY IDENTITY,
FIO nvarchar(100) not null,
licensy int not null,
)

INSERT INTO Doctors (FIO, licensy)
VALUES
('������ ���� ��������', 1),
('������ ϸ�� ��������', 3)

SELECT * FROM Doctors