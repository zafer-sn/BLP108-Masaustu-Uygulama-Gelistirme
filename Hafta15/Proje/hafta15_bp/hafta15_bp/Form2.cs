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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Hesapla(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    label5.Text = $"Seçilen: {radioButton1.Text}";
                }
                else if (radioButton2.Checked)
                {
                    label5.Text = $"Seçilen: {radioButton2.Text}";
                }
                if (checkBox1.Checked)
                {
                    try
                    {
                        double sayi1 = double.Parse(maskedTextBox1.Text);
                        double sayi2 = double.Parse(maskedTextBox2.Text);
                        double sonuc;
                        if (comboBox1.Text == "+")
                        {
                            sonuc = sayi1 + sayi2;
                        }
                        else if (comboBox1.Text == "-")
                        {
                            sonuc = sayi1 - sayi2;
                        }
                        else if (comboBox1.Text == "*")
                        {
                            sonuc = sayi1 * sayi2;
                        }
                        else if (comboBox1.Text == "/")
                        {
                            if (sayi2 == 0)
                            {
                                MessageBox.Show("Bölme işlemi için ikinci sayı sıfır olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            MessageBox.Show("Lütfen bir işlem seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        label4.Text = "Sonuç: " + sonuc.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lütfen geçerli sayılar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir cinsiyet seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OrtalamaHesaplamaFormu(object sender, EventArgs e)
        {
            Form3 ortalamaFormu = new Form3();
            ortalamaFormu.Show();
            this.Hide();
        }
    }
}
