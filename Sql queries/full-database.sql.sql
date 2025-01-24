Create Database TourFlowManagerDB

GO

USE TourFlowManagerDB
GO
--1 Role tablosu(Role)
   Create table tbl_Role(
   RoleID int identity(1,1) Primary Key,
   RoleName nvarchar(20) Not Null
);

Go

INSERT INTO tbl_Role(RoleName)
VALUES
('Admin'),('TourGuide'),('Standart');

Go

--2. Kullanıcılar Tablosu (Users)

CREATE TABLE tbl_Users (                                                             
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Email nvarchar(50) UNIQUE NOT NULL ,
    FirstName nvarchar(50) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    PhoneNumber varchar(15) NOT NULL,
    UserPassword nvarchar(20) NOT NULL,
    RoleID INT NOT NULL CONSTRAINT ck_RoleID CHECK (RoleID BETWEEN 1 AND 3),
    BirthDate date NOT NULL,
    CreatedAt DATETIME NOT NULL Constraint df_getdate DEFAULT GETDATE(),
    Constraint ck_Email CHECK (Email LIKE '%_@_%._%'),
    Constraint fk_RoleID FOREIGN KEY(RoleID) REFERENCES tbl_Role(RoleID)  
);

Go

INSERT INTO tbl_Users (Email, FirstName, LastName, PhoneNumber,UserPassword, RoleID, BirthDate)
VALUES 
('melih.asd@hotmail.com','Melih','lala','+905648289546','password0',1,'05.08.1850'),
('ahmet.yilmaz@example.com', 'Ahmet', 'Yılmaz', '+905321234567', 'password1', 1, '1998-05-15'), --2
('azizsancar@hotmail.com', 'Aziz', 'Sancar', '+905349876543', 'password0', 2, '1990-03-22'), --3          
('evliyacelebi@hotmail.com', 'Evliya', 'Çelebi', '+905412345678', 'password0', 3, '1985-12-10'), --4
('fatma.çelik@example.com', 'Fatma', 'Çelik', '+905429876541', 'password4', 3, '1988-07-05'), --5
('ali.karaca@example.com', 'Ali', 'Karaca', '+905551231234', 'password5', 2, '1980-01-25'), --6
('zeynep.öz@example.com', 'Zeynep', 'Öz', '+905337654321', 'password6', 3, '2002-09-15'), --7
('mustafa.erdem@example.com', 'Mustafa', 'Erdem', '+905445678912', 'password7', 3, '1983-11-30'), --8
('elif.sahin@example.com', 'Elif', 'Şahin', '+905347891234', 'password8', 3, '1998-06-21'), --9
('omer.turan@example.com', 'Ömer', 'Turan', '+905343456789', 'password9', 3, '1989-02-12'), --10
('yasemin.balci@example.com', 'Yasemin', 'Balcı', '+905431237654', 'password10', 3, '1991-08-18'), --11
('john.doe@example.com', 'John', 'Doe', '+105499887766', 'securepass1', 3, '1990-04-10'), --12
('emily.clark@example.com', 'Emily', 'Clark', '+105331415926', 'securepass2', 2, '1987-12-01'), --13
('michael.smith@example.com', 'Michael', 'Smith', '+205492345671', 'securepass3', 3, '1992-09-19'), --14
('sophia.williams@example.com', 'Sophia', 'Williams', '+905512435678', 'securepass4', 3, '1985-11-03'), --15
('liam.johnson@example.com', 'Liam', 'Johnson', '+905467654321', 'securepass5', 3, '1994-03-27'), --16
('isabella.brown@example.com', 'Isabella', 'Brown', '+305344321112', 'securepass6', 2, '1997-07-14'), --17
('ethan.miller@example.com', 'Ethan', 'Miller', '+305345678901', 'securepass7', 3, '1988-05-16'), --18
('mia.davis@example.com', 'Mia', 'Davis', '+905453217654', 'securepass8', 3, '1990-06-20'), --19
('ayse.dogan@example.com', 'Ayşe', 'Doğan', '+905469876543', 'password11', 3, '1993-04-15'), --20
('mehmet.kaya@example.com', 'Mehmet', 'Kaya', '+905321237890', 'password12', 3, '1987-10-05'), --21
('canan.uzun@example.com', 'Canan', 'Uzun', '+905551234521', 'password13', 3, '1995-02-28'), --22
('deniz.yildiz@example.com', 'Deniz', 'Yıldız', '+905431287654', 'password14', 3, '1990-12-01'), --23
('arda.celik@example.com', 'Arda', 'Çelik', '+905347651234', 'password15', 3, '1988-08-22'), --24
('buse.turan@example.com', 'Buse', 'Turan', '+905498765432', 'password16', 3, '1996-06-18'), --25
('murat.aydin@example.com', 'Murat', 'Aydın', '+905342345678', 'password17', 3, '1985-11-05'), --26
('selin.yilmaz@example.com', 'Selin', 'Yılmaz', '+905512349876', 'password18', 3, '1999-07-23'), --27
('ozan.demir@example.com', 'Ozan', 'Demir', '+905467894321', 'password19',3,'1991-03-12'), --28
('ipek.kara@example.com', 'İpek', 'Kara', '+905341567892', 'password20', 3, '1992-01-15');

