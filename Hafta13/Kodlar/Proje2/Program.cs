using Hafta13_BP;
namespace Hafta13_BP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Okul okul1 = new Okul();
            // Okul2 okul2 = new Okul2();
            Sekil sekil1 = new Sekil();            
        }
    }

    class Kare:Sekil
    {
        public Kare()
        {
            base.Alan = 25.0;
        }
    }


}
