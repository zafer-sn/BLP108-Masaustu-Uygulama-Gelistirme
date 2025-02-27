// Tek satırlı yorum satırı
/*
 Çok satırlı
yorum satırı
 */

/*
 namespace içerisinde classların bulunduğu bir yapıdır.
 */
namespace Hafta2BP
{
    /*
     internal bir erişim belirtecidir.
    internal ile işaretlenen classa aynı proje içerisindeki her yerden erişilebilir
     class bir şablon gibi düşünülebilir. Bu şablon kullanılarak aynı şablona uygun pek çok yapı oluşturulabilir.
     */
    internal class Program
    {
        /*
         static ilgili bellek alanında kendine özel bir ayırır.
        void bir fonksiyonun/metodun değer döndürmeyeceğini belirtir
        () fonksiyonun parametrelerini belirtir.
         */
        static void Main(string[] args)
        {
            #region Hafta2 Örnekleri
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(args[0]);
            #endregion

            #region Hesap Makinesi

            #endregion
            //todo Buradan sonrasını Zeliha yapacak.
            Console.WriteLine("Merhaba Dünya!");

            // degiskenTipi degiskenAdi;
            int bilecikPlaka;
            bilecikPlaka = 11;
            Console.WriteLine(bilecikPlaka);

            short istanbulPlaka = 34;
            Console.WriteLine(istanbulPlaka);

            long sinopPlaka = 57;
            Console.WriteLine(sinopPlaka);

            byte deger = 120;
            Console.WriteLine(deger);

            string isim = "Zafer wsgs//889h32hsdsg..!!!adfhıahhabjfBhhbdsgs";
            Console.WriteLine(isim);

            char basHarf = 'Z';

            double piSayisi = 3.14;
            float eSayisi = 2.718f;
            decimal cevre = 5.6784m;

            int tamsayi1 = 11;
            int tamsayi2 = 6;
            tamsayi2 = tamsayi1; // tamsayi1 = 6;
            Console.WriteLine(tamsayi1);
            Console.WriteLine(tamsayi2);

            bool girisYaptimi = true;

            /*
             Değişken isimlendirme kuralları
            1- Değişken isimlerinde Türkçe karakter kullanmıyoruz.
            2- Değişken isimlerinde özel karakter kullanılamaz. _ hariç
            3- C# büyük-küçük harf duyarlı bir dildir.
            4- Değişkenler sayi ile başlayamaz!
            5- C# için özel anlam ifade eden keyword(anahtar sözcükler) doğrudan değişken adı olarak verilemez!
             */
            int tamsay_i4 = 56;
            int Tamsay_i4 = 56;
            int @for = 5;
















           




        }
    }
}
