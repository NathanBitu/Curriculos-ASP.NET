drop database Curriculos

create database Curriculos
use Curriculos

create table curriculos(
	nome varchar(50),
	cpf varchar(14) primary key not null,
	endereco varchar(50),
	telefone varchar(11),
	pretencaoSalarial float,
	cargoPretendido varchar(50),
	instituicaoFormacao1 varchar(50),
	tipoFormacao1 varchar(50),
	formacao1 varchar(50),
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
	idioma2 varchar(15),
	idioma3 varchar(15),
)