namespace Pmetodos
{
    partial class frmExercicio4
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
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnContaNumeros = new System.Windows.Forms.Button();
            this.btnPosicaoBranco = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Location = new System.Drawing.Point(12, 12);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(339, 105);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnContaNumeros
            // 
            this.btnContaNumeros.Location = new System.Drawing.Point(12, 123);
            this.btnContaNumeros.Name = "btnContaNumeros";
            this.btnContaNumeros.Size = new System.Drawing.Size(80, 64);
            this.btnContaNumeros.TabIndex = 1;
            this.btnContaNumeros.Text = "Quantidade de números";
            this.btnContaNumeros.UseVisualStyleBackColor = true;
            this.btnContaNumeros.Click += new System.EventHandler(this.btnContaNumeros_Click);
            // 
            // btnPosicaoBranco
            // 
            this.btnPosicaoBranco.Location = new System.Drawing.Point(98, 123);
            this.btnPosicaoBranco.Name = "btnPosicaoBranco";
            this.btnPosicaoBranco.Size = new System.Drawing.Size(115, 64);
            this.btnPosicaoBranco.TabIndex = 2;
            this.btnPosicaoBranco.Text = "Posição Primeiro espaço branco";
            this.btnPosicaoBranco.UseVisualStyleBackColor = true;
            this.btnPosicaoBranco.Click += new System.EventHandler(this.btnPosicaoBranco_Click);
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(219, 123);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(132, 64);
            this.btnContaLetras.TabIndex = 3;
            this.btnContaLetras.Text = "Quantidade de Letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 199);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnPosicaoBranco);
            this.Controls.Add(this.btnContaNumeros);
            this.Controls.Add(this.rchTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnContaNumeros;
        private System.Windows.Forms.Button btnPosicaoBranco;
        private System.Windows.Forms.Button btnContaLetras;
    }
}