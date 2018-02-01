create database schedule

create table schedule
(
name varchar (30),
phone varchar (13)
)

insert into schedule values('Guilherme', '5511963996533')

select * from schedule

use schedule

create table cadastro
(
cod int identity primary key,
name varchar (30),
phone varchar (13)
)

insert into cadastro values ('Guilherme Montagnani','5511963996533')

select * from cadastro