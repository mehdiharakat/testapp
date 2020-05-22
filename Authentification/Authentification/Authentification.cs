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
    public partial class Authentification : MaterialSkin.Controls.MaterialForm
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //if(Login.Text.ToString().Equals("Login"))
            //{
            //    Login.Text = "";
            //}
        }

        private void mdp_Click(object sender, EventArgs e)
        {
            //if (mdp.Text.ToString().Equals("Mot de passe"))
            //{
            //    mdp.Text = "";
            //}
        }

        private void Login_Leave(object sender, EventArgs e)
        {
        //    if (Login.Text.Length < 1)
        //    {
        //        Login.Text = "Login";
                
        //    }
        }

        private void mdp_Leave(object sender, EventArgs e)
        {
            //if (mdp.Text.Length < 1)
            //{
            //    mdp.Text = "Mot de passe";

            //}
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(Login.Text.Equals("Admin") && mdp.Text.Equals("123456"))
            {
                Main_Form main_Page = new Main_Form();
                main_Page.Show();
                this.Hide();
            }
        }

        internal class Pressing_DBDataSet
        {
            internal object view_Trans;

            public Pressing_DBDataSet()
            {
            }

            public string DataSetName { get; internal set; }
            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        }

        internal class Pressing_DBDataSetTableAdapters
        {
            internal class view_TransTableAdapter
            {
                public view_TransTableAdapter()
                {
                }

                public bool ClearBeforeFill { get; internal set; }

                internal void Fill(object view_Trans)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