Go

--3. Şehirler Tablosu (Cities)

CREATE TABLE tbl_Cities (
    PlateNumber varchar(5) PRIMARY KEY,
    CityName NVARCHAR(100) NOT NULL UNIQUE,
    Country NVARCHAR(100) CONSTRAINT df_Country DEFAULT 'Turkey'
);

Go

INSERT INTO tbl_Cities (PlateNumber, CityName)
VALUES
('01', 'Adana'),('02', 'Adıyaman'),('03', 'Afyon'),('04', 'Ağrı'),('05', 'Amasya'),('06', 'Ankara'),
('07', 'Antalya'),('08', 'Artvin'),('09', 'Aydın'),('10', 'Balıkesir'),('11', 'Bilecik'),('12', 'Bingöl'),
('13', 'Bitlis'),('14', 'Bolu'),('15', 'Burdur'),('16', 'Bursa'),('17', 'Çanakkale'),('18', 'Çankırı'),
('19', 'Çorum'),('20', 'Denizli'),('21', 'Diyarbakır'),('22', 'Edirne'),('23', 'Elazığ'),('24', 'Erzincan'),
('25', 'Erzurum'),('26', 'Eskişehir'),('27', 'Gaziantep'),('28', 'Giresun'),('29', 'Gümüşhane'),('30', 'Hakkari'),
('31', 'Hatay'),('32', 'Isparta'),('33', 'Mersin'),('34', 'İstanbul'),('35', 'İzmir'),('36', 'Kars'),
('37', 'Kastamonu'),('38', 'Kayseri'),('39', 'Kırklareli'),('40', 'Kırşehir'),('41', 'Kocaeli'),('42', 'Konya'),
('43', 'Kütahya'),('44', 'Malatya'),('45', 'Manisa'),('46', 'Kahramanmaraş'),('47', 'Mardin'),('48', 'Muğla'),
('49', 'Muş'),('50', 'Nevşehir'),('51', 'Niğde'),('52', 'Ordu'),('53', 'Rize'),('54', 'Sakarya'),('55', 'Samsun'),
('56', 'Siirt'),('57', 'Sinop'),('58', 'Sivas'),('59', 'Tekirdağ'),('60', 'Tokat'),('61', 'Trabzon'),
('62', 'Tunceli'),('63', 'Şanlıurfa'),('64', 'Uşak'),('65', 'Van'),('66', 'Yozgat'),('67', 'Zonguldak'),
('68', 'Aksaray'),('69', 'Bayburt'),('70', 'Karaman'),('71', 'Kırıkkale'),('72', 'Batman'),('73', 'Şırnak'),
('74', 'Bartın'),('75', 'Ardahan'),('76', 'Iğdır'),('77', 'Yalova'),('78', 'Karabük'),('79', 'Kilis'),('80', 'Osmaniye'),
('81', 'Düzce');

