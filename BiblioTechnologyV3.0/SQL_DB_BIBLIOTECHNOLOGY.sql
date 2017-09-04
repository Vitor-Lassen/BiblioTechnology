﻿CREATE TABLE TB_LOCADOR(
COD_LOC INT PRIMARY KEY,
NOME_LOC VARCHAR(150),
TURMA_LOC VARCHAR(10),
TEL_LOC VARCHAR (13),
CEL_LOC VARCHAR (14),
END_LOC VARCHAR(255),
NUMERO_LOC INT,
COMPLEMENTO_LOC VARCHAR(20),
BAIRRO_LOC VARCHAR(50),
CIDADE_LOC VARCHAR (50),
CEP_LOC INT
)

CREATE TABLE TB_GENERO(
GENERO VARCHAR (20) PRIMARY KEY 
)

CREATE TABLE TB_EDITORA(
COD_EDIT INT PRIMARY KEY IDENTITY(1,1),
NOME_EDIT VARCHAR(100),
TEL_EDIT VARCHAR (13),
EMAIL_EDIT VARCHAR (255),
SITE_EDIT VARCHAR (255),
END_EDIT VARCHAR(255),
NUMERO_EDIT INT,
COMPLEMENTO_EDIT VARCHAR(20),
BAIRRO_EDIT VARCHAR(50),
CIDADE_EDIT VARCHAR (50),
CEP_EDIT INT
)

CREATE TABLE TB_LIVROS(
COD_LIVRO INT PRIMARY KEY IDENTITY(1,1),
TITULO_LIVRO VARCHAR(100),
AUTOR_LIVRO VARCHAR(150),
EDICAO_LIVRO VARCHAR(20),
ANO_LANÇAMENTO VARCHAR(4),
GENERO VARCHAR(20) REFERENCES TB_GENERO(GENERO),
COD_EDIT INT REFERENCES TB_EDITORA (COD_EDIT),
LUGAR_LIVRO VARCHAR(50),
ATIVO_LIVRO BIT,
OBS_LIVRO VARCHAR(200)

)

CREATE TABLE TB_LOCACAO(
COD_LOCACAO INT PRIMARY KEY IDENTITY(1,1),
COD_LOC INT REFERENCES TB_LOCADOR(COD_LOC),
COD_LIVRO INT REFERENCES TB_LIVROS(COD_LOC),
DATA_LOCACAO DATE,
DATA_DEVOLCAO DATE,
DEVOLUCAO DATE,
)