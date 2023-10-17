-- Creación de tabla
CREATE TABLE report(
	report_id INT PRIMARY KEY IDENTITY (1, 1),
	employee_id INT NOT NULL,
	absence_type_id INT NOT NULL,
	num_of_hours INT NOT NULL,
	absence_date DATE NOT NULL
)

-- Inserción de registros
insert into report (employee_id, absence_type_id, num_of_hours, absence_date ) values 
(5,2,9,'2017-01-02'),
(5,2,9,'2017-01-08'),
(5,3,6,'2017-01-05'),
(6,2,6,'2017-01-02'),
(6,3,6,'2017-01-05'),
(6,8,9,'2017-01-08'),
(7,2,2,'2017-12-07'),
(7,8,5,'2017-12-13'),
(7,8,1,'2017-12-08'),
(7,8,9,'2017-12-07'),
(8,2,3,'2017-09-14'),
(8,3,2,'2017-09-15'),
(8,8,9,'2017-09-18')

SELECT * FROM report

--Query
SELECT employee_id,
       COUNT(CASE WHEN absence_type_id = 2 THEN 1 ELSE NULL END) AS NUM_OF_OBSENCE_TYPE_2,
	   SUM(CASE WHEN absence_type_id = 2 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS,
	   
	   COUNT(CASE WHEN absence_type_id = 3 THEN 1 ELSE NULL END) AS NUM_OF_OBSENCE_TYPE_3,
       SUM(CASE WHEN absence_type_id = 3 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS,
	   
	   COUNT(CASE WHEN absence_type_id = 8 THEN 1 ELSE NULL END) AS NUM_OF_OBSENCE_TYPE_8,
       SUM(CASE WHEN absence_type_id = 8 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS
FROM report
GROUP BY employee_id;
