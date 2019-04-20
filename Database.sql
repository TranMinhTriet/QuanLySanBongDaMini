use master
Go
if exists (select * from sys.databases where name = 'QLSanBong')
	drop database QLSanBong
Go
create database QLSanBong
Go
use QLSanBong
Go
--Sanbong
--Account
--Bill
--BillInfo
--LoaiThucAn
--Food

CREATE TABLE Account
(
	UserName VARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Person',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type int NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE SanBong
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Category
(
	ID INT IDENTITY PRIMARY KEY,
	LoaiDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	TenThucAn NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	dvt nvarchar(50) not null default N'Chưa đặt tên',
	idCategory int NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	Note nvarchar(100),
	FOREIGN KEY (idCategory) REFERENCES dbo.Category(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETime NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETime,
	idSanBong INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	FOREIGN KEY (idSanBong) REFERENCES dbo.SanBong(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count float NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

insert into SanBong(Name) values(N'Sân 1')
insert into SanBong(Name) values(N'Sân 2')
insert into SanBong(Name) values(N'Sân 3')
insert into SanBong(Name) values(N'Sân 4')
insert into SanBong(Name) values(N'Sân 5')
insert into SanBong(Name) values(N'Sân 6')
Go
insert into Account values('admin',N'Admin','1',1)
insert into Account values('staff',N'Nhân viên','1',0)
Go
insert into Category values(N'Thức uống')
insert into Category values(N'Món ăn')
insert into Category values(N'Loại khác')
Go
insert into Food values(N'Redbull',N'Lon',1,15000,N'Thức uống')
insert into Food values(N'Trà đá',N'Thùng',1,20000,N'Thức uống')
insert into Food values(N'Aquarius',N'Chai',1,15000,N'Thức uống')
insert into Food values(N'C2',N'Chai',1,15000,N'Thức uống')
insert into Food values(N'Cà phê đen đá/nóng',N'Ly',1,15000,N'Thức uống')
insert into Food values(N'Cà phê sữa đá/nóng',N'Ly',1,15000,N'Thức uống')
insert into Food values(N'Coca Cola',N'Chai',1,15000,N'Thức uống')
insert into Food values(N'Cá viên chiên',N'Xiên',2,6000,N'Món ăn')
insert into Food values(N'Xoài lắc',N'Ly',2,15000,N'Món ăn')
insert into Food values(N'Giờ A(7h-16h)',N'Giờ',3,160000,N'Bảng giá giờ')
insert into Food values(N'Giờ B(16h-18h)',N'Giờ',3,220000,N'Bảng giá giờ')
Go

create PROC USP_Login
@userName varchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

create PROC USP_GetSoccerYardList
as 
begin
select * from dbo.SanBong
end
Go

create PROC USP_InsertBill
@idSoccerYard int
as
begin
	insert dbo.Bill(DateCheckIn,DateCheckOut,idSanBong,status)
	values(getdate(),Null,@idSoccerYard,0)
end
go


create PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count float
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount float = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO
insert dbo.Bill(DateCheckIn,DateCheckOut,idSanBong,status) values(getdate(),Null,1,0)
insert dbo.Bill(DateCheckIn,DateCheckOut,idSanBong,status) values(getdate(),Null,2,0)
insert dbo.Bill(DateCheckIn,DateCheckOut,idSanBong,status) values(getdate(),Null,3,0)
insert into BillInfo(idBill,idFood,count) values(1,2,3)
insert into BillInfo(idBill,idFood,count) values(2,2,4)
insert into BillInfo(idBill,idFood,count) values(3,3,5)
Go
select * from Bill
select * from BillInfo
select * from Food
select * from Category
select * from SanBong
Go

select max(id) from dbo.Bill