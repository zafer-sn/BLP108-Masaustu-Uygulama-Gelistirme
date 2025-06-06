namespace Hafta16_bp
{
    partial class KayitFormu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kullaniciAdiLBL = new Label();
            parolaLBL = new Label();
            kullaniciAdiTB = new TextBox();
            parolaTB = new TextBox();
            kayitOlBTN = new Button();
            telefonLBL = new Label();
            telefonMTB = new MaskedTextBox();
            girisYapBTN = new Button();
            kullaniciGuncelleBTN = new Button();
            kullaniciSilBTN = new Button();
            SuspendLayout();
            // 
            // kullaniciAdiLBL
            // 
            kullaniciAdiLBL.AutoSize = true;
            kullaniciAdiLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciAdiLBL.Location = new Point(12, 10);
            kullaniciAdiLBL.Name = "kullaniciAdiLBL";
            kullaniciAdiLBL.Size = new Size(158, 26);
            kullaniciAdiLBL.TabIndex = 0;
            kullaniciAdiLBL.Text = "Kullanici Adi:";
            // 
            // parolaLBL
            // 
            parolaLBL.AutoSize = true;
            parolaLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            parolaLBL.Location = new Point(12, 60);
            parolaLBL.Name = "parolaLBL";
            parolaLBL.Size = new Size(89, 26);
            parolaLBL.TabIndex = 1;
            parolaLBL.Text = "Parola:";
            // 
            // kullaniciAdiTB
            // 
            kullaniciAdiTB.Location = new Point(180, 10);
            kullaniciAdiTB.Name = "kullaniciAdiTB";
            kullaniciAdiTB.Size = new Size(150, 31);
            kullaniciAdiTB.TabIndex = 2;
            // 
            // parolaTB
            // 
            parolaTB.Location = new Point(180, 60);
            parolaTB.Name = "parolaTB";
            parolaTB.PasswordChar = '*';
            parolaTB.Size = new Size(150, 31);
            parolaTB.TabIndex = 3;
            // 
            // kayitOlBTN
            // 
            kayitOlBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayitOlBTN.Location = new Point(12, 160);
            kayitOlBTN.Name = "kayitOlBTN";
            kayitOlBTN.Size = new Size(314, 49);
            kayitOlBTN.TabIndex = 4;
            kayitOlBTN.Text = "Kayıt Ol";
            kayitOlBTN.UseVisualStyleBackColor = true;
            kayitOlBTN.Click += KayitOl;
            // 
            // telefonLBL
            // 
            telefonLBL.AutoSize = true;
            telefonLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            telefonLBL.Location = new Point(12, 110);
            telefonLBL.Name = "telefonLBL";
            telefonLBL.Size = new Size(94, 26);
            telefonLBL.TabIndex = 5;
            telefonLBL.Text = "Telefon:";
            // 
            // telefonMTB
            // 
            telefonMTB.Location = new Point(180, 110);
            telefonMTB.Mask = "0000000000";
            telefonMTB.Name = "telefonMTB";
            telefonMTB.Size = new Size(150, 31);
            telefonMTB.TabIndex = 6;
            telefonMTB.ValidatingType = typeof(int);
            // 
            // girisYapBTN
            // 
            girisYapBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisYapBTN.Location = new Point(12, 230);
            girisYapBTN.Name = "girisYapBTN";
            girisYapBTN.Size = new Size(314, 49);
            girisYapBTN.TabIndex = 7;
            girisYapBTN.Text = "Giriş Yap";
            girisYapBTN.UseVisualStyleBackColor = true;
            girisYapBTN.Click += GirisYap;
            // 
            // kullaniciGuncelleBTN
            // 
            kullaniciGuncelleBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciGuncelleBTN.Location = new Point(12, 300);
            kullaniciGuncelleBTN.Name = "kullaniciGuncelleBTN";
            kullaniciGuncelleBTN.Size = new Size(314, 49);
            kullaniciGuncelleBTN.TabIndex = 8;
            kullaniciGuncelleBTN.Text = "Kullanıcı Güncelle";
            kullaniciGuncelleBTN.UseVisualStyleBackColor = true;
            kullaniciGuncelleBTN.Click += KullaniciGuncelle;
            // 
            // kullaniciSilBTN
            // 
            kullaniciSilBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciSilBTN.Location = new Point(12, 370);
            kullaniciSilBTN.Name = "kullaniciSilBTN";
            kullaniciSilBTN.Size = new Size(314, 49);
            kullaniciSilBTN.TabIndex = 9;
            kullaniciSilBTN.Text = "Kullanıcı Sil";
            kullaniciSilBTN.UseVisualStyleBackColor = true;
            kullaniciSilBTN.Click += this.KullaniciSil;
            // 
            // KayitFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 434);
            Controls.Add(kullaniciSilBTN);
            Controls.Add(kullaniciGuncelleBTN);
            Controls.Add(girisYapBTN);
            Controls.Add(telefonMTB);
            Controls.Add(telefonLBL);
            Controls.Add(kayitOlBTN);
            Controls.Add(parolaTB);
            Controls.Add(kullaniciAdiTB);
            Controls.Add(parolaLBL);
            Controls.Add(kullaniciAdiLBL);
            Name = "KayitFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciAdiLBL;
        private Label parolaLBL;
        private TextBox kullaniciAdiTB;
        private TextBox parolaTB;
        private Button kayitOlBTN;
        private Label telefonLBL;
        private MaskedTextBox telefonMTB;
        private Button girisYapBTN;
        private Button kullaniciGuncelleBTN;
        private Button kullaniciSilBTN;
    }
}