Go

INSERT INTO tbl_Cities (PlateNumber, CityName, Country)
VALUES
('fr75', 'Paris', 'Fransa'),('de01', 'Berlin', 'Almanya'),('it01', 'Roma', 'İtalya'),
('es28', 'Madrid', 'İspanya'),('uk01', 'Londra', 'Birleşik Krallık'),('us01', 'New York', 'Amerika Birleşik Devletleri'),
('us02', 'Los Angeles', 'Amerika Birleşik Devletleri'),('cn01', 'Pekin', 'Çin'),('jp01', 'Tokyo', 'Japonya'),
('ru77', 'Moskova', 'Rusya');

Go

--4. Tur Türleri Tablosu (TourTypes)

CREATE TABLE tbl_TourTypes (
    TourTypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(255) Default NULL
);

Go

INSERT INTO tbl_TourTypes (TypeName, Description)
VALUES
('Kültür Turu', 'Tarihî ve kültürel zenginliklerin, tarihî yapılar ve müzelerin keşfedildiği, unutulmaz bir deneyim sunan turlar.'),
('Yurtdışı Turları', 'Dünyanın farklı noktalarını keşfetmek isteyenler için özel olarak hazırlanmış, yeni kültürler ve lezzetlerle buluşma fırsatı sunan geziler.'),
('Mavi Yolculuk Turları', 'Denizin eşsiz mavisinde, plajlar ve koylarda keyif dolu anlar yaşayabileceğiniz, lüks yat ve teknelerle yapılan unutulmaz tatiller.'),
('Termal Turlar', 'Sağlık ve huzuru bir arada bulacağınız, termal otellerde konforlu konaklama ile yenilenme fırsatı sunan turlar.'),
('Doğa Turu', 'Doğanın büyüleyici güzelliklerinde yürüyüş, kamp ve doğayla iç içe etkinliklerle dolu bir macera sunan turlar.');

Go

--5. Turlar Tablosu (Tours)

CREATE TABLE tbl_Tours (
    TourID INT IDENTITY(1,1) PRIMARY KEY,
    TourName nvarchar(30),
    StartPointCityID varchar(5) NOT NULL FOREIGN KEY REFERENCES tbl_Cities(PlateNumber),
    DestinationCityID varchar(5) NOT NULL FOREIGN KEY REFERENCES tbl_Cities(PlateNumber),
    TourTypeID INT NOT NULL,
    GuideID INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    MaxParticipants INT NOT NULL,
    
    Constraint ck_MaxParticipants CHECK (MaxParticipants >= 0),
    CONSTRAINT fk_TourType FOREIGN KEY (TourTypeID) REFERENCES tbl_TourTypes(TourTypeID),
    CONSTRAINT fk_GuideID FOREIGN KEY (GuideID) REFERENCES tbl_Users(UserID),
    CONSTRAINT ck_DateRange CHECK (StartDate <= EndDate)
);

Go

INSERT INTO tbl_Tours (TourName, StartPointCityID, DestinationCityID, TourTypeID, GuideID, StartDate, EndDate, Price, MaxParticipants)
VALUES
('Ege Kültür Turu', '06', '35', 1, 3, '2024-04-01', '2024-04-07', 35000.00, 15),
('Akdeniz Mavi Yolculuk', '16', '48', 3, 3, '2024-06-20', '2024-06-27', 70000.00, 12), 
('Pamukkale Termal Turu', '25', '20', 4, 6, '2024-03-01', '2024-03-05', 15000.00, 10), 
('Avrupa Rüyası Paris', '34', 'fr75', 2, 17, '2024-08-01', '2024-08-14', 150000.00, 10), 
('Karadeniz Yaylaları', '35', '61', 5, 6, '2024-07-15', '2024-07-22', 30000.00, 10),  
('Güneydoğu Kültür Turu', '35', '63', 1, 3, '2024-10-01', '2024-10-07', 45000.00, 15), 
('İstanbul Tarih Turu', '26', '34', 1, 6, '2024-11-05', '2024-11-08', 20000.00, 12), 
('Roma Keşif Gezisi', '06', 'it01', 2, 13, '2024-09-10', '2024-09-17', 120000.00, 10), 
('Kapadokya Balon Turu', '35', '50', 5, 6, '2024-05-15', '2024-05-20', 32000.00, 10);

