namespace Hafta5BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metinsel Tür Dönüşümü
            string harcTutar = "500";
            // Parse Yöntemi type.Parse(degisken_adi)
            int harcTutarInt = int.Parse(harcTutar);
            Console.WriteLine(harcTutarInt * 2);
            // Convert Yöntemi Convert.ToDouble(degisken_adi)
            string tutar = "125,8";
            double tutarDouble = Convert.ToDouble(tutar);
            Console.WriteLine(tutarDouble * 3);
            string xKarakteri = "x";
            char xKarakteriChar = Convert.ToChar(xKarakteri);
            Console.WriteLine(xKarakteriChar.GetType());
            string girisYapildimi = "faLsE";
            bool girisYapildimiBool = Convert.ToBoolean(girisYapildimi);
            Console.WriteLine(girisYapildimi.GetType());
            Console.WriteLine(girisYapildimiBool.GetType());
            #endregion
            #region Bilinçsiz Tür Dönüşümü
            byte bilecikPlaka = 11;
            int bilecikPlakaInt = bilecikPlaka;
            Console.WriteLine(bilecikPlaka.GetType());
            Console.WriteLine(bilecikPlakaInt.GetType());
            short kurulusYili = 1994;
            long kurulusYiliLong = kurulusYili;
            Console.WriteLine(kurulusYili.GetType());
            Console.WriteLine(kurulusYiliLong * 2);
            #endregion
            #region Bilinçli Tür Dönüşümü
            int buyukDeger = 12500;
            byte buyukDegerByte = (byte)buyukDeger;
            Console.WriteLine(buyukDegerByte);

            double sayi3 = 2500;
            float sayi4 = (int)sayi3;
            Console.WriteLine(sayi3);
            Console.WriteLine(sayi4);
            #endregion
            #region checked Yapisi
            Console.WriteLine("-----------------Checked Yapisi--------------------");
            checked
            {
                int bursaPlaka = 160; // 1600'de hata verir.
                byte bursaPlakaByte = (byte)bursaPlaka;
                Console.WriteLine(bursaPlakaByte);
            }
            #endregion
            #region unchecked Yapisi
            unchecked
            {
                int kayseriPlaka = 38000;
                short kayseriPlakaShort = (short)kayseriPlaka;
                Console.WriteLine(kayseriPlakaShort);
            }
            #endregion
            #region Mantiksal Türlerin Sayisal Türlere Dönüşümü
            bool yasiyorMu = false; // true -> 1, false -> 0
            int yasiyorMuInt = Convert.ToInt32(yasiyorMu);
            Console.WriteLine(yasiyorMuInt);
            #endregion
            #region Sayisal Türlerin Mantıksal Türlere Dönüşümü
            int okulaGeldimi = -1500; // 0 hariç her değerde true olur
            bool okulaGeldimiBool = Convert.ToBoolean(okulaGeldimi);
            Console.WriteLine(okulaGeldimiBool);
            #endregion
            #region Karakter Türlerin Dönüşümü
            char AKarakteri = 'A';
            int AKarakteriInt = Convert.ToInt32(AKarakteri);
            Console.WriteLine(AKarakteriInt);
            #endregion
            #region Sayisal Türlerin Karakter Türlere Dönüşümü
            int aKarakteri = 97;
            char aKarakteriChar = Convert.ToChar(aKarakteri);
            Console.WriteLine(aKarakteriChar);
            #endregion
        }
    }
}
