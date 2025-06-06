namespace Hafta16_bp
{
    partial class GirisYapFormu
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
            kullaniciAdiLBL = new Label();
            label1 = new Label();
            kullaniciAdiTB = new TextBox();
            parolaTB = new TextBox();
            button1 = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 1;
            label1.Text = "Parola:";
            // 
            // kullaniciAdiTB
            // 
            kullaniciAdiTB.Location = new Point(176, 10);
            kullaniciAdiTB.Name = "kullaniciAdiTB";
            kullaniciAdiTB.Size = new Size(150, 31);
            kullaniciAdiTB.TabIndex = 2;
            // 
            // parolaTB
            // 
            parolaTB.Location = new Point(176, 60);
            parolaTB.Name = "parolaTB";
            parolaTB.PasswordChar = '*';
            parolaTB.Size = new Size(150, 31);
            parolaTB.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 110);
            button1.Name = "button1";
            button1.Size = new Size(314, 41);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GirisYap;
            // 
            // GirisYapFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 164);
            Controls.Add(button1);
            Controls.Add(parolaTB);
            Controls.Add(kullaniciAdiTB);
            Controls.Add(label1);
            Controls.Add(kullaniciAdiLBL);
            Name = "GirisYapFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciAdiLBL;
        private Label label1;
        private TextBox kullaniciAdiTB;
        private TextBox parolaTB;
        private Button button1;
    }
}