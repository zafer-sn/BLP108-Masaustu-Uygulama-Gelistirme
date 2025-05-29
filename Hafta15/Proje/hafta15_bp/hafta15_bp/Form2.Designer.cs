namespace hafta15_bp
{
    partial class Form2
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "İşlem:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(82, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 264);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 227);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(82, 55);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(119, 23);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(82, 12);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(119, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 5;
            label3.Text = "Sayı2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 4;
            label2.Text = "Sayı1:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 183);
            button1.Name = "button1";
            button1.Size = new Size(191, 32);
            button1.TabIndex = 3;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Hesapla;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(12, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 28);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Hesaplansın mı?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(12, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 114);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 72);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 9;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 404);
            button2.Name = "button2";
            button2.Size = new Size(214, 32);
            button2.TabIndex = 9;
            button2.Text = "Ortalama Hesaplama Formunu Aç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OrtalamaHesaplamaFormu;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 448);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesaplama Formu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}