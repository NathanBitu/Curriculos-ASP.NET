create database Curriculos
use Curriculos
create table curriculos(
	CPF varchar(14) primary key not null,
	nome varchar(50),
	dataNasc smalldatetime,
	experiencia1 varchar(50),
	experiencia2 varchar(50),
	experiencia3 varchar(50),
	experiencia4 varchar(50),
	experiencia5 varchar(50),
	estudo1 varchar(50),
	estudo2 varchar(50),
	estudo3 varchar(50),
	estudo4 varchar(50),
	estudo5 varchar(50),
)

select * from curriculos
	