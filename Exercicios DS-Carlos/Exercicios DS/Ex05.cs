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
    public partial class Ex05 : Form
    {
        public Ex05()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            float A;

            A = float.Parse(txbNum.Text);

            if (A > 50)
            {
                txbNum.Text = "ERROR";
            }
            else
            {
                for (int I = 0; I <= A; I++)
                {
                    listResult.Items.Add(I);
                }
            }
        }
    }
}
