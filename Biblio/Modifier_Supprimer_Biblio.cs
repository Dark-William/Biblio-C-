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
    public partial class Modifier_Supprimer_Biblio : Form
    {
        public Modifier_Supprimer_Biblio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
            string Query = "update   personnel set nom_personnel ='" + textBox2.Text + "',usename ='" + textBox3.Text + "',password ='" + textBox4.Text + "',adresse='" + textBox5.Text + "', email = '" + textBox6.Text + "' where matricule='" + comboBox1.SelectedItem.ToString() + "'";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection Con = new MySqlConnection(conn);
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, Con);
            MySqlDataReader Reader;
            Con.Open();
            Reader = Command.ExecuteReader();
            Con.Close();
            MessageBox.Show("Modification  effectuée", "Modifier Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
            string Query = "delete from  personnel where matricule='" + comboBox1.SelectedItem.ToString() + "'";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection Con = new MySqlConnection(conn);
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, Con);
            MySqlDataReader Reader;
            Con.Open();
            Reader = Command.ExecuteReader();
            Con.Close();
            MessageBox.Show("Suppression  effectuée", "Sup Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select * from personnel where matricule ='" + comboBox1.SelectedItem.ToString() + "'and permission= '" + 0 + "'", conn);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                // comboBox1.Items.Add(dr["code"].ToString());
                textBox2.Text = dr["nom_personnel"].ToString();
                textBox3.Text = dr["usename"].ToString();
                textBox4.Text = dr["password"].ToString();
                textBox5.Text = dr["adresse"].ToString();
                textBox6.Text = dr["email"].ToString();

            }
        }

        private void Modifier_Supprimer_Biblio_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select * from personnel ", conn);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                comboBox1.Items.Add(dr["matricule"].ToString());


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select * from personnel where matricule ='" + comboBox1.SelectedItem.ToString() + "'and permission= '" + 0 + "'", conn);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                // comboBox1.Items.Add(dr["code"].ToString());
                textBox2.Text = dr["nom_personnel"].ToString();
                textBox3.Text = dr["usename"].ToString();
                textBox4.Text = dr["password"].ToString();
                textBox5.Text = dr["adresse"].ToString();
                textBox6.Text = dr["email"].ToString();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }
    }
}
