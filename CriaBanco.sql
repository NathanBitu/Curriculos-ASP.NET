drop database Curriculos

create database Curriculos

use Curriculos

create table curriculos(
	nome varchar(50) not null,
	cpf varchar(14) primary key not null,
	endereco varchar(50) not null,
	telefone varchar(11) not null,
	pretencaoSalarial float not null,
	cargoPretendido varchar(50) not null,
	instituicaoFormacao1 varchar(50) not null,
	tipoFormacao1 varchar(50) not null,
	formacao1 varchar(50) not null,
	instituicaoFormacao2 varchar(50),
	tipoFormacao2 varchar(50),
	formacao2 varchar(50),
	instituicaoFormacao3 varchar(50),
	tipoFormacao3 varchar(50),
	formacao3 varchar(50),
	instituicaoFormacao4 varchar(50),
	tipoFormacao4 varchar(50),
	formacao4 varchar(50),
	instituicaoFormacao5 varchar(50),
	tipoFormacao5 varchar(50),
	formacao5 varchar(50),
	empresaExperiencia1 varchar(50),
	tipoExperiencia1 varchar(50),
	experiencia1 varchar(50),
	empresaExperiencia2 varchar(50),
	tipoExperiencia2 varchar(50),
	experiencia2 varchar(50),
	empresaExperiencia3 varchar(50),
	tipoExperiencia3 varchar(50),
	experiencia3 varchar(50),
	idioma1 varchar(15),
	nivelIdioma1 varchar(15),
	idioma2 varchar(15),
	nivelIdioma2 varchar(15),
	idioma3 varchar(15),
	nivelIdioma3 varchar(15)
)

select * from curriculos