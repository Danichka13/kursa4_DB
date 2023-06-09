DROP TABLE IF EXISTS ProductBuy

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