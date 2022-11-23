create database demo;
use demo;

create table products(
id int auto_increment primary key,
product_code int,
product_name varchar(50),
product_price double,
product_amount int,
product_description varchar(50),
product_status bit(1));
insert products (product_code,product_name,product_price,product_amount,product_description,product_status) 
values(101,'iphone',5000000,3,null,1),(102,'nokia',2000000,4,null,0),(103,'samsung',6000000,1,null,1);
-- Tạo Unique Index trên bảng Products (sử dụng cột productCode để tạo chỉ mục)
create unique index i_product_code on products(product_code);
-- Tạo Composite Index trên bảng Products (sử dụng 2 cột productName và productPrice)
create unique index i_product_name_price on products(product_name,product_price);
-- Sử dụng câu lệnh EXPLAIN để biết được câu lệnh SQL của bạn thực thi như nào
explain select product_code from products where product_code = 101;
explain select product_name,product_price from products where product_name='iphone' and product_price = 5000000;
-- So sánh câu truy vấn trước và sau khi tạo index
drop index i_product_code on products;
explain select product_code from products where product_code = 101;
explain select product_name,product_price from products where product_name='iphone' and product_price = 5000000;
-- Tạo view lấy về các thông tin: productCode, productName, productPrice, productStatus từ bảng products.
create view w_product as select product_code,product_name,product_price,product_status from products;
select * from w_product;
-- Tiến hành sửa đổi view
alter view w_product as select product_code,product_name,product_price,product_status from products where product_code =101;
update w_product set product_name = 'toto' where product_code = 101;
-- Tiến hành xoá view
drop view w_product;
-- Tạo store procedure lấy tất cả thông tin của tất cả các sản phẩm trong bảng product
delimiter //
create procedure sp_product ()
begin
select * from products;
end //
delimiter ;
call sp_product();
drop procedure sp_product;
-- Tạo store procedure thêm một sản phẩm mới
delimiter //
create procedure sp_add_product (in a int,in b varchar(50),in c double,in d int ,in e varchar(50),in f bit)
begin
insert into products (product_code,product_name,product_price,product_amount,product_description,product_status) 
value(a,b,c,d,e,f);
end //
delimiter ;
call sp_add_product(104,'oppo',1000000,5,null,0);
-- Tạo store procedure sửa thông tin sản phẩm theo id
delimiter //
create procedure sp_update_product (in name_p varchar(50),in id_p int)
begin
update products set product_name = name_p where id = id_p;
end //
delimiter ;
call sp_update_product('cucgach',3);
-- Tạo store procedure xoá sản phẩm theo id
delimiter //
create procedure sp_delete_product (in id_p int)
begin
delete from products where id = id_p;
end //
delimiter ;
call sp_delete_product(3);