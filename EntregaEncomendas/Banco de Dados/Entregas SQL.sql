create database entregas
use entregas

CREATE TABLE [moradores] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [nome] varchar(50) NOT NULL,
  [cpf] varchar(20) UNIQUE NOT NULL,
  [rg] varchar(20) UNIQUE NOT NULL,
  [num_apto] varchar(5) NOT NULL,
  [bloco_apto] varchar(3) NOT NULL,
  [data_cadastro] datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP)
)
GO

CREATE TABLE [encomendas] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [id_morador] int FOREIGN KEY REFERENCES moradores,
  [data_cadastro] datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP),
  [data_retirada] datetime,
  [nome_recebedor] nvarchar(50)
)
GO

drop table moradores
drop table encomendas
select * from moradores
select * from encomendas
INSERT INTO moradores (nome, cpf, rg,num_apto,bloco_apto)
VALUES ('Breno Carlos', '43469972877', '5168921222',15,3);
INSERT INTO moradores (nome, cpf, rg,num_apto,bloco_apto) 
values ('Nicolas Gabriel', 12367867234, 7654322431,10,1); 


INSERT INTO encomendas (id_morador, data_retirada,nome_recebedor)
values (3,09/02/2022,'Gabriel Cordeiro'); 
INSERT INTO encomendas (id_morador, data_retirada,nome_recebedor) 
values (4,23/08/2022,'Nicolas Oliveira'); 

