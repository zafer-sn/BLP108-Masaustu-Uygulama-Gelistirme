using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta15_bp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void OrtalamaHesapla(object sender, EventArgs e)
        {
            double vizeNotu = double.Parse(maskedTextBox2.Text);
            double odevNotu = double.Parse(maskedTextBox1.Text);
            double finalNotu = double.Parse(maskedTextBox3.Text);
            double ortalama = (vizeNotu * 0.3) + (odevNotu * 0.1) + (finalNotu * 0.6);
            MessageBox.Show
                (
                    $"Vize Notu: {vizeNotu}\nÖdev Notu: {odevNotu}\nFinal Notu: {finalNotu}\nOrtalama: {ortalama}",
                    "Ortalama Hesaplama Sonucu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
