-- CSDL Nhóm 9: Quản lý cửa hàng đồ ăn vặt 

-- I. Tạo Bảng
GO 
-- Bảng 1: khuyến mãi 
CREATE TABLE KhuyenMai(
	maKM VARCHAR(10),
	tenChuongTrinh NVARCHAR(255) NOT NULL,
	ngayBatDau DATE  NOT NULL,
	ngayKetThuc DATE NOT NULL,  
	CONSTRAINT PK_KhuyenMai PRIMARY KEY (maKM)
);
Go
-- Bảng 2: loại sản phẩm 
CREATE TABLE LoaiSanPham(
	maLoaiSanPham CHAR(3),
	tenLoaiSanPham NVARCHAR(50) NOT NULL,
	maKM VARCHAR(10),
	CONSTRAINT PK_LoaiSanPham PRIMARY KEY (maLoaiSanPham),
	CONSTRAINT FK_LoaiSanPham_KM FOREIGN KEY (maKM) REFERENCES KhuyenMai(maKM)
	ON DELETE SET NULL 
	ON UPDATE CASCADE 
);
GO 
-- Bảng 3: nhà cung cấp 
CREATE TABLE NhaCungCap (
    maNCC VARCHAR(10),
    tenNCC NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
	email NVARCHAR(100),
	SDT VARCHAR(50) NOT NULL, 
	CONSTRAINT unique_email UNIQUE (email),
	CONSTRAINT unique_sdt UNIQUE (SDT),
	CONSTRAINT PK_NhaCungCap PRIMARY KEY (maNCC)
);
GO 
-- Bảng 4: sản phẩm 
CREATE TABLE SanPham (
    maSP VARCHAR(20),
    tenSanPham NVARCHAR(100) NOT NULL,
    giaBan DECIMAL(10,2) NOT NULL CHECK (giaBan > 0),
    hanSuDung DATE NOT NULL,
    moTa NVARCHAR(255),
	soLuongSP INT NOT NULL CHECK(soLuongSP > 0),
    maLoaiSanPham CHAR(3),
	CONSTRAINT PK_SanPham PRIMARY KEY (maSP),
    CONSTRAINT FK_SanPham_LSP FOREIGN KEY (maLoaiSanPham) REFERENCES LoaiSanPham(maLoaiSanPham) 
	ON DELETE SET NULL
	ON UPDATE CASCADE 
);
GO
-- Bảng 5: hóa đơn 
CREATE TABLE HoaDon (
    maDon VARCHAR(10),
    ngayDat DATE NOT NULL,
    tongTien DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_HoaDon PRIMARY KEY (maDon)
);
GO
-- Bảng 6: hóa đơn chi tiết 
CREATE TABLE HoaDonChiTiet (
    maSP VARCHAR(20),
    maDon VARCHAR(10),
    soLuongSP INT NOT NULL CHECK (soLuongSP > 0),
    tongTien DECIMAL(10,2) NOT NULL,
    CONSTRAINT PK_HoaDonChiTiet PRIMARY KEY (maSP, maDon),
    CONSTRAINT FK_HoaDonChiTiet_SP FOREIGN KEY (maSP) REFERENCES SanPham(maSP),
    CONSTRAINT FK_HoaDonChiTiet FOREIGN KEY (maDon) REFERENCES HoaDon(maDon)
	ON UPDATE CASCADE 
);
GO
-- Bảng 7: cung cấp 
CREATE TABLE CungCap(
	maSP VARCHAR(20),
	maNCC VARCHAR(10),
	soLuongSP INT check (soLuongSP > 0) NOT NULL,
	CONSTRAINT PK_CungCap_NCC PRIMARY KEY (maSP, maNCC),
	CONSTRAINT FK_CungCap_SP FOREIGN KEY (maSP) REFERENCES SanPham(maSP),
	CONSTRAINT FK_CungCap_NCC FOREIGN KEY (maNCC) REFERENCES NhaCungCap(maNCC)
	ON UPDATE CASCADE 
	ON DELETE CASCADE 
);
GO 
-- Bảng 8: đăng ký 
CREATE TABLE DangKy(
	ID INT IDENTITY(1,1),
	hoTen NVARCHAR(100) NOT NULL,
	SDT VARCHAR(50) NOT NULL,
	email VARCHAR(100),
	gioiTinh NVARCHAR(10) CHECK (gioiTinh = N'Nam' OR gioiTinh = N'Nữ') NOT NULL,
	vaiTro NVARCHAR(20) CHECK (vaiTro = N'Quản Lý' OR vaiTro = N'Nhân Viên') NOT NULL, 
	tenDangNhap VARCHAR(20) NOT NULL,
	matKhau VARCHAR(20) NOT NULL, 
	CONSTRAINT PK_ID PRIMARY KEY (ID)
);

-- II. Tạo Trigger & View
-- TRIGGER
-- 1. Khi thêm một sản phẩm mới sẽ hiện thông báo "Thêm mới sản phẩm thành công "
-- Đối với bảng sản phẩm 
GO
CREATE TRIGGER TRG_CapNhatTrangThaiCuaHangKhiThem_SanPham
ON [dbo].[SanPham]
AFTER INSERT
AS
BEGIN 
    PRINT N'Thêm mới sản phẩm thành công';
END;
-- Đối với bảng nhà cung cấp
GO
CREATE TRIGGER TRG_CapNhatTrangThaiCuaHangKhiThem_NCC 
ON [dbo].[NhaCungCap]
AFTER INSERT
AS
BEGIN 
    PRINT N'Thêm mới nhà cung cấp thành công';
END;
-- Đối với bảng Khuyến mãi 
GO
CREATE TRIGGER TRG_CapNhatTrangThaiCuaHangKhiThem_KM 
ON [dbo].[KhuyenMai]
AFTER INSERT
AS
BEGIN 
    PRINT N'Thêm mới khuyến mãi thành công';
END;
-- Đối với bảng loại sản phẩm 
GO
CREATE TRIGGER TRG_CapNhatTrangThaiCuaHangKhiThem_LSP 
ON [dbo].[LoaiSanPham]
AFTER INSERT
AS
BEGIN 
    PRINT N'Thêm mới loại sản phẩm thành công';
END;
-- 2. Cập Nhật tổng tiền trong hóa đơn chi tiết khi có sự thay đổi về số lượng sản phẩm trong hóa đơn chi tiết 
GO 
CREATE TRIGGER trg_thanhTien
ON [dbo].[HoaDonChiTiet]
AFTER UPDATE, INSERT, DELETE 
AS
BEGIN
    UPDATE hdct
    SET hdct.tongTien = i.soLuongSP * p.giaBan
    FROM [dbo].[HoaDonChiTiet] hdct
    JOIN inserted i ON hdct.maDon = i.maDon AND hdct.maSP = i.maSP
    JOIN [dbo].[SanPham] p ON hdct.maSP = p.maSP;
END;
-- 3. Cập nhật tổng tiền trong hóa đơn khi thành tiền thay đổi giá trị
GO 
CREATE TRIGGER trg_hoaDon
ON [dbo].[HoaDonChiTiet]
AFTER UPDATE, INSERT 
AS
BEGIN
    UPDATE h
    SET tongTien = (
        SELECT SUM(hdct.tongTien)
        FROM [dbo].[HoaDonChiTiet] hdct
        WHERE hdct.maDon = h.maDon
    )
    FROM [dbo].[HoaDon] h
    WHERE h.maDon IN (SELECT DISTINCT maDon FROM inserted);
END;
--4. trigger bắt lỗi trùng khi thêm hoặc cập nhật sản phẩm 
GO 
CREATE TRIGGER trg_BatLoiTrung
ON [dbo].[SanPham]
AFTER INSERT, UPDATE 
AS BEGIN 
	IF EXISTS (SELECT * FROM inserted i WHERE EXISTS (SELECT * FROM [dbo].[SanPham] sp WHERE I.tenSanPham = sp.tenSanPham AND i.maSP <> sp.maSP ))
		BEGIN 
			ROLLBACK;
		END;
	END;
