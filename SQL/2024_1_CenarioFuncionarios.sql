USE ExercicioDB;

DROP TABLE IF EXISTS aluno

CREATE TABLE aluno (
RM INTEGER NOT NULL PRIMARY KEY,
NOME VARCHAR(60) NOT NULL,
ESTADO CHAR(2),
NASCIMENTO DATE NOT NULL DEFAULT '1900-01-01'
);

INSERT INTO aluno VALUES
(5001, 'Asdronio da Silva', 'SP', '1961-12-24'),
(5002, 'Severino Severá SeVou', 'MG', '1967-07-08'),
(5003, 'Juvenal Juvênio', 'MG', '1975-05-21'),
(5004, 'Ambrósio Adelino Xavier', 'PA', '1949-02-17'),
(5005, 'Adelino da Silva Sauro', 'RJ', '1985-06-30'),
(5006, 'Adamastor Augusto', 'SP', '1974-09-21'),
(5007, 'Chapecó Iramir da Silva', 'RJ', '1947-07-07'),
(5008, 'Carlitos Tevez', 'BU', '1985-11-06'),
(5009, 'Silvio Santos', 'SP', '1935-12-11');

SELECT * FROM aluno;

SELECT RM, aluno.NOME FROM aluno WHERE aluno.NOME LIKE 'A%';

SELECT * FROM aluno WHERE YEAR(aluno.NASCIMENTO) = 1985;

SELECT aluno.NOME, aluno.NASCIMENTO FROM aluno WHERE YEAR(aluno.NASCIMENTO) < 1950

SELECT * FROM aluno WHERE YEAR(aluno.NASCIMENTO) < 1950;

