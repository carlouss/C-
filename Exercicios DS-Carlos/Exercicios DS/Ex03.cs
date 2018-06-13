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
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            float A, B, C;
            A = float.Parse(txbA.Text);
            B = float.Parse(txbB.Text);
            C = float.Parse(txbC.Text);

            if (A == B & A == C && C == B) {
                lblResult.Text = "Triângulo equilatero!";
            }
            else if ((A == B & A != C) || (A == C && A != B) || (B == C & A != C))
            {
                lblResult.Text = "Triângulo isosceles!";
            }
            else {
                lblResult.Text = "Triângulo escaleno!";
            }
        }


    }
}
