namespace Hafta3BP
{    
    internal class Program
    {
        #region class içerisinde değişken(field) varsayılan değer
        static string kediIsim;
        static int kediYas;
        static double kediKilo;
        static bool kediCinsiyet;
        #endregion
        static void Main(string[] args)
        {            
            #region Değişkenler
            /*
             Değişken isimlendirme kuralları.
            1- Değişken isimleri rakamla başlayamaz!
            2- C#'ta değişken isimleri büyük-küçük harf duyarlıdır.
            3- Aynı isimde birden fazla değişken olamaz!!!
            4- _ hariç değişken isminde özel karakter(!, *, ?) bulunamaz!
             5- Değişken isimlerinde Türkçe karakter(ö, ğ, ç, ü, İ, ş) kullanmıyoruz.
             6- Değişken isimlerinde boşluk karakteri kullanılamaz!
             7 - Programatik açıdan bir anlam ifade eden kelimeler değişken ismi olarak kullanılamaz!
             8- Tanımlanmış bir değişkene türüne uygun bir değer atanmalıdır.
             */
            /*
             Naming Convention - Değişken İsimlendirme Gelenekleri
            BilecikPlaka - PascalCase
            bilecik_plaka - snake_case
            bilecikPlaka - camelCase 
             */
            int bilecikPlaka;
            int BilecikPlaka;
            // @ operatörü kullanımı
            int @static;
            int @for;
            bilecikPlaka = 11;
            // 38 = kayseriPlaka;
            int kayseriPlaka = 38;
            int sayi1 = 22;
            Console.WriteLine(sayi1);
            // override
            sayi1 = 55;
            sayi1 = 75;
            sayi1 = -105;
            Console.WriteLine(sayi1);
            int sayi2 = 33;
            sayi1 = sayi2; // sayi1 = 33;
            string kelime = "selam";
            string selamla = "Selamlar, \n nasilsin?";
            /* Console.WriteLine("Merhabalar, nasilsin?");
            Console.WriteLine("Merhabalar, nasilsin?");
            Console.WriteLine("Merhabalar, nasilsin?");
            Console.WriteLine("Merhabalar, nasilsin?");
            Console.WriteLine("Merhabalar, nasilsin?"); */
            Console.WriteLine(selamla);
            Console.WriteLine(selamla);
            Console.WriteLine(selamla);
            Console.WriteLine(selamla);
            Console.WriteLine(selamla);
            // bool eHarfi = 'E';
            string sayi3 = "15";
            char basHarf = 'Z';
            char yildizKarakteri = '*';
            char unlemKarakteri = '!';
            string basHarf2 = "Z";
            bool girisYapildimi = false;
            bool yoneticimi = true;
            float piSayisi = 3.14F;
            Console.WriteLine(piSayisi);
            double eSayisi = 2.718D;
            decimal boy= 1.7412345M;
            int bursaPlaka = 999999999;
            #endregion
            #region Tuple ile değer atama
            (string ad, string soyad, int yas, bool akademikPersonelmi) personel = ("Zafer", "SERİN", 30, true);
            Console.WriteLine(personel.ad);
            #endregion
            #region Literals Düzenlemeler
            int milyarDegeri = 1_000_000_000;
            #endregion
            #region Varsayilan Deger
            string kediIsim1 = default(string);
            int kediYas1 = default;
            double kediKilo1 = default;
            bool kediCinsiyet1 = default;

            Console.WriteLine(kediIsim1);
            Console.WriteLine(kediYas1);
            Console.WriteLine(kediKilo1);
            Console.WriteLine(kediCinsiyet1);
            // Console.WriteLine(2/0);
            // NaN -> Not a number
            Console.WriteLine(kediIsim); Console.WriteLine(kediYas);
            Console.WriteLine(kediKilo);
            Console.WriteLine(kediCinsiyet);
            #endregion
            #region Faaliyet Alani(Scope)
            {
                int PMYOKurulusYili = 1994;
                Console.WriteLine(PMYOKurulusYili);
                {
                    Console.WriteLine(PMYOKurulusYili);
                    {
                        Console.WriteLine(PMYOKurulusYili);
                        {
                            string renk = "Kirmizi";
                            Console.WriteLine(PMYOKurulusYili);
                            Console.WriteLine(renk);                            
                        }
                        // Console.WriteLine(renk);
                    }
                }
                {
                    Console.WriteLine(PMYOKurulusYili);
                }
            }
            #endregion
            #region Faaliyet Alani 2
            int sayi4 = 25;
            {
                int sayi5 = 55;
                Console.WriteLine(sayi4);
            }
            // Console.WriteLine(sayi5);
            #endregion
            #region Değişmeyenler
            // constant - sabit
            const double pi_sayisi = 3.1415;
            // const double e_sayisi;
            // e_sayisi = 2.718;
            // pi_sayisi = 65.4;
            // Console.WriteLine(pi_sayisi);
            // pi_sayisi = pi_sayisi * 2;
            // Console.WriteLine(pi_sayisi * 2);
            #endregion
            #region Değişken Atama Varyasyonu
            int sayi6 = 27, sayi7 = 35;
            int sayi8, sayi9;
            #endregion
            #region Object Kavrami
            int kopekYas = 2;
            Console.WriteLine(kopekYas * 2);
            string kopekAd = "Karabas";
            bool kopekCinsiyet = false;
            double kopekKilo = 10.5;
            // Console.WriteLine("Zafer" * 2);
            // Boxing - Kutulama
            object kopekYas1 = 2;
            Console.WriteLine((string)kopekYas1);
            object kopekAd1 = "Karabas";
            object kopekCinsiyet1 = false;
            object kopekKilo1 = 10.5;
            #endregion
            #region var(variable) ifadesi
            var kopekYas2 = 2;
            // kopekYas2 = "selam";
            Console.WriteLine(kopekYas2 * 2);
            var kopekAd2 = "Karabas";
            var kopekCinsiyet2 = false;
            var kopekKilo2 = 10.5;
            #endregion
            #region dynamic ifadesi
            dynamic kopekYas3 = 2;
            kopekYas3 = "selam";
            dynamic kopekAd3 = "Karabas";
            dynamic kopekCinsiyet3 = false;
            dynamic kopekKilo3 = 10.5;
            #endregion
            #region Tamsayi değişken türleri
            byte deger1 = 255;
            short deger2 = 32000;
            int deger3 = 155_000;
            long deger4 = 9999999999;
            #endregion
        }
    }
}
