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
    public partial class Ajouter_Adherent : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        public Ajouter_Adherent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errors())
            {
                MessageBox.Show("Remplissez Les champs obligatoires (*)", "Ajouter bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);// Notify user for error.
            }
            else
            {
                conn.Open();
                string Query = "insert into adherent(code_ad, num_recu, nom_adherent, telephone) values(" + textBox1.Text + ", '" + textBox2.Text + "','" + textBox3.Text + "'," + textBox6.Text + ")";
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Ajout effectué avec succès", "Ajouter Adherent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
            this.Hide();
        }

        private void gérerLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Adherents ger_ad = new Gerer_Adherents();
            ger_ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Errors()
        {
            if (textBox1.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (textBox2.Text.Trim() == String.Empty)
                return true;

            if (textBox3.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            return false;
        }
    }
}
