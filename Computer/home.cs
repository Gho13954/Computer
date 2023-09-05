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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
        }

        private void f3_Click(object sender, EventArgs e)
        {
            Form F = new Form2();
            F.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
