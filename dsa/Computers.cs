using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace dsa
{
    public partial class Computers : Form
    {
        public Computers()
        {
            InitializeComponent();
           
        }

      public static string id = "0";
        public string getdata()
        {
            return id;
        }
        void Rent()
        {
            PictureBox[] pb = { pb1, pb2, pb3, pb4 };
            //new PictureBox[4];
        }
           
        void Free()
        {
         
        }
        void LoadImage()
        {
            PictureBox[] pb = { pb1, pb2, pb3, pb4 };
            //new PictureBox[4];
            for (int i = 0; i < 4; i++)
            {
                if (pb[i].Tag.Equals(1))
                {
                    Image free = dsa.Properties.Resources.free;
                    pb[i].BackColor = System.Drawing.Color.Transparent;
                    pb[i].Image = free;
                }
                else
                {
                    Image rented = dsa.Properties.Resources.rented;
                    pb[i].BackColor = System.Drawing.Color.Transparent;
                    pb[i].Image = rented;
                    
                }
            }
        }
        private void Computers_Load(object sender, EventArgs e)
        {
            this.Icon = dsa.Properties.Resources.zsz_fcvos10_LWv_icon;
            Image leet = dsa.Properties.Resources.image;
            this.BackgroundImage = leet;
            pb1.Tag = 1;
            pb2.Tag = 1;
            pb3.Tag = 1;
            pb4.Tag = 1;
            LoadImage();
            lbl1.BackColor= System.Drawing.Color.Transparent;
            
            
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            id = "0";
            Info info = new Info();
           info.Show();
            if (pb1.Tag.Equals(1))
            {
                Rent();
               
            }
            else
            {
                Free();

            }
        }
        private void pb2_Click(object sender, EventArgs e)
        {
           id = "1";
            Info info = new Info();
            info.Show();
            if (pb2.Tag.Equals(1))
            {
                Rent();
                
            }
            else
            {
                Free();
            }
        }


        private void pb3_Click(object sender, EventArgs e)
        {
            id= "2";
            Info info = new Info();
            info.Show();
            if (pb3.Tag.Equals(1))
            {
                Rent();
                
            }
            else
            {
                Free();
            }
        }


        private void pb4_Click(object sender, EventArgs e)
        {
            id = "3";
            Info info = new Info();
            info.Show();
            if (pb4.Tag.Equals(1))
            {
                Rent();
                
            }
            else
            {
                Free();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Func AdminPanel = new Func();
            AdminPanel.Show();
            this.Hide();

        }
        public static int s = 60, m = 60, h = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int s = 60, m = 60, h = 60;
            Label[] lbl = { lbl1, lbl2, lbl3, lbl4 };
            lbl[Int32.Parse(id)].ForeColor = Color.White;
            lbl[Int32.Parse(id)].Text = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
            s = s - 1;
            {
                if (s == -1)
                {
                    m = m - 1;
                    s = 59;
                }
                if (m == -1)
                {
                    h = h - 1;
                    m = 59;
                }
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //int s = 60, m = 60, h = 60;
            Label[] lbl = { lbl1, lbl2, lbl3, lbl4 };
            lbl[Int32.Parse(id)].ForeColor = Color.White;
            lbl[Int32.Parse(id)].Text = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
            s = s - 1;
            {
                if (s == -1)
                {
                    m = m - 1;
                    s = 59;
                }
                if (m == -1)
                {
                    h = h - 1;
                    m = 59;
                }
            }

        }





    }
    }
