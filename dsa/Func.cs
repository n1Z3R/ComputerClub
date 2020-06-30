using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dsa.Tournaments;

namespace dsa
{
    public partial class Func : Form
    {
      public static string mycontent;
        public class Json
        {
            public string idNews { get; set; }
            public string Header { get; set; }
            public string Content { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string idAdmin { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public Func()
        {
            InitializeComponent();
        }
        string text;
        private void Func_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            Image leet = dsa.Properties.Resources.image;
            this.BackgroundImage = leet;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=getNews&position=0&number=10";
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var mycontent = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var jsonString = mycontent;
                if (jsonString != null)
                {
                    RootObject datas = JsonConvert.DeserializeObject<RootObject>(jsonString);

                    foreach (var Json in datas.json)
                    {
                        text = Json.idNews + " " + Json.Header + " " + Json.Content + " " + Json.Date + " " + Json.Time + " " + Json.idAdmin;
                        lstNews.Items.Add(text);
                    }
                }
            }
            catch
            {
                Error Error = new Error();
                Error.Show();
            }


        }



        private void btnComputers_Click(object sender, EventArgs e)
        {
            Computers ComputersPanel = new Computers();
            ComputersPanel.Show();
            this.Hide();
        }

        private void btnTournaments_Click(object sender, EventArgs e)
        {
            Tournaments Tournamentspanel = new Tournaments();
            Tournamentspanel.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
            Users.Show();
            this.Hide();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            Teams Teams = new Teams();
            Teams.Show();
            this.Hide();
        }
    }
}
