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
    public partial class Bibliothecaire : Form
    {
        public Bibliothecaire()
        {
            InitializeComponent();
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouvelAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerLesBibliothéairesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauLivreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ajouter_Livre a_li = new Ajouter_Livre();
            a_li.Show();
        }

        private void gérerLivresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gérer_Livres g_li = new Gérer_Livres();
            g_li.Show();
            this.Hide();
        }

        private void nouvelEmpruntToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ajouter_Emprunt em = new Ajouter_Emprunt();
            em.Show();
        }

        private void gérerEmpruntsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gerer_Emprunts ep = new Gerer_Emprunts();
            ep.Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
