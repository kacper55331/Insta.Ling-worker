using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;

namespace instalink2
{
    static class Program
    {
        public static String app_name = "Instaling hack, by CeKa";
        public static String app_version = "[Version: v.0.1]";

        public static int home_id = 7890;
        public static int home_acc = 17433;

        public static DB DB;
        public static main Main_Form;
        public static Form1 Forum_Form;
        public static register Register_Form;
        public static pay Pay_Form;

        public static List<String[]> answer = new List<String[]>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DB = new DB(/*string host, string db, string user, string paswd*/);
            if(DB == null)
            {
                MessageBox.Show("Aplikacja zamknięta, brak połączenia z bazą danych! Sprawdź połączenie z internetem!");
                Application.Exit();
                return;
            }
            Main_Form = new main();

            getAnswer();
            Application.Run(Main_Form);
        }

        private static void getAnswer()
        {
            Program.DB.query("SELECT * FROM `answer`");
            if(Program.DB.lastquery != null)
            {
                var rdr = Program.DB.lastquery.ExecuteReader();
                while (rdr.Read())
                {
                    String[] result = new String[2];
                    result[0] = rdr.GetString(2);
                    result[1] = rdr.GetString(1);
                    Program.answer.Add(result);
                }
                rdr.Close();
                Program.DB.CloseConnection();
            }
        }

        public static string dli(int x, string a, string b, string c)
        {
            if (x == 1) return a;
            if (x % 10 > 1 && x % 10 < 5 && !(x % 100 >= 10 && x % 100 <= 21)) return b;
            return c;
        }
    }
}
