namespace Hafta16_bp
{
    partial class VerilerFormu
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
            ogrenciVerileriDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ogrenciVerileriDGV).BeginInit();
            SuspendLayout();
            // 
            // ogrenciVerileriDGV
            // 
            ogrenciVerileriDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ogrenciVerileriDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogrenciVerileriDGV.Dock = DockStyle.Fill;
            ogrenciVerileriDGV.Location = new Point(0, 0);
            ogrenciVerileriDGV.Name = "ogrenciVerileriDGV";
            ogrenciVerileriDGV.RowHeadersWidth = 62;
            ogrenciVerileriDGV.Size = new Size(800, 450);
            ogrenciVerileriDGV.TabIndex = 0;
            // 
            // VerilerFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ogrenciVerileriDGV);
            Name = "VerilerFormu";
            Text = "Veriler Formu";
            Load += VerileriYukle;
            ((System.ComponentModel.ISupportInitialize)ogrenciVerileriDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ogrenciVerileriDGV;
    }
}