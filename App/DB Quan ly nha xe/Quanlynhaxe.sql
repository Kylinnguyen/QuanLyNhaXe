CREATE DATABASE Quanlynhaxe
GO

USE Quanlynhaxe
GO

CREATE TABLE Account
(	ID INT IDENTITY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(100),
	TheAddress NVARCHAR(200),
	PhoneNumber VARCHAR(100),
	UserName VARCHAR(100) ,
	ThePassword VARCHAR(100) DEFAULT 9999,
	TheRole NVARCHAR(100),
	PRIMARY KEY(ID)
)
GO



CREATE TABLE Customer
(
	ID INT IDENTITY,
	Name NVARCHAR(100),
	TheAddress NVARCHAR(200),
	PhoneNumber VARCHAR(10),
	Email VARCHAR(100),
	TimeLeave DATE,
	station NVARCHAR(100),
	CMND VARCHAR(20),
	CityLeave NVARCHAR(100),
	cityArrival NVARCHAR(100),
	GiaVe DECIMAL DEFAULT 0,
	TrangThai NVARCHAR(100) DEFAULT N'Chưa thanh toán',
	PRIMARY KEY(ID, CMND)
)
GO

CREATE TABLE Salary
(
	ID INT IDENTITY,
	FirstName NVARCHAR(20),
	LastName NVARCHAR(100),
	PhoneNumber VARCHAR(10),
	TheRole NVARCHAR(100),
	Salary DECIMAL DEFAULT 0,
	IDAccount INT,
	TrangThai NVARCHAR(100) DEFAULT N'Chưa thanh toán',
	PRIMARY KEY(ID),
	FOREIGN KEY(IDAccount) REFERENCES dbo.Account(ID)
)
GO

/*
ALTER PROC addUser
@FirstName NVARCHAR(20),
@LastName NVARCHAR(100),
@TheAddress NVARCHAR(200),
@PhoneNumber VARCHAR(10),
@UserName VARCHAR(100),
@ThePassword VARCHAR(100),
@TheRole NVARCHAR(100)
AS 
	INSERT INTO dbo.Account(FirstName, LastName, TheAddress, PhoneNumber, UserName, ThePassword, TheRole)
	VALUES  (@FirstName,@LastName,@TheAddress,@PhoneNumber,@UserName,@ThePassword,@TheRole)
GO
*/


CREATE PROC proc_Login
@UserName VARCHAR(100),
@ThePassword VARCHAR(100)
AS 
BEGIN 
	SELECT * FROM dbo.Account WHERE UserName = @UserName AND ThePassword = @ThePassword
END 
GO


CREATE PROC proc_UpdateAccount
@FirstName NVARCHAR(20),
@LastName NVARCHAR(100),
@TheAddress NVARCHAR(200),
@PhoneNumber VARCHAR(10),
@UserName VARCHAR(100),
@ThePassword VARCHAR(100),
@NewPassword VARCHAR(100), 
@TheRole NVARCHAR(100)
AS
BEGIN 
	DECLARE @HasRightPassword INT = 1
	SELECT @HasRightPassword = COUNT(*) FROM dbo.Account WHERE UserName = @UserName AND ThePassword = @ThePassword
	IF (@HasRightPassword =1)
	BEGIN 
		IF (@NewPassword = NULL OR @NewPassword = '')
		BEGIN
			UPDATE dbo.Account SET FirstName = @FirstName WHERE UserName = @UserName
		END 
		ELSE 
			UPDATE dbo.Account SET FirstName = @FirstName, ThePassword = @NewPassword WHERE UserName = @UserName  
	END 
END 
GO

