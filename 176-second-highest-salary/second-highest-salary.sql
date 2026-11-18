/* Write your T-SQL query statement below */
WITH SecondRank AS (
    SELECT salary,
        DENSE_RANK() OVER(ORDER BY salary DESC) AS Salary_rank
    FROM Employee
)

SELECT MAX(salary) AS SecondHighestSalary
FROM SecondRank
WHERE Salary_rank = 2