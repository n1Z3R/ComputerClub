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
using static dsa.Func;

namespace dsa
{
    public partial class EditTournaments : Form
    {
        
        public class Json
        {
            public string idTournament { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string GameName { get; set; }
            public string TournamentName { get; set; }
            public string Type { get; set; }
            public string max_players { get; set; }
            public string description { get; set; }
            public string accepted { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public EditTournaments()
        {
            InitializeComponent();
        }
        public static string type;
        public string gettype()
        {
            return type;
        }
        int switcher = 0;
        private void EditTournaments_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            cbGame.Items.Add("CS:GO");
            cbGame.Items.Add("Dota");
            cbGame.Items.Add("Fortnite");
            cbGame.Items.Add("Pubg");
            cbMode.Items.Add("1");
            cbMode.Items.Add("0");
            lbl2.BackColor = System.Drawing.Color.Transparent;
            lblAccepted.BackColor = System.Drawing.Color.Transparent;
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblDate.BackColor = System.Drawing.Color.Transparent;
            lblGame.BackColor = System.Drawing.Color.Transparent;
            lblMode.BackColor = System.Drawing.Color.Transparent;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblDescription.BackColor = System.Drawing.Color.Transparent;
            lblMaxplayers.BackColor = System.Drawing.Color.Transparent;
            lbl2.ForeColor = Color.White;
            lblAccepted.ForeColor = Color.White;
            lblMaxplayers.ForeColor = Color.White;
            lblDescription.ForeColor = Color.White;
            lblTime.ForeColor = Color.White;
            lblDate.ForeColor = Color.White;
            lblGame.ForeColor = Color.White;
            lblMode.ForeColor = Color.White;
            lblName.ForeColor = Color.White;
            txtNameT.Enabled = false;
            cbGame.Enabled = false;
            cbMode.Enabled = false;
            txtDate.Enabled = false;
            txtData.Enabled = false;
            txtDescription.Enabled = false;
            txtMaxplayers.Enabled = false;
            btnAccept.Enabled = false;
            LoadTournaments();
        }
        private void LoadTournaments()
        {
            Tournaments Tournaments = new Tournaments();
            Main main = new Main();
            string id = Tournaments.getdata();
            string hash = main.getdata();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=get_reg_tournament_v2&token=" + hash + "&t_id="+ id;
            var data = Encoding.UTF8.GetBytes(postData);

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
                    cbGame.Text = Json.GameName;
                    txtNameT.Text = Json.TournamentName;
                    type = Json.Type;
                    cbMode.Text = Json.Type;
                    txtDate.Text = Json.Date;
                    txtData.Text = Json.Time;
                    txtDescription.Text = Json.description;
                    txtMaxplayers.Text = Json.max_players;
                    lblAccepted.Text = Json.accepted+"/"+Json.max_players;
                }
            }
        }
  
        private void EditTournament()
        {
            Tournaments Tournaments = new Tournaments();
            Main main = new Main();
            string id = Tournaments.getdata();
            string hash = main.getdata();
            string Date = txtDate.Text; //2019-12-05
            string Time = txtData.Text; //12:00
            string Game = cbGame.Text;
            string Name = txtNameT.Text;
            string Mode = cbMode.Text;
            string MaxPlayers = txtMaxplayers.Text;
            string Description = txtDescription.Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=update&query=change_tournament_data&token=" + hash + "&t_id=" + id+ "&date=" + Date + "&time=" + Time + "&game_name=" + Game + "&tour_name=" + Name + "&type_t=" + Mode + "&max_players=" + MaxPlayers + "&description=" + Description;
            var data = Encoding.UTF8.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            

            var response = (HttpWebResponse)request.GetResponse();

            var mycontent = new StreamReader(response.GetResponseStream()).ReadToEnd();
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(switcher == 0) {
            switcher = 1;
            cbGame.Enabled = true;
            txtNameT.Enabled = true;
            cbGame.Enabled = true;
            cbMode.Enabled = true;
            txtDate.Enabled = true;
            txtData.Enabled = true;
            txtDescription.Enabled = true;
            txtMaxplayers.Enabled = true;
            btnAccept.Enabled = true;
            btnEdit.Text = "Отмена";
            }
            else
            {
                cbGame.Enabled = false;
                txtNameT.Enabled = false;
                cbGame.Enabled = false;
                cbMode.Enabled = false;
                txtDate.Enabled = false;
                txtData.Enabled = false;
                txtDescription.Enabled = false;
                txtMaxplayers.Enabled = false;
                btnAccept.Enabled = false;
                btnEdit.Text = "Редактировать";
                switcher = 0;
                LoadTournaments();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tournaments Tournaments = new Tournaments();
            Tournaments.Show();
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            EditTournament();
      
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Members Members = new Members();
            Members.Show();
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            Bracket Bracket = new Bracket();
            Bracket.Show();
        }
    }
}
