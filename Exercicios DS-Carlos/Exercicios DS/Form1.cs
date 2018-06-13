using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex01 formEx1=new Ex01();
            formEx1.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Ex02 formEx2 = new Ex02();
            formEx2.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Ex03 formEx3 = new Ex03();
            formEx3.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Ex04 formEx4 = new Ex04();
            formEx4.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            Ex05 formEx5 = new Ex05();
            formEx5.Show();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            Ex06 formEx6 = new Ex06();
            formEx6.Show();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            Ex07 formEx7 = new Ex07();
            formEx7.Show();
        }
    }
}
