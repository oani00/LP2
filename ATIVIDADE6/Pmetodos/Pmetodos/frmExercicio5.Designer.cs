namespace Pmetodos
{
    partial class frmExercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio5));
            this.btnRolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rchResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRolar
            // 
            this.btnRolar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRolar.BackgroundImage")));
            this.btnRolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRolar.Location = new System.Drawing.Point(197, 59);
            this.btnRolar.Name = "btnRolar";
            this.btnRolar.Size = new System.Drawing.Size(78, 65);
            this.btnRolar.TabIndex = 0;
            this.btnRolar.UseVisualStyleBackColor = true;
            this.btnRolar.Click += new System.EventHandler(this.btnRolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dice roller: Vamos sortear um número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "e";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(58, 59);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(112, 20);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(58, 104);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(112, 20);
            this.txt2.TabIndex = 5;
            // 
            // rchResultado
            // 
            this.rchResultado.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchResultado.Location = new System.Drawing.Point(12, 143);
            this.rchResultado.Name = "rchResultado";
            this.rchResultado.Size = new System.Drawing.Size(263, 76);
            this.rchResultado.TabIndex = 6;
            this.rchResultado.Text = "";
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 241);
            this.Controls.Add(this.rchResultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRolar);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RichTextBox rchResultado;
    }
}