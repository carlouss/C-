using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FORM1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();//cria uma instancia do forrmulario teste1
            tst1.MdiParent = this; //esta linha define que a instancia do formulario criado é "filho" do formulario principal
            tst1.Show(); //esta linha exibe o formulario Teste1
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();//cria uma instancia do forrmulario teste1
            tst1.MdiParent = this; //esta linha define que a instancia do formulario criado é "filho" do formulario principal
            tst1.Show(); //esta linha exibe o formulario Teste1
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data:" + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
