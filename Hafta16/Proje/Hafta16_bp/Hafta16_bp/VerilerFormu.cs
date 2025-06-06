using Hafta16_bp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta16_bp
{
    public partial class VerilerFormu : Form
    {
        public VerilerFormu()
        {
            InitializeComponent();
        }

        private void VerileriYukle(object sender, EventArgs e)
        {
            AppDbContext adbc = new AppDbContext();
            ogrenciVerileriDGV.DataSource = adbc.Ogrenciler.ToList();
        }
    }
}
