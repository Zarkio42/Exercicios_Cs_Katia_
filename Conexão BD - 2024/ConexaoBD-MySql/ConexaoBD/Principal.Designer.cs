namespace ConexaoBD
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduto = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 426);
            this.panel1.TabIndex = 1;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(17, 23);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(83, 74);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Location = new System.Drawing.Point(150, 12);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(779, 426);
            this.pnlTela.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Forms1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Panel pnlTela;
    }
}