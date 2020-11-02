namespace exercicios__oani
{
    partial class Form3
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
            this.btnPal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPal
            // 
            this.btnPal.Location = new System.Drawing.Point(71, 87);
            this.btnPal.Name = "btnPal";
            this.btnPal.Size = new System.Drawing.Size(146, 40);
            this.btnPal.TabIndex = 9;
            this.btnPal.Text = "É palindromo?";
            this.btnPal.UseVisualStyleBackColor = true;
            this.btnPal.Click += new System.EventHandler(this.btnPal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 65);
            this.label3.TabIndex = 8;
            this.label3.Text = "-Mostrarei o que você digitar.\r\n\r\n-E direi se é palindromo ou não.\r\n\r\n           " +
    "Max 50 caracteres!";
            // 
            // txtPal
            // 
            this.txtPal.Location = new System.Drawing.Point(71, 40);
            this.txtPal.MaxLength = 50;
            this.txtPal.Name = "txtPal";
            this.txtPal.Size = new System.Drawing.Size(146, 20);
            this.txtPal.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPal);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPal;
    }
}