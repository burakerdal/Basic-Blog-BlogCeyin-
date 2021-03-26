CREATE PROCEDURE getConfirmedAndPublished
AS
SELECT * 
FROM Blogs
WHERE Confirm > 0 AND PublishHome > 0
ORDER BY SubmitTime DESC