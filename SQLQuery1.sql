create procedure psValidaLogin
@logindecliente char(11),
@senha char(6)
as
select * from Cliente
where logindecliente=@logindecliente and senha=@senha

create procedure ps_buscaContasPorIdCorrentista_48 
@idcliente int
as
select * from conta
where idCliente=@idcliente

 

exec ps_buscaContasPorIdCorrentista_48 1



	









insert into Cliente
values ('vitor','12312312312', '112233445', '123123','11/06/2000', 'vitor@hotmail.com', 'masculino', '13991651655', 'casa amarela de esquina', 'Rua jornalista donato ribeiro','cubatão','são paulo')

select * from Cliente