GO 
--5. trigger cập nhật lại số lượng sản phẩm trong cửa hàng nếu nhân viên đã tạo đơn và có số lượng trong hóa đơn chi tiết 
CREATE TRIGGER trg_CapNhatSoLuongSP
ON  [dbo].[HoaDonChiTiet]
AFTER INSERT
AS BEGIN 
	UPDATE SP 
	SET SP.soLuongSP = SP.soLuongSP - i.soLuongSP
	FROM SanPham SP INNER JOIN inserted i ON  SP.maSP = i.maSP; 
END 
GO 
--6. trigger cập nhật lại số lượng sản phẩm trong cửa hàng khi nhân viên sữa số lượng sản phẩm trong chi tiết hóa đơn 
CREATE TRIGGER trg_SuaSanPhamTrongCuaHang
ON [dbo].[HoaDonChiTiet]
AFTER UPDATE 
AS BEGIN 
	UPDATE SP
    SET SP.soLuongSP = SP.soLuongSP + d.soLuongSP - i.soLuongSP
    FROM SanPham SP
    INNER JOIN deleted d ON SP.maSP = d.maSP
    INNER JOIN inserted i ON SP.maSP = i.maSP AND d.maDon = i.maDon;
END 
--7. trigger nhà cung cấp cung cấp sản phẩn đến cho cửa hàng
GO 
CREATE TRIGGER trg_CungCapSanPham
ON [dbo].[HoaDonChiTiet]
AFTER INSERT, UPDATE 
AS BEGIN 
	UPDATE sp 
	SET sp.soLuongSP = sp.soLuongSP + cc.soLuongSP
	FROM SanPham sp JOIN inserted i ON sp.maSP = i.maSP JOIN CungCap cc ON sp.maSP = cc.maSP 
	WHERE sp.soLuongSP < 10
END 
--8. trigger sau khi xóa sản phẩm khỏi hóa đơn chi tiết thì sản phẩm sẽ được hoàn lại cho mục sản phẩm 
GO 
CREATE TRIGGER trg_HoanLaiSanPham 
ON [dbo].[HoaDonChiTiet]
AFTER DELETE 
AS BEGIN 
	UPDATE sp 
	SET sp.soLuongSP = sp.soLuongSP + d.soLuongSP
	FROM SanPham sp JOIN deleted d ON sp.maSP = d.maSP
END 
--9. Cập nhật tổng tiền trong hóa đơn khi thành tiền thay đổi giá trị đối với trường hợp nhân viên hủy món đó 
GO 
CREATE TRIGGER trg_UpdateTTHD 
ON [dbo].[HoaDonChiTiet]
AFTER DELETE 
AS BEGIN
    -- Kiểm tra xem có phải là xóa toàn bộ chi tiết hóa đơn hay không
    IF EXISTS (SELECT 1 FROM deleted WHERE maDon IN (SELECT maDon FROM HoaDonChiTiet))
    BEGIN
        -- Nếu chỉ xóa một món ăn trong hóa đơn
        UPDATE h
        SET tongTien = (
            SELECT SUM(hdct.tongTien)
            FROM [dbo].[HoaDonChiTiet] hdct
            WHERE hdct.maDon = h.maDon
        )
        FROM [dbo].[HoaDon] h
        WHERE h.maDon IN (SELECT DISTINCT maDon FROM deleted);
    END
    -- Nếu xóa toàn bộ chi tiết hóa đơn thì không cần cập nhật
END;
--10. trigger chặn khi nhập sai ngày bắt đầu và ngày kết thúc
GO 
CREATE TRIGGER trg_ChanNhapSaiNgay
ON [dbo].[KhuyenMai] 
INSTEAD OF INSERT 
AS BEGIN 
	IF EXISTS (SELECT 1 FROM inserted WHERE ngayBatDau > ngayKetThuc)
	BEGIN 
		RAISERROR (N'Ngày kết thúc phải sau ngày bắt đầu', 16, 1);
		RETURN 
	END
	INSERT INTO KhuyenMai (MaKM, TenChuongTrinh, ngayBatDau, ngayKetThuc)
	SELECT i.maKM, i.tenChuongTrinh, i.ngayBatDau, i.ngayKetThuc
	FROM inserted i
END 
GO 
-- 11. Trigger chặn khi nhân viên nhập nhiều hơn sản phẩm có trong cửa hàng 
CREATE TRIGGER trgi_ChanNhapNhieu
ON [dbo].[HoaDonChiTiet]
INSTEAD OF INSERT 
AS BEGIN 
	IF EXISTS (SELECT * FROM inserted i JOIN SanPham sp ON i.maSP = sp.maSP WHERE i.soLuongSP > sp.soLuongSP)
	BEGIN 
		RAISERROR (N'DỮ LIỆU NHẬP VÀO KHÔNG CHÍNH XÁC', 16, 1);
		ROLLBACK TRANSACTION; 
	END 
	INSERT INTO HoaDonChiTiet (maSP, maDon, soLuongSP, tongTien)
	SELECT i.maSP, i.maDon, i.soLuongSP, i.tongTien
	FROM inserted i
END 
		
-- VIEW
-- 1. Xem tổng doanh thu theo ngày của cửa hàng.
GO 
CREATE VIEW DoanhMuc_DoanhThu AS 
SELECT hd.ngayDat, Count(sp.tenSanPham) as SP_Banra, Sum(hd.tongTien) TienThu 
FROM  HoaDonChiTiet ct Join HoaDon hd On ct.maDon = hd.maDon Join SanPham sp On ct.maSP = sp.maSP  
GROUP BY hd.ngayDat
-- 2. Xem một số thông tin cơ bản của sản phẩm
GO
CREATE VIEW DanhMuc_SanPham AS
SELECT sp.tenSanPham, sp.giaBan, sp.hanSuDung, sp.moTa, lsp.tenLoaiSanPham, sp.soLuongSP 
FROM SanPham sp Join LoaiSanPham lsp On sp.maLoaiSanPham = lsp.maLoaiSanPham
-- 3. Xem thông tin liên của nhà cung cấp.
GO 
CREATE VIEW ThongTinNCC AS 
SELECT 
	ncc.tenNCC, ncc.DiaChi, ncc.email, ncc.SDT, sp.tenSanPham, cc.soLuongSP as SoLuongCungCap
FROM CungCap cc JOIN NhaCungCap ncc ON cc.maNCC = ncc.maNCC
JOIN SanPham sp ON cc.maSP = sp.maSP 
-- 4. Xem những sản phẩm đang có chương trình khuyến mãi 
GO 
CREATE VIEW ChuongTrinhKM_SP AS
SELECT sp.tenSanPham, km.tenChuongTrinh, km.ngayBatDau, km.ngayKetThuc, lsp.tenLoaiSanPham 
FROM LoaiSanPham lsp Join SanPham sp On lsp.maLoaiSanPham = sp.maLoaiSanPham 
Join KhuyenMai km On lsp.maKM = km.maKM  
GO 
--5. Xem thông tin tài khoản của nhân viên 
CREATE VIEW View_TaiKhoan AS 
SELECT hoTen, tenDangNhap, matKhau
FROM DangKy
GO 

-- III. CÁC Procedure & Function 
-- Gọi các View và Danh sách
-- 1. Gọi View doanh thu
CREATE PROC proc_DoanhMuc_DoanhThu
AS BEGIN 
	SELECT * FROM DoanhMuc_DoanhThu
END 
GO 
-- 2. Gọi View danh mục sản phẩm 
CREATE PROC proc_DanhMuc_SanPham
AS BEGIN 
	SELECT * FROM DanhMuc_SanPham
END 
GO 
-- 3. Gọi View thông tin nhà cung cấp 
CREATE PROC proc_ThongTinNCC
AS BEGIN 
	SELECT * FROM ThongTinNCC
END 
GO 
-- 4. Gọi View chương trình khuyến mãi 
CREATE PROC proc_ChuongTrinhKM_SP
AS BEGIN 
	SELECT * FROM ChuongTrinhKM_SP
END
GO 
-- 5. Gọi View xem thông tin tài khoản 
CREATE PROC proc_View_TaiKhoan
AS BEGIN 
	SELECT * FROM ChuongTrinhKM_SP
END 
GO 
-- Danh sách các bảng 
-- Bảng sản phẩm 
CREATE PROC proc_ListSanPham 
AS BEGIN 
	SELECT * FROM SanPham
