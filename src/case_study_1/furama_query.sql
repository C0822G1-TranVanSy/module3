use furama;

-- 2.Hiển thị thông tin của tất cả nhân viên có trong hệ thống có tên bắt đầu là một trong các ký tự “H”, “T” hoặc “K” và có tối đa 15 kí tự.
select * from nhan_vien nv where (SUBSTRING_INDEX(nv.ho_ten, ' ', -1) like 'h%' 
or SUBSTRING_INDEX(nv.ho_ten, ' ', -1) like 't%' or SUBSTRING_INDEX(nv.ho_ten, ' ', -1) like 'k%') 
and char_length(SUBSTRING_INDEX(nv.ho_ten, ' ', -1)) <= 15;

-- 3.Hiển thị thông tin của tất cả khách hàng có độ tuổi từ 18 đến 50 tuổi và có địa chỉ ở “Đà Nẵng” hoặc “Quảng Trị”.
select * from khach_hang where ((YEAR(curdate()) - YEAR(ngay_sinh) - (RIGHT(curdate(), 5) < RIGHT(ngay_sinh, 5))) 
between 18 and 50) and (dia_chi like'% Đà Nẵng' or dia_chi like '% Quảng Trị');

-- 4.Đếm xem tương ứng với mỗi khách hàng đã từng đặt phòng bao nhiêu lần. Kết quả hiển thị được sắp xếp tăng dần theo số lần đặt phòng của khách hàng. Chỉ đếm những khách hàng nào có Tên loại khách hàng là “Diamond”.
select kh.ma_khach_hang,kh.ho_ten,count(ma_hop_dong) as so_lan_dat_phong from hop_dong hd 
join khach_hang kh on hd.ma_khach_hang = kh.ma_khach_hang 
join loai_khach lk on kh.ma_loai_khach = lk.ma_loai_khach 
where lk.ten_loai_khach = 'Diamond' group by kh.ma_khach_hang order by count(ma_hop_dong);

-- 5.Hiển thị ma_khach_hang, ho_ten, ten_loai_khach, ma_hop_dong, ten_dich_vu, ngay_lam_hop_dong, ngay_ket_thuc, tong_tien (Với tổng tiền được tính theo công thức như sau: Chi Phí Thuê + Số Lượng * Giá, với Số Lượng và Giá là từ bảng dich_vu_di_kem, hop_dong_chi_tiet) cho tất cả các khách hàng đã từng đặt phòng. (những khách hàng nào chưa từng đặt phòng cũng phải hiển thị ra).
select kh.ma_khach_hang, kh.ho_ten, lk.ten_loai_khach, hd.ma_hop_dong, dv.ten_dich_vu, hd.ngay_lam_hop_dong, hd.ngay_ket_thuc, 
  (ifnull(dv.chi_phi_thue, 0)+sum(ifnull(hdct.so_luong, 0)* ifnull(dvdk.gia, 0))) as tong_tien 
from khach_hang kh 
  left join hop_dong hd on kh.ma_khach_hang = hd.ma_khach_hang 
  left join dich_vu dv on hd.ma_dich_vu = dv.ma_dich_vu 
  left join hop_dong_chi_tiet hdct on hd.ma_hop_dong = hdct.ma_hop_dong 
  left join dich_vu_di_kem dvdk on hdct.ma_dich_vu_di_kem = dvdk.ma_dich_vu_di_kem 
  left join loai_khach lk on kh.ma_loai_khach = lk.ma_loai_khach 
