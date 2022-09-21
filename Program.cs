using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soz Dizimi

            // class SinifAdi
            // {
            //     [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erisim Belirleyici] [Geri Donus Tipi] MetotAdi(Parametre Listesi)
            //     {
            //         //Metot Komutlari
            //     }
            // }

            //Erisim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Enes";
            calisan1.Soyad = "Orhan";
            calisan1.No = 23434587;
            calisan1.Departman = "Insan Kaynaklari";
            calisan1.CalisanBilgileri();

            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 85459034;
            calisan2.Departman = "Satin Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Soyadi: {0}",Soyad);
            Console.WriteLine("Calisan Numarasi: {0}",No);
            Console.WriteLine("Calisanin Departmani: {0}",Departman);
        }
    }
}
