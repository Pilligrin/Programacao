-- Nome: Gustavo Pelegrino - RA:061230022

--Exercício 1: Retornar todos os campos e registros da tabela funcionários.
USE Inteligencia --Nome do DATABASE que foi salvo o CenarioFuncionarios

SELECT * FROM funcionarios; --Seleciona todos os campos e registros da tabela funcionarios
--

--Exercício 2: Apenas o nome dos funcionários que tem o gerente id 2.

SELECT func_nome as 'Nome dos funcionários' FROM funcionarios
				 WHERE gerente_id = 2;
				 --Foi colocado o as (apelido) para a coluna, para testar a instrução
				 --mesmo sendo que não foi pedido
--

--Exercício 3: Selecionar os setores que terminam com a letra 'e'.

SELECT * FROM setores
		 WHERE setor_nome LIKE '%e';
		 --função Like é comparar se é parecido com
		 -- o '%e' significa termina com e
--

--Exercício 4: Selecionar os nomes e data de nascimento dos funcionários que trabalhem no setor 3.

SELECT func_nome, func_dataNasc FROM funcionarios 
								WHERE setor_id = 3;
--

--Exercício 5: Selecionar os nomes, setores e gerente id dos funcionários que tenham o salário menor do que R$900,00.

SELECT func_nome, setor_id, gerente_id FROM funcionarios
									   WHERE func_salario < 900;
--

--Exercício 6: Selecionar os nomes, setores e gerente id dos funcionários que tenham o salário entre R$750,00 e R$900,00 (valores inclusos no intervalo).

SELECT func_nome, setor_id, gerente_id FROM funcionarios
									   WHERE (func_salario < 900 AND func_salario > 750);
									   --também poderia ser utilizado WHERE func_salario betweeen 900 and 750;
--

--Exercício 7:  Selecionar os funcionários que nasceram no ano de 1984 (Pesquisar e utilizar a função ANO).

SELECT * FROM funcionarios WHERE YEAR(func_dataNASC) = 1984; 
--Função YEAR extrai somente o ano de um campo, no caso func_dataNASC
--

--Exercício 8: Atualizar para 'Valdir Costa' o nome do funcionário de ID 16 (Instrução UPDATE).

UPDATE funcionarios SET func_nome = 'Valdir Costa' WHERE func_id = 16;
SELECT func_id, func_nome FROM funcionarios; --Não pediu no exercício, contudo seria para verificar a atualização
--

--Exercício 9: Remover os funcionários que possuem os IDs 11, 12 e 13 (Pesquisar e utilizar a instrução DELETE).

DELETE FROM funcionarios WHERE func_id IN (11,12,13); --foi utilizado a função IN para evitar diversas vezes a comparação
SELECT func_id, func_nome FROM funcionarios; --Não pediu no exercício, contudo seria para verificar a atualização
--