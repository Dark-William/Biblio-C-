namespace Biblio
{
    partial class Gerer_Emprunts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerer_Emprunts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView_Emprunt = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelAdhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliothécairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauBibliothécaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesBibliothéairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emprunt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 52);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(506, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 25);
            this.button8.TabIndex = 20;
            this.button8.Text = "Recherche";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 25);
            this.textBox1.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(80, 445);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 30);
            this.button7.TabIndex = 33;
            this.button7.Text = "Actualiser";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView_Emprunt
            // 
            this.dataGridView_Emprunt.AllowUserToAddRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView_Emprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Emprunt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Emprunt.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Emprunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Emprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Emprunt.Location = new System.Drawing.Point(14, 98);
            this.dataGridView_Emprunt.Name = "dataGridView_Emprunt";
            this.dataGridView_Emprunt.ReadOnly = true;
            this.dataGridView_Emprunt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Emprunt.Size = new System.Drawing.Size(860, 332);
            this.dataGridView_Emprunt.TabIndex = 32;
            this.dataGridView_Emprunt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Emprunt_CellContentClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(749, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 31;
            this.button6.Text = "Quitter";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(375, 445);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "Supprimer Emprunt";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(203, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ajouter Emprunt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(887, 27);
            this.menuStrip1.TabIndex = 35;
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
            this.gérerLesAdhérentsToolStripMenuItem});
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // nouvelAdhérentToolStripMenuItem
            // 
            this.nouvelAdhérentToolStripMenuItem.Name = "nouvelAdhérentToolStripMenuItem";
            this.nouvelAdhérentToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.nouvelAdhérentToolStripMenuItem.Text = "Nouvel adhérent";
            this.nouvelAdhérentToolStripMenuItem.Click += new System.EventHandler(this.nouvelAdhérentToolStripMenuItem_Click);
            // 
            // gérerLesAdhérentsToolStripMenuItem
            // 
            this.gérerLesAdhérentsToolStripMenuItem.Name = "gérerLesAdhérentsToolStripMenuItem";
            this.gérerLesAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.gérerLesAdhérentsToolStripMenuItem.Text = "Gérer les adhérents";
            this.gérerLesAdhérentsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesAdhérentsToolStripMenuItem_Click);
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelEmpruntToolStripMenuItem});
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
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(564, 445);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "Retour Emprunt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gerer_Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView_Emprunt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Gerer_Emprunts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerer_Emprunts";
            this.Load += new System.EventHandler(this.Gerer_Emprunts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emprunt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView_Emprunt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelAdhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliothécairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauBibliothécaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesBibliothéairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}