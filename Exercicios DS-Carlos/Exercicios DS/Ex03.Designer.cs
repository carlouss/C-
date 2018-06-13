namespace WindowsFormsApplication1
{
    partial class Ex03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex03));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.txbC = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado C";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(69, 77);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 3;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(69, 110);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 4;
            // 
            // txbC
            // 
            this.txbC.Location = new System.Drawing.Point(69, 142);
            this.txbC.Name = "txbC";
            this.txbC.Size = new System.Drawing.Size(100, 20);
            this.txbC.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificar.Image")));
            this.btnVerificar.Location = new System.Drawing.Point(176, 77);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 85);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(25, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 39);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "3. Ler 3 números, os possíveis lados de um\r\n triângulo, e imprimir a classificaçã" +
                "o de acordo\r\n com tamanho dos lados. ";
            // 
            // Ex03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(262, 262);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbC);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex03";
            this.Text = "Ex03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.TextBox txbC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblTitulo;
    }
}