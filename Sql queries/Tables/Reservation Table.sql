CREATE TABLE tbl_Reservations (
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,
    TourID INT NOT NULL,
    UserID INT NOT NULL,
    ReservationDate DATETIME NOT NULL DEFAULT GETDATE(),
    Constraint fk_TourID FOREIGN KEY (TourID) REFERENCES tbl_Tours(TourID) ON DELETE CASCADE,
    Constraint fk_UserID FOREIGN KEY (UserID) REFERENCES tbl_Users(UserID) ON DELETE CASCADE
);