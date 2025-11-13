--Gustavo Pelegrino (Dispensado) - RA:061230022

USE ExercicioDB;

DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS tipos;
DROP TABLE IF EXISTS fitas;
DROP TABLE IF EXISTS locacoes;


CREATE TABLE clientes(
Cod_cliente INT PRIMARY KEY,
Nome VARCHAR(50));

CREATE TABLE tipos(
Cod_tipo INT PRIMARY KEY,
Descricao VARCHAR(50));

CREATE TABLE fitas(
Cod_fita INT PRIMARY KEY,
Descricao VARCHAR(50),
Cod_tipo INT FOREIGN KEY REFERENCES tipos);

CREATE TABLE locacoes(
Cod_locacao INT PRIMARY KEY,
Cod_fita INT FOREIGN KEY REFERENCES fitas,
Valor DECIMAL(4,2),
Cod_cliente INT  FOREIGN KEY REFERENCES clientes);

INSERT INTO clientes VALUES (1,	'Silvio Santos'),
							(2,	'Xuxa'),
							(3,	'Ratinho'),
							(4,	'Teobaldo'),
							(5,	'Bob Esponja');

INSERT INTO tipos VALUES (1, 'Drama'),
						 (2, 'Ação'),
						 (3, 'Terror'),
 						 (4, 'Ficção'),
 						 (5, 'Documentário');

INSERT INTO fitas VALUES (1, 'Titanic',	1),
						 (2, 'Kill Bill', 2),
						 (3, 'O Massacre da serra elétrica', 3),
						 (4, 'Os outros', 3),
						 (5, 'O Grande Dragão Branco', 2);

INSERT INTO locacoes VALUES (1, 2, 5, 1),
							(2, 3, 4, 2),
							(3, 1, 5, 3),
							(4, 1, 3, 2),
							(5, 3, 2, 1),
							(6, 3, 5, 3),							
							(7, 2, 4, 3),							
							(8, 2, 3, 1),
							(9, 1, 1, 1),
							(10, 2, 5, 2);


USE ExercicioDB;

-- 4-a) 
SELECT * from clientes WHERE Nome LIKE '%a%';

--4-b)
SELECT * from locacoes 
WHERE Valor >=3 AND Valor <=5 
ORDER BY Valor;


--4-c)
SELECT Cod_fita FROM locacoes WHERE Cod_cliente = 3 AND Valor <= 4;


--4-d)
SELECT Cod_fita from fitas GROUP BY Cod_fita; 
-- Só é possível agrupar os campos que estão no select, precisando agrupar todos



--4-e)
SELECT SUM(locacoes.Valor) AS 'Soma dos Valores' FROM fitas 
INNER JOIN locacoes ON fitas.Cod_fita = locacoes.Cod_fita
GROUP BY fitas.Cod_fita;

--4-f)
SELECT AVG(Valor) AS 'Média' FROM locacoes GROUP BY Cod_cliente


--4-g)
SELECT Cod_fita, MAX(Valor) AS 'Maior Valor' FROM locacoes GROUP BY Cod_fita;

--4-h)
SELECT Cod_cliente ,MIN(Valor) AS 'Menor Valor' FROM locacoes GROUP BY Cod_cliente;

--4-i)
SELECT fitas.Descricao, tipos.Descricao FROM fitas
INNER JOIN tipos ON fitas.Cod_tipo = tipos.Cod_tipo;

--4-j)
SELECT fitas.Descricao, fitas.Cod_fita, tipos.Descricao FROM fitas
INNER JOIN tipos ON fitas.Cod_tipo = tipos.Cod_tipo
WHERE fitas.Cod_tipo=3;


--4-k)
SELECT locacoes.Cod_locacao, locacoes.Valor, clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente

--4-l)
SELECT locacoes.Cod_locacao, locacoes.Valor, locacoes.Cod_cliente, clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente 
WHERE locacoes.Valor > 3;