END 
GO
-- Bảng nhà cung cấp
CREATE PROC proc_ListNhaCungCap
AS BEGIN 
	SELECT * FROM NhaCungCap 
END 
GO 
-- Bảng Cung cấp 
CREATE PROC proc_ListCungCap
AS BEGIN 
	SELECT * FROM CungCap
END 
GO 
-- Bảng hóa đơn 
CREATE PROC proc_ListHoaDon
AS BEGIN 
	SELECT * FROM HoaDon
END 
GO 
-- Bảng hóa đơn chi tiết 
CREATE PROC proc_ListHoaDonChiTiet
AS BEGIN 
	SELECT * FROM HoaDonChiTiet
END 
GO 
-- Bảng khuyến mãi 
CREATE PROC proc_ListKhuyenMai
AS BEGIN 
	 SELECT * FROM KhuyenMai
END 
GO 
-- Bảng loại sản phẩm 
CREATE PROC proc_ListLoaiSanPham
AS BEGIN 
	SELECT * FROM LoaiSanPham
END 
GO 
-- Bảng SanPham 
--1. thủ tục thêm sản phẩm (có truyền tham số)
CREATE PROC Them_SanPham
@maSP VARCHAR(20),
@tenSanPham NVARCHAR(100),
@giaBan DECIMAL(10,2),
@hanSuDung DATE,
@moTa NVARCHAR(255),
@soLuongSP INT,
@maLoaiSanPham CHAR(3)
AS BEGIN 
BEGIN TRANSACTION 
	BEGIN TRY 
		-- thêm mới sản phẩm 
		INSERT INTO SanPham(maSP, tenSanPham, giaBan, hanSuDung, moTa, soLuongSP, maLoaiSanPham) 
		VALUES(@maSP, @tenSanPham, @giaBan, @hanSuDung, @moTa, @soLuongSP, @maLoaiSanPham)
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'Lỗi Không thêm được sản phẩm');
	END CATCH 
END;
--2. thủ tục chỉnh sửa (Cập Nhật) sản phẩm theo mã sản phẩm (có truyền tham số)
GO 
CREATE PROC ChinhSua_SanPham
@maSP VARCHAR(20), 
@tenSanPham NVARCHAR(100),
@giaBan DECIMAL(10,2),
@hanSuDung DATE,
@moTa NVARCHAR(255),
@soLuongSP INT,
@maLoaiSanPham CHAR(3)
AS BEGIN 
BEGIN TRANSACTION 
	BEGIN TRY
		UPDATE SanPham
		SET tenSanPham = @tenSanPham,
			giaBan = @giaBan,
			hanSuDung = @hanSuDung,
			moTa = @moTa,
			soLuongSP = @soLuongSP,
			maLoaiSanPham = @maLoaiSanPham
		WHERE maSP = @maSP
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'KHÔNG CẬP NHẬT ĐƯỢC')
	END CATCH 
END;
--3. hàm lấy thông tin một sản phẩm theo mã (hàm trả về một bảng nhưng chỉ có một câu lệnh)
GO 
CREATE FUNCTION Fun_ThongTinSP (@maSP VARCHAR(20)) RETURNS table 
AS 
	return (SELECT * FROM SanPham WHERE maSP = @maSP)
--4. thủ tục lấy danh sách các sản phẩm theo loại (có tham số)
GO
CREATE PROC DsTheoLoai_SanPham
@maLoaiSanPham CHAR(3)
AS BEGIN 
	SELECT * FROM SanPham WHERE maLoaiSanPham = @maLoaiSanPham
END;
--5. thủ tục lấy ra danh sách sản phẩm sắp hết hàng tại cửa hàng (số lượng < 20) (không có tham số)
GO 
CREATE PROC proc_SPhetHang 
AS BEGIN 
SELECT * FROM SanPham WHERE soLuongSP < 20;
END;
GO
--6. thủ tục lấy ra các sản phẩm đã bán tại cửa hàng (không có tham số)
GO
CREATE PROC proc_SPBanNhieuNhat
AS BEGIN 
SELECT sp.maSP, sp.tenSanPham, sp.giaBan, ct.SoLuongMAX FROM SanPham sp Join 
		(SELECT MAX(soLuongSP) as SoLuongMAX, maSP FROM HoaDonChiTiet Group By maSP) as ct
		 On sp.maSP = ct.maSP;
END;
--7. Xóa sản phẩm 
-- 7.1. Hàm lấy mã sản phẩm (trả về một giá trị)
GO
CREATE FUNCTION fun_LayMaSP(@tenSanPham NVARCHAR(100)) 
RETURNS VARCHAR(20)
AS BEGIN 
	DECLARE @MaSP VARCHAR(20)
	SELECT @MaSP = maSP FROM SanPham WHERE tenSanPham = @tenSanPham
	RETURN @MaSP
END 
--7.2. thủ tục xóa sản phẩm (có tham số)
GO 
CREATE PROC proc_XoaSP @tenSanPham NVARCHAR(255)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY
	IF EXISTS (SELECT * FROM SanPham WHERE tenSanPham = @tenSanPham)
	BEGIN 
		DECLARE @maSP VARCHAR(20)
		SET @maSP = dbo.fun_LayMaSP(@tenSanPham)
		-- Xóa sản phẩm trong bảng cung cấp 
		DELETE FROM CungCap WHERE maSP = @maSP
		-- Xóa sản phẩm trong bảng Sản phẩm
		DELETE FROM SanPham WHERE maSP = @maSP
		COMMIT TRANSACTION 
	END 
	ELSE 
	BEGIN 
		ROLLBACK TRANSACTION
		PRINT (N'KHÔNG THỂ XÓA SẢN PHẨM')
	END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ XÓA ĐƯỢC')
	END CATCH 
END
GO
--8. hàm tìm kiếm mã sản phẩm 
CREATE FUNCTION fun_MaSanPham(@tensanpham NVARCHAR(100))
RETURNS VARCHAR(20)
AS BEGIN 
	DECLARE @masp VARCHAR(20)
	SELECT @masp = maSP FROM SanPham WHERE tenSanPham = @tensanpham
	RETURN @masp
END 
GO 
--9. Hàm lấy tên sản phẩm theo mã sản phẩm 
CREATE FUNCTION fun_TenSanPham(@maSP VARCHAR(20))
RETURNS NVARCHAR(100)
AS BEGIN 
	DECLARE @Tensanpham NVARCHAR(100)
	SELECT @Tensanpham = tenSanPham FROM SanPham WHERE maSP = @maSP
	RETURN @Tensanpham
END 
GO 
-- Bảng KhuyenMai 
-- 1. thủ tục Thêm khuyến mãi (có tham số)
CREATE PROCEDURE Them_KhuyenMai
    @maKM VARCHAR(50),
    @tenChuongTrinh NVARCHAR(255),
	@ngayBatDau DATE,
	@ngayKetThuc DATE 
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM KhuyenMai WHERE tenChuongTrinh = @tenChuongTrinh)
		BEGIN 
			INSERT INTO KhuyenMai (MaKM, TenChuongTrinh, ngayBatDau, ngayKetThuc)
			VALUES (@maKM, @tenChuongTrinh, @ngayBatDau, @ngayKetThuc)
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION 
			PRINT (N'CHƯƠNG TRÌNH KHUYẾN MÃI ĐÃ TỒN TẠI')
		END 
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT (N'CHƯƠNG TRÌNH ĐÃ TỒN TẠI')
	END CATCH 
END
GO 
-- 2. thủ tục sửa khuyến mãi (có tham số)
CREATE PROCEDURE Sua_KhuyenMai 
    @maKM VARCHAR(50),
    @tenChuongTrinh NVARCHAR(255),
	@ngayBatDau DATE,
	@ngayKetThuc DATE 
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		UPDATE KhuyenMai
		SET TenChuongTrinh = @tenChuongTrinh,
		ngayBatDau = @ngayBatDau,
		ngayKetThuc = @ngayKetThuc 
		WHERE MaKM = @maKM
		COMMIT TRANSACTION 
	END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI KHÔNG SỮA ĐƯỢC')
	END CATCH 
