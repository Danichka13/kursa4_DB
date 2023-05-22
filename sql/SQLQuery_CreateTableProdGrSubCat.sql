DROP TABLE IF EXISTS Product, ProductGroup, ProductSubcategory, ProductCategory

CREATE TABLE ProductCategory
(
Code INT PRIMARY KEY,
Name NVARCHAR(50) NOT NULL,
ProductCount int,
)

INSERT INTO ProductCategory (Code, Name, ProductCount)
VALUES (1703, '������������� ��������', 49)


CREATE TABLE ProductSubcategory
(
ProductCategoryCode INT REFERENCES ProductCategory (Code),
Code INT PRIMARY KEY,
Name NVARCHAR(50) NOT NULL,
ProductCount INT,
)

INSERT INTO ProductSubcategory (ProductCategoryCode, Code, Name, ProductCount)
VALUES
(1703, 10, '���������������', 13),
(1703, 13, '��������������', 9),
(1703, 17, '��������', 17),
(1703, 18, '�����������', 10)


CREATE TABLE ProductGroup
(
ProductSubcategoryCode INT REFERENCES ProductSubcategory (Code),
Code INT,
Name nvarchar(50) NOT NULL,
ProductCount INT,
PRIMARY KEY(Code, ProductSubcategoryCode)
)

INSERT INTO ProductGroup(ProductSubCategoryCode, Code, Name, ProductCount)
VALUES
(10, 1, '��������������� ��������', 6),
(10, 2, '��������������� ������', 3),
(10, 3, '��������������� �����', 4),
(10, 4, '��������������� ������', 0),
(13, 1, '�������������� ��������', 4),
(13, 2, '�������������� ������', 2),
(13, 3, '�������������� �����', 3),
(17, 1, '�������� A', 2),
(17, 2, '�������� B', 4),
(17, 3, '�������� C', 3),
(17, 4, '�������� D', 5),
(17, 5, '�������� E', 3),
(18, 1, '����������� ����', 4),
(18, 2, '����������� �����', 6)


CREATE TABLE Product
(
Number INT PRIMARY KEY, -- 1703 10 1 01 - ������ ��������
ProductSubcategoryCode INT,
Code INT,
Name nvarchar(50),
Price MONEY NOT NULL,
ExpirationDate DATETIME NOT NULL,
FOREIGN KEY (Code, ProductSubcategoryCode) REFERENCES ProductGroup(Code, ProductSubcategoryCode)
)

INSERT INTO Product (Number, ProductSubcategoryCode, Code, Name, Price, ExpirationDate)
VALUES
(170310101, 10, 1, '�������', 200, '12.04.2025'),
(170310102, 10, 1, '�������', 200, '12.04.2025'),
(170310103, 10, 1, '�������', 200, '12.04.2025'),
(170310104, 10, 1, '�������', 300, '18.06.2027'),
(170310105, 10, 1, '�������', 300, '18.09.2027'),
(170310106, 10, 1, '��������', 700, '02.01.2026'),
(170310201, 10, 2, '�������', 350, '30.05.2025'),
(170310202, 10, 2, '�������', 350, '30.05.2025'),
(170310203, 10, 2, '���������', 250, '29.05.2025'),
(170310301, 10, 3, '���', 100, '30.10.2026'),
(170310302, 10, 3, '��������', 200, '16.01.2024'),
(170310303, 10, 3, '��������', 200, '16.01.2024'),
(170310304, 10, 3, '�������', 170, '01.12.2030'),

(170313101, 13, 1, '�������', 150, '07.11.2028'),
(170313102, 13, 1, '�������', 300, '12.04.2025'),
(170313103, 13, 1, '���������', 300, '12.04.2025'),
(170313104, 13, 1, '���������', 300, '12.04.2025'),
(170313201, 13, 2, '��������', 90, '12.04.2025'),
(170313202, 13, 2, '�������', 200, '12.04.2025'),
(170313301, 13, 3, '����������', 780, '12.04.2025'),
(170313302, 13, 3, '����', 400, '12.04.2025'),
(170313303, 13, 3, '����', 400, '12.04.2025'),

(170317101, 17, 1, '�������', 80, '12.04.2025'),
(170317102, 17, 1, '�������', 80, '12.04.2025'),
(170317201, 17, 2, '������', 130, '12.04.2025'),
(170317202, 17, 2, '��������', 2000, '12.04.2025'),
(170317203, 17, 2, '�������', 460, '12.04.2025'),
(170317204, 17, 2, '�������', 460, '12.04.2025'),
(170317301, 17, 3, '�������', 1300, '12.04.2025'),
(170317302, 17, 3, '����������', 50, '12.04.2025'),
(170317303, 17, 3, '����������', 50, '12.04.2025'),
(170317401, 17, 4, '�������', 700, '12.04.2025'),
(170317402, 17, 4, '�������', 700, '12.04.2025'),
(170317403, 17, 4, '��������', 600, '12.04.2025'),
(170317404, 17, 4, '��������', 600, '12.04.2025'),
(170317405, 17, 4, '��������', 600, '12.04.2025'),
(170317501, 17, 5, '�����', 500, '12.04.2025'),
(170317502, 17, 5, '�����', 500, '12.04.2025'),
(170317503, 17, 5, '����', 380, '12.04.2025'),

(170318101, 18, 1, '���������', 150, '12.04.2025'),
(170318102, 18, 1, '�����������', 100, '12.04.2025'),
(170318103, 18, 1, '��������', 200, '12.04.2025'),
(170318104, 18, 1, '��������', 200, '12.04.2025'),
(170318201, 18, 2, '��������', 480, '12.04.2025'),
(170318202, 18, 2, '��������', 480, '12.04.2025'),
(170318203, 18, 2, '��������', 480, '12.04.2025'),
(170318204, 18, 2, '�������', 370, '12.04.2025'),
(170318205, 18, 2, '��������', 400, '12.04.2025'),
(170318206, 18, 2, '���������', 290, '12.04.2025')