namespace Hafta12_BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Calis();
            Ogrenci ogr2 = new Ogrenci();
            Ogrenci ogr3 = new Ogrenci();

            Console.WriteLine();

            int sayi = 0;
            while (sayi < 10)
            {
                new Personel();
                sayi++;
            }
            // GC.Collect();
            // PersonelOlustur();
            // Garbage Collector
            // GC.Collect();
            // Console.ReadLine();

            new Kullanici();
            new Kullanici();
            new Kullanici();

            // Personel.MaasHesapla();

            Araba a1 = new Araba();
            Console.WriteLine(a1.Marka);
            Honda h1 = new Honda();
            Console.WriteLine();
            Opel o1= new Opel();
            Mercedes m1 = new Mercedes();
            Musteri mu1 = new Musteri();
            mu1.Solunum();

            KizilCam kc1 = new KizilCam();

            ZiraatBankasi zb = new ZiraatBankasi();

            Kitap k1 = new Kitap("Kürk Mantolu Madonna", 500, "Sabahattin Ali");
            Kedi ke1 = new Kedi();
            k1.ToString();

            object bilecikPlaka = 11;
            Console.WriteLine((int)bilecikPlaka + 11);

            Insan i1 = new Insan();
            Personel p1 = new Personel();
            AkademikPersonel ap = new AkademikPersonel();
            IdariPersonel ip = new IdariPersonel();
            ZaferSERIN zs = new ZaferSERIN();
            ap.VerdigiDersler = ["Masaüstü Uygulama Geliştirme"];
            ap.MakalesiVarmi = false;
            zs.OgrenciSayisi = 400;
            Console.WriteLine(zs.BilinenProgramlamaDilleri);
        }

        public static void PersonelOlustur()
        {
            Personel p1 = new Personel();
        }
    }
    class Insan
    {
        public void Solunum()
        {
            Console.WriteLine("Solunum yapılıyor...");
        }
        public void Dolasim()
        {
            Console.WriteLine("Dolaşım yapılıyor...");
        }
        public void Beslenme()
        {
            Console.WriteLine("Beslenme yapılıyor...");
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

    class Personel : Insan
    {
        private double brutMaas;      

        public double BrutMaas
        {
            get { return brutMaas; }
            set { brutMaas = value; }
        }

        public double MaasHesapla()
        {
            return brutMaas * 0.75;
        }
    }

    class AkademikPersonel : Personel
    {
        public string[] VerdigiDersler { get; set; }
        public string[] AldigiDersler { get; set; }

        public bool MakalesiVarmi { get; set; }
    }

    class IdariPersonel : Personel
    {
        public string Yetki { get; set; }

        public void DilekceYaz()
        {
            Console.WriteLine("Dilekçe yazılıyor...");
        }
    }

    class ZaferSERIN
    {
        public string[] BilinenProgramlamaDilleri { get; set; }
        public int OgrenciSayisi { get; set; }
    }


    class Kitap : Object
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        private int SayfaSayisi { get; set; }
        private string Yazar { get; set; }

        public Kitap(string Adi, int SayfaSayisi, string Yazar)
        {
            this.Adi = Adi;
            this.SayfaSayisi = SayfaSayisi;
            this.Yazar = Yazar;
        }
    }
    class Hayvan : Object
    {
        public Hayvan()
        {
            
        }
    }

    class Kedi : Hayvan
    {
        public Kedi()
        {
            Console.WriteLine("Kedi nesnesi oluşturuluyor...");
        }
    }
    class Banka
    {
        public string Adi { get; set; }
        public bool Acikmi { get; set; }
        public Banka(string Adi, bool Acikmi)
        {
            this.Adi = Adi;
            this.Acikmi = Acikmi;
            Console.WriteLine("Banka nesnesi oluşturuluyor...");
        }

        public Banka(int musteriSayisi)
        {
            Console.WriteLine($"Musteri Sayisi: {musteriSayisi}");
        }
    }

    class ZiraatBankasi : Banka
    {
        public ZiraatBankasi() : base("Garanti Bankasi", false)
        {
            Console.WriteLine("ZiraatBankasi nesnesi oluşturuluyor...");
        }
        public ZiraatBankasi(int kurulusYili) : base(200)
        {
            Console.WriteLine($"Kuruluş Yılı: {kurulusYili}");
        }
    }

    class Bitki
    {
        public Bitki()
        {
            Console.WriteLine("Bitki nesnesi üretiliyor...");
        }
    }

    class Agac : Bitki
    {
        public Agac()
        {
            Console.WriteLine("Agac nesnesi üretiliyor...");
        }
    }

    class CamAgaci : Agac
    {
        public CamAgaci()
        {
            Console.WriteLine("CamAgaci nesnesi üretiliyor...");
        }
    }

    class KizilCam : CamAgaci
    {
        public KizilCam()
        {
            Console.WriteLine("KizilCam nesnesi üretiliyor...");
        }
    }

    /*interface IHesap
    {

    }*/
    class Canli
    {
        public void Solunum()
        {
            Console.WriteLine("Solunum yapılıyor...");
        }
    }

    /*class Insan : Canli
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public bool Cinsiyet { get; set; }
        public int Yas { get; set; }
    }*/
    class Musteri : Insan
    {
        public double Bakiye { get; set; }
    }
    class App : StatelessWidget
    {
        public Center Build()
        {
            return new Center(child: 11);
        }
    }
    class StatelessWidget
    {
        public string appBar { get; set; }
        public string body { get; set; }
    }

    class Center
    {
        public int child { get; set; }
        public Center(int child)
        {
            this.child = child;
               }
        
    }

    class Scaffold
    {

    }

    class Column
    {
        public int[] children { get; set; }
    }
    class Kullanici
    {

        static Kullanici()
        {
            Console.WriteLine("Statik constructor çalıştı...");
        }
        public Kullanici()
        {
            Console.WriteLine("Kullanici nesnesi oluşturuluyor...");
        }
    }

    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
    }

    class Honda : Araba
    {
        
    }
    class Opel : Araba
    {
        
    }

    class Mercedes : Araba
    {
        
    }

    /* class Personel
    {
        public static double MaasHesapla()
        {
            Console.WriteLine("Maaş hesaplanıyor...");
            return 5.0;
        }

        public Personel()
        {
            Console.WriteLine("Nesne oluşturuluyor...");
        }
        // ALT + 0156
        // ALT + Ü
        
        ~Personel()
        {
            Console.WriteLine("Nesne yok ediliyor...");
        }
    }*/

    class Okul
    {
        // SOLID -> 
        // Single Resposibility, O -> Open-Close
        // Singleton

        public static string OkulAdi { get; set; }

        private Okul()
        {
            
        }

        public Okul(string isim)
        {
            Console.WriteLine(isim);
        }

        public Okul(int kurulusYili)
        {
            Console.WriteLine(kurulusYili);
        }

        public void X()
        {
            Okul o1 = new Okul();
        }
    }

    class Ogrenci
    {
        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi oluşturuldu...");
            int a = 5;
            int b = 7;
            Console.WriteLine(a+b);
        }

        public void Calis()
        {
            Console.WriteLine("Ogrenci çalışıyor...");
        }
    }

}