END
GO 
-- 3. thủ tục xóa khuyến mãi (có tham số)
--3.1. hàm tìm kiếm khuyến mãi (hàm rả về giá trị)
GO 
CREATE FUNCTION fun_LayMaKM (@tenChuongTrinhKM NVARCHAR(255)) 
RETURNS VARCHAR(10)
AS BEGIN 
	DECLARE @MaKM VARCHAR(10)
	SELECT @MaKM =  maKM FROM KhuyenMai WHERE tenChuongTrinh = @tenChuongTrinhKM;

	RETURN @MaKM;
END 
GO 
--3.2. thủ tục xóa khuyến mãi (thủ tục có tham số)
CREATE PROCEDURE Xoa_KhuyenMai @tenChuongTrinhKM NVARCHAR(255) 
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		IF EXISTS (SELECT * FROM KhuyenMai WHERE tenChuongTrinh = @tenChuongTrinhKM)
		BEGIN 
			DECLARE @MaKM VARCHAR(10)
			SET @MaKM = dbo.fun_LayMaKM(@tenChuongTrinhKM)
			DELETE FROM KhuyenMai
			WHERE MaKM = @MaKM
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION
			PRINT (N'KHÔNG TÌM THẤY TÊN CHƯƠNG TRÌNH ĐỂ XÓA')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI KHÔNG XÓA ĐƯỢC')
	END CATCH 
END
GO 
--4. hàm lấy ra tên chương trình khuyến mãi theo mã khuyến mãi 
CREATE FUNCTION fun_TenChuongTrinh(@maKM VARCHAR(10))
RETURNS NVARCHAR(255)
AS BEGIN 
	DECLARE @TenChuongTrinh NVARCHAR(255)
	SELECT @TenChuongTrinh = tenChuongTrinh FROM KhuyenMai WHERE maKM = @maKM
	RETURN @TenChuongTrinh
END 
GO 
--5. hàm lấy ra mã khuyến mãi theo tên chương trình khuyến mãi 
CREATE FUNCTION fun_MaKM(@tenCT NVARCHAR(255))
RETURNS VARCHAR(10)
AS BEGIN 
	DECLARE @maKM VARCHAR(10)
	SELECT @maKM = maKM FROM KhuyenMai WHERE tenChuongTrinh = @tenCT
	RETURN @maKM
END
GO 
-- Bảng LoaiSanPham  
-- 1. thủ tục thêm loại sản phẩm (có tham số)
CREATE PROCEDURE Them_LoaiSanPham
    @maLoaiSanPham VARCHAR(50),
    @tenLoaiSanPham NVARCHAR(255),
    @maKM VARCHAR(50)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM LoaiSanPham WHERE tenLoaiSanPham = @tenLoaiSanPham)
		BEGIN 
			INSERT INTO LoaiSanPham (MaLoaiSanPham, TenLoaiSanPham, MaKM)
			VALUES (@maLoaiSanPham, @tenLoaiSanPham, @maKM)
			COMMIT TRANSACTION
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION
			PRINT (N'LOẠI SẢN PHẨM ĐÃ TỒN TẠI')
		END 
	END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THÊM ĐƯỢC')
	END CATCH 
END
GO 
-- 2. thủ tục sửa loại sản phẩm (có tham số)
CREATE PROCEDURE Sua_LoaiSanPham
    @maLoaiSanPham VARCHAR(50),
    @tenLoaiSanPham NVARCHAR(255),
    @maKM VARCHAR(50)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		UPDATE LoaiSanPham
		SET TenLoaiSanPham = @tenLoaiSanPham, MaKM = @maKM
		WHERE MaLoaiSanPham = @maLoaiSanPham
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI KHÔNG ĐIỀU CHỈNH ĐƯỢC')
	END CATCH 
END
GO 
-- 3. thủ tục xóa loại sản phẩm (có tham số)
--3.1. lấy mã loại sản phẩm 
GO 
CREATE FUNCTION fun_LayMaLSP(@tenLoaiSP NVARCHAR(50)) 
RETURNS CHAR(3)
AS BEGIN 
	DECLARE @MaLSP CHAR(3)
	SELECT @MaLSP = maLoaiSanPham FROM LoaiSanPham WHERE tenLoaiSanPham = @tenLoaiSP
	RETURN @MaLSP
END
--3.2. thủ tục xóa loại sản phẩm 
GO 
CREATE PROC proc_XoaLSP @tenLoaiSP NVARCHAR(50)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY 
		IF EXISTS (SELECT * FROM LoaiSanPham WHERE tenLoaiSanPham  = @tenLoaiSP)
		BEGIN 
			DECLARE @MaLSP CHAR(3)
			SET @MaLSP = dbo.fun_LayMaLSP(@tenLoaiSP)
			DELETE FROM LoaiSanPham WHERE maLoaiSanPham = @MaLSP
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION
			PRINT (N'LOẠI SẢN PHẨM NÀY CHƯA TỒN TẠI TRONG CỬA HÀNG')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI KHÔNG THỂ LOẠI BỎ ')
	END CATCH 
END 
GO 
--4. hàm trả về tên sản phẩm theo mã sản phẩm 
CREATE FUNCTION fun_TenLoaiSanPham(@maLoaiSP NVARCHAR(50))
RETURNS NVARCHAR(50)
AS BEGIN 
	DECLARE @tenLSP NVARCHAR(50)
	SELECT @tenLSP = tenLoaiSanPham FROM LoaiSanPham WHERE maLoaiSanPham = @maLoaiSP
	RETURN @tenLSP
END
GO 
--5. hàm trả về mã sản phẩm theo tên sản phẩm 
CREATE FUNCTION fun_maLSP(@tenLSP NVARCHAR(50))
RETURNS CHAR(3) 
AS BEGIN 
	DECLARE @maLSP CHAR(3)
	SELECT @maLSP = maLoaiSanPham FROM LoaiSanPham WHERE tenLoaiSanPham = @tenLSP
	RETURN @maLSP
END
-- Bảng NhaCungCap
-- 1. thủ tục thêm nhà cung cấp  (có tham số)
GO
CREATE PROCEDURE ThemNhaCungCap
    @maNCC VARCHAR(10),
    @tenNCC NVARCHAR(100),
    @diaChi NVARCHAR(255),
    @email NVARCHAR(100),
    @sdt VARCHAR(50)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		IF NOT EXISTS (SELECT * FROM NhaCungCap WHERE tenNCC = @tenNCC)
		BEGIN 
			INSERT INTO NhaCungCap(maNCC, tenNCC, DiaChi, email, SDT)
			VALUES (@maNCC, @tenNCC, @diaChi, @email, @sdt);
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION
			PRINT (N'NHÀ CUNG CẤP NÀY ĐÃ HỢP TÁC RỒI.')
		END 
	END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ HỢP TÁC ')
	END CATCH 
END;
GO
-- 2. hàm tìm kiếm nhà cung cấp theo tên (có tham số)
CREATE FUNCTION TimKiemNhaCungCap (@tenNCC NVARCHAR(100))
RETURNS TABLE
AS
RETURN
    SELECT * 
    FROM NhaCungCap
    WHERE tenNCC LIKE '%' + @tenNCC + '%';
GO 
-- 3. thủ tục chỉnh sửa nhà cung cấp (có tham số)
CREATE PROCEDURE ChinhSuaNhaCungCap 
    @maNCC VARCHAR(10),
    @tenNCC NVARCHAR(100),
    @diaChi NVARCHAR(255),
    @email NVARCHAR(100),
    @sdt VARCHAR(50)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		UPDATE NhaCungCap
		SET tenNCC = @tenNCC, DiaChi = @diaChi, email = @email, SDT = @sdt
		WHERE maNCC = @maNCC;
		COMMIT TRANSACTION 
	END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'THÔNG TIN KHÔNG ĐƯỢC CẬP NHẬT')
	END CATCH 
END;
GO
-- 4. thủ tục xóa nhà cung cấp (có tham số)
--4.1. hàm lấy mã nhà cung cấp
CREATE FUNCTION fun_LayMaNCC(@tenNCC NVARCHAR(100))
RETURNS VARCHAR(10)
AS BEGIN 
	DECLARE @MaNCC VARCHAR(10)
	SELECT @MaNCC = maNCC FROM NhaCungCap WHERE tenNCC = @tenNCC
	RETURN @MaNCC
