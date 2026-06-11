namespace Hafta12BP
{
    class Matematik
    {
        double piSayisi;
        public double PiSayisi
        {
            get
            {
                return piSayisi;
            }

            set
            {
                piSayisi = value;
            }
        }
        public double eSayisi { get; set; }
        // Özyinelemeli fonksiyon - Rekursif Fonksiyon - Metot
        // 2^3 = 2* 2 * 2
        public static double UsAl(int taban, int us)
        {
            if (us == 0)
            {
                return 1;
            }
            // 2 * Usal (2, 2)
            // 2 * 2 * UsAL(2, 1)
            // 2*2*2*UsAl(2,0)
            // 2*2*2*1=8
            return taban * UsAl(taban, us - 1);
        }

        public int this[int a, int b]
        {
            get
            {                
                a = a * 2;
                return a;
                // return a * b;
            }            
        }

        int deger;
        public double dondur()
        {        

            return UsAl(2,3);
        }
    }

    class Ogrenci
    {
        public Ogrenci() : this(2, "Zeynep")
        {
            Console.WriteLine("Ogrenci nesnesi olusturuldu!");
            Console.WriteLine();
        }
        public Ogrenci(int id) : this("Mehmet", 4)
        {
            Console.WriteLine($"Ogrenci nesnesi {id} degeri ile olusturuldu!");

        }

        public Ogrenci(int id, string isim) : this(3)
        {
            Console.WriteLine($"Ogrenci nesnesi {id} degeri {isim} adi ile olusturuldu!");

        }

        public Ogrenci(string isim, int id)
        {
            Console.WriteLine($"Ogrenci nesnesi önce {isim} adı sonra {id} degeri ile olusturuldu!");

        }        
    }

    class Hayvan
    {
        private Hayvan()
        {
            
        }
    }

    class Personel
    {
        // SOLID - D -> Dependency Inversion - bağımlılıkların tersine çevrilmesi
        int id;
        int yas;
        string isim;
        double brutMaas;
        double vardiyaUcreti;
        int calismaYili;
        public Personel(int id, int yas, string isim, double brutMaas, double vardiyaUcreti, int calismaYili)
        {
            this.id = id;
            this.yas = yas;
            this.isim = isim;
            this.brutMaas = brutMaas;
            this.vardiyaUcreti = vardiyaUcreti;
            this.calismaYili = calismaYili;
        }

        public double NetMaas()
        {
            return (this.brutMaas) + (this.vardiyaUcreti);
        }

        public double Tazminat()
        {
            return this.calismaYili * this.NetMaas();
        }
    }
    class Dikdortgen
    {
        double en;
        double boy;
        public Dikdortgen(double en, double boy)
        {
            this.en = en;
            this.boy = boy;
        }

        public double AlanHesapla()
        {
            return this.en * this.boy;
        }
    }

    class Okul
    {
        public Okul(int kurulusYili)
        {
            
        }
    }

    class Bitki
    {
        // Bu yapıcı metot değildir! Normal metottur.
        public void BiTki()
        {

        }
        public Bitki()
        {
            Console.WriteLine("Bitki nesnesi olusturuldu!");
        }
        ~Bitki()
        {
            Console.WriteLine("Yıkıcı metot calisti");
        }

    }

    class Insan
    {
        public Insan()
        {
            Console.WriteLine("Normal yapıcı metot tetiklendi");
        }

        ~Insan()
        {
            Console.WriteLine("Normal yıkıcı metot tetiklendi");
        }

        static Insan()
        {
            Console.WriteLine("Statik yapıcı metot tetiklendi");
        }
    }

    class Database
    {
        static Database db;
        public string connString { get; set; }
        public static Database GetInstance
        {
            get
            {
                return db;
            }

            set
            {

            }
        }
        Database()
        {

        }

        static Database()
        {
            db = new Database();
        }

    }
    internal class Program
    {
        static void NesneOlustur()
        {
            Bitki papatya = new Bitki();
        }
        static void Main(string[] args)
        {
            var db1 = Database.GetInstance;
            var db2 = Database.GetInstance;
            db2.connString = "deneme11";
            var db3 = Database.GetInstance;
            var db4 = Database.GetInstance;
            var db5 = Database.GetInstance;
            // Database db = new Database(); - HATA!
            new Insan();
            new Insan();
            new Insan();
            new Insan();
            new Insan();
            NesneOlustur();
            GC.Collect();
            //Console csl1 = new Console();
            //csl1.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
            Matematik m2 = new Matematik();
            
            Matematik.UsAl(3, 5);
            Okul o1 = new Okul(1994);
            int yas = 19;
            Matematik m1 = new Matematik();
            //Console.WriteLine(m1.UsAl(2, 3));
            //Console.WriteLine(m1.UsAl(3, 4));
            // Console.WriteLine(m1.UsAl(3, -2));
            // int[] yaslar = new int[5]; [] -> indexer - indeksleyici
            Console.WriteLine(m1[3, 5]);
            Console.WriteLine("----------------------------------------");
            new Ogrenci();
            new Ogrenci();
            new Ogrenci();
            new Ogrenci();
            new Ogrenci();
            new Ogrenci(1);
            new Ogrenci(2, "Zafer");
            new Ogrenci("Ayse", 3);
            Personel zeliha = new Personel(1, 20, "Zeliha", 45000, 5000, 20);
            Console.WriteLine(zeliha.NetMaas());
            Console.WriteLine(zeliha.Tazminat());
            Personel yasemin = new Personel(2, 21, "Yasemin", 35000, 2750, 12);
            Console.WriteLine(yasemin.NetMaas());
            Console.WriteLine(yasemin.Tazminat());
            Dikdortgen d1 = new Dikdortgen(5, 3);
            Console.WriteLine(d1.AlanHesapla());
            Dikdortgen d2 = new Dikdortgen(7, 9);
            Console.WriteLine(d2.AlanHesapla());
            Console.WriteLine("********************************************");
            Ogrenci ogr1 = new Ogrenci();
            // Hayvan h1 = new Hayvan();

        }
    }
}
