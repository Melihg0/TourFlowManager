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
