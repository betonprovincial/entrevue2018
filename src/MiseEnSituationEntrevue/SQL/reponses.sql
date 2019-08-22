USE AdventureWorks2012;

/**
 * Question #1
 */
SELECT *
FROM
	Person.Person p
WHERE
	p.FirstName = 'David'
	AND ModifiedDate >= '2013-01-01' AND ModifiedDate < '2014-01-01'
-- Notes concernant la réponse :
-- 1) La réponse proposée ci-dessus est valide sur le poste de travail qu'on fournissait durant le test étant donné sa configuration. Ceci dit,
--    idéalement la clause de comparaison devrait spécifier le format de date utilisé pour éviter de s'appuyer sur la conversion implicite de SQL Server.
--    Par exemple : ModifiedDate >= CONVERT(DATE, '2013-01-01', 23). Cet élément de réponse n'était pas nécessaire/évaluée durant notre test, mais aurait 
--    pu démontrer une bonne maîtrise du sujet par le candidat.
-- 2) L'utilisation d'un BETWEEN '2013-01-01' AND '2014-01-01' ne convient par car toutes les données modifiées dans la journée du 1er janvier 2014 sont
--    ignorées (sauf celles modifiées à minuit exactement).

/**
 * Question #2
 */
SELECT
	FirstName,
	NombreOccurences = COUNT(1),
	NombreNomsFamille = COUNT(DISTINCT LastName)
FROM
	Person.Person p
GROUP BY
	p.FirstName
HAVING
	COUNT(1) >= 95
ORDER BY
	COUNT(1) DESC

/**
 * Question #3
 */

SELECT
	p.ProductID,
	NomProduit = MAX(p.Name),
	NombrePhoto = COUNT(ppp.ProductID)
FROM
	Production.Product p
	LEFT JOIN Production.ProductProductPhoto ppp ON (p.ProductID = ppp.ProductID)
WHERE
	EXISTS (SELECT 1 FROM Production.ProductReview pr WHERE p.ProductID = pr.ProductID)
GROUP BY
	p.ProductID


/**
 * Question #4
 */

SELECT TOP 100
	p.Name,
	MontantVentes = CAST(ROUND(SUM(sod.LineTotal)/1000, 0) AS INT),
	Meilleur100En2011 = CASE WHEN MAX(bp2011.ProductID) IS NULL THEN 'NON' ELSE 'OUI' END
FROM
	AdventureWorks2012.Sales.SalesOrderDetail sod
	JOIN AdventureWorks2012.Production.Product p ON (sod.ProductID = p.ProductID)
	JOIN AdventureWorks2012.Sales.SalesOrderHeader soh ON (sod.SalesOrderID = soh.SalesOrderID)
	LEFT JOIN
	(
		SELECT TOP 100 
			ProductID
		FROM 
			AdventureWorks2012.Sales.SalesOrderDetail sod 
			JOIN AdventureWorks2012.Sales.SalesOrderHeader soh ON (sod.SalesOrderID = soh.SalesOrderID)
		WHERE
			soh.OrderDate >= '2011-01-01' AND soh.OrderDate < '2012-01-01'
		GROUP BY 
			ProductID
		ORDER BY
			SUM(LineTotal) DESC
	) bp2011 ON (sod.ProductID = bp2011.ProductID)
WHERE
	soh.OrderDate >= '2014-01-01' AND soh.OrderDate < '2015-01-01'
GROUP BY
	sod.ProductID,
	p.Name
ORDER BY
	SUM(sod.LineTotal) DESC;