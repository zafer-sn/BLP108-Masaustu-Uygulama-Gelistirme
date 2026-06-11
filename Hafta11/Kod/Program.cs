// Namespace disinda class tanimlama

class Meyve2
{

}
namespace Hafta11BP
{
    class Personel
    {
        public double temelMaas;
        public bool vardiyaVarmi;
        public int vardiyaSaati;
        public double vardiyaUcreti;
        public double maasHesapla()
        {
            if(vardiyaVarmi == true)
            {
                return temelMaas + (vardiyaSaati * vardiyaUcreti);
            }
            else
            {
                return temelMaas;
            }
        }
    }
    // Namespace içerisinde class tanimlama
    class Meyve1
    {
        // Class içerisinde class tanimlama (nested-type class)
        class Meyve3
        {

        }
    }

    class Ogrenci
    {
        // C#'ta varsayilan erisim belirteci privatetır.
        // public - her yerden erişilebilir
        // private - yalnizca class içinden erişilebilir
        public string ad;
        public string soyad;
        public int yas;
        public double vizeNotu;
        public double odevNotu;
        public double finalNotu;
        public float kilo;
        public float boy;
        public bool cinsiyet;
        
        public double OrtalamaHesapla()
        {            
            double vizeOrt = vizeNotu * 0.3;
            double odevOrt = odevNotu * 0.1;
            double finalOrt = finalNotu * 0.6;
            double genelOrt = vizeOrt + odevOrt + finalOrt;
            return genelOrt;
        }

        public float VKIHesapla()
        {
            return kilo / (boy * boy);
        }
    }

    class Musteri
    {
        // price - Price
        double bakiye;

        public double Bakiye
        {
            get
            {                
                return bakiye*2;
            }
            set
            {
                bakiye = value * 2;
            }
        }
        
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciParola { get; set; }
        public float latitude { get; set; }

    }
    
    internal class Program
    {        
        static void Main(string[] args)
        {
            Ogrenci damla = new Ogrenci();
            damla.ad = "Damla";
            Console.WriteLine(damla.yas);
            /* int yas;
            Console.WriteLine(yas); */
            damla.vizeNotu = 60.5;
            damla.odevNotu = 100;
            damla.finalNotu = 35;
            damla.finalNotu = 35;
            damla.finalNotu = 35;
            damla.finalNotu = 35;
            Console.WriteLine(damla.OrtalamaHesapla());

            Ogrenci batuhan = new Ogrenci();
            batuhan.vizeNotu = 75;
            batuhan.odevNotu = 55;
            batuhan.finalNotu = 65;
            Console.WriteLine(batuhan.OrtalamaHesapla());

            Personel p1 = new Personel();
            p1.temelMaas = 25000;
            p1.vardiyaVarmi = true;
            p1.vardiyaSaati = 12;
            p1.vardiyaUcreti = 250;
            Console.WriteLine(p1.maasHesapla());

            Musteri m1 = new Musteri();
            m1.Bakiye = 500;
            Console.WriteLine(m1.Bakiye);


        }
    }
}
