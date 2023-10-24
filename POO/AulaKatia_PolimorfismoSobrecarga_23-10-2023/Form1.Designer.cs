namespace AulaKatia_23_10_2023
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
            this.rbtnFuncionario = new System.Windows.Forms.RadioButton();
            this.rbtnVendedor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnFuncionario
            // 
            this.rbtnFuncionario.AutoSize = true;
            this.rbtnFuncionario.Location = new System.Drawing.Point(255, 47);
            this.rbtnFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFuncionario.Name = "rbtnFuncionario";
            this.rbtnFuncionario.Size = new System.Drawing.Size(95, 20);
            this.rbtnFuncionario.TabIndex = 0;
            this.rbtnFuncionario.TabStop = true;
            this.rbtnFuncionario.Text = "Funcionário";
            this.rbtnFuncionario.UseVisualStyleBackColor = true;
            this.rbtnFuncionario.CheckedChanged += new System.EventHandler(this.rbtnFuncionario_CheckedChanged);
            // 
            // rbtnVendedor
            // 
            this.rbtnVendedor.AutoSize = true;
            this.rbtnVendedor.Location = new System.Drawing.Point(454, 47);
            this.rbtnVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnVendedor.Name = "rbtnVendedor";
            this.rbtnVendedor.Size = new System.Drawing.Size(85, 20);
            this.rbtnVendedor.TabIndex = 1;
            this.rbtnVendedor.TabStop = true;
            this.rbtnVendedor.Text = "Vendedor";
            this.rbtnVendedor.UseVisualStyleBackColor = true;
            this.rbtnVendedor.CheckedChanged += new System.EventHandler(this.rbtnVendedor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(255, 139);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(284, 22);
            this.txtMatricula.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(255, 212);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 22);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(255, 281);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(105, 22);
            this.txtSalario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(434, 281);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(105, 22);
            this.txtBonus.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bônus";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(255, 353);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 22);
            this.txtTotal.TabIndex = 11;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Location = new System.Drawing.Point(251, 334);
            this.lblTotalVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(112, 16);
            this.lblTotalVendas.TabIndex = 10;
            this.lblTotalVendas.Text = "Total das vendas";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(255, 412);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 38);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 490);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnVendedor);
            this.Controls.Add(this.rbtnFuncionario);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFuncionario;
        private System.Windows.Forms.RadioButton rbtnVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Button btnMostrar;
    }
}