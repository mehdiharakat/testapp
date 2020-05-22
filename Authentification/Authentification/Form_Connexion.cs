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
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text.Equals("admin") && materialSingleLineTextField2.Text.Equals("1234"))
            {
                Main.is_Connected = 1;
                
                this.Hide();

            }
        }
    }
}
