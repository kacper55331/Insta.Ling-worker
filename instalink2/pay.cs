using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace instalink2
{
    public partial class pay : Form
    {
        private int uid = 0;
        private String name = String.Empty;
        private DateTime license;

        public pay(int uid, String name, DateTime license)
        {
            InitializeComponent();
            if (uid == 0)
            {
                this.btn_back_Click(null, null);
                return;
            }
            this.uid = uid;
            this.txt_login.Text = this.name = name;
            this.txt_uid.Text = uid + "";
            this.license = license;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Program.Main_Form == null)
                Program.Main_Form = new main();
            Program.Main_Form.Show();
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string act = this.txt_activate.Text;
            if(Regex.IsMatch(act, "/^[A-Za-z0-9]{8}$/"))
            {
                MessageBox.Show("Zły format znaków", "Błąd");
                return;
            }
            using (var webpage = new WebClient())
            {
                webpage.Encoding = System.Text.Encoding.UTF8;
                webpage.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                string str = webpage.DownloadString(new Uri("http://homepay.pl/API/check_code.php?usr_id=" + Program.home_id + "&acc_id=" + Program.home_acc + "&code=" + act));
                int result = int.Parse(str);
                if(result == 0)
                {
                    MessageBox.Show("Nieprawidłowy kod", "Błąd");
                }
                else if(result == 1)
                {
                    MessageBox.Show("Kod poprawny", "Sukces");
                    Int32 time = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    time += (4 * 604800) + 3600;

                    Program.DB.query("UPDATE `users` SET `time` = '" + time + "' WHERE `uid` = '" + uid + "'");
                    if (Program.DB.lastquery != null)
                    {
                        Program.DB.lastquery.ExecuteNonQuery();
                        Program.DB.CloseConnection();
                    }

                    main.InsertToLog(this.uid);

                    if (Program.Forum_Form == null)
                        Program.Forum_Form = new Form1(this.name, this.license.AddDays(28.0));
                    Program.Forum_Form.Tag = this;
                    Program.Forum_Form.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Błąd przy połączeniu, spróbuj ponownie później!", "Błąd");
                }
            }
        }

        private void pay_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://ssl.homepay.pl/regulamin/regulamin_sms_premium/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://ssl.homepay.pl/reklamacje/");
        }
    }
}
