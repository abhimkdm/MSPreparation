--Find records which are not duplicate.

Select Id, Name, Salary, Count(*)
from DuplicateData
Group by Id, Name, Salary
Having COUNT(*) = 1