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
    public partial class Make_inquiry : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Make_inquiry()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Make_inquiry_Load(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
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
            string cid = txt_bookid.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE book_id='" + cid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_isbn.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();
                txt_type.Text = dr[5].ToString();

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the book" + err.Message);
                con.Close();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string cid = txt_title.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE title='" + cid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_isbn.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();
                txt_type.Text = dr[5].ToString();

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the book" + err.Message);
                con.Close();
            }
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            string cid = txt_isbn.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE ISBN_no='" + cid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_isbn.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();
                txt_type.Text = dr[5].ToString();

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the book" + err.Message);
                con.Close();
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string coid = cid.Text;
            try
            {
                com.CommandText = "SELECT * FROM copy WHERE copy_id='" + coid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                cbid.Text = dr[1].ToString();
                ctitle.Text = dr[2].ToString();
                cstatus.Text = dr[3].ToString();
               

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not find the book" + err.Message);
                con.Close();
            }
        }
    }
    

   
}
