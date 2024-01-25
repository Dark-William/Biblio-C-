using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Livre li = new Ajouter_Livre();
            li.Show();
        }

        private void gérerLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gérer_Livres gli = new Gérer_Livres();
            gli.Show();
            this.Hide();
        }

        private void nouvelAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent ad = new Ajouter_Adherent();
            ad.Show();
        }

        private void gérerAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Adherents gad = new Gerer_Adherents();
            gad.Show();
            this.Close();
        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt ad = new Ajouter_Emprunt();
            ad.Show();
        }

        private void gérerEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Emprunts gad = new Gerer_Emprunts();
            gad.Show();
            this.Close();
        }

        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Biblio gad = new Ajouter_Biblio();
            gad.Show();
        }

        private void gérerLesBibliothéairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Biblio gad = new Gerer_Biblio();
            gad.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
