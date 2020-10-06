namespace PesoIdeal
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtmMasculino = new System.Windows.Forms.RadioButton();
            this.rbtmFeminino = new System.Windows.Forms.RadioButton();
            this.mskPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(150, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(182, 59);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtmMasculino);
            this.groupBox1.Controls.Add(this.rbtmFeminino);
            this.groupBox1.Location = new System.Drawing.Point(322, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtmMasculino
            // 
            this.rbtmMasculino.AutoSize = true;
            this.rbtmMasculino.Location = new System.Drawing.Point(40, 55);
            this.rbtmMasculino.Name = "rbtmMasculino";
            this.rbtmMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtmMasculino.TabIndex = 1;
            this.rbtmMasculino.TabStop = true;
            this.rbtmMasculino.Text = "Masculino";
            this.rbtmMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtmFeminino
            // 
            this.rbtmFeminino.AutoSize = true;
            this.rbtmFeminino.Location = new System.Drawing.Point(40, 20);
            this.rbtmFeminino.Name = "rbtmFeminino";
            this.rbtmFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtmFeminino.TabIndex = 0;
            this.rbtmFeminino.TabStop = true;
            this.rbtmFeminino.Text = "Feminino";
            this.rbtmFeminino.UseVisualStyleBackColor = true;
            // 
            // mskPesoAtual
            // 
            this.mskPesoAtual.Location = new System.Drawing.Point(150, 33);
            this.mskPesoAtual.Mask = "000.000";
            this.mskPesoAtual.Name = "mskPesoAtual";
            this.mskPesoAtual.Size = new System.Drawing.Size(100, 20);
            this.mskPesoAtual.TabIndex = 6;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(150, 89);
            this.mskAltura.Mask = "0.00";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(100, 20);
            this.mskAltura.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.mskPesoAtual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtmMasculino;
        private System.Windows.Forms.RadioButton rbtmFeminino;
        private System.Windows.Forms.MaskedTextBox mskPesoAtual;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

