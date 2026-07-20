# Write your MySQL query statement below
SELECT E.name Employee
FROM Employee E
WHERE EXISTS (
    SELECT 1 FROM Employee M
    WHERE   M.id = E.managerId
        AND M.salary < E.salary
)