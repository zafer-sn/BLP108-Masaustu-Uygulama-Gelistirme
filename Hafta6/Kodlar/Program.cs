namespace Hafta6BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler-1
            // degisken_tipi[] dizinin_adi = new degisken_tipi[eleman_sayisi];
            int[] yaslar1 = new int[5];
            yaslar1[4] = 20;
            Console.WriteLine(yaslar1[3]);
            Console.WriteLine(yaslar1[4]);
            try
            {
                Console.WriteLine(yaslar1[5]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata var: {ex.Message}");         
            }            
            Console.WriteLine("Uygulama devam ediyor");
            #endregion
            #region Dizi Tanımlama Varyasyonları-1
            int[] yaslar2 = {20, 19, 18, 22, 25};
            Console.WriteLine(yaslar2[4]);
            #endregion
            #region Dizi Tanımlama Varyasyonları-2
            double[] yaslar3 = new double[] {3.14, 2.71, 5.67};
            #endregion
            #region Dizi Tanımlama Varyasyonları-3
            string[] isimler = new string[2] {"Zafer", "Ahmet"};
            #endregion
            #region Dizi elemanlarına tek tek erişme
            int[] plakalar = {11, 15, 22, 53, 81, 57};
            for(int i = 0; i < plakalar.Length; i++)
            {
                Console.WriteLine(plakalar[i]);
            }
            #endregion
            #region Ornek-1
            /* Kullanıcıdan 5 tane tamsayı değeri alıp bunları
             * bir diziye atayın ve dizinin ortalamasını bulun */
            /*int[] ortalamaAlinacakDizi = new int[5];
            int toplam = 0;
            for(int i = 0; i < ortalamaAlinacakDizi.Length; i++)
            {
                Console.Write($"Lütfen {i}. dizi elemanını giriniz..:");
                ortalamaAlinacakDizi[i] = int.Parse(Console.ReadLine());
                toplam = toplam + ortalamaAlinacakDizi[i]; // toplam += ortalamaAlinacakDizi[i];
            }
            Console.WriteLine($"Dizinin Ortalaması: {toplam/ortalamaAlinacakDizi.Length}");*/
            #endregion
            #region for-each
            double[] ondalikliSayilar = { 1.12, 2.27, 5.67 };
            foreach(double ondalikliSayi in ondalikliSayilar)
            {
                Console.WriteLine(ondalikliSayi);
            }
            #endregion
            #region Metot Çağrımları
            selamla();
            topla(3, 5);
            Console.WriteLine(carp() * 2);
            Console.WriteLine(fonksiyon(1, 1));
            #endregion
            #region Asal Metot Çağrımları
            Console.WriteLine(asalmi(88)); // False
            Console.WriteLine(asalmi(32)); // False
            Console.WriteLine(asalmi(53)); // True
            Console.WriteLine(asalmi(11)); // True
            #endregion
            #region Math classı Metotları
            Console.WriteLine(Math.Floor(2.8)); // Verilen sayıyı aşağıya yuvarlar
            Console.WriteLine(Math.Ceiling(2.2)); // Verilen sayıyı yukarıya yuvarlar
            Console.WriteLine(Math.Round(2.2)); // Verilen sayıyı yakın olan sayıya yuvarlar
            Console.WriteLine(Math.Round(2.7)); // Verilen sayıyı yakın olan sayıya yuvarlar
            Console.WriteLine(Math.Round(2.5)); // Verilen sayıyı yakın olan sayıya yuvarlar
            Console.WriteLine(Math.Abs(-3.7)); // Verilen sayının mutlak değerini alır.
            Console.WriteLine(Math.Abs(4.2)); // Verilen sayının mutlak değerini alır.
            Console.WriteLine(Math.Pow(2, 3)); // Üs almayı sağlar.
            Console.WriteLine(Math.Pow(-5, 2)); // Üs almayı sağlar.
            Console.WriteLine(Math.Sqrt(25)); // Karekök almayı sağlar.
            Console.WriteLine(Math.Sqrt(144)); // Karekök almayı sağlar.
            #endregion
            #region Rastgele Sayı Üretimi
            Random rastgele = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("---------------------");
                int r = rastgele.Next(0, 101);
                Console.WriteLine(r);
            }

            #endregion
            #region Sayı Tahmin Oyunu
            /*
             0 ile 100 arasında rastgele bir sayı üretin.
             Kullanıcı bu sayıyı tahmin ederek bulmaya çalışsın.
             Eğer kullanıcı rastgele sayıdan daha küçük bir sayı tahmin ederse daha büyük bir sayı tahmin et gibi bir uyarı versin
             Eğer kullanıcı rastgele sayıdan daha büyük bir sayı tahmin ederse daha küçük bir sayı tahmin et gibi bir uyarı versin
             Kullanıcı kaç tahminde sonucu buldu hesaplatın.
             */
            Random tahmin = new Random();
            int t = tahmin.Next(0, 101);
            int sayac = 0;
            while(true)
            {
                int kullaniciTahmini = int.Parse(Console.ReadLine());
                if(kullaniciTahmini == t)
                {
                    sayac++;
                    Console.WriteLine("Tebrikler doğru tahmin ettiniz!");
                    break;
                } else if(kullaniciTahmini < t)
                {
                    sayac++;
                    Console.WriteLine("Lütfen daha büyük bir sayı giriniz.");
                } else if(kullaniciTahmini > t)
                {
                    sayac++;
                    Console.WriteLine("Lütfen daha küçük bir sayı giriniz.");
                }
            }
            Console.WriteLine($"{sayac} denemede doğru buldunuz!");




            #endregion
        }
        #region Metotlar
        /*
         1-> Parametre almayan ve değer döndürmeyen(void) metot
         2-> Parametre alan ve değer döndürmeyen(void) metot
         3-> Parametre almayan ve değer döndüren metot
         4-> Parametre alan ve değer döndüren metot

        erişim_belirteci dönüş_değeri metot_adi(varsa parametreler) -> İmzası
        {
         // Metodun yapacağı işlemler
         // Gövdesi
        }
        Static bir metot içerisinde sadece ve sadece yine static metotlar çağrılabilir.         
         */
        #endregion
        #region 1. Tipte Metot
        public static void selamla()
        {
            Console.WriteLine("Selam");
        }
        #endregion
        #region 2. Tipte Metot
        public static void topla(int x, int y)
        {
            Console.WriteLine($"Toplam: {x+y}");
        }
        #endregion
        #region 3. Tipte Metot
        public static int carp()
        {
            return 5 * 3;
        }
        #endregion
        #region 4. Tipte Metot
        private static double fonksiyon(double x, double y)
        {
            Console.WriteLine("Fonksiyon Hesaplanıyor.");
            return ((3 * x * y * y) + 7) / 25;
        }
        #endregion
        #region Asal sayi bulan
        // Bir metoda bir sayı parametresi yollayalım bize bu sayı asal mı değil mi söylesin
        public static bool asalmi(int sayi)
        {            
            bool gelenDegerAsalmi = true;
            for (int i = 2; i < sayi; i++)
            {
                if(sayi % i == 0)
                {
                    gelenDegerAsalmi = false;
                    break;
                }
            }
            return gelenDegerAsalmi;
        }
        #endregion
    }
}