Go

--6. Rezervasyonlar Tablosu (Reservations)

CREATE TABLE tbl_Reservations (
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,
    TourID INT NOT NULL,
    UserID INT NOT NULL,
    ReservationDate DATETIME NOT NULL DEFAULT GETDATE(),
    Constraint fk_TourID FOREIGN KEY (TourID) REFERENCES tbl_Tours(TourID) ON DELETE CASCADE,
    Constraint fk_UserID FOREIGN KEY (UserID) REFERENCES tbl_Users(UserID) ON DELETE CASCADE
);

Go

INSERT INTO tbl_Reservations (TourID, UserID) VALUES
(1, 4),(3, 4), (5, 4),(3, 5),(4, 5),(7, 5),(4, 7),(6, 7),(3, 8),(5, 8),(7, 8),(1, 9),(6, 9),(4, 9),(8, 9),
(7, 10),(1, 11),(3, 11),(1, 12),(5, 12),(3, 14),(1, 15),(5, 16),(7, 16),(3, 18),(6, 18),(1, 19),
(5, 19),(1, 20),(6, 20),(8, 20),(7, 21),(1, 21),(8, 21),(3, 22),(5, 22),(6, 23),(1, 24),(5, 24),(8, 24),(4, 24),
(3, 25),(6, 25),(1, 26),(5, 26),(7, 26),(3, 27),(6, 27),(1, 28),(5, 28),(6, 29),(7, 29);

Go

--7. Silinmiş Kullanıcılar Tablosu (DeletedUsers)

CREATE TABLE tbl_DeletedUsers (
    DeletedUserID INT PRIMARY KEY,
    DeletedAt DATETIME NOT NULL DEFAULT GETDATE(),
    Email nvarchar(50) UNIQUE NOT NULL ,
    FirstName nvarchar(50) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    PhoneNumber varchar(15) NOT NULL,
    DeletedUserPassword nvarchar(20) NOT NULL,
    RoleID int NOT NULL,
    BirthDate date NOT NULL
);

Go

--8. Silinmiş Turlar tablosu (DeletedTours)

CREATE TABLE tbl_DeletedTours(
   DeletedTourID INT PRIMARY KEY,
   DeletedAt DATETIME NOT NULL DEFAULT GETDATE(),
   TourName nvarchar(30),
   StartPointCityID nvarchar(8) NOT NULL,
   DestinationCityID nvarchar(8) NOT NULL,
   TourTypeID INT NOT NULL,
   GuideID INT NOT NULL,
   StartDate DATE NOT NULL,
   EndDate DATE NOT NULL,
   Price DECIMAL(10,2) NOT NULL,
   MaxParticipants INT NOT NULL
);

Go
--DeletedTourstablosu insert islemi
CREATE TRIGGER tr_DeletedTours ON tbl_Tours
    AFTER DELETE
AS
BEGIN
    INSERT INTO tbl_DeletedTours (
        DeletedTourID, 
        DeletedAt, 
        TourName, 
        StartPointCityID, 
        DestinationCityID, 
        TourTypeID, 
        GuideID, 
        StartDate, 
        EndDate, 
        Price, 
        MaxParticipants

    )
    SELECT 
        TourID, 
        GETDATE(), -- Silinme tarihi
        TourName, 
        StartPointCityID, 
        DestinationCityID, 
        TourTypeID, 
        GuideID, 
        StartDate, 
        EndDate, 
        Price, 
        MaxParticipants
    FROM deleted;
END;

GO

--DeletedUsers tablosu insert islemi
CREATE TRIGGER tr_DeletedUsers ON tbl_Users
    AFTER DELETE
