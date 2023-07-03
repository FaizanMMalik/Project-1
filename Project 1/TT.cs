using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class TT : Form

    {
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project1 ; Data Source = FAIZAN101";
        public TT()
        {
            InitializeComponent();
        }

        private void TT_Load(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TT a = new TT();
            a.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VC a = new VC();
            a.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact a = new Contact();
            a.Show();
            this.Hide();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service a = new Service();
            a.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btntapin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string query = "INSERT INTO dbo.TT(ModuleName,Time) VAlUES('" + txtmname.Text + "','" + txttime.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Successfully Tapped In ");

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(strConn);
            //string query = "select * from TT";

            //con.Open();
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader dataReader = cmd.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    DGV.Rows.Add(dataReader[0], dataReader[1], dataReader[2]);
            //}
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

