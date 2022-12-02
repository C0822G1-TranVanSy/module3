create database user_management;
use user_management;

create table users (
id int auto_increment primary key,
name varchar(120) not null,
email varchar(220) not null,
country varchar(120)
);