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
    public partial class Register_book : MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sarasavi_DB.accdb");
        OleDbCommand com;
        public Register_book()
        {
            com = new OleDbCommand("", con);
            InitializeComponent();
        }

        private void Register_book_Load(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
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
            string bid = txt_bookid.Text;
            string isbn = txt_isbnno.Text;
            string title = txt_title.Text;
            string author = txt_author.Text;
            string year = txt_year.Text;
            string type;

            if (string.IsNullOrEmpty(bid) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(year) )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                if (radioborrowable.Checked)
                {
                    type = "Borrowable";
                }
                else
                {
                    type = "Reference";
                }

                MessageBox.Show("Book Id is  :" + bid +
                    "\n Book ISBN no is   :" + isbn +
                    "\n Book title is   :" + title +
                    "\n Book author no is :" + author +
                    "\n Book year no is :" + year +
                    "\n Book type is  :" + type);
                   
                try
                {
                    com.CommandText = "INSERT INTO [books](book_id,ISBN_no,title,author,book_year,type) VALUES('" + bid + "','" + isbn + "','" + title + "','" + author + "','" + year + "','" + type + "')";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Sucessfully Added");
                }
                catch (Exception )
                {
                    MessageBox.Show("Book could not be Added. ");
                    con.Close();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string bid = txt_bookid.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE book_id='" + bid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_bookid.Text = dr[0].ToString();
                txt_isbnno.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();


                if (dr[5].ToString() == "Reference")
                    radireference.Checked = true;
                else
                    radioborrowable.Checked = true;


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Inceoorect book ID");
                con.Close();
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            string isbn = txt_isbnno.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE isbn_no='" + isbn + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_bookid.Text = dr[0].ToString();
                txt_isbnno.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();


                if (dr[5].ToString() == "Reference")
                    radireference.Checked = true;
                else
                    radioborrowable.Checked = true;

                con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Incorrect ISBN no" );
                con.Close();
            }
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            try
            {
                com.CommandText = "SELECT * FROM books WHERE title='" + title + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_bookid.Text = dr[0].ToString();
                txt_isbnno.Text = dr[1].ToString();
                txt_title.Text = dr[2].ToString();
                txt_author.Text = dr[3].ToString();
                txt_year.Text = dr[4].ToString();


                if (dr[5].ToString() == "Reference")
                    radireference.Checked = true;
                else
                    radioborrowable.Checked = true;

                con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Incorrect book title" );
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string bid = txt_bookid.Text;
            string isbn = txt_isbnno.Text;
            string title = txt_title.Text;
            string author = txt_author.Text;
            string year = txt_year.Text;
            string type;

            if (string.IsNullOrEmpty(bid) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
               
                if (radireference.Checked)
                {
                    type = "Reference";
                }
                else
                {
                    type = "Borrowable";
                }

                MessageBox.Show("Book Id is  :" + bid +
                    "\n Book ISBN no is   :" + isbn +
                    "\n Book title is   :" + title +
                    "\n Book author no is :" + author +
                    "\n Book year is  :" + year +
                    "\n Book type is  :" + type);
                try
                {
                    com.CommandText = "UPDATE [books] SET ISBN_no='" + isbn + "',title='" + title + "',author='" + author + "',book_year='" + year + "',type='" + type + "' WHERE book_id='" + bid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect book ID");
                    else
                        MessageBox.Show("BooK details successfully updated");

                }
                catch (Exception err)
                {
                    MessageBox.Show("Book could not be updated. " + err.Message);
                    con.Close();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string bid = txt_bookid.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // MessageBox.Show("Deleted successfully");

                try
                {
                    com.CommandText = "DELETE FROM [books] WHERE book_id='" + bid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect book ID");
                    else
                        MessageBox.Show("Book Sucessfully Deleted");


                }
                catch (Exception err)
                {
                    MessageBox.Show("Book could not be Deleted. " + err.Message);
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Record not deleted");

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string cid = txt_copyid.Text;
            string cbid = book_id.Text;
            string ctitle = txt_titlecopy.Text;
           

            if (string.IsNullOrEmpty(cid) || string.IsNullOrEmpty(cbid) || string.IsNullOrEmpty(ctitle))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
               
                MessageBox.Show("Copy Id is  :" + cid +
                    "\n Book ID is   :" + cbid +
                    "\n Copy title is   :" + ctitle );

                try
                {
                    com.CommandText = "INSERT INTO [copy](copy_id,book_id,copy_title,copy_current_status) VALUES('" + cid + "','" + cbid + "','" + ctitle + "',' Available ')";
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Copy Sucessfully Added");
                }
                catch (Exception)
                {
                    MessageBox.Show("Copy could not be Added. ");
                    con.Close();
                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string cid = txt_copyid.Text;
            try
            {
                com.CommandText = "SELECT * FROM copy WHERE copy_id='" + cid + "'";
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                dr.Read();
                txt_copyid.Text = dr[0].ToString();
                book_id.Text = dr[1].ToString();
                txt_titlecopy.Text = dr[2].ToString();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect copy ID");
                con.Close();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string cid = txt_copyid.Text;
            string cbid = book_id.Text;
            string ctitle = txt_titlecopy.Text;

            if (string.IsNullOrEmpty(cid) || string.IsNullOrEmpty(cbid) || string.IsNullOrEmpty(ctitle))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {

                MessageBox.Show("Book Id is  :" + cid +
                    "\n Book ISBN no is   :" + cbid +
                    "\n Book title is   :" + ctitle );
                try
                {
                    com.CommandText = "UPDATE [copy] SET copy_title='" + ctitle + "',book_id='" + cbid + "',copy_current_status='Availible' WHERE copy_id='" + cid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect copy ID");
                    else
                        MessageBox.Show("Copy details successfully updated");

                }
                catch (Exception err)
                {
                    MessageBox.Show("Copy could not be updated. " + err.Message);
                    con.Close();
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string cid = txt_copyid.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // MessageBox.Show("Deleted successfully");

                try
                {
                    com.CommandText = "DELETE FROM [copy] WHERE copy_id='" + cid + "'";
                    con.Open();
                    int n = com.ExecuteNonQuery();
                    con.Close();
                    if (n <= 0)
                        MessageBox.Show("Incorrect copy ID");
                    else
                        MessageBox.Show("Copy Sucessfully Deleted");


                }
                catch (Exception)
                {
                    MessageBox.Show("Copy could not be Deleted. ");
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
