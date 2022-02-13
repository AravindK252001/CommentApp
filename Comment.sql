create database commentapp
drop database commentapp

create table commenttable
(
Id int identity(1,1) primary key,
Username varchar(150) unique not null,
Pass varchar(150) not null,
Secretcode varchar(150) not null,
Comment varchar(500) null
)

select * from commenttable

drop table commenttable