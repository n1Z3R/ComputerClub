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
    public partial class Info : Form
    {
        public class Json
        {
            public string idReservation { get; set; }
            public string idComputer { get; set; }
            public string DateReservation { get; set; }
            public string idUser { get; set; }
            public string Time { get; set; }
            public string WhenRes { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        public Info()
        {
            InitializeComponent();
        }
        string text;
        private void LoadReservation()
        {
         
            Computers computers = new Computers();
            string id = computers.getdata();
            lstReservation.Items.Clear();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=getReservationsById&idcomp=" + id;
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
                if (datas != null)
                {
                    foreach (var Json in datas.json)
                    {
                        text = Json.idReservation + " " + Json.DateReservation + "   " + Json.idUser + "          " + Json.Time;
                        lstReservation.Items.Add(text);
                    }
                }
                else
                    lstReservation.Items.Add("Пусто");
            }
        }
            private void Info_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            LoadReservation();
            lbl2.BackColor = System.Drawing.Color.Transparent;
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblDate.BackColor = System.Drawing.Color.Transparent;
            lblId.BackColor = System.Drawing.Color.Transparent;
            lbl2.BackColor = System.Drawing.Color.Transparent;
           
            lbl2.ForeColor = Color.White;
            lblTime.ForeColor = Color.White;
            lblDate.ForeColor = Color.White;
            lblId.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

        }
        private void DeleteReservation()
        {
            Main main = new Main();
            string hash = main.getdata();
            string id = txtDelete.Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=update&hash=" + hash + "&query=deleteReservation&idreservation=" + id;
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
            LoadReservation();

            //    text = txtNameT.Text + " " + cbGame.GetItemText(cbGame.SelectedItem).ToString() + " " + cbMode.GetItemText(cbMode.SelectedItem).ToString() + " " + dtpT.Value.ToString();
        }
        private void AddReservation()
        {
            Main main = new Main();
            string hash = main.getdata();
            Computers computers = new Computers();
            string id = computers.getdata();
            string Date = txtDate.Text; 
            string Time = txtTime.Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");
            string postData = "type=update&hash=" + hash + "&query=addReservation&idcomp=" + id + "&datetime="+Date+"&restime="+Time;
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
            LoadReservation();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReservation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteReservation();
        }
    }
    } 