group by hd.ma_hop_dong,kh.ma_khach_hang;

  -- 6.	Hiển thị ma_dich_vu, ten_dich_vu, dien_tich, chi_phi_thue, ten_loai_dich_vu của tất cả các loại dịch vụ chưa từng được khách hàng thực hiện đặt từ quý 1 của năm 2021 (Quý 1 là tháng 1, 2, 3).
  select dv.ma_dich_vu,dv.ten_dich_vu,dv.dien_tich,dv.chi_phi_thue,ldv.ten_loai_dich_vu from dich_vu dv 
  left join loai_dich_vu ldv on dv.ma_loai_dich_vu = ldv.ma_loai_dich_vu 
  left join hop_dong hd on dv.ma_dich_vu = hd.ma_dich_vu where hd.ma_dich_vu not in 
  (select hd.ma_dich_vu from hop_dong hd where (year(hd.ngay_lam_hop_dong) = 2021) 
  and (quarter(hd.ngay_lam_hop_dong) = 1)) group by dv.ma_dich_vu;
  
  -- 7.	Hiển thị thông tin ma_dich_vu, ten_dich_vu, dien_tich, so_nguoi_toi_da, chi_phi_thue, ten_loai_dich_vu của tất cả các loại dịch vụ đã từng được khách hàng đặt phòng trong năm 2020 nhưng chưa từng được khách hàng đặt phòng trong năm 2021.
  select dv.ma_dich_vu,dv.ten_dich_vu,dv.dien_tich,dv.chi_phi_thue,ldv.ten_loai_dich_vu from dich_vu dv 
  left join loai_dich_vu ldv on dv.ma_loai_dich_vu = ldv.ma_loai_dich_vu 
  left join hop_dong hd on dv.ma_dich_vu = hd.ma_dich_vu 
  where hd.ma_dich_vu not in 
  (select ma_dich_vu from hop_dong where year(ngay_lam_hop_dong) !=2020 and year(ngay_lam_hop_dong) = 2021) 
  group by hd.ma_dich_vu;
  
  -- 8.	Hiển thị thông tin ho_ten khách hàng có trong hệ thống, với yêu cầu ho_ten không trùng nhau.
  -- 3 cách:
  -- c1
  select ho_ten from khach_hang group by ho_ten having not count(ho_ten)>1;
  -- c2
  select ho_ten from khach_hang a where a.ho_ten not in 
  (select b.ho_ten from khach_hang b where a.ma_khach_hang != b.ma_khach_hang);
  -- c3
  select ho_ten from khach_hang a where not exists 
  (select * from khach_hang b where a.ho_ten = b.ho_ten and a.ma_khach_hang != b.ma_khach_hang);
  
  -- 9.	Thực hiện thống kê doanh thu theo tháng, nghĩa là tương ứng với mỗi tháng trong năm 2021 thì sẽ có bao nhiêu khách hàng thực hiện đặt phòng.
   select month(ngay_lam_hop_dong) as thang_co_don, count(ma_hop_dong) as so_don_dat_hang from hop_dong 
   group by month(ngay_lam_hop_dong) order by month(ngay_lam_hop_dong) ;
   
  -- 10.	Hiển thị thông tin tương ứng với từng hợp đồng thì đã sử dụng bao nhiêu dịch vụ đi kèm. Kết quả hiển thị bao gồm ma_hop_dong, ngay_lam_hop_dong, ngay_ket_thuc, tien_dat_coc, so_luong_dich_vu_di_kem (được tính dựa trên việc sum so_luong ở dich_vu_di_kem).
  select hd.ma_hop_dong,hd.ngay_lam_hop_dong,hd.ngay_ket_thuc,hd.tien_dat_coc,ifnull(sum(hdct.so_luong),0) as so_luong_dich_vu_di_kem 
  from hop_dong hd left join hop_dong_chi_tiet hdct on hd.ma_hop_dong = hdct.ma_hop_dong 
  group by hd.ma_hop_dong order by hd.ma_hop_dong;
  
  -- 11.	Hiển thị thông tin các dịch vụ đi kèm đã được sử dụng bởi những khách hàng có ten_loai_khach là “Diamond” và có dia_chi ở “Vinh” hoặc “Quảng Ngãi”.
  select dvdk.ma_dich_vu_di_kem,dvdk.ten_dich_vu_di_kem from dich_vu_di_kem dvdk 
  join hop_dong_chi_tiet hdct on dvdk.ma_dich_vu_di_kem = hdct.ma_dich_vu_di_kem 
  join hop_dong hd on hd.ma_hop_dong = hdct.ma_hop_dong 
  join khach_hang kh on hd.ma_khach_hang = kh.ma_khach_hang 
  join loai_khach lk on kh.ma_loai_khach = lk.ma_loai_khach 
  where lk.ten_loai_khach = 'Diamond' and (kh.dia_chi like '% Vinh' or kh.dia_chi like '% Quảng Ngãi');
  
  -- 12.	Hiển thị thông tin ma_hop_dong, ho_ten (nhân viên), ho_ten (khách hàng), so_dien_thoai (khách hàng), ten_dich_vu, so_luong_dich_vu_di_kem (được tính dựa trên việc sum so_luong ở dich_vu_di_kem), tien_dat_coc của tất cả các dịch vụ đã từng được khách hàng đặt vào 3 tháng cuối năm 2020 nhưng chưa từng được khách hàng đặt vào 6 tháng đầu năm 2021.
  select hd.ma_hop_dong,nv.ho_ten as ten_nhan_vien,kh.ho_ten as ten_khach_hang,kh.so_dien_thoai,dv.ten_dich_vu,ifnull(sum(hdct.so_luong),0) as so_luong_dich_vu_di_kem, hd.tien_dat_coc from hop_dong hd 
  left join hop_dong_chi_tiet hdct on hd.ma_hop_dong = hdct.ma_hop_dong 
   join nhan_vien nv on hd.ma_nhan_vien = nv.ma_nhan_vien 
   join khach_hang kh on hd.ma_khach_hang = kh.ma_khach_hang 
   join dich_vu dv on hd.ma_dich_vu = dv.ma_dich_vu
  where (quarter(hd.ngay_lam_hop_dong) = 4 and year(hd.ngay_lam_hop_dong) = 2020) 
  and not (quarter(hd.ngay_lam_hop_dong) in (1,2) and year(hd.ngay_lam_hop_dong) = 2021)
  group by hd.ma_hop_dong;
  
  -- 13.	Hiển thị thông tin các Dịch vụ đi kèm được sử dụng nhiều nhất bởi các Khách hàng đã đặt phòng. (Lưu ý là có thể có nhiều dịch vụ có số lần sử dụng nhiều như nhau).
  select dvdk.ma_dich_vu_di_kem,dvdk.ten_dich_vu_di_kem,sum(hdct.so_luong) as tong_so_luong from dich_vu_di_kem dvdk 
  join hop_dong_chi_tiet hdct on dvdk.ma_dich_vu_di_kem = hdct.ma_dich_vu_di_kem group by dvdk.ma_dich_vu_di_kem 
  having tong_so_luong = (select sum(so_luong) from hop_dong_chi_tiet group by ma_dich_vu_di_kem order by sum(so_luong) desc limit 1);
  
  -- 14.	Hiển thị thông tin tất cả các Dịch vụ đi kèm chỉ mới được sử dụng một lần duy nhất. Thông tin hiển thị bao gồm ma_hop_dong, ten_loai_dich_vu, ten_dich_vu_di_kem, so_lan_su_dung (được tính dựa trên việc count các ma_dich_vu_di_kem).
  select hdct.ma_hop_dong,ldv.ten_loai_dich_vu,dvdk.ten_dich_vu_di_kem,count(dvdk.ma_dich_vu_di_kem) as so_lan_su_dung
  from hop_dong_chi_tiet hdct join dich_vu_di_kem dvdk on hdct.ma_dich_vu_di_kem = dvdk.ma_dich_vu_di_kem
  join hop_dong hd on hdct.ma_hop_dong = hd.ma_hop_dong
  join dich_vu dv on hd.ma_dich_vu = dv.ma_dich_vu
  join loai_dich_vu ldv on dv.ma_loai_dich_vu = ldv.ma_loai_dich_vu
  group by dvdk.ma_dich_vu_di_kem having count(dvdk.ma_dich_vu_di_kem) = 1
  order by hd.ma_hop_dong;
  
  -- 15.	Hiển thi thông tin của tất cả nhân viên bao gồm ma_nhan_vien, ho_ten, ten_trinh_do, ten_bo_phan, so_dien_thoai, dia_chi mới chỉ lập được tối đa 3 hợp đồng từ năm 2020 đến 2021.
  select nv.ma_nhan_vien,nv.ho_ten,td.ten_trinh_do,bp.ten_bo_phan, nv.so_dien_thoai,nv.dia_chi from nhan_vien nv 
  join hop_dong hd on nv.ma_nhan_vien = hd.ma_nhan_vien
  join trinh_do td on nv.ma_trinh_do = td.ma_trinh_do
  join bo_phan bp on nv.ma_bo_phan = bp.ma_bo_phan
  where year(hd.ngay_lam_hop_dong) in (2020,2021)
  group by hd.ma_nhan_vien having count(ma_hop_dong)<=3;
  
 -- 16.	Xóa những Nhân viên chưa từng lập được hợp đồng nào từ năm 2019 đến năm 2021. 
