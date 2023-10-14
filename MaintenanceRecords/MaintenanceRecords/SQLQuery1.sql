-- Delete all records from Records_Tbl
DELETE FROM Records_Tbl;

-- Reseed the OwnerID identity column
DBCC CHECKIDENT ('Records_Tbl', RESEED, 1);

