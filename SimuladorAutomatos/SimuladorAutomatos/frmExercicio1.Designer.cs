namespace SimuladorAutomatos
{
    partial class frmExercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio1));
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbParametros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPassoApasso = new System.Windows.Forms.CheckBox();
            this.btnSolucao = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.irParaOOutroExercícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbLinkedin = new System.Windows.Forms.PictureBox();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblQ0 = new System.Windows.Forms.Label();
            this.pcbEstadoQ2 = new System.Windows.Forms.PictureBox();
            this.pcbEstadoQ1 = new System.Windows.Forms.PictureBox();
            this.pcbEstadoQ0 = new System.Windows.Forms.PictureBox();
            this.gpbParametros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedin)).BeginInit();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ0)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.txtEntrada.Location = new System.Drawing.Point(16, 54);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(231, 27);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alfabeto de Entrada:";
            // 
            // gpbParametros
            // 
            this.gpbParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gpbParametros.Controls.Add(this.label2);
            this.gpbParametros.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.gpbParametros.ForeColor = System.Drawing.Color.White;
            this.gpbParametros.Location = new System.Drawing.Point(26, 34);
            this.gpbParametros.Name = "gpbParametros";
            this.gpbParametros.Size = new System.Drawing.Size(375, 69);
            this.gpbParametros.TabIndex = 3;
            this.gpbParametros.TabStop = false;
            this.gpbParametros.Text = "Parâmetros Lógicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "L (M) = {w ∈ {0,1} | w inicia em 0 e termina em 1}";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.chkPassoApasso);
            this.groupBox1.Controls.Add(this.btnSolucao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros de Entrada";
            // 
            // chkPassoApasso
            // 
            this.chkPassoApasso.AutoSize = true;
            this.chkPassoApasso.Checked = true;
            this.chkPassoApasso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassoApasso.Location = new System.Drawing.Point(16, 98);
            this.chkPassoApasso.Name = "chkPassoApasso";
            this.chkPassoApasso.Size = new System.Drawing.Size(195, 23);
            this.chkPassoApasso.TabIndex = 7;
            this.chkPassoApasso.Text = "Acompanhar passo a passo";
            this.chkPassoApasso.UseVisualStyleBackColor = true;
            // 
            // btnSolucao
            // 
            this.btnSolucao.BackColor = System.Drawing.SystemColors.Control;
            this.btnSolucao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.btnSolucao.Location = new System.Drawing.Point(253, 54);
            this.btnSolucao.Name = "btnSolucao";
            this.btnSolucao.Size = new System.Drawing.Size(102, 27);
            this.btnSolucao.TabIndex = 6;
            this.btnSolucao.Text = "Solução";
            this.btnSolucao.UseVisualStyleBackColor = false;
            this.btnSolucao.Click += new System.EventHandler(this.btnSolucao_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.HideSelection = false;
            this.txtLog.Location = new System.Drawing.Point(423, 45);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(258, 218);
            this.txtLog.TabIndex = 6;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Humnst777 Cn BT", 10F);
            this.lblSobre.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblSobre.Location = new System.Drawing.Point(68, 497);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(613, 17);
            this.lblSobre.TabIndex = 7;
            this.lblSobre.Text = "Desenvolvido por Gabriel Vicente | RA: 1595885018 | Ciência da Computação - Facul" +
    "dade Anhanguera de Taubaté";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irParaOOutroExercícioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 8;
            // 
            // irParaOOutroExercícioToolStripMenuItem
            // 
            this.irParaOOutroExercícioToolStripMenuItem.Name = "irParaOOutroExercícioToolStripMenuItem";
            this.irParaOOutroExercícioToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.irParaOOutroExercícioToolStripMenuItem.Text = "Ir para o Exercício 2";
            this.irParaOOutroExercícioToolStripMenuItem.Click += new System.EventHandler(this.irParaOOutroExercícioToolStripMenuItem_Click);
            // 
            // pcbLinkedin
            // 
            this.pcbLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLinkedin.Image = global::SimuladorAutomatos.Properties.Resources._in;
            this.pcbLinkedin.Location = new System.Drawing.Point(35, 492);
            this.pcbLinkedin.Name = "pcbLinkedin";
            this.pcbLinkedin.Size = new System.Drawing.Size(27, 27);
            this.pcbLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLinkedin.TabIndex = 15;
            this.pcbLinkedin.TabStop = false;
            this.pcbLinkedin.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gpbResultado.Controls.Add(this.label3);
            this.gpbResultado.Controls.Add(this.label7);
            this.gpbResultado.Controls.Add(this.label9);
            this.gpbResultado.Controls.Add(this.label10);
            this.gpbResultado.Controls.Add(this.label11);
            this.gpbResultado.Controls.Add(this.pictureBox1);
            this.gpbResultado.Controls.Add(this.pictureBox8);
            this.gpbResultado.Controls.Add(this.pictureBox9);
            this.gpbResultado.Controls.Add(this.pictureBox10);
            this.gpbResultado.Controls.Add(this.pictureBox11);
            this.gpbResultado.Controls.Add(this.pictureBox12);
            this.gpbResultado.Controls.Add(this.lblQ2);
            this.gpbResultado.Controls.Add(this.lblQ1);
            this.gpbResultado.Controls.Add(this.lblQ0);
            this.gpbResultado.Controls.Add(this.pcbEstadoQ2);
            this.gpbResultado.Controls.Add(this.pcbEstadoQ1);
            this.gpbResultado.Controls.Add(this.pcbEstadoQ0);
            this.gpbResultado.Font = new System.Drawing.Font("Humnst777 Cn BT", 12F);
            this.gpbResultado.ForeColor = System.Drawing.Color.White;
            this.gpbResultado.Location = new System.Drawing.Point(26, 269);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(655, 217);
            this.gpbResultado.TabIndex = 19;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(424, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(536, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(309, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(424, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 26);
            this.label10.TabIndex = 15;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(196, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimuladorAutomatos.Properties.Resources.seta_inicio;
            this.pictureBox1.Location = new System.Drawing.Point(21, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SimuladorAutomatos.Properties.Resources.seta_curva;
            this.pictureBox8.Location = new System.Drawing.Point(527, 63);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SimuladorAutomatos.Properties.Resources.seta_curva;
            this.pictureBox9.Location = new System.Drawing.Point(298, 63);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 39);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SimuladorAutomatos.Properties.Resources.seta_esquerda;
            this.pictureBox10.Location = new System.Drawing.Point(356, 131);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(155, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SimuladorAutomatos.Properties.Resources.seta_direita;
            this.pictureBox11.Location = new System.Drawing.Point(356, 89);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(155, 36);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SimuladorAutomatos.Properties.Resources.seta_direita;
            this.pictureBox12.Location = new System.Drawing.Point(129, 89);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(155, 36);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 8;
            this.pictureBox12.TabStop = false;
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.BackColor = System.Drawing.Color.White;
            this.lblQ2.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.lblQ2.Location = new System.Drawing.Point(529, 120);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(34, 26);
            this.lblQ2.TabIndex = 5;
            this.lblQ2.Text = "q2";
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.BackColor = System.Drawing.Color.White;
            this.lblQ1.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.lblQ1.Location = new System.Drawing.Point(303, 120);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(34, 26);
            this.lblQ1.TabIndex = 4;
            this.lblQ1.Text = "q1";
            // 
            // lblQ0
            // 
            this.lblQ0.AutoSize = true;
            this.lblQ0.BackColor = System.Drawing.Color.White;
            this.lblQ0.Font = new System.Drawing.Font("Humnst777 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.lblQ0.Location = new System.Drawing.Point(76, 119);
            this.lblQ0.Name = "lblQ0";
            this.lblQ0.Size = new System.Drawing.Size(34, 26);
            this.lblQ0.TabIndex = 3;
            this.lblQ0.Text = "q0";
            // 
            // pcbEstadoQ2
            // 
            this.pcbEstadoQ2.Image = global::SimuladorAutomatos.Properties.Resources.duplo_circulo_;
            this.pcbEstadoQ2.Location = new System.Drawing.Point(516, 103);
            this.pcbEstadoQ2.Name = "pcbEstadoQ2";
            this.pcbEstadoQ2.Size = new System.Drawing.Size(60, 60);
            this.pcbEstadoQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstadoQ2.TabIndex = 2;
            this.pcbEstadoQ2.TabStop = false;
            // 
            // pcbEstadoQ1
            // 
            this.pcbEstadoQ1.Image = ((System.Drawing.Image)(resources.GetObject("pcbEstadoQ1.Image")));
            this.pcbEstadoQ1.Location = new System.Drawing.Point(290, 103);
            this.pcbEstadoQ1.Name = "pcbEstadoQ1";
            this.pcbEstadoQ1.Size = new System.Drawing.Size(60, 60);
            this.pcbEstadoQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstadoQ1.TabIndex = 1;
            this.pcbEstadoQ1.TabStop = false;
            // 
            // pcbEstadoQ0
            // 
            this.pcbEstadoQ0.Image = global::SimuladorAutomatos.Properties.Resources.white_circle;
            this.pcbEstadoQ0.Location = new System.Drawing.Point(63, 102);
            this.pcbEstadoQ0.Name = "pcbEstadoQ0";
            this.pcbEstadoQ0.Size = new System.Drawing.Size(60, 60);
            this.pcbEstadoQ0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstadoQ0.TabIndex = 0;
            this.pcbEstadoQ0.TabStop = false;
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(703, 541);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.pcbLinkedin);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbParametros);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(719, 579);
            this.MinimumSize = new System.Drawing.Size(719, 579);
            this.Name = "frmExercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1 | Simulador de Autômatos";
            this.Load += new System.EventHandler(this.frmExercicio1_Load);
            this.gpbParametros.ResumeLayout(false);
            this.gpbParametros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedin)).EndInit();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstadoQ0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbParametros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSolucao;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkPassoApasso;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem irParaOOutroExercícioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbLinkedin;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblQ0;
        private System.Windows.Forms.PictureBox pcbEstadoQ2;
        private System.Windows.Forms.PictureBox pcbEstadoQ1;
        private System.Windows.Forms.PictureBox pcbEstadoQ0;
    }
}

