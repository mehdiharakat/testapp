using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentification
{
    public partial class Main : Form
    {
        public static int is_Connected = 0;

        public Main()
        {
            InitializeComponent();

            Thread th = new Thread(() =>
            {
                while (true)
                {
                    if (is_Connected == 1)
                    {
                        is_Connected = -1;
                        pictureBox1.BackgroundImage = Properties.Resources.home;
                        pictureBox2.Image = Properties.Resources.depot;
                        pictureBox3.Image = Properties.Resources.retrait;
                        setting_p.Invoke(new MethodInvoker(delegate
                            {
                                setting_p.Visible = false;
                            }
                            ));
                    }
                }
            });

            th.Start();

        }

        private void Menu_1_Click(object sender, EventArgs e)
        {
            Menu_1.Visible = false;
            Menu_2.Visible = true;
            Menu_name.Visible = true;
            setting_p.Visible = false;
        }

        private void Menu_2_Click(object sender, EventArgs e)
        {
            Menu_2.Visible = false;
            Menu_1.Visible = true;
            Menu_name.Visible = false;
            setting_p.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (setting_p.Visible)
            {
                setting_p.Visible = false;
                return;
            }
            setting_p.Location = new Point(settings.Location.X + 45, settings.Location.Y);
            setting_p.Visible = true;
        }
        private void Menu_name_VisibleChanged(object sender, EventArgs e)
        {
            if (Menu_name.Visible)
            {
                settings.Location = new Point(214, 12);
                //groupBox1.Location = new Point(214, 12);

            }
            else
            {
                settings.Location = new Point(100, 12);
                //groupBox1.Location = new Point(100, 12);

            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=Pressing_DB;Integrated Security=True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM view_Trans", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;

                

            }
            // TODO: cette ligne de code charge les données dans la table 'pressing_DBDataSet.view_Trans'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // dataGridView1.DataSource = 
            Menu_name_VisibleChanged(sender, e);
        }
        private void Connexion_button_MouseHover(object sender, EventArgs e)
        {
            Connexion_button.ForeColor = Color.DodgerBlue;
        }

        private void Connexion_button_MouseLeave(object sender, EventArgs e)
        {
            Connexion_button.ForeColor = Color.Snow;
        }

        private void deconnexion_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void deconnexion_button_MouseHover(object sender, EventArgs e)
        {
            deconnexion_button.ForeColor = Color.DodgerBlue;
        }

        private void deconnexion_button_MouseLeave(object sender, EventArgs e)
        {
            deconnexion_button.ForeColor = Color.Snow;
        }
        //private void Open_Connexion_Form()
        //{
        //    foreach (Form form in fc)
        //    {
        //        if (form.Name == "Connexion_f")
        //        {
        //            return;
        //        }
        //    }
        //    Connexion_f connexion_F = new Connexion_f();
        //    connexion_F.Show();
        //}

        private void Connexion_button_Click(object sender, EventArgs e)
        {
            Form_Connexion connexion_F = new Form_Connexion();
            connexion_F.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            info.Visible = false;
            cat.Visible = false;
            prod.Visible = true;
            //groupBox1.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            info.Visible = true;
            cat.Visible = false;
            prod.Visible = false;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            info.Visible = false;
            cat.Visible = true;
            prod.Visible = false;
        }

        private void deconnexion_button_Click_1(object sender, EventArgs e)
        {
            is_Connected = -1;
            Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            info.Visible = false;
            cat.Visible = false;
            prod.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            info.Visible = false;
            cat.Visible = true;
            prod.Visible = false;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            info.Visible = true;
            cat.Visible = false;
            prod.Visible = false;
           groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Trans add = new Add_Trans();
            add.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
