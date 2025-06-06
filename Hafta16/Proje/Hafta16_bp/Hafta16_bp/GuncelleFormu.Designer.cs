namespace Hafta16_bp
{
    partial class GuncelleFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guncelleBTN = new Button();
            eskiKullaniciParolaTB = new TextBox();
            eskiKullaniciAdiTB = new TextBox();
            eskiKullaniciParolaLBL = new Label();
            EskiKullaniciAdiLBL = new Label();
            yeniKullaniciParolaTB = new TextBox();
            yeniKullaniciAdiTB = new TextBox();
            YeniKullaniciParolaLBL = new Label();
            yeniKullaniciAdiLBL = new Label();
            SuspendLayout();
            // 
            // guncelleBTN
            // 
            guncelleBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guncelleBTN.Location = new Point(12, 260);
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Size = new Size(368, 41);
            guncelleBTN.TabIndex = 9;
            guncelleBTN.Text = "Kullanici Güncelle";
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += KullaniciGuncelle;
            // 
            // eskiKullaniciParolaTB
            // 
            eskiKullaniciParolaTB.Location = new Point(230, 60);
            eskiKullaniciParolaTB.Name = "eskiKullaniciParolaTB";
            eskiKullaniciParolaTB.PasswordChar = '*';
            eskiKullaniciParolaTB.Size = new Size(150, 31);
            eskiKullaniciParolaTB.TabIndex = 8;
            // 
            // eskiKullaniciAdiTB
            // 
            eskiKullaniciAdiTB.Location = new Point(230, 10);
            eskiKullaniciAdiTB.Name = "eskiKullaniciAdiTB";
            eskiKullaniciAdiTB.Size = new Size(150, 31);
            eskiKullaniciAdiTB.TabIndex = 7;
            // 
            // eskiKullaniciParolaLBL
            // 
            eskiKullaniciParolaLBL.AutoSize = true;
            eskiKullaniciParolaLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            eskiKullaniciParolaLBL.Location = new Point(12, 60);
            eskiKullaniciParolaLBL.Name = "eskiKullaniciParolaLBL";
            eskiKullaniciParolaLBL.Size = new Size(140, 26);
            eskiKullaniciParolaLBL.TabIndex = 6;
            eskiKullaniciParolaLBL.Text = "Eski Parola:";
            // 
            // EskiKullaniciAdiLBL
            // 
            EskiKullaniciAdiLBL.AutoSize = true;
            EskiKullaniciAdiLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            EskiKullaniciAdiLBL.Location = new Point(12, 10);
            EskiKullaniciAdiLBL.Name = "EskiKullaniciAdiLBL";
            EskiKullaniciAdiLBL.Size = new Size(209, 26);
            EskiKullaniciAdiLBL.TabIndex = 5;
            EskiKullaniciAdiLBL.Text = "Eski Kullanici Adi:";
            // 
            // yeniKullaniciParolaTB
            // 
            yeniKullaniciParolaTB.Location = new Point(230, 210);
            yeniKullaniciParolaTB.Name = "yeniKullaniciParolaTB";
            yeniKullaniciParolaTB.PasswordChar = '*';
            yeniKullaniciParolaTB.Size = new Size(150, 31);
            yeniKullaniciParolaTB.TabIndex = 13;
            // 
            // yeniKullaniciAdiTB
            // 
            yeniKullaniciAdiTB.Location = new Point(230, 160);
            yeniKullaniciAdiTB.Name = "yeniKullaniciAdiTB";
            yeniKullaniciAdiTB.Size = new Size(150, 31);
            yeniKullaniciAdiTB.TabIndex = 12;
            // 
            // YeniKullaniciParolaLBL
            // 
            YeniKullaniciParolaLBL.AutoSize = true;
            YeniKullaniciParolaLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            YeniKullaniciParolaLBL.Location = new Point(12, 210);
            YeniKullaniciParolaLBL.Name = "YeniKullaniciParolaLBL";
            YeniKullaniciParolaLBL.Size = new Size(140, 26);
            YeniKullaniciParolaLBL.TabIndex = 11;
            YeniKullaniciParolaLBL.Text = "Yeni Parola:";
            // 
            // yeniKullaniciAdiLBL
            // 
            yeniKullaniciAdiLBL.AutoSize = true;
            yeniKullaniciAdiLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yeniKullaniciAdiLBL.Location = new Point(12, 160);
            yeniKullaniciAdiLBL.Name = "yeniKullaniciAdiLBL";
            yeniKullaniciAdiLBL.Size = new Size(209, 26);
            yeniKullaniciAdiLBL.TabIndex = 10;
            yeniKullaniciAdiLBL.Text = "Yeni Kullanici Adi:";
            // 
            // GuncelleFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 314);
            Controls.Add(yeniKullaniciParolaTB);
            Controls.Add(yeniKullaniciAdiTB);
            Controls.Add(YeniKullaniciParolaLBL);
            Controls.Add(yeniKullaniciAdiLBL);
            Controls.Add(guncelleBTN);
            Controls.Add(eskiKullaniciParolaTB);
            Controls.Add(eskiKullaniciAdiTB);
            Controls.Add(eskiKullaniciParolaLBL);
            Controls.Add(EskiKullaniciAdiLBL);
            Name = "GuncelleFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuncelleFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guncelleBTN;
        private TextBox eskiKullaniciParolaTB;
        private TextBox eskiKullaniciAdiTB;
        private Label eskiKullaniciParolaLBL;
        private Label EskiKullaniciAdiLBL;
        private TextBox yeniKullaniciParolaTB;
        private TextBox yeniKullaniciAdiTB;
        private Label YeniKullaniciParolaLBL;
        private Label yeniKullaniciAdiLBL;
    }
}