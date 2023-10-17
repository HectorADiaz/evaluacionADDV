-- Creación de la base de datos
CREATE DATABASE evaluacion 
USE evaluacion

-- Creación de la tabla
CREATE TABLE characters (
charName NVARCHAR(100)
) 

-- Insercion de registro
INSERT INTO characters VALUES('hello world') 
SELECT * FROM characters

-- Query
SELECT letra, COUNT(letra) AS cantidad
FROM (
  SELECT SUBSTRING(charName, number, 1) AS letra
  FROM characters 
  CROSS JOIN (
    SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS number
    FROM master..spt_values
  ) AS numbers
  WHERE number <= LEN(charName) AND SUBSTRING(charName, number, 1) <> ' '
) AS letras
GROUP BY letra
ORDER BY letra; 
 




