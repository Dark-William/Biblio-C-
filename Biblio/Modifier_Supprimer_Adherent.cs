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
    public partial class Modifier_Supprimer_Adherent : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        MySqlCommand cmd;
        MySqlDataReader dr;
        string ot;
        public Modifier_Supprimer_Adherent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select id_adherent from adherent where code_ad ='" + comboBox1.Text.ToString() + "'", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ot = (dr["id_adherent"].ToString());
            }
            dr.Close();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2 = new MySqlCommand("select * from adherent where id_adherent ='" + ot + "'", conn);
            dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                string recu = dr["num_recu"].ToString();
                string nom = dr["nom_adherent"].ToString();
                string telephone = dr["telephone"].ToString();
                textBox2.Enabled = true; textBox2.Text = recu;
                textBox3.Enabled = true; textBox3.Text = nom;
                textBox6.Enabled = true; textBox6.Text = telephone;

            }
            dr.Close();
            conn.Close();
        }

        private void Modifier_Supprimer_Adherent_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            conn.Open();
            cmd = new MySqlCommand("select * from adherent ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["code_ad"].ToString());

            }
            dr.Close();
            conn.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "update adherent set num_recu = " + textBox2.Text + " , nom_adherent = '" + textBox3.Text +  "' , telephone = " + textBox6.Text + " where id_adherent = '" + ot + "'";
            MySqlCommand Command = new MySqlCommand(Query, conn);
            dr = Command.ExecuteReader();
            conn.Close();
            MessageBox.Show("Modification effectuée avec succès !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "delete from  adherent where id_adherent ='" + ot + "'";
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, conn);
            dr = Command.ExecuteReader();
            conn.Close();
            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
