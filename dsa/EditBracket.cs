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
    public partial class EditBracket : Form
    {
        public EditBracket()
        {
            InitializeComponent();
        }
        public class Json
        {
            public string idTeam { get; set; }
            public string TeamName { get; set; }
            public string useradmin { get; set; }
            public string id_tour { get; set; }
        }

        public class RootObject
        {
            public List<Json> json { get; set; }
        }

        private void EditBracket_Load(object sender, EventArgs e)
        {

        }
        private void LoadResult()
        {
            Users Users = new Users();
            Main main = new Main();
            string id = Users.getdata();
            string hash = main.getdata();
            var request = (HttpWebRequest)WebRequest.Create("http://5.180.139.59/index.php");

            string postData = "type=u&query=get_user_by_id_admin&token=" + hash + "&id_user=" + id;
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
                    
                }
            }
        }
    }
}
