
IF not exists(select * from sys.columns 
            where Name = N'GIA_VTPT' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI ADD TEN_DON_VI_ANH NVARCHAR(200)
END    

IF not exists(select * from sys.columns 
            where Name = N'TEN_DON_VI_HOA' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI ADD TEN_DON_VI_HOA NVARCHAR(200)
END    

IF exists(select * from sys.columns 
            where Name = N'NGANH_KINH_TE' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI DROP COLUMN NGANH_KINH_TE 
	END

	IF exists(select * from sys.columns 
            where Name = N'THANH_PHAN_KINH_TE' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI DROP COLUMN THANH_PHAN_KINH_TE 
	END

		IF exists(select * from sys.columns 
            where Name = N'TEN_DV_VNI' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI DROP COLUMN TEN_DV_VNI 
	END
	
		IF exists(select * from sys.columns 
            where Name = N'DIEN_THOAI_NOI_BO' and Object_ID = Object_ID(N'DON_VI'))
begin
    ALTER TABLE dbo.DON_VI DROP COLUMN DIEN_THOAI_NOI_BO 
	END
