
create table AdminLog1
(
    [FirmaID] [int] NULL,
	[FirmaAdi] [varchar](50) NULL,
	[YetkiliAdi] [varchar](50) NULL,
	[YetkiliSoyadi] [varchar](50) NULL,
	[Numara] [varchar](11) NULL,
	[YetkiliTC] [varchar](11) NULL,
	[SeferSayisi] [varchar](50) NULL,
	[UcakSayisi] [varchar](50) NULL,
	[MaxYolcuSayisi] [int] NULL,
	[BagajAgirligi] [varchar](50) NULL,
	[logEylem] [varchar](100) NULL,
	[LogZamani] [datetime] NULL
)
ALTER TRIGGER EklediktenSonra on [dbo].[AdmininGörevleri]
for insert
as
	declare @ID int;
	declare @FirmaAdi varchar(50);
	declare @YetkiliAdi varchar(50);
	declare @YetkiliSoyadi varchar(15);
	declare @Numara varchar(max);
	declare @YetkiliTC varchar(11);
	declare @SeferSayisi varchar(50);
	declare @UcakSayisi varchar(50);
	declare @MaxYolcuSayisi int;
	declare @BagajAgirligi varchar(50);
	declare @logeylem varchar(100); 
select @ID=i.FirmaID from inserted i
select @FirmaAdi=i.FirmaAdi from inserted i
select @YetkiliAdi=i.YetkiliAdi from inserted i
select @YetkiliSoyadi=i.YetkiliSoyadi from inserted i
select @Numara=i.Numara from inserted i
select @YetkiliTC=i.YetkiliTC from inserted i
select @SeferSayisi=i.SeferSayisi from inserted i
select @UcakSayisi=i.UcakSayisi from inserted i
select @MaxYolcuSayisi=i.MaxYolcuSayisi from inserted i
select @BagajAgirligi=i.BagajAgirligi from inserted i
set @logeylem='Kayýt Eklendi...'
insert into [dbo].[AdminLog1]
(FirmaID,FirmaAdi,YetkiliAdi,YetkiliSoyadi,Numara,YetkiliTC,SeferSayisi,
UcakSayisi,MaxYolcuSayisi,BagajAgirligi, logEylem,LogZamani)
values(@ID,@FirmaAdi,@YetkiliAdi,@YetkiliSoyadi,@Numara,@YetkiliTC,
@SeferSayisi,@UcakSayisi,@MaxYolcuSayisi,@BagajAgirligi, @logeylem,getdate());
Print 'insert trigger ateþlendi...'
--6.soru--
/*
update KASIYERLER set Soyad='kumbasar' where Ad='nida' 
select * from kasiyerlerLog
select *  from KASIYERLER
*/
create trigger guncellediktensonra on [dbo].[AdmininGörevleri]
fOR update
as
	declare @ID int;
	declare @FirmaAdi varchar(50);
	declare @YetkiliAdi varchar(50);
	declare @YetkiliSoyadi varchar(15);
	declare @Numara varchar(max);
	declare @YetkiliTC varchar(11);
	declare @SeferSayisi varchar(50);
	declare @UcakSayisi varchar(50);
	declare @MaxYolcuSayisi int;
	declare @BagajAgirligi varchar(50);
	declare @logeylem varchar(100); 
	 
select @ID=i.FirmaID from inserted i
select @FirmaAdi=i.FirmaAdi from inserted i
select @YetkiliAdi=i.YetkiliAdi from inserted i
select @YetkiliSoyadi=i.YetkiliSoyadi from inserted i
select @Numara=i.Numara from inserted i
select @YetkiliTC=i.YetkiliTC from inserted i
select @SeferSayisi=i.SeferSayisi from inserted i
select @UcakSayisi=i.UcakSayisi from inserted i
select @MaxYolcuSayisi=i.MaxYolcuSayisi from inserted i
select @BagajAgirligi=i.BagajAgirligi from inserted i

	UPDATE [dbo].[AdmininGörevleri]
   SET [FirmaAdi] = @FirmaAdi
      ,[YetkiliAdi] = @YetkiliAdi
      ,[YetkiliSoyadi] = @YetkiliSoyadi
      ,[Numara] =@Numara
      ,[YetkiliTC] = @YetkiliTC
	  ,SeferSayisi=@SeferSayisi
	  ,UcakSayisi=@UcakSayisi
	  ,MaxYolcuSayisi=@MaxYolcuSayisi
	  , BagajAgirligi=@BagajAgirligi
	  , @logEylem='Kayýt Guncellendi.'
insert into [dbo].[AdminLog1]
	(FirmaID,FirmaAdi,YetkiliAdi,YetkiliSoyadi,Numara,YetkiliTC,SeferSayisi,
UcakSayisi,MaxYolcuSayisi,BagajAgirligi, logEylem,LogZamani)
values(@ID,@FirmaAdi,@YetkiliAdi,@YetkiliSoyadi,@Numara,@YetkiliTC,
@SeferSayisi,@UcakSayisi,@MaxYolcuSayisi,@BagajAgirligi, @logeylem,getdate());
Print 'update trigger ateþlendi...'
--7.soru--
/*
delete KASIYERLER where Ad='ayþe'
select * from kasiyerlerLog
select *  from KASIYERLER
*/
create TRIGGER sildiktensonra on [dbo].[AdmininGörevleri]
AFTER DELETE
as
	declare @ID int;
	declare @FirmaAdi varchar(50);
	declare @YetkiliAdi varchar(50);
	declare @YetkiliSoyadi varchar(15);
	declare @Numara varchar(max);
	declare @YetkiliTC varchar(11);
	declare @SeferSayisi varchar(50);
	declare @UcakSayisi varchar(50);
	declare @MaxYolcuSayisi int;
	declare @BagajAgirligi varchar(50);
	declare @logeylem varchar(100); 
select @ID=d.FirmaID from deleted d
select @FirmaAdi=d.FirmaAdi from deleted d
select @YetkiliAdi=d.YetkiliAdi from deleted d
select @YetkiliSoyadi=d.YetkiliSoyadi from deleted d
select @Numara=d.Numara from deleted d
select @YetkiliTC=d.YetkiliTC from deleted d
select @SeferSayisi=d.SeferSayisi from deleted d
select @UcakSayisi=d.UcakSayisi from deleted d
select @MaxYolcuSayisi=d.MaxYolcuSayisi from deleted d
select @BagajAgirligi=d.BagajAgirligi from deleted d
set @logeylem='Kayýt silindi...'
insert into [dbo].[AdminLog1]
(FirmaID,FirmaAdi,YetkiliAdi,YetkiliSoyadi,Numara,YetkiliTC,SeferSayisi,
UcakSayisi,MaxYolcuSayisi,BagajAgirligi, logEylem,LogZamani)
values(@ID,@FirmaAdi,@YetkiliAdi,@YetkiliSoyadi,@Numara,@YetkiliTC,
@SeferSayisi,@UcakSayisi,@MaxYolcuSayisi,@BagajAgirligi, @logeylem,getdate());
Print 'delete trigger ateþlendi...'
