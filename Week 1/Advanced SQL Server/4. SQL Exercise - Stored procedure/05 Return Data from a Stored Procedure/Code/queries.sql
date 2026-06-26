CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT,
    @TotalEmployees INT OUTPUT
AS
BEGIN
    SELECT @TotalEmployees = COUNT(*)
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

DECLARE @Count INT;

EXEC sp_GetEmployeeCountByDepartment
    @DepartmentID = 3,
    @TotalEmployees = @Count OUTPUT;

SELECT @Count AS TotalEmployees;