namespace Biblio
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.se_connecter = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.pwd_visible = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // se_connecter
            // 
            this.se_connecter.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_connecter.Location = new System.Drawing.Point(230, 278);
            this.se_connecter.Name = "se_connecter";
            this.se_connecter.Size = new System.Drawing.Size(135, 37);
            this.se_connecter.TabIndex = 0;
            this.se_connecter.Text = "Se Connecter";
            this.se_connecter.UseVisualStyleBackColor = true;
            this.se_connecter.Click += new System.EventHandler(this.se_connecter_Click);
            // 
            // uname
            // 
            this.uname.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(230, 130);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(330, 25);
            this.uname.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(230, 188);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(330, 25);
            this.pwd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(91, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom d\'Utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(91, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe";
            // 
            // quitter
            // 
            this.quitter.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(417, 278);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(143, 37);
            this.quitter.TabIndex = 5;
            this.quitter.Text = "Quitter";
            this.quitter.Click += new System.EventHandler(this.quitter_Click_1);
            // 
            // pwd_visible
            // 
            this.pwd_visible.AutoSize = true;
            this.pwd_visible.BackColor = System.Drawing.Color.Transparent;
            this.pwd_visible.Checked = true;
            this.pwd_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pwd_visible.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_visible.ForeColor = System.Drawing.Color.Silver;
            this.pwd_visible.Location = new System.Drawing.Point(230, 230);
            this.pwd_visible.Name = "pwd_visible";
            this.pwd_visible.Size = new System.Drawing.Size(121, 18);
            this.pwd_visible.TabIndex = 6;
            this.pwd_visible.Text = "Mot de Passe visible";
            this.pwd_visible.UseVisualStyleBackColor = false;
            this.pwd_visible.CheckedChanged += new System.EventHandler(this.pwd_visible_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(260, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Authentification";
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwd_visible);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.se_connecter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button se_connecter;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.CheckBox pwd_visible;
        private System.Windows.Forms.Label label3;
    }
}