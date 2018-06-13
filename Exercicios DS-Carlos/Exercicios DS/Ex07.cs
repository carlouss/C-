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
    public partial class Ex07 : Form
    {
        public Ex07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double A, M;
            A = 1.50;
            M = 1.10;

            for (int I = 1; M < A; I++)
            {
                A = A + 0.02;
                M = M + 0.03;
                lblAno.Text = I.ToString(+I+" Anos");
            }

        }
    }
}
