create database entregas
use entregas

CREATE TABLE [moradores] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [nome] nvarchar(50) NOT NULL,
  [cpf] nvarchar(20) UNIQUE NOT NULL,
  [rg] nvarchar(20) UNIQUE NOT NULL,
  [num_apto] nvarchar(5) NOT NULL,
  [bloco_apto] nvarchar(3) NOT NULL,
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
