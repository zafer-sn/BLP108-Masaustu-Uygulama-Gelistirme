using Hafta16_bp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta16_bp
{
    public partial class SilFormu : Form
    {
        public SilFormu()
        {
            InitializeComponent();
        }

        private void KullaniciSil(object sender, EventArgs e)
        {
            AppDbContext adbc = new AppDbContext();
            // foreach alternatifi
            Ogrenci ogrenci = adbc.Ogrenciler.FirstOrDefault
                (ogrenci => ogrenci.KullaniciAdi == kullaniciAdiTB.Text);
            if (ogrenci != null && BCrypt.Net.BCrypt.Verify(parolaTB.Text, ogrenci.Parola))
            {
                adbc.Remove(ogrenci);
                adbc.SaveChanges();
                MessageBox.Show
                (
                    "Kullanici silindi!",
                    "Bilgilendirme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            } else
            {
                MessageBox.Show
                (
                    "Kullanici adi veya parola hatalı!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
