CREATE PROCEDURE sp_DeleteUser
   @ID int
AS
BEGIN
   DELETE tbl_Users WHERE UserID =@ID
END;
