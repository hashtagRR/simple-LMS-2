namespace SarasaviLibrary
{
    partial class Member_management
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.btnupdate = new MetroFramework.Controls.MetroButton();
            this.btndelete = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.radiofemale = new MetroFramework.Controls.MetroRadioButton();
            this.radiomale = new MetroFramework.Controls.MetroRadioButton();
            this.txtbday = new MetroFramework.Controls.MetroDateTime();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfn = new MetroFramework.Controls.MetroTextBox();
            this.txtcontact = new MetroFramework.Controls.MetroTextBox();
            this.txtnic = new MetroFramework.Controls.MetroTextBox();
            this.txtmid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sarasaviDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sarasavi_DBDataSet = new SarasaviLibrary.Sarasavi_DBDataSet();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new SarasaviLibrary.Sarasavi_DBDataSetTableAdapters.membersTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarasaviDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarasavi_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Aquamarine;
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.btnsave);
            this.metroPanel1.Controls.Add(this.btnupdate);
            this.metroPanel1.Controls.Add(this.btndelete);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.radiofemale);
            this.metroPanel1.Controls.Add(this.radiomale);
            this.metroPanel1.Controls.Add(this.txtbday);
            this.metroPanel1.Controls.Add(this.txtaddress);
            this.metroPanel1.Controls.Add(this.txtfn);
            this.metroPanel1.Controls.Add(this.txtcontact);
            this.metroPanel1.Controls.Add(this.txtnic);
            this.metroPanel1.Controls.Add(this.txtmid);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(421, 554);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.Orange;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton4.Location = new System.Drawing.Point(288, 120);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(108, 34);
            this.metroButton4.TabIndex = 24;
            this.metroButton4.Text = "Search by NIC";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(95, 25);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(129, 19);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Add new member";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(13, 484);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 34);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.UseCustomBackColor = true;
            this.btnsave.UseCustomForeColor = true;
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnupdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(149, 484);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 34);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseCustomBackColor = true;
            this.btnupdate.UseCustomForeColor = true;
            this.btnupdate.UseSelectable = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(288, 484);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 34);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseCustomBackColor = true;
            this.btndelete.UseCustomForeColor = true;
            this.btndelete.UseSelectable = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Orange;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(288, 70);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 34);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Search by ID";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // radiofemale
            // 
            this.radiofemale.AutoSize = true;
            this.radiofemale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radiofemale.Location = new System.Drawing.Point(197, 271);
            this.radiofemale.Name = "radiofemale";
            this.radiofemale.Size = new System.Drawing.Size(68, 19);
            this.radiofemale.TabIndex = 15;
            this.radiofemale.Text = "Female";
            this.radiofemale.UseCustomBackColor = true;
            this.radiofemale.UseCustomForeColor = true;
            this.radiofemale.UseSelectable = true;
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radiomale.Location = new System.Drawing.Point(128, 271);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(55, 19);
            this.radiomale.TabIndex = 14;
            this.radiomale.Text = "Male";
            this.radiomale.UseCustomBackColor = true;
            this.radiomale.UseCustomForeColor = true;
            this.radiomale.UseSelectable = true;
            // 
            // txtbday
            // 
            this.txtbday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtbday.Location = new System.Drawing.Point(128, 218);
            this.txtbday.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtbday.Name = "txtbday";
            this.txtbday.Size = new System.Drawing.Size(137, 29);
            this.txtbday.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(128, 380);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(137, 68);
            this.txtaddress.TabIndex = 12;
            // 
            // txtfn
            // 
            // 
            // 
            // 
            this.txtfn.CustomButton.Image = null;
            this.txtfn.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtfn.CustomButton.Name = "";
            this.txtfn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfn.CustomButton.TabIndex = 1;
            this.txtfn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfn.CustomButton.UseSelectable = true;
            this.txtfn.CustomButton.Visible = false;
            this.txtfn.Lines = new string[0];
            this.txtfn.Location = new System.Drawing.Point(128, 177);
            this.txtfn.MaxLength = 32767;
            this.txtfn.Name = "txtfn";
            this.txtfn.PasswordChar = '\0';
            this.txtfn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfn.SelectedText = "";
            this.txtfn.SelectionLength = 0;
            this.txtfn.SelectionStart = 0;
            this.txtfn.Size = new System.Drawing.Size(137, 23);
            this.txtfn.TabIndex = 11;
            this.txtfn.UseSelectable = true;
            this.txtfn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtcontact
            // 
            // 
            // 
            // 
            this.txtcontact.CustomButton.Image = null;
            this.txtcontact.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtcontact.CustomButton.Name = "";
            this.txtcontact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcontact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcontact.CustomButton.TabIndex = 1;
            this.txtcontact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcontact.CustomButton.UseSelectable = true;
            this.txtcontact.CustomButton.Visible = false;
            this.txtcontact.Lines = new string[0];
            this.txtcontact.Location = new System.Drawing.Point(128, 319);
            this.txtcontact.MaxLength = 32767;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcontact.SelectedText = "";
            this.txtcontact.SelectionLength = 0;
            this.txtcontact.SelectionStart = 0;
            this.txtcontact.Size = new System.Drawing.Size(137, 23);
            this.txtcontact.TabIndex = 9;
            this.txtcontact.UseSelectable = true;
            this.txtcontact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcontact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtnic
            // 
            // 
            // 
            // 
            this.txtnic.CustomButton.Image = null;
            this.txtnic.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtnic.CustomButton.Name = "";
            this.txtnic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtnic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnic.CustomButton.TabIndex = 1;
            this.txtnic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnic.CustomButton.UseSelectable = true;
            this.txtnic.CustomButton.Visible = false;
            this.txtnic.Lines = new string[0];
            this.txtnic.Location = new System.Drawing.Point(128, 131);
            this.txtnic.MaxLength = 32767;
            this.txtnic.Name = "txtnic";
            this.txtnic.PasswordChar = '\0';
            this.txtnic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnic.SelectedText = "";
            this.txtnic.SelectionLength = 0;
            this.txtnic.SelectionStart = 0;
            this.txtnic.Size = new System.Drawing.Size(137, 23);
            this.txtnic.TabIndex = 8;
            this.txtnic.UseSelectable = true;
            this.txtnic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtmid
            // 
            // 
            // 
            // 
            this.txtmid.CustomButton.Image = null;
            this.txtmid.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtmid.CustomButton.Name = "";
            this.txtmid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmid.CustomButton.TabIndex = 1;
            this.txtmid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmid.CustomButton.UseSelectable = true;
            this.txtmid.CustomButton.Visible = false;
            this.txtmid.Lines = new string[0];
            this.txtmid.Location = new System.Drawing.Point(128, 81);
            this.txtmid.MaxLength = 32767;
            this.txtmid.Name = "txtmid";
            this.txtmid.PasswordChar = '\0';
            this.txtmid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmid.SelectedText = "";
            this.txtmid.SelectionLength = 0;
            this.txtmid.SelectionStart = 0;
            this.txtmid.Size = new System.Drawing.Size(137, 23);
            this.txtmid.TabIndex = 7;
            this.txtmid.UseSelectable = true;
            this.txtmid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(18, 218);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "B\'day";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 381);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Address";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(18, 319);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Contact No";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(18, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Full Name";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(18, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "NIC No";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(18, 268);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Gender";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(18, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Member ID";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // sarasaviDBDataSetBindingSource
            // 
            this.sarasaviDBDataSetBindingSource.DataSource = this.sarasavi_DBDataSet;
            this.sarasaviDBDataSetBindingSource.Position = 0;
            // 
            // sarasavi_DBDataSet
            // 
            this.sarasavi_DBDataSet.DataSetName = "Sarasavi_DBDataSet";
            this.sarasavi_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Location = new System.Drawing.Point(5, 15);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 34);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Home";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.sarasavi_DBDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // Member_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 605);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Member_management";
            this.Resizable = false;
            this.Text = "            Member Management";
            this.Load += new System.EventHandler(this.Member_management_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarasaviDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarasavi_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtmid;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtfn;
        private MetroFramework.Controls.MetroTextBox txtcontact;
        private MetroFramework.Controls.MetroTextBox txtnic;
        private MetroFramework.Controls.MetroRadioButton radiofemale;
        private MetroFramework.Controls.MetroRadioButton radiomale;
        private MetroFramework.Controls.MetroDateTime txtbday;
        private System.Windows.Forms.TextBox txtaddress;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton btnupdate;
        private MetroFramework.Controls.MetroButton btndelete;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton4;
        private Sarasavi_DBDataSet sarasavi_DBDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private Sarasavi_DBDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.BindingSource sarasaviDBDataSetBindingSource;
    }
}