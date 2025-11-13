
INSERT INTO aluno (ra, nome, rg, data_nasc, sexo, turma) VALUES

(1, 'AGATHA MARIA SOUZA DA SILVA    '           , NULL, NULL, 'F', 'A'),
(2, 'ALAN HENRIQUE VIEIRA DA SILVA'             , NULL, NULL, 'M', 'A'),
(3, 'ANA PALOMA MARQUES DE MATOS'               , NULL, NULL, 'F', 'A'),
(4, 'ANYA ELIZA BONVECHIO LEME PINTO'           , NULL, NULL, 'F', 'A'),
(5, 'BRUNO TRINDADE PEREIRA DE OLIVEIRA'        , NULL, NULL, 'M', 'A'),
(6, 'CAROLINE BROLEZI DE ALENCAR'               , NULL, NULL, 'M', 'A'),
(7, 'DAVID ALVES MOLIZANE NETO'                 , NULL, NULL, 'F', 'A'),
(8, 'EDUARDO LUIS ALVES VILLA BERNARDES'        , NULL, NULL, 'F', 'A'),
(9, 'GILBERTO CARLOS DO NASCIMENTO'             , NULL, NULL, 'M', 'B'),
(10, 'GLEISSON HENRIQUE DO CARMO SANT ANTONIO'  , NULL, NULL, 'M', 'A'),
(11, 'GUILHERME HORNICK DE OLIVEIRA'            , NULL, NULL, 'M', 'A'),
(12, 'HENRIQUE FERREIRA ZACCARIOTTO'            , NULL, NULL, 'M', 'A'),
(13, 'HIGOR DA SILVA TERTULINO'                 , NULL, NULL, 'M', 'B'),
(14, 'HUGO ANTONIO MARQUETTI'                   , NULL, NULL, 'M', 'A'),
(15, 'HUGO FERREIRA ZACCARIOTTO'                , NULL, NULL, 'M', 'A'),
(16, 'JOÃO PEDRO PEREIRA DOS SANTOS'            , NULL, NULL, 'M', 'A'),
(17, 'JOÃO PEDRO PEREIRA SANTOS'                , NULL, NULL, 'M', 'A'),
(18, 'JOÃO VICTOR SOARES ALVES'                 , NULL, NULL, 'M', 'B'),
(19, 'JÔNATAS SILVA DA CAMPO'                   , NULL, NULL, 'M', 'B'),
(20, 'KAUÃ SOARES DOS SANTOS'                   , NULL, NULL, 'F', 'B'),
(21, 'LUAN RODRIGUES DE SOUZA MACIEL'           , NULL, NULL, 'F', 'B'),
(22, 'LUCAS DE OLIVEIRA BIZACHI'                , NULL, NULL, 'M', 'B'),
(23, 'LUCAS FERNANDO PICOLI'                    , NULL, NULL, 'M', 'B'),
(24, 'LUCAS MENDES SERAFIM'                     , NULL, NULL, 'M', 'A'),
(25, 'LUIS HENRIQUE CARVALHO RODRIGUES'         , NULL, NULL, 'M', 'B'),
(26, 'MARCO ANTONIO ARRAIS SERODIO'             , NULL, NULL, 'M', 'B'),
(27, 'MATHEUS NASCIMENTO DE OLIVEIRA'           , NULL, NULL, 'M', 'B'),
(28, 'MILENA ALVES DE OLIVEIRA'                 , NULL, NULL, 'F', 'B'),
(29, 'PEDRO HENRIQUE DAMAS'                     , NULL, NULL, 'F', 'B'),
(30, 'SAULO JESSE TEODORO'                      , NULL, NULL, 'M', 'B'),
(31, 'VALDECIR APARECIDO COIMBRA'               , NULL, NULL, 'F', 'B'),
(32, 'VERÔNICA GONÇALVES TEIXEIRA'              , NULL, NULL, 'F', 'B'),
(33, 'VITOR EMANUEL REVELO'                     , NULL, NULL, 'M', 'B'),
(34, 'WILIAN ARAUJO SANTOS'                     , NULL, NULL, 'M', 'B'),
(35, 'X'     , NULL, NULL, 'M', 'B'),
(36, 'Y'     , NULL, NULL, 'M', 'B'),
(37, 'Z'     , NULL, NULL, 'M', 'B'),
(38, 'W'     , NULL, NULL, 'M', 'A');

