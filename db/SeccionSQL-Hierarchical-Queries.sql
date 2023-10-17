-- Creación de tabla
CREATE TABLE employees(
	employee_id INT PRIMARY KEY IDENTITY (1, 1),
	First_Name NVARCHAR (50) NOT NULL,
	Last_Name NVARCHAR (50) NOT NULL,
	manager_id INT NULL
)

-- Inserción de registros
INSERT INTO employees 
  (First_Name, Last_Name, manager_id)
VALUES
    ('Alvin', 'Smith', NULL),
    ('Jose', 'Jones', 1),
    ('Amado', 'Taylor', 1),
    ('Stuart', 'Williams', 1),
    ('Demarcus', 'Brown', 2),
    ('Mark', 'Davies', 2),
    ('Merlin', 'Evans', 2),
    ('Elroy', 'Wilson', 7),
    ('Charles', 'Thomas', 7),
    ('Rudolph', 'Roberts', 7)
	select * from employees;
	
	--Query
		-- Ancla
	WITH employeeId AS (
    SELECT employee_id, First_Name, manager_id
    FROM employees
    WHERE employee_id = 10 -- Inicia con el empleado 

    UNION ALL

		-- Recursivo
    SELECT e.employee_id, e.First_Name, e.manager_id
    FROM employees e
    INNER JOIN employeeId eh ON e.employee_id = eh.manager_id
)
SELECT * FROM employeeId;
 