--4-m)
SELECT locacoes.Cod_locacao, locacoes.Cod_fita, locacoes.Valor, locacoes.Cod_cliente, clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
WHERE locacoes.Valor BETWEEN 3 AND 5 AND clientes.Nome LIKE '%o%';

--4-n)
SELECT locacoes.Cod_locacao, fitas.Descricao, clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente  
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita;

--4-o)
SELECT locacoes.Cod_locacao, fitas.Descricao, clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente  
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
WHERE fitas.Cod_fita <> 2 ORDER BY clientes.Nome;

--4-p)
SELECT fitas.Descricao, tipos.Descricao, locacoes.Valor, clientes.Nome FROM locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
INNER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
ORDER BY fitas.Descricao DESC;

--4-q)
SELECT fitas.Cod_fita, fitas.Cod_tipo, fitas.Descricao FROM fitas 
INNER JOIN tipos ON fitas.Cod_tipo=tipos.Cod_tipo
WHERE tipos.Descricao = 'Ação';

--4-r)
SELECT fitas.Descricao, tipos.Descricao, locacoes.Valor from locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
INNER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
WHERE clientes.Nome = 'Silvio Santos' ORDER BY locacoes.Valor DESC;

--4-s)
SELECT tipos.Descricao, COUNT(locacoes.Cod_fita) AS 'Número de vezes alugada' FROM locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
INNER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
GROUP BY tipos.Cod_tipo, tipos.Descricao;

--4-t)
SELECT clientes.Nome, COUNT(locacoes.Cod_cliente) AS 'Soma das fitas alugadas' from locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
GROUP BY locacoes.Cod_cliente, clientes.nome;

--4-u)
SELECT fitas.Descricao, SUM(locacoes.Valor) AS 'Valor feito pelo fita' FROM locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
GROUP BY fitas.Cod_fita, fitas.Descricao;

--4-v)
SELECT tipos.Descricao FROM tipos
INNER JOIN fitas ON tipos.Cod_tipo = fitas.Cod_tipo
 WHERE fitas.Cod_tipo in (select fitas.Cod_fita FROM fitas);


--4-w)
SELECT tipos.Descricao, fitas.Descricao FROM tipos
FULL OUTER JOIN fitas ON tipos.Cod_tipo = fitas.Cod_tipo
 WHERE tipos.Cod_tipo in (select tipos.Cod_tipo FROM tipos);

--4-x)
SELECT clientes.Nome, locacoes.Cod_locacao FROM locacoes
FULL OUTER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
 WHERE clientes.Cod_cliente in (select clientes.Cod_cliente FROM clientes);


--4-y)
SELECT clientes.*, locacoes.* FROM locacoes
FULL OUTER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
 WHERE clientes.Cod_cliente in (select clientes.Cod_cliente FROM clientes);


--5)
SELECT clientes.Nome, fitas.Descricao, tipos.Descricao FROM locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
INNER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente;
--Esse código já serve, mas poderia colocar WHERE HAVUNG COUNT(Cod_locacao) < 1, usando full outer join

--6)
SELECT clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
GROUP BY clientes.Nome
HAVING COUNT(Cod_locacao) > 2;

--7)
SELECT tipos.Descricao FROM locacoes
INNER JOIN fitas ON locacoes.Cod_fita = fitas.Cod_fita
INNER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
GROUP BY tipos.Descricao
HAVING COUNT(Cod_locacao) >= 4;


--8)
SELECT clientes.Nome FROM locacoes
FULL OUTER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
GROUP BY clientes.Nome
HAVING COUNT(Cod_locacao) < 1;

--9)
SELECT tipos.Descricao FROM fitas
FULL OUTER JOIN tipos ON tipos.Cod_tipo = fitas.Cod_tipo
GROUP BY tipos.Descricao
HAVING COUNT(fitas.Cod_tipo) < 1;


--10)
SELECT clientes.Nome FROM locacoes
INNER JOIN clientes ON locacoes.Cod_cliente = clientes.Cod_cliente
GROUP BY clientes.Nome
HAVING SUM(Valor) >= 12;
