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
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }
        public class Json
        {
            public string idUser { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string SecondName { get; set; }
            public string Team { get; set; }
            public string Number { get; set; }
            public string Login { get; set; }
            public string Pass_hash { get; set; }
            public string Admin { get; set; }
            public string e_mail { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }
        private void EditUsers_Load(object sender, EventArgs e)
        {
            LoadUser();
            lblEmail.BackColor = System.Drawing.Color.Transparent;
            lblEmail.ForeColor = Color.White;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblName.ForeColor = Color.White;
            lblNumber.BackColor = System.Drawing.Color.Transparent;
            lblNumber.ForeColor = Color.White;
            lblSname.BackColor = System.Drawing.Color.Transparent;
            lblSname.ForeColor = Color.White;
            lblSurname.BackColor = System.Drawing.Color.Transparent;
            lblSurname.ForeColor = Color.White;
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
        }
        private void LoadUser()
        {
            Users Users = new Users();
            Main main = new Main();
            string id = Users.getdata();
            string hash = main.getdata();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=get&query=get_user_by_id_admin&token=" + hash + "&id_user=" + id;
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
                    txtName.Text = Json.Name;
                    txtSurname.Text = Json.Surname;
                    txtSname.Text = Json.SecondName;
                    txtNumber.Text = Json.Number;
                    txtEmail.Text = Json.e_mail;
                }
            }
        }
        private void EditUser()
        {
            Users Users = new Users();
            Main main = new Main();
            string id = Users.getdata();
            string hash = main.getdata();
            string Name = txtName.Text; 
            string Surname = txtSurname.Text; 
            string Sname = txtSname.Text;
            string Number = txtNumber.Text;
            string Email = txtEmail.Text;
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=update&query=change_personal_data_admin&token=" + hash + "&id_user=" + id + "&name=" + Name + "&surname=" + Surname + "&s_name=" + Sname + "&phone=" + Number + "&email=" + Email;
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
            LoadUser();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
            Users.LoadUsers();
            Users.ShowDialog();
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            EditUser();
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtEmail.Text = null;
            txtName.Text = null;
            txtSurname.Text = null;
            txtSname.Text = null;
            txtNumber.Text = null;
            LoadUser();
        }
    }
}
