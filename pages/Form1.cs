using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace SarasaviLibrary
{
    public partial class Form1 : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Form1()
        {
            InitializeComponent();
            com = new OleDbCommand("", con);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string un = txtun.Text;
            string pw = txtpw.Text;
            if (String.IsNullOrEmpty(un) || String.IsNullOrEmpty(pw))
            {
                MessageBox.Show("Please Fill Both Fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM librarian WHERE username='" + un + "' AND passwords='" + pw + "'";

                    OleDbDataReader dr = com.ExecuteReader();
                    int n = 0;
                    while (dr.Read())
                    {
                        n = n + 1;

                    }
                    if (n == 1)
                    {
                        con.Close();
                        con.Dispose();
                        this.Hide();
                        Home form = new Home();
                        form.Show();


                    }
                    else if (n > 1)
                    {
                        MessageBox.Show("More than one users are using this username and password. Please make new acount with different credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (n == 0)
                    {
                        MessageBox.Show("Username and/ Password is Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("" + err.Message);
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
