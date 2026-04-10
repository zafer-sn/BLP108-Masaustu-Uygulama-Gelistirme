namespace Hafta7BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region throw anahtar sözcüğü
            /* try
            {
                Console.Write("Lütfen bir sayı giriniz..:");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("Lütfen bir sayı giriniz..:");
                int sayi2 = int.Parse(Console.ReadLine());

                if(sayi2 == 0)
                {
                    //throw new DivideByZeroException("Sayi2 0 olamaz!");
                    throw new DivideByZeroException("Sayi2 0 olamaz!");
                }

                Console.WriteLine(sayi1 / sayi2);
            }/*
            
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"Sıfıra bölme hatası: {dbze.Message}");
                //throw new Exception("Hata");
                throw;
            }
            /* catch (FormatException fe)
            {

            } */
            /*
            catch (Exception e)
            {
                Console.WriteLine($"Genel hata: {e.Message}");
            }*/
            #endregion
            #region throw anahtar sözcüğü-2
            /* try
            {
                Console.Write("Lutfen sayi giriniz..:");
                string deger = Console.ReadLine();
                int degerI = 0;
                if(int.TryParse(deger, out degerI))
                {
                    Console.WriteLine(degerI * 2);
                }
                Console.Write("Lutfen sayi giriniz..:");
                int sayi1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format hatasi!");
                throw;
            } */
            #endregion
            #region for Döngüsü - 1
            /* for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Selam");
            } */
            #endregion
            #region for Döngüsü - 2
            /* for(int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            } */
            #endregion
            #region for Döngüsü - 3
            /* for (int i = 0; i < 101; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            } */
            #endregion
            #region for Döngüsü - 4
            /* Console.Write("Alt sinir giriniz..:");
            int altSinir = int.Parse(Console.ReadLine());
            Console.Write("Ust sinir giriniz..:");
            int ustSinir = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = altSinir; i <= ustSinir; i++)
            {                
                if(i % 5 == 0)
                {
                    toplam += i; // toplam = toplam + i ;
                }
            }
            Console.WriteLine($"Toplam: {toplam}"); */
            #endregion
            #region for Döngüsü - 5
            /* for(int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            } */
            #endregion
            #region for Döngüsü - 6
            /* // 5! = 5x4x3x2x1 = 120
            // 6! = 6x5x4x3x2x1 = 720
            // 0! = 1
            Console.Write("Lutfen faktoriyel alinacak degeri yaziniz..:");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            // for(int i = 1; i <= sayi; i++)'da olur. i 2 den de başlatılabilir
            for(int i = sayi; i >= 1; i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(faktoriyel); */
            #endregion
            #region for Döngüsü - 7
            /*for(int i1 = 5, i2 = 10; i1 % 5 == 0 && i2 % 5 == 0 ; i1+=5, i2+=5)
            {
                Console.WriteLine(i1);
                Console.WriteLine(i2);
                if(i1 == 50)
                {
                    break;
                }
            }*/
            #endregion
            #region for Döngüsü - 8
            /* for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j} = {i*j}");
                }
            } */
            #endregion
            #region while Döngüsü - 1            
            /* while(true)
            {
                Console.WriteLine("Selam");
            } */
            #endregion
            #region while Döngüsü - 2
            /* int i = 1;
            while(i <= 10)
            {
                //i++;
                Console.WriteLine(i);
                i++;
            } */
            #endregion
            #region while Döngüsü - 3
            /* int toplam = 0;
            while(true)
            {
                Console.Write("Sayi giriniz..:");
                string deger = Console.ReadLine();
                if(deger == "q")
                {
                    Console.WriteLine($"Toplam: {toplam}");
                    break;
                } else
                {
                    toplam += int.Parse(deger);
                }
            } */
            #endregion
            #region do-while Döngüsü - 1
            /*int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 0); */
            #endregion
            #region do-while Döngüsü - 2
            /* do
            {
                Console.WriteLine("Test");
            } while (false); */
            #endregion
            #region break anahtar sözcüğü
            /* for (int i = 1; i <= 100; i++)
            {
                if(i == 51)
                {
                    break;
                }
                Console.WriteLine(i);
            } */
            #endregion
            #region continue anahtar sözcüğü
            /* for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            } */
            #endregion
            #region Ornek-1
            /* Random r1 = new Random();
            int rastgele = r1.Next(0, 101);
            int denemeSayisi = 0;
            while(true)
            {
                Console.Write("Tahmin giriniz..:");
                int tahmin = int.Parse(Console.ReadLine());
                denemeSayisi++;
                if(tahmin == rastgele)
                {
                    Console.WriteLine($"Tebrikler, {denemeSayisi} denemede buldunuz.");
                    break;
                } else if(tahmin < rastgele)
                {
                    Console.WriteLine("Lütfen daha buyuk bir sayi giriniz.");
                } else
                {
                    Console.WriteLine("Lütfen daha küçük bir sayi giriniz.");
                }
                        
            } */
            #endregion
            #region Ornek-3
            /* for(int i = 1; i<=100; i++)
            {
                Console.WriteLine(i);
            } */
            #endregion
            #region Ornek - 4
            /* for(int i = 150; i <= 450; i+=15)
            {
                Console.WriteLine(i);                
            } */
            #endregion
            #region Ornek - 5
            /* for(int i = 150; i <= 450; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            } */
            #endregion
        }
    }
}
