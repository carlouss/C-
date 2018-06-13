namespace WindowsFormsApplication1
{
    partial class Ex01
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
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(26, 62);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(70, 20);
            this.txbValor1.TabIndex = 0;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(121, 62);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(70, 20);
            this.txbValor2.TabIndex = 1;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(42, 34);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(135, 34);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 3;
            this.lblValor2.Text = "Valor 2";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(216, 62);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(70, 20);
            this.txbResult.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(222, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(102, 65);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(13, 13);
            this.lblPlus.TabIndex = 6;
            this.lblPlus.Text = "+";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(197, 65);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 7;
            this.lblEquals.Text = "=";
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(26, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(260, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Ex01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(318, 125);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Name = "Ex01";
            this.Text = "Ex01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Button btnCalcular;
    }
}