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
    public partial class Librarian_management : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Librarian_management()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Librarian_management_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string mid = txtlid.Text;
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

                MessageBox.Show("Librarian Id is " + mid +
                    "\n Librarian Name is " + fn +
                    "\n Librarian b'day is " + bday +
                    "\n Librarian NIC no is " + nic +
                    "\n Librarian address is " + add +
                    "\n Librarian contact no is " + tp +
                    "\n Librarian Gender is " + gender);
                try
                {
                    com.CommandText = "UPDATE [librarian] SET full_name='" + fn + "',nic_no='" + nic + "',b_day='" + bday + "',contact_no='" + tp + "',address='" + add + "',gender='" + gender + "',username='"+un+"',passwords='"+pw+"' WHERE librarian_id='" + mid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Record not Found");
                    else
                        MessageBox.Show("Librarian details successfully updated");

                }
                catch (Exception err)
                {
                    MessageBox.Show("Librarian could not be updated. " + err.Message);
                    con.Close();
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string mid = txtlid.Text;
            string fn = txtfn.Text;
            string nic = txtnic.Text;
            string add = txtaddress.Text;
            string tp = txtcontact.Text;
            string bday = txtbday.Text;
            string un1 = un.Text;
            string pw1 = pw.Text;
            string gender;
            if (string.IsNullOrEmpty(mid) || string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(add) ||
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

                MessageBox.Show("Librarian Id is  :" + mid +
                    "\n Librarian Name is  :" + fn +
                    "\n Librarian b'day is  :" + bday +
                    "\n Librarian NIC no is  :" + nic +
                    "\n Librarian address is   :" + add +
                    "\n Librarian contact no is   :" + tp +
                    "\n Librarian Gender is   :" + gender);
                try
                {
                    com.CommandText = "INSERT INTO librarian (ID,full_name,nic_no,b_day,address,contact_no,gender,passwords,username) VALUES('" + mid + "','" + fn + "','" + nic + "','" + bday + "','" + add + "','" + tp + "','" + gender + "','"+pw1+"','"+un1+"')";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Librarian Sucessfully Added");
                }
                catch (Exception)
                {
                    MessageBox.Show("Librarian could not be Added. " );
                    con.Close();
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id = txt_adminid.Text;
            string un = txt_adminun.Text;
            string pw = txt_adminpw.Text;
           

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(un) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                

                try
                {
                    com.CommandText = "INSERT INTO librarian (ID,username,passwords) VALUES('" + id + "','" + un + "','" + pw + "')";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Admin Sucessfully Added");
                }
                catch (Exception err )
                {
                    MessageBox.Show("New Admin could not be Added. " + err);
                    con.Close();
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string lid = txt_lid.Text;
            string pwold = txt_oldpw.Text;
            string pwnew = txt_newpw.Text;


            if (string.IsNullOrEmpty(lid) || string.IsNullOrEmpty(pwold) || string.IsNullOrEmpty(pwnew))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    com.CommandText = "UPDATE [librarian] SET passwords='" + pwnew + "' WHERE ID='" + lid + "' AND passwords='"+pwold+"'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Invalid username and/ old password");
                    else
                        MessageBox.Show("Password successfully updated");
                }
                catch (Exception)
                {
                    MessageBox.Show("Password could not be changed. " );
                    con.Close();
                }
            }
        }
    }
}
