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

            Console.WriteLine("******** Calisan 1 *******");
            Calisan calisan1 = new Calisan("Enes","Orhan",23434587,"Insan Kaynaklari");
            calisan1.CalisanBilgileri();

            Console.WriteLine("******** Calisan 2 *******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 85459034;
            calisan2.Departman = "Satin Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("******** Calisan 3 *******");
            Calisan calisan3 = new Calisan("Furkan","Orhan");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;   //this bu sınıfın elemanı olduğu için kullandık
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }   

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;   //this bu sınıfın elemanı olduğu için kullandık
            this.Soyad = soyad;

        }
        //overload işlemi
        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Soyadi: {0}",Soyad);
            Console.WriteLine("Calisan Numarasi: {0}",No);
            Console.WriteLine("Calisanin Departmani: {0}",Departman);
        }
    }
}
