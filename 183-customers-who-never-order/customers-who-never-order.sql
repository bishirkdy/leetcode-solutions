/* Write your T-SQL query statement below */
SELECT name AS Customers
FROM Customers
Where id NOT IN(
    Select customerId FROM Orders
)