set sql_safe_updates = 1;
-- c1:
 delete from nhan_vien where ma_nhan_vien in (select * from(
 select nv.ma_nhan_vien from nhan_vien nv 
 left join hop_dong hd on nv.ma_nhan_vien = hd.ma_nhan_vien 
 where hd.ma_nhan_vien is null) as delete_nhan_vien);
 -- c2:
 delete from nhan_vien where ma_nhan_vien not in 
 (select hd.ma_nhan_vien from hop_dong hd  where year(ngay_lam_hop_dong) in (2020,2021));
 
-- 17.	Cập nhật thông tin những khách hàng có ten_loai_khach từ Platinum lên Diamond, chỉ cập nhật những khách hàng đã từng đặt phòng với Tổng Tiền thanh toán trong năm 2021 là lớn hơn 10.000.000 VNĐ.
set sql_safe_updates = 0;

update khach_hang kh1 join loai_khach lk1 on kh1.ma_loai_khach = lk1.ma_loai_khach set ten_loai_khach = 'Diamond' 
where kh1.ma_khach_hang in (select kh1.ma_khach_hang from(
select kh.ma_khach_hang,(ifnull(dv.chi_phi_thue, 0)+sum(ifnull(hdct.so_luong, 0)* ifnull(dvdk.gia, 0))) 
as tong_tien from khach_hang kh 
join loai_khach lk on kh.ma_loai_khach = lk.ma_loai_khach
join hop_dong hd on kh.ma_khach_hang = hd.ma_khach_hang
join dich_vu dv on hd.ma_dich_vu = dv.ma_dich_vu
join hop_dong_chi_tiet hdct on hd.ma_hop_dong = hdct.ma_hop_dong
join dich_vu_di_kem dvdk on hdct.ma_dich_vu_di_kem = dvdk.ma_dich_vu_di_kem
 where lk.ten_loai_khach = 'Platinium' group by hd.ma_hop_dong
having tong_tien > 1000000) as update_khach_hang);

