namespace Authentification
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Client = new System.Windows.Forms.Panel();
            this.Clientt = new MaterialSkin.Controls.MaterialLabel();
            this.p_client = new System.Windows.Forms.PictureBox();
            this.Lab_date = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Retrait = new MaterialSkin.Controls.MaterialLabel();
            this.p_retrait = new System.Windows.Forms.PictureBox();
            this.Dépôt = new MaterialSkin.Controls.MaterialLabel();
            this.p_depot = new System.Windows.Forms.PictureBox();
            this.Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_client)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_retrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_depot)).BeginInit();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Client.Controls.Add(this.Clientt);
            this.Client.Controls.Add(this.p_client);
            this.Client.Controls.Add(this.Lab_date);
            this.Client.Controls.Add(this.panel2);
            this.Client.Controls.Add(this.Retrait);
            this.Client.Controls.Add(this.p_retrait);
            this.Client.Controls.Add(this.Dépôt);
            this.Client.Controls.Add(this.p_depot);
            this.Client.Location = new System.Drawing.Point(1, 64);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(1196, 667);
            this.Client.TabIndex = 0;
            // 
            // Clientt
            // 
            this.Clientt.AutoSize = true;
            this.Clientt.Depth = 0;
            this.Clientt.Font = new System.Drawing.Font("Roboto", 11F);
            this.Clientt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clientt.Location = new System.Drawing.Point(559, 417);
            this.Clientt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Clientt.Name = "Clientt";
            this.Clientt.Size = new System.Drawing.Size(48, 19);
            this.Clientt.TabIndex = 9;
            this.Clientt.Text = "Client";
            this.Clientt.Click += new System.EventHandler(this.Clientt_Click);
            // 
            // p_client
            // 
            this.p_client.Image = ((System.Drawing.Image)(resources.GetObject("p_client.Image")));
            this.p_client.Location = new System.Drawing.Point(532, 283);
            this.p_client.Name = "p_client";
            this.p_client.Size = new System.Drawing.Size(97, 131);
            this.p_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_client.TabIndex = 8;
            this.p_client.TabStop = false;
            this.p_client.Click += new System.EventHandler(this.p_client_Click);
            // 
            // Lab_date
            // 
            this.Lab_date.AutoSize = true;
            this.Lab_date.Depth = 0;
            this.Lab_date.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lab_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lab_date.Location = new System.Drawing.Point(534, 22);
            this.Lab_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lab_date.Name = "Lab_date";
            this.Lab_date.Size = new System.Drawing.Size(38, 19);
            this.Lab_date.TabIndex = 6;
            this.Lab_date.Text = "date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.materialSingleLineTextField3);
            this.panel2.Controls.Add(this.materialSingleLineTextField2);
            this.panel2.Controls.Add(this.materialSingleLineTextField1);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Location = new System.Drawing.Point(22, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 157);
            this.panel2.TabIndex = 7;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Enabled = false;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(874, 69);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField3.TabIndex = 6;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Enabled = false;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(397, 98);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField2.TabIndex = 5;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(397, 47);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(691, 73);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(177, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Montant des opérations :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(243, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Nombres de dépôt : ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(243, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Nombres de retrait : ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Données importantes";
            // 
            // Retrait
            // 
            this.Retrait.AutoSize = true;
            this.Retrait.Depth = 0;
            this.Retrait.Font = new System.Drawing.Font("Roboto", 11F);
            this.Retrait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Retrait.Location = new System.Drawing.Point(660, 230);
            this.Retrait.MouseState = MaterialSkin.MouseState.HOVER;
            this.Retrait.Name = "Retrait";
            this.Retrait.Size = new System.Drawing.Size(53, 19);
            this.Retrait.TabIndex = 5;
            this.Retrait.Text = "Retrait";
            this.Retrait.Click += new System.EventHandler(this.Retrait_Click);
            // 
            // p_retrait
            // 
            this.p_retrait.Image = ((System.Drawing.Image)(resources.GetObject("p_retrait.Image")));
            this.p_retrait.Location = new System.Drawing.Point(636, 120);
            this.p_retrait.Name = "p_retrait";
            this.p_retrait.Size = new System.Drawing.Size(97, 107);
            this.p_retrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_retrait.TabIndex = 4;
            this.p_retrait.TabStop = false;
            this.p_retrait.Click += new System.EventHandler(this.p_retrait_Click);
            // 
            // Dépôt
            // 
            this.Dépôt.AutoSize = true;
            this.Dépôt.Depth = 0;
            this.Dépôt.Font = new System.Drawing.Font("Roboto", 11F);
            this.Dépôt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dépôt.Location = new System.Drawing.Point(438, 230);
            this.Dépôt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Dépôt.Name = "Dépôt";
            this.Dépôt.Size = new System.Drawing.Size(49, 19);
            this.Dépôt.TabIndex = 3;
            this.Dépôt.Text = "Dépôt";
            this.Dépôt.Click += new System.EventHandler(this.Dépôt_Click);
            // 
            // p_depot
            // 
            this.p_depot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_depot.Image = ((System.Drawing.Image)(resources.GetObject("p_depot.Image")));
            this.p_depot.Location = new System.Drawing.Point(400, 120);
            this.p_depot.Name = "p_depot";
            this.p_depot.Size = new System.Drawing.Size(129, 107);
            this.p_depot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_depot.TabIndex = 2;
            this.p_depot.TabStop = false;
            this.p_depot.Click += new System.EventHandler(this.p_depot_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1198, 733);
            this.Controls.Add(this.Client);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue dans votre espace pressing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_page_Load);
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_client)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_retrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_depot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Client;
        private MaterialSkin.Controls.MaterialLabel Dépôt;
        private System.Windows.Forms.PictureBox p_depot;
        private MaterialSkin.Controls.MaterialLabel Retrait;
        private System.Windows.Forms.PictureBox p_retrait;
        private MaterialSkin.Controls.MaterialLabel Lab_date;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel Clientt;
        private System.Windows.Forms.PictureBox p_client;
    }
}