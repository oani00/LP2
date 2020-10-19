namespace Pmetodos
{
    partial class frmExercicio2
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
            this.lblllbla = new System.Windows.Forms.Label();
            this.btnTestaIguais = new System.Windows.Forms.Button();
            this.btnInsere1 = new System.Windows.Forms.Button();
            this.btnInsere2 = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            // 
            // lblllbla
            // 
            this.lblllbla.AutoSize = true;
            this.lblllbla.Location = new System.Drawing.Point(128, 160);
            this.lblllbla.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblllbla.Name = "lblllbla";
            this.lblllbla.Size = new System.Drawing.Size(103, 25);
            this.lblllbla.TabIndex = 1;
            this.lblllbla.Text = "Palavra 2";
            // 
            // btnTestaIguais
            // 
            this.btnTestaIguais.Location = new System.Drawing.Point(133, 223);
            this.btnTestaIguais.Margin = new System.Windows.Forms.Padding(6);
            this.btnTestaIguais.Name = "btnTestaIguais";
            this.btnTestaIguais.Size = new System.Drawing.Size(165, 89);
            this.btnTestaIguais.TabIndex = 2;
            this.btnTestaIguais.Text = "Testa se são Iguais";
            this.btnTestaIguais.UseVisualStyleBackColor = true;
            this.btnTestaIguais.Click += new System.EventHandler(this.btnTestaIguais_Click);
            // 
            // btnInsere1
            // 
            this.btnInsere1.Location = new System.Drawing.Point(316, 223);
            this.btnInsere1.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsere1.Name = "btnInsere1";
            this.btnInsere1.Size = new System.Drawing.Size(212, 89);
            this.btnInsere1.TabIndex = 3;
            this.btnInsere1.Text = "Insere Primeiro no meio do Segundo";
            this.btnInsere1.UseVisualStyleBackColor = true;
            this.btnInsere1.Click += new System.EventHandler(this.btnInsere1_Click);
            // 
            // btnInsere2
            // 
            this.btnInsere2.Location = new System.Drawing.Point(549, 223);
            this.btnInsere2.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsere2.Name = "btnInsere2";
            this.btnInsere2.Size = new System.Drawing.Size(144, 89);
            this.btnInsere2.TabIndex = 4;
            this.btnInsere2.Text = "Insere Asteriscos";
            this.btnInsere2.UseVisualStyleBackColor = true;
            this.btnInsere2.Click += new System.EventHandler(this.btnInsere2_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(316, 88);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(196, 31);
            this.txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(316, 154);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(196, 31);
            this.txtPalavra2.TabIndex = 6;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 352);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnInsere2);
            this.Controls.Add(this.btnInsere1);
            this.Controls.Add(this.btnTestaIguais);
            this.Controls.Add(this.lblllbla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblllbla;
        private System.Windows.Forms.Button btnTestaIguais;
        private System.Windows.Forms.Button btnInsere1;
        private System.Windows.Forms.Button btnInsere2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}