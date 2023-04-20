namespace SarasaviLibrary
{
    partial class Form1
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
            this.btnexit = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.txtpw = new MetroFramework.Controls.MetroTextBox();
            this.txtun = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::SarasaviLibrary.Properties.Resources.a_book_a_week_image;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.btnexit);
            this.metroPanel1.Controls.Add(this.btnlogin);
            this.metroPanel1.Controls.Add(this.txtpw);
            this.metroPanel1.Controls.Add(this.txtun);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(351, 309);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Crimson;
            this.btnexit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnexit.Location = new System.Drawing.Point(212, 209);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 33);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnexit.UseCustomBackColor = true;
            this.btnexit.UseSelectable = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnlogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnlogin.Location = new System.Drawing.Point(27, 209);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 33);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnlogin.UseCustomBackColor = true;
            this.btnlogin.UseSelectable = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpw
            // 
            // 
            // 
            // 
            this.txtpw.CustomButton.Image = null;
            this.txtpw.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtpw.CustomButton.Name = "";
            this.txtpw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpw.CustomButton.TabIndex = 1;
            this.txtpw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpw.CustomButton.UseSelectable = true;
            this.txtpw.CustomButton.Visible = false;
            this.txtpw.Lines = new string[0];
            this.txtpw.Location = new System.Drawing.Point(159, 125);
            this.txtpw.MaxLength = 32767;
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpw.SelectedText = "";
            this.txtpw.SelectionLength = 0;
            this.txtpw.SelectionStart = 0;
            this.txtpw.Size = new System.Drawing.Size(128, 23);
            this.txtpw.TabIndex = 5;
            this.txtpw.UseSelectable = true;
            this.txtpw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtun
            // 
            // 
            // 
            // 
            this.txtun.CustomButton.Image = null;
            this.txtun.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtun.CustomButton.Name = "";
            this.txtun.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtun.CustomButton.TabIndex = 1;
            this.txtun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtun.CustomButton.UseSelectable = true;
            this.txtun.CustomButton.Visible = false;
            this.txtun.Lines = new string[0];
            this.txtun.Location = new System.Drawing.Point(159, 75);
            this.txtun.MaxLength = 32767;
            this.txtun.Name = "txtun";
            this.txtun.PasswordChar = '\0';
            this.txtun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtun.SelectedText = "";
            this.txtun.SelectionLength = 0;
            this.txtun.SelectionStart = 0;
            this.txtun.Size = new System.Drawing.Size(128, 23);
            this.txtun.TabIndex = 4;
            this.txtun.UseSelectable = true;
            this.txtun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(27, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(27, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "User Name :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 381);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Text = "Sarasavi Library Admin Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnlogin;
        private MetroFramework.Controls.MetroTextBox txtpw;
        private MetroFramework.Controls.MetroTextBox txtun;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnexit;
    }
}

