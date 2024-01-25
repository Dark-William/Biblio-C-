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
    public partial class Home : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Visible = false;
            this.timer1.Start();
            progressBar1.Maximum = 100;
            i = 1;

        }
        int i;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);
            progressBar1.Value = progressBar1.Value + 1;
            label3.Text = i + "%";
            i += 1;
            if (i == 100)
            {
                try
                {
                    conn.Open();
                    label2.Visible = false;
                    label3.Visible = false;
                    progressBar1.Visible = false;
                    Authentification auth = new Authentification();
                    auth.Show();
                    this.Hide();
                    /*MessageBox.Show("Connected!");
                   
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if(i>100)
            {
                timer1.Enabled = false;
            }
            //timer2.Start();
            
        }


        /* private void connexion()
         {
             MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
             try
             {
                 conn.Open();
                 MessageBox.Show("Connected!");
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }
         }*/
    }
}
