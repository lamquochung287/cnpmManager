CREATE DATABASE manageritem_db

CREATE TABLE mathang(
	idmathang varchar(5) primary key not null,
	tenmathang varchar(100) not null,
)

/*table phiếu nhập*/
CREATE TABLE phieunhap(
	idphieunhap varchar(5) primary key not null,
	ngaynhap datetime not null,
)

/*thông tin tất cả sản phẩm đã nhập trong kho dựa vào id phiếu nhập để show chi tiết cho từng phiếu nhập trong phần mềm*/
CREATE TABLE bangnhapkho(
	idmathang varchar(5) not null,
	tenmathang varchar(100) not null,
	ngaynhap datetime not null,
	idphieunhap varchar(5) not null,
	soluong int not null,
	thanhtien int not null,
	tongthanhtien int not null,
)

--Thêm khóa ngoại cho bảng nhập kho
ALTER TABLE bangnhapkho ADD FOREIGN KEY(idmathang) REFERENCES mathang(idmathang)
ALTER TABLE bangnhapkho ADD FOREIGN KEY(idphieunhap) REFERENCES phieunhap(idphieunhap)

/*chứa các phiếu xuất kho click vào 1 phiếu thông qua bảng xuất kho show chi tiết sản phẩm xuất kho của phiếu xuất kho đó*/
CREATE TABLE phieuxuatkho(
	idphieuxuat varchar(5) primary key not null,
	ngayxuatkho datetime not null,
)

/*chứa thông tin chi tiết sản phẩm xuất kho dựa theo id phiếu xuất kho để show chi tiết sản phẩm được xuất kho của phiếu xuất đó*/
CREATE TABLE bangxuatkho(
	idmathang varchar(5) not null,
	tenmathang varchar(100) not null, 
	ngayxuat datetime not null,
	idphieuxuat varchar(5) not null,
	soluong int not null,
	thanhtien int not null,
	tongthanhtien int not null,
	tendaili nvarchar(100) not null,
	tinhtrangdonhang nvarchar(100) not null,
	tinhtrangthanhtoan bit not null,
)

-- Thêm khóa ngoại cho bảng xuất kho
ALTER TABLE bangxuatkho ADD FOREIGN KEY(idmathang) REFERENCES mathang(idmathang)
ALTER TABLE bangxuatkho ADD FOREIGN KEY(idphieuxuat) REFERENCES phieuxuatkho(idphieuxuat)


--Tạo các phiếu nhập kho
INSERT INTO phieunhap VALUES ('H0001','2021/12/28')
INSERT INTO phieunhap VALUES ('H0002','2021/12/28')

--Thêm dòng sản phẩm điện thoại vào bảng mathang
INSERT INTO mathang VALUES('00001',' iphone 6s') -- Giá nhập 1000/1cai, giá bán 1200/cai
INSERT INTO mathang VALUES('00002','iphone 7s') -- Giá nhập2000/1cai, giá bán 2200/cai
INSERT INTO mathang VALUES('00003',' iphone 8s') -- Giá nhập 3000/1cai, giá bán 3200/cai
INSERT INTO mathang VALUES('00004','iphone Xs') -- Giá nhập 4000/1cai, giá bán 4200/cai 
INSERT INTO mathang VALUES('00005',' iphone 6s plus') -- Giá nhập 1500/1cai, giá bán 1700/cai
INSERT INTO mathang VALUES('00006','iphone 7s plus')  -- Giá nhập 2500/1cai, giá bán 2700/cai
INSERT INTO mathang VALUES('00007',' iphone 8s plus') -- Giá nhập 3500/1cai, giá bán 3700/cai

--Thêm thông tin các sản phẩm vào bangnhapkho dựa theo idphieunhap để hiển thị các sản phẩm của phiếu nhập
INSERT INTO bangnhapkho VALUES('00001','iphone 6s','2021/12/28','H0001', 5,1000,5000)
INSERT INTO bangnhapkho VALUES('00002','iphone 7s','2021/12/28','H0001', 2,2000,4000)
INSERT INTO bangnhapkho VALUES('00002','iphone 7s','2021/12/28','H0002', 3,2000,6000)
INSERT INTO bangnhapkho VALUES('00003','iphone 8s','2021/12/28','H0001', 5,3000,15000)
INSERT INTO bangnhapkho VALUES('00004','iphone Xs','2021/12/28','H0001', 1,4000,4000)
INSERT INTO bangnhapkho VALUES('00007','iphone 8s plus','2021/12/28','H0002', 1,3500,3500)


--Tạo phiếu xuất kho
INSERT INTO phieuxuatkho VALUES ('H0001','2021/12/29')
INSERT INTO phieuxuatkho VALUES ('H0002','2021/12/29')
INSERT INTO phieuxuatkho VALUES ('H0003','2021/12/30')

--Thêm thông tin sản phẩm cho bảng xuất kho: idmathang,tenmathang, ngayxuat, idphieuxuat,soluong,
--thanhtien,tongthanhtien,tendaili,tinhtrangdonhang, tinhtrangthanhtoan

INSERT INTO bangxuatkho VALUES('00001','iphone 6s','2021/12/29','H0001',2,1200,2400, N'Công ty A',N'đang vận chuyển',1)
INSERT INTO bangxuatkho VALUES('00002','iphone 7s','2021/12/29','H0001',2,2200,4400, N'Công ty A',N'đang vận chuyển',1)
INSERT INTO bangxuatkho VALUES('00003','iphone 8s','2021/12/29','H0001',2,3200,6400, N'Công ty A',N'đang vận chuyển',1)
INSERT INTO bangxuatkho VALUES('00007','iphone 8s plus','2021/12/29','H0001',3,3700,11100, N'Công ty A',N'đang vận chuyển',1)

INSERT INTO bangxuatkho VALUES('00001','iphone 6s','2021/12/29','H0002',2,1200,2400, N'Công ty B',N'đang đóng gói',1)
INSERT INTO bangxuatkho VALUES('00004','iphone Xs','2021/12/29','H0002',1,4000,4000, N'Công ty B',N'đang đóng gói',1)

INSERT INTO bangxuatkho VALUES('00001','iphone 6s','2021/12/30','H0003',2,1200,2400, N'Công ty C',N'đang vận chuyển',0)
INSERT INTO bangxuatkho VALUES('00002','iphone 7s','2021/12/30','H0003',2,2200,4400, N'Công ty C',N'đang vận chuyển',0)
INSERT INTO bangxuatkho VALUES('00003','iphone 8s','2021/12/30','H0003',2,3200,6400, N'Công ty C',N'đang vận chuyển',0)

SELECT * FROM phieuxuatkho
SELECT * FROM bangxuatkho 
SELECT * FROM mathang
SELECT * FROM phieunhap
SELECT * FROM bangnhapkho where idphieunhap = 'H0003'

SELECT * FROM bangxuatkho

SELECT idmathang, tenmathang,soluong, thanhtien, tongthanhtien FROM bangxuatkho


-- code mẫu thống kê sản phẩm nhập xuất gộp theo tên để hiển thị
	SELECT tenmathang as 'tên mặt hàng', SUM(soluong) as 'số lượng', SUM(tongthanhtien) as 'tổng' FROM bangnhapkho
	WHERE ngaynhap >= '20211128' and ngaynhap <= '20211231' GROUP BY tenmathang

	SELECT * from bangxuatkho WHERE ngayxuat >= '20211229' and ngayxuat <= '20211231'