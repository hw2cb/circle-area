

SELECT Products.Name AS [Name Product], Categories.Name AS [Name Category] 
FROM ProductsCategories as PS 
INNER JOIN Products ON PS.ProductId = Products.Id 
LEFT JOIN Categories ON PS.CategoryId = Categories.Id