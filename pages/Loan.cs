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
    public partial class Loan : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Loan()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string mid = txt_mid.Text;
            string c1 = txt_lcp1.Text;
            string c2 = txt_lcp2.Text;
            string c3 = txt_lcp3.Text;
            string c4 = txt_lcp4.Text;
            string c5 = txt_lcp5.Text;
            string date = txt_ldead.Text;

            if (string.IsNullOrEmpty(mid) || string.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please fill member ID and/or deadline");
            }
            else
            {
                try
                {
                    con.Open();
                    com.CommandText = "INSERT INTO [loan](c1,c2,c3,c4,c5,deadline,member_id) VALUES('" + c1 + "','" + c2 + "','" + c3 + "','" + c4 + "','" + c5 + "','" + date + "','" + mid + "')";
                     int n = com.ExecuteNonQuery();
                    if (n <= 0)
                        MessageBox.Show("Loan could not added");
                    else
                    {
                        com.CommandText = "UPDATE [copy] SET copy_current_status='Borrowed' WHERE copy_id='" + c1 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Borrowed' WHERE copy_id='" + c2 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Borrowed' WHERE copy_id='" + c3 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Borrowed' WHERE copy_id='" + c4 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Borrowed' WHERE copy_id='" + c5 + "'";
                        com.ExecuteNonQuery();

                        
                        
                        MessageBox.Show("Loan Sucessfully Added");
                        txt_mid.Clear();
                        txt_lcp1.Clear();
                        txt_lcp2.Clear();
                        txt_lcp3.Clear();
                        txt_lcp4.Clear();
                        txt_lcp5.Clear();
                        txt_ldead.ResetText();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Loan could not be Added. " + err.Message);
                    con.Close();
                }
                con.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mid = txt_memid.Text;
            if (string.IsNullOrEmpty(mid))
            {
                MessageBox.Show("Please fill the member ID");
            }
            else
            {
                try
                {
                    com.CommandText = "SELECT * FROM loan WHERE member_id='" + mid + "'";
                    con.Open();
                    OleDbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    txt_cpy1.Text = dr[2].ToString();
                    txt_cp2.Text = dr[2].ToString();
                    txt_cp3.Text = dr[3].ToString();
                    txt_cp4.Text = dr[4].ToString();
                    txt_cp5.Text = dr[5].ToString();
                    txt_deadline.Text = dr[6].ToString();


                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No prior loans");
                    con.Close();
                }
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string mid = cid.Text;
            if (string.IsNullOrEmpty(mid))
            {
                MessageBox.Show("Please fill the copy ID");
            }
            else
            {
                try
                {
                    com.CommandText = "SELECT * FROM reservation WHERE copy_id='" + mid + "'";
                    con.Open();
                    OleDbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    rsvid.Text = dr[0].ToString();
                    rvdate.Text = dr[3].ToString();
                    rsvmid.Text = dr[2].ToString();

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No availible reservations");
                    con.Close();
                }
            }
        }
    }
}
