using System.Data;
using System.Transactions;

namespace Hafta13_BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(); 
            Kedi k1 = new Kedi(); 
            
            Hastane h1 = new Hastane();
            Console.WriteLine(h1.Adi);

            Hastane h2 = new Hastane()
            {
                Adi = "Eskişehir Hastanesi",
                OdaSayisi = 100,
                CalisanSayisi = 1500
            };
            Console.WriteLine(h2.Adi);
            Console.WriteLine(h2.OdaSayisi);
            h2.Adi = "Ankara Hastanesi";
            h2.OdaSayisi = 200;
            // h2.CalisanSayisi = 2500; -> Hata verir.

            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                Islemci = "i7 4790K",
                RAMMiktari = 32
            };

            Banka1Record bnk1record = new Banka1Record();
            Banka1Record bnk2record = new Banka1Record();

            Banka2Class bnk1class = new Banka2Class();
            Banka2Class bnk2class = new Banka2Class();
            if(bnk1class == bnk2class)
            {
                Console.WriteLine("Class nesneleri aynıdır...");
            }

            if(bnk1record == bnk2record)
            {
                Console.WriteLine("Record nesneleri aynıdır...");
            }

            Kitap ktp1 = new Kitap();
            ktp1.Oku();
            SiirKitabi siirKitabi1 = new SiirKitabi();
            siirKitabi1.Oku();

            Canli canli1 = new Canli();
            canli1.Solunum();

            Erkek erkek1 = new Erkek();
            erkek1.Solunum();

            Kadin kadin1 = new Kadin();
            kadin1.Solunum();

            Personel Zeliha = new Personel()
            { 
                BrutMaas = 200_000,
                GelirVergisi = 20_000
            };
            Console.WriteLine(Zeliha.NetMaasHesapla());

            VardiyaliPersonel vp1 = new VardiyaliPersonel()
            {
                BrutMaas = 60_000,
                GelirVergisi = 10_000,
                VardiyaUcreti = 250,
                VardiyaSaati = 48
            };
            Console.WriteLine(vp1.NetMaasHesapla());
            
            Kus kus1 = new Kus();

            Kus papagan1 = new Papagan();
            papagan1.Renk = "Sarı";

            int bilecikPlaka = 11; // Int32 - Polimorfizm
            double b = bilecikPlaka;

            Object p1 = new Personel();
            p1.ToString();
        }
    }
    class Kus
    {
        public bool PerdeAyak { get; set; }
        public string Renk { get; set; }
    }

    class Papagan : Kus
    {
        public void Konus()
        {
            Console.WriteLine("Papagan konusuyor...");
        }
    }







    class Kitap
    {
        public int sayfaSayisi; // field yapıları sanal hale getirilemez!
        public virtual string Isim { get; set; }
        virtual public void Oku()
        {
            Console.WriteLine("Kitap okunuyor...");
        }
        public virtual int this[int a]
        {
            get
            {
                return 5;
            }            
        }
    }
    class Varlik
    {
        public virtual void Solunum()
        {
            Console.WriteLine("Solunum yapılıyor...");
        }
    }
    class Personel
    {
        private readonly double brutMaas;
        public double BrutMaas
        {
            get
            {
                return brutMaas;
            }
            init
            {
                brutMaas = value;
            }
        }

        private readonly double gelirVergisi;
        public double GelirVergisi
        {
            get
            {
                return gelirVergisi;
            }
            init
            {
                gelirVergisi = value;
            }
        }

        public virtual double NetMaasHesapla()
        {
            return BrutMaas - GelirVergisi;
        }
    }

    class VardiyaliPersonel : Personel
    {
        private readonly int vardiyaSaati;
        public int VardiyaSaati
        {
            get
            {
                return vardiyaSaati;
            }
            init
            {
                vardiyaSaati = value;
            }
        }

        private readonly double vardiyaUcreti;
        public double VardiyaUcreti
        {
            get
            {
                return vardiyaUcreti;
            }
            init
            {
                vardiyaUcreti = value;
            }
        }

        public override double NetMaasHesapla()
        {
            return (base.BrutMaas + this.VardiyaUcreti * this.VardiyaSaati) - base.GelirVergisi;
        }
    }

    class Canli : Varlik
    {
        
    }

    class Insan : Canli
    {
        public override void Solunum()
        {
            Console.WriteLine("Insan solunum yapıyor...");
        }
    }

    class Erkek : Insan
    {
       
    }

    class Kadin : Insan
    {

    }

    class SiirKitabi : Kitap
    {
        public override void Oku()
        {
            Console.WriteLine("Şiir kitabı okunuyor...");
        }
    }

    // With Expressions
    // record
    record Banka1Record
    {        
        public string Isim { get; init; }
        public int KurulusYili { get; init; }
    }

    class Banka2Class
    {
        public string Isim { get; set; }
        public int KurulusYili { get; set; }
    }

    class Bilgisayar
    {
        private readonly int rAMMiktari;
        public int RAMMiktari
        {
            get
            { 
                return rAMMiktari;
            }
            init
            {
                rAMMiktari = value;
            }
        }

        public readonly string renk;
        public string Islemci { get; init; }
    }


    class Hastane
    {
        public string Adi { get; set; } = "Bilecik Hastanesi";
        public int OdaSayisi { get; set; }
        public int CalisanSayisi { get; init; } // Readonly
    }

    
    public class Sekil
    {
        protected internal double Alan { get; set; }
        // Ufak-ödev
        private protected double Cevre { get; set; }
    }

    class Ucgen : Sekil
    {

    }
    
    class Kedi
    {
        private string Isim { get; set; }
        public int Yas { get; set; }
        protected string Renk { get; set; }
        internal string Tur { get; set; }
    }

    class Tekir : Kedi
    {
        public Tekir()
        {
            
        }
    }



    class Ogrenci
    {
        string Isim { get; set; } // Varsayılan private
        // Nested Type Class
        /*private class Adres
        {

        }*/
        private string Soyisim { get; set; }
    }



    // public - internal
    // internal -> Sadece kendi projesi içerisinden erişilebilir
    public class Okul
    {

    }

    internal class Okul2
    {

    }

}
// public - internal
class Okul3
{

}