AS
BEGIN
    INSERT INTO tbl_DeletedUsers (
        DeletedUserID, 
        DeletedAt, 
        Email, 
        FirstName, 
        LastName, 
        PhoneNumber, 
        DeletedUserPassword, 
        RoleID, 
        BirthDate
    )
    SELECT 
        UserID, 
        GETDATE(), -- Silinme tarihi
        Email, 
        FirstName, 
        LastName, 
        PhoneNumber, 
        UserPassword, 
        RoleID, 
        BirthDate
    FROM deleted;
END;

GO

CREATE TRIGGER tr_CheckDuplicateBooking
ON tbl_Reservations
AFTER INSERT
AS
BEGIN
    -- Eğer yeni eklenen kayıt, aynı UserID ve TourID ile zaten varsa, hata döndür
    IF EXISTS (
        SELECT 1
        FROM tbl_Reservations r
        INNER JOIN inserted i ON r.TourID = i.TourID AND r.UserID = i.UserID --triger çalıştıgında eklenen veriler otomatik olarak geçici inserted tablosuna eklenir.
    )
    BEGIN
        RAISERROR('Bu tura zaten kayıtlısınız.', 16, 1);
        ROLLBACK TRANSACTION;
      --Rollback transaction ile insert edilen veriyi geri al.
    END
END;

GO

--Kullanıcı giris Kontrol

CREATE PROCEDURE sp_ValidateUser
   @Email nvarchar(50),
   @Password nvarchar(20)
AS
BEGIN
   Select UserID, FirstName, LastName, Email, RoleID, PhoneNumber, UserPassword, BirthDate, CreatedAt
      from tbl_Users Where Email=@Email and UserPassword=@Password
END;

GO

CREATE PROCEDURE sp_RegisterUser
  @Name nvarchar(50),
  @Surname nvarchar(50),
  @Email nvarchar(50),
  @PhoneNumber varchar(15),
  @UserPassword nvarchar(20), 
  @RoleID INT , 
  @BirthDate date 
AS
BEGIN
   INSERT INTO tbl_Users(FirstName,LastName,Email,PhoneNumber,UserPassword,RoleID,BirthDate)
	  VALUES(@NAME,@SURNAME,@Email,@PhoneNumber,@UserPassword,@RoleID,@BirthDate) 	
END;

GO

CREATE PROCEDURE sp_GetUserAndRole --Kullanılmıyor.
AS
BEGIN
    SELECT 
        u.UserID AS ID,
        u.Email,
        u.FirstName,
        u.LastName,
        u.PhoneNumber,
        r.RoleName AS Role,
        u.BirthDate,
        u.UserPassword
    FROM 
        tbl_Users u 
    INNER JOIN 
        tbl_Role r ON u.RoleID = r.RoleID;
END;

GO

CREATE PROCEDURE sp_UpdateUser
  @ID INT,
  @Name nvarchar(50),
  @Surname nvarchar(50),
  @Email nvarchar(50),
  @PhoneNumber varchar(15),
  @UserPassword nvarchar(20), 
  @RoleID INT , 
  @BirthDate date 
AS
BEGIN 
   UPDATE tbl_Users set FirstName =@Name, LastName =@Surname, Email=@Email,PhoneNumber=@PhoneNumber,
   RoleID=@RoleID,UserPassword=@UserPassword,BirthDate=@BirthDate 
     WHERE UserID = @ID 
End

GO

CREATE PROCEDURE sp_DeleteUser
   @ID int
AS
BEGIN
   DELETE tbl_Users WHERE UserID =@ID
END;

GO

--Combobox TourGuide Listeleme

CREATE PROCEDURE GetTourGuideNames
AS
BEGIN
    SELECT 
        u.UserID, -- ID değeri
        CONCAT(u.UserID, ' - ', u.FirstName, ' ', u.LastName) AS FullNameWithID -- ID ve ad-soyadı birleştiriyoruz
    FROM 
        tbl_Users u
    INNER JOIN 
        tbl_Role r ON u.RoleID = r.RoleID
    WHERE 
        r.RoleName = 'TourGuide';
END;