-- Criando banco dados 
Create database DBPizza;
-- Usando banco de dados
Use DBPizza;
-- Criando as tabelas do banco de dados
Create table tbpedido(
codPedido int primary key auto_increment,
tipoPizza varchar(50),
valorPizza varchar(50),
valorOpcao varchar(50),
valorTotal varchar(50)
);

-- Consultando as tabelas do banco de dados

select*from tbpedido;
