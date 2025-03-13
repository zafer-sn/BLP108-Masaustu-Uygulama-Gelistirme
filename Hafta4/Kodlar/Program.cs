namespace Hafta4BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console.ReadLine() Kullanımı
            Console.Write("Lütfen 1.sayiyi giriniz..:");
            // int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2.sayiyi giriniz..:");
            // int sayi2 = int.Parse(Console.ReadLine());
            // stringlerde + operatörü concatenate(concat) - birleştirme işlemi yapar.
            // Console.WriteLine($"Toplam sonucu: {sayi1 + sayi2}");
            #endregion
            #region Aritmetik Operatörler
            Console.WriteLine();
            Console.WriteLine(5+3); // 8
            Console.WriteLine(5-3); // 2
            Console.WriteLine(5*3); // 15
            Console.WriteLine(5/3); // 1
            Console.WriteLine(5%3); // 2
            Console.WriteLine(17%5); // 2
            Console.WriteLine(27%6); // 3
            Console.WriteLine(41%7); // 6
            #endregion
            #region Karşılaştırma Operatörleri
            Console.WriteLine(5 > 7); // False
            Console.WriteLine(5 >= 5); // True
            Console.WriteLine(5 > 5); // False
            Console.WriteLine(5 == 5); // True
            Console.WriteLine(5 != 5); // False
            Console.WriteLine(7 != 10); // True
            #endregion
            #region Mantıksal Operatörler
            /*
             && -> VE -> AND -> AND Gate -> Matematiksel olarak çarpma işlemine karşılık gelir
            x y z
            0 0 0 
            0 1 0
            1 0 0
            1 1 1
            1 -> true
            0 -> false
             */
            Console.WriteLine(true && false); // False
            Console.WriteLine(true && true); // True

            /*
             || -> VEYA -> OR -> OR Gate -> Matematiksel olarak toplama işlemine karşılık gelir
            x y z
            0 0 0 
            0 1 1
            1 0 1
            1 1 1
            1 -> true
            0 -> false
             */
            Console.WriteLine(true || false); // True
            Console.WriteLine(true || true); // True

            Console.WriteLine((true || false) && true); // True

            /*
             ^ -> ÖZEL VEYA -> X-OR -> X-OR Gate -> Matematiksel olarak bir karşılığı yok, Girişler farklıysa sonuç 1
            x y z
            0 0 0 
            0 1 1
            1 0 1
            1 1 0
            1 -> true
            0 -> false
             */
            Console.WriteLine(true ^ false); // True
            Console.WriteLine(true ^ true); // False

            /*
             10 -> 1010
             5  -> 0101
             &  -> 0000 -> 0
             |  -> 1111 -> 15
             */
            Console.WriteLine(10 & 5); // 0
            Console.WriteLine(10 | 5); // 15
            #endregion
            #region İşlem Önceliği
            Console.WriteLine((3+7)*2);
            #endregion
            #region Fahrenhayt Hesabı
            Console.Write("Lütfen Fahrenhayt değerini giriniz..:");
            // double fahrenhayt = double.Parse(Console.ReadLine());
            // Console.WriteLine($"Derece değeri: {(fahrenhayt-32)/1.8}");
            #endregion
            #region Denklem Hesabı
            Console.Write("Lütfen x değerini giriniz..:");
            // float x = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine($"Sonuç: {10/(5-x+2)}");
            #endregion
            #region try-catch-finally bloğu
            Console.WriteLine();
            int sayi1 = 10;
            int sayi2 = 0;
            try
            {
                Console.WriteLine(sayi1 / sayi2);
                Console.WriteLine("Selam");
            }
            // İndis dışarıda hatası
            catch(IndexOutOfRangeException iore)
            {
                Console.WriteLine(iore.Message);
            }
            // Sıfıra bölme hatası
            catch(DivideByZeroException dbze)
            {
                Console.WriteLine($"Hata: {dbze.Message}");
            }
            // Boş değer hatası
            catch(NullReferenceException nrfe)
            {
                Console.WriteLine(nrfe.Message);
            }
            // En genel hata
            catch (Exception ex)
            {
                Console.WriteLine("Hatalı bölme işlemi");
            }
            finally 
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            #endregion
            #region 1 Artırma - Azaltma Operatörleri
            int bilecikPlaka = 11;
            bilecikPlaka++;
            Console.WriteLine(bilecikPlaka);

            int istanbulPlaka = 34;
            ++istanbulPlaka;
            Console.WriteLine(istanbulPlaka);

            int aydinPlaka = 9;
            Console.WriteLine(++aydinPlaka);
            // ++ veya -- operatörleri değişkenin soluna yazılırsa o satırda ilgili işlem yapılır
            // ++ veya -- operatörleri değişkenin sağına yazılırsa bir sonraki satırda ilgili işlem yapılır
            int kütahyaPlaka = 43;
            kütahyaPlaka++; // kütahyaPlaka = 43
            ++kütahyaPlaka; // kütahyaPlaka = 44 -> kütahyaPlaka 45
            Console.WriteLine(--kütahyaPlaka); // 44
            kütahyaPlaka--;
            Console.WriteLine(kütahyaPlaka); // 43
            #endregion
            #region Üzerine Ekleme-Yığma operatörleri
            int konyaPlaka = 42;
            konyaPlaka = konyaPlaka + 10; // 52
            Console.WriteLine(konyaPlaka);

            int bursaPlaka = 16;
            bursaPlaka += 10; // bursaPlaka = bursaPlaka + 10
            bursaPlaka -= 20;
            bursaPlaka *= 2;
            bursaPlaka /= 2;
            bursaPlaka %= 4;
            Console.WriteLine(bursaPlaka);
            #endregion
            #region sizeof Operatörü
            Console.WriteLine(sizeof(int)); // Int32 -> 32 bit / 8 bit 1 byte
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(char));
            // Console.WriteLine(sizeof(string)); // string -> referans tipli değişken -> hata verir
            int sizeofDeger = 11;
            // Console.WriteLine(sizeof(sizeofDeger)); -> hata verir
            #endregion
            #region typeof Operatörü
            Type t1 = typeof(int);

            Console.WriteLine(t1.Attributes);
            Type t2 = typeof(string);
            Console.WriteLine(t2.FullName);
            #endregion
            #region is ve is null operatörleri
            object izmirPlaka = 35;
            Console.WriteLine(izmirPlaka is int); // double olarak çıkarılamaz

            // int mardinPlaka = null;
            string isim = "Zafer";
            Console.WriteLine(isim is null);
            #endregion
            #region as Operatörü
            object isimYeni = 15;
            Console.WriteLine((int)isimYeni * 2);

            object isimYepYeni = "16";
            Console.WriteLine(isimYepYeni as string); // cast'ten farkı dışarı çıkaramazsa null değer atar.
            #endregion
            #region Değer tipli bir değişkeni null yapma
            int? deger1 = null; // nullable
            double? deger2 = null; // nullable
            #endregion
            #region ?? Operatörü
            string okulAdi = "PMYO"; // string okulAdi = null;
            Console.WriteLine(okulAdi ?? "BŞEÜ");
            #endregion
            #region ??= Operatörü
            string renk = "Kirmizi"; // string renk = null;
            Console.WriteLine(renk ??= "Yeşil");
            Console.WriteLine(renk);
            #endregion
        }
    }
}
