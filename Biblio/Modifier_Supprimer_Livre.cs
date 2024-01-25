using MySql.Data.MySqlClient;
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
    public partial class Modifier_Supprimer_Livre : Form
    {
        public Modifier_Supprimer_Livre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
            string Query = "update   ouvrage set nom_ouvrage ='" + textBox2.Text + "',description ='" + textBox4.Text + "',qte ='" + textBox6.Text + "',auteur ='" + textBox3.Text + "' where Code='" + comboBox1.SelectedItem.ToString() + "'";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection Con = new MySqlConnection(conn);
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, Con);
            MySqlDataReader Reader;
            Con.Open();
            Reader = Command.ExecuteReader();
            Con.Close();
            MessageBox.Show("Modification  effectuée", "Modifier Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
            string Query = "delete from  ouvrage where Code='" + comboBox1.SelectedItem.ToString() + "'";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection Con = new MySqlConnection(conn);
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, Con);
            MySqlDataReader Reader;
            Con.Open();
            Reader = Command.ExecuteReader();
            Con.Close();
            MessageBox.Show("Suppression  effectuée", "Sup Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select * from ouvrage where Code ='" + comboBox1.SelectedItem.ToString() + "'", conn);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                // comboBox1.Items.Add(dr["code"].ToString());
                textBox2.Text = dr["nom_ouvrage"].ToString();
                textBox3.Text = dr["auteur"].ToString();
                textBox4.Text = dr["description"].ToString();
                textBox6.Text = dr["qte"].ToString();

            }
        }

        private void Modifier_Supprimer_Livre_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select * from ouvrage ", conn);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                comboBox1.Items.Add(dr["code"].ToString());


            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
