create database `student_management`;
use `student_management`;
create table Class(
  id int auto_increment primary key, 
  `name` varchar(45)
);
create table Teacher(
  id int auto_increment primary key, 
  `name` varchar(45), 
  age int, 
  country varchar(45)
);
select 
  * 
from 
  Teacher;
  select 
  * 
from 
  Class;
  insert into Class(name) values(
  "C08");
  delete from class where id = 3;