-- -- 18.	Xóa những khách hàng có hợp đồng trước năm 2021 (chú ý ràng buộc giữa các bảng).
SET FOREIGN_KEY_CHECKS=0;
SET FOREIGN_KEY_CHECKS=1;
-- c1:
delete from khach_hang where ma_khach_hang in (select * from (
select kh.ma_khach_hang from khach_hang kh join hop_dong hd on kh.ma_khach_hang = hd.ma_khach_hang 
where year(hd.ngay_lam_hop_dong) < 2021) as delete_khach_hang);
-- c2:
delete from khach_hang where ma_khach_hang in (
select hd.ma_khach_hang from hop_dong hd
where year(hd.ngay_lam_hop_dong) < 2021);

-- 19.	Cập nhật giá cho các dịch vụ đi kèm được sử dụng trên 10 lần trong năm 2020 lên gấp đôi.
update dich_vu_di_kem set gia = gia*2 where ma_dich_vu_di_kem in (select ma_dich_vu_di_kem from(
select dvdk.*,sum(hdct.so_luong) as tong from hop_dong_chi_tiet hdct 
join dich_vu_di_kem dvdk on hdct.ma_dich_vu_di_kem = dvdk.ma_dich_vu_di_kem 
group by dvdk.ma_dich_vu_di_kem having tong > 10) as update_gia);

