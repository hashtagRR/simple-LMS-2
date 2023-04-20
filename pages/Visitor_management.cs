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
    public partial class Visitor_management : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Visitor_management()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Visitor_management_Load(object sender, EventArgs e)
        {
            

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string fn = txtfn.Text;
            try
            {
                com.CommandText = "SELECT * FROM visitor WHERE full_name='" + fn + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txtvid.Text = dr[0].ToString();
                txtfn.Text = dr[1].ToString();
                txtnic.Text = dr[2].ToString();
                txtbday.Text = dr[3].ToString();
                txtaddress.Text = dr[4].ToString();
                txtcontact.Text = dr[5].ToString();

                if (dr[6].ToString() == "Male")
                    radiomale.Checked = true;
                else
                    radiofemale.Checked = true;

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the visitor" + err.Message);
                con.Close();
            }
    }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string vid = txtvid.Text;
            string fn = txtfn.Text;
            string nic = txtnic.Text;
            string add = txtaddress.Text;
            string tp = txtcontact.Text;
            string bday = txtbday.Text;
            string gender;
            if (string.IsNullOrEmpty(vid) || string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(add) ||
                string.IsNullOrEmpty(tp) || string.IsNullOrEmpty(bday))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                if (radiomale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                MessageBox.Show("Visitor Id is  :" + vid +
                    "\n Visitor Name is  :" + fn +
                    "\n Visitor b'day is  :" + bday +
                    "\n Visitor NIC no is  :" + nic +
                    "\n Visitor address is   :" + add +
                    "\n Visitor contact no is   :" + tp +
                    "\n Visitor Gender is   :" + gender);
                try
                {
                    com.CommandText = "INSERT INTO [visitor](visitor_id,full_name,nic_no,b_day,address,contact_no,gender) VALUES('" + vid + "','" + fn + "','" + nic + "','" + bday + "','" + add + "','" + tp + "','" + gender + "')";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Visitor Sucessfully Added");
                }
                catch (Exception)
                {
                    MessageBox.Show("Visitor could not be Added. ");
                    con.Close();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string mid = txtvid.Text;
            string fn = txtfn.Text;
            string nic = txtnic.Text;
            string add = txtaddress.Text;
            string tp = txtcontact.Text;
            string bday = txtbday.Text;

            if (string.IsNullOrEmpty(mid) || string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(add) ||
                string.IsNullOrEmpty(tp) || string.IsNullOrEmpty(bday))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string gender;
                if (radiomale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                MessageBox.Show("Visitor Id is " + mid +
                    "\n Visitor Name is " + fn +
                    "\n Visitor b'day is " + bday +
                    "\n Visitor NIC no is " + nic +
                    "\n Visitor address is " + add +
                    "\n Visitor contact no is " + tp +
                    "\n Visitor Gender is " + gender);
                try
                {
                    com.CommandText = "UPDATE [visitor] SET full_name='" + fn + "',nic_no='" + nic + "',b_day='" + bday + "',contact_no='" + tp + "',address='" + add + "',gender='" + gender + "' WHERE visitor_id='" + mid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect visitor ID");
                    else
                        MessageBox.Show("Visitor details successfully updated");

                }
                catch (Exception err)
                {
                    MessageBox.Show("Visitor could not be updated. " + err.Message);
                    con.Close();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string mid = txtvid.Text;
            try
            {
                com.CommandText = "SELECT * FROM visitor WHERE visitor_id='" + mid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txtvid.Text = dr[0].ToString();
                txtfn.Text = dr[1].ToString();
                txtnic.Text = dr[2].ToString();
                txtbday.Text = dr[3].ToString();
                txtaddress.Text = dr[4].ToString();
                txtcontact.Text = dr[5].ToString();

                if (dr[6].ToString() == "Male")
                    radiomale.Checked = true;
                else
                    radiofemale.Checked = true;

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the visitor" + err.Message);
                con.Close();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string nic = txtnic.Text;
            try
            {
                com.CommandText = "SELECT * FROM visitor WHERE nic_no='" + nic + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txtvid.Text = dr[0].ToString();
                txtfn.Text = dr[1].ToString();
                txtnic.Text = dr[2].ToString();
                txtbday.Text = dr[3].ToString();
                txtaddress.Text = dr[4].ToString();
                txtcontact.Text = dr[5].ToString();

                if (dr[6].ToString() == "Male")
                    radiomale.Checked = true;
                else
                    radiofemale.Checked = true;

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the visitor" + err.Message);
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string mid = txtvid.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // MessageBox.Show("Deleted successfully");

                try
                {
                    com.CommandText = "DELETE FROM [visitor] WHERE visitor_id='" + mid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect visitor ID");
                    else
                        MessageBox.Show("Visitor Sucessfully Deleted");


                }
                catch (Exception err)
                {
                    MessageBox.Show("Visitor could not be Deleted. " + err.Message);
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Record not deleted");

            }
        }
    }
}
