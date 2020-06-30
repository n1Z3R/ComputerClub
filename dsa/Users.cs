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
    public partial class Users : Form
    {
        public Users()
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
        public static string id;
        List<ListViewItem> allItems = new List<ListViewItem>();
        public string getdata()
        {
            return id;
        }
        private void Users_Load(object sender, EventArgs e)
        {
            lstUsers.FullRowSelect = true;
            LoadUsers();
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            lblFind.BackColor = System.Drawing.Color.Transparent;
            lblFind.ForeColor = Color.White;
        }
        public void LoadUsers()
        {

            Main main = new Main();
            lstUsers.Items.Clear();
            string hash = main.getdata();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "token="+hash+"&type=get&query=get_users_admin";
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
                    item.SubItems.Add(Json.Surname);
                    item.SubItems.Add(Json.Name);
                    item.SubItems.Add(Json.SecondName);
                    item.SubItems.Add(Json.Team);
                    item.SubItems.Add(Json.Number);
                    item.SubItems.Add(Json.Login);
                    item.SubItems.Add(Json.e_mail);
                    if (Json.Admin == "1")
                    {
                        item.SubItems.Add("Админ");
                    }
                    if (Json.Admin == "0")
                    {
                        item.SubItems.Add("Пользователь");
                    } 
                    lstUsers.Items.Add(item);
                    allItems.AddRange(lstUsers.Items.Cast<ListViewItem>());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Func Func = new Func();
            Func.Show();
            this.Hide();
        }

        private void lstUsers_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstUsers.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsUsers.Show(Cursor.Position);
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                LoadUsers();
            }

            var list = lstUsers.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(txtFind.Text)))
                                .ToArray();
            lstUsers.Items.Clear();
            lstUsers.Items.AddRange(list);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = lstUsers.SelectedItems[0].Text;
            EditUsers EditUsers = new EditUsers();
            EditUsers.Show();
        }
    }
}
