/*CREATE TABLE Users(
	Id INT,
	Username NVARCHAR(50),	--varchar doesnt assing sepific qty in memory
	CreatedOn DATE,
	Balance DECIMAL(8, 2) -- 8 cipari kopa, no kuriem divi aiz komata
)*/

SELECT * FROM Users -- Id, Username lietas ko atlasit, var ari lietot * ja atlasit visu

INSERT INTO Users(Id, Username, CreatedOn, Balance)
VALUES(1, 'Kirils', '2019-06-10', 799.99)

UPDATE Users	--ieraksta atjaunosana
SET Balance=1000, Username='KirKrav'
WHERE Id = 1;	--atjauno tikai id ar 3

DELETE FROM Users
WHERE Id=1

SELECT * FROM Users
WHERE Username like '%iril%' -- var izmantot vienadibas zimes vieta "like" lai mekletu pec dalas, un "%" zimi lai mekletu dalu %iri%
AND Balance >=500
AND Balance <=1000

SELECT * FROM Users
WHERE CreatedOn > '2019-06-01'

SELECT count (*) FROM Users
WHERE id = 2;

CREATE TABLE Orders(
Id INT,
UserID INT,
ItemTitle NVARCHAR(100)
)

INSERT INTO Orders (Id, UserID, ItemTitle)
VALUES (1, 2, 'Prece 1')

SELECT o.* FROM Orders o, Users u	--atlasam no divam tabulam, ar prefiksi
WHERE o.UserID = u.Id
AND u.Username = 'Kirils'; 