using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Ajouter_Biblio : Form
    {
        public Ajouter_Biblio()
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
                string conn = "server = localhost;  userid= root; password=; database = bibliotheque";
                string Query = "insert into personnel (matricule,nom_personnel,usename,password,adresse,email) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection Con = new MySqlConnection(conn);
                //This is command class which will handle the query and connection object.  
                MySqlCommand Command = new MySqlCommand(Query, Con);
                MySqlDataReader Reader;
                Con.Open();
                Reader = Command.ExecuteReader();
                Con.Close();
                MessageBox.Show("Ajout effectué", "Ajouter bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Errors()
        {
            if (textBox1.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (textBox2.Text.Trim() == String.Empty)
                return true;

            if (textBox3.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            if (textBox4.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found if (textBox1.Text.Trim() == String.Empty)

            return false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" regex de l'email
            if (IsValid(textBox5.Text))
            {
                MessageBox.Show("Entrez une adress Mail valide");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
