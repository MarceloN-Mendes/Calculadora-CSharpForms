namespace t1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnQuadrado = new System.Windows.Forms.RadioButton();
            this.rbtnretangulo = new System.Windows.Forms.RadioButton();
            this.rbtntriangulo = new System.Windows.Forms.RadioButton();
            this.rbtncirculo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarea = new System.Windows.Forms.TextBox();
            this.txtbperimetro = new System.Windows.Forms.TextBox();
            this.imgGeo = new System.Windows.Forms.PictureBox();
            this.lstHist = new System.Windows.Forms.ListBox();
            this.lblBaseLado = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.txtBaseLad = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.chkAtvHist = new System.Windows.Forms.CheckBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnLimHist = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGeo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtnQuadrado
            // 
            this.rbtnQuadrado.AutoSize = true;
            this.rbtnQuadrado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbtnQuadrado.Checked = true;
            this.rbtnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuadrado.Location = new System.Drawing.Point(51, 32);
            this.rbtnQuadrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnQuadrado.Name = "rbtnQuadrado";
            this.rbtnQuadrado.Size = new System.Drawing.Size(106, 24);
            this.rbtnQuadrado.TabIndex = 1;
            this.rbtnQuadrado.TabStop = true;
            this.rbtnQuadrado.Text = "Quadrado";
            this.rbtnQuadrado.UseVisualStyleBackColor = false;
            this.rbtnQuadrado.CheckedChanged += new System.EventHandler(this.rbtnQuadrado_CheckedChanged);
            // 
            // rbtnretangulo
            // 
            this.rbtnretangulo.AutoSize = true;
            this.rbtnretangulo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbtnretangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnretangulo.Location = new System.Drawing.Point(267, 32);
            this.rbtnretangulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnretangulo.Name = "rbtnretangulo";
            this.rbtnretangulo.Size = new System.Drawing.Size(110, 24);
            this.rbtnretangulo.TabIndex = 2;
            this.rbtnretangulo.TabStop = true;
            this.rbtnretangulo.Text = "Retângulo";
            this.rbtnretangulo.UseVisualStyleBackColor = false;
            this.rbtnretangulo.CheckedChanged += new System.EventHandler(this.rbtnretangulo_CheckedChanged);
            // 
            // rbtntriangulo
            // 
            this.rbtntriangulo.AutoSize = true;
            this.rbtntriangulo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbtntriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtntriangulo.Location = new System.Drawing.Point(605, 32);
            this.rbtntriangulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtntriangulo.Name = "rbtntriangulo";
            this.rbtntriangulo.Size = new System.Drawing.Size(188, 24);
            this.rbtntriangulo.TabIndex = 4;
            this.rbtntriangulo.TabStop = true;
            this.rbtntriangulo.Text = "Triângulo Equilátero";
            this.rbtntriangulo.UseVisualStyleBackColor = false;
            this.rbtntriangulo.CheckedChanged += new System.EventHandler(this.rbtntriangulo_CheckedChanged);
            // 
            // rbtncirculo
            // 
            this.rbtncirculo.AutoSize = true;
            this.rbtncirculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbtncirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtncirculo.Location = new System.Drawing.Point(452, 32);
            this.rbtncirculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtncirculo.Name = "rbtncirculo";
            this.rbtncirculo.Size = new System.Drawing.Size(82, 24);
            this.rbtncirculo.TabIndex = 3;
            this.rbtncirculo.TabStop = true;
            this.rbtncirculo.Text = "Círculo";
            this.rbtncirculo.UseVisualStyleBackColor = false;
            this.rbtncirculo.CheckedChanged += new System.EventHandler(this.rbtncirculo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.rbtncirculo);
            this.groupBox1.Controls.Add(this.rbtntriangulo);
            this.groupBox1.Controls.Add(this.rbtnQuadrado);
            this.groupBox1.Controls.Add(this.rbtnretangulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(848, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de polígonos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Perímetro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbarea
            // 
            this.txtbarea.Enabled = false;
            this.txtbarea.Location = new System.Drawing.Point(89, 35);
            this.txtbarea.Name = "txtbarea";
            this.txtbarea.ReadOnly = true;
            this.txtbarea.Size = new System.Drawing.Size(100, 29);
            this.txtbarea.TabIndex = 7;
            this.txtbarea.TextChanged += new System.EventHandler(this.txtbarea_TextChanged);
            // 
            // txtbperimetro
            // 
            this.txtbperimetro.Enabled = false;
            this.txtbperimetro.Location = new System.Drawing.Point(89, 83);
            this.txtbperimetro.Name = "txtbperimetro";
            this.txtbperimetro.Size = new System.Drawing.Size(100, 29);
            this.txtbperimetro.TabIndex = 8;
            // 
            // imgGeo
            // 
            this.imgGeo.BackColor = System.Drawing.Color.LightBlue;
            this.imgGeo.InitialImage = null;
            this.imgGeo.Location = new System.Drawing.Point(284, 322);
            this.imgGeo.Name = "imgGeo";
            this.imgGeo.Size = new System.Drawing.Size(225, 208);
            this.imgGeo.TabIndex = 9;
            this.imgGeo.TabStop = false;
            this.imgGeo.Click += new System.EventHandler(this.imgGeo_Click);
            // 
            // lstHist
            // 
            this.lstHist.FormattingEnabled = true;
            this.lstHist.ItemHeight = 20;
            this.lstHist.Location = new System.Drawing.Point(92, 186);
            this.lstHist.Name = "lstHist";
            this.lstHist.Size = new System.Drawing.Size(157, 344);
            this.lstHist.TabIndex = 10;
            // 
            // lblBaseLado
            // 
            this.lblBaseLado.AutoSize = true;
            this.lblBaseLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseLado.Location = new System.Drawing.Point(6, 34);
            this.lblBaseLado.Name = "lblBaseLado";
            this.lblBaseLado.Size = new System.Drawing.Size(49, 20);
            this.lblBaseLado.TabIndex = 11;
            this.lblBaseLado.Text = "Lado:";
            this.lblBaseLado.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(329, 34);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(46, 20);
            this.lblRaio.TabIndex = 12;
            this.lblRaio.Text = "Raio:";
            this.lblRaio.Visible = false;
            this.lblRaio.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.BackColor = System.Drawing.Color.LightBlue;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(669, 34);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(55, 20);
            this.lblAlt.TabIndex = 13;
            this.lblAlt.Text = "Altura:";
            this.lblAlt.Visible = false;
            this.lblAlt.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBaseLad
            // 
            this.txtBaseLad.Location = new System.Drawing.Point(58, 31);
            this.txtBaseLad.Name = "txtBaseLad";
            this.txtBaseLad.Size = new System.Drawing.Size(100, 29);
            this.txtBaseLad.TabIndex = 14;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(377, 31);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 29);
            this.txtRaio.TabIndex = 15;
            this.txtRaio.Visible = false;
            this.txtRaio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(726, 31);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(100, 29);
            this.txtAlt.TabIndex = 16;
            this.txtAlt.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.txtbarea);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbperimetro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(544, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 124);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.chkAtvHist);
            this.groupBox3.Controls.Add(this.btnlimpar);
            this.groupBox3.Controls.Add(this.btnLimHist);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.lstHist);
            this.groupBox3.Controls.Add(this.btnCalc);
            this.groupBox3.Controls.Add(this.imgGeo);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 552);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(284, 272);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(228, 32);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // chkAtvHist
            // 
            this.chkAtvHist.AutoSize = true;
            this.chkAtvHist.Location = new System.Drawing.Point(375, 194);
            this.chkAtvHist.Name = "chkAtvHist";
            this.chkAtvHist.Size = new System.Drawing.Size(134, 24);
            this.chkAtvHist.TabIndex = 21;
            this.chkAtvHist.Text = "Ativar Histórico";
            this.chkAtvHist.UseVisualStyleBackColor = true;
            this.chkAtvHist.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(437, 224);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 32);
            this.btnlimpar.TabIndex = 20;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimHist
            // 
            this.btnLimHist.Location = new System.Drawing.Point(284, 224);
            this.btnLimHist.Name = "btnLimHist";
            this.btnLimHist.Size = new System.Drawing.Size(147, 32);
            this.btnLimHist.TabIndex = 19;
            this.btnLimHist.Text = "Limpar Histórico";
            this.btnLimHist.UseVisualStyleBackColor = true;
            this.btnLimHist.Click += new System.EventHandler(this.btnLimHist_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(284, 186);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 32);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox4.Controls.Add(this.lblAlt);
            this.groupBox4.Controls.Add(this.txtRaio);
            this.groupBox4.Controls.Add(this.txtAlt);
            this.groupBox4.Controls.Add(this.lblRaio);
            this.groupBox4.Controls.Add(this.lblBaseLado);
            this.groupBox4.Controls.Add(this.txtBaseLad);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(92, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(848, 66);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1115, 586);
            this.Controls.Add(this.groupBox3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polígonos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGeo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnQuadrado;
        private System.Windows.Forms.RadioButton rbtnretangulo;
        private System.Windows.Forms.RadioButton rbtntriangulo;
        private System.Windows.Forms.RadioButton rbtncirculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarea;
        private System.Windows.Forms.TextBox txtbperimetro;
        private System.Windows.Forms.PictureBox imgGeo;
        private System.Windows.Forms.ListBox lstHist;
        private System.Windows.Forms.Label lblBaseLado;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.TextBox txtBaseLad;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimHist;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.CheckBox chkAtvHist;
        private System.Windows.Forms.Button btnSair;
    }
}

