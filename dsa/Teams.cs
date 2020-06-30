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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }
        public class Json
        {
            public string idTeam { get; set; }
            public string TeamName { get; set; }
            public string useradmin { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public static string id;
        public string getdata()
        {
            return id;
        }

        List<ListViewItem> allItems = new List<ListViewItem>();

        private void Teams_Load(object sender, EventArgs e)
        {
            lstTeams.FullRowSelect = true;
            LoadTeams();
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            lblFind.BackColor = System.Drawing.Color.Transparent;
            lblFind.ForeColor = Color.White;
        }
        public void LoadTeams()
        {
            lstTeams.Items.Clear();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=getTeams";
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
                    ListViewItem item = new ListViewItem(Json.idTeam);
                    item.SubItems.Add(Json.TeamName);
                    item.SubItems.Add(Json.useradmin);
                    lstTeams.Items.Add(item);
                    allItems.AddRange(lstTeams.Items.Cast<ListViewItem>());
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                LoadTeams();
            }

            var list = lstTeams.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(txtFind.Text)))
                                .ToArray();
            lstTeams.Items.Clear();
            lstTeams.Items.AddRange(list);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Func Func = new Func();
            Func.Show();
            this.Hide();
        }

        private void lstTeams_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstTeams.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsTeams.Show(Cursor.Position);
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = lstTeams.SelectedItems[0].Text;
            PlayersTeam PlayersTeam = new PlayersTeam();
            PlayersTeam.Show();
        }
    }
}
