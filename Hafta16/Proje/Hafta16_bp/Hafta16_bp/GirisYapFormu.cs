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
    public partial class GirisYapFormu : Form
    {
        public GirisYapFormu()
        {
            InitializeComponent();
        }

        private void GirisYap(object sender, EventArgs e)
        {
            AppDbContext adbc = new AppDbContext();
            Ogrenci dogrulanacakOgrenci = new Ogrenci();
            bool dogrulandimi = false;
            foreach (Ogrenci ogrenci in adbc.Ogrenciler.ToList())
            {
                if(ogrenci.KullaniciAdi == kullaniciAdiTB.Text)
                {                    
                    if(BCrypt.Net.BCrypt.Verify(parolaTB.Text, ogrenci.Parola))
                    {
                        dogrulandimi |= true;
                        VerilerFormu vf = new VerilerFormu();
                        vf.Show();
                        this.Hide();
                    }
                }                
            }  
            if (!dogrulandimi)
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
