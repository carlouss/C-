namespace WindowsFormsApplication1
{
    partial class Ex02
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
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(44, 61);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(190, 20);
            this.txbNum.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificar.Location = new System.Drawing.Point(44, 103);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(190, 131);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(44, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 26);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "coloque um número para verificar\r\n se ele é divisível por 10, por 5 ou por 2";
            // 
            // Ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbNum);
            this.Name = "Ex02";
            this.Text = "Ex02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTitulo;
    }
}