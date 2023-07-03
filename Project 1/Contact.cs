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
    public partial class Contact : Form
    {
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project1 ; Data Source = FAIZAN101";
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string query = "UPDATE  dbo.Contact set Name='" + txtname.Text + "',DOB='" + txtdob.Text + "',Email='" + txtemail.Text + "'" +
                ",PhoneNumber='" + txtphone.Text + "',Course='" + txtcourse.Text + "',Address='" + txtaddress.Text + "',PostCode='" + txtpostcode.Text + "',City='" + txtcity.Text + "' Where id='" + txtid.Text + "'";
         
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Saved New Contact Details !");
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Contact";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                DGV.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5], dataReader[6], dataReader[7], dataReader[8]);
            }
        }
    }
}
