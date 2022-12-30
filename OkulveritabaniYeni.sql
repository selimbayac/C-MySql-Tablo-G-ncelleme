create schema okul; 
use okul;
CREATE TABLE ogrenci(
ogrenciID int(10) unsigned auto_increment primary KEY, 
ogrenciad varchar(50) ,
ogrencisoyad varchar(40),
nickname varchar(16),
Age int ,
birday  date    ,
ulke varchar(36),
city varchar(26),
favoriren varchar(30)

); 
create table Ulke(
ulkeID int(10) unsigned auto_increment primary KEY, 
Ulkead varchar(50),
ulkenufus int );

insert into Ulke (Ulkead,ulkenufus) value ("sırbistan",44456415);

create table city(
cityID int(10)unsigned auto_increment primary KEY, 
cityad varchar(30),
citynufus int 
);
insert into city (cityad , citynufus) value ("randomyer" ,23234);

create table renkler (
renkid int(100) unsigned auto_increment primary KEY, 
renkkodu varchar(31),
renk varchar(23));

insert into renkler (renk , renkkodu) value ("fffff","beyaz");
insert into renkler (renk , renkkodu) value ("ffgff","gri");
insert into renkler (renk , renkkodu) value ("00fff","mavi");

insert  into ogrenci (ogrenciad, ogrencisoyad, nickname,Age ,birday,ulke,city,favoriren)
   VALUES("Muhammed","Mehmet","Mami","19",'2004-07-20 19:23:47',"Sırbistan","Sırbikanzula","Çinge pembesi");
   insert  into ogrenci (ogrenciad, ogrencisoyad, nickname,Age ,birday,ulke,city,favoriren)
   VALUES ("Hakan","At","Dızcı_ceza","15",'2016-07-20 ',"ABD","Niggarti","Beyaz");
   insert  into ogrenci (ogrenciad, ogrencisoyad, nickname,Age ,birday,ulke,city,favoriren)
   VALUES ("Burak","Aktaş","Fehmi","18",'2004-07-20 ',"Türkiye","Bolu","Mavi");
   
   
select * from renkler;
select * from ogrenci;
select * from ogrenci , renkler ;
DELETE  from renkler where renkid = 4 ;

DELIMITER //
CREATE TRIGGER bir_urun_silindi BEFORE DELETE
ON urunler
FOR EACH ROW
BEGIN
  INSERT INTO islem(islem_adi) VALUES(CONCAT(OLD.urun_adi, ' silindi.'));
END//
DELIMITER ;
