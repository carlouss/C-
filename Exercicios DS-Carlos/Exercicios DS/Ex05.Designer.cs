namespace WindowsFormsApplication1
{
    partial class Ex05
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "5. Criar um algoritmos que leia um número até 50\r\n e imprima todos os número de 1" +
                " até o número digitado.\r\n (Usar Loop – For / While / Do While) ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 97);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(101, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Digite um número = ";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(120, 94);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(46, 20);
            this.txbNum.TabIndex = 2;
            this.txbNum.Text = "Max:50";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(15, 123);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Printar";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(15, 155);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(120, 95);
            this.listResult.TabIndex = 5;
            // 
            // Ex05
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
            this.Name = "Ex05";
            this.Text = "Ex05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox listResult;
    }
}