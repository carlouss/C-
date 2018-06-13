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
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            float A;

            A = float.Parse(txbNum.Text);

            {
                for (int I = 0; I <= A; I++)
                {
                    listResult.Items.Add("Brasil");
                }
            }
        }


    }
}
