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
    public partial class Return : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Return()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mid = txt_memid.Text;
            try
            {
                com.CommandText = "SELECT * FROM loan WHERE member_id='" + mid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_cp1.Text = dr[2].ToString();
                txt_cp2.Text = dr[2].ToString();
                txt_cp3.Text = dr[3].ToString();
                txt_cp4.Text = dr[4].ToString();
                txt_cp5.Text = dr[5].ToString();
                txt_deadline.Text = dr[6].ToString();


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid member ID" );
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string bid = txt_memid.Text;
            string c1 = txt_cp1.Text;
            string c2 = txt_cp2.Text;
            string c3 = txt_cp3.Text;
            string c4 = txt_cp4.Text;
            string c5 = txt_cp5.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // MessageBox.Show("Deleted successfully");

                try
                {
                    con.Open();
                    com.CommandText = "DELETE FROM [loan] WHERE member_id='" + bid + "'";
                    int n = com.ExecuteNonQuery();
                    if (n <= 0)
                        MessageBox.Show("Record not Found");
                    else
                    {
                        com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + c1 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + c2 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + c3 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + c4 + "'";
                        com.ExecuteNonQuery();

                        com.CommandText = "UPDATE [copy] SET copy_current_status='Availible' WHERE copy_id='" + c5 + "'";
                        com.ExecuteNonQuery();

                        MessageBox.Show("Loan Sucessfully claimed");
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Loan could not be Claimed. " + err.Message);
                    con.Close();
                }
                con.Close();
            }

            else
            {
                MessageBox.Show("Record not deleted");

            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string mid = cid.Text;
            try
            {
                com.CommandText = "SELECT * FROM reservation WHERE copy_id='" + mid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                rsvid.Text = dr[0].ToString();
                rsvdate.Text = dr[3].ToString();
                rsvmid.Text = dr[2].ToString();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Copy is not reserved" );
                con.Close();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
    }
    
    
}
