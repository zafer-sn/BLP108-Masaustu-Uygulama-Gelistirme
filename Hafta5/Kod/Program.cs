namespace Hafta6BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console.ReadLine() Kullanimi
            /* Console.Write("Lutfen bir sayi giriniz..:");
            int sayi1 = int.Parse(Console.ReadLine());
            // string isim = 11;
            Console.Write("Lutfen bir sayi giriniz..:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            // stringlerde + operatörü concat işlemi yapar -> concatenation - birleştirme
            Console.WriteLine(sayi1 + sayi2); */
            #endregion
            #region $ İşareti Kullanımı
            string isim = "Zafer";
            int dogumYili = 1995;
            Console.WriteLine($"Benim adim {isim}, yasim {2026-dogumYili}");
            #endregion
            #region Aritmetik Operatörler
            Console.WriteLine(5+3); // 8
            Console.WriteLine(5-3); // 2
            Console.WriteLine(5*3); // 15
            Console.WriteLine(5/3); // 1
            Console.WriteLine(5.0/3.0); // 1,...
            Console.WriteLine(5%3); // 2
            Console.WriteLine(11%7); // 4
            Console.WriteLine(23%5); // 3
            Console.WriteLine(37%2); // 1
            Console.WriteLine(35%7); // 0
            #endregion
            #region Karsilastirma Operatörleri
            Console.WriteLine(5 > 3); // true
            Console.WriteLine(3 >= 3); // true
            Console.WriteLine(3 > 3); // false
            Console.WriteLine(2 < 7); // true
            Console.WriteLine(-2 < -9); // false
            Console.WriteLine(3.5 > 2.7); // true
            Console.WriteLine(5 == 5); // true
            Console.WriteLine(7 == 5); // false
            Console.WriteLine(3 != 3); // false
            Console.WriteLine(8 != 5); // true
            #endregion
            #region Mantıksal Operatörler
            Console.WriteLine("-------------Mantıksal Operatörler---------------");
            Console.WriteLine(true && false); // false
            Console.WriteLine(true && true); // true
            Console.WriteLine(false || true); // true
            Console.WriteLine((false ^ true)|| true); // true
            Console.WriteLine((false && true)|| (true ^ false)); // true
            Console.WriteLine((false && true || true) ^ (false || true) && true); // true ^ true && true - false
            Console.WriteLine((5!=5) && true || (2 != 2) ^ false); // false && true || false ^ false
            Console.WriteLine(3 | 5);
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            #endregion
            #region İşlem Önceliği
            Console.WriteLine((3+5)*4);
            // 8/4*8+9-4 = 21
            Console.WriteLine((5+3)/4 * 8 + (2+7) - 4); // 20, 70, 21, 
            #endregion
            #region Artirma ve Azaltma Operatörleri
            Console.WriteLine("*********************************");
            int istanbulPlaka = 34;
            Console.WriteLine(istanbulPlaka++); // 34
            Console.WriteLine(++istanbulPlaka); // 36
            istanbulPlaka--;
            ++istanbulPlaka;
            Console.WriteLine(--istanbulPlaka); // 35

            int konyaPlaka = 42;
            Console.WriteLine(--konyaPlaka); // 41
            Console.WriteLine(konyaPlaka--); // 41
            Console.WriteLine(konyaPlaka++); // 40
            konyaPlaka--;
            ++konyaPlaka;
            Console.WriteLine(++konyaPlaka); // 42

            int adanaPlaka = 1;
            ++adanaPlaka; 
            adanaPlaka--;
            Console.WriteLine(adanaPlaka++); // 1
            adanaPlaka--;
            --adanaPlaka;
            Console.WriteLine(--adanaPlaka); // -1
            Console.WriteLine(adanaPlaka--); // -1
            Console.WriteLine(--adanaPlaka); // -3
            #endregion
            #region Üzerine Ekleme ve Yığma Operatörleri
            int giresunPlaka = 28;
            Console.WriteLine(giresunPlaka);
            giresunPlaka = giresunPlaka + 10; // giresunPlaka += 10;
            Console.WriteLine(giresunPlaka);

            int trabzonPlaka = 61;
            Console.WriteLine(trabzonPlaka); // 61
            trabzonPlaka -= 10;
            Console.WriteLine(trabzonPlaka); // 51
            trabzonPlaka += 5;
            Console.WriteLine(trabzonPlaka); // 56
            trabzonPlaka *= 2;
            Console.WriteLine(trabzonPlaka); // 112
            trabzonPlaka %= 4; // trabzonPlaka = trabzonPlaka % 4;
            Console.WriteLine(trabzonPlaka); // 0
            #endregion
            #region sizeOf Operatörü
            int marasPlaka = 46;
            // Console.WriteLine(sizeof(marasPlaka));
            Console.WriteLine(sizeof(int) * 4); // 16
            Console.WriteLine(sizeof(long)); // 8
            Console.WriteLine(sizeof(short)); // 2
            Console.WriteLine(sizeof(byte)); // 1
            Console.WriteLine(sizeof(double)); // 8
            Console.WriteLine(sizeof(float)); // 4
            #endregion
            #region typeOf Operatörü
            Console.WriteLine("---------------typeOf-----------------");
            double piSayisi = 3.14;
            Type tip = typeof(string);
            Console.WriteLine(tip.Name);
            Console.WriteLine(tip.IsPrimitive);
            Console.WriteLine(tip.IsValueType);

            Type tip2 = typeof(int);
            Console.WriteLine(tip2.FullName);
            Console.WriteLine(tip2.IsPrimitive);
            Console.WriteLine(tip2.IsValueType);
            #endregion
            #region is ve is null operatörü
            object sakaryaPlaka = 54;
            Console.WriteLine(sakaryaPlaka is int); // true
            Console.WriteLine(sakaryaPlaka is short); // false
            Console.WriteLine((int)sakaryaPlaka * 2);

            // int bingolPlaka = null;
            string ad = "Zafer";
            Console.WriteLine(ad is null); // false eğer null ise true
            #endregion
            #region ? operatörü
            int? duzcePlaka = 81;
            Console.WriteLine(duzcePlaka is null);
            #endregion
            #region as operatörü
            object batmanPlaka = "selam";
            // Console.WriteLine((int)batmanPlaka);
            //int? batmanPlakaInt = batmanPlaka as int?;
            //Console.WriteLine(batmanPlakaInt * 2);
            // Console.WriteLine((int)batmanPlaka);
            Console.WriteLine(batmanPlaka as object);

            string soyisim = "SERİN";
            Console.WriteLine(soyisim as string);
            #endregion
            #region ?? ve ??= Operatörü
            int? afyonPlaka = null;
            Console.WriteLine(afyonPlaka ?? 3);

            int? erzurumPlaka = null;
            Console.WriteLine(erzurumPlaka ??= 25);
            #endregion
        }
    }
}
