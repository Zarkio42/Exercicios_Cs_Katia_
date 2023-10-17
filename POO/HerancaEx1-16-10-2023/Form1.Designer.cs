namespace HerancaEx1
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
            this.lbValor = new System.Windows.Forms.Label();
            this.radioBtnIngresso = new System.Windows.Forms.RadioButton();
            this.radioBtnIngressoVip = new System.Windows.Forms.RadioButton();
            this.txtValorIngresso = new System.Windows.Forms.TextBox();
            this.lbAdicional = new System.Windows.Forms.Label();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(135, 76);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(154, 20);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor do ingresso:";
            // 
            // radioBtnIngresso
            // 
            this.radioBtnIngresso.AutoSize = true;
            this.radioBtnIngresso.Location = new System.Drawing.Point(295, 142);
            this.radioBtnIngresso.Name = "radioBtnIngresso";
            this.radioBtnIngresso.Size = new System.Drawing.Size(65, 17);
            this.radioBtnIngresso.TabIndex = 1;
            this.radioBtnIngresso.TabStop = true;
            this.radioBtnIngresso.Text = "Ingresso";
            this.radioBtnIngresso.UseVisualStyleBackColor = true;
            this.radioBtnIngresso.CheckedChanged += new System.EventHandler(this.radioBtnIngresso_CheckedChanged);
            // 
            // radioBtnIngressoVip
            // 
            this.radioBtnIngressoVip.AutoSize = true;
            this.radioBtnIngressoVip.Location = new System.Drawing.Point(398, 142);
            this.radioBtnIngressoVip.Name = "radioBtnIngressoVip";
            this.radioBtnIngressoVip.Size = new System.Drawing.Size(85, 17);
            this.radioBtnIngressoVip.TabIndex = 2;
            this.radioBtnIngressoVip.TabStop = true;
            this.radioBtnIngressoVip.Text = "Ingresso VIP";
            this.radioBtnIngressoVip.UseVisualStyleBackColor = true;
            this.radioBtnIngressoVip.CheckedChanged += new System.EventHandler(this.radioBtnIngressoVip_CheckedChanged);
            // 
            // txtValorIngresso
            // 
            this.txtValorIngresso.Location = new System.Drawing.Point(295, 78);
            this.txtValorIngresso.Name = "txtValorIngresso";
            this.txtValorIngresso.Size = new System.Drawing.Size(188, 20);
            this.txtValorIngresso.TabIndex = 3;
            // 
            // lbAdicional
            // 
            this.lbAdicional.AutoSize = true;
            this.lbAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdicional.Location = new System.Drawing.Point(135, 198);
            this.lbAdicional.Name = "lbAdicional";
            this.lbAdicional.Size = new System.Drawing.Size(134, 20);
            this.lbAdicional.TabIndex = 4;
            this.lbAdicional.Text = "Valor Adicional:";
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(295, 198);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(188, 20);
            this.txtAdicional.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(333, 264);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 31);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAdicional);
            this.Controls.Add(this.lbAdicional);
            this.Controls.Add(this.txtValorIngresso);
            this.Controls.Add(this.radioBtnIngressoVip);
            this.Controls.Add(this.radioBtnIngresso);
            this.Controls.Add(this.lbValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.RadioButton radioBtnIngresso;
        private System.Windows.Forms.RadioButton radioBtnIngressoVip;
        private System.Windows.Forms.TextBox txtValorIngresso;
        private System.Windows.Forms.Label lbAdicional;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.Button btnCalcular;
    }
}