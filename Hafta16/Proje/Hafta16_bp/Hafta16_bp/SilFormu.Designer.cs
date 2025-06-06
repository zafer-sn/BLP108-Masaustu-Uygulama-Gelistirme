namespace Hafta16_bp
{
    partial class SilFormu
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
            button1 = new Button();
            parolaTB = new TextBox();
            kullaniciAdiTB = new TextBox();
            label1 = new Label();
            kullaniciAdiLBL = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 109);
            button1.Name = "button1";
            button1.Size = new Size(314, 41);
            button1.TabIndex = 9;
            button1.Text = "Sil!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += KullaniciSil;
            // 
            // parolaTB
            // 
            parolaTB.Location = new Point(176, 59);
            parolaTB.Name = "parolaTB";
            parolaTB.PasswordChar = '*';
            parolaTB.Size = new Size(150, 31);
            parolaTB.TabIndex = 8;
            // 
            // kullaniciAdiTB
            // 
            kullaniciAdiTB.Location = new Point(176, 9);
            kullaniciAdiTB.Name = "kullaniciAdiTB";
            kullaniciAdiTB.Size = new Size(150, 31);
            kullaniciAdiTB.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 6;
            label1.Text = "Parola:";
            // 
            // kullaniciAdiLBL
            // 
            kullaniciAdiLBL.AutoSize = true;
            kullaniciAdiLBL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciAdiLBL.Location = new Point(12, 9);
            kullaniciAdiLBL.Name = "kullaniciAdiLBL";
            kullaniciAdiLBL.Size = new Size(158, 26);
            kullaniciAdiLBL.TabIndex = 5;
            kullaniciAdiLBL.Text = "Kullanici Adi:";
            // 
            // SilFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 161);
            Controls.Add(button1);
            Controls.Add(parolaTB);
            Controls.Add(kullaniciAdiTB);
            Controls.Add(label1);
            Controls.Add(kullaniciAdiLBL);
            Name = "SilFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SilFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox parolaTB;
        private TextBox kullaniciAdiTB;
        private Label label1;
        private Label kullaniciAdiLBL;
    }
}