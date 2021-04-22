select top 1 name from employee where salary not in 
(select max(salary) from employee
) order by salary desc;


select top 1 name from (
select top 2 name from employee order by salary desc
) as db ;


select max(salary) from employee where salary < (select max(salary) from employee);