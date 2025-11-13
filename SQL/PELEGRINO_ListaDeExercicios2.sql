-- Gustavo Pelegrino (Dispensado) - RA: 061230022 - ECA 3 - 1° sem.

Use ExercicioDB;--Garantir que está no banco de dados correto

DROP TABLE aluno;--Apaga tabela inteira

--Cria tabela
CREATE TABLE aluno (
 rm INTEGER PRIMARY KEY NOT NULL, --chave primária, fala que o registro é único, não podendo ser nula
 nome VARCHAR(60) NOT NULL, --pode ter de 0 até 60 caracteres, não  pode ficar sem nome
 estado CHAR(2) DEFAULT 'SP', --pois só tem exatamente 2 caracteres, caso não colocar nada considera como São Paulo (padrão)
 nascimento DATE DEFAULT '1900-01-01'
);

--Insere valores na tabela, em ordem igual dos campos
INSERT INTO aluno VALUES (5001, 'Asdronio da Silva', 'SP', '1961-12-24'), --ISODATE, padrão de dado  
						 (5002, 'Severino Severá SeVou', 'MG', '1967-07-08'),
						 (5003, 'Juvenal Juvênio', 'MG', '1975-05-21'),
						 (5004, 'Ambrósio Adelino Xavier', 'PA', '1949-02-17'),
						 (5005, 'Adelino da Silva Sauro', 'RJ', '1985-06-30'),
						 (5006, 'Adamastor Augusto', 'SP', '1974-09-21'),
					     (5007, 'Chapecó Iramir da Silva', 'RJ', '1947-07-07'),
						 (5008, 'Carlitos Tevez', 'BU', '1985-11-06'),
						 (5009, 'Silvio Santos', 'SP', '1935-12-11');
--Exercicio 4-a
SELECT rm, nome FROM aluno WHERE nome LIKE 'A%';-- Where é um método de comparar, condição se é semelhante a A%
--A% significa A+alguma coisa = começa com A

--Exercício 4-b)

SELECT * FROM aluno WHERE YEAR(nascimento) = 1985;

--Exercício  4-c)

SELECT nome, nascimento FROM aluno WHERE YEAR(nascimento) < 1950;

--Exercício  4-d)
SELECT * FROM aluno WHERE MONTH(nascimento) = 07 ORDER BY nome ASC; --ordem alfabetica (crescente),

--Exercício  4-e)
SELECT nome, nascimento FROM aluno WHERE (DAY(nascimento) < 20 AND YEAR(nascimento) < 1985);

--Exercício  4-f)
SELECT * FROM aluno ORDER BY nascimento DESC;

--Exercício  4-g)
SELECT nome, YEAR(nascimento) as 'ano' from aluno ORDER BY 'ano' DESC;

--Exercício  4-h)
SELECT nome, day(nascimento) as 'dia', month(nascimento) as 'mês', year(nascimento) as 'ano' from aluno;

--Exercício  5-a)
UPDATE aluno SET nome = 'Adrônio da Silva Silveira' WHERE rm = 5001;
SELECT rm, nome FROM aluno;

--Exercício  5-b)
UPDATE aluno SET nome = 'Severino Seviu Denovo', nascimento = '1967-08-08' WHERE rm = 5002;
SELECT rm, nome, nascimento FROM aluno;
  
--Exercício  5-c)
UPDATE aluno SET estado = 'PE' WHERE estado = 'RJ';
SELECT * from aluno;

--Exercício  5-d)
UPDATE aluno SET nome = nome + 'Santos' WHERE nome LIKE '%SILVA%';
SELECT * from aluno;


--Exercício  6-a)
DELETE FROM aluno WHERE rm = 5006;
SELECT * from aluno;

--Exercício  6-b)
DELETE FROM aluno WHERE YEAR(nascimento) < 1970;
SELECT * from aluno;

--Exercício  6-c)
DELETE FROM aluno WHERE rm != 5008;
SELECT * from aluno;

--Exercício  6-d)
DELETE FROM aluno WHERE nome LIKE '%Carlitos%';
SELECT * from aluno;