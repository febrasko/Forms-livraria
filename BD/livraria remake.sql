create database livraria2;
use livraria2;

create table cliente(
codigo int primary key,
nome varchar(100),
sexo char(1),
username varchar(50),
email varchar(100),
senha varchar(50),
cpf char(11),
telefone varchar(20),
rua_id int,
rua_bairro_id int,
rua_bairro_cidade_id int,
rua_bairro_cidade_estado_id int,
numero int
);

create table funcionario(
codigo int primary key,
nome varchar(100),
sexo char(1),
nascimento date,
estadocivil varchar(20),
cargo varchar(50),
horario varchar(20),
salario int, 
rua_id int,
rua_bairro_id int,
rua_bairro_cidade_id int,
rua_bairro_cidade_estado_id int,
numero int
);

create table livro(
codigo int primary key,
titulo varchar(100),
autor varchar(200),
genero varchar(100),
datapub date,
descricao varchar(400)
);

create table estado(
id int primary key,
nome varchar(50),
sigla char(2)
);

create table cidade(
id int primary key,
nome varchar(50),
estado_id int
);
create table bairro(
id int primary key,
nome varchar(50),
cidade_id int,
cidade_estado_id int
);
create table rua(
id int primary key,
nome varchar(50),
bairro_id int,
bairro_cidade_id int,
bairro_cidade_estado_id int
);