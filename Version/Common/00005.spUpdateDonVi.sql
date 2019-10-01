IF NOT EXISTS ( SELECT  *
                FROM    sys.objects
                WHERE   type = 'P'
                        AND name = 'spUpdateDonVi' )
    EXEC('CREATE PROCEDURE spUpdateDonVi AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE spUpdateDonVi
    @ID_DV BIGINT ,
    @MSDV NVARCHAR(10) , -- MSDV - nvarchar(10)
    @TEN_DON_VI NVARCHAR(200) ,-- TEN_DON_VI - nvarchar(200)
	@TEN_DON_VI_ANH NVARCHAR(200) ,-- TEN_DON_VI - nvarchar(200)
	@TEN_DON_VI_HOA NVARCHAR(200) ,-- TEN_DON_VI - nvarchar(200)
    @TEN_NGAN NVARCHAR(50) , -- TEN_NGAN - nvarchar(50)
    @DIA_CHI NVARCHAR(200) , -- DIA_CHI - nvarchar(200)
    @MAC_DINH BIT , -- MAC_DINH - bit
    @CHU_QUAN NVARCHAR(50) , -- CHU_QUAN - nvarchar(50)
    @DIEN_THOAI NVARCHAR(100) , -- DIEN_THOAI - nvarchar(100)
    @FAX NVARCHAR(50) , -- FAX - nvarchar(50)
    @MS_BHYT NVARCHAR(50) , -- MS_BHYT - nvarchar(50)
    @MS_BHXH NVARCHAR(50) , -- MS_BHXH - nvarchar(50)
    @SO_TAI_KHOAN NVARCHAR(100) , -- SO_TAI_KHOAN - nvarchar(100)
    @TEN_NGAN_HANG NVARCHAR(255) , -- TEN_NGAN_HANG - nvarchar(255)
    @KY_HIEU NVARCHAR(50) , -- KY_HIEU - nvarchar(50)
    @NGUOI_DAI_DIEN NVARCHAR(50) , -- NGUOI_DAI_DIEN - nvarchar(100)
    @CHUC_VU NVARCHAR(100) , -- CHUC_VU - nvarchar(100)
    @SO_HS NVARCHAR(50)  -- SO_HS - nvarchar(50)
AS
    BEGIN
        IF ( @ID_DV = -1 )
            BEGIN
                INSERT  INTO dbo.DON_VI
                        ( MSDV ,
                          TEN_DON_VI ,
						  TEN_DON_VI_ANH,
						  TEN_DON_VI_HOA,
                          TEN_NGAN ,
                          DIA_CHI ,
                          MAC_DINH ,
                          CHU_QUAN ,
                          DIEN_THOAI ,
                          FAX ,
                          MS_BHYT ,
                          MS_BHXH ,
                          SO_TAI_KHOAN ,
                          TEN_NGAN_HANG ,
                          KY_HIEU ,
                          NGUOI_DAI_DIEN ,
                          CHUC_VU ,
                          SO_HS
                        )
                VALUES  ( @MSDV ,
                          @TEN_DON_VI ,
						  @TEN_DON_VI_ANH,
						  @TEN_DON_VI_HOA,
                          @TEN_NGAN ,
                          @DIA_CHI ,
                          @MAC_DINH ,
                          @CHU_QUAN ,
                          @DIEN_THOAI ,
                          @FAX ,
                          @MS_BHYT ,
                          @MS_BHXH ,
                          @SO_TAI_KHOAN ,
                          @TEN_NGAN_HANG ,
                          @KY_HIEU ,
                          @NGUOI_DAI_DIEN ,
                          @CHUC_VU ,
                          @SO_HS
	                    )
            END	
        ELSE
            BEGIN
                UPDATE  dbo.DON_VI
                SET     MSDV = @MSDV ,
                        TEN_DON_VI = @TEN_DON_VI ,
						TEN_DON_VI_ANH = @TEN_DON_VI_ANH ,
						TEN_DON_VI_HOA = @TEN_DON_VI_HOA ,
                        TEN_NGAN = @TEN_NGAN ,
                        DIA_CHI = @DIA_CHI ,
                        MAC_DINH = @MAC_DINH ,
                        CHU_QUAN = @CHU_QUAN ,
                        DIEN_THOAI = @DIEN_THOAI ,
                        FAX = @FAX ,
                        MS_BHYT = @MS_BHYT ,
                        MS_BHXH = @MS_BHXH ,
                        SO_TAI_KHOAN = @SO_TAI_KHOAN ,
                        TEN_NGAN_HANG = @TEN_NGAN_HANG ,
                        KY_HIEU = @KY_HIEU ,
                        NGUOI_DAI_DIEN = @NGUOI_DAI_DIEN ,
                        CHUC_VU = @CHUC_VU ,
                        SO_HS = @SO_HS
                WHERE   ID_DV = @ID_DV
            END	
    END	


