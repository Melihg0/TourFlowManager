CREATE TRIGGER tr_DeletedUsers 
ON tbl_Users
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
