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