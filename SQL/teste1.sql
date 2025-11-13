--Instrução para retornar todos os registros
--e todos os campos da tabela Person.Person
sELecT * fROm Person.Person;

--Seleciona apenas os campos FirstName e LastName
--da tabela Person.Person
SELECT FirstName, 
	   LastName 
  FROM Person.Person;

--Restringir apenas os registros que possuem o
--primeiro nome como Ken
SELECT * FROM Person.Person WHERE FirstName = 'Lucas';

SELECT FirstName, MiddleName, LastName FROM Person.Person
  WHERE FirstName = 'Erik';

SELECT * FROM Production.ProductModel