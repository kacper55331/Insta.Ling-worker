using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace instalink2
{
    public partial class Form1 : Form
    {
        private String login, lastword;
        private DateTime license;
        private String domain = "https://instaling.pl";
        private bool get = false;

        public Form1(String login, DateTime license)
        {
            InitializeComponent();

            this.login = login;
            this.license = license;
            this.webBrowser2.Url = new Uri("http://flyink.pl/sp/ads2.html");

            webBrowser1.Url = new Uri(domain + "/teacher2/logout.php");
        }

        void BrowserDocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return;

            string url = webBrowser1.Url.ToString();
            if(url == domain + "/teacher2/logout.php")
            {
                webBrowser1.Url = new Uri(domain + "/teacher.php?page=login");
            }
            else if (url == domain + "/teacher.php?page=login")
            {
                HtmlElement login = webBrowser1.Document.GetElementById("log_email");
                login.SetAttribute("value", this.login);
                login.Style = "display: none;";

                foreach (HtmlElement elem in webBrowser1.Document.GetElementsByTagName("label"))
                {
                    if (elem.InnerText == "Email / login:")
                    {
                        elem.InnerText = "Licencja wygasa: " + license.ToString("G", CultureInfo.CreateSpecificCulture("de-DE"));
                        break;
                    }
                }

                foreach (HtmlElement elem in webBrowser1.Document.GetElementsByTagName("a"))
                {
                    elem.SetAttribute("href", "#");
                }
            }
            else if(url == domain + "/learning/student.php")
            {
                HtmlElement el = webBrowser1.Document.GetElementById("session_button");
                String u = el.GetAttribute("href");

                if (!Properties.Settings.Default.info)
                {
                    MessageBox.Show("Aby uzupełnić pole. Wciśnij LPM. Jeżeli słowo się nie uzupełni, zostanie dodane do bazy danych i przy następnej próbie będzie już prawidłowo działało!", "Instrukcja obsługi");
                    Properties.Settings.Default.info = true;
                    Properties.Settings.Default.Save();
                }
                get = true;
                return;
            }

            if(get)
            {
                webBrowser1.Document.Body.AttachEventHandler("onclick", Document_Click);

                if(webBrowser1.Document.GetElementById("title") != null)
                    webBrowser1.Document.GetElementById("title").Style = "display:none";

                if(webBrowser1.Document.GetElementById("footer") != null)
                    webBrowser1.Document.GetElementById("footer").InnerHtml = "<div style='text-align: center;'><a href='http://flyink.pl' target='_blank'>Flyink Creative</a></div>";
            }
        }

        private void Document_Click(object sender, EventArgs e)
        {
            HtmlElement e_word = webBrowser1.Document.GetElementById("word");
            if (e_word != null && !String.IsNullOrEmpty(e_word.InnerText) && this.lastword != e_word.InnerText)
            {
                String word = MySqlHelper.EscapeString(e_word.InnerText);
                if (Program.DB.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Parameters.Add("@word", MySqlDbType.String).Value = word;
                    cmd.CommandText = "SELECT COUNT(*) FROM `answer` WHERE `answer` = @word";
                    cmd.Connection = Program.DB.connection;
                    cmd.ExecuteScalar();
                    int Result = int.Parse(cmd.ExecuteScalar() + "");
                    Program.DB.CloseConnection();
                    if(Result == 0)
                    {
                        HtmlElement e_an = webBrowser1.Document.GetElementById("answer_translations");
                        if (e_an != null && !String.IsNullOrEmpty(e_an.InnerText))
                        {
                            String an = MySqlHelper.EscapeString(e_an.InnerText);
                            Program.DB.query("INSERT INTO `answer` (`answer`, `quest`) VALUES ('" + word + "', '" + an + "')");
                            if (Program.DB.lastquery != null)
                            {
                                Program.DB.lastquery.ExecuteNonQuery();
                                Program.DB.CloseConnection();

                                String[] result = new String[2];
                                result[1] = word;
                                result[0] = an;
                                Program.answer.Add(result);
                            }
                            this.lastword = e_word.InnerText;
                        }
                    }
                }
            }
            if(get)
            {
                HtmlElementCollection form = webBrowser1.Document.GetElementsByTagName("div");
                foreach (HtmlElement elem in form)
                {
                    if (elem.GetAttribute("className") == "translations" && elem.GetAttribute("id") != "answer_translations")
                    {
                        bool found = false;
                        foreach (String[] a in Program.answer)
                        {
                            if(a[0] == elem.InnerText)
                            {
                                webBrowser1.Document.GetElementById("answer").SetAttribute("value", a[1]);
                                found = true;
                            }
                        }
                    } 
                }
            }
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
