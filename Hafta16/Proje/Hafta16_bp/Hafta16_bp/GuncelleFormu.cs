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
    public partial class GuncelleFormu : Form
    {
        public GuncelleFormu()
        {
            InitializeComponent();
        }

        private void KullaniciGuncelle(object sender, EventArgs e)
        {
            AppDbContext adbc = new AppDbContext();
            bool guncellenecekOgrenciBulundumu = false;
            foreach (Ogrenci ogrenci in adbc.Ogrenciler.ToList())
            {
                if (ogrenci.KullaniciAdi == eskiKullaniciAdiTB.Text)
                {
                    if (BCrypt.Net.BCrypt.Verify(eskiKullaniciParolaTB.Text, ogrenci.Parola))
                    {
                        ogrenci.KullaniciAdi = yeniKullaniciAdiTB.Text;
                        ogrenci.Parola = BCrypt.Net.BCrypt.HashPassword(yeniKullaniciParolaTB.Text);
                        adbc.SaveChanges();
                        guncellenecekOgrenciBulundumu = true;
                        MessageBox.Show
                        (
                            "Veriler başarılı bir şekilde güncellendi",
                            "Bilgilendirme",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            if (!guncellenecekOgrenciBulundumu)
            {
                MessageBox.Show
                (
                    "Eski Kullanici adi veya parola hatalı!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } 
        }
    }
}
