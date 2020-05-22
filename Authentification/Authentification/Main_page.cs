using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentification
{
    public partial class Main_page : MaterialSkin.Controls.MaterialForm
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            //CODE BARRE GENERATEUR
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(txtBarCode.Text, 60);
        }
    }
}
