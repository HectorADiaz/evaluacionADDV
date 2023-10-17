-- Creación de tablas
CREATE TABLE tblAuthor(
	AuthorId INT PRIMARY KEY IDENTITY (1, 1),
	AuthorName NVARCHAR (100) NOT NULL
)
CREATE TABLE tblDoctor (
	DoctorId INT PRIMARY KEY IDENTITY (1, 1),
	DoctorNumber NVARCHAR (100) NOT NULL,
	DoctorName NVARCHAR (100) NOT NULL,
	BirthDate DATE NOT NULL,
	FirstEpisodeDate DATE NOT NULL,
	LastEpisodeDate DATE NOT NULL
)

CREATE TABLE tblEpisode(
	EpisodeId INT PRIMARY KEY IDENTITY (1, 1),
	SeriesNumber INT NOT NULL,
	EpisodeNumber INT NOT NULL,
	EpisodeType NVARCHAR(100) NOT NULL,
	Title NVARCHAR(100) NOT NULL,
	EpisodeDate DATE NOT NULL,
	AuthorId INT NOT NULL,
	DoctorId INT NOT NULL, 
	Notes NVARCHAR(MAX)
	FOREIGN KEY (AuthorId) references tblAuthor(AuthorId),
	FOREIGN KEY (DoctorId) references tblDoctor(DoctorId)

)

-- Inserción de registro
--	Autores
INSERT INTO tblAuthor values ('Russell T. Davies')
INSERT INTO tblAuthor values ('Steven Moffat')
SELECT * FROM tblAuthor

-- Autores

INSERT INTO tblDoctor values (55213251,'David Tennant','1980-05-15', '2005-07-20', '2023-10-15')
INSERT INTO tblDoctor values (55651651,'MattSmith','1975-05-15', '1983-04-10', '1990-06-05')
INSERT INTO tblDoctor values (44561561,'Christopher Eccleston','1982-09-28', '1996-02-15', '2003-04-20')
INSERT INTO tblDoctor values (77231516,'Peter Capaldi','1978-11-09', '1979-11-25', '1986-01-30')

SELECT * FROM tblDoctor

-- Episodios
INSERT INTO tblEpisode 
  (SeriesNumber, EpisodeNumber, EpisodeType, Title, EpisodeDate, AuthorId, DoctorId, Notes)
VALUES
    (1, 11, 'Special', 'Episodio 11', '2022-01-15', 1, 1, 'Notas del episodio'),
    (1, 12, 'Regular', 'Episodio 22', '2022-01-22', 1, 1, 'Notas del episodio'),
    (1, 13, 'Regular', 'Episodio 13', '2022-01-29', 1, 1, 'Notas del episodio'),
    (1, 20, 'Regular', 'Episodio 20', '2022-02-05', 1, 1, 'Notas del episodio'),
    (1, 21, 'Regular', 'Episodio 21', '2022-02-12', 1, 1, 'Notas del episodio'),
    (2, 16, 'Special', 'Episodio 16', '2022-02-19', 2, 2, 'Notas del episodio'),
    (2, 17, 'Regular', 'Episodio 17', '2022-02-26', 2, 2, 'Notas del episodio'),
    (2, 18, 'Regular', 'Episodio 18', '2022-03-05', 2, 2, 'Notas del episodio'),
    (2, 19, 'Regular', 'Episodio 19', '2022-03-12', 2, 2, 'Notas del episodio'),
    (2, 20, 'Regular', 'Episodio 20', '2022-03-19', 2, 2, 'Notas del episodio'),
    (3, 5, 'Special', 'Episodio 5', '2022-03-26', 1, 3, 'Notas del episodio'),
    (3, 6, 'Regular', 'Episodio 6', '2022-04-02', 1, 3, 'Notas del episodio'),
    (3, 7, 'Regular', 'Episodio 7', '2022-04-09', 1, 3, 'Notas del episodio'),
    (3, 8, 'Regular', 'Episodio 8', '2022-04-16', 1, 3, 'Notas del episodio'),
    (3, 9, 'Regular', 'Episodio 9', '2022-04-23', 1, 3, 'Notas del episodio'),
    (4, 2, 'Special', 'Episodio 2', '2022-04-30', 2, 4, 'Notas del episodio'),
    (4, 3, 'Regular', 'Episodio 3', '2022-05-07', 2, 4, 'Notas del episodio'),
    (4, 4, 'Regular', 'Episodio 4', '2022-05-14', 2, 4, 'Notas del episodio'),
    (4, 5, 'Regular', 'Episodio 5', '2022-05-21', 2, 4, 'Notas del episodio'),
    (4, 6, 'Regular', 'Episodio 6', '2022-05-28', 2, 4, 'Notas del episodio');

	SELECT * FROM tblEpisode

	--Query 
	SELECT tblAuthor.AuthorName, tblDoctor.DoctorName, MAX(EpisodeNumber) AS Episodes
	FROM tblEpisode
	INNER JOIN tblAuthor ON tblAuthor.AuthorId = tblEpisode.AuthorId
	INNER JOIN tblDoctor ON tblDoctor.DoctorId = tblEpisode.DoctorId
	GROUP BY tblAuthor.AuthorName, tblDoctor.DoctorName
	ORDER BY Episodes DESC

