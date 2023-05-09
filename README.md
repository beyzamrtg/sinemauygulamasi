# sinemauygulamasi
proje

Sinema Rezervasyon Programı
Bu program, müşterilerin sinema seanslarında film rezervasyonu yapmasına imkan tanır. Program, Musteri, Rezervasyon, Film ve Seans sınıflarından oluşur.

Kullanım
Programı kullanmak için, proje klasöründe yer alan Program.cs dosyasını açın ve uygulamayı başlatın. Ardından, müşterinin adı soyadı, cinsiyeti, engel durumu, seans, film adı ve bilet adeti gibi bilgileri girmesini sağlayan bir arayüz görüntülenir. Müşteri bilgileri girildikten sonra, rezervasyon bilgileri ekrana yazdırılır.

Sınıflar
musteri
Bu sınıf, müşteriye ait bilgileri içerir. MusteriAdSoyad, Cinsiyet ve EngelDurumu gibi özellikleri gösterir.


rezervasyon
Bu sınıf, müşterinin yaptığı rezervasyonu temsil eder. Musteri sınıfından miras alır ve MusteriAdsoyad, BiletAdeti, KoltukNo, Seans gibi özellikleri gösterir .rezervasyon sınıfı musteri sınıfının özelliklerini almıştır.

Film
Bu sınıf, sinema filmleri hakkında bilgi tutar. FilmAdi, FilmTürü ve VizyonTarihi gibi özellikleri gösterir.

Seans
Bu sınıf, sinema seanslarını temsil eder. Seans suresi, salonNo, film gibi özellikleri gösterir.


Salon
Bu sınıf,sinema salon numaralarını temsil eder. salon adi ve salon kapasitesi gibi özellikleri gösterir.

Program cs.
Program cs. sınıfların altındaki özelliklerin değerlerini girerek Konsole uygulamasında gözükmesini sağlar.Sinema  rezervasyon uygulamasında, Switch kodunu kullanarak belirli filmlerin hangi salonlarda oynayacağına bağlı olarak kullanıcıya hangi salonda kaç kişilik yer olduğunu,adını soyadını,cinsiyetini, bilet adetini,bildirir. While döngüsüylede kişinin engel durumu olup olmadığını sorup, var ise özel yer ayırtılacağı belirtilir.
