namespace Hafta7BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch-Case-1            
            int kontrolDegeri = 10;
            switch(kontrolDegeri)
            {
                case 1:
                Console.WriteLine("Selam");
                break;
                case 10:
                Console.WriteLine("10dur");
                break;
            }            
            
            // int tamSayi = "selam";
            Console.Write("Lutfen bir plaka giriniz..:");
            int plaka = int.Parse(Console.ReadLine());
            switch(plaka)
            {
                case 1:
                    Console.WriteLine("Adana");
                    break;
                default:
                    Console.WriteLine("Hicbirisi degil");
                    break;
                case 2:
                    Console.WriteLine("Adıyaman");
                    break;
                case 34:
                    Console.WriteLine("İstanbul");
                    object bursaPlaka = 16;
                    Console.WriteLine((int)bursaPlaka * 2);
                    break;
                case 11:
                    Console.WriteLine("Bilecik");
                    break;
            }
            #endregion
            #region Switch-Case-2
            string gun = "pazartesi";
            // const - constant
            const string friday = "cuma";
            switch(gun)
            {
                case "pazartesi":
                    Console.WriteLine(1);
                    // Bad practice
                    // Best practice
                    goto case "cumartesi";
                case "sali":
                    Console.WriteLine(2);
                    break;
                case "carsamba":
                    Console.WriteLine(3);
                    break;
                case "persembe":
                    Console.WriteLine(4);
                    break;
                case friday:
                    Console.WriteLine(5);
                    break;
                case "cumartesi":
                    Console.WriteLine(6);
                    break;
                case "pazar":
                    Console.WriteLine(7);
                    break;
            }
            #endregion
            #region Switch-Case-3-Switch-Expressions
            Console.Write("Ortalamanizi giriniz..:");
            double ortalama = double.Parse(Console.ReadLine());
            Console.Write("Final notunuzu giriniz..:");
            double finalNotu = double.Parse(Console.ReadLine());
            string gecmeDurumu = ortalama switch
            {
                >= 45.0 when (finalNotu >= 50.0) => "Gecti",
                < 45.0 when (finalNotu < 50.0) => "Kaldi",
                < 45.0 when (finalNotu >= 50.0) => "Kaldi",
                > 45.0 when (finalNotu < 50.0) => "Kaldi",
                _ => "Deger gecerli degil"
            };
            Console.WriteLine(gecmeDurumu);
            /*
            switch(ortalama)
            {
                case > 45
            }*/
            #endregion
            #region Switch-Case-4
            string renk = "kirmizi";
            bool deger = 3 > 5; // 3<5 olsa idi Renk kırmızıdır yazardı.
            switch (renk)
            {
                case "kirmizi" when deger:
                    Console.WriteLine("Renk kırmızıdır");
                    break;
                case "sari":
                    Console.WriteLine("Renk sarıdır");
                    break;
            }
            Console.WriteLine("Kod devam ediyor...");
            #endregion
            #region Switch-Case-Expressions-2
            string havaDurumu = "parcali bulutlu";
            string tavsiye = havaDurumu switch
            {
                "yagmurlu" => "Semsiye al",
                "bulutlu" => "Daha iyi giyin",
                "karli" => "Cok sıkı giyin",
                _ => "Böyle bir hava durumu yok"
            };
            Console.WriteLine(tavsiye);
            #endregion
            #region ifyapisi
            /*
             if()
            {

            }
             */
            if (true)
            {
                Console.WriteLine("Kosul saglandi!");
            }
            bool girisYapildimi = false; // true olsaydı yazmazdı
            if (!girisYapildimi)
            {
                Console.WriteLine("Giris basarili!");
            }
            #endregion
            #region ifYapisi2
            Console.Write("Lutfen yasinizi giriniz..:");
            int yas = Convert.ToInt32(Console.ReadLine());
            if(yas >= 18 && yas <= 100)
            {
                Console.WriteLine("Ehliyet alabilir.");
            }
            else if (yas >= 15 && yas < 18)
            {
                Console.WriteLine("Kısıtlı ehliyet alabilir");
            }
            if (yas >= 0 && yas < 18)
            {
                Console.WriteLine("Ehliyet alamaz!");
            }
            else
            {
                Console.WriteLine("Geçerli bir yaş değeri değil");
            }
            Console.WriteLine("Kod devam ediyor...");
            #endregion
            #region ifYapisi3
            bool lisedenMezunmu = true;
            bool yksKazandimi = false;
            // lisedenMezunmu direk yazılırsa bu değer lisedenMezunmu==true ya denktir
            Console.WriteLine("Merhaba");
            if (lisedenMezunmu)
            {
                Console.WriteLine("Liseden mezun olmuş");
                if (yksKazandimi == true)
                {
                    Console.WriteLine("Liseden mezun olmuş ve yksyi kazanmış");
                }
                else
                {
                    Console.WriteLine("Liseden mezun olmuş ama yksyi kazanamamış");
                }
            }
            else
            {
                Console.WriteLine("Liseden mezun olamamış");
            }
            #endregion
            #region ifYapisi4
            double suDerece = 25.0;
            if (suDerece >= 100.0)
                Console.WriteLine("Su kaynamaya başladı");
            else
                Console.WriteLine("Su henüz kaynamıyor");
            #endregion
            #region Type Pattern
            object kayseriPlaka = "38";
            if (kayseriPlaka is int kayseriPlakaI)
            {
                Console.WriteLine(kayseriPlakaI * 2);
            }
            else
            {
                Console.WriteLine(int.Parse((string)kayseriPlaka) * 5);
            }
            #endregion
            #region Constant Pattern
            object izmirPlaka = 35;
            if (izmirPlaka is 35) // ==
            {
                Console.WriteLine("Deger dogru");
            }
            else
            {
                Console.WriteLine("Deger yanlis");
            }
            #endregion
            #region Ornek1
            Console.Write("Sayi1 i giriniz..:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Sayi2 i giriniz..:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Sayi3 i giriniz..:");
            int sayi3 = int.Parse(Console.ReadLine());
            int enBuyuk = sayi1;
            if(sayi2 > enBuyuk)
            {
                enBuyuk = sayi2;
            }
            if(sayi3 > enBuyuk)
            {
                enBuyuk = sayi3;
            }
            Console.WriteLine($"Girilen en buyuk sayi: {enBuyuk}");
            #endregion
            #region Hataların Ele Alınması
            try
            {
                Console.Write("Lutfen sayi giriniz..:");
                int sayiDegeri = int.Parse(Console.ReadLine());
                int deger1 = 10;
                int deger2 = 5;
                Console.WriteLine(deger1 / deger2);
                string isim = "Zafer";
                // int? deger3 = null;
                Console.WriteLine(isim.ToString());
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"Sıfıra bölme hatası: {dbze.Message}");
            }
            catch (FormatException fe)
            {
                // İngiliz anahtarı property
                Console.WriteLine($"Bir hata olustu: {fe.Message}");
            }
            /*catch(NullReferenceException nre)
            {
                Console.WriteLine($"Bir hata olustu: {nre.Message}");
            }*/
            catch (Exception e)
            {
                Console.WriteLine($"Bilinmeyen bir hata oluştu {e.Message}");
            }
            finally
            {
                Console.WriteLine("Ne olursa olsun çalışır");
            }
            Console.WriteLine("Kod devam ediyor...");
            #endregion
        }
    }
}
