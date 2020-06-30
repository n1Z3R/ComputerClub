using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsa
{
    public partial class PlayersTeam : Form
    {
        public PlayersTeam()
        {
            InitializeComponent();
        }
        public class Json
        {
            public string idUser { get; set; }
            public string Login { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string SecondName { get; set; }
            public string Team { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        List<ListViewItem> allItems = new List<ListViewItem>();
        private void PlayersTeam_Load(object sender, EventArgs e)
        {
            LoadTeams();
            lstPlayers.FullRowSelect = true;
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            lblFind.BackColor = System.Drawing.Color.Transparent;
            lblFind.ForeColor = Color.White;

        }
        public void LoadTeams()
        {
            Teams Teams = new Teams();
            string id = Teams.getdata();
            lstPlayers.Items.Clear();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=get_team_users&id_t="+id;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

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
                    ListViewItem item = new ListViewItem(Json.idUser);
                    item.SubItems.Add(Json.Login);
                    item.SubItems.Add(Json.Surname);
                    item.SubItems.Add(Json.Name);
                    item.SubItems.Add(Json.SecondName);
                    lstPlayers.Items.Add(item);
                    allItems.AddRange(lstPlayers.Items.Cast<ListViewItem>());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
