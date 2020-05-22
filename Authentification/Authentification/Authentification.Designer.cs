namespace Authentification
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mdp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Window;
            this.Login.Depth = 0;
            this.Login.Hint = "Login";
            this.Login.Location = new System.Drawing.Point(128, 96);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.PasswordChar = '\0';
            this.Login.SelectedText = "";
            this.Login.SelectionLength = 0;
            this.Login.SelectionStart = 0;
            this.Login.Size = new System.Drawing.Size(165, 23);
            this.Login.TabIndex = 0;
            this.Login.UseSystemPasswordChar = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // mdp
            // 
            this.mdp.BackColor = System.Drawing.SystemColors.Window;
            this.mdp.Depth = 0;
            this.mdp.Hint = "Mot de passe";
            this.mdp.Location = new System.Drawing.Point(128, 145);
            this.mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '*';
            this.mdp.SelectedText = "";
            this.mdp.SelectionLength = 0;
            this.mdp.SelectionStart = 0;
            this.mdp.Size = new System.Drawing.Size(165, 23);
            this.mdp.TabIndex = 1;
            this.mdp.UseSystemPasswordChar = true;
            this.mdp.Click += new System.EventHandler(this.mdp_Click);
            this.mdp.Leave += new System.EventHandler(this.mdp_Leave);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(138, 221);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(146, 23);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Se Connecter";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(458, 275);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Login;
        private MaterialSkin.Controls.MaterialSingleLineTextField mdp;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

