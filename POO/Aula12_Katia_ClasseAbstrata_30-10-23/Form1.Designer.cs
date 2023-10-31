namespace Aula10_Katia_ClasseAbstrata_30_10_23
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnQuadrado = new System.Windows.Forms.RadioButton();
            this.rbtnCirculo = new System.Windows.Forms.RadioButton();
            this.pnlQuadrado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLadoQuadrado = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPerimetro = new System.Windows.Forms.Label();
            this.pnlRetangulo = new System.Windows.Forms.Panel();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.pnlCirculo = new System.Windows.Forms.Panel();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtnRetangulo = new System.Windows.Forms.RadioButton();
            this.pnlQuadrado.SuspendLayout();
            this.pnlRetangulo.SuspendLayout();
            this.pnlCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formas:";
            // 
            // rbtnQuadrado
            // 
            this.rbtnQuadrado.AutoSize = true;
            this.rbtnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuadrado.Location = new System.Drawing.Point(79, 130);
            this.rbtnQuadrado.Name = "rbtnQuadrado";
            this.rbtnQuadrado.Size = new System.Drawing.Size(86, 20);
            this.rbtnQuadrado.TabIndex = 1;
            this.rbtnQuadrado.TabStop = true;
            this.rbtnQuadrado.Text = "Quadrado";
            this.rbtnQuadrado.UseVisualStyleBackColor = true;
            this.rbtnQuadrado.CheckedChanged += new System.EventHandler(this.rbtnQuadrado_CheckedChanged);
            // 
            // rbtnCirculo
            // 
            this.rbtnCirculo.AutoSize = true;
            this.rbtnCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCirculo.Location = new System.Drawing.Point(79, 231);
            this.rbtnCirculo.Name = "rbtnCirculo";
            this.rbtnCirculo.Size = new System.Drawing.Size(66, 20);
            this.rbtnCirculo.TabIndex = 3;
            this.rbtnCirculo.TabStop = true;
            this.rbtnCirculo.Text = "Circulo";
            this.rbtnCirculo.UseVisualStyleBackColor = true;
            this.rbtnCirculo.CheckedChanged += new System.EventHandler(this.rbtnCirculo_CheckedChanged);
            // 
            // pnlQuadrado
            // 
            this.pnlQuadrado.Controls.Add(this.txtLadoQuadrado);
            this.pnlQuadrado.Controls.Add(this.label2);
            this.pnlQuadrado.Location = new System.Drawing.Point(532, 274);
            this.pnlQuadrado.Name = "pnlQuadrado";
            this.pnlQuadrado.Size = new System.Drawing.Size(256, 97);
            this.pnlQuadrado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lados";
            // 
            // txtLadoQuadrado
            // 
            this.txtLadoQuadrado.Location = new System.Drawing.Point(58, 37);
            this.txtLadoQuadrado.Multiline = true;
            this.txtLadoQuadrado.Name = "txtLadoQuadrado";
            this.txtLadoQuadrado.Size = new System.Drawing.Size(180, 29);
            this.txtLadoQuadrado.TabIndex = 6;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(272, 236);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(40, 15);
            this.lbArea.TabIndex = 7;
            this.lbArea.Text = "Área:";
            // 
            // lbPerimetro
            // 
            this.lbPerimetro.AutoSize = true;
            this.lbPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerimetro.Location = new System.Drawing.Point(272, 285);
            this.lbPerimetro.Name = "lbPerimetro";
            this.lbPerimetro.Size = new System.Drawing.Size(74, 15);
            this.lbPerimetro.TabIndex = 8;
            this.lbPerimetro.Text = "Perímetro:";
            // 
            // pnlRetangulo
            // 
            this.pnlRetangulo.Controls.Add(this.txtLado2);
            this.pnlRetangulo.Controls.Add(this.label6);
            this.pnlRetangulo.Controls.Add(this.txtLado1);
            this.pnlRetangulo.Controls.Add(this.label5);
            this.pnlRetangulo.Location = new System.Drawing.Point(423, 12);
            this.pnlRetangulo.Name = "pnlRetangulo";
            this.pnlRetangulo.Size = new System.Drawing.Size(365, 138);
            this.pnlRetangulo.TabIndex = 7;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(82, 23);
            this.txtLado1.Multiline = true;
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(211, 28);
            this.txtLado1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lado 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lado 2";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(82, 70);
            this.txtLado2.Multiline = true;
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(211, 29);
            this.txtLado2.TabIndex = 8;
            // 
            // pnlCirculo
            // 
            this.pnlCirculo.Controls.Add(this.txtRaio);
            this.pnlCirculo.Controls.Add(this.label8);
            this.pnlCirculo.Location = new System.Drawing.Point(497, 156);
            this.pnlCirculo.Name = "pnlCirculo";
            this.pnlCirculo.Size = new System.Drawing.Size(291, 97);
            this.pnlCirculo.TabIndex = 9;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(68, 33);
            this.txtRaio.Multiline = true;
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(211, 29);
            this.txtRaio.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raio";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(80, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 33);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtnRetangulo
            // 
            this.rbtnRetangulo.AutoSize = true;
            this.rbtnRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRetangulo.Location = new System.Drawing.Point(79, 182);
            this.rbtnRetangulo.Name = "rbtnRetangulo";
            this.rbtnRetangulo.Size = new System.Drawing.Size(87, 20);
            this.rbtnRetangulo.TabIndex = 11;
            this.rbtnRetangulo.TabStop = true;
            this.rbtnRetangulo.Text = "Retângulo";
            this.rbtnRetangulo.UseVisualStyleBackColor = true;
            this.rbtnRetangulo.CheckedChanged += new System.EventHandler(this.rbtnRetangulo_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnRetangulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pnlCirculo);
            this.Controls.Add(this.pnlQuadrado);
            this.Controls.Add(this.pnlRetangulo);
            this.Controls.Add(this.lbPerimetro);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.rbtnCirculo);
            this.Controls.Add(this.rbtnQuadrado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlQuadrado.ResumeLayout(false);
            this.pnlQuadrado.PerformLayout();
            this.pnlRetangulo.ResumeLayout(false);
            this.pnlRetangulo.PerformLayout();
            this.pnlCirculo.ResumeLayout(false);
            this.pnlCirculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnQuadrado;
        private System.Windows.Forms.RadioButton rbtnCirculo;
        private System.Windows.Forms.Panel pnlQuadrado;
        private System.Windows.Forms.TextBox txtLadoQuadrado;
        private System.Windows.Forms.Panel pnlCirculo;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlRetangulo;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPerimetro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtnRetangulo;
    }
}