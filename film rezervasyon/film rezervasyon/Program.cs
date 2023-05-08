using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace film_rezervasyon
{
    public class Program
    {
        public static string EngelDurumu;
        public static int BiletAdeti;
        public static int alinanbiletler;
        static void Main(string[] arg)
        {
            Film film1 = new Film();
            film1.FilmAdi = "Şimşek Hırsızı";
            film1.FilmTürü = "Fantastik";

            DateTime VizyonTarihi1 = new DateTime(2010, 03, 04);
            Console.WriteLine("1) " + VizyonTarihi1.ToString("dd.MM.yyyy"));


            Film film2 = new Film();
            film2.FilmAdi = "Oyuncaklar";
            film2.FilmTürü = "animasyon";
            DateTime VizyonTarihi2 = new DateTime(2012, 05, 06);
            Console.WriteLine("2) " + VizyonTarihi2.ToString("dd.MM.yyyy"));

            Console.WriteLine("Filmler");
            Console.WriteLine("1.  " + film1.FilmAdi);
            Console.WriteLine("2.    " + film2.FilmAdi);
            Console.WriteLine("Hangi filme bilet almak istiyorsunuz");


            int secilen_film = Convert.ToInt32(Console.ReadLine());
            switch (secilen_film)
            {
                case 1:
                    Console.WriteLine("seçtiğiniz film " + film1.FilmAdi);
                    break;
                case 2:
                    Console.WriteLine("seçtiğiniz film " + film2.FilmAdi);
                    break;
                default:
                    Console.WriteLine("Film Bulunamamaktadır.");
                    break;
            }

            Seans seans1 = new Seans();
            seans1.salonNo = 2;
            seans1.suresi = 120;

            Seans seans2 = new Seans();
            seans2.salonNo = 3;
            seans2.suresi = 240;

            switch (secilen_film)
            {
                case 1:
                    Console.WriteLine("Salon No:" + seans1.salonNo);
                    break;

                case 2:
                    Console.WriteLine("Salon No:" + seans2.salonNo);
                    break;

                default:
                    Console.WriteLine("Böyle bir seans bulunmamaktadır.");
                    break;

            }
            salon salon1 = new salon();
            salon1.SalonKapasitesi = 150;
            salon1.SalonAdi = 2;

            salon salon2 = new salon();
            salon2.SalonKapasitesi = 200;
            salon2.SalonAdi = 3;

            switch (secilen_film)
            {
                case 1:
                    Console.WriteLine("Salon Kapasitesi:" + salon1.SalonKapasitesi);
                    break;
                case 2:
                    Console.WriteLine("Salon Kapasitesi:" + salon2.SalonKapasitesi);
                    break;
                default:
                    Console.WriteLine("salon bulunamamaktadır.");
                    break;
            }
            rezervasyon rezervasyon1 = new rezervasyon();
            rezervasyon rezervasyon2 = new rezervasyon();
            switch (secilen_film)
            {
                case 1:
                    Console.WriteLine("Adınız ve Soyadınızı giriniz:");
                    rezervasyon1.MusteriAdsoyad = (Console.ReadLine());

                    Console.WriteLine("Cinsiyet giriniz:");
                    rezervasyon1.Cinsiyet = (Console.ReadLine());

                    Console.WriteLine("Kaç bilet almak istiyorsunuz?");
                    rezervasyon1.BiletAdeti = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < rezervasyon1.BiletAdeti + 1; i++)
                    {
                        Console.WriteLine("almak istediğiniz koltuk numrasını yazınız");
                        Console.WriteLine("koltuk" + i);
                        alinanbiletler = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2:
                    
                    Console.WriteLine("Adınız ve Soyadınızı giriniz:");
                    rezervasyon2.MusteriAdsoyad = (Console.ReadLine());

                    Console.WriteLine("Cinsiyet giriniz:");
                    rezervasyon2.Cinsiyet = (Console.ReadLine());

                    Console.WriteLine("Kaç bilet almak istiyorsunuz?");
                    rezervasyon2.BiletAdeti = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < rezervasyon2.BiletAdeti + 1; i++)
                    {
                        Console.WriteLine("almak istediğiniz koltuk numrasını yazınız");
                        Console.WriteLine("koltuk" + i);
                        alinanbiletler = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                default:
                    Console.WriteLine("rezervsyon bulunamamaktadır.");
                    break;
            }

            bool ok_engel = true;
            while (ok_engel)
            {
                Console.WriteLine("Herhangi bir Engeliniz Var Mı?, 'Evet' ya da 'Hayır '");
                EngelDurumu = (Console.ReadLine());
                if (EngelDurumu == "Evet")
                {
                    Console.WriteLine("Size Uygun Yer Ayarlandı ");
                    ok_engel = false;
                }
                else if (EngelDurumu == "Hayır")
                {
                    Console.WriteLine("Engel Durumu Yok");
                    ok_engel = false;
                }
                else
                {
                    Console.WriteLine("Yanlış Yazdınız");
                    ok_engel = true;
                }
            }

            switch (secilen_film)
            {
                case 1:
                    Console.WriteLine("Bilet Adeti:" + rezervasyon1.BiletAdeti);
                    Console.WriteLine("Koltuk No:" + rezervasyon1.KoltukNo);
                    Console.WriteLine("Müşteri Ad Soyad:" + rezervasyon1.MusteriAdsoyad);
                    Console.WriteLine("Cinsiyet:" + rezervasyon1.Cinsiyet);
                    break;
                case 2:
                    Console.WriteLine("Bilet Adeti:" + rezervasyon2.BiletAdeti);
                    Console.WriteLine("Koltuk No:" + rezervasyon2.KoltukNo);
                    Console.WriteLine("Müşteri Ad Soyad:" + rezervasyon2.MusteriAdsoyad);
                    Console.WriteLine("Cinsiyet:" + rezervasyon2.Cinsiyet);
                    break;
                default:
                    Console.WriteLine("Rezervasyon Bulunmamaktadır.");
                    break;
            }
        }
    }
}