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
    public partial class Ex04 : Form
    {
        public Ex04()
        {
            InitializeComponent();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            float A;
            A = float.Parse(txbNum.Text);

            if (A == 1) {
                lblResult.Text="Janeiro";
            }
            else if (A == 2){
                lblResult.Text = "Fevereiro";
            }
            else if (A == 3)
            {
                lblResult.Text = "Março";
            }
            else if (A == 4)
            {
                lblResult.Text = "Abril";
            }
            else if (A == 5)
            {
                lblResult.Text = "Maio";
            }
            else if (A == 6)
            {
                lblResult.Text = "Junho";
            }
            else if (A == 7)
            {
                lblResult.Text = "Julho";
            }
            else if (A == 8)
            {
                lblResult.Text = "Agosto";
            }
            else if (A == 9)
            {
                lblResult.Text = "Setembro";
            }
            else if (A == 10)
            {
                lblResult.Text = "Outubro";
            }
            else if (A == 11)
            {
                lblResult.Text = "Novembro";
            }
            else if (A == 12)
            {
                lblResult.Text = "Dezembro";
            }
            else {
                lblResult.Text = "Nenhum mês correspondente";
            }
        }
    }
}
