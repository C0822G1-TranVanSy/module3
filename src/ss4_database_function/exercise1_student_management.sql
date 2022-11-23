create database student_management;
use student_management;

CREATE TABLE class(
    class_id INT AUTO_INCREMENT PRIMARY KEY,
    class_name VARCHAR(60) NOT NULL,
    start_date DATETIME NOT NULL,
    `status` BIT
);

CREATE TABLE student(
    student_id INT AUTO_INCREMENT PRIMARY KEY,
    student_name VARCHAR(30) NOT NULL,
    address  VARCHAR(50),
    phone VARCHAR(20),
    `status` BIT,
    class_id INT NOT NULL,
    FOREIGN KEY (class_id) REFERENCES class (class_id)
);

CREATE TABLE `subject`(
    sub_id INT AUTO_INCREMENT PRIMARY KEY,
    sub_name VARCHAR(30) NOT NULL,
    credit TINYINT NOT NULL DEFAULT 1 CHECK ( credit >= 1 ),
    `status` BIT DEFAULT 1
);

CREATE TABLE mark(
    mark_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    sub_id INT NOT NULL,
    student_id INT NOT NULL,
    mark FLOAT DEFAULT 0 CHECK ( mark BETWEEN 0 AND 100),
    exam_times TINYINT DEFAULT 1,
    UNIQUE (sub_id, student_id),
    FOREIGN KEY (sub_id) REFERENCES `subject` (sub_id),
    FOREIGN KEY (student_id) REFERENCES student (student_id)
);

select * from `student_management`.`class`; 

INSERT INTO `student_management`.`class` ( `class_name`, `start_date`, `status`) VALUES ( 'A1', '2008/12/20', 1);

INSERT INTO `student_management`.`class` ( `class_name`, `start_date`, `status`) VALUES ( 'A2', '2008/12/22', 1);

INSERT INTO `student_management`.`class` ( `class_name`, `start_date`, `status`) VALUES ( 'B3', current_date(), 0);

INSERT INTO student_management.student (student_name, address, phone, `status`, class_id)
VALUES ('Hung', 'Ha Noi', '0912113113', 1, 1);

INSERT INTO student_management.student (student_name, address, `status`, class_id)
VALUES ('Hoa', 'Hai phong', 1, 1);

INSERT INTO student_management.student (student_name, address, phone, `status`, class_id)
VALUES ('Manh', 'HCM', '0123123123', 0, 2);

INSERT INTO student_management.`subject`
VALUES (1, 'CF', 5, 1),
       (2, 'C', 6, 1),
       (3, 'HDJ', 5, 1),
       (4, 'RDBMS', 10, 1);
       
INSERT INTO student_management.Mark (sub_id, student_id, mark, exam_times)
VALUES (1, 1, 8, 1),
       (1, 2, 10, 2),
       (2, 1, 12, 1);
       
use student_management;

-- Hiển thị tất cả các thông tin môn học (bảng subject) có credit lớn nhất.
select 
  * 
from 
  subject 
where 
  credit = (
    select 
      max(credit) 
    from 
      subject
  );
  
-- Hiển thị các thông tin môn học có điểm thi lớn nhất.
select 
  s.*, 
  max(m.mark) 
from 
  subject s 
  join mark m on s.sub_id = m.sub_id 
group by 
  s.sub_id;
  
-- Hiển thị các thông tin sinh viên và điểm trung bình của mỗi sinh viên, xếp hạng theo thứ tự điểm giảm dần
select 
  s.*, 
  avg(mark) as avg_mark 
from 
  student s 
  join mark m on s.student_id = m.student_id 
group by 
  s.student_id 
order by 
  avg(mark) desc;