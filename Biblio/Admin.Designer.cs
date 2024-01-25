namespace Biblio
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelAdhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliothécairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauBibliothécaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesBibliothéairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livresToolStripMenuItem,
            this.adhérentsToolStripMenuItem,
            this.empruntsToolStripMenuItem,
            this.bibliothécairesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 27);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauLivreToolStripMenuItem,
            this.gérerLivresToolStripMenuItem});
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.livresToolStripMenuItem.Text = "Livres";
            // 
            // nouveauLivreToolStripMenuItem
            // 
            this.nouveauLivreToolStripMenuItem.Name = "nouveauLivreToolStripMenuItem";
            this.nouveauLivreToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.nouveauLivreToolStripMenuItem.Text = "Nouveau livre";
            this.nouveauLivreToolStripMenuItem.Click += new System.EventHandler(this.nouveauLivreToolStripMenuItem_Click);
            // 
            // gérerLivresToolStripMenuItem
            // 
            this.gérerLivresToolStripMenuItem.Name = "gérerLivresToolStripMenuItem";
            this.gérerLivresToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.gérerLivresToolStripMenuItem.Text = "Gérer les livres";
            this.gérerLivresToolStripMenuItem.Click += new System.EventHandler(this.gérerLivresToolStripMenuItem_Click);
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelAdhérentToolStripMenuItem,
            this.gérerAdhérentsToolStripMenuItem});
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // nouvelAdhérentToolStripMenuItem
            // 
            this.nouvelAdhérentToolStripMenuItem.Name = "nouvelAdhérentToolStripMenuItem";
            this.nouvelAdhérentToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.nouvelAdhérentToolStripMenuItem.Text = "Nouvel adhérent";
            this.nouvelAdhérentToolStripMenuItem.Click += new System.EventHandler(this.nouvelAdhérentToolStripMenuItem_Click);
            // 
            // gérerAdhérentsToolStripMenuItem
            // 
            this.gérerAdhérentsToolStripMenuItem.Name = "gérerAdhérentsToolStripMenuItem";
            this.gérerAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.gérerAdhérentsToolStripMenuItem.Text = "Gérer Adhérents";
            this.gérerAdhérentsToolStripMenuItem.Click += new System.EventHandler(this.gérerAdhérentsToolStripMenuItem_Click);
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelEmpruntToolStripMenuItem,
            this.gérerEmpruntsToolStripMenuItem});
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.empruntsToolStripMenuItem.Text = "Emprunts";
            // 
            // nouvelEmpruntToolStripMenuItem
            // 
            this.nouvelEmpruntToolStripMenuItem.Name = "nouvelEmpruntToolStripMenuItem";
            this.nouvelEmpruntToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.nouvelEmpruntToolStripMenuItem.Text = "Nouvel emprunt";
            this.nouvelEmpruntToolStripMenuItem.Click += new System.EventHandler(this.nouvelEmpruntToolStripMenuItem_Click);
            // 
            // gérerEmpruntsToolStripMenuItem
            // 
            this.gérerEmpruntsToolStripMenuItem.Name = "gérerEmpruntsToolStripMenuItem";
            this.gérerEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.gérerEmpruntsToolStripMenuItem.Text = "Gérer Emprunts";
            this.gérerEmpruntsToolStripMenuItem.Click += new System.EventHandler(this.gérerEmpruntsToolStripMenuItem_Click);
            // 
            // bibliothécairesToolStripMenuItem
            // 
            this.bibliothécairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauBibliothécaireToolStripMenuItem,
            this.gérerLesBibliothéairesToolStripMenuItem});
            this.bibliothécairesToolStripMenuItem.Name = "bibliothécairesToolStripMenuItem";
            this.bibliothécairesToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.bibliothécairesToolStripMenuItem.Text = "Bibliothécaires";
            // 
            // nouveauBibliothécaireToolStripMenuItem
            // 
            this.nouveauBibliothécaireToolStripMenuItem.Name = "nouveauBibliothécaireToolStripMenuItem";
            this.nouveauBibliothécaireToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.nouveauBibliothécaireToolStripMenuItem.Text = "Nouveau bibliothécaire";
            this.nouveauBibliothécaireToolStripMenuItem.Click += new System.EventHandler(this.nouveauBibliothécaireToolStripMenuItem_Click);
            // 
            // gérerLesBibliothéairesToolStripMenuItem
            // 
            this.gérerLesBibliothéairesToolStripMenuItem.Name = "gérerLesBibliothéairesToolStripMenuItem";
            this.gérerLesBibliothéairesToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.gérerLesBibliothéairesToolStripMenuItem.Text = "Gérer les bibliothéaires";
            this.gérerLesBibliothéairesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesBibliothéairesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 499);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelAdhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerEmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliothécairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauBibliothécaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesBibliothéairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerAdhérentsToolStripMenuItem;
    }
}