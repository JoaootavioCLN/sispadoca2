CREATE TABLE [funcionarios] (
	[cpf] nvarchar(11) NOT NULL UNIQUE,
	[nome] nvarchar(67) NOT NULL UNIQUE,
	[cargo] nvarchar(20) NOT NULL,
	[email] nvarchar(50) NOT NULL UNIQUE,
	[telefone] nvarchar(15) NOT NULL UNIQUE,
	[datadenascimento] date NOT NULL UNIQUE,
	[rg] nvarchar(9) NOT NULL UNIQUE,
	[cargahoraria] nvarchar(10) NOT NULL UNIQUE,
	PRIMARY KEY ([cpf])
);
CREATE TABLE [cliente] (
	[cpf] nvarchar(11) NOT NULL UNIQUE,
	[nome] nvarchar(100) NOT NULL UNIQUE,
	[email] nvarchar(100) NOT NULL UNIQUE,
	[telefone] nvarchar(15) NOT NULL UNIQUE,
	[datacadastro] datetime NOT NULL UNIQUE,
	[datanascimento] date NOT NULL UNIQUE,
	PRIMARY KEY ([cpf])
);
CREATE TABLE [produto] (
	[id_produto] int IDENTITY(1,1) NOT NULL UNIQUE,
	[lote] nvarchar(2) NOT NULL,
	[nome] nvarchar(5000) NOT NULL,
	[datavalidade] date NOT NULL UNIQUE,
	[codbarras] nvarchar(13) NOT NULL UNIQUE,
	[cnpj] int NOT NULL,
	[quantidade] int UNIQUE,
	[id_ingredientes] int NOT NULL,
	PRIMARY KEY ([id_produto])
);
CREATE TABLE [fornecedor] (
	[cnpj] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nomefantasia] nvarchar(35) NOT NULL UNIQUE,
	[telefone] nvarchar(15) NOT NULL,
	[representante] nvarchar(max) NOT NULL,
	[nacionalidade] nvarchar(50) NOT NULL UNIQUE,
	[emailcontato] nvarchar(30) NOT NULL,
	[contrato] nvarchar(200) NOT NULL UNIQUE,
	PRIMARY KEY ([cnpj])
);
CREATE TABLE [ingredientes] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(50) NOT NULL UNIQUE,
	[unidademedida] nvarchar(max) NOT NULL,
	[preçocompra] int NOT NULL UNIQUE,
	[cnpj] int NOT NULL,
	PRIMARY KEY ([id])
);
ALTER TABLE [produto] ADD CONSTRAINT [produto_fk7] FOREIGN KEY ([id_ingredientes]) REFERENCES [ingredientes]([id]);
ALTER TABLE [produto] ADD CONSTRAINT [produto_fk6] FOREIGN KEY (cnpj) REFERENCES fornecedor (cnpj);
ALTER TABLE [ingredientes] ADD CONSTRAINT [ingredientes_fk4] FOREIGN KEY ([cnpj]) REFERENCES [fornecedor]([cnpj]);