END 
--4.2. thủ tục xóa nhà cung cấp
GO 
CREATE PROC proc_XoaNCC @tenNCC NVARCHAR(100)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY 
		IF EXISTS (SELECT * FROM NhaCungCap WHERE tenNCC = @tenNCC)
		BEGIN 
			DECLARE @maNCC VARCHAR(10) 
			SET @maNCC = dbo.fun_LayMaNCC(@tenNCC)
			DELETE FROM NhaCungCap WHERE maNCC = @maNCC
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION 
			PRINT (N'NHÀ CUNG CẤP NÀY CHƯA TỒN TẠI')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI. CHƯA THỂ NGỪNG HỢP TÁC NGAY ĐƯỢC')
	END CATCH 
END 
GO 
-- 5. hàm xuất ra số lượng sản phẩm mà nhà cung cấp đã cung cấp cho cửa hàng 
-- (hàm trả về một bảng nhưng có nhiều câu lệnh)
CREATE FUNCTION SoLuongSPCCTuNCC (@maNCC VARCHAR(10)) 
RETURNS @table table (tenNCC NVARCHAR(100), tenSanPham NVARCHAR(100), soLuongSP INT)
AS BEGIN 
	INSERT @table SELECT ncc.tenNCC, sp.tenSanPham, cc.soLuongSP FROM [dbo].[CungCap] cc Join [dbo].[NhaCungCap] ncc On cc.maNCC = ncc.maNCC
	Join [dbo].[SanPham] sp On cc.maSP = sp.maSP WHERE cc.maNCC = @maNCC
	RETURN 
	END 
GO
--6. hàm lấy thông tin cung cấp của một nhà cung cấp: 
-- (hàm trả về một bảng có nhiều câu lệnh)
CREATE FUNCTION fun_ThongTinNCCSP(@maSP VARCHAR(10))
RETURNS @table table (tenSanPham NVARCHAR(100), tenNCC NVARCHAR(100), diaChi NVARCHAR(255), email NVARCHAR(100), SDT VARCHAR(100), soLuongSP INT)
AS BEGIN 
	INSERT @table SELECT sp.tenSanPham, ncc.tenNCC, ncc.DiaChi, ncc.email, ncc.SDT, cc.soLuongSP 
				  FROM CungCap cc Join SanPham sp ON cc.maSP = sp.maSP Join NhaCungCap ncc ON cc.maNCC = ncc.maNCC
				  WHERE cc.maSP = @maSP
	RETURN 
	END 
GO 
-- 7. thủ tục liên kết sản phẩm với nhà cung cấp
CREATE PROC proc_LienKet 
    @maSP VARCHAR(20),
    @MaNCC VARCHAR(10),
    @soLuong INT 
AS BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Thêm vào bảng CungCap
        INSERT INTO CungCap (maSP, maNCC, soLuongSP)
        VALUES (@maSP, @MaNCC, @soLuong);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        PRINT(N'Lỗi không liên kết được: ' + ERROR_MESSAGE());
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
-- 8. hàm lấy ra mã nhà cung cấp
CREATE FUNCTION fun_MaNhaCungCap(@tenNCC NVARCHAR(100)) RETURNS VARCHAR 
AS BEGIN 
	DECLARE @maNCC VARCHAR(10)
	SELECT @maNCC = maNCC FROM NhaCungCap WHERE tenNCC = @tenNCC
	RETURN @maNCC
END 
GO 
-- Bảng HoaDon 
-- 1. hàm tìm kiếm hóa đơn (trả về một bảng có một câu lệnh)
CREATE FUNCTION TimKiemHoaDon (@maDon VARCHAR(10))
RETURNS TABLE
AS
RETURN
    SELECT *
    FROM HoaDon
    WHERE maDon = @maDon;
GO
-- 2. thủ tục thêm hóa đơn mới (có tham số)
CREATE PROCEDURE themHoaDonMoi 
    @maDon VARCHAR(10),
    @ngayDat DATE,
    @tongTien DECIMAL(10,2)
AS BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO HoaDon (maDon, ngayDat, tongTien)
		VALUES (@maDon, @ngayDat, @tongTien);
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'KHÔNG THỂ LÊN ĐƠN')
	END CATCH 
END;
GO
-- 3. thủ tục chỉnh sửa hóa đơn (có tham số)
CREATE PROCEDURE suaHoaDon
    @maDon VARCHAR(10),
    @ngayDat DATE,
    @tongTien DECIMAL(10,2)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY 
		UPDATE HoaDon
		SET ngayDat = @ngayDat, tongTien = @tongTien
		WHERE maDon = @maDon;
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'KHÔNG THỂ ĐIỀU CHỈNH HÓA ĐƠN')
	END CATCH 
END
GO
-- 4. thủ tục xóa hóa đơn (có tham số)
CREATE PROCEDURE proc_XoaHD
    @maDon VARCHAR(10)
AS BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		IF EXISTS (SELECT * FROM HoaDon WHERE maDon = @maDon)
		BEGIN 
			-- Xóa chi tiết hóa đơn từ bảng HoaDonChiTiet
			DELETE FROM HoaDonChiTiet WHERE maDon = @maDon;
			-- Xóa hóa đơn từ bảng HoaDon
			DELETE FROM HoaDon WHERE maDon = @maDon;
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION
			PRINT (N'KHÔNG THỂ XÓA')
		END 
	END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ LOẠI BỎ HÓA ĐƠN NÀY')
	END CATCH 
END
GO 
-- 5. hàm in thông tin chi tiết hóa đơn (hàm trả về một bảng có nhiều câu lệnh) 
CREATE FUNCTION fun_ChiTietHoaDon (@maDon VARCHAR(10)) 
RETURNS @table table(tenSanPham NVARCHAR(100), soLuongSP INT, giaBan DECIMAL(10,2), tongTien DECIMAL(10,2))
AS BEGIN 
	INSERT @table SELECT sp.tenSanPham, ct.soLuongSP, sp.giaBan, ct.tongTien FROM SanPham sp Join HoaDonChiTiet ct On sp.maSP = ct.maSP WHERE ct.maDon = @maDon
	RETURN 
END 
GO
--6 hàm trả về giá trị tổng cộng trong hóa đơn chi tiết 
CREATE FUNCTION fun_TongCong (@maDon VARCHAR(10))
RETURNS DECIMAL(10,2)
AS BEGIN 
	DECLARE @TongTien DECIMAL(10,2)
	SELECT @TongTien = Sum(tongTien) FROM dbo.fun_ChiTietHoaDon(@maDon)
	RETURN @TongTien
END
GO
--7. Hàm trả về doanh thu của cửa hàng theo sản phẩm 
CREATE FUNCTION fun_DoanhThuTheoSP(@tuNgay DATE, @denNgay DATE)
RETURNS @table table(tenSanPham NVARCHAR(100), giaBan DECIMAL(10, 2), ngayDat DATE, soLuongSP INT, tongTien DECIMAL(10, 2))
AS BEGIN 
	INSERT @table SELECT sp.tenSanPham, sp.giaBan, hd.ngayDat, ct.soLuongSP, ct.tongTien FROM HoaDonChiTiet ct Join SanPham sp On ct.maSP = sp.maSP Join HoaDon hd On ct.maDon = hd.maDon WHERE hd.ngayDat BETWEEN @tuNgay AND @denNgay
	RETURN 
END 
GO
--8. hàm trả về tổng tiền 
CREATE FUNCTION fun_tongTienDT(@tuNgay DATE, @denNgay DATE)
RETURNS DECIMAL(10,2)
AS BEGIN 
	DECLARE @tongTien DECIMAL(10,2 )
	SELECT @tongTien = SUM(tongTien) FROM dbo.fun_DoanhThuTheoSP(@tuNgay, @denNgay)
	RETURN @tongTien
END 
GO 
--Bảng Hóa Đơn Chi Tiết 
--1. thủ tục thêm hóa đơn chi tiết 
CREATE PROC proc_ThemHDChiTiet
	@maSP VARCHAR(20),
	@maDon VARCHAR(10),
	@soLuongSp INT, 
	@thanhTien DECIMAL(10,2)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY
		INSERT INTO HoaDonChiTiet(maSP, maDon, soLuongSP, tongTien)
		VALUES(@maSP, @maDon, @soLuongSp, @thanhTien)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ GỌI MÓN')
	END CATCH 
