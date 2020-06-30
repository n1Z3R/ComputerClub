using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;

namespace dsa
{

    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }
        public static string mycontent;
        public static string hash64;
        public string getdata()
        {
            return hash64;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            Image leet = dsa.Properties.Resources.image;
            this.BackgroundImage = leet;
            txt2.UseSystemPasswordChar = true;
            lblError.Hide();
            lblError.Text = "Неправильный пароль или логин";
            lblError.ForeColor = Color.Red;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            lblError.BackColor = System.Drawing.Color.Transparent;


        }
        private void Authorization()

        {

            string login = txt1.Text;
            string password = txt2.Text;
            byte[] datas = Encoding.Default.GetBytes(password);
            var result = new SHA256Managed().ComputeHash(datas);
            string hash = BitConverter.ToString(result).Replace("-", "").ToLower();

            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "hash=" + hash + "&type=get&query=login&login=" + login;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();

                mycontent = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (mycontent != "-1")
                {
                    hash64 = mycontent.Substring(0, 64);
                }
            }
            catch
            {
                Error Error = new Error();
        Error.Show();
            }
}
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string decline= "-1";
            try { Authorization(); }
            catch {
                Error Error = new Error();
                Error.Show();
            }
            if (mycontent == decline)
            {
                lblError.Show();
            }
            else
            {
                Func AdminPanel = new Func();
                AdminPanel.Show();
                this.Hide();
                lblError.Hide();
            }
        }
    }
}
