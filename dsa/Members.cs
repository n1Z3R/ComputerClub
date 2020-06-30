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
    public partial class Members : Form
    {
        public class Json
        {
            public string idUser { get; set; }
            public string team { get; set; }
            public string NUMBER { get; set; }
            public string Login { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public Members()
        {
            InitializeComponent();
        }
        string text;
        List<ListViewItem> allItems = new List<ListViewItem>();
        private void LoadMembers()
        {
            Tournaments Tournaments = new Tournaments();
            string id = Tournaments.getdata();
            
            lstMembers.Items.Clear();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=get_tournament_users&t_id=" + id;
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
            if (jsonString != "0")
            {
                RootObject datas = JsonConvert.DeserializeObject<RootObject>(jsonString);
                if (datas != null)
                {
                    foreach (var Json in datas.json)
                    {
                        text = Json.idUser + " " + "Логин:" + " " + Json.Login + " "+ "Номер телефона:" + " " + Json.NUMBER + " "+"Команда:" + " " + Json.team;
                        ListViewItem item = new ListViewItem(Json.idUser);
                        item.SubItems.Add(Json.Login);
                        item.SubItems.Add(Json.NUMBER);
                        item.SubItems.Add(Json.team);
                        lstMembers.Items.Add(item);
                        allItems.AddRange(lstMembers.Items.Cast<ListViewItem>());
                    }
                }
              
            }
            
        }
        private void LoadTeams()
        {
            Tournaments Tournaments = new Tournaments();
            string id = Tournaments.getdata();

            lstMembers.Items.Clear();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=get_tournament_teams&t_id=" + id;
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
            if (jsonString != "0")
            {
                RootObject datas = JsonConvert.DeserializeObject<RootObject>(jsonString);
                if (datas != null)
                {
                    foreach (var Json in datas.json)
                    {
                        ListViewItem item = new ListViewItem(Json.idUser);
                        item.SubItems.Add(Json.Login);
                        item.SubItems.Add(Json.NUMBER);
                        item.SubItems.Add(Json.team);
                        lstMembers.Items.Add(item);
                        allItems.AddRange(lstMembers.Items.Cast<ListViewItem>());
                    }
                }

            }

        }
        private void Delete()
        {
            
            Main main = new Main();
            Tournaments Tournaments = new Tournaments();
            string hash = main.getdata();
            string t_id = Tournaments.getdata();
            string id;
            id = lstMembers.SelectedItems[0].Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "token=" + hash + "&type=update&query=delete_tournament_user&id_user="+id+"&t_id="+t_id;
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
            LoadMembers();

            //    text = txtNameT.Text + " " + cbGame.GetItemText(cbGame.SelectedItem).ToString() + " " + cbMode.GetItemText(cbMode.SelectedItem).ToString() + " " + dtpT.Value.ToString();

        }
        private void Members_Load(object sender, EventArgs e)
        {
            lstMembers.FullRowSelect = true;
            lblFind.BackColor = System.Drawing.Color.Transparent;
            lblFind.ForeColor = Color.White;
            lstMembers.MouseUp += new MouseEventHandler(lstMembers_MouseUp);
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            EditTournaments EditTournaments = new EditTournaments();
            string type = EditTournaments.gettype();
            if (type == "0")
            {
                LoadMembers();
            }
            else
            {
                LoadTeams();
            }
           
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                LoadMembers();
            }

            var list = lstMembers.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(txtFind.Text)))
                                .ToArray();
            lstMembers.Items.Clear();
            lstMembers.Items.AddRange(list);
        }

        private void lstMembers_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstMembers.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsMembers.Show(Cursor.Position);
                }
            }
        }
    }
}
