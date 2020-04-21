--Find the duplicate records

Select ID,Name,Salary, count(*) from DuplicateData
Group by ID,Name,Salary
Having count(*)>=2;