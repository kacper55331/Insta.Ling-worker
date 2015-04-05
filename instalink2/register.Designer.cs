namespace instalink2
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass2 = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(186, 121);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(128, 42);
            this.btn_reg.TabIndex = 4;
            this.btn_reg.Text = "Zarejestruj";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(12, 121);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Wróć";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lbl_login.Location = new System.Drawing.Point(12, 25);
            this.lbl_login.MaxLength = 32;
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(148, 24);
            this.lbl_login.TabIndex = 1;
            // 
            // lbl_pass
            // 
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lbl_pass.Location = new System.Drawing.Point(12, 79);
            this.lbl_pass.MaxLength = 32;
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(148, 24);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.UseSystemPasswordChar = true;
            // 
            // lbl_pass2
            // 
            this.lbl_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lbl_pass2.Location = new System.Drawing.Point(166, 79);
            this.lbl_pass2.MaxLength = 32;
            this.lbl_pass2.Name = "lbl_pass2";
            this.lbl_pass2.Size = new System.Drawing.Size(148, 24);
            this.lbl_pass2.TabIndex = 3;
            this.lbl_pass2.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Location = new System.Drawing.Point(12, 9);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(124, 13);
            this.txt_login.TabIndex = 14;
            this.txt_login.Text = "Wpisz login z instaling.pl:";
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = true;
            this.txt_pass.Location = new System.Drawing.Point(12, 63);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(227, 13);
            this.txt_pass.TabIndex = 15;
            this.txt_pass.Text = "Podaj hasło(może być inne, niż na instaling.pl):";
            // 
            // register
            // 
            this.AcceptButton = this.btn_reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(331, 175);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_pass2);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Program.app_name + " " + Program.app_version;
            this.Closed += new System.EventHandler(this.register_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.TextBox lbl_login;
        public System.Windows.Forms.TextBox lbl_pass;
        public System.Windows.Forms.TextBox lbl_pass2;
        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.Label txt_pass;
    }
}