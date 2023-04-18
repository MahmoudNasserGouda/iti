use AdventureWorks;
SELECT ProductID, Name
FROM Production.Product
WHERE Color NOT IN
	(SELECT Color
	FROM Production.Product
	WHERE ProductID = 5)