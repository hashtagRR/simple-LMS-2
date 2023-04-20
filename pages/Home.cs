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

namespace SarasaviLibrary
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tile_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tile_register_book_Click(object sender, EventArgs e)
        {
            Register_book form = new Register_book();
            form.Show();
            this.Hide();
        }

        private void tile_member_management_Click(object sender, EventArgs e)
        {
            Member_management form = new Member_management();
            form.Show();
            this.Hide();
        }

        private void tile_visitor_management_Click(object sender, EventArgs e)
        {
            Visitor_management form = new Visitor_management();
            form.Show();
            this.Hide();
        }

        private void tile_search_book_Click(object sender, EventArgs e)
        {
            Make_inquiry form = new Make_inquiry();
            form.Show();
            this.Hide();
        }

        private void tile_loan_Click(object sender, EventArgs e)
        {
            Loan form = new Loan();
            form.Show();
            this.Hide();
        }

        private void tile_return_book_Click(object sender, EventArgs e)
        {
            Return form = new Return();
            form.Show();
            this.Hide();
        }

        private void tile_reserve_book_Click(object sender, EventArgs e)
        {
            Reservations form = new Reservations();
            form.Show();
            this.Hide();
        }

        private void tile_admin_Click(object sender, EventArgs e)
        {
            Librarian_management form = new Librarian_management();
            form.Show();
            this.Hide();
        }
    }
}
