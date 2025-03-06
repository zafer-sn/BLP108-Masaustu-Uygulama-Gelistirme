namespace Hafta3BP{
    // 1
    internal class Program
    {
        // 2
        // static int degisken2;
        static void Main(string[] args)
        {
            // 3
            #region Tuple ile değişken atama
            (string isim, int yas) kisiBilgileri = ("Zafer", 29) ;
            kisiBilgileri.isim = "Ahmet";
            Console.WriteLine(kisiBilgileri.isim);
            #endregion
            #region Literals Düzenleme
            int milyarDegeri = 1_000_000_000;
            Console.WriteLine(milyarDegeri);
            #endregion
            #region Varsayılan Değer Atama
            // int intDefDeger;
            int intDef = default;
            string strDef = default;
            double doubleDef = default;
            bool boolDef = default;
            Console.WriteLine(intDef);
            Console.WriteLine(strDef);
            Console.WriteLine(doubleDef);
            Console.WriteLine(boolDef);
            // Console.WriteLine(degisken2);
            #endregion
            #region Değişkenlerin Faaliyet Alanları(Scope)
            int bilecikPlaka = 11;
            {
                // 4
                Console.WriteLine(bilecikPlaka);
                {
                    // 5
                    int istanbulPlaka = 34;
                }
                {
                    // 6
                    string okulAdi = "PMYO";
                    {
                        Console.WriteLine(okulAdi);
                    }
                }
            }
            #endregion
            #region Değişmeyenler(Sabitler)
            int a = 5;
            /*
             birinciDegiskeninDegeri -> camelCase
            BirinciDegiskeninDegeri -> PascalCase
            birinci_degiskenin_degeri -> snake_case
             */
            int aydinPlaka = 15;
            aydinPlaka = 5;
            aydinPlaka = 9;
            Console.WriteLine(aydinPlaka);

            const double piSayisi = 3.1415; // const -> constant -> sabit-kısıtlı
            Console.WriteLine(piSayisi);

            const double eSayisi = 2.718;            
            Console.WriteLine(eSayisi * 2);
            #endregion
            #region Değişken Atama Varyasyonları
            int dav1 = 11; int dav2 = 22; int dav3 = 33;
            int dav4 = 44, dav5 = 55;
            #endregion
            #region object, var ve dynamic
            int normalDgr1 = 11;
            double normalDgr2 = 11.1;
            string normalDgr3 = "11";
            bool normalDgr4 = false;

            // değerler derleyici zamanında atanır
            var varDgr1 = 25;
            varDgr1 = 35;
            // varDgr1 = "selam";
            var varDgr2 = 25.1;
            var varDgr3 = "25.1";
            var varDgr4 = false;
            Console.WriteLine(varDgr1 + 2);

            // değerler runtimeda atanır
            dynamic dynDgr1 = 25;
            dynDgr1 = 35;
            // dynDgr1 = "selam";
            dynamic dynDgr2 = 25.1;
            dynamic dynDgr3 = "25.1";
            dynamic dynDgr4 = false;
            Console.WriteLine(dynDgr1 + 2);

            object objDgr1 = 25;
            object objDgr2 = 25.1;
            object objDgr3 = "25.1";
            object objDgr4 = false;
            Console.WriteLine((int)objDgr1 + 2); // cast işlemi
            Console.WriteLine(varDgr1.GetType());
            Console.WriteLine(dynDgr1.GetType());
            Console.WriteLine(objDgr1.GetType());
            #endregion
            #region Metinsel ifadelerin diğer türlere dönüştürülmesi
            string strSayi = "17";
            int intSayi = int.Parse(strSayi);
            Console.WriteLine(int.Parse(strSayi) + 2); // concatenation            
            Console.WriteLine(intSayi + 2); // concatenation            
            // Parse(Sadece stringler için kullanılabilir) - Convert
            string dersiGectimi = "fAlSe";
            // unsigned -> işaretsiz uint işaretsiz tamsayı
            // İşaretsiz tamsayılar negatif değerler alamaz.
            // int -> Int32 -> -2.5 milyar ve + 2.5 milyar
            // uint -> UInt32 -> 0 ile 5 milyar arasında değer tutabilir
            int sayi1 = 11;
            uint sayi2 = 11;
            bool boolDersiGectimi = Convert.ToBoolean(dersiGectimi);
            Console.WriteLine(boolDersiGectimi);
            #endregion
            #region Sayısal türlerin kendi arasında dönüştürülmesi
            byte byteDegisken = 128;
            int intDegisken = byteDegisken;

            short sDegisken1 = 2500;
            double dDegisken1 = sDegisken1;

            /*checked
            {
                int buyukDegisken = 10500;
                byte kucukDegisken = (byte)buyukDegisken;
                Console.WriteLine(kucukDegisken);
            }*/
            unchecked
            {
                float milyarDeger2 = 1_000_000_000_000f;
                short milyarDeger3 = (short)milyarDeger2;
                Console.WriteLine(milyarDeger3);
            }

            #endregion
            #region Mantıksal türlerin sayısal türlere dönüştürülmesi
            // true olsa 1 olurdu
            bool sinaviGectimi = false;
            Console.WriteLine(Convert.ToInt32(sinaviGectimi));
            #endregion
            #region Sayısal türlerin mantıksal türlere dönüştürülmesi
            double polis = -155.128;
            Console.WriteLine(Convert.ToBoolean(polis));
            #endregion
            #region Karakter türlerin sayısal türlere dönüşümü
            // " " kesinlikle null a eşit değildir!!!
            char aKarakteri = ' ';
            Console.WriteLine(Convert.ToInt32(aKarakteri));
            int aKarakteriInt = aKarakteri;
            Console.WriteLine(aKarakteriInt);
            #endregion
            #region Sayısal türlerin karakter türlerine dönüşümü
            int aDegeri = 39;
            Console.WriteLine(Convert.ToChar(aDegeri));
            #endregion                        
        }
    }
}
