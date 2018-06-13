namespace WindowsFormsApplication1
{
    partial class Ex04
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMes = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblEquals2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(8, 89);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(90, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Insira um número:";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(121, 86);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(28, 20);
            this.txbNum.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 52);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "4. Ler um número inteiro entre 1 e 12 e escrever \r\no mês correspondente. \r\nCaso o" +
                " número seja fora desse intervalo,\r\n informar que não existe mês com este número" +
                ". (usar if) ";
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(11, 116);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(86, 23);
            this.btnMes.TabIndex = 3;
            this.btnMes.Text = "Mês";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 121);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(104, 89);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 5;
            this.lblEquals.Text = "=";
            // 
            // lblEquals2
            // 
            this.lblEquals2.AutoSize = true;
            this.lblEquals2.Location = new System.Drawing.Point(105, 121);
            this.lblEquals2.Name = "lblEquals2";
            this.lblEquals2.Size = new System.Drawing.Size(13, 13);
            this.lblEquals2.TabIndex = 6;
            this.lblEquals2.Text = "=";
            // 
            // Ex04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblEquals2);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Ex04";
            this.Text = "Ex04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblEquals2;
    }
}