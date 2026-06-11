namespace Hafta14BP
{
    // DRY -> Dont Repeat Yourself
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
    class Personel
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int yas { get; set; }
        public double MaasHesapla(double netMaas,
            double vardiyaSaati,
            double vardiyaSaatUcreti,
            double kesinti)
        {
            return (netMaas + (vardiyaSaati * vardiyaSaatUcreti)) - kesinti;
        }
    }
    class AkademikPersonel : Personel
    {
        public string[] verilenDersler { get; set; }
        /* public AkademikPersonel(string isim)
        {
            base.isim = isim;
        } */
    }
    class IdariPersonel : Personel
    {
        public void ogrenciBelgesiVer()
        {
            Console.WriteLine("Öğrenci belgesi veriliyor...");
        }
        public void stajyerSigortasiYap()
        {
            Console.WriteLine("Stajyer sigortası yapılıyor...");
        }
    }
    class GeciciPersonel : Personel
    {
        public int calisilanAy { get; set; }
    }

    class Stajyer : GeciciPersonel
    {
        public string yetki { get; set; }
    }
    class Anne
    {

    }
    class Baba : Anne
    {

    }
    class Cocuk : Baba
    {

    }
    interface IAPI
    {
        public void istekAt();
    }
    interface IAPI2
    {
        public void istekAt2();
    }
    // İmplemente
    class Uygula : IAPI, IAPI2
    {
        public void istekAt()
        {

        }

        public void istekAt2()
        {
            throw new NotImplementedException();
        }
    }

    /*
     * Bu şekilde kalıtım alınamaz!!!
    class Cocuk : Anne, Baba
    {

    }*/
    // Constructor - Yapıcı Metot - Kurucu Metot
    class Okul
    {
        public string adi { get; set; }
        public int kurulusYili { get; set; }
        public int ogrenciSayisi { get; set; }
        public Okul(string adi, int kurulusYili)
        {
            this.kurulusYili = kurulusYili;
            this.adi = adi;
            Console.WriteLine($"{this.adi} okulu, {this.kurulusYili} yılında kurulmuştur!");
        }
        public Okul(int ogrenciSayisi)
        {
            this.ogrenciSayisi = ogrenciSayisi;
        }
    }
    class Universite : Okul
    {
        public Universite(int ogrenciSayisi) :  base (ogrenciSayisi)
        {
            Console.WriteLine("Universite nesnesi oluşturuldu!");
        }
    }
    class Kopek
    {
        public Kopek() : this ("Karabas")
        {
            
        }
        public Kopek(string isim)
        {
            
        }
    }
    class Lise : Okul
    {
        public Lise(string ad, int kurulusYili) : base(ad,kurulusYili)
        {
            Console.WriteLine("Lise nesnesi oluşturuldu!");
        }
    }
    class Bitki
    {
        public Bitki()
        {
            
        }
    }

    class Papatya : Bitki
    {

    }

    class Canli
    {
        public int hucreSayisi { get; set; }
        public void Solunum()
        {
            Console.WriteLine("Solunum yapılıyor...");
        }
        public void Dolasim(string isim)
        {
            Console.WriteLine($"{isim} dolasim yapiyor...");
        }
    }
    class Insan : Canli
    {
        public bool akil { get; set; }
        public void ThisBase()
        {
            this.akil = true;
            this.Dolasim("Kopek");
            base.Dolasim("Kedi");
        }
    }
    class Hayvan : Canli
    {

    }
    class Kitap
    {
        public string ad { get; set; }
        public string yazar { get; set; }
    }
    class Varlik
    {
        public bool atomikYapi1 { get; set; }
        private bool atomikYapi2 { get; set; }
        protected bool atomikYapi3 { get; set; }
        internal bool atomikYapi4 { get; set; }
        public void Deneme()
        {
            atomikYapi1 = false;
        }
    }
    class Ucak : Varlik
    {
        public string Marka { get; set; }
        public void Test()
        {
            base.atomikYapi1 = true;
        }
    }
    // C#'ta bir class sadece public ve internal ile işaretlenebilir.
    public class Masa
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Varlik v1 = new Varlik();
            object sayi = 11;
            Console.WriteLine((int)sayi + 5);
            Kitap ktp1 = new Kitap();
            ktp1.ToString();
            Insan insan1 = new Insan();
            Okul okul1 = new Okul("ODTU",2005);
            Universite uni1 = new Universite(15000);
            Lise lise1 = new Lise("Anadolu", 1970);
            Console.WriteLine("-----------------------------------------");
            Honda h1 = new Honda(); // RAM, Heap - GC            
            h1.Marka = "Honda";
            h1.Model = "Civic";
            h1.KM = 50000;
            Opel o1 = new Opel();
            o1.Marka = "Opel";
            o1.Model = "Astra";
            o1.KM = 25000;
            Mercedes m1 = new Mercedes();
            m1.Marka = "Mercedes";
            m1.Model = "C180";
            m1.KM = 100000;
            Personel p1 = new Personel();
            p1.isim = "Ahmet";
            AkademikPersonel zafer = new AkademikPersonel();
            zafer.isim = "Zafer";
            zafer.soyisim = "SERİN";
            zafer.verilenDersler = new string[2] {"Masaüstü", "Mobil"};
            Console.WriteLine($"Zafer maaş: {zafer.MaasHesapla(500000, 15, 1000, 50000)}");
            AkademikPersonel serkan = new AkademikPersonel();
            serkan.isim = "Serkan";
            serkan.soyisim = "SÖKMEN";
            serkan.verilenDersler = new string[2] { "C Programlama", "Programlama Dilleri" };
            Console.WriteLine($"Serkan maaş: {serkan.MaasHesapla(7500000, 25, 2000, 100000)}");
            IdariPersonel enes = new IdariPersonel();
            enes.isim = "Enes";
            enes.soyisim = "Bey";
            Console.WriteLine($"Enes maaş: {enes.MaasHesapla(2500000, 5, 3000, 250000)}");
            enes.ogrenciBelgesiVer();
            enes.stajyerSigortasiYap();
            GeciciPersonel batuhan = new GeciciPersonel();
            batuhan.isim = "Batuhan";
            batuhan.soyisim = "TEST";
            batuhan.calisilanAy = 6;
            Console.WriteLine($"Batuhan maaş: {batuhan.MaasHesapla(3500000, 8 * batuhan.calisilanAy, 4000, 250000)}");
            Stajyer ahmet = new Stajyer();
            ahmet.isim = "Ahmet";
            ahmet.soyisim = "DENEME";
            ahmet.calisilanAy = 4;
            // DD
            ahmet.yetki = "Dusuk";
            Console.WriteLine($"Ahmet maaş: {ahmet.MaasHesapla(3500000, 8 * batuhan.calisilanAy, 4000, 250000)}");

        }
    }
}
