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
    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float v1, v2,result;
            v1 = float.Parse(txbValor1.Text);
            v2 = float.Parse(txbValor2.Text);
            result = v1 + v2;

            if (result > 20)
            {
                result = result + 8;
                txbResult.Text = result.ToString();
            }
            else {
                result = result-5;
                txbResult.Text = result.ToString();
            }
        }

    }
}
