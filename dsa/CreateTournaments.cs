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
    public partial class CreateTournaments : Form
    {

        public CreateTournaments()
        {
            InitializeComponent();
        }

        private void CreateTournaments_Load(object sender, EventArgs e)
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
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblDate.BackColor = System.Drawing.Color.Transparent;
            lblGame.BackColor = System.Drawing.Color.Transparent;
            lblMode.BackColor = System.Drawing.Color.Transparent;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblDescription.BackColor = System.Drawing.Color.Transparent;
            lblMaxplayers.BackColor = System.Drawing.Color.Transparent;
            lbl2.ForeColor = Color.White;
            lblMaxplayers.ForeColor = Color.White;
            lblDescription.ForeColor = Color.White;
            lblTime.ForeColor = Color.White;
            lblDate.ForeColor = Color.White;
            lblGame.ForeColor = Color.White;
            lblMode.ForeColor = Color.White;
            lblName.ForeColor = Color.White;

        }
        private void CreateTournament()
        {
            Main main = new Main();
            string hash = main.getdata();
            string Date = txtDate.Text; //2019-12-05
            string Time = txtData.Text; //12:00
            string Game = cbGame.GetItemText(cbGame.SelectedItem.ToString());
            string Name = txtNameT.Text;
            string Mode = cbMode.GetItemText(cbMode.SelectedItem.ToString());
            string MaxPlayers = txtMaxplayers.Text;
            string Description = txtDescription.Text;

            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");
            // string postData = "hash=f3b9e45ef8de5f95effba9723d74de503b2318d9655b535af465629473b46c59&type=update&query=createTournament&date=" + Date + "&time=" + Time + "&game=" + Game + "&name=" + Name + "&typet=0";
            string postData = "token=" + hash + "&type=update&query=createTournament_admin&date=" + Date + "&time=" + Time + "&game=" + Game + "&name=" + Name + "&typet=" + Mode + "&max_players=" + MaxPlayers + "&description="+ Description;
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
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            CreateTournament();
            Tournaments Tournaments = new Tournaments();
            Tournaments.Show();
            this.Hide();
        }

        private void txtMaxplayers_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tournaments Tournaments = new Tournaments();
            Tournaments.Show();
            this.Hide();
        }
    }
}
