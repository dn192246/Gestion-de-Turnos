drop table turno

create table turno(
id int identity(1,1) not null primary key,
peso varchar(4) not null,
estado int not null,
mesa int null,
idmiembro int null)
go

create table miembro(
idmiembro int not null primary key,
nombre varchar(80) not null
)
go

alter table turno
add constraint fk_miembro_turno
foreign key (idmiembro) references miembro(idmiembro)
on delete cascade
on update cascade
go

select * from turno

update turno set estado=1, mesa=1 where id=2