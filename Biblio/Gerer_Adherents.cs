using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblio
{
    public partial class Gerer_Adherents : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Gerer_Adherents()
        {
            InitializeComponent();
        }


        private void gérerLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Emprunts ger_emp = new Gerer_Emprunts();
            ger_emp.Show();
            this.Hide();
        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt aj_emp = new Ajouter_Emprunt();
            aj_emp.Show();
        }

        private void nouvelAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent aj_ad = new Ajouter_Adherent();
            aj_ad.Show();
        }

        private void Gerer_Adherents_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("select * from adherent", conn);
            dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = "select * from adherent where nom_adherent like '" + textBox1.Text + "' or num_recu like '" + textBox1.Text + "' or telephone like '" + textBox1.Text + "' ";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            dr.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("select * from adherent", conn);
            dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent ajouter_adherent = new Ajouter_Adherent();
            ajouter_adherent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Adherent modifier_supprimer_adherent = new Modifier_Supprimer_Adherent();
            modifier_supprimer_adherent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Adherent modifier_supprimer_adherent = new Modifier_Supprimer_Adherent();
            modifier_supprimer_adherent.Show();
        }

        private void gérerEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Emprunts gerer_emprunt = new Gerer_Emprunts();
            gerer_emprunt.Show();
            this.Hide();
        }

        private void dataGridView_Adherent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Biblio bi = new Ajouter_Biblio();
            bi.Show();
        }


        private void gérerLesBibliothéairesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gerer_Biblio bg = new Gerer_Biblio();
            bg.Show();
            this.Hide();
        }

        private void nouveauLivreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ajouter_Livre ji = new Ajouter_Livre();
            ji.Show();
        }

        private void gérerLivresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gérer_Livres li = new Gérer_Livres();
            li.Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
