namespace Hafta5BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch-case
            int bilecikPlaka = 11;
            int istabulPlaka = 34;

            switch(bilecikPlaka)
            {
                default:
                    Console.WriteLine("Hiçbirisi değil");
                    break;
                case 0:
                    Console.WriteLine("Değer 0'dır");
                    break;
                case 22:
                    Console.WriteLine("Değer 22'dir");
                    break;
                case 34:
                    Console.WriteLine("Değer 34'tür");
                    break;
                case 8:
                    Console.WriteLine("Değer 8'dir");
                    break;
                case 11 when (istabulPlaka == 37):
                    goto case 0;
                    break;
            }
            #endregion
            #region if-else if-else
            int aydinPlaka = 9;
            int agriPlaka = 4;
            if(true)
            {
                Console.WriteLine("İfade doğrudur");
            }

            if(false)
            {
                Console.WriteLine("İfade yanlıştır");
            }

            if(aydinPlaka == 9)
            {
                Console.WriteLine("Aydın plaka 9'dur");
            }
            
            if(aydinPlaka >= 9 && agriPlaka == 4 && false)
            {
                Console.WriteLine("Şart sağlandı");
            }

            if (aydinPlaka == 9)
            {
                Console.WriteLine("Değer doğrudur");
            }
            else
            {
                Console.WriteLine("Değer yanlıştır.");
            }

            if(agriPlaka == 7)
            {
                Console.WriteLine("Ağrı plaka değeri 7'dir");
            } else if (agriPlaka == 11 && false)
            {
                Console.WriteLine("Ağrı plaka değeri 11'dir ve false");
            } else if (false)
            {
                Console.WriteLine("Şart yanlış");
            } else if(true)
            {
                Console.WriteLine("Şart doğru");
            }
            else
            {
                Console.WriteLine("Hiçbiri değil.");
            }

            int malatyaPlaka = 44;
            if(malatyaPlaka == 44)
            {
                malatyaPlaka = 55;
                Console.WriteLine("Malatya Plakası 44'tür");
            } else if(malatyaPlaka == 55)
            {
                Console.WriteLine("Malatya Plakası 55'tir");
            } else
            {
                Console.WriteLine("Malatya Plakası hiçbiri değildir.");
            }

            int izmirPlaka = 35;
            if(izmirPlaka == 35)
                Console.WriteLine("İzmir Plaka doğrudur");
            #endregion
            #region EnBuyukSayi
            /*Console.Write("Lütfen 1. sayiyi giriniz..:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayiyi giriniz..:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 3. sayiyi giriniz..:");
            int sayi3 = int.Parse(Console.ReadLine());
            int enBuyuk = sayi1;
            if (sayi2 > enBuyuk) 
            {
                enBuyuk = sayi2;
            }
            if (sayi3 > enBuyuk)
            {
                enBuyuk = sayi3;
            }
            Console.WriteLine($"En büyük sayi: {enBuyuk}");*/
            #endregion
            #region Type Pattern
            object ankaraPlaka = 6;
            Console.WriteLine(ankaraPlaka is double);
            if(ankaraPlaka is int ankaraPlaka_i)
            {
                Console.WriteLine(ankaraPlaka_i * 2);
            }
            #endregion
            #region Constant Pattern
            object bursaPlaka = 16;
            if(bursaPlaka is 16) // ==
            {
                Console.WriteLine("Bursanın plakası 16'dır");
            }
            #endregion
            #region for döngüsü
            /*for(baslangic_degeri; şart; artim_miktarı)
            {

            }*/
            // Sonsuz for döngüsü
            /*for(; ;)
            {
                Console.WriteLine("Selam");
            }*/
            // i -> iteration
            /*for(var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }*/
            // i = i + 3 -> i += 3
            /*for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = -10; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (double i = 0; i < 10; i+=0.1)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/
            #endregion
            #region Araliktaki 7 kati
            /*Console.Write("Lütfen alt siniri giriniz..:");
            int altSinir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen üst siniri giriniz..:");
            int ustSinir = Convert.ToInt32(Console.ReadLine());
            for (int i = altSinir; i < ustSinir; i++)
            {
                if(i % 7 == 0)
                    Console.WriteLine(i);
            }*/
            #endregion
            #region while döngüsü
            int rizePlaka = 53;
            while(rizePlaka <= 81)
            {
                rizePlaka++;
                Console.WriteLine(rizePlaka);                 
            }
            // Console.WriteLine(rizePlaka);
            #endregion
            #region do while
            int bayburtPlaka = 69;
            do
            {
                Console.WriteLine(bayburtPlaka);
            } while (false);

            int antalyaPlaka = 7;
            do
            {
                antalyaPlaka += 2;
                Console.WriteLine(antalyaPlaka);
            } while (antalyaPlaka <= 11);
            #endregion
            #region break-continue
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    break;
                    Console.WriteLine(i);
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                    Console.WriteLine(i);
                }
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