/*
-- Gia ve tu tp.hcm di cac tinh khac
INSERT dbo.Giave (ID, Diemdi, DiemDen, GiaVe ) VALUES  (0, N'TP. HCM', N'TP. Đà Lạt', '250000')
GO
INSERT dbo.Giave (ID, Diemdi, DiemDen, GiaVe ) VALUES  (1, N'TP. HCM', N'TP. Nha Trang', '225000')
GO
INSERT dbo.Giave (ID, Diemdi, DiemDen, GiaVe ) VALUES  (2, N'TP. HCM', N'TP. Đà Nẵng', '375000')
GO
INSERT dbo.Giave (ID, Diemdi, DiemDen, GiaVe ) VALUES  (3, N'TP. HCM', N'TP. Huế', '380000')
GO

-- Gia ve tu tp. da lat di cac tinh khac
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 4, N'TP. Đà Lạt', N'TP. HCM', '250000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 5, N'TP. Đà Lạt', N'TP. Nha Trang', '135000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 6, N'TP. Đà Lạt', N'TP. Đà Nẵng', '285000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 7, N'TP. Đà Lạt', N'TP. Huế', '345000')
GO

-- Gia ve tu tp. nha trang di cac tinh khac
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 8, N'TP. Nha Trang', N'TP. HCM', '225000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 9, N'TP. Nha Trang', N'TP. Đà Lạt', '135000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 10, N'TP. Nha Trang', N'TP. Đà Nẵng', '240000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 11, N'TP. Nha Trang', N'TP. Huế', '250000')
GO

-- Gia ve tu tp. đà nẵng di cac tinh khac
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 12, N'TP. Đà Nẵng', N'TP. HCM', '375000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 13, N'TP. Đà Nẵng', N'TP. Đà Lạt', '285000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 14, N'TP. Đà Nẵng', N'TP. Nha Trang',  '240000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 15, N'TP. Đà Nẵng', N'TP. Huế', '80000')


-- Gia ve tu tp. hue di cac tinh khac
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 16, N'TP. Huế', N'TP. HCM', '380000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 17, N'TP. Huế', N'TP. Đà Lạt', '345000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 18, N'TP. Huế', N'TP. Nha Trang',  '250000')
GO
INSERT dbo.Giave ( ID, Diemdi, DiemDen, GiaVe ) VALUES  ( 19, N'TP. Huế', N'TP. Đà Nẵng',  '80000')
go
*/

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Huy' , -- FirstName - nvarchar(20)
          N'Nguyễn Văn Quang' , -- LastName - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0796636330' , -- PhoneNumber - varchar(10)
          'kylin' , -- UserName - varchar(100)
          '123' , -- ThePassword - varchar(100)
          N'Quản lý'  -- TheRole - nvarchar(100)
        )
GO

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Thiên' , -- FirstName - nvarchar(20)
          N'Huỳnh Hữu' , -- LastName - nvarchar(100)
          N'TP. Quy Nhơn' , -- TheAddress - nvarchar(200)
          '0898215088' , -- PhoneNumber - varchar(10)
          'thien' , -- UserName - varchar(100)
          'thien123' , -- ThePassword - varchar(100)
          N'Nhân viên Bán vé'  -- TheRole - nvarchar(100)
        )
GO

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Huy' , -- FirstName - nvarchar(20)
          N'Nguyễn Quốc' , -- LastName - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0899086488' , -- PhoneNumber - varchar(10)
          'huyhuy' , -- UserName - varchar(100)
          'huyhuy123' , -- ThePassword - varchar(100)
          N'Nhân viên Kế toán'  -- TheRole - nvarchar(100)
        )
GO

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Tùng' , -- FirstName - nvarchar(20)
          N'Nguyễn Thanh' , -- LastName - nvarchar(100)
          N'TP. Thái Bình' , -- TheAddress - nvarchar(200)
          '0898218388' , -- PhoneNumber - varchar(10)
          'SonTungMTP' , -- UserName - varchar(100)
          'tung123' , -- ThePassword - varchar(100)
          N'Nhân viên Bán vé'  -- TheRole - nvarchar(100)
        )
GO

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Ly' , -- FirstName - nvarchar(20)
          N'Trần Thị Cẩm' , -- LastName - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898235088' , -- PhoneNumber - varchar(10)
          'camly' , -- UserName - varchar(100)
          'camly123' , -- ThePassword - varchar(100)
          N'Nhân viên Bán vé'  -- TheRole - nvarchar(100)
        )
GO

INSERT dbo.Account
        ( FirstName ,
          LastName ,
          TheAddress ,
          PhoneNumber ,
          UserName ,
          ThePassword ,
          TheRole
        )
VALUES  ( N'Hưng' , -- FirstName - nvarchar(20)
          N'Đàm Vĩnh' , -- LastName - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898235488' , -- PhoneNumber - varchar(10)
          'hung' , -- UserName - varchar(100)
          'hung123' , -- ThePassword - varchar(100)
          N'Nhân viên Kế toán'  -- TheRole - nvarchar(100)
        )

INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Phan Thị Mỹ Tâm' , -- Name - nvarchar(100)
          N'TP. Đà Nẵng' , -- TheAddress - nvarchar(200)
          '0898236088' , -- PhoneNumber - varchar(10)
          'mytamphan@gmail.com' , -- Email - varchar(100)
          '2020/11/04', -- TimeLeave - datetime
          N'Bến xe miền Đông' , -- station - nvarchar(100)
          '192278747' , -- CMND - varchar(20)
          N'TP. HCM' , -- CityLeave - nvarchar(100)
          N'TP. Đà Lạt' , -- cityArrival - nvarchar(100)
          '250000' , -- GiaVe - varchar(1000)
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Bùi Anh Tuấn' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898237188' , -- PhoneNumber - varchar(10)
          'buianhtuan@gmail.com' , -- Email - varchar(100)
          '2020/11/06' , -- TimeLeave - datetime
          N'Bến xe miền Đông' , -- station - nvarchar(100)
          '147278291' , -- CMND - varchar(20)
          N'TP. Nha Trang' , -- CityLeave - nvarchar(100)
          N'TP. Đà Nẵng' , -- cityArrival - nvarchar(100)
          '240000' , -- GiaVe - varchar(1000)
          N'Chưa thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Hồ Ngọc Hà' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898238588' , -- PhoneNumber - varchar(10)
          'haho@gmail.com' , -- Email - varchar(100)
          '2020/11/10' , -- TimeLeave - datetime
          N'Bến xe phía Bắc Nha Trang' , -- station - nvarchar(100)
          '183655291' , -- CMND - varchar(20)
          N'TP. Nha Trang' , -- CityLeave - nvarchar(100)
          N'TP. Đà Nẵng' , -- cityArrival - nvarchar(100)
          '240000' , -- GiaVe - varchar(1000)
          N'Chưa thanh toán'  -- TrangThai - nvarchar(100)
        )
GO


INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Lý Nhã Kỳ' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898242088' , -- PhoneNumber - varchar(10)
          'nhaky@gmail.com' , -- Email - varchar(100)
          '2020/11/12' , -- TimeLeave - datetime
          N'Bến xe phía Bắc Nha Trang' , -- station - nvarchar(100)
          '198376258' , -- CMND - varchar(20)
          N'TP. Nha Trang' , -- CityLeave - nvarchar(100)
          N'TP. Huế' , -- cityArrival - nvarchar(100)
          '250000' , -- GiaVe - varchar(1000)
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO


INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Lê Công Vinh' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898243088' , -- PhoneNumber - varchar(10)
          'congvinh@gmail.com' , -- Email - varchar(100)
          '2020/12/01' , -- TimeLeave - datetime
          N'Bến xe Trung tâm Đà Nẵng' , -- station - nvarchar(100)
          '176253974' , -- CMND - varchar(20)
          N'TP. Đà Nẵng' , -- CityLeave - nvarchar(100)
          N'TP. HCM' , -- cityArrival - nvarchar(100)
          '375000' , -- GiaVe - varchar(1000)
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Trần Thị Thủy Tiên' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898247188' , -- PhoneNumber - varchar(10)
          'thuytien@gmail.com' , -- Email - varchar(100)
          '2020/12/01' , -- TimeLeave - datetime
          N'Bến xe Trung tâm Đà Nẵng' , -- station - nvarchar(100)
          '654827932' , -- CMND - varchar(20)
          N'TP. Đà Nẵng' , -- CityLeave - nvarchar(100)
          N'TP. HCM' , -- cityArrival - nvarchar(100)
          '375000' , -- GiaVe - varchar(1000)
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Customer
        ( Name ,
          TheAddress ,
          PhoneNumber ,
          Email ,
          TimeLeave ,
          station ,
          CMND ,
          CityLeave ,
          cityArrival ,
          GiaVe ,
          TrangThai
        )
