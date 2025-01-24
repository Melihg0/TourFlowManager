CREATE TABLE tbl_DeletedTours(
   DeletedTourID INT PRIMARY KEY,
   DeletedAt DATETIME NOT NULL DEFAULT GETDATE(),
   TourName nvarchar(30),
   StartPointCityID nvarchar(8) NOT NULL,
   DestinationCityID nvarchar(8) NOT NULL,
   TourTypeID INT NOT NULL,
   GuideID INT NOT NULL,
   StartDate DATE NOT NULL,
   EndDate DATE NOT NULL,
   Price DECIMAL(10,2) NOT NULL,
   MaxParticipants INT NOT NULL
);