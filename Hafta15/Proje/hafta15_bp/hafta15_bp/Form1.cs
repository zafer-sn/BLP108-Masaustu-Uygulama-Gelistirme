namespace hafta15_bp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Label lbl1 = new Label();
            lbl1.Text = "Ho�geldiniz";
            lbl1.Location = new Point(10, 10);
            this.Controls.Add(lbl1);*/
        }

        private void GirisYap(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show
                    (
                        "Giri� Ba�ar�l�!, Hesaplama Formunun y�klenmesi i�in OK butonuna t�klay�n�z...",
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
                        "Giri� Ba�ar�s�z!",
                        "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
    }
}
