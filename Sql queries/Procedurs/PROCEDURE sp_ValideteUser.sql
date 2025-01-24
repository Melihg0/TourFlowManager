CREATE PROCEDURE sp_ValidateUser
   @Email nvarchar(50),
   @Password nvarchar(20)
AS
BEGIN
   Select UserID, FirstName, LastName, Email, RoleID, PhoneNumber, UserPassword, BirthDate, CreatedAt
      from tbl_Users Where Email=@Email and UserPassword=@Password
END;