END 
GO
--2. hàm lấy thông tin chi tiết của một mã hóa đơn 
GO
CREATE FUNCTION fun_LayThongTinChiTietHD(@maHD VARCHAR(10))
RETURNS table 
AS
	RETURN (SELECT * FROM HoaDonChiTiet WHERE maDon = @maHD)
GO
--3. thủ tục xóa hóa đơn chi tiết 
CREATE PROC prox_XoaHDChiTiet
	@maDon VARCHAR(10), @maSP VARCHAR(20)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY
		IF EXISTS (SELECT * FROM HoaDonChiTiet WHERE maDon = @maDon AND maSP = @maSP)
		BEGIN 
			DELETE HoaDonChiTiet WHERE maDon = @maDon AND maSP = @maSP
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION 
			PRINT (N'MÓN ĂN NÀY CHƯA ĐƯỢC GỌI')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ XÓA ĐƯỢC')
	END CATCH 
END 
GO
--4. thủ tục chỉnh sữa hóa đơn chi tiết
CREATE PROC proc_SuaHDChiTiet 
	@maDon VARCHAR(10),
	@maSPCu VARCHAR(20),
	@maSPNew VARCHAR(20),
	@soLuongSP INT,
	@thanhTien DECIMAL(10,2)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY 
		UPDATE HoaDonChiTiet
		SET maSP = @maSPNew,
		soLuongSP = @soLuongSP,
		tongTien = @thanhTien
		WHERE maDon = @maDon AND maSP = @maSPCu
		COMMIT TRANSACTION 
	END TRY 
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG THỂ HỦY YÊU CẦU GỌI MÓN')
	END CATCH 
END 
GO 
-- Bảng Đăng Ký 
--1. Lưu thông tin đăng ký 
CREATE PROC proc_LuuThongTinnDK 
	@hoTen NVARCHAR(100),
	@SDT VARCHAR(50),
	@email VARCHAR(100),
	@gioiTinh NVARCHAR(10),
	@vaiTro NVARCHAR(20),
	@tenDangNhap VARCHAR(20), 
	@matKhau VARCHAR(20)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM DangKy WHERE tenDangNhap = @tenDangNhap)
		BEGIN 
			INSERT INTO DangKy(hoTen, SDT, email, gioiTinh, vaiTro, tenDangNhap, matKhau)
			VALUES (@hoTen, @SDT, @email, @gioiTinh, @vaiTro, @tenDangNhap, @matKhau)
			COMMIT TRANSACTION 
		END 
		ELSE 
		BEGIN 
			ROLLBACK TRANSACTION 
			PRINT (N'NHÂN VIÊN NÀY ĐÃ ĐƯỢC CẤP TÀI KHOẢN RỒI')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		PRINT (N'LỖI KHÔNG CẤP ĐƯỢC TÀI KHOẢN')
	END CATCH 
END 
GO 
--2. Xóa tài khoản 
--2.1. Hàm tìm kiếm mã nhân viên (hàm trả về một giá trị)
CREATE FUNCTION fun_TimKiemID(@hoTen NVARCHAR(100), @SDT VARCHAR(50)) RETURNS INT 
AS BEGIN 
	DECLARE @ID INT 
	SELECT @ID = ID FROM DangKy WHERE hoTen = @hoTen AND SDT = @SDT
	RETURN @ID 		
END 

GO 
--2.2. Hàm xóa tài khoản theo mã nhà cung cấp 
CREATE PROC proc_XoaTaiKhoan
	@hoTen NVARCHAR(100), 
	@SDT VARCHAR(50)
AS BEGIN 
	BEGIN TRANSACTION 
	BEGIN TRY
		IF EXISTS (SELECT * FROM DangKy WHERE hoTen = @hoTen AND SDT = @SDT)
		BEGIN 
			DECLARE @ID INT 
			SET @ID = dbo.fun_TimKiemID(@hoTen, @SDT)
			DELETE FROM DangKy WHERE ID = @ID 
			COMMIT TRANSACTION 
		END 
		ELSE
		BEGIN 
			ROLLBACK TRANSACTION 
			PRINT (N'TÀI KHỎA KHÔNG TỒN TẠI')
		END 
	END TRY
	BEGIN CATCH 
		ROLLBACK TRANSACTION 
		PRINT (N'LỖI KHÔNG ĐỂ HỦY TÀI KHOẢN NÀY')
	END CATCH 
END 
--3. Hàm xem thông tin nhân viên trong cửa hàng (hàm trả về một bảng chỉ với một dòng lệnh)
GO
CREATE FUNCTION fun_XemTK(@hoTen NVARCHAR(100), @SDT VARCHAR(50)) RETURNS TABLE 
AS 
	RETURN (SELECT * FROM DangKy WHERE hoTen = @hoTen AND SDT = @SDT);
GO 

-- IV. tạo user và gán quyền 
-- 1. Đối với người quản lý có toàn quyền trên đó
-- người quản trị cấp tài khoản cho người quản lý 
INSERT INTO DangKy(hoTen, SDT, email, gioiTinh, vaiTro, tenDangNhap, matKhau) 
VALUES (N'Bùi Thị Thu Thảo', '0798555243', 'thuthao@gmail.com', N'Nữ', N'Quản Lý', 'ql_thuThao', '11072005');

-- 2. Đối với nhân viên 
CREATE ROLE NhanVien 
-- gán quyền thực thi trên table 
GRANT SELECT, DELETE, UPDATE, REFERENCES ON dbo.HoaDon TO NhanVien
GRANT SELECT, DELETE, UPDATE, REFERENCES ON dbo.HoaDonChiTiet TO NhanVien
GRANT SELECT, REFERENCES ON dbo.SanPham TO NhanVien
GRANT SELECT, REFERENCES ON dbo.KhuyenMai TO NhanVien
GRANT SELECT, REFERENCES ON dbo.LoaiSanPham TO NhanVien
GRANT SELECT, REFERENCES ON dbo.NhaCungCap TO NhanVien
GRANT SELECT, REFERENCES ON dbo.CungCap TO NhanVien
-- gán quyền thực thi các View
GRANT SELECT, REFERENCES ON DoanhMuc_DoanhThu TO NhanVien 
GRANT SELECT, REFERENCES ON DanhMuc_SanPham TO NhanVien
GRANT SELECT, REFERENCES ON ThongTinNCC TO NhanVien
GRANT SELECT, REFERENCES ON ChuongTrinhKM_SP TO NhanVien
-- gán quyền thực thi các FUNCTION và PROCEDURE 
GRANT SELECT TO NhanVien;
GRANT EXECUTE TO NhanVien;
-- không cấp quyền trên các hàm và thủ tục 
DENY EXECUTE ON Them_SanPham TO NhanVien;
DENY EXECUTE ON ChinhSua_SanPham TO NhanVien;
DENY EXECUTE ON proc_XoaSP TO NhanVien;
DENY EXECUTE ON fun_LayMaSP TO NhanVien;
DENY EXECUTE ON Them_KhuyenMai TO NhanVien;
DENY EXECUTE ON Sua_KhuyenMai TO NhanVien;
DENY EXECUTE ON fun_LayMaKM TO NhanVien;
DENY EXECUTE ON Xoa_KhuyenMai TO NhanVien;
DENY EXECUTE ON Them_LoaiSanPham TO NhanVien;
DENY EXECUTE ON Sua_LoaiSanPham TO NhanVien;
DENY EXECUTE ON fun_LayMaLSP TO NhanVien;
DENY EXECUTE ON proc_XoaLSP TO NhanVien;
DENY EXECUTE ON ThemNhaCungCap TO NhanVien;
DENY EXECUTE ON ChinhSuaNhaCungCap TO Nhanvien;
DENY EXECUTE ON fun_LayMaNCC TO NhanVien;
DENY EXECUTE ON proc_XoaNCC TO NhanVien;
DENY EXECUTE ON proc_LuuThongTinnDK TO NhanVien;
DENY EXECUTE ON proc_XoaTaiKhoan TO NhanVien;
DENY EXECUTE ON fun_TimKiemID TO NhanVien;
DENY SELECT ON fun_XemTK TO NhanVien;
DENY EXECUTE ON fun_tongTienDT TO NhanVien;
DENY SELECT ON fun_DoanhThuTheoSP TO NhanVien;

