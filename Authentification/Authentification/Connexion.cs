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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (login.Text.Equals("Admin") && pwd.Text.Equals("1234"))
            {
                Main.is_Connected = 1;
                this.Hide();
            }
        }
    }
}
