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
    public partial class Ajouter_Livre : Form
    {
        public Ajouter_Livre()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
            string Query = "insert into ouvrage (code,nom_ouvrage,description,qte,auteur) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection Con = new MySqlConnection(conn);
            //This is command class which will handle the query and connection object.  
            MySqlCommand Command = new MySqlCommand(Query, Con);
            MySqlDataReader Reader;
            Con.Open();
            Reader = Command.ExecuteReader();
            Con.Close();
            MessageBox.Show("Ajout effectué", "Ajouter Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void Ajouter_Livre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errors())
            {
                MessageBox.Show("Remplissez Les champs obligatoires (*)", "Ajouter bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);// Notify user for error.
            }
            else
            {
                string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
                string Query = "insert into ouvrage (code,nom_ouvrage,description,qte,auteur) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection Con = new MySqlConnection(conn);
                //This is command class which will handle the query and connection object.  
                MySqlCommand Command = new MySqlCommand(Query, Con);
                MySqlDataReader Reader;
                Con.Open();
                Reader = Command.ExecuteReader();
                Con.Close();
                MessageBox.Show("Ajout effectué", "Ajouter Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
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
            if (textBox2.Text.Trim() == String.Empty)
                return true;

            if (textBox3.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            return false;
        }
    }


}
