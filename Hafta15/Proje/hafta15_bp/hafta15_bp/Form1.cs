namespace hafta15_bp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Label lbl1 = new Label();
            lbl1.Text = "Hoþgeldiniz";
            lbl1.Location = new Point(10, 10);
            this.Controls.Add(lbl1);*/
        }

        private void GirisYap(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show
                    (
                        "Giriþ Baþarýlý!, Hesaplama Formunun yüklenmesi için OK butonuna týklayýnýz...",
                        "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                Form2 hesaplamaFormu = new Form2();
                hesaplamaFormu.Show();
                this.Hide();
            } else
            {
                MessageBox.Show
                    (
                        "Giriþ Baþarýsýz!",
                        "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
    }
}
