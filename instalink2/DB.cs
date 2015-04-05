using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace instalink2
{
    class DB
    {
        public String error = string.Empty;
        public MySqlConnection connection;
        public MySqlCommand lastquery;
        public String lastquer = String.Empty;

        public DB(string host, string db, string user, string paswd)
        {
            string conn;
            conn = "SERVER=" + host + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + paswd + ";charset=utf8";

            this.connection = new MySqlConnection(conn);
            if (this.connection != null)
            {
                this.query("SET NAMES 'utf8' COLLATE 'utf8_polish_ci'");
                this.lastquery.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        ~DB()
        {
            this.CloseConnection();
        }

        public MySqlCommand query(string sql)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                this.lastquery = cmd;
                this.lastquer = sql;
                return cmd;
            }
            return null;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    case 1042:
                        MessageBox.Show("Can't get hostname address");
                        break;
                    default:
                        MessageBox.Show("Error: " + ex.Number);
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
