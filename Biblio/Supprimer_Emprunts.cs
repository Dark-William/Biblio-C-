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
    public partial class Supprimer_Emprunts : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        MySqlCommand cmd;
        MySqlDataReader dr;
        string ot;
       // string at;
       // string it;
        public Supprimer_Emprunts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "delete emprunt where id_emprunt = " + ot + "";
            MySqlCommand Command = new MySqlCommand(Query, conn);
            dr = Command.ExecuteReader();
            //cmd = new MySqlCommand("delete emprunt where id_emprunt = " + ot + "", conn);
            conn.Close();
            MessageBox.Show("Emprunt supprimé !!", "Supprimer Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Supprimer_Emprunts_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select * from emprunt ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["code_emprunt"].ToString());

            }
            dr.Close();
            conn.Close();
        }

        public void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string Query ="select id_emprunt from emprunt where code_emprunt=" + comboBox4.Text.ToString() + "";
            cmd = new MySqlCommand(Query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ot = (dr["id_emprunt"].ToString());
            }
            //MessageBox.Show(ot);
            dr.Close();
            string Query2 = "select emprunt.code_emprunt, emprunt.date_emprunt, emprunt.date_retour, emprunt.statut, adherent.code_ad, ouvrage.Code, personnel.matricule from emprunt join ouvrage join adherent join personnel where emprunt.id_emprunt = '" + ot + "' and emprunt.id_ouvrage = ouvrage.id_ouvrage and emprunt.id_adherent = adherent.id_adherent and emprunt.id_personnel = personnel.id_personnel;";
            MySqlCommand cmd2_1 = new MySqlCommand(Query2, conn);
            MySqlDataReader dr2 = cmd2_1.ExecuteReader();
            while (dr2.Read())
            {
                string livre = dr2["Code"].ToString();
                string bibliothecaire = dr2["matricule"].ToString();
                string adherent = dr2["code_ad"].ToString();
                string date_emprunt = dr2["date_emprunt"].ToString();
                string date_retour = dr2["date_retour"].ToString();
                comboBox1.Text = livre;
                comboBox1.Enabled = false;
                comboBox2.Text = bibliothecaire;
                comboBox2.Enabled = false;
                comboBox3.Text = adherent;
                comboBox3.Enabled = false;
                dateTimePicker1.Text = date_emprunt;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker2.Text = date_retour;

            }
            dr2.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
