CREATE DATABASE CoffeeShop
USE CoffeeShop

/**/



/*CREATE TABLE COLUMN*/
CREATE TABLE Items(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
Price FLOAT
)
/*drop table items : DROP TABLE Items*/
SELECT * FROM Items

/*INSERT VALUE OF attribute in COLUMN*/
INSERT INTO Items (Name, Price) Values ('BLACK',160)
INSERT INTO Items (Name, Price) Values ('HOT',120)
INSERT INTO Items (Name, Price) Values ('COLD',80)
INSERT INTO Items (Name, Price) Values ('COLD',70)
INSERT INTO Items (Name, Price) Values ('JUICE',90)
INSERT INTO Items (Name, Price) Values ('MOLD',60)

DELETE FROM Items WHERE ID = 4
/*CHANGE sequence OF INSERTION*/
INSERT INTO Items (name, price,ID) Values ('CAPUCINO',90,4)

/*INSERTION WITHOUT attribute NAME*/
INSERT INTO Items Values (5,'REGULAR',60)

/*INSERTION WITHOUT attribute NAME but changeing sequence is cause an error*/
INSERT INTO Items Values ('REGULAR',6,50)

/*SHOW VALUE OF COLUMN*/
SELECT * FROM Items

/*DELETE ALL FROM COLUMN*/
DELETE FROM Items 

/*DELETE SELECTED ITEM*/
DELETE FROM Items WHERE ID = 1;

/*UPDATE ITEMS*/
UPDATE Items
SET 
Name = 'HOT NEW', Price = 110
WHERE ID = 2

UPDATE Items
SET 
Name = 'REGULAR NEW', Price = 100
WHERE ID = 3

/*SHOW ONLY NAMES*/
SELECT Name FROM Items
SELECT ID FROM Items
SELECT Price FROM Items
SELECT Name, ID FROM Items
SELECT Name, Price FROM Items
SELECT ID, Price FROM Items

/*CONDITION*/
SELECT Name,Price FROM Items
WHERE Price<100



