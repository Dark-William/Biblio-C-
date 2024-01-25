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
    public partial class Ajouter_Emprunt : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        MySqlCommand cmd;
        MySqlDataReader dr;
        string ot;
        string at;
        string it;
        public Ajouter_Emprunt()
        {
            InitializeComponent();
        }

        private void get_adherent()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from adherent ", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["nom_adherent"].ToString());

            }
            dr.Close();
            
            conn.Close();
        }
        private void get_livre()
        {
            conn.Open();
            cmd = new MySqlCommand("select * from ouvrage ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["nom_ouvrage"].ToString());

            }
            dr.Close();
            conn.Close();
        }

        private void get_bibliothecaire()
        {
            conn.Open();
            cmd = new MySqlCommand("select * from personnel ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["nom_personnel"].ToString());

            }
            dr.Close();
            
            conn.Close();
        }

        private void Ajouter_Emprunt_Load(object sender, EventArgs e)
        {
            get_adherent();
            get_livre();
            get_bibliothecaire();
        }


        private void nouvelAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent aj_ad = new Ajouter_Adherent();
            aj_ad.Show();
            this.Hide();
        }

        private void gérerLesAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Adherents ger_ad = new Gerer_Adherents();
            ger_ad.Show();
            this.Hide();
        }

        private void gérerLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select * from adherent where nom_adherent ='" + comboBox3.Text.ToString() + "'", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                at = (dr["id_adherent"].ToString());
                //comboBox3.Items.Add(dr["id_adherent"].ToString());

            }
            dr.Close();
            /*MySqlCommand cmd2 = new MySqlCommand("select * from adherent where nom_adherent ='" + comboBox5.Text.ToString() + "'", conn);
            MySqlDataReader da = cmd2.ExecuteReader();
            while (da.Read())
            {
                comboBox1.Items.Add(dr["id_adherent"].ToString());

            }
            da.Close();*/
            conn.Close();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select * from ouvrage where nom_ouvrage='" + comboBox1.Text.ToString() + "'", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                it = (dr["id_ouvrage"].ToString());
                //comboBox1.Items.Add(dr["id_ouvrage"].ToString());

            }
            dr.Close();
            
           
            conn.Close();
        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select id_personnel from personnel where nom_personnel='" + comboBox2.Text.ToString() + "'", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ot = (dr["id_personnel"].ToString());
                //comboBox2.Items.Add(dr["id_personnel"].ToString());
            }
            //MessageBox.Show(ot);
            dr.Close();
            
            conn.Close();
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
                string Query = "insert into emprunt(code_emprunt,date_emprunt,date_retour,id_ouvrage,id_adherent,id_personnel) values(" + textBox1.Text + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + it + "'," + at + "," + ot + ")";
                cmd = new MySqlCommand(Query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Ajouté avec Succès", "Ajouter Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Errors()
        {
            if (textBox1.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (comboBox1.Text.Trim() == String.Empty)
                return true;

            if (comboBox2.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            if (comboBox3.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            return false;
        }
    }
}
