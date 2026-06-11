namespace Hafta15BP
{
    class Birim
    {
        public string Ad { get; set; }
    }
    interface IStrateji
    {
        void butceCikar();
    }
    interface IMusavirlik
    {
        bool musavirmi { get; set; }
    }
    class Muhasebe : Birim, IStrateji, IMusavirlik
    {

    }
    /* Bu şekilde olmaz!
    class Baba
    {

    }
    class Anne
    { 
    }
    class Cocuk : Anne, Baba
    {

    }*/
    interface IParalelIstek
    {
        int ParalelIstekSayisi { get; set; }
        void paralelIstekAt();

    }
    interface Iistek
    {
        int IstekSayisi { get; set; }
        void istekAt();
    }
    class Baglanti : Iistek, IParalelIstek
    {
        public int ParalelIstekSayisi { get; set; }
        public void paralelIstekAt()
        {

        }
        public string BaglantiTuru { get; set; }
        public int IstekSayisi { get; set; }
        public void istekAt()
        {

        }
    }
    abstract class Urun
    {
        public int ID { get; set; }
        public void Deneme()
        {

        }
        public abstract string Renk { get; set; }
        public virtual int GarantiSuresi { get; set; }
        public abstract double KDVHesapla(double brutTutar, double kdvOrani);
        protected Urun()
        {
            Console.WriteLine("Abstract classtan nesne üretildi!");
        }

    }
    // Artık buna kalıtım değil implementasyon adını veriyoruz.
    class ElektronikCihaz : Urun
    {
        public string SeriNO { get; set; }
        public override double KDVHesapla(double brutTutar, double kdvOrani)
        {
            return (brutTutar * kdvOrani / 100);
        }
        public override string Renk { get; set; }
        public override int GarantiSuresi { get; set;}
        
    }

    class Canli
    {
        public void Solunum()
        {
            Console.WriteLine("Solunum yapiliyor...");
        }
    }
    class Insan : Canli
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public void Iletisim()
        {
            Console.WriteLine("Iletisim kuruluyor...");
        }
    }
    class Erkek : Insan
    {
        public bool Sakal { get; set; }
    }
    class Kadin : Insan
    {
        public bool Makyaj { get; set; }
    }
    class Bitki
    {
        public virtual void Fotosentez()
        {
            Console.WriteLine("Bitki fotosentez yapıyor...");
        }
    }
    class Papatya : Bitki
    {
        
    }
    class SariPapatya : Papatya
    {
        //Name-Hiding -- İsim saklama
        /*public virtual void Fotosentez()
        {
            Console.WriteLine("Sarı papatya fotosentez yapıyor...");
        }*/
        //Ezme İşlemi
        public override void Fotosentez()
        {
            Console.WriteLine("Sarı papatya fotosentez yapıyor...");
        }
    }
    class Musteri
    {
        double bakiye;
        public double Bakiye
        {
            get
            {
                return bakiye;
            }
            set
            {
                bakiye = value;
            }
        }
        public int ID { get; set; }
        public string? Isim { get; set; }
        public string? Soyisim { get; set; }
        public virtual double FaizOrani { get; set; } // 
        public int Yas { get; set; }
        public double Mevduat { get; set; }
        public Musteri(int ID, string? Isim, string? Soyisim, double FaizOrani, int Yas, double Mevduat)
        {
            this.ID = ID;
            this.Isim = Isim;
            this.Soyisim = Soyisim;
            this.FaizOrani = FaizOrani;
            this.Yas = Yas;
            this.Mevduat = Mevduat;
        }
        public virtual double ToplamFaizliPara()
        {
            return (this.Mevduat) + (this.Mevduat * this.FaizOrani)/100;
            // 10.000 + (10.000 * 3.34)
        }

    }
    class NormalMusteri : Musteri
    {
        public NormalMusteri(int ID, string? Isim, string Soyisim, double FaizOrani, int Yas, double Mevduat) : base(ID, Isim, Soyisim, FaizOrani, Yas, Mevduat)
        {
            
        }
    }
    class VIPMusteri : Musteri
    {
        public VIPMusteri(int ID, string? Isim, string Soyisim, double FaizOrani, int Yas, double Mevduat) : base(ID, Isim, Soyisim, FaizOrani, Yas, Mevduat)
        {

        }
        public override double FaizOrani { get; set; }
        public double BonusTutari { get; set; }
        public override double ToplamFaizliPara()
        {
            return (this.Mevduat+this.BonusTutari) + (this.Mevduat * this.FaizOrani) / 100;
            // (20000 + 5000)+(20000*50)/100
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1, "Ahmet", "YILMAZ", 3.34, 25, 10000);
            Console.WriteLine($"musteri1'in faizli toplam tutari: {musteri1.ToplamFaizliPara()}, musteri1'in faiz Orani: {musteri1.FaizOrani}");
            NormalMusteri normalMusteri1 = new NormalMusteri(2, "Ayse", "BULUT", 3, 30, 10000);
            Console.WriteLine($"normalMusteri1'in faizli toplam tutari: {normalMusteri1.ToplamFaizliPara()}, normalMusteri1'in faiz Orani: {normalMusteri1.FaizOrani}");
            VIPMusteri vipmusteri1 = new VIPMusteri(3, "Metehan", "TEST", 50.0, 20, 20000);
            vipmusteri1.BonusTutari = 5000;
            Console.WriteLine($"vipMusteri1'in faizli toplam tutari: {vipmusteri1.ToplamFaizliPara()}, vipMusteri1'in faiz Orani: {vipmusteri1.FaizOrani}");
            Console.WriteLine("--------------------------------");
            Bitki bitki1 = new Bitki();
            bitki1.Fotosentez();
            Papatya papatya1 = new Papatya();
            papatya1.Fotosentez();
            SariPapatya sariPapatya1 = new SariPapatya();
            sariPapatya1.Fotosentez();
            Object erkek1 = new Erkek();
            Insan kadin1 = new Kadin();
            byte bilecikPlaka = 11;
            int intBilecikPlaka = bilecikPlaka;
            ElektronikCihaz ecihaz1 = new ElektronikCihaz();
            Iistek baglanti1 = new Baglanti();
            baglanti1.
  

        }
    }
}
