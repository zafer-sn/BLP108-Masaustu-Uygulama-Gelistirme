
namespace Hafta14_BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AKullanici k1 = new Kullanici();           
            Object k2 = new Kullanici();  
            IPersonel p1 = new Personel();

            Personel p2 = new Personel();
            IPersonel p3 = new Personel();
            IKullanici p4 = new Personel();
            Canli p5 = new Personel();

            IRaporOlusturucu pdfOlusturucu = new PdfRaporu();
            pdfOlusturucu.Olustur("Aylık satış verileri");
            IRaporOlusturucu excelOlusturucu = new ExcelRaporu();
            pdfOlusturucu.Olustur("Stok durum raporu");
            IRaporOlusturucu metinOlusturucu = new MetinRaporu();
            pdfOlusturucu.Olustur("Günlük log kayıtları");

            IRaporOlusturucu[] dizi = { pdfOlusturucu, excelOlusturucu, metinOlusturucu };
            foreach (var item in dizi)
            {
                item.Olustur("Genel performans özeti");
            }

            for(var i = 0; i < dizi.Length; i++)
            {
                dizi[i].Olustur("Genel performans özeti");
            }

            // SOLID
            List<int> deneme = new List<int>();
            deneme.Add(1);

            DevletBirimleri db = new DevletBirimleri();
            

        }
    }

    // Partial(Parçalı) yapılanması
    partial class DevletBirimleri
    {
        public string SaglikBakanligi { get; set; }
        public string SavunmaBakanligi { get; set; }
        public string IletisimBakanligi { get; set; }
        public string MEB { get; set; }
    }

    partial class DevletBirimleri
    {
        public string BilecikBelediyesi { get; set; }
        public string EskisehirBelediyesi { get; set; }
        public string IstanbulBelediyesi { get; set; }
        public string AnkaraBelediyesi { get; set; }
    }

    interface IRaporOlusturucu
    {
        void Olustur(string raporVerisi);
    }

    class PdfRaporu : IRaporOlusturucu
    {
        public void Olustur(string raporVerisi)
        {
            Console.WriteLine($"{raporVerisi} içeriğiyle PDF raporu oluşturuluyor...");
        }
    }

    class ExcelRaporu : IRaporOlusturucu
    {
        public void Olustur(string raporVerisi)
        {
            Console.WriteLine($"{raporVerisi} içeriğiyle Excel raporu oluşturuluyor...");
        }
    }

    class MetinRaporu : IRaporOlusturucu
    {
        public void Olustur(string raporVerisi)
        {
            Console.WriteLine($"{raporVerisi} içeriğiyle metin raporu oluşturuluyor...");
        }
    }


    interface IPersonel
    {
        string Isim { get; set; }
        string Soyisim { get; set; }
        int Yas { get; set; }
        void MaasHesapla();        
    }

    interface IKullanici
    {
        string KullaniciAdi { get; set; }
        string KullaniciParola { get; set; }
    }

    class Canli
    {
        public void Solunum()
        {
            Console.WriteLine("Solunum yapılıyor...");
        }
    }

    class Personel : Canli, IPersonel, IKullanici
    {
        public void Yuruyus()
        {
            Console.WriteLine("Yürüyor...");
        }
        public void MaasHesapla()
        {
            Console.WriteLine("Maaş hesaplanıyor...");
        }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
    }

    /*
     Abstract class -> Temelinde bir classtır.
     Somut Bölüm(Size şimdiye kadar anlatttıklarım) - Soyut Bölüm     
     */
    abstract class AKullanici
    {
        protected AKullanici()
        {
            Console.WriteLine("AKullanici abstract classından nesne üretildi...");
        }
        int yas;
        public int TC { get; set; }
        public void Selamla()
        {
            Console.WriteLine("Selam");
        }

        public abstract void Ekle(KullaniciBilgi kb);
        public abstract void Getir();
        public abstract void Guncelle();
        public abstract void Sil();
    }

    // Kalıtım değil implementasyon
    // Java extends
    // implements
    class Kullanici : AKullanici
    {
        public Kullanici()
        {
            Console.WriteLine("Kullanici classından nesnes üretildi...");
        }
        /*
         CRUD ->
         Create -> POST -> Oluşturmak, Ekle
         Read -> GET -> Okuma
         Update -> PUT -> Güncelle
         Delete -> DELETE -> Silme         
         */

        /*
         Frontend
         Backend
         Full Stack
         Senior -> Tecrübeli geliştirici
         Junior -> Giriş seviye yazılımcı
         DBA -> Database Administrator
         */
        public override void Ekle(KullaniciBilgi kb)
        {
            Console.WriteLine("Kullanici ekleniyor...");
        }

        public override void Getir()
        {
            Console.WriteLine("Kullanici getiriliyor...");
        }

        public override void Guncelle()
        {
            Console.WriteLine("Kullanici guncelleniyor...");
        }
        public override void Sil()
        {
            Console.WriteLine("Kullanici siliniyor...");
        }

        // Kullanici Maaş örneği
        public double MaasHesapla()
        {
            Console.WriteLine("Maaş hesaplanıyor...");
            return 1000.0;
        }

        public int PrimHesapla()
        {
            Console.WriteLine("Prim hesaplanıyor...");
            return 500;
        }
    }

    class KullaniciBilgi
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
    }



}
