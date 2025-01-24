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