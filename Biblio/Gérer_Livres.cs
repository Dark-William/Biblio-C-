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
    public partial class Gérer_Livres : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        MySqlCommand cmd;
        private Bitmap bitmap;
        public Gérer_Livres()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter_Livre a_li = new Ajouter_Livre();
            a_li.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Livre mod_s = new Modifier_Supprimer_Livre();
            mod_s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Livre mod_s = new Modifier_Supprimer_Livre();
            mod_s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 100, 50, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            groupBox1.Hide();
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 100, 50, s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("select * from ouvrage", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "select * from ouvrage where nom_ouvrage ='" + textBox1.Text + "'";
            cmd.Connection = conn;
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }

        private void Gérer_Livres_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd = new MySqlCommand("select * from ouvrage", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}
