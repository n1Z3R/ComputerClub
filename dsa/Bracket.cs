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
    public partial class Bracket : Form
    {
        public Bracket()
        {
            InitializeComponent();
        }
        public class Json
        {
            public string id_result { get; set; }
            public string id_tour { get; set; }
            public string type_t { get; set; }
            public string play1 { get; set; }
            public string play2 { get; set; }
            public string stage { get; set; }
            public string play1_score { get; set; }
            public string play2_score { get; set; }
            public string DATE { get; set; }
            public string TIME { get; set; }
            public string GameName { get; set; }
            public string TournamentName { get; set; }
            public string MAX_players { get; set; }
            public string team1_name { get; set; }
            public string team2_name { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        string text;

        private void Bracket_Load(object sender, EventArgs e)
        {
            lstBracket.FullRowSelect = true;
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            Tournaments Tournaments = new Tournaments();
            string id = Tournaments.getdata();
            //  System.Diagnostics.Process.Start("http://5.180.139.59/result.php?id="+id);
            LoadBracket();
            chId.Width = 25;
            chStage.Width = 100;
        }
        private void LoadBracket()
        {
            try {
                Tournaments Tournaments = new Tournaments();
                string id = Tournaments.getdata();
                lstBracket.Items.Clear();
                var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

                string postData = "type=get&query=get_tournament_results&t_id=" + id;
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
                            text = Json.id_result + " " + Json.stage + " " + Json.team1_name + " " + Json.team2_name + " " + Json.play1_score + " " + Json.play2_score;
                            ListViewItem item = new ListViewItem(Json.id_result);
                            string stage = "0";
                            if (Json.stage == 0.ToString()) { stage = "Финал"; }
                            if (Json.stage == 1.ToString()) { stage = "Полуфинал"; }
                            if (Json.stage == 2.ToString()) { stage = "Четвертьфинал"; }
                            if (Json.stage == 3.ToString()) { stage = "1/8"; }
                            if (Json.stage == 4.ToString()) { stage = "1/16"; }
                            if (Json.stage == 5.ToString()) { stage = "1/32"; }
                            if (Json.stage == 6.ToString()) { stage = "1/64"; }
                            item.SubItems.Add(stage);
                            item.SubItems.Add(Json.team1_name);
                            item.SubItems.Add(Json.team2_name);
                            item.SubItems.Add(Json.play1_score + ":" + Json.play2_score);
                            lstBracket.Items.Add(item);

                        }
                    }

                }
                else
                    lstBracket.Items.Add("Пусто");
            }
            catch
            {
                Error Error = new Error();
                Error.Show();
            }

    }
        private void Delete()
        {
            Main main = new Main();
            string hash = main.getdata();
            string id;
            id = lstBracket.SelectedItems[0].Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "token=" + hash + "&type=update&query=delete_tournament_result&id_res=" + id;
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
            LoadBracket();

            //    text = txtNameT.Text + " " + cbGame.GetItemText(cbGame.SelectedItem).ToString() + " " + cbMode.GetItemText(cbMode.SelectedItem).ToString() + " " + dtpT.Value.ToString();

        }

        private void lstBracket_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstBracket.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsBracket.Show(Cursor.Position);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
