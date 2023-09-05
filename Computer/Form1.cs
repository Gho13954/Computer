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
    public partial class Form1 : Form
    {
        double dis1, dis2, result;            //记录第一个数和第二个数还有计算结果

        bool Spot = false;                      //判断有没有按下小数点

        string asmd;                //加减乘除

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.Text = "  ";
            history.Text = "  ";
            this.Text = "计算机";
        }

        private void equal_Click(object sender, EventArgs e)        //=出结果
        {
            if (display.Text=="  ")
            {
                
            }
            else
            { 
            dis2 = double.Parse(display.Text);
                switch (asmd)
                {
                    case "+":
                        result = dis1 + dis2;
                        display.Text = result.ToString();
                        break;
                    case "-":
                        result = dis1 - dis2;
                        display.Text = result.ToString();
                        break;
                    case "*":
                        result = dis1 * dis2;
                        display.Text = result.ToString();
                        break;
                    case "/":
                        if (dis2 == 0)
                        {
                            display.Text = "除数不能为0";
                        }
                        else
                        {
                            result = dis1 / dis2;
                            display.Text = result.ToString();
                        }
                        break;
                }
                string X = history.Text;
                history.SelectedText = ")";
                spot.Enabled = true;
            }
        }

        public void ClickNum(int Num)
        {
            if (Spot == false)                                          //还未按下小数点
            {
                if (display.Text == "  ")                            //还未输入数字
                {
                    display.Text = Num.ToString() + " ";             //将display结果改为输入的数字加上空格
                    history.SelectedText = Num.ToString();
                }
                else                                                 //已经输入数字了
                {
                    display.Text = display.Text.Substring(0, display.Text.Length - 1) + Num.ToString() + " ";       //用输入数字替换后面的空格
                    history.SelectedText = Num.ToString();
                }
            }
            else                                                     //按下了小数点
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1)  +"."+ Num.ToString() + " ";
                history.SelectedText = "."+Num.ToString();
                Spot = false;
            }   
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            ClickNum(0);
        }

        private void One_Click(object sender, EventArgs e)
        {
            ClickNum(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            ClickNum(2);
        }

        private void there_Click(object sender, EventArgs e)
        {
            ClickNum(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            ClickNum(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            ClickNum(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            ClickNum(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            ClickNum(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            ClickNum(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            ClickNum(9);
        }

        private void add_Click(object sender, EventArgs e)
        {
            asmd = "+";
            dis1 = double.Parse(display.Text);
            display.Text = "  ";
            history.SelectedText = "+";
            spot.Enabled = true;
            Spot = false;
        }

        private void st_Click(object sender, EventArgs e)
        {
            asmd = "-";
            dis1 = double.Parse(display.Text);
            display.Text = "  ";
            history.SelectedText = "-";
            spot.Enabled = true;
            Spot = false;
        }

        private void mt_Click(object sender, EventArgs e)
        {
            asmd = "*";
            dis1 = double.Parse(display.Text);
            display.Text = "  ";
            history.SelectedText = "×";
            spot.Enabled = true;
            Spot = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            asmd = "/";
            dis1 = double.Parse(display.Text);
            display.Text = "  ";
            history.SelectedText = "÷";
            spot.Enabled = true;
            Spot = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            history.Text = "  ";
        }

        private void spot_Click(object sender, EventArgs e)
        {
                Spot = true;
                spot.Enabled = false;
        }

        private void Returnzero_Click(object sender, EventArgs e)
        {
            display.Text = "  ";
            dis1 = 0;
            dis2 = 0;
            result = 0;
            history.Text = "  ";
            spot.Enabled = true;
            Spot = false;
        }

    }
}
