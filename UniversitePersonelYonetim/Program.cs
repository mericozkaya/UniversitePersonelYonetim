using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    internal class Program
    {
        static List<Personel> personeller = new List<Personel>();

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            // Başlangıçta varsayılan personeller ekleniyor
            VarsayilanPersonelleriEkle();

            while (true)
            {
                Console.WriteLine("\n===== MENÜ =====");
                Console.WriteLine("1 - Tüm çalışanları listele");
                Console.WriteLine("2 - Yeni çalışan ekle");
                Console.WriteLine("3 - Maaşları göster");
                Console.WriteLine("4 - Zam uygula");
                Console.WriteLine("5 - 12 aylık simülasyonu çalıştır");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        TumCalisanlariListele();
                        break;
                    case "2":
                        YeniCalisanEkle();
                        break;
                    case "3":
                        MaaslariGoster();
                        break;
                    case "4":
                        ZamUygula();
                        break;
                    case "5":
                        SimulasyonuCalistir();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static void VarsayilanPersonelleriEkle()
        {
            personeller.Add(new Professor { Ad = "Efendi", Soyad = "NASİBOĞLU", DersSaati = 10 });
            personeller.Add(new Docent { Ad = "Muhammet", Soyad = "DAMAR", DersSaati = 8 });
            personeller.Add(new Docent { Ad = "Fidan", Soyad = "NURİYEVA", DersSaati = 7 });
            personeller.Add(new DrOgrUyesi { Ad = "Barış Tekin", Soyad = "TEZEL", DersSaati = 6 });
            personeller.Add(new DrOgrUyesi { Ad = "Kadriye Filiz", Soyad = "BALBAL", DersSaati = 5 });
            personeller.Add(new DrOgrUyesi { Ad = "Erdem", Soyad = "Alkım", DersSaati = 4 });
            personeller.Add(new ArasGor { Ad = "Süheyla", Soyad = "UYGUR" });
            personeller.Add(new ArasGor { Ad = "Onur Mert", Soyad = "ÇELDİR" });
            personeller.Add(new Memur { Ad = "Samed", Soyad = "TUÇAY" });
            personeller.Add(new Memur { Ad = "Osman", Soyad = "YAVUZ" });
            personeller.Add(new TeknikPersonel { Ad = "Mehmet", Soyad = "PAKSOY" });
        }

        static void TumCalisanlariListele()
        {
            Console.Clear();
            Console.WriteLine("\n--- Çalışan Listesi ---");
            foreach (var p in personeller)
            {
                Console.WriteLine(p);
            }
        }

        static void MaaslariGoster()
        {
            Console.Clear();
            Console.WriteLine("\n--- Maaşlar ---");
            foreach (var p in personeller)
            {
                Console.WriteLine($"{p} - Maaş: {p.MaasHesapla():N0} TL");
            }
        }

        static void ZamUygula()
        {
            Console.WriteLine("\nZam işlemi uygulanıyor...");
            foreach (var p in personeller)
            {
                if (p is IZamYap z)
                {
                    z.ZamYap();
                }
            }
            Console.WriteLine("Zam uygulandı.");
        }

        static void SimulasyonuCalistir()
        {
            Console.Clear();
            decimal toplamYillikGider = 0;

            for (int ay = 1; ay <= 12; ay++)
            {
                Console.WriteLine($"\n--- {ay}. Ay ---");

                if (ay == 6)
                {
                    Console.WriteLine("Haziran zammı bu ay uygulandı.");
                    ZamUygula();
                }

                decimal aylikToplam = 0;

                foreach (var p in personeller)
                {
                    decimal maas = p.MaasHesapla();
                    aylikToplam += maas;
                    Console.WriteLine($"{p} - Maaş: {maas:N0} TL");
                }

                Console.WriteLine($"Toplam Personel Gideri ({ay}. Ay): {aylikToplam:N0} TL");
            }

            Console.WriteLine($"\n12 Ay Sonundaki Toplam Gider: {toplamYillikGider:N0} TL");
            Console.WriteLine("\nAna menüye dönmek için ENTER'a bas.");
            Console.ReadLine();
        }


        static void YeniCalisanEkle()
        {
            Console.Clear();
            Console.WriteLine("\nYeni personel ekleniyor...");
            Console.WriteLine("Tür seçin: 1-Professor, 2-Docent, 3-DrOgrUyesi, 4-ArasGor, 5-Memur, 6-TeknikPersonel");
            string tur = Console.ReadLine();

            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            int dersSaati = 0;
            if (tur == "1" || tur == "2" || tur == "3")
            {
                Console.Write("Ders saati: ");
                int.TryParse(Console.ReadLine(), out dersSaati);
            }

            Personel yeni = null;

            switch (tur)
            {
                case "1":
                    yeni = new Professor { Ad = ad, Soyad = soyad, DersSaati = dersSaati };
                    break;
                case "2":
                    yeni = new Docent { Ad = ad, Soyad = soyad, DersSaati = dersSaati };
                    break;
                case "3":
                    yeni = new DrOgrUyesi { Ad = ad, Soyad = soyad, DersSaati = dersSaati };
                    break;
                case "4":
                    yeni = new ArasGor { Ad = ad, Soyad = soyad };
                    break;
                case "5":
                    yeni = new Memur { Ad = ad, Soyad = soyad };
                    break;
                case "6":
                    yeni = new TeknikPersonel { Ad = ad, Soyad = soyad };
                    break;
            }


            if (yeni != null)
            {
                personeller.Add(yeni);
                Console.WriteLine("Çalışan eklendi.");
            }
            else
            {
                Console.WriteLine("Geçersiz tür.");
            }
        }
    }
}

