namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEx1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEx1,
            this.btnEx2,
            this.btnEx3,
            this.btnEx4,
            this.btnEx5,
            this.btnEx6,
            this.btnEx7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEx1
            // 
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(42, 20);
            this.btnEx1.Text = "Ex01";
            this.btnEx1.Click += new System.EventHandler(this.ex01ToolStripMenuItem_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(42, 20);
            this.btnEx2.Text = "Ex02";
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(42, 20);
            this.btnEx3.Text = "Ex03";
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(42, 20);
            this.btnEx4.Text = "Ex04";
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(42, 20);
            this.btnEx5.Text = "Ex05";
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // btnEx6
            // 
            this.btnEx6.Name = "btnEx6";
            this.btnEx6.Size = new System.Drawing.Size(42, 20);
            this.btnEx6.Text = "Ex06";
            this.btnEx6.Click += new System.EventHandler(this.btnEx6_Click);
            // 
            // btnEx7
            // 
            this.btnEx7.Name = "btnEx7";
            this.btnEx7.Size = new System.Drawing.Size(42, 20);
            this.btnEx7.Text = "Ex07";
            this.btnEx7.Click += new System.EventHandler(this.btnEx7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEx1;
        private System.Windows.Forms.ToolStripMenuItem btnEx2;
        private System.Windows.Forms.ToolStripMenuItem btnEx3;
        private System.Windows.Forms.ToolStripMenuItem btnEx4;
        private System.Windows.Forms.ToolStripMenuItem btnEx5;
        private System.Windows.Forms.ToolStripMenuItem btnEx6;
        private System.Windows.Forms.ToolStripMenuItem btnEx7;
    }
}

