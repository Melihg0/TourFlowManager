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