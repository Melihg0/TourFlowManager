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