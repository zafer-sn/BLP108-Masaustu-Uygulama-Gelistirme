using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hafta11_BP
{
    // Personel class ı tanımlama
    class Personel
    {
        // private(class dışından erişilemez) maas fieldı tanımlama
        private double maas;
        // maas fieldının okunması durumunda(get) çalışacak metot, metot ile kapsülleme yapılmış.
        public double GetMaas()
        {
            return maas;
        }
        // maas fieldına değer atanması(set) durumunda çalışacak metot, metot ile kapsülleme yapılmış.
        public void SetMaas(double deger)
        {
            maas = deger;
        }
        // public(her yerden erişilebilir) yas fieldı tanımlama
        public int yas;
        /*
        DogumTarihiHesapla() isimli metot tanımlama. this.yas yas fieldına erişim sağlar,
        normal yas ise metodun parametresi olan yas'a erişim sağlar
        */
        public void DogumTarihiHesapla(int yas)
        {
            this.yas = yas; // this.yas = 100;
        }
    }
    // Ogrenci class ı tanımlama
    class Ogrenci
    {
        // public(her yerden erişilebilir) not fieldı tanımlama. Class member-1
        public int not;
        // private(sadece class içerisinden erişilebilir) ortalama fieldı tanımlama
        private int ortalama;
        /*
        ortalama fieldını Ortalama property'si ile kapsülleme. Propertylerde genelde kapsüllenecek
        fieldın ilk harfi büyük olarak tanımlama yapılır. Class member-2
        get bloğu -> fieldın değeri okunduğunda(getirildiğinde) çalışır.
        set bloğu -> fielda bir değer atandığında(yazıldığında) çalışır.
        */
        public int Ortalama
        {
            get
            {
                // ortalama fieldının değeri 2 ile çarpılarak döndürülüyor.
                return ortalama *2;
            }
            set
            {
                // ortalama fieldının gelen değerin 10 eksiği atanıyor.
                ortalama = value-10;
            }
        }
        // Bir başka property ile kapsülleme örneği. Kısayolu propfull yazıp tab tuşuna basmak.
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        // Bir başka property ile kapsülleme örneği. Kısayolu prop yazıp tab tuşuna basmak.
        public int MyProperty1 { get; set; }
        // DersCalis() metodu tanımlanmış. Class member-3
        public void DersCalis()
        {
            Console.WriteLine("Ders çalışılıyor");
        }
        // Indexer tanımlanmış. Property'e çok benzer. this ile kullanılır. class member-4
        public int this[int a]
        {
            get
            {
                return a*5;
            }            
        }
    }
    // Okul class ı tanımlama
    class Okul
    {
        // 4 adet field tanımlanmış.
        string adi;
        string konum;
        int yapilisYili;
        bool devletmi;
        // Yapıcı metot tanımlanmış. Yapıcı metot class ismi ile aynı olmalı, public olmalı, geri dönüş değeri belirtilmemeli!
        // Bir classtan nesne üretildiğinde yapıcı metot çalışır. Çalışmak zorunda!
        public Okul(string adi, string konum, int yapilisYili, bool devletmi)
        {
            // this.adi ile 86. satırdaki adi fieldına erişim sağlanıyor.
            // ='in sağında adi ise parametre olarak alınan adi değişkeni.
            this.adi = adi;
            this.konum = konum;
            this.yapilisYili = yapilisYili;
            this.devletmi = devletmi;
        }
        // TorenYap() metodu tanımlanmış.
        public void TorenYap()
        {
            Console.WriteLine("Tören yapılıyor...");
        }
    }
    // Hastane class ı tanımlama
    class Hastane
    {
        public Hastane()
        {
                
        }
    }
    // Belediye class ı tanımlama
    class Belediye
    {
        // Birden çok yapıcı metot tanımlanmış ve this ile aralarında geçil sağlanmış.
        public Belediye() : this(1995)
        {
            Console.WriteLine("Parametresiz yapıcı metot");
        }

        public Belediye(int kurulusYili) : this (150, "Bilecik Belediyesi")
        {
            Console.WriteLine("kurulusYili parametreli yapıcı metot");
        }

        public Belediye(int calisanSayisi, string belediyeAdi)
        {
            Console.WriteLine($"Calisan sayisi: {calisanSayisi}, belediye adi: {belediyeAdi}");
        }
    }
    /*
    Bir tane Ogrenci classı tanımlayın.
    Class içerisinde: isim(string), soyisim(string), yas(int),
    vizeNotu(int), odevNotu(int), finalNotu(int) fieldları bulunsun.
    Herbir fielda kapsülleme uygulansın.
    Bir tane OrtalamaHesapla isimli metot olsun ve öğrencinin
    ortalamasını hesaplasın.
    isim() ve soyisim() fieldarı sadece okunabilsin, değiştirilemesin!  
    */
    // Kullanici class ı tanımlama
    class Kullanici
    {
        string isim;
        string soyisim;
        int yas;
        int vizeNotu;
        int odevNotu;
        int finalNotu;
        // İlgili fieldlar için property tanımlanmış ve kapsüllenmiş.
        public int FinalNotu
        {
            get
            {
                return finalNotu;
            }
            set
            {
                finalNotu = value;
            }
        }
        public int OdevNotu
        {
            get
            {
                return odevNotu;
            }
            set
            {
                odevNotu = value;
            }
        }
        public int VizeNotu
        {
            get
            {
                return vizeNotu;
            }
            set
            {
                vizeNotu = value;
            }
        }

        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                yas = value;
            }
        }

        public string Isim
        {
            get
            {
                return isim;
            }            
        }

        public string Soyisim
        {
            get
            {
                return soyisim;
            }
        }
        // OrtalamaHesapla() metodu tanımlanmış.
        public double OrtalamaHesapla()
        {
            return this.vizeNotu * 0.4 + this.odevNotu * 0.1 + this.finalNotu * 0.6;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanici classından bir nesne üretilmiş ve k1 referansı ile işaretlenmiş.
            Kullanici k1 = new Kullanici();
            k1.VizeNotu = 15;
            k1.OdevNotu = 65;
            k1.FinalNotu = 85;
            Console.WriteLine(k1.OrtalamaHesapla());

            // Belediye belediye1 = new Belediye();                      
            // Belediye belediye2 = new Belediye();
            Belediye belediye1 = new Belediye();

            // Sadece nesne üretilmiş ve yapıcı metotlar tetikletilmiş.
            new Okul(adi:"PMYO", "Pazaryeri", 1994, true); 
            new Okul("ESOGU", "Odunpazarı", 1970, true); 
            new Okul("Bilkent", "Ankara", 1985, false);
            Okul okul1 = new Okul("ODTÜ", "Ankara", 1990, true);
            okul1.TorenYap();

            // Hastane classından bir nesne üretilmiş ve hastane1 referansı ile işaretlenmiş.
            // new(); ile de nesne üretimi yapılabilir.
            Hastane hastane1 = new();
            var hastane2 = new Hastane();

            // Ogrenci classından bir nesne üretilmiş ve ogr1 referansı ile işaretlenmiş. İlgili memberları atanmış.
            Ogrenci ogr1 = new Ogrenci();
            ogr1.not = 50;
            Ogrenci ogr2 = new Ogrenci();
            ogr2.not = 100;
            ogr1 = ogr2;
            ogr2.not = 75;
            Console.WriteLine(ogr1.not);
            Console.WriteLine(ogr2.not);
            int a = 100;
            int b = 75;
            a = b; a = 75;
            b = 80;
            string[] meyveler = { "elma", "armut", "cilek" };
            string[] sebzeler = { "pırasa", "domates", "roka" };
            meyveler = sebzeler;
            meyveler[0] = "Havuc";
            sebzeler[1] = "Patlıcan";
            meyveler[2] = "Dut";
            Console.WriteLine(meyveler[0]);
            Console.WriteLine(meyveler[1]);
            Console.WriteLine(meyveler[2]);
            Console.WriteLine(sebzeler[0]);
            Console.WriteLine(sebzeler[1]);
            Console.WriteLine(sebzeler[2]);

            Ogrenci ogr3 = new Ogrenci();
            Console.WriteLine(ogr3.Ortalama);
            ogr3.Ortalama = 80;
            Console.WriteLine(ogr3.Ortalama);
            Console.WriteLine(ogr3[5]);

            /*
            Personel maas fieldını metot kullanarak kapsülleyen bir örnek yapınız.             
            */
            Personel p1 = new Personel();
            p1.SetMaas(1000);
            Console.WriteLine(p1.GetMaas());
            p1.DogumTarihiHesapla(100);
            Console.WriteLine(p1.yas);     
        }
    }
}


