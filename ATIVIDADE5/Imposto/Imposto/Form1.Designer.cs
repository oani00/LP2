namespace Imposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mskSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mskINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskSalBruto
            // 
            this.mskSalBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskSalBruto.Location = new System.Drawing.Point(285, 51);
            this.mskSalBruto.Mask = "0000000.00";
            this.mskSalBruto.Name = "mskSalBruto";
            this.mskSalBruto.Size = new System.Drawing.Size(121, 20);
            this.mskSalBruto.TabIndex = 2;
            this.mskSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSalBruto_MaskInputRejected);
            // 
            // mskNumFilhos
            // 
            this.mskNumFilhos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskNumFilhos.Location = new System.Drawing.Point(285, 92);
            this.mskNumFilhos.Mask = "00";
            this.mskNumFilhos.Name = "mskNumFilhos";
            this.mskNumFilhos.Size = new System.Drawing.Size(120, 20);
            this.mskNumFilhos.TabIndex = 3;
            this.mskNumFilhos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNumFilhos_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(150, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do(a) funcionario(a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(150, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(150, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de filhos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(150, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aliquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(150, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(150, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salário Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(150, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Salário Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(421, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(421, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Desconto IRPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMasc);
            this.groupBox1.Controls.Add(this.radFem);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(423, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Location = new System.Drawing.Point(33, 45);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(73, 17);
            this.radMasc.TabIndex = 1;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Checked = true;
            this.radFem.Location = new System.Drawing.Point(33, 19);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(67, 17);
            this.radFem.TabIndex = 0;
            this.radFem.TabStop = true;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            this.radFem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(423, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 62);
            this.panel1.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Casado(a)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label11.Location = new System.Drawing.Point(633, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 33);
            this.label11.TabIndex = 22;
            this.label11.Text = "Materia LP2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // mskFuncionario
            // 
            this.mskFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskFuncionario.Location = new System.Drawing.Point(285, 11);
            this.mskFuncionario.Name = "mskFuncionario";
            this.mskFuncionario.Size = new System.Drawing.Size(121, 20);
            this.mskFuncionario.TabIndex = 1;
            this.mskFuncionario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFuncionario_MaskInputRejected);
            // 
            // mskINSS
            // 
            this.mskINSS.Enabled = false;
            this.mskINSS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskINSS.Location = new System.Drawing.Point(259, 230);
            this.mskINSS.Name = "mskINSS";
            this.mskINSS.Size = new System.Drawing.Size(147, 20);
            this.mskINSS.TabIndex = 24;
            // 
            // mskIRPF
            // 
            this.mskIRPF.Enabled = false;
            this.mskIRPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskIRPF.Location = new System.Drawing.Point(259, 261);
            this.mskIRPF.Name = "mskIRPF";
            this.mskIRPF.Size = new System.Drawing.Size(147, 20);
            this.mskIRPF.TabIndex = 25;
            // 
            // mskSalFamilia
            // 
            this.mskSalFamilia.Enabled = false;
            this.mskSalFamilia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskSalFamilia.Location = new System.Drawing.Point(259, 294);
            this.mskSalFamilia.Name = "mskSalFamilia";
            this.mskSalFamilia.Size = new System.Drawing.Size(147, 20);
            this.mskSalFamilia.TabIndex = 26;
            // 
            // mskSalLiquido
            // 
            this.mskSalLiquido.Enabled = false;
            this.mskSalLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskSalLiquido.Location = new System.Drawing.Point(259, 324);
            this.mskSalLiquido.Name = "mskSalLiquido";
            this.mskSalLiquido.Size = new System.Drawing.Size(147, 20);
            this.mskSalLiquido.TabIndex = 27;
            // 
            // mskDescINSS
            // 
            this.mskDescINSS.Enabled = false;
            this.mskDescINSS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskDescINSS.Location = new System.Drawing.Point(508, 232);
            this.mskDescINSS.Name = "mskDescINSS";
            this.mskDescINSS.Size = new System.Drawing.Size(100, 20);
            this.mskDescINSS.TabIndex = 28;
            // 
            // mskDescIRPF
            // 
            this.mskDescIRPF.Enabled = false;
            this.mskDescIRPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskDescIRPF.Location = new System.Drawing.Point(507, 261);
            this.mskDescIRPF.Name = "mskDescIRPF";
            this.mskDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskDescIRPF.TabIndex = 29;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(423, 294);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 50);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(530, 294);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 50);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaida.Location = new System.Drawing.Point(159, 185);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 13);
            this.lblSaida.TabIndex = 32;
            this.lblSaida.Click += new System.EventHandler(this.lblSaida_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificar.Location = new System.Drawing.Point(285, 131);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verifica Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(178, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "<- a saida aparecera na label ao lado, \r\nque esta pequenininha e horrivel de ver " +
    "aqui no modo edicao";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(631, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 155);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label12.Location = new System.Drawing.Point(633, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 33);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ex 5";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label13.Location = new System.Drawing.Point(23, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 33);
            this.label13.TabIndex = 37;
            this.label13.Text = "= )";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label14.Location = new System.Drawing.Point(7, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 33);
            this.label14.TabIndex = 38;
            this.label14.Text = "By oani00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(631, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 155);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(13, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 155);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(13, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 155);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(763, 360);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskDescIRPF);
            this.Controls.Add(this.mskDescINSS);
            this.Controls.Add(this.mskSalLiquido);
            this.Controls.Add(this.mskSalFamilia);
            this.Controls.Add(this.mskIRPF);
            this.Controls.Add(this.mskINSS);
            this.Controls.Add(this.mskFuncionario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskSalBruto);
            this.Controls.Add(this.mskNumFilhos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskSalBruto;
        private System.Windows.Forms.MaskedTextBox mskNumFilhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskFuncionario;
        private System.Windows.Forms.MaskedTextBox mskINSS;
        private System.Windows.Forms.MaskedTextBox mskIRPF;
        private System.Windows.Forms.MaskedTextBox mskSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskSalLiquido;
        private System.Windows.Forms.MaskedTextBox mskDescINSS;
        private System.Windows.Forms.MaskedTextBox mskDescIRPF;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

