CREATE TRIGGER tr_DeletedTours 
ON tbl_Tours
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