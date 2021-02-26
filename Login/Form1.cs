using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbutt_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Account name\Documents\(DataBase file name).accdb");
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" + usernameinput.Text + "' AND Password='" + passwordinput.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                // this.Hide();
                // new Editor().Show();

                MessageBox.Show("Logged in!");
            }
            else
                MessageBox.Show("Incorret username or password");
        }

        private void usernameinput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerbutt_Click(object sender, EventArgs e)
        {

        }
    }
}
