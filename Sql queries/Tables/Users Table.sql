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