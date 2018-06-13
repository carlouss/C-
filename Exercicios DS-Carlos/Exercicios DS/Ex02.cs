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
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            float valor;
            valor = float.Parse(txbNum.Text);
            if (valor % 10 == 0)
            {
                lblResult.Text = "O número é divisível por 10!";
            }
            else if (valor % 5 == 0)
            {
                lblResult.Text = "O número é divisível por 5!";
            }
            else if (valor % 2 == 0)
            {
                lblResult.Text = "O número é divisível por 2!";
            }
            else {
                lblResult.Text = "Nenhum dos números!";
            }

        }
    }
}
