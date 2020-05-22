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
    public partial class Main_Form : MaterialSkin.Controls.MaterialForm
    {
        FormCollection fc = Application.OpenForms;
        int exit = 0;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            Lab_date.Text = DateTime.Now.ToLongDateString();
            //CODE BARRE GENERATEUR
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(txtBarCode.Text, 60);
        }

        private void p_depot_Click(object sender, EventArgs e)
        {
            foreach (Form form in fc)
            {
                if (form.Name == "F_Depot")
                {
                    return;
                }
            }
            //F_Depot f_Depot = new F_Depot();
            //f_Depot.Show();
        }

        private void p_client_Click(object sender, EventArgs e)
        {
            foreach (Form form in fc)
            {
                if (form.Name == "F_Client")
                {
                    return;
                }
            }
            F_Client f_Client = new F_Client();
            f_Client.Show();
        }

        private void Dépôt_Click(object sender, EventArgs e)
        {

            foreach(Form form in fc)
            {
                if(form.Name == "F_Depot")
                {
                    return;
                }
            }
            //F_Depot f_Depot = new F_Depot();
            //f_Depot.Show();
        }

        private void Clientt_Click(object sender, EventArgs e)
        {
            foreach (Form form in fc)
            {
                if (form.Name == "F_Client")
                {
                    return;
                }
            }
            F_Client f_Client = new F_Client();
            f_Client.Show();
        }

        private void p_retrait_Click(object sender, EventArgs e)
        {
            foreach (Form form in fc)
            {
                if (form.Name == "F_Retrait")
                {
                    return;
                }
            }
            F_Retrait f_Retrait = new F_Retrait();
            f_Retrait.Show();
        }

        private void Retrait_Click(object sender, EventArgs e)
        {
            foreach (Form form in fc)
            {
                if (form.Name == "F_Retrait")
                {
                    return;
                }
            }
            F_Retrait f_Retrait = new F_Retrait();
            f_Retrait.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Etes-vous sur de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {       /* quitte l'application */
                    exit = 1;
                    Application.Exit();
                }
                else
                    /* annule le dechargement de la form */
                    e.Cancel = true;
            }
        }
    }
}
