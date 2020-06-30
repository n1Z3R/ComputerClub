using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsa
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            this.BackgroundImage = dsa.Properties.Resources.image;
            lblError.Text = "Ошибка подключения! Проверьте подключение интернета";
            lblError.ForeColor = Color.Red;
            lblError.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
