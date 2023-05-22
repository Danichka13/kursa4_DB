SELECT Purchase.Id AS Id, STRING_AGG(Product.Number,', ') AS ProductsNumbers, STRING_AGG(Product.Name, ', ') AS ProductName, 
STRING_AGG(Product.Price, ', ') AS ProductPrice, Purchase.Summ AS PurchaseSumm
FROM ProductBuy
JOIN Product ON Product.Number = ProductBuy.ProductNumber
JOIN Purchase ON Purchase.Id = ProductBuy.PurchaseId
WHERE Product.Name LIKE '%À%'
GROUP BY Purchase.Id, Purchase.Summ
