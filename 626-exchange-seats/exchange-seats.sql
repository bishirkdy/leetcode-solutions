# Write your MySQL query statement below
SELECT
    id,
    CASE
        WHEN id % 2 = 1 THEN COALESCE(
            (SELECT student FROM Seat s2 WHERE s2.id = s1.id + 1),
            student
        )
        ELSE (SELECT student FROM Seat s2 WHERE s2.id = s1.id - 1)
    END student
FROM Seat s1;