create database user_management;
use user_management;

create table users (
id int auto_increment primary key,
name varchar(120) not null,
email varchar(220) not null,
country varchar(120)
);
select *from users;
select * from users where country like "%c%";
select * from users order by name;

delimiter //
create procedure get_user_by_id(in user_id int)
begin
select * from users where users.id = user_id;
end //
delimiter ;

delimiter //
create procedure insert_user(in user_name varchar(50), in user_email varchar(50), in user_country varchar(50))
begin
	insert into users(name,email,country) values(user_name, user_email, user_country);
end //
delimiter ;

delimiter //
create procedure display_list()
begin
	select * from users order by name;
end //
delimiter ;

delimiter //
create procedure edit_user(in user_name varchar(50), in user_email varchar(50), in user_country varchar(50), in user_id int)
begin
	update users set `name` = user_name, email = user_email, country = user_country where id = user_id;
end //
delimiter ;

delimiter //
create procedure remove_user(in user_id int)
begin
	delete from users where id = user_id;
end //
delimiter ;
