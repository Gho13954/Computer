using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form2 : Form
    {
        public string inputid;
        int i = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "飞机大战";
            this.KeyPreview = true;
            plane.Left = Gameplane.Width / 2 - plane.Width / 2;
            plane.Top = Gameplane.Width - plane.Width*2;
            plane.Tag = "P";
            Gameplane.Controls.Add(plane);
            timer1.Stop();
            timer2.Stop();
            if(inputid=="w")
            {
                life.Text = "*****";
            }
            else if(inputid=="l")
            {
                life.Text = "*";
            }
            else
            {
                life.Text = "***";
            }
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            if(difficulty.SelectedIndex == -1)
            {
                MessageBox.Show("请选择难度");
            }
            else
            {
                timer1.Start();
                timer2.Start();
            }
        }

        private void gameread_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
            Close();
        }
        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(difficulty.Text== "easy")
            {
                timer1.Interval = 1500;
                timer2.Interval = 150;
            }
            else if(difficulty.Text == "normal")
            {
                timer1.Interval = 1000;
                timer2.Interval = 100;
            }
            else
            {
                timer1.Interval = 500;
                timer2.Interval = 50;
            }
        }
        Random rd = new Random();
        public void timer1_Tick(object sender, EventArgs e)
        {
            Label English = new Label();
            English.Text = ((char)rd.Next(97,123)).ToString();
            English.Font = new Font("宋体", rd.Next(25, 35));
            English.ForeColor=Color.FromArgb(rd.Next(255),rd.Next(255),rd.Next(255));
            English.Left = rd.Next(Gameplane.Width - English.Width);
            English.AutoSize = true;
            English.Tag = "English";
            Gameplane.Controls.Add(English);
        }

        public void timer2_Tick_1(object sender, EventArgs e)
        {
            foreach(Control item in Gameplane.Controls)
            {
                if (item.Tag.ToString() == "English")
                {
                    if (item.Top<Gameplane.Height)
                    {
                        item.Top += 8;
                    }
                    else
                    {
                        item.Dispose();
                        if(life.Text=="*****")
                        {
                            life.Text = "****";
                            return;
                        }
                        else if (life.Text == "*")
                        {
                            timer1.Stop();
                            timer2.Stop();
                            life.Text = " ";
                            Gameplane.Controls.Remove(item);
                            MessageBox.Show("game over");
                            gameread.Text = "重新开始？";
                            i = 0;
                        }
                        else if (life.Text == "**")
                        {
                            life.Text = "*";
                            return;
                        }
                        else if (life.Text == "***")
                        {
                            life.Text = "**";
                            return;
                        }
                        else if(life.Text=="****")
                        {
                            life.Text = "***";
                            return;
                        }



                    }
                }
            }
        }

        private void Theworld_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            startgame.Text = "继续游戏";
        }

        public void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control item in Gameplane.Controls)
            {
                if (item.Tag.ToString() == "English")
                {
                    if (e.KeyChar.ToString() == item.Text.ToString())
                    {
                        plane.Left = item.Left + item.Width / 2 - plane.Width / 2;
                        item.Dispose();
                        i++;
                        ft.Text = i.ToString();
                    }
                }
            }
        }
    }
}