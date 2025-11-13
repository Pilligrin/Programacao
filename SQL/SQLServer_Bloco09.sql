USE master;
DROP TABLE IF EXISTS notebooks_carrinhos;
DROP TABLE IF EXISTS carrinhos_nt;
DROP TABLE IF EXISTS manutencoes;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS categorias_usuarios;
DROP TABLE IF EXISTS conferencias;
DROP TABLE IF EXISTS equipamentos;
DROP TABLE IF EXISTS status_equip;
DROP TABLE IF EXISTS modelos_equip;
DROP TABLE IF EXISTS marcas_equip;
DROP TABLE IF EXISTS descricoes_equip;
DROP TABLE IF EXISTS locais;

CREATE TABLE status_equip (
cod_status INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
descr_status VARCHAR(30) NOT NULL
);
INSERT INTO status_equip (descr_status) VALUES
('OK'),
('Em manutenção'),
('Indisponível'),
('Desativado');
SELECT * FROM status_equip;

CREATE TABLE modelos_equip (
cod_modelo INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
descr_modelo VARCHAR(100) NOT NULL
);
INSERT INTO modelos_equip (descr_modelo) VALUES
('MO-2061'),
('MP-3005'),
('ET-2053DMM'),
('ET-2042C'),
('ET-2082C'),
('DM-313'),
('ET-3005'),
('MPL-3303M'),
('MO-2061'),
('SD-1202'),
('MFG-4221');
SELECT * FROM modelos_equip;

CREATE TABLE marcas_equip (
cod_marca INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
descr_marca VARCHAR(60) NOT NULL
);
INSERT INTO marcas_equip (descr_marca) VALUES
('Minipa'),
('GoldStar');
SELECT * FROM marcas_equip;

CREATE TABLE descricoes_equip (
cod_descr INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
descricao VARCHAR(60) NOT NULL
);
INSERT INTO descricoes_equip (descricao) VALUES
('Osciloscópio Digital LCD 5,7" 60Mhz 2 Canais'),
('Fonte regulável DC 30V 3A'),
('Multímetro digital'),
('Multímetro analógico'),
('Maleta de ensaios para eletrônica'),
('Gerador de função 20MHz');
SELECT * FROM descricoes_equip;

CREATE TABLE locais (
cod_local INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
descr_local VARCHAR(30) NOT NULL,
ramal INTEGER,
bloco VARCHAR(10) NOT NULL
);
INSERT INTO locais (descr_local, ramal, bloco) VALUES
('Lab. 71', 6693, 9),
('Lab. 70', 6692, 9),
('Lab. 66', 6688, 9);
SELECT * FROM locais;

CREATE TABLE equipamentos (
cod_equipamento INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
cod_marca INTEGER,
cod_modelo INTEGER,
cod_descr INTEGER,
num_patrimonio INTEGER,
serialNum VARCHAR(60) NOT NULL,
cod_sap INTEGER,
cod_local INTEGER,
cod_status INTEGER DEFAULT 1,
FOREIGN KEY(cod_marca) REFERENCES marcas_equip(cod_marca),
FOREIGN KEY(cod_modelo) REFERENCES modelos_equip(cod_modelo),
FOREIGN KEY(cod_descr) REFERENCES descricoes_equip(cod_descr),
FOREIGN KEY(cod_local) REFERENCES locais(cod_local),
FOREIGN KEY(cod_status) REFERENCES status_equip(cod_status)
);
INSERT INTO equipamentos
(cod_marca, cod_modelo, cod_descr, num_patrimonio, serialNum, cod_sap, cod_local, cod_status) VALUES
(1,7,4,NULL, 'MA000002202' ,NULL,3,1),
(1,8,2,206062, 'B3303M001439' ,1053613,3,1),
(1,8,2,206064, 'B3303M001464' ,1053613,3,1),
(1,8,2,206057, 'B3303M001466' ,1053613,3,1),
(1,8,2,206059, 'B3303M001477' ,1053613,3,1),
(1,8,2,206061, 'B3303M001484' ,1053613,3,1),
(1,8,2,206058, 'B3303M001486' ,1053613,3,1),
(1,8,2,206063, 'B3303M001496' ,1053613,3,1),
(1,8,2,206060, 'B3303M001499' ,1053613,3,1),
(1,1,1,202249, 'MO2061000005' ,NULL,3,1),
(1,1,1,202210, 'MO2061000014' ,NULL,3,1),
(1,1,1,202208, 'MO2061000015' ,NULL,3,1),
(1,1,1,202204, 'MO2061000030' ,NULL,3,1),
(1,1,1,202202, 'MO2061000258' ,NULL,3,1),
(1,1,1,202246, 'MO2061000260' ,NULL,3,1),
(1,1,1,202200, 'MO2061000274' ,NULL,3,1),
(1,1,1,202211, 'MO2061000275' ,NULL,3,1),
(1,10,5,202214, 'SD1202000051' ,NULL,3,1),
(1,10,5,204120, 'SD1202000052' ,NULL,3,1),
(1,10,5,204119, 'SD1202000053' ,NULL,3,1),
(1,10,5,202243, 'SD1202000054' ,NULL,3,1),
(1,10,5,202203, 'SD1202000055' ,NULL,3,1),
(1,10,5,202201, 'SD1202000056' ,NULL,3,1),
(1,10,5,202244, 'SD1202000057' ,NULL,3,1),
(1,10,5,202206, 'SD1202000058' ,NULL,3,1),
(1,11,6,206065, '11040038' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002889' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002890' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002891' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002892' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002893' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002894' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002895' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002896' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002897' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002898' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002899' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002900' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002901' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002902' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002903' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002904' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002905' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002906' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002907' ,NULL,3,1),
(1,3,3,NULL, 'EB2053002908' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023243' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023247' ,NULL,3,1),
(1,4,3,NULL, 'ET204C022429' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023250' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023252' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023253' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023254' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023258' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023261' ,NULL,3,1),
(1,4,3,NULL, 'ET204C023262' ,NULL,3,1),
(1,5,3,NULL, 'EB208C008755' ,NULL,3,1),
(1,5,3,NULL, 'M00130002389' ,NULL,3,1),
(1,5,3,NULL, 'M00130002390' ,NULL,3,1),
(1,5,3,NULL, 'M00130002404' ,NULL,3,1),
(1,5,3,NULL, 'M00130002405' ,NULL,3,1),
(2,6,3,NULL, '313000431' ,NULL,3,1),
(2,6,3,NULL, '313000436' ,NULL,3,1),
(1,7,3,NULL, 'MA000002202' ,NULL,3,1),
(1,5,3,NULL, 'M001300009166M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009161M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009168M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009167M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009159M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009169M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009162M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009171M' ,NULL,3,1),
(1,5,3,NULL, 'M001300009163M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011025M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011026M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011028M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011029M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011030M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011032M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011033M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011034M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011035M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011036M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011037M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011038M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011039M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011040M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011041M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011042M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011043M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011044M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011045M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011046M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011047M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011048M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011049M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011050M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011051M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011052M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011053M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011054M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011055M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011056M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011057M' ,NULL,3,1),
(1,5,3,NULL, 'M001300011058M' ,NULL,3,1);
SELECT * FROM equipamentos;

CREATE TABLE conferencias (
cod_equipamento INTEGER,
conf_datahora DATE NOT NULL,
FOREIGN KEY(cod_equipamento) REFERENCES equipamentos(cod_equipamento),
PRIMARY KEY(cod_equipamento, conf_datahora)
);
INSERT INTO conferencias (cod_equipamento, conf_datahora) VALUES
(1, '2023-10-27T10:38:33'),
(3, '2023-10-21T07:45:00'),
(4, '2023-10-07T14:12:58'),
(3, '2023-10-14T16:00:12'),
(1, '2023-09-15T12:15:33');
SELECT * FROM conferencias;

CREATE TABLE categorias_usuarios (
cod_categoria INTEGER PRIMARY KEY IDENTITY(1, 1) NOT NULL,
cat_descr VARCHAR(30)
);
INSERT INTO categorias_usuarios (cat_descr) VALUES
('Técnico de laboratório'),
('Coordenador'),
('Professor'),
('Colaborador'),
('Aluno');
SELECT * FROM categorias_usuarios;

CREATE TABLE usuarios (
cod_usuario INTEGER PRIMARY KEY IDENTITY(1, 1),
registro INTEGER NOT NULL,
cod_categoria INTEGER DEFAULT 5,
nome VARCHAR(200) NOT NULL,
email VARCHAR(200) NOT NULL,
FOREIGN KEY(cod_categoria) REFERENCES categorias_usuarios(cod_categoria)
);
INSERT INTO usuarios (cod_categoria, registro, nome, email) VALUES
(1, 12341,'Ryan Pantaleão Carvalho', 'rcarvalho@cefsa.edu.br'),
(3, 9111,'Marco Aurélio Vinchi de Oliveira', 'pro9111@cefsa.edu.br'),
(2, 4666,'Silvio Celso Peixoto Gomes', 'speixoto@cefsa.edu.br');
SELECT * FROM usuarios;

CREATE TABLE manutencoes (
cod_manut INTEGER PRIMARY KEY IDENTITY(1, 1),
cod_equipamento INTEGER,
cod_usuario_solicitante INTEGER,
cod_usuario_aprovador INTEGER,
manut_descr VARCHAR(600),
manut_datahora_abertura DATETIME NOT NULL,
manut_datahora_conclusao DATETIME,
manut_obs VARCHAR(1000),
FOREIGN KEY(cod_equipamento) REFERENCES equipamentos(cod_equipamento),
FOREIGN KEY(cod_usuario_solicitante) REFERENCES usuarios(cod_usuario),
FOREIGN KEY(cod_usuario_aprovador) REFERENCES usuarios(cod_usuario)
);
INSERT INTO manutencoes 
(cod_equipamento, cod_usuario_solicitante, cod_usuario_aprovador, manut_descr, manut_datahora_abertura, manut_datahora_conclusao, manut_obs)
VALUES
(2, 1, 3, 'Falha no display', '2023-10-15T07:30:00', '2023-10-22T12:00:00', NULL),
(3, 1, 3, 'Ajuste de tensão avariado', '2023-11-01T07:00:00', NULL, NULL);
SELECT * FROM manutencoes;

CREATE TABLE carrinhos_nt (
cod_carrinho INTEGER PRIMARY KEY IDENTITY(1, 1),
carr_descr VARCHAR(300),
carr_capac INTEGER NOT NULL
);
INSERT INTO carrinhos_nt (carr_descr, carr_capac)
VALUES ('DELL', 40),
('HP', 40),
('Hacktron', 42);
SELECT * FROM carrinhos_nt;

CREATE TABLE notebooks_carrinhos (
cod_equip INTEGER,
cod_carrinho INTEGER,
FOREIGN KEY(cod_equip) REFERENCES equipamentos(cod_equipamento),
FOREIGN KEY(cod_carrinho) REFERENCES carrinhos_nt(cod_carrinho)
);
--INSERT INTO notebooks_carrinhos VALUES ();
SELECT * FROM notebooks_carrinhos;




SELECT * FROM SYSOBJECTS WHERE xtype = 'U'


SELECT * FROM equipamentos;
SELECT * FROM descricoes_equip;
SELECT * FROM status_equip;
SELECT * FROM modelos_equip;
SELECT * FROM marcas_equip;

SELECT mar.descr_marca 'marca' , mo.descr_modelo 'modelo', de.descricao 'descrição', equipamentos.num_patrimonio 'nº patr.', equipamentos.serialNum 'Serial Number'FROM equipamentos
INNER JOIN marcas_equip mar ON mar.cod_marca =equipamentos.cod_marca
INNER JOIN modelos_equip mo ON mo.cod_modelo = equipamentos.cod_modelo
INNER JOIN descricoes_equip de ON de.cod_descr = equipamentos.cod_descr
WHERE de.descricao LIKE '%Mult%'