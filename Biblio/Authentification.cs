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
    public partial class Authentification : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void se_connecter_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter Da = new MySqlDataAdapter("select * from personnel where usename like '" + uname.Text + "' and password like '" + pwd.Text + "'", conn);
                DataTable Dt = new DataTable();
                Dt.Clear();
                Da.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {

                    if (Dt.Rows[0][7].ToString() == "1")
                    {
                        //MessageBox.Show("Admin");
                        Admin admin = new Admin();
                        admin.Show();
                        conn.Close();
                    }

                    else if (Dt.Rows[0][7].ToString() == "0")
                    {
                        //MessageBox.Show("Bibliothécaire");
                        Bibliothecaire user = new Bibliothecaire();
                        user.Show();
                        conn.Close();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Le Nom d'utilisateur ou le Mot de passe est incorrect !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pwd_visible_CheckedChanged(object sender, EventArgs e)
        {
            if (pwd_visible.Checked)
            {
                pwd.UseSystemPasswordChar = false;
            }
            else
                pwd.UseSystemPasswordChar = true;
        }
    }
}