INSERT INTO curso (id_curso, nome, periodo, ch_curso) VALUES
(1, 'Técnico em DS', 'Noturno', 1500),
(2, 'Técnico em ADM', 'Noturno', 1500);

INSERT INTO modulo (id_modulo, desc_modulo, ch_modulo, id_curso) VALUES
(1, '1 ET DS', 500, 1),
(2, '2 ET DS', 500, 1),
(3, '3 ET DS', 500, 1),
(4, '1 ET ADM', 500, 2),
(5, '2 ET ADM', 500, 2),
(6, '3 ET ADM', 500, 2);

INSERT INTO matricula (id_mat, ra, data_mat, id_modulo) VALUES
(51, 1, '2021-02-05', 1),
(52, 2, '2021-02-05', 1),
(53, 3, '2021-02-05', 1),
(54, 4, '2021-02-05', 2),
(55, 5, '2021-02-05', 2),
(56, 6, '2021-02-05', 2),
(57, 7, '2021-02-05', 3),
(58, 8, '2021-02-05', 3),
(59, 9, '2021-02-05', 3),
(60, 10, '2021-02-05', 4),
(61, 11, '2021-02-05', 4),
(62, 12, '2021-02-05', 4),
(63, 13, '2021-02-05', 5),
(64, 14, '2021-02-05', 5),
(65, 15, '2021-02-05', 5),
(66, 16, '2021-02-05', 6),
(67, 17, '2021-02-05', 6),
(68, 18, '2021-02-05', 6),
(69, 19, '2021-02-05', 1),
(70, 20, '2021-02-05', 2),
(71, 21, '2021-02-05', 3),
(72, 22, '2021-02-05', 4),
(73, 23, '2021-02-05', 5),
(74, 24, '2021-02-05', 6),
(75, 25, '2021-02-05', 1);

INSERT INTO disciplina (id_disciplina, nome_disc, ch_disc, id_modulo) VALUES
(1, 'AS'    , NULL, 1),
(2, 'PA'    , NULL, 1),
(3, 'BDI'   , NULL, 1),
(4, 'IP'    , NULL, 2),
(5, 'PAM I' , NULL, 2),
(6, 'BDII'  , NULL, 2),
(7, 'SSI'   , NULL, 3),
(8, 'BDIII' , NULL, 3),
(9, 'SE'    , NULL, 3),
(10, 'PLE'  , NULL, 4),
(11, 'CPOC' , NULL, 5),
(12, 'PE'   , NULL, 6),
(13, 'DD'   , NULL, 1);

INSERT INTO professor (id_professor, nome, sexo) VALUES
(1, 'André', 'M'),
(2, 'Pablo', 'M'),
(3, 'Edson', 'M'),
(4, 'Edna', 'F'),
(5, 'Ivan', 'M'),
(6, 'Guto', 'M');

insert into prof_disc values 
(1,2),
(2,2),
(2,3),
(3,1),
(4,2),
(5,6),
(6,1),
(7,2),
(8,1),
(9,2),
(10,5),
(11,5),
(12,4),
(13,2),
(13,3);

/*
select d.nome_disc, p.nome 
from disciplina d, professor p, prof_disc
where (d.id_disciplina=prof_disc.id_disc) and (prof_disc.id_prof=p.id_professor);

select d.nome_disc, p.nome 
from prof_disc t inner join disciplina d on (d.id_disciplina = t.id_disc)
			     inner join professor p on (t.id_prof=p.id_professor)
where p.id_professor=1;
*/