-- 3. Trigger tự động tạo login và user khi thêm dữ liệu vào bảng DangKy
GO
CREATE TRIGGER trg_TaoLoginUser 
ON [dbo].[DangKy]
AFTER INSERT 
AS BEGIN 
	DECLARE @tenDangNhap VARCHAR(20)
	DECLARE @matKhau VARCHAR(20)
	DECLARE @vaiTro NVARCHAR(20)
	
	-- lấy dữ liệu vừa được chèn vào bảng 
	SELECT @tenDangNhap = i.tenDangNhap, @matKhau = i.matKhau, @vaiTro = i.vaiTro FROM inserted i 
	
	-- tạo login 
	DECLARE @stringSQL NVARCHAR(2000)
	SET @stringSQL = 'CREATE LOGIN [' + @tenDangNhap + '] WITH PASSWORD = ''' + @matKhau + ''', CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF';
	EXEC sp_executesql @stringSQL;

	-- tạo user cho loggin vừa tạo 
	SET @stringSQL = 'CREATE USER [' + @tenDangNhap + '] FOR LOGIN [' + @tenDangNhap + ']';
	EXEC sp_executesql @stringSQL;

	-- gán quyền cho user 
	IF @vaiTro = N'Quản Lý'
		SET @stringSQL = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @tenDangNhap +']';
	IF @vaiTro = N'Nhân Viên'
		SET @stringSQL = 'ALTER ROLE NhanVien ADD MEMBER [' + @tenDangNhap +']';
	EXEC sp_executesql @stringSQL;
END;
GO
-- 4. Trigger tự động xóa login và user khi dữ liệu trên bảng DangKy đã bị xóa 
CREATE TRIGGER trg_XoaLogin 
ON [dbo].[DangKy]
AFTER DELETE 
AS BEGIN 
	DECLARE @tenDangNhap VARCHAR(20)
	
	-- lấy dữ liệu vừa được chèn vào bảng 
	SELECT @tenDangNhap = d.tenDangNhap FROM deleted d

	-- kiểm tra và ngắt kết nối người dùng 
	DECLARE @DangNhapID INT 
	SELECT @DangNhapID = SESSION_ID FROM sys.dm_exec_sessions WHERE login_name = @tenDangNhap

	IF @DangNhapID IS NOT NULL 
	BEGIN 
		DECLARE @NgatLogin NVARCHAR(100);
		SET @NgatLogin = 'KILL ' + CAST(@DangNhapID AS NVARCHAR(20));
		EXEC sp_executesql @NgatLogin;
	END 

	-- xóa User và Login 
	DECLARE @stringSQL NVARCHAR(2000)
	SET @stringSQL = 'DROP USER [' + @tenDangNhap + ']';
	EXEC sp_executesql @stringSQL;

	SET @stringSQL = 'DROP LOGIN [' + @tenDangNhap +']';
	EXEC sp_executesql @stringSQL;
END 
GO



-- V. DATA 
--1. SanPham(maSP, tenSanPham, giaBan, hanSuDung, moTa, soluongSP, maLoaiSP)
INSERT INTO  SanPham (maSP, tenSanPham, giaBan, hanSuDung, moTa, soluongSP, maLoaiSanPham) 
VALUES  ('L01BKG001', N'Bánh Kem Gấu Nhân Sữa', 15000, '2025-05-22', N'Bánh gấu võ giòn, nhân sữa thơm ngon', 50, 'L01'),
		('L01BKG002', N'Bánh Kem Gấu Nhân Socola', 15000, '2025-05-22', N'Bánh gấu võ giòn, nhân socola béo ngậy', 50, 'L01'),
		('L01BP003', N'Bánh Pillows Nhân Socola', 18000, '2026-07-11', N'Bánh ngon mê, ăn là tê', 23, 'L01'),
		('L01BP004', N'Bánh Pillows Nhân Khoai Môn', 18000, '2026-07-11', N'Bánh ngon mê, ăn là tê', 50, 'L01'),
		('L05MC001', N'MilosCube', 2000, '2026-09-11', N'Uống là mê, ăn là ghiền', 59, 'L05'),
		('L01BQ005', N'Bánh quy Oreo', 12000, '2026-06-01', N'Bánh quy nhân kem', 30, 'L01'),
		('L02KE001', N'Kẹo dẻo Happy', 5000, '2026-01-01', N'Kẹo dẻo mềm, nhiều hương vị', 70, 'L02'),
		('L02SN002', N'Snack khoai tây Lays', 10000, '2026-06-01', N'Snack khoai tây giòn, nhiều vị', 31, 'L02'),
		('L01BM006', N'Bánh mì baguette', 12000, '2025-03-30', N'Bánh mì baguette thơm ngon', 5, 'L01'),
		('L01BN007', N'Bánh ngọt socola', 10000, '2026-06-01', N'Bánh ngọt nhân socola', 60, 'L01'), 
		('L04NGK001', N'Nước lê tươi', 30000, '2026-03-20', N'冰糖雪梨', 69, 'L04' ), 
		('L04NGK002', N'Nước thạch trái cây JELE', 12000, '2025-11-25', N'VitaminS A.C.E', 27, 'L04'),
		('L03SCU001', N'Sữa chua uống AD WAHAHA', 15000, '2025-10-20', N'AD钙', 10, 'L03'),
		('L03SCU002', N'Sữa chua uống trái cây JILI', 12000, '2025-09-15', N'优酸乳', 21, 'L03'),
		('L04TGN003', N'Trà giải nhiệt NONGFU SPRING - GD đại ngôn', 25000, '2026-01-27', N'茶π', 17, 'L04');
--2. KhuyenMai(maKM, tenChuongTrinh)
INSERT INTO KhuyenMai (maKM, tenChuongTrinh, ngayBatDau, ngayKetThuc)
VALUES  ('KM01', N'Quốc Tế Phụ Nữ Sale 10% cho các loại sữa chua', '2025-03-08', '2025-03-09'),
		('KM02', N'Mua 1 tặng 1', '2025-03-16', '2025-03-31'),
		('KM03', N'Mua 1 Sp giải khát tặng 1 bịch kẹo dẻo Happy', '2025-04-30', '2025-05-02');
--3. LoaiSanPham(maLoaiSP, tenLoaiSP, maKM)
INSERT INTO LoaiSanPham(maLoaiSanPham, tenLoaiSanPham, maKM) 
VALUES  ('L01', N'Các loại bánh', 'KM02' ),
		('L02', N'Snack & Kẹo', 'KM02'),
		('L03', N'Sản phẩm từ sữa', 'KM01'),
		('L04', N'Nước giải khát', 'KM03'),
		('L05', N'Sản phẩm đặc biệt', null);
--4. NhaCungCap(maNCC, tenNCC, diaChi, email, SDT)
INSERT INTO NhaCungCap(maNCC, tenNCC, diaChi, email, SDT) 
VALUES  ('NSX01', N'Công ty Cổ phần Bibica', N'443 Lý Thường Kiệt, Phường 8, Quận Tân Bình, TP. HCM', N'bibica@bibica.com.vn', '02839717920'),
		('NSX02', N'Công ty Cổ phần Orion Vina', N'15 Đường số 10, KCN Sóng Thần 1, Dĩ An, Bình Dương', N'info@orionvina.com', '02743737676'),
		('NSX03', N'Công ty Cổ phần Mondelez Kinh Đô Việt Nam', N'Tầng 12, Tòa nhà Empress Tower, 138-142 Hai Bà Trưng, Phường Đa Kao, Quận 1, TP. Hồ Chí Minh', N'contact@mdlz.com', '02838270468'),
		('NSX04', N'Công ty TNHH Nestlé Việt Nam', N'Số 8, Đường 17A, KCN Biên Hòa 2, Biên Hòa, Đồng Nai', N'info@vn.nestle.com', '02513832218'),
		('NSX05', N'Công ty Cổ phần Bánh kẹo Hải Hà', N'25 Trương Định, Phường Trương Định, Quận Hai Bà Trưng, Hà Nội', N'haiahaco@haiahaco.com.vn', '02438633271'),
		('NSX06', N'Công ty TNHH Bánh Mì Việt', N'123 Lê Văn Sỹ, Phường 13, Quận Phú Nhuận, TP. Hồ Chí Minh', N'info@banhmiviet.com', '02839912345'),
		('NSX07', N'Công ty Cổ phần Thực phẩm Quốc tế', N'321 Lý Thường Kiệt, Phường 15, Quận 11, TP. Hồ Chí Minh', N'contact@thucphamquocte.vn', '02839654321'),
		('NSX08', N'Công ty TNHH Thực phẩm Wahaha', N'29 Đường Xinmin, Hàng Châu, Trung Quốc', N'contact@wahaha.com.cn', '+8657187828888'),
		('NSX09', N'Công ty TNHH Thực phẩm JILI', N'456 Đường DEF, Quận 2, TP. Hồ Chí Minh, Việt Nam', N'contact@jilifoods.vn', '02823456789'),
		('NSX10', N'Công ty TNHH Nước uống Nongfu Spring', N'Nongfu Spring South Road, Thôn Tangxi, Hàng Châu, Trung Quốc', N'contact@nongfuspring.com', N'+8657187688888');

--5. CungCap(maSP, maNCC, soLuongSP)
INSERT INTO CungCap(maSP, maNCC, soLuongSP) 
VALUES	('L01BKG001', 'NSX01', 100),
		('L01BKG002', 'NSX01', 100),
		('L01BP003', 'NSX02', 50),
		('L01BP003', 'NSX03', 50),
		('L01BP004', 'NSX03', 50),
		('L01BP004', 'NSX02', 50),
		('L05MC001', 'NSX04', 60),
		('L01BQ005', 'NSX03', 80),
		('L02KE001', 'NSX05', 50),
		('L02SN002', 'NSX03', 40),
		('L01BM006', 'NSX06', 60),
		('L01BN007', 'NSX02', 60),
		('L04NGK001', 'NSX07', 72),
		('L04NGK002', 'NSX07', 48),
		('L03SCU001', 'NSX08', 36),
		('L03SCU002', 'NSX09', 24),
		('L03SCU002', 'NSX07', 24),
		('L04TGN003', 'NSX10', 60);

--6. HoaDon(maDon, ngayDat, tongTien)
INSERT INTO HoaDon(maDon, ngayDat, tongTien) 
VALUES  ('D001', '2025-02-01', 54000), -- 2 bánh kem gấu nhân sữa (15000 x 2) + 1 bánh quy Oreo (12000 x 1) + 1 nước thạch trái cây JELE (12000 x 1)
        ('D002', '2025-02-03', 50000), -- 2 bánh kem gấu nhân socola (15000 x 2) + 2 kẹo dẻo Happy (5000 x 2) + 1 snack khoai tây Lays (10000 x 1)
        ('D003', '2025-02-05', 66000), -- 2 bánh pillows nhân socola (18000 x 2) + 2 sữa chua uống AD WAHAHA (15000 x 2)
        ('D004', '2025-02-05', 80000), -- 1 bánh pillows nhân khoai môn (18000 x 1) + 1 MiloCube (2000 x 1) + 2 nước lê tươi (30000 x 2)
        ('D005', '2025-02-10', 35000), -- 5 MiloCube (2000 x 5) + 1 trà giải nhiệt NONGFU SPRING (25000 x 1)
        ('D006', '2025-02-12', 46000), -- 2 bánh quy Oreo (12000 x 2) + 1 bánh ngọt socola (10000 x 1) + 1 bánh mì baguette (12000 x 1)
        ('D007', '2025-02-15', 27000), -- 3 kẹo dẻo Happy (5000 x 3) + 1 sữa chua uống trái cây JILI (12000 x 1)
        ('D008', '2025-02-15', 20000), -- 2 snack khoai tây Lays (10000 x 2)
        ('D009', '2025-02-20', 72000), -- 1 bánh mì baguette (12000 x 1) + 2 nước lê tươi (30000 x 2)
        ('D010', '2025-02-22', 42000), -- 3 bánh ngọt socola (10000 x 3) + 1 nước thạch trái cây JELE (12000 x 1)
        ('D011', '2025-02-23', 60000), -- 2 nước lê tươi (30000 x 2)
        ('D012', '2025-02-25', 12000), -- 1 nước thạch trái cây JELE (12000 x 1)
        ('D013', '2025-02-25', 30000), -- 2 sữa chua uống AD WAHAHA (15000 x 2)
        ('D014', '2025-02-26', 12000), -- 1 sữa chua uống trái cây JILI (12000 x 1)
        ('D015', '2025-02-27', 25000), -- 1 trà giải nhiệt NONGFU SPRING (25000 x 1)
        ('D016', '2025-02-28', 36000), -- 2 bánh pillows nhân socola (18000 x 2)
        ('D017', '2025-02-22', 24000), -- 2 bánh quy Oreo (12000 x 2)
        ('D018', '2025-02-28', 15000), -- 3 kẹo dẻo Happy (5000 x 3)
        ('D019', '2025-02-28', 12000), -- 1 bánh mì baguette (12000 x 1)
        ('D020', '2025-02-26', 58000), -- 3 bánh ngọt socola (10000 x 3) + 1 bánh pillows nhân khoai môn (18000 x 1) + 1 snack khoai tây Lays (10000 x 1)
		('D021', '2025-02-02', 16000), -- 2 Miloscube(2000 x 2) + 1 Sữa chua uống trái cây JILI (12000 x 1)
		('D022', '2025-02-05', 15000), -- 1 Sữa chua uống AD WAHAHA (15000 x 1)
		('D023', '2025-02-15', 27000); -- 1 Bánh Kem Gấu Nhân Sữa (15000 x 1) + 1 Nước thạch trái cây JELE (12000 x 1)

--7. HoaDonChiTiet(maSP, maDon, soLuongSP, tongTien)
INSERT INTO HoaDonChiTiet(maSP, maDon, soLuongSP, tongTien)
VALUES	('L01BKG001', 'D001', 2, 30000),
		('L01BQ005', 'D001', 1, 12000),
		('L03SCU002', 'D001', 1, 12000),
		('L01BKG002', 'D002', 2, 15000),
        ('L02KE001', 'D002', 2, 5000),
        ('L02SN002', 'D002', 1, 10000),
        ('L01BP003', 'D003', 2, 18000),
        ('L03SCU001', 'D003', 2, 15000),
        ('L01BP004', 'D004', 1, 18000),
        ('L05MC001', 'D004', 1, 2000),
        ('L04NGK001', 'D004', 2, 30000),
        ('L05MC001', 'D005', 5, 2000),
        ('L04TGN003', 'D005', 1, 25000),
        ('L01BQ005', 'D006', 2, 12000),
        ('L01BN007', 'D006', 1, 10000),
        ('L01BM006', 'D006', 1, 12000),
        ('L02KE001', 'D007', 3, 5000),
        ('L03SCU002', 'D007', 1, 12000),
        ('L02SN002', 'D008', 2, 10000),
        ('L01BM006', 'D009', 1, 12000),
        ('L04NGK001', 'D009', 2, 30000),
        ('L01BN007', 'D010', 3, 10000),
        ('L04NGK002', 'D010', 1, 12000),
        ('L04NGK001', 'D011', 2, 30000),
        ('L04NGK002', 'D012', 1, 12000),
        ('L03SCU001', 'D013', 2, 15000),
        ('L03SCU002', 'D014', 1, 12000),
        ('L04TGN003', 'D015', 1, 25000),
        ('L01BP004', 'D016', 2, 18000),
        ('L01BQ005', 'D017', 2, 12000),
        ('L02KE001', 'D018', 3, 5000),
        ('L01BM006', 'D019', 1, 12000),
        ('L01BN007', 'D020', 3, 10000),
        ('L01BP003', 'D020', 1, 18000),
        ('L02SN002', 'D020', 1, 10000),
		('L05MC001', 'D021', 2, 10000),
		('L03SCU002', 'D021', 1, 12000),
		('L03SCU001', 'D022', 1, 15000),
		('L01BKG001', 'D023', 1, 15000),
		('L04NGK002', 'D023', 1, 12000);



