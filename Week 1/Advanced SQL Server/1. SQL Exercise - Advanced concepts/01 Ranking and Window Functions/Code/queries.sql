-- using ROW_NUMBER()

WITH RankedProducts AS
(
    SELECT *,
           ROW_NUMBER() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS PriceRank
    FROM Products
)

SELECT *
FROM RankedProducts
WHERE PriceRank <= 3;

-- using RANK()

WITH RankedProducts AS
(
    SELECT *,
           RANK() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS PriceRank
    FROM Products
)

SELECT *
FROM RankedProducts
WHERE PriceRank <= 3;

-- using DENSE_RANK()

WITH RankedProducts AS
(
    SELECT *,
           DENSE_RANK() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS PriceRank
    FROM Products
)

SELECT *
FROM RankedProducts
WHERE PriceRank <= 3;

