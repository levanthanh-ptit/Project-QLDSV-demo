USE [QLDSV100k]
GO
Declare @temp table(MASV varchar(10));
insert into @temp select distinct top 80000 MASV from DIEMTHI; 
UPDATE DIEMTHI
   SET DIEM = 1
 WHERE MAMH = 'VXL' and exists(select MASV from @temp as temp where DIEMTHI.MASV = temp.MASV);
GO


