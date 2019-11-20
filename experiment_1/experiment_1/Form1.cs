using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experiment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = "学号："+textBox1.Text + "\n姓名：" + textBox2.Text + "\n性别：" + textBox3.Text + "\n年龄：" + textBox4.Text + "\n专业：" + textBox5.Text + "\n";
            textBox6.Text = str;
        }
    }
}
