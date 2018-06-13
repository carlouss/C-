namespace WindowsFormsApplication1
{
    partial class Ex06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(12, 147);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(120, 95);
            this.listResult.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 115);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Printar";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(117, 86);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(46, 20);
            this.txbNum.TabIndex = 8;
            this.txbNum.Text = "0";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(9, 89);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(101, 13);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "Digite um número = ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 26);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "6. Entrar com o número de vezes que se deseja imprimir\r\n a palavra “Brasil”. (Usa" +
                "r Loop – For / While / Do While) ";
            // 
            // Ex06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ex06";
            this.Text = "Ex06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTitulo;

    }
}