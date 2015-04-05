using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Net;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace instalink2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.ActiveControl = this.login_box;
            this.login_box.Text = Properties.Settings.Default.login;
            this.pass_box.Text = Properties.Settings.Default.password;
            this.remember_box.Checked = Properties.Settings.Default.remember;
            this.webBrowser1.Url = new Uri("http://flyink.pl/sp/ads.html");

            updateInfo();
        }

        public void updateInfo()
        {
            Program.DB.query("SELECT Count(*) FROM `users`");
            if (Program.DB.lastquery != null)
            {
                int Result = int.Parse(Program.DB.lastquery.ExecuteScalar() + "");
                Program.DB.CloseConnection();
                this.lbl_registered.Text = Result + " " + Program.dli(Result, "zarejestrowana osoba", "zarejestrowane osoby", "zarejestrowanych osób");
            }
            else this.lbl_registered.Hide();

            Program.DB.query("SELECT Count(*) FROM `answer`");
            if (Program.DB.lastquery != null)
            {
                int Result = int.Parse(Program.DB.lastquery.ExecuteScalar() + "");
                Program.DB.CloseConnection();
                this.lbl_answer.Text = Result + " " + Program.dli(Result, "słowo", "słowa", "słów") + " w bazie danych";
            }
            else this.lbl_answer.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://flyink.pl");
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            String login, pass;
            login = this.login_box.Text;
            pass = this.pass_box.Text;

            if(String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Nie podałeś loginu lub hasła!");
                return;
            }

            if(this.remember_box.Checked)
            {
                Properties.Settings.Default.login = login;
                Properties.Settings.Default.password = pass;
                Properties.Settings.Default.remember = this.remember_box.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.login = String.Empty;
                Properties.Settings.Default.password = String.Empty;
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }

            int[] result = this.getUserUID(login, pass);
            if(result[0] == 0)
            {
                MessageBox.Show("Nie znaleziono takiego konta lub login/hasło się nie zgadza.");
                return;
            }

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(result[1]).ToLocalTime();
            if (result[1] < (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds)
            {
                MessageBox.Show("Licencja na używanie programu, skończyła się!");
                if (Program.Pay_Form == null)
                    Program.Pay_Form = new pay(result[0], login, dateTime);
                Program.Pay_Form.Tag = this;
                Program.Pay_Form.Show(this);
                this.Hide();
                return;
            }

            InsertToLog(result[0]);

            if (Program.Forum_Form == null)
                Program.Forum_Form = new Form1(this.login_box.Text, dateTime);
            Program.Forum_Form.Tag = this;
            Program.Forum_Form.Show(this);
            this.Hide();
        }

        public static void InsertToLog(int uid)
        {
            if (uid == 0) return;
            Program.DB.query("INSERT INTO `visits` (`user`) VALUES ('" + uid + "')");
            if (Program.DB.lastquery != null)
            {
                Program.DB.lastquery.ExecuteNonQuery();
                Program.DB.CloseConnection();
            }
        }

        protected int[] getUserUID(string login, string password)
        {
            int[] r = new int[2];
            login = MySqlHelper.EscapeString(login);
            password = MySqlHelper.EscapeString(password);
            if(Program.DB.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = login;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;
                cmd.CommandText = "SELECT `uid`, `time` FROM `users` WHERE `name` = @username AND `password` = md5(md5(@password))";
                cmd.Connection = Program.DB.connection;
                cmd.ExecuteScalar();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    r[0] = int.Parse(dataReader["uid"] + "");
                    r[1] = int.Parse(dataReader["time"] + "");
                }
                Program.DB.CloseConnection();
            }
            return r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Register_Form == null)
                Program.Register_Form = new register();
            Program.Register_Form.Tag = this;
            Program.Register_Form.Show(this);
            this.Hide();
        }
    }
}
