using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsa
{
    public partial class Tournaments : Form
    {
      
        public class Json
        {
            public string idTournament { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string GameName { get; set; }
            public string TournamentName { get; set; }
            public string Type { get; set; }
           
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public Tournaments()
        {
            InitializeComponent();
            
        }
        public static string id;
        public static int f;
        public string getdata()
        {
            return id;
        }
        string text;
        List<ListViewItem> allItems = new List<ListViewItem>();

        private void Delete()
        {
            Main main = new Main();
            string hash = main.getdata();
            id = lstTournaments.SelectedItems[0].Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "hash="+hash+"&type=update&query=deleteTournament&id="+id;
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
            LoadTournaments();

            //    text = txtNameT.Text + " " + cbGame.GetItemText(cbGame.SelectedItem).ToString() + " " + cbMode.GetItemText(cbMode.SelectedItem).ToString() + " " + dtpT.Value.ToString();

        }
        private void LoadTournaments()
        {
           
            Main main = new Main();
            lstTournaments.Items.Clear();
            
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=getTournaments";
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
                    text = Json.idTournament + " " + Json.Date + " " + Json.Time + " " + Json.GameName + " " + Json.TournamentName + " " + Json.Type;
                    ListViewItem item = new ListViewItem(Json.idTournament);
                    item.SubItems.Add(Json.Date);
                    item.SubItems.Add(Json.Time);
                    item.SubItems.Add(Json.GameName);
                    item.SubItems.Add(Json.TournamentName);
                    item.SubItems.Add(Json.Type);
                    lstTournaments.Items.Add(item);
                    allItems.AddRange(lstTournaments.Items.Cast<ListViewItem>());
                }
            }
        }
        private void Tournaments_Load(object sender, EventArgs e)
        {
            lstTournaments.FullRowSelect = true;
            lstTournaments.MouseUp += new MouseEventHandler(lstTournaments_MouseUp);
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            LoadTournaments();
            Image leet = dsa.Properties.Resources.image;
            this.BackgroundImage = leet;
            lblFind.BackColor = System.Drawing.Color.Transparent;
            lblFind.ForeColor = Color.White;
      
        }
     
        private void btnCreate_Click(object sender, EventArgs e)
        {
           // CreateTournament();
            CreateTournaments CreateTournaments = new CreateTournaments();
            CreateTournaments.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Func AdminPanel = new Func();
            AdminPanel.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTournaments EditTournaments = new EditTournaments();
            id = lstTournaments.SelectedItems[0].Text;
            EditTournaments.Show();
            this.Hide();
        }
     

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                LoadTournaments();
            }

            var list = lstTournaments.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(txtFind.Text)))
                                .ToArray();
            lstTournaments.Items.Clear();
            lstTournaments.Items.AddRange(list);
        }

        private void lstTournaments_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstTournaments.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsTournament.Show(Cursor.Position);
                }
            }
        }
    }
    }

