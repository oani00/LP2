namespace exercicios__oani
{
    partial class Form_1
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
            this.txtVezes = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtBranco = new System.Windows.Forms.TextBox();
            this.btnPardLetras = new System.Windows.Forms.Button();
            this.btnNVezes = new System.Windows.Forms.Button();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtVezes
            // 
            this.txtVezes.Location = new System.Drawing.Point(384, 170);
            this.txtVezes.Name = "txtVezes";
            this.txtVezes.Size = new System.Drawing.Size(161, 20);
            this.txtVezes.TabIndex = 23;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(200, 169);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(161, 20);
            this.txtR.TabIndex = 22;
            // 
            // txtBranco
            // 
            this.txtBranco.Location = new System.Drawing.Point(9, 170);
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.Size = new System.Drawing.Size(161, 20);
            this.txtBranco.TabIndex = 21;
            // 
            // btnPardLetras
            // 
            this.btnPardLetras.Location = new System.Drawing.Point(384, 125);
            this.btnPardLetras.Name = "btnPardLetras";
            this.btnPardLetras.Size = new System.Drawing.Size(161, 38);
            this.btnPardLetras.TabIndex = 20;
            this.btnPardLetras.Text = "Vezes em que ocorre um par de letras qualquer\r\n";
            this.btnPardLetras.UseVisualStyleBackColor = true;
            this.btnPardLetras.Click += new System.EventHandler(this.btnPardLetras_Click);
            // 
            // btnNVezes
            // 
            this.btnNVezes.Location = new System.Drawing.Point(200, 125);
            this.btnNVezes.Name = "btnNVezes";
            this.btnNVezes.Size = new System.Drawing.Size(161, 38);
            this.btnNVezes.TabIndex = 19;
            this.btnNVezes.Text = "N vezes aparece \"R\"";
            this.btnNVezes.UseVisualStyleBackColor = true;
            this.btnNVezes.Click += new System.EventHandler(this.btnNVezes_Click);
            // 
            // btnEspacos
            // 
            this.btnEspacos.Location = new System.Drawing.Point(9, 125);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(161, 38);
            this.btnEspacos.TabIndex = 18;
            this.btnEspacos.Text = "Espacos em Branco";
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(533, 96);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 230);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtVezes);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.btnPardLetras);
            this.Controls.Add(this.btnNVezes);
            this.Controls.Add(this.btnEspacos);
            this.Name = "Form_1";
            this.Text = "Form_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVezes;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtBranco;
        private System.Windows.Forms.Button btnPardLetras;
        private System.Windows.Forms.Button btnNVezes;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}