CREATE TABLE Pasutijums(
	Id INT,
	Summa DECIMAL(8, 2),
	BoughtOn DATE
)
INSERT INTO Pasutijums
VALUES(15001, 150.5, '2018-10-05')
INSERT INTO Pasutijums
VALUES(15002, 270.65, '2018-09-10')
INSERT INTO Pasutijums
VALUES(16000, 65.26, '2018-10-05')
INSERT INTO Pasutijums
VALUES(16005, 110.5, '2018-08-17')
INSERT INTO Pasutijums
VALUES(17000, 948.5, '2018-09-10')

SELECT BoughtOn FROM Pasutijums -- 2.

SELECT Summa FROM Pasutijums --3.
ORDER BY Summa DESC

SELECT Id FROM Pasutijums	--4.
WHERE Summa > 150

SELECT * From Pasutijums	--5.
WHERE BoughtOn like '2018-10%'

INSERT INTO Pasutijums	--6.
VALUES (18000, 666.66, '2019-06-10')

UPDATE Pasutijums	--7.
SET Summa = 1000
WHERE Id = 17000

DELETE FROM Pasutijums	--8.
WHERE Id = 18000

CREATE TABLE Klienti(	--9.
	Id INT,
	Vards NVARCHAR(50),
	Uzvards NVARCHAR(50)
)
INSERT INTO Klienti
VALUES(10000, 'John', 'Smith')
INSERT INTO Klienti
VALUES(11000, 'Kate', 'Miller')

ALTER TABLE Pasutijums	--10.
ADD ClientId INT

SELECT * FROM Pasutijums

INSERT INTO Pasutijums(ClientId)
VALUES(10000);
INSERT INTO Pasutijums(ClientId)
VALUES(10000);
INSERT INTO Pasutijums(ClientId)
VALUES(11000);
INSERT INTO Pasutijums(ClientId)
VALUES(10000);
INSERT INTO Pasutijums(ClientId)
VALUES(11000);

DELETE FROM Pasutijums WHERE Summa IS NULL
