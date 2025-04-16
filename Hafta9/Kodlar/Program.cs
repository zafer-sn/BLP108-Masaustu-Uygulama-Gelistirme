// namespace dışında class tanımlama
class Ogrenci3
{

}

namespace Hafta9BP
{
    // namespace içinde class tanımlama
    class Ogrenci1
    {
        // class içinde class tanımlama(Nested Type)
        class Ogrenci2
        {

        }
    }

    public class Ogrenci
    {
        /*
        public -> Her yerden erişilebileceği anlamına gelir
        private -> Sadece ilgili class içerisinden erişilebilir
        protected
        internal
        private protected
        protected internal         
        Not: C#'ta varsayılan erişim belirteci private'tır.
         */
        public int yas;
        char cinsiyet;
        string isim;
        string bolum;
        string girisYili;
        string memleket;
        double boy;
        double kilo;
        bool gectimi;
        public double vizeNotu;
        public double odevNotu;
        public double finalNotu;

        public void OrtalamaHesapla()
        {
            double ortalama = vizeNotu * 0.3 + odevNotu * 0.1 + finalNotu * 0.6;
            Console.WriteLine(ortalama);
        }
    }

    class Sekil
    {
        public int a, b, c, d;

        public double CevreHesapla()
        {
            return a + b + c + d;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // string isim = 'selam';
            // char basHarf = 'Z';
            // Referans oluşturma
            Ogrenci ogr1;
            // Bir nesne üretmek için new anahtar sözcüğünü kullanırız.
            ogr1 = new Ogrenci();
            Console.WriteLine(ogr1.yas);
            ogr1.vizeNotu = 10;
            ogr1.odevNotu = 20;
            ogr1.finalNotu = 50;
            ogr1.OrtalamaHesapla();
            Ogrenci ogr2 = new Ogrenci();
            Ogrenci ogr3 = new Ogrenci();

            Console.Write("Lütfen şekli giriniz(Dikdortgen, Yamuk, Paralelkenar)..:");
            string sekil = Console.ReadLine();
            switch (sekil)
            {
                case "Dikdortgen":
                    Sekil dikdortgen = new Sekil();
                    Console.Write("A kenarını giriniz..:");
                    dikdortgen.a = int.Parse(Console.ReadLine());
                    Console.Write("B kenarını giriniz..:");
                    dikdortgen.b = int.Parse(Console.ReadLine());
                    Console.Write("C kenarını giriniz..:");
                    dikdortgen.c = int.Parse(Console.ReadLine());
                    Console.Write("D kenarını giriniz..:");
                    dikdortgen.d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Dikdortgenin cevresi: {dikdortgen.CevreHesapla()}");
                    break;
                case "Yamuk":
                    Sekil yamuk = new Sekil();
                    Console.Write("A kenarını giriniz..:");
                    yamuk.a = int.Parse(Console.ReadLine());
                    Console.Write("B kenarını giriniz..:");
                    yamuk.b = int.Parse(Console.ReadLine());
                    Console.Write("C kenarını giriniz..:");
                    yamuk.c = int.Parse(Console.ReadLine());
                    Console.Write("D kenarını giriniz..:");
                    yamuk.d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Dikdortgenin cevresi: {yamuk.CevreHesapla()}");
                    break;
                case "Paralelkenar":
                    Sekil paralelkenar = new Sekil();
                    Console.Write("A kenarını giriniz..:");
                    paralelkenar.a = int.Parse(Console.ReadLine());
                    Console.Write("B kenarını giriniz..:");
                    paralelkenar.b = int.Parse(Console.ReadLine());
                    Console.Write("C kenarını giriniz..:");
                    paralelkenar.c = int.Parse(Console.ReadLine());
                    Console.Write("D kenarını giriniz..:");
                    paralelkenar.d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Dikdortgenin cevresi: {paralelkenar.CevreHesapla()}");
                    break;
                default:
                    break;
            }
        }
        // Bir tane Sekil classı oluşturun
        // Bu classtan 3 tane nesne üretin(ParalelKenar, Yamuk, Dikdortgen)
        // Class içinde ilgili seklin çevresini hesaplayan bir metot olsun
        // Kenar değerleri kullanıcı tarafından girilsin.
        // Hangi şeklin oluşturulacağı kullanıcı tarafından seçilsin
    }
}
