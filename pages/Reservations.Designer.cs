namespace SarasaviLibrary
{
    partial class Reservations
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
            this.current_status = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btndelete = new MetroFramework.Controls.MetroButton();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_date = new MetroFramework.Controls.MetroDateTime();
            this.txt_cpyid = new MetroFramework.Controls.MetroTextBox();
            this.txt_memid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Aquamarine;
            this.metroPanel1.Controls.Add(this.current_status);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btndelete);
            this.metroPanel1.Controls.Add(this.btnsave);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.txt_date);
            this.metroPanel1.Controls.Add(this.txt_cpyid);
            this.metroPanel1.Controls.Add(this.txt_memid);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(317, 312);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // current_status
            // 
            // 
            // 
            // 
            this.current_status.CustomButton.Image = null;
            this.current_status.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.current_status.CustomButton.Name = "";
            this.current_status.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.current_status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.current_status.CustomButton.TabIndex = 1;
            this.current_status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.current_status.CustomButton.UseSelectable = true;
            this.current_status.CustomButton.Visible = false;
            this.current_status.Lines = new string[0];
            this.current_status.Location = new System.Drawing.Point(113, 190);
            this.current_status.MaxLength = 32767;
            this.current_status.Name = "current_status";
            this.current_status.PasswordChar = '\0';
            this.current_status.ReadOnly = true;
            this.current_status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.current_status.SelectedText = "";
            this.current_status.SelectionLength = 0;
            this.current_status.SelectionStart = 0;
            this.current_status.Size = new System.Drawing.Size(108, 23);
            this.current_status.TabIndex = 30;
            this.current_status.UseSelectable = true;
            this.current_status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.current_status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(16, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Current Status";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(227, 262);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 34);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.UseCustomBackColor = true;
            this.btndelete.UseCustomForeColor = true;
            this.btndelete.UseSelectable = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(16, 262);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 34);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseCustomBackColor = true;
            this.btnsave.UseCustomForeColor = true;
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Orange;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(227, 52);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 34);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(113, 144);
            this.txt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(108, 29);
            this.txt_date.TabIndex = 20;
            // 
            // txt_cpyid
            // 
            // 
            // 
            // 
            this.txt_cpyid.CustomButton.Image = null;
            this.txt_cpyid.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txt_cpyid.CustomButton.Name = "";
            this.txt_cpyid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cpyid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cpyid.CustomButton.TabIndex = 1;
            this.txt_cpyid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cpyid.CustomButton.UseSelectable = true;
            this.txt_cpyid.CustomButton.Visible = false;
            this.txt_cpyid.Lines = new string[0];
            this.txt_cpyid.Location = new System.Drawing.Point(113, 63);
            this.txt_cpyid.MaxLength = 32767;
            this.txt_cpyid.Name = "txt_cpyid";
            this.txt_cpyid.PasswordChar = '\0';
            this.txt_cpyid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cpyid.SelectedText = "";
            this.txt_cpyid.SelectionLength = 0;
            this.txt_cpyid.SelectionStart = 0;
            this.txt_cpyid.Size = new System.Drawing.Size(108, 23);
            this.txt_cpyid.TabIndex = 19;
            this.txt_cpyid.UseSelectable = true;
            this.txt_cpyid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cpyid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_memid
            // 
            // 
            // 
            // 
            this.txt_memid.CustomButton.Image = null;
            this.txt_memid.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txt_memid.CustomButton.Name = "";
            this.txt_memid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_memid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memid.CustomButton.TabIndex = 1;
            this.txt_memid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memid.CustomButton.UseSelectable = true;
            this.txt_memid.CustomButton.Visible = false;
            this.txt_memid.Lines = new string[0];
            this.txt_memid.Location = new System.Drawing.Point(113, 103);
            this.txt_memid.MaxLength = 32767;
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.PasswordChar = '\0';
            this.txt_memid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memid.SelectedText = "";
            this.txt_memid.SelectionLength = 0;
            this.txt_memid.SelectionStart = 0;
            this.txt_memid.Size = new System.Drawing.Size(108, 23);
            this.txt_memid.TabIndex = 14;
            this.txt_memid.UseSelectable = true;
            this.txt_memid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(16, 154);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(38, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Date";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 67);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Copy ID";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Member ID";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Aquamarine;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(68, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Manage Reservations";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DarkBlue;
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton5.Location = new System.Drawing.Point(16, 23);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 34);
            this.metroButton5.TabIndex = 26;
            this.metroButton5.Text = "Home";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 373);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Reservations";
            this.Resizable = false;
            this.Text = "                  Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime txt_date;
        private MetroFramework.Controls.MetroTextBox txt_cpyid;
        private MetroFramework.Controls.MetroTextBox txt_memid;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox current_status;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btndelete;
    }
}