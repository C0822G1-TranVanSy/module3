create database qlsv;
use qlsv;

create table jame(
user_name varchar(50) primary key,
`password` varchar(50));

create table class(
id int auto_increment primary key,
classname varchar(50));

create table room(
id int primary key,
name varchar(50),
class_id int,
foreign key (class_id) references class(id));

create table student(
id int auto_increment primary key,
studentname varchar(50),
gender boolean,
birthday date,
email varchar(50) default null,
point double,
user_name varchar(50) unique,
class_id int,
foreign key (user_name) references jame(user_name),
foreign key(class_id) references class(id));
create table instructor(
id int primary key,
name varchar(50),
birthday date,
salary double);

create table instructor_class(
instructor_id int,
class_id int,
primary key(instructor_id,class_id),
start_time date,
foreign key (instructor_id) references instructor(id),
foreign key (class_id) references class(id)
);
insert into class (classname) value ('c1121g1');
insert into class (classname) value ('c1221g1');
insert into class (classname) value ('a0821l1');
insert into class (classname) value ('a0921l1');

insert into jame (user_name,`password`) value('cunn','cunn');
insert into jame (user_name,`password`) value('chunng','chunng');
insert into jame (user_name,`password`) value('doann','doann');
insert into jame (user_name,`password`) value('b','b');
insert into jame (user_name,`password`) value('c','c');
insert into jame (user_name,`password`) value('d','d');

insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(1,'nguyen ngoc cu', 1,'1981/12/12',null,8,'cunn',1);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(2,'le hai chung', 1,'1990/12/12',null,5,'chunng',2);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(3,'hoang huu hai', 1,'1987/12/12',null,3,'doann',1);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(4,'nguyen ngoc huynh', 1,'1981/12/12',null,8,null,null);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(5,'nguyen ngoc a', 1,'1981/12/12',null,5,null,null);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(6,'hoang huu b', 1,'1987/12/12',null,9,'b',2);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(7,'hoang huu c', 1,'1987/12/12',null,9,'c',2);
insert into student (id,studentname,gender,birthday,email,point,user_name,class_id) values(8,'hoang huu d', 1,'1987/12/12',null,9,'d',2);
select * from student;

insert into instructor (id,name,birthday,salary) value (1,'tran van chanh','1985/03/02',100);
insert into instructor (id,name,birthday,salary) value (2,'tran minh chien','1985/03/02',200);
insert into instructor (id,name,birthday,salary) value (3,'vu thanh tien','1985/03/02',300);
insert into instructor (id,name,birthday,salary) value (4,'tran van nam','1985/03/02',100);

insert into instructor_class(instructor_id,class_id,start_time) value (1,1,null);
insert into instructor_class(instructor_id,class_id,start_time) value (1,2,null);
insert into instructor_class(instructor_id,class_id,start_time) value (1,3,null);
insert into instructor_class(instructor_id,class_id,start_time) value (2,1,null);
insert into instructor_class(instructor_id,class_id,start_time) value (2,2,null);
insert into instructor_class(instructor_id,class_id,start_time) value (2,3,null);

select student.*,class.classname from student join class on student.class_id = class.id;
select * from student inner join class on student.class_id = class.id;
select * from student where studentname like '%heo' or studentname like '%ga';
select * from student where studentname like 'nguyen%' ;
SELECT point, count(point) FROM student where point > 5 GROUP BY point ;
SELECT point, count(point) FROM student where point > 5 GROUP BY point having count(point) >=2;
select student.*,class.classname from student join class on student.class_id = class.id where classname = 'c1121g1'  order by studentname;

select class.classname,count(class.id) from class join student on class.id = student.class_id group by class.classname;
select class.classname,max(student.point) from class join student on class.id = student.class_id group by class.classname;
select class.classname,avg(student.point) from class join student on class.id = student.class_id group by class.classname;
select s.studentname,s.birthday,i.name as instructor_name,i.birthday from student s join instructor_class i_c on s.class_id = i_c.class_id join instructor i on i_c.instructor_id = i.id;
select studentname,point from student order by point desc limit 3;
select studentname,point from student where point = (select max(point) from student);
select studentname as name, birthday from student union select name, birthday from instructor;