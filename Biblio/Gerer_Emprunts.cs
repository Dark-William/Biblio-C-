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
    public partial class Gerer_Emprunts : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque; Convert Zero Datetime=True");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Gerer_Emprunts()
        {
            InitializeComponent();
        }

        private void nouvelAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent aj_ad = new Ajouter_Adherent();
            aj_ad.Show();
        }

        private void gérerLesAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Adherents ger_ad = new Gerer_Adherents();
            ger_ad.Show();
            this.Hide();
        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt aj_emp = new Ajouter_Emprunt();
            aj_emp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supprimer_Emprunts sup_emp = new Supprimer_Emprunts();
            sup_emp.Show();
        }

        private void Gerer_Emprunts_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter cmd = new MySqlDataAdapter("select code_emprunt, nom_ouvrage, nom_adherent, date_emprunt, retour_def, nom_personnel, statut from emprunt inner join ouvrage inner join personnel inner join adherent where emprunt.id_ouvrage = ouvrage.id_ouvrage and emprunt.id_adherent = adherent.id_adherent and emprunt.id_personnel = personnel.id_personnel", conn);
            DataTable Dt = new DataTable();
            cmd.Fill(Dt);
            dataGridView_Emprunt.DataSource = Dt;
            /*dataGridView_Emprunt.Columns[1].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView_Emprunt.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView_Emprunt.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";*/
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("select * from emprunt join ouvrage where ouvrage.nom_ouvrage like '%" + textBox1.Text + "%'", conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Emprunt.DataSource = dt;
            dr.Close();
        }

        private void dataGridView_Emprunt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retour_Emprunt rem = new Retour_Emprunt();
            rem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            MySqlDataAdapter cmd = new MySqlDataAdapter("select nom_ouvrage, nom_adherent, date_emprunt, date_retour, nom_personnel, statut from emprunt inner join ouvrage inner join personnel inner join adherent where emprunt.id_ouvrage = ouvrage.id_ouvrage and emprunt.id_adherent = adherent.id_adherent and emprunt.id_personnel = personnel.id_personnel", conn);
            DataTable Dt = new DataTable();
            cmd.Fill(Dt);
            dataGridView_Emprunt.DataSource = Dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt aj_emp = new Ajouter_Emprunt();
            aj_emp.Show();
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Livre ji = new Ajouter_Livre();
            ji.Show();
        }

        private void gérerLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gérer_Livres li = new Gérer_Livres();
            li.Show();
            this.Hide();
        }

        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Biblio bi = new Ajouter_Biblio();
            bi.Show();
        }

        private void gérerLesBibliothéairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Biblio bg = new Gerer_Biblio();
            bg.Show();
            this.Hide();
        }
    }
}
