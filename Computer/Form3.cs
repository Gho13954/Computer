using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form3 : Form
    {
        string H;
        double C;
        public string Resultid;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "剪刀石头布";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = (rd.Next(0, 3));
            string k =Convert.ToString(i);
            C = double.Parse(k);
            if (k == "0")
            {
                Cr.Text = "石头";
            }
            else if (k == "1")
            {
                Cr.Text = "剪刀";
            }
            else
            {
                Cr.Text = "布";
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            H = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = (rd.Next(0, 3));
            string k = Convert.ToString(i);
            C = double.Parse(k);
            if (k == "0")
            {
                Cr.Text = "石头";
            }
            else if (k == "1")
            {
                Cr.Text = "剪刀";
            }
            else
            {
                Cr.Text = "布";
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            H = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = (rd.Next(0, 3));
            string k = Convert.ToString(i);
            C =double.Parse (k);
            if (k == "0")
            {
                Cr.Text = "石头";
            }
            else if (k == "1")
            {
                Cr.Text = "剪刀";
            }
            else
            {
                Cr.Text = "布";
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            H = "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (H)
            {
                case "0":
                    if(C==0)
                    {
                        MessageBox.Show("平局，默认3条命");
                        Resultid = "0";
                    }
                    else if(C==1)
                    {
                        MessageBox.Show("你赢了，获得5条命");
                        Resultid = "w";
                    }
                    else
                    {
                        MessageBox.Show("你输了,只有1条命");
                        Resultid = "l";
                    }
                    break;
                case "1":
                    if (C == 0)
                    {
                        MessageBox.Show("你输了,只有1条命");
                        Resultid = "l";
                    }
                    else if (C == 1)
                    {
                        MessageBox.Show("平局，默认3条命");
                        Resultid = "0";
                    }
                    else
                    {
                        MessageBox.Show("你赢了，获得5条命");
                        Resultid = "w";
                    }
                    break;
                case "2":
                    if (C == 0)
                    {
                        MessageBox.Show("你赢了，获得5条命");
                        Resultid = "w";
                    }
                    else if (C == 1)
                    {
                        MessageBox.Show("你输了，只有1条命");
                        Resultid = "l";
                    }
                    else
                    {
                        MessageBox.Show("平局，默认3条命");
                        Resultid = "0";
                    }
                    break;
            }
            Form2 form2 = new Form2();
            form2.inputid = this.Resultid;
            form2.ShowDialog();
            Close();
        }
    }
}