VALUES  ( N'Phạm Đan Trường' , -- Name - nvarchar(100)
          N'TP. Hồ Chí Minh' , -- TheAddress - nvarchar(200)
          '0898247388' , -- PhoneNumber - varchar(10)
          'dantruong@gmail.com' , -- Email - varchar(100)
          '2020/12/03' , -- TimeLeave - datetime
          N'Bến xe Liên tỉnh Đà Lạt' , -- station - nvarchar(100)
          '654827932' , -- CMND - varchar(20)
          N'TP. Đà Lạt' , -- CityLeave - nvarchar(100)
          N'TP. Đà Nẵng' , -- cityArrival - nvarchar(100)
          '285000' , -- GiaVe - varchar(1000)
          N'Chưa thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Salary
        ( FirstName ,
          LastName ,
          PhoneNumber ,
          TheRole ,
          Salary ,
          IDAccount ,
          TrangThai
        )
VALUES  ( N'Huy' , -- FirstName - nvarchar(20)
          N'Nguyễn Văn Quang' , -- LastName - nvarchar(100)
          '0796636330' , -- PhoneNumber - varchar(10)
          N'Quản lý' , -- TheRole - nvarchar(100)
          10000000 , -- Salary - decimal
          1 , -- IDAccount - int
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Salary
        ( FirstName ,
          LastName ,
          PhoneNumber ,
          TheRole ,
          Salary ,
          IDAccount ,
          TrangThai
        )
VALUES  ( N'Thiên' , -- FirstName - nvarchar(20)
          N'Huỳnh Hữu' , -- LastName - nvarchar(100)
          '0898215088' , -- PhoneNumber - varchar(10)
          N'Nhân viên Bán vé' , -- TheRole - nvarchar(100)
          8000000 , -- Salary - decimal
          2 , -- IDAccount - int
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Salary
        ( FirstName ,
          LastName ,
          PhoneNumber ,
          TheRole ,
          Salary ,
          IDAccount ,
          TrangThai
        )
VALUES  ( N'Huy' , -- FirstName - nvarchar(20)
          N'Nguyễn Quốc' , -- LastName - nvarchar(100)
          '0899086488' , -- PhoneNumber - varchar(10)
          N'Nhân viên Kế toán' , -- TheRole - nvarchar(100)
          8000000 , -- Salary - decimal
          3 , -- IDAccount - int
          N'Đã thanh toán'  -- TrangThai - nvarchar(100)
        )
GO

INSERT dbo.Salary
        ( FirstName ,
          LastName ,
          PhoneNumber ,
          TheRole ,
          Salary ,
          IDAccount ,
          TrangThai
        )
VALUES  ( N'Tùng' , -- FirstName - nvarchar(20)
          N'Nguyễn Thanh' , -- LastName - nvarchar(100)
          '0898218388' , -- PhoneNumber - varchar(10)
          N'Nhân viên Bán vé' , -- TheRole - nvarchar(100)
          8000000 , -- Salary - decimal
          4 , -- IDAccount - int
          N'Chưa thanh toán'  -- TrangThai - nvarchar(100)
        )        
GO

INSERT dbo.Salary
        ( FirstName ,
          LastName ,
          PhoneNumber ,
          TheRole ,
          Salary ,
          IDAccount ,
          TrangThai
        )
VALUES  ( N'Ly' , -- FirstName - nvarchar(20)
          N'Trần Thị Cẩm' , -- LastName - nvarchar(100)
          '0898235088' , -- PhoneNumber - varchar(10)
          N'Nhân viên Bán vé' , -- TheRole - nvarchar(100)
          8000000 , -- Salary - decimal
          5 , -- IDAccount - int
          N'Chưa thanh toán'  -- TrangThai - nvarchar(100)
        )
GO 

CREATE PROC proc_getListTicketByDate
@startday DATE, @endday DATE
AS
BEGIN 
	SELECT ID, Name AS N'Họ tên', TheAddress AS N'Địa chỉ',
	PhoneNumber AS 'Số điện thoại', Email AS 'Email', TimeLeave AS N'Thời gian xuất bến',
	station AS N'Bến xe', CMND, CityLeave AS N'Điểm đi', 
	cityArrival AS N'Điểm đến', GiaVe AS N'Giá vé', 
	TrangThai AS N'Trạng thái' FROM dbo.Customer 
	WHERE @startday <= TimeLeave AND TimeLeave <= @endday AND TrangThai = N'Đã thanh toán'
END 
GO


CREATE PROC proc_getDoanhThu
@startday DATE, @endday DATE
AS
BEGIN 
	SELECT SUM(GiaVe) AS N'Doanh thu' FROM dbo.Customer 	
	WHERE @startday <= TimeLeave AND TimeLeave <= @endday AND TrangThai = N'Đã thanh toán'
END 
GO



SELECT * FROM dbo.Salary
GO

SELECT * FROM dbo.Customer
GO

SELECT * FROM Account 
GO

