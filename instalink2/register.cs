using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace instalink2
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.ActiveControl = this.lbl_login;
        }

        private void register_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Program.Main_Form == null)
                Program.Main_Form = new main();
            Program.Main_Form.Show();
            this.Hide();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            String login = MySqlHelper.EscapeString(lbl_login.Text);
            String pass1 = MySqlHelper.EscapeString(lbl_pass.Text);
            String pass2 = MySqlHelper.EscapeString(lbl_pass2.Text);
            if(String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pass1) || String.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Nie podałeś loginu lub haseł.");
                return;
            }

            if(pass1 != pass2)
            {
                MessageBox.Show("Podane hasła różnią się od siebie!");
                return;
            }
            if (Program.DB.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Add("@name", MySqlDbType.String).Value = login;
                cmd.CommandText = "SELECT COUNT(*) FROM `users` WHERE `name` = @name";
                cmd.Connection = Program.DB.connection;
                cmd.ExecuteScalar();
                int Result = int.Parse(cmd.ExecuteScalar() + "");
                Program.DB.CloseConnection();
                if (Result != 0)
                {
                    MessageBox.Show("W bazie danych jest już użytkownik z takim nickiem!");
                    return;
                }
            }

            Int32 time = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            time += 604800;
            Program.DB.query("INSERT INTO `users` VALUES (NULL, '" + login + "', md5(md5('" + pass1 + "')), '" + time + "');");
            if (Program.DB.lastquery != null)
            {
                Program.DB.lastquery.ExecuteNonQuery();
                Program.DB.CloseConnection();
            }
            Properties.Settings.Default.login = login;
            Properties.Settings.Default.password = pass1;
            Properties.Settings.Default.Save();

            MessageBox.Show("Konto stworzone poprawnie, login: " + login + ". Możesz się teraz zalogować.\n\nLicencja konta jest ważna tydzień!", "Sukces");

            if (Program.Main_Form == null)
                Program.Main_Form = new main();
            Program.Main_Form.updateInfo();
            Program.Main_Form.Show();
            this.Hide();
        }
    }
}
