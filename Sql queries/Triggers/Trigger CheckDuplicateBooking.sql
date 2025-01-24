CREATE TRIGGER tr_CheckDuplicateBooking
ON tbl_Reservations
AFTER INSERT
AS
BEGIN
    -- Eğer yeni eklenen kayıt, aynı UserID ve TourID ile zaten varsa, hata döndür
    IF EXISTS (
        SELECT 1
        FROM tbl_Reservations r
        INNER JOIN inserted i ON r.TourID = i.TourID AND r.UserID = i.UserID --triger çalıştıgında eklenen veriler otomatik olarak geçici inserted tablosuna eklenir.
    )
    BEGIN
        RAISERROR('Bu tura zaten kayıtlısınız.', 16, 1);
        ROLLBACK TRANSACTION;
      --Rollback transaction ile insert edilen veriyi geri al.
    END
END;