update dich_vu_di_kem set gia = gia*2 where ma_dich_vu_di_kem in (
select hdct.ma_dich_vu_di_kem from hop_dong_chi_tiet hdct
group by hdct.ma_dich_vu_di_kem having sum(hdct.so_luong) > 10);

-- 20.	Hiển thị thông tin của tất cả các nhân viên và khách hàng có trong hệ thống, thông tin hiển thị bao gồm id (ma_nhan_vien, ma_khach_hang), ho_ten, email, so_dien_thoai, ngay_sinh, dia_chi.
(select ma_nhan_vien as id,ho_ten,email,so_dien_thoai,ngay_sinh,dia_chi from nhan_vien order by ma_nhan_vien) union all
(select ma_khach_hang,ho_ten,email,so_dien_thoai,ngay_sinh,dia_chi from khach_hang order by ma_khach_hang);

-- 21.	Tạo khung nhìn có tên là v_nhan_vien để lấy được thông tin của tất cả các nhân viên có địa chỉ là “Hải Châu” và đã từng lập hợp đồng cho một hoặc nhiều khách hàng bất kì với ngày lập hợp đồng là “12/12/2019”.

-- 22.	Thông qua khung nhìn v_nhan_vien thực hiện cập nhật địa chỉ thành “Liên Chiểu” đối với tất cả các nhân viên được nhìn thấy bởi khung nhìn này.

insert into nhan_vien(
  ma_nhan_vien, ho_ten, ngay_sinh, so_cmnd, 
  luong, so_dien_thoai, email, dia_chi, 
  ma_vi_tri, ma_trinh_do, ma_bo_phan
) 
values 
  (
    '1', 'Nguyễn Văn An', '1970-11-07', 
    '456231786', '10000000', '0901234121', 
    'annguyen@gmail.com', '295 Nguyễn Tất Thành, Đà Nẵng', 
    '1', '3', '1'
  ), 
  (
    '4', 'Võ Công Toản', '1980-04-04', 
    '123231365', '17000000', '0374443232', 
    'toan0404@gmail.com', '77 Hoàng Diệu, Quảng Trị', 
    '1', '4', '4'
  ), 
  (
    '5', 'Nguyễn Bỉnh Phát', '1999-12-09', 
    '454363232', '6000000', '0902341231', 
    'phatphat@gmail.com', '43 Yên Bái, Đà Nẵng', 
    '2', '1', '1'
  ), 
  (
    '6', 'Khúc Nguyễn An Nghi', '2000-11-08', 
    '964542311', '7000000', '0978653213', 
    'annghi20@gmail.com', '294 Nguyễn Tất Thành, Đà Nẵng', 
    '2', '2', '3'
  ), 
  (
    '8', 'Nguyễn Hà Đông', '1989-09-03', 
    '234414123', '9000000', '0642123111', 
    'donghanguyen@gmail.com', '111 Hùng Vương, Hà Nội', 
    '2', '4', '4'
  ), 
  (
    '9', 'Tòng Hoang', '1982-09-03', 
    '256781231', '6000000', '0245144444', 
    'hoangtong@gmail.com', '213 Hàm Nghi, Đà Nẵng', 
    '2', '4', '4'
  );
  
  insert into khach_hang(
  ma_khach_hang, ho_ten, ngay_sinh, 
  gioi_tinh, so_cmnd, so_dien_thoai, 
  email, dia_chi, ma_loai_khach
) 
values 
  (
    '1', 'Nguyễn Thị Hào', '1970-11-07', 
    0, '643431213', '0945423362', 'thihao07@gmail.com', 
    '23 Nguyễn Hoàng, Đà Nẵng', 
    '5'
  ), 
  (
    '3', 'Trương Đình Nghệ', '1990-02-27', 
    1, '488645199', '0373213122', 'nghenhan2702@gmail.com', 
    'K323/12 Ông Ích Khiêm, Vinh', 
    '1'
  ), 
  (
    '4', 'Dương Văn Quan', '1981-07-08', 
    1, '543432111', '0490039241', 'duongquan@gmail.com', 
    'K453/12 Lê Lợi, Đà Nẵng', 
    '1'
  );