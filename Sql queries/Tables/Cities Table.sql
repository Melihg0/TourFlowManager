CREATE TABLE tbl_Cities (
    PlateNumber varchar(5) PRIMARY KEY,
    CityName NVARCHAR(100) NOT NULL UNIQUE,
    Country NVARCHAR(100) CONSTRAINT df_Country DEFAULT 'Turkey'
);