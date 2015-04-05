namespace instalink2
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.start = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.remember_box = new System.Windows.Forms.CheckBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_registered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(146, 142);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 42);
            this.start.TabIndex = 4;
            this.start.Text = "Zaloguj";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // end
            // 
            this.end.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.end.Location = new System.Drawing.Point(12, 142);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(128, 42);
            this.end.TabIndex = 5;
            this.end.Text = "Wyjdź";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(12, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(62, 13);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "Podaj login:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 64);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(67, 13);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Podaj hasło:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabel1.Location = new System.Drawing.Point(307, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Flyink Creative";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // remember_box
            // 
            this.remember_box.AutoSize = true;
            this.remember_box.Checked = global::instalink2.Properties.Settings.Default.remember;
            this.remember_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remember_box.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::instalink2.Properties.Settings.Default, "remember", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remember_box.Location = new System.Drawing.Point(15, 111);
            this.remember_box.Name = "remember_box";
            this.remember_box.Size = new System.Drawing.Size(78, 17);
            this.remember_box.TabIndex = 3;
            this.remember_box.Text = "Zapamiętaj";
            this.remember_box.UseVisualStyleBackColor = true;
            // 
            // pass_box
            // 
            this.pass_box.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::instalink2.Properties.Settings.Default, "password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.pass_box.Location = new System.Drawing.Point(12, 80);
            this.pass_box.MaxLength = 32;
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(148, 24);
            this.pass_box.TabIndex = 2;
            this.pass_box.Text = global::instalink2.Properties.Settings.Default.password;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // login_box
            // 
            this.login_box.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::instalink2.Properties.Settings.Default, "login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.login_box.Location = new System.Drawing.Point(12, 25);
            this.login_box.MaxLength = 32;
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(148, 24);
            this.login_box.TabIndex = 1;
            this.login_box.Text = global::instalink2.Properties.Settings.Default.login;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 203);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(396, 85);
            this.webBrowser1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(277, 25);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_answer.Size = new System.Drawing.Size(117, 13);
            this.lbl_answer.TabIndex = 9;
            this.lbl_answer.Text = "X słów w bazie danych";
            this.lbl_answer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_registered
            // 
            this.lbl_registered.AutoSize = true;
            this.lbl_registered.Location = new System.Drawing.Point(277, 9);
            this.lbl_registered.Name = "lbl_registered";
            this.lbl_registered.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_registered.Size = new System.Drawing.Size(125, 13);
            this.lbl_registered.TabIndex = 10;
            this.lbl_registered.Text = "X zarejestrowanych osób";
            this.lbl_registered.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // main
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.end;
            this.ClientSize = new System.Drawing.Size(419, 300);
            this.Controls.Add(this.lbl_registered);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.remember_box);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Program.app_name + " " + Program.app_version;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button end;
        public System.Windows.Forms.TextBox login_box;
        public System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox remember_box;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_registered;
    }
}