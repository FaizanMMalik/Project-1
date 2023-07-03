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
    public partial class Login : Form
    {
       
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project1 ; Data Source =";
        public Login()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtEpass.Text;
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Login where username='" + username + "' and password='" + password + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Login Successfull !");
                TT a = new TT();
                a.Show();
                this.Hide();
            }
            else
            {
                string message = "Invalid Username or Password!";
                string title = "Login Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Retry)
                {

                    txtusername.Text = "";
                    txtEpass.Text = "";
                }
                else
                {
                    // Do something  
                }


            }
        }

        private void txtEpass_TextChanged(object sender, EventArgs e)
        {
            txtEpass.PasswordChar = '*';
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblEpass_Click(object sender, EventArgs e)
        {

        }

        private void lblEname_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
