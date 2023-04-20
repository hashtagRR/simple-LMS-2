namespace SarasaviLibrary
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tile_logout = new MetroFramework.Controls.MetroTile();
            this.tile_register_book = new MetroFramework.Controls.MetroTile();
            this.tile_admin = new MetroFramework.Controls.MetroTile();
            this.tile_reserve_book = new MetroFramework.Controls.MetroTile();
            this.tile_search_book = new MetroFramework.Controls.MetroTile();
            this.tile_loan = new MetroFramework.Controls.MetroTile();
            this.tile_return_book = new MetroFramework.Controls.MetroTile();
            this.tile_visitor_management = new MetroFramework.Controls.MetroTile();
            this.tile_member_management = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::SarasaviLibrary.Properties.Resources.stack_of_books;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.tile_logout);
            this.metroPanel1.Controls.Add(this.tile_register_book);
            this.metroPanel1.Controls.Add(this.tile_admin);
            this.metroPanel1.Controls.Add(this.tile_reserve_book);
            this.metroPanel1.Controls.Add(this.tile_search_book);
            this.metroPanel1.Controls.Add(this.tile_loan);
            this.metroPanel1.Controls.Add(this.tile_return_book);
            this.metroPanel1.Controls.Add(this.tile_visitor_management);
            this.metroPanel1.Controls.Add(this.tile_member_management);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 13;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 55);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(955, 590);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // tile_logout
            // 
            this.tile_logout.ActiveControl = null;
            this.tile_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_logout.ForeColor = System.Drawing.Color.Black;
            this.tile_logout.Location = new System.Drawing.Point(890, 0);
            this.tile_logout.Name = "tile_logout";
            this.tile_logout.Size = new System.Drawing.Size(65, 78);
            this.tile_logout.TabIndex = 11;
            this.tile_logout.Text = "Logout";
            this.tile_logout.TileImage = global::SarasaviLibrary.Properties.Resources.download2;
            this.tile_logout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_logout.UseCustomBackColor = true;
            this.tile_logout.UseCustomForeColor = true;
            this.tile_logout.UseSelectable = true;
            this.tile_logout.UseTileImage = true;
            this.tile_logout.Click += new System.EventHandler(this.tile_logout_Click);
            // 
            // tile_register_book
            // 
            this.tile_register_book.ActiveControl = null;
            this.tile_register_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_register_book.ForeColor = System.Drawing.Color.Black;
            this.tile_register_book.Location = new System.Drawing.Point(293, 134);
            this.tile_register_book.Name = "tile_register_book";
            this.tile_register_book.Size = new System.Drawing.Size(129, 156);
            this.tile_register_book.TabIndex = 10;
            this.tile_register_book.Text = "Book/ Copy\r\nManagement";
            this.tile_register_book.TileImage = global::SarasaviLibrary.Properties.Resources.download1;
            this.tile_register_book.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_register_book.UseCustomBackColor = true;
            this.tile_register_book.UseCustomForeColor = true;
            this.tile_register_book.UseSelectable = true;
            this.tile_register_book.UseTileImage = true;
            this.tile_register_book.Click += new System.EventHandler(this.tile_register_book_Click);
            // 
            // tile_admin
            // 
            this.tile_admin.ActiveControl = null;
            this.tile_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_admin.ForeColor = System.Drawing.Color.Black;
            this.tile_admin.Location = new System.Drawing.Point(704, 335);
            this.tile_admin.Name = "tile_admin";
            this.tile_admin.Size = new System.Drawing.Size(129, 156);
            this.tile_admin.TabIndex = 9;
            this.tile_admin.Text = "Librarian\r\nManagement";
            this.tile_admin.TileImage = global::SarasaviLibrary.Properties.Resources.download__3_1;
            this.tile_admin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_admin.UseCustomBackColor = true;
            this.tile_admin.UseCustomForeColor = true;
            this.tile_admin.UseSelectable = true;
            this.tile_admin.UseTileImage = true;
            this.tile_admin.Click += new System.EventHandler(this.tile_admin_Click);
            // 
            // tile_reserve_book
            // 
            this.tile_reserve_book.ActiveControl = null;
            this.tile_reserve_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_reserve_book.ForeColor = System.Drawing.Color.Black;
            this.tile_reserve_book.Location = new System.Drawing.Point(704, 134);
            this.tile_reserve_book.Name = "tile_reserve_book";
            this.tile_reserve_book.Size = new System.Drawing.Size(129, 156);
            this.tile_reserve_book.TabIndex = 7;
            this.tile_reserve_book.Text = "Reserve\r\nBook";
            this.tile_reserve_book.TileImage = global::SarasaviLibrary.Properties.Resources.travel_25_256;
            this.tile_reserve_book.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_reserve_book.UseCustomBackColor = true;
            this.tile_reserve_book.UseCustomForeColor = true;
            this.tile_reserve_book.UseSelectable = true;
            this.tile_reserve_book.UseTileImage = true;
            this.tile_reserve_book.Click += new System.EventHandler(this.tile_reserve_book_Click);
            // 
            // tile_search_book
            // 
            this.tile_search_book.ActiveControl = null;
            this.tile_search_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_search_book.ForeColor = System.Drawing.Color.Black;
            this.tile_search_book.Location = new System.Drawing.Point(293, 335);
            this.tile_search_book.Name = "tile_search_book";
            this.tile_search_book.Size = new System.Drawing.Size(129, 156);
            this.tile_search_book.TabIndex = 6;
            this.tile_search_book.Text = "Search Book/\r\nCheck Copy";
            this.tile_search_book.TileImage = global::SarasaviLibrary.Properties.Resources.search;
            this.tile_search_book.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_search_book.UseCustomBackColor = true;
            this.tile_search_book.UseCustomForeColor = true;
            this.tile_search_book.UseSelectable = true;
            this.tile_search_book.UseTileImage = true;
            this.tile_search_book.Click += new System.EventHandler(this.tile_search_book_Click);
            // 
            // tile_loan
            // 
            this.tile_loan.ActiveControl = null;
            this.tile_loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_loan.ForeColor = System.Drawing.Color.Black;
            this.tile_loan.Location = new System.Drawing.Point(510, 134);
            this.tile_loan.Name = "tile_loan";
            this.tile_loan.Size = new System.Drawing.Size(129, 156);
            this.tile_loan.TabIndex = 5;
            this.tile_loan.Text = "Loan";
            this.tile_loan.TileImage = global::SarasaviLibrary.Properties.Resources.download__2_1;
            this.tile_loan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_loan.UseCustomBackColor = true;
            this.tile_loan.UseCustomForeColor = true;
            this.tile_loan.UseSelectable = true;
            this.tile_loan.UseTileImage = true;
            this.tile_loan.Click += new System.EventHandler(this.tile_loan_Click);
            // 
            // tile_return_book
            // 
            this.tile_return_book.ActiveControl = null;
            this.tile_return_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_return_book.ForeColor = System.Drawing.Color.Black;
            this.tile_return_book.Location = new System.Drawing.Point(510, 335);
            this.tile_return_book.Name = "tile_return_book";
            this.tile_return_book.Size = new System.Drawing.Size(129, 156);
            this.tile_return_book.TabIndex = 4;
            this.tile_return_book.Text = "Return";
            this.tile_return_book.TileImage = global::SarasaviLibrary.Properties.Resources.download__1_1;
            this.tile_return_book.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_return_book.UseCustomBackColor = true;
            this.tile_return_book.UseCustomForeColor = true;
            this.tile_return_book.UseSelectable = true;
            this.tile_return_book.UseTileImage = true;
            this.tile_return_book.Click += new System.EventHandler(this.tile_return_book_Click);
            // 
            // tile_visitor_management
            // 
            this.tile_visitor_management.ActiveControl = null;
            this.tile_visitor_management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_visitor_management.ForeColor = System.Drawing.Color.Black;
            this.tile_visitor_management.Location = new System.Drawing.Point(89, 335);
            this.tile_visitor_management.Name = "tile_visitor_management";
            this.tile_visitor_management.Size = new System.Drawing.Size(129, 156);
            this.tile_visitor_management.TabIndex = 3;
            this.tile_visitor_management.Text = "Visitor \r\nManagement";
            this.tile_visitor_management.TileImage = global::SarasaviLibrary.Properties.Resources.download__1_;
            this.tile_visitor_management.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_visitor_management.UseCustomBackColor = true;
            this.tile_visitor_management.UseCustomForeColor = true;
            this.tile_visitor_management.UseSelectable = true;
            this.tile_visitor_management.UseTileImage = true;
            this.tile_visitor_management.Click += new System.EventHandler(this.tile_visitor_management_Click);
            // 
            // tile_member_management
            // 
            this.tile_member_management.ActiveControl = null;
            this.tile_member_management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tile_member_management.ForeColor = System.Drawing.Color.Black;
            this.tile_member_management.Location = new System.Drawing.Point(89, 134);
            this.tile_member_management.Name = "tile_member_management";
            this.tile_member_management.Size = new System.Drawing.Size(129, 156);
            this.tile_member_management.TabIndex = 2;
            this.tile_member_management.Text = "Member \r\nManagement";
            this.tile_member_management.TileImage = global::SarasaviLibrary.Properties.Resources.member_icon1;
            this.tile_member_management.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_member_management.UseCustomBackColor = true;
            this.tile_member_management.UseCustomForeColor = true;
            this.tile_member_management.UseSelectable = true;
            this.tile_member_management.UseTileImage = true;
            this.tile_member_management.Click += new System.EventHandler(this.tile_member_management_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 646);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(26, 87, 26, 29);
            this.Resizable = false;
            this.Text = "                         Sarasavi Library Management System - Home Window";
            this.Load += new System.EventHandler(this.Home_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile tile_member_management;
        private MetroFramework.Controls.MetroTile tile_visitor_management;
        private MetroFramework.Controls.MetroTile tile_register_book;
        private MetroFramework.Controls.MetroTile tile_admin;
        private MetroFramework.Controls.MetroTile tile_reserve_book;
        private MetroFramework.Controls.MetroTile tile_search_book;
        private MetroFramework.Controls.MetroTile tile_loan;
        private MetroFramework.Controls.MetroTile tile_return_book;
        private MetroFramework.Controls.MetroTile tile_logout;
    }
}