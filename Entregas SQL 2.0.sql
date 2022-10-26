CREATE TABLE [moradores] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [nome] nvarchar(255) NOT NULL,
  [cpf] nvarchar(255) UNIQUE NOT NULL,
  [rg] nvarchar(255) UNIQUE NOT NULL,
  [num_apto] nvarchar(255) NOT NULL,
  [bloco_apto] nvarchar(255) NOT NULL,
  [data_cadastro] datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP)
)
GO

CREATE TABLE [encomendas] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [id_morador] int,
  [data_cadastro] datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP),
  [data_retirada] datetime DEFAULT (CURRENT_TIMESTAMP),
  [nome_recebedor] nvarchar(255)
)
GO

ALTER TABLE [encomendas] ADD FOREIGN KEY ([id_morador]) REFERENCES [moradores] ([id])
GO
