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
    public partial class Reservations : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Reservations()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string cid = txt_memid.Text;
            string cpyid = txt_cpyid.Text;
            string cdate = txt_date.Text;


            if (string.IsNullOrEmpty(cid) || string.IsNullOrEmpty(cpyid) || string.IsNullOrEmpty(cdate))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    com.CommandText = "INSERT INTO reservation (copy_id,member_id,resv_date) VALUES ('"+cpyid+"','"+cid+"','"+cdate+"')";
                   com.ExecuteNonQuery();

                    com.CommandText = "UPDATE [copy] SET copy_current_status='Reserved' WHERE copy_id='" + cpyid + "'";
                    com.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Reservation Sucessfully Added");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Copy could not be Added. " + err.Message);
                    con.Close();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string cid = txt_cpyid.Text;
            try
            {
                com.CommandText = "SELECT * FROM reservation WHERE copy_id='" + cid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_memid.Text = dr[2].ToString();
                txt_date.Text = dr[3].ToString();
                con.Close();

                com.CommandText = "SELECT * FROM copy WHERE copy_id='" + cid + "'";
                con.Open();
                OleDbDataReader dt = com.ExecuteReader();
                dt.Read();
                current_status.Text = dt[3].ToString();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Invalid copy ID" + err.Message);
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string cid = txt_cpyid.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // MessageBox.Show("Deleted successfully");

                try
                {
                    con.Open();
                  
                    com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + cid + "'";
                    int n = com.ExecuteNonQuery();
                    if (n <= 0)
                        MessageBox.Show("Incorrect copy ID");
                    else
                        MessageBox.Show("Reservation seccussfully removed");
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show("Resevation could not be Removed. " + err.Message);
                   
                }
                con.Close();
            }

            else
            {
                MessageBox.Show("Record not deleted");

            }
        }
    }
}
