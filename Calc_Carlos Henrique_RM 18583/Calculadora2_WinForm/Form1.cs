using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        float num1,num2,result;
        int opera,v=0; //Tipo de operação
        //0
        private void btn0_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 0;
            txbHist.Text = txbHist.Text + 0;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 0;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 0;
            }
        }
        //1
        private void btn1_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 1;
            txbHist.Text = txbHist.Text + 1;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 1;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 1;
            }
        }
        //2
        private void btn2_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 2;
            txbHist.Text = txbHist.Text + 2;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 2;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 2;
            }
        }
        //3
        private void btn3_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 3;
            txbHist.Text = txbHist.Text + 3;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 3;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 3;
            }
        }
        //4
        private void btn4_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 4;
            txbHist.Text = txbHist.Text + 4;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 4;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 4;
            }
        }
        //5
        private void btn5_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 5;
            txbHist.Text = txbHist.Text + 5;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 5;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 5;
            }
        }
        //6
        private void btn6_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 6;
            txbHist.Text = txbHist.Text + 6;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 6;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 6;
            }
        }
        //7
        private void btn7_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 7;
            txbHist.Text = txbHist.Text + 7;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 7;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 7;
            }
        }
        //8
        private void btn8_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 8;
            txbHist.Text = txbHist.Text + 8;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 8;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 8;
            }
        }
        //9
        private void btn9_Click(object sender, EventArgs e)
        {
            txbCalculo.Text = txbCalculo.Text + 9;
            txbHist.Text = txbHist.Text + 9;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 9;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 9;
            }
        }
        //+
        private void btnMais_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (opera)
                {
                    case 1:
                        {
                            result = num1 + num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 2:
                        {
                            result = num1 - num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 3:
                        {
                            result = num1 / num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 4:
                        {
                            result = num1 * num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = result;
                num2 = 0;
            }

                result = float.Parse(txbCalculo.Text);
                txbCalculo.Clear();
                opera = 1;
                txbHist.Text = txbHist.Text + "+";
                v++;
        }
        // -
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (opera)
                {
                    case 1:
                        {
                            result = num1 + num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 2:
                        {
                            result = num1 - num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 3:
                        {
                            result = num1 / num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 4:
                        {
                            result = num1 * num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = result;
                num2 = 0;
            }
            
                result = float.Parse(txbCalculo.Text);
                txbCalculo.Clear();
                opera = 2;
                txbHist.Text = txbHist.Text + "-";
                v++;
        }
        // *
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (opera)
                {
                    case 1:
                        {
                            result = num1 + num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 2:
                        {
                            result = num1 - num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 3:
                        {
                            result = num1 / num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 4:
                        {
                            result = num1 * num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = result;
                num2 = 0;
            }
            
                result = float.Parse(txbCalculo.Text);
                txbCalculo.Clear();
                opera = 3;
                txbHist.Text = txbHist.Text + "*";
                v++;
        }
        // /
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (opera)
                {
                    case 1:
                        {
                            result = num1 + num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 2:
                        {
                            result = num1 - num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 3:
                        {
                            result = num1 / num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    case 4:
                        {
                            result = num1 * num2;
                            txbCalculo.Text = result.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = result;
                num2 = 0;
            }
            
                result = float.Parse(txbCalculo.Text);
                txbCalculo.Clear();
                opera = 4;
                txbHist.Text = txbHist.Text + "/";
                v++;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (opera) { 
                case 1:{
                    result = result + float.Parse(txbCalculo.Text);
                    txbCalculo.Text = result.ToString();
                    break;
                }
                case 2:
                    {
                        result = result - float.Parse(txbCalculo.Text);
                        txbCalculo.Text = result.ToString();
                        break;
                    }
                case 3:
                    {
                        result = result * float.Parse(txbCalculo.Text);
                        txbCalculo.Text = result.ToString();
                        break;
                    }
                case 4:
                    {
                        result = result / float.Parse(txbCalculo.Text);
                        txbCalculo.Text = result.ToString();
                        break;
                    }
                    default:
                    break;
            }
            num1 = result;
            num2 = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCalculo.Clear();
            txbHist.Clear();
        }




        }
    }

