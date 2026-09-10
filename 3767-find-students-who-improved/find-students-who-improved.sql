/* Write your T-SQL query statement below */
WITH FirstExam AS (
    SELECT
        student_id,
        subject,
        MIN(exam_date) AS first_date,
        MAX(exam_date) AS latest_date
    FROM Scores
    GROUP BY student_id, subject
    HAVING COUNT(*) >= 2
)
SELECT
    f.student_id,
    f.subject,
    s1.score AS first_score,
    s2.score AS latest_score
FROM FirstExam f
JOIN Scores s1
    ON s1.student_id = f.student_id
    AND s1.subject = f.subject
    AND s1.exam_date = f.first_date
JOIN Scores s2
    ON s2.student_id = f.student_id
    AND s2.subject = f.subject
    AND s2.exam_date = f.latest_date
WHERE s2.score > s1.score
ORDER BY f.student_id, f.subject;