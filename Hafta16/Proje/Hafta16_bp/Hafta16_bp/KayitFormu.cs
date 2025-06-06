using Hafta16_bp.model;

namespace Hafta16_bp
{
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void KayitOl(object sender, EventArgs e)
        {
            AppDbContext adbc = new AppDbContext();
            Ogrenci eklenecekOgrenci = new Ogrenci();
            try
            {
                eklenecekOgrenci.KullaniciAdi = kullaniciAdiTB.Text;
                string acikParola = parolaTB.Text;
                eklenecekOgrenci.Parola = BCrypt.Net.BCrypt.HashPassword(acikParola);
                eklenecekOgrenci.Telefon = int.Parse(telefonMTB.Text);
            } catch(Exception)
            {
                MessageBox.Show
                    (
                        "Lütfen geçerli deðerler giriniz!",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
            adbc.Add(eklenecekOgrenci);
            adbc.SaveChanges();
            MessageBox.Show
                    (
                        "Kullanici baþarýlý bir þekilde kayýt edildi.",
                        "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
        }

        private void GirisYap(object sender, EventArgs e)
        {
            GirisYapFormu gyf = new GirisYapFormu();
            gyf.Show();
            this.Hide();
        }

        private void KullaniciGuncelle(object sender, EventArgs e)
        {
            GuncelleFormu gf = new GuncelleFormu();
            gf.Show();
            this.Hide();
        }

        private void KullaniciSil(object sender, EventArgs e)
        {
            SilFormu sf = new SilFormu();
            sf.Show();
            this.Hide();
        }
    }
}
