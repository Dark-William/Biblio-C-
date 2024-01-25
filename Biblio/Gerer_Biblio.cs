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
    public partial class Gerer_Biblio : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn = new MySqlConnection("server = localhost;  userid= root; password=; database = bibliotheque");
        private Bitmap bitmap;
        public Gerer_Biblio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter_Biblio a_bi = new Ajouter_Biblio();
            a_bi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Biblio md_bi = new Modifier_Supprimer_Biblio();
            md_bi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Biblio md_bi = new Modifier_Supprimer_Biblio();
            md_bi.Show();
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
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 100, 50, s);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gerer_Biblio_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter("select matricule,nom_personnel,usename,email,adresse,password from personnel where permission='" + 0 + "'", conn);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dataGridView_Adherent.DataSource = Dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from personnel where permission ='" + 0 + "'", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "select * from personnel where nom_personnel like '" + textBox1.Text + "' or usename like '" + textBox1.Text + "'";
            cmd = new MySqlCommand(Query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            dr.Close();
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
