-- Banco de Dados Matrícula
-- 1 semestre DS 2023

create database matricula;
use matricula;

CREATE TABLE aluno (
  ra 	      smallint auto_increment,
  nome	    varchar(50) not null,
  rg		    char(9),
  data_nasc date,
  sexo	    set('M','F'), 
  turma	  	enum('A','B') not null,
  PRIMARY KEY (ra)
);

CREATE TABLE curso (
  id_curso	smallint auto_increment,
  nome      varchar(60),
  periodo 	varchar(15),
  ch_curso	smallint unsigned,
  PRIMARY KEY (id_curso)
) ;

CREATE TABLE matricula (
  id_mat  	int auto_increment,
  ra		    smallint,
  data_mat	date,
  id_modulo	smallint,
  PRIMARY KEY (id_mat)
) ;

CREATE TABLE modulo (
  id_modulo		smallint auto_increment,
  desc_modulo	varchar(40),
  ch_modulo   smallint,
  id_curso	  smallint,
  PRIMARY KEY (id_modulo)
) ;

CREATE TABLE disciplina (
  id_disciplina smallint auto_increment,
  nome_disc		  varchar(30),
  ch_disc	      smallint,
  id_modulo	  	smallint,
  PRIMARY KEY (id_disciplina)
) ;

CREATE TABLE professor (
  id_professor  smallint auto_increment,
  nome		 varchar(50),
  sexo		 enum('F','M'),
  PRIMARY KEY (id_professor)
) ;

CREATE TABLE prof_disc (
id_disc smallint,
id_prof smallint,
PRIMARY KEY (id_disc,id_prof)
);

ALTER TABLE matricula ADD FOREIGN KEY (id_modulo) REFERENCES modulo (id_modulo);
ALTER TABLE matricula ADD FOREIGN KEY (ra) REFERENCES aluno (ra);
	
ALTER TABLE modulo  ADD FOREIGN KEY (id_curso) REFERENCES curso (id_curso);	

ALTER TABLE disciplina ADD FOREIGN KEY (id_modulo) REFERENCES modulo (id_modulo);

ALTER TABLE prof_disc ADD FOREIGN KEY (id_disc) REFERENCES disciplina (id_disciplina);
ALTER TABLE prof_disc ADD FOREIGN KEY (id_prof) REFERENCES professor (id_professor);
