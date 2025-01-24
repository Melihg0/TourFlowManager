CREATE TABLE tbl_Tours (
    TourID INT IDENTITY(1,1) PRIMARY KEY,
    TourName nvarchar(30),
    StartPointCityID varchar(5) NOT NULL FOREIGN KEY REFERENCES tbl_Cities(PlateNumber),
    DestinationCityID varchar(5) NOT NULL FOREIGN KEY REFERENCES tbl_Cities(PlateNumber),
    TourTypeID INT NOT NULL,
    GuideID INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    MaxParticipants INT NOT NULL,
    
    Constraint ck_MaxParticipants CHECK (MaxParticipants >= 0),
    CONSTRAINT fk_TourType FOREIGN KEY (TourTypeID) REFERENCES tbl_TourTypes(TourTypeID),
    CONSTRAINT fk_GuideID FOREIGN KEY (GuideID) REFERENCES tbl_Users(UserID),
    CONSTRAINT ck_DateRange CHECK (StartDate <= EndDate)
);