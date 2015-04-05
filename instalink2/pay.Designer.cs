namespace instalink2
{
    partial class pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pay));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_activate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(12, 269);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 42);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Wróć";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(417, 269);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(128, 42);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Wyślij";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_uid
            // 
            this.txt_uid.Enabled = false;
            this.txt_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.txt_uid.Location = new System.Drawing.Point(12, 25);
            this.txt_uid.MaxLength = 32;
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(29, 24);
            this.txt_uid.TabIndex = 8;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(9, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(29, 13);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "UID:";
            // 
            // txt_login
            // 
            this.txt_login.Enabled = false;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.txt_login.Location = new System.Drawing.Point(63, 25);
            this.txt_login.MaxLength = 32;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(148, 24);
            this.txt_login.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 65);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(262, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Regulamin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(316, 111);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 13);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Reklamacje";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::instalink2.Properties.Resources.zaplac_teraz;
            this.pictureBox1.Location = new System.Drawing.Point(391, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 60);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txt_activate
            // 
            this.txt_activate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txt_activate.Location = new System.Drawing.Point(134, 197);
            this.txt_activate.MaxLength = 8;
            this.txt_activate.Name = "txt_activate";
            this.txt_activate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_activate.Size = new System.Drawing.Size(284, 44);
            this.txt_activate.TabIndex = 16;
            this.txt_activate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_activate.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wpisz kod aktywacyjny:";
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_activate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instaling hack, by CeKa [Version: v.0.1]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pay_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label lbl_login;
        public System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_activate;
        private System.Windows.Forms.Label label3;
    }
}