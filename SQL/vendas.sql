
CREATE DATABASE vendas;
USE vendas;
CREATE TABLE cliente (
  CODCLI    int not null,
  NOMECLI   varchar(30) not null,
  ENDCLI    varchar(40) not null,
  CIDCLI    varchar(20) not null,
  CEPCLI    int unsigned not null,
  UF        char(2) not null,
  CNPJ      char(15) not null,
  FONE      int unsigned,
  SEXO      enum('M','F') not null,
  primary key(codcli)
);

CREATE TABLE vendedor (
  CODVEN 	int not null,
  NOMEVEN varchar(30) not null,
  FAIXA 	set('A','B','C') not null,
  SALARIO decimal(7,2) not null, 
  PRIMARY KEY (CODVEN)
);

CREATE TABLE produto (
  CODPROD 	int not null,
  DESCRICAO varchar(40) not null,
  EMBALAGEM	char(2) not null,
  VALUNIT 	decimal(7,2) not null,
  QTD_STQ 	smallint not null,
  DATA_ALT	timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  PRIMARY KEY (CODPROD)
);

CREATE TABLE pedido (
  NUMPED    int not null ,
  DATA      timestamp NOT NULL default CURRENT_TIMESTAMP,
  PRAZO     smallint not null,
  CODCLI    int not null,
  CODVEN    int not null,
  TOTAL_PEDIDO decimal(10,2),
  PRIMARY KEY (NUMPED)
);

CREATE TABLE  itempedido (
  ID_ITEM   int not null,
  NUMPED    int not null,
  CODPROD   int not null,
  QUANT     int not null,
  TOTAL_PROD decimal(7,2),
  PRIMARY KEY (ID_ITEM)
);

INSERT INTO cliente (CODCLI, NOMECLI, ENDCLI, CIDCLI, CEPCLI, UF, CNPJ, FONE,SEXO) VALUES
(100, 'Elisabete' , 'Av. Climério n. 45'    , 'São Paulo'     , 25679300, 'SP', '32485126/7326-8', 56439280,'F'),
(101, 'Jorge'     , 'Rua Caiapo n.13'       , 'Curitiba'      , 30078500, 'PR', '14512764/9834-9', 0       ,'M'),
(102, 'Edmar'     , 'Rua da Praia s/n'      , 'Salvador'      , 40019300, 'BA', '23463284/2341-9', 44327121,'M'),
(103, 'Paulo'     , 'Tv. Moraes c/3'        , 'Londrina'      , 30079300, 'PR', '32848223/3241-2', 32331923,'M'),
(104, 'Luis'      , 'Av. Beira Mar n. 1256' , 'Florianópolis' , 30077500, 'SC', '12736571/2347-4', 0       ,'M'),
(105, 'Lúcia'     , 'Rua Itabira 123 apto 9', 'Belo Horizonte', 22124391, 'MG', '28315213/9348-8', 34212985,'F'),
(106, 'José'      , 'Rua 3 b1.3 apto 1003'  , 'Brasília'      , 22841650, 'DF', '21763576/1232-3', 23122931,'M'),
(107, 'Susana'    , 'Rua Lopes Mendes n. 12', 'Niterói'       , 30046500, 'RJ', '21763571 /232-9', 36762530,'F'),
(108, 'Renato'    , 'Rua Meireles n. 123'   , 'Campinas'      , 30225900, 'SP', '13276571/1231-4', 66741820,'M'),
(109, 'Sebastião' , 'Rua da Igreja n. 10'   , 'Uberaba'       , 30438700, 'MG', '32176547/2131-3', 55679071,'M'),
(110, 'Rodolfo'   , 'Largo da Lapa n. 27'   , 'Rio de Janeiro', 30078900, 'RJ', '12835128/2346-9', 23227431,'M'),
(111, 'Ana'       , 'Rua 17 n. 19'          , 'Niterói'       , 24358310, 'RJ', '12113231/0001-4', 32112134,'F'),
(112, 'Marcos'    , 'Av. Paulista n. 1236'  , 'Araras'        , 3012683 , 'SP', '32816985/7465-6', 23459343,'M'),
(113, 'Fernando'  , 'Av. Preso Vargas n.10' , 'São Caetano'   , 22763931, 'SP', '22534126/9387-9', 34214631,'M');

INSERT INTO produto (CODPROD, DESCRICAO, EMBALAGEM, VALUNIT, QTD_STQ, DATA_ALT) VALUES
(200, 'Arroz'     , 'PC', '6.18', 90, '2022-03-17 01:49:46'),
(201, 'Feijão'    , 'PC', '0.11', 72, '2022-03-17 01:49:46'),
(202, 'Queijo'    , 'KG', '0.97', 61, '2022-03-17 01:49:46'),
(203, 'Açúcar'    , 'PC', '0.30',  5, '2022-03-17 01:49:46'),
(204, 'Chocolate' , 'BA', '0.87',  9, '2022-03-17 01:49:46'),
(205, 'Cenoura'   , 'KG', '0.25',  7, '2022-03-17 01:49:46'),
(206, 'Patinho'   , 'KG', '1.80', 10, '2022-03-17 01:49:46'),
(207, 'Balde'     , 'UN', '1.05', 81, '2022-03-17 01:49:46'),
(208, 'Guaraná'   , 'LT', '2.00', 66, '2022-03-17 01:49:46'),
(209, 'Vela'      , 'UN', '1.97',  3, '2022-03-17 01:49:46'),
(210, 'Bolacha'   , 'PC', '2.32', 22, '2022-03-17 01:49:46'),
(211, 'Bala'      , 'PC', '5.00', 12, '2022-03-17 01:49:46');

INSERT INTO vendedor (CODVEN, NOMEVEN, FAIXA, SALARIO) VALUES
(1, 'João'        , 'C', '2780.00'),
(2, 'João Silva'  , 'C', '2650.00'),
(3, 'Carlos José' , 'A', '2490.00'),
(4, 'José Luis'   , 'C', '1800.00'),
(5, 'Jonas'       , 'A', '2300.00'),
(6, 'Antônio'     , 'C', '9500.00'),
(7, 'Maurício'    , 'B', '2930.00'),
(8, 'Josias'      , 'B', '870.00'),
(9, 'Felipe'      , 'A', '4600.00');

INSERT INTO pedido (NUMPED, `DATA`, PRAZO, CODCLI, CODVEN, TOTAL_PEDIDO) VALUES
(1, '2020-02-24 02:30:52', 20, 100, 1, '0.00'),
(2, '2020-03-21 02:30:52', 20, 110, 2, '0.00'),
(3, '2020-04-08 02:30:52', 20, 109, 3, '0.00'),
(4, '2020-05-10 02:30:52', 15, 109, 3, '0.00'),
(5, '2020-05-10 02:30:52', 20, 102, 4, '0.00'),
(6, '2020-07-16 02:30:52', 30, 101, 5, '0.00'),
(7, '2020-08-24 02:30:52', 15, 104, 6, '0.00'),
(8, '2021-02-07 02:30:52', 15, 106, 6, '0.00'),
(9, '2021-02-16 02:30:52', 20, 100, 7, '0.00'),
(10, '2021-05-16 02:30:52', 30, 110, 1, '0.00'),
(11, '2021-07-13 02:30:52', 20, 111, 1, '0.00'),
(12, '2021-09-14 02:30:52', 10, 112, 2, '0.00'),
(13, '2021-10-18 02:30:52', 20, 112, 3, '0.00'),
(14, '2021-11-20 02:30:52', 20, 107, 7, '0.00'),
(15, '2021-12-12 02:30:52', 30, 105, 7, '0.00'),
(16, '2022-01-11 02:30:52', 20, 104, 8, '0.00'),
(17, '2022-02-06 02:30:52', 15, 102, 9, '0.00'),
(18, '2022-03-02 02:30:52', 30, 108, 9, '0.00');

INSERT INTO itempedido (ID_ITEM, NUMPED, CODPROD, QUANT, TOTAL_PROD) VALUES
(1, 1, 200,    9, '55.62'),
(2, 1, 204,   22, '19.14'),
(3, 2, 200,    9, '55.62'),
(4, 2, 204,   20, '17.40'),
(5, 3, 204,    5, '4.35'),
(6, 4, 200,    5, '30.90'),
(7, 4, 207,    9, '9.45'),
(8, 4, 204,    2, '1.74'),
(9, 4, 205,   18, '4.50'),
(10, 5, 210,  37, NULL),
(11, 6, 210,  32, '74.24'),
(12, 7, 205,  10, '2.50'),
(13, 9, 209,  10, '19.70'),
(14, 9, 204,   1, '0.87'),
(15, 9, 205,  70, '17.50'),
(16, 10, 200,  7, '43.26'),
(17, 10, 206, 10, '18.00'),
(18, 10, 210, 43, '99.76'),
(19, 10, 204, 40, '34.80'),
(20, 11, 209, 10, NULL),
(21, 11, 207, 35, '36.75'),
(22, 11, 204,  2, '1.74'),
(23, 13, 200,  8, '49.44'),
(24, 14, 206, 10, '18.00'),
(25, 14, 210, 18, '41.76'),
(26, 14, 204, 35, '30.45'),
(27, 15, 207, 20, '21.00'),
(28, 15, 205, 10, '2.50'),
(29, 16, 209, 10, '19.70'),
(30, 16, 207,  7, NULL),
(31, 16, 203,  8, '2.40'),
(32, 16, 204,  3, '2.61'),
(33, 16, 205, 30, '7.50'),
(34, 17, 205, 45, '11.25'),
(35, 18, 200, 13, '80.34'),
(36, 18, 207,  6, '6.30');

ALTER TABLE pedido
  ADD FOREIGN KEY (CODVEN) REFERENCES vendedor (CODVEN),
  ADD FOREIGN KEY (CODCLI) REFERENCES cliente (CODCLI);

ALTER TABLE itempedido
  ADD FOREIGN KEY (NUMPED) REFERENCES pedido (NUMPED),
  ADD FOREIGN KEY (CODPROD) REFERENCES produto (CODPROD);
