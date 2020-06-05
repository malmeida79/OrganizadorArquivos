namespace OrganizadorArquivos
{
    partial class Opcoes
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
            this.fileListOrigem = new System.Windows.Forms.ListBox();
            this.fileListFinal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.btnLimparEOrdenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.optUpper = new System.Windows.Forms.RadioButton();
            this.optLower = new System.Windows.Forms.RadioButton();
            this.optCapitalize = new System.Windows.Forms.RadioButton();
            this.optTitle = new System.Windows.Forms.RadioButton();
            this.chkOrdenacao = new System.Windows.Forms.CheckBox();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.chkNumercao = new System.Windows.Forms.CheckBox();
            this.txtPrefixo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNovoAgrupador = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileListOrigem
            // 
            this.fileListOrigem.FormattingEnabled = true;
            this.fileListOrigem.Location = new System.Drawing.Point(8, 25);
            this.fileListOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileListOrigem.Name = "fileListOrigem";
            this.fileListOrigem.Size = new System.Drawing.Size(200, 420);
            this.fileListOrigem.TabIndex = 0;
            // 
            // fileListFinal
            // 
            this.fileListFinal.FormattingEnabled = true;
            this.fileListFinal.Location = new System.Drawing.Point(211, 25);
            this.fileListFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileListFinal.Name = "fileListFinal";
            this.fileListFinal.Size = new System.Drawing.Size(200, 420);
            this.fileListFinal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomes Originais";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(208, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomes após tratamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(247, 27);
            this.txtSeparador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeparador.MaxLength = 1;
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(25, 20);
            this.txtSeparador.TabIndex = 2;
            this.txtSeparador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeparador.Leave += new System.EventHandler(this.txtSeparador_Leave);
            // 
            // btnLimparEOrdenar
            // 
            this.btnLimparEOrdenar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimparEOrdenar.Location = new System.Drawing.Point(11, 16);
            this.btnLimparEOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimparEOrdenar.Name = "btnLimparEOrdenar";
            this.btnLimparEOrdenar.Size = new System.Drawing.Size(75, 21);
            this.btnLimparEOrdenar.TabIndex = 3;
            this.btnLimparEOrdenar.Text = "Preview ...";
            this.btnLimparEOrdenar.UseVisualStyleBackColor = false;
            this.btnLimparEOrdenar.Click += new System.EventHandler(this.btnLimparEOrdenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agrupador de blocos (00 - <<prefixo>> - nome):";
            // 
            // optUpper
            // 
            this.optUpper.AutoSize = true;
            this.optUpper.Location = new System.Drawing.Point(19, 38);
            this.optUpper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optUpper.Name = "optUpper";
            this.optUpper.Size = new System.Drawing.Size(78, 17);
            this.optUpper.TabIndex = 5;
            this.optUpper.Text = "Maiusculas";
            this.optUpper.UseVisualStyleBackColor = true;
            this.optUpper.CheckedChanged += new System.EventHandler(this.optUpper_CheckedChanged);
            // 
            // optLower
            // 
            this.optLower.AutoSize = true;
            this.optLower.Location = new System.Drawing.Point(175, 19);
            this.optLower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optLower.Name = "optLower";
            this.optLower.Size = new System.Drawing.Size(78, 17);
            this.optLower.TabIndex = 5;
            this.optLower.Text = "Minusculas";
            this.optLower.UseVisualStyleBackColor = true;
            this.optLower.CheckedChanged += new System.EventHandler(this.optLower_CheckedChanged);
            // 
            // optCapitalize
            // 
            this.optCapitalize.AutoSize = true;
            this.optCapitalize.Location = new System.Drawing.Point(175, 38);
            this.optCapitalize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optCapitalize.Name = "optCapitalize";
            this.optCapitalize.Size = new System.Drawing.Size(82, 17);
            this.optCapitalize.TabIndex = 5;
            this.optCapitalize.Text = "Capitalizado";
            this.optCapitalize.UseVisualStyleBackColor = true;
            this.optCapitalize.CheckedChanged += new System.EventHandler(this.optCapitalize_CheckedChanged);
            // 
            // optTitle
            // 
            this.optTitle.AutoSize = true;
            this.optTitle.Checked = true;
            this.optTitle.Location = new System.Drawing.Point(19, 19);
            this.optTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optTitle.Name = "optTitle";
            this.optTitle.Size = new System.Drawing.Size(71, 17);
            this.optTitle.TabIndex = 5;
            this.optTitle.TabStop = true;
            this.optTitle.Text = "Tipo titulo";
            this.optTitle.UseVisualStyleBackColor = true;
            this.optTitle.CheckedChanged += new System.EventHandler(this.optTitle_CheckedChanged);
            // 
            // chkOrdenacao
            // 
            this.chkOrdenacao.AutoSize = true;
            this.chkOrdenacao.Checked = true;
            this.chkOrdenacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrdenacao.Location = new System.Drawing.Point(11, 30);
            this.chkOrdenacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOrdenacao.Name = "chkOrdenacao";
            this.chkOrdenacao.Size = new System.Drawing.Size(129, 17);
            this.chkOrdenacao.TabIndex = 6;
            this.chkOrdenacao.Text = "Ordenação Alfabética";
            this.chkOrdenacao.UseVisualStyleBackColor = true;
            this.chkOrdenacao.CheckedChanged += new System.EventHandler(this.chkOrdenacao_CheckedChanged);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDesfazer.Location = new System.Drawing.Point(105, 16);
            this.btnDesfazer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 21);
            this.btnDesfazer.TabIndex = 3;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = false;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(630, 427);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 21);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAplicar.Location = new System.Drawing.Point(198, 16);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 21);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // chkNumercao
            // 
            this.chkNumercao.AutoSize = true;
            this.chkNumercao.Checked = true;
            this.chkNumercao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumercao.Location = new System.Drawing.Point(162, 30);
            this.chkNumercao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNumercao.Name = "chkNumercao";
            this.chkNumercao.Size = new System.Drawing.Size(114, 17);
            this.chkNumercao.TabIndex = 6;
            this.chkNumercao.Text = "Aplicar numeração";
            this.chkNumercao.UseVisualStyleBackColor = true;
            this.chkNumercao.CheckedChanged += new System.EventHandler(this.chkNumercao_CheckedChanged);
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.Location = new System.Drawing.Point(15, 44);
            this.txtPrefixo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.Size = new System.Drawing.Size(170, 20);
            this.txtPrefixo.TabIndex = 7;
            this.txtPrefixo.Leave += new System.EventHandler(this.txtPrefixo_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obs: Ao preenhcer o separador, sera realizada uma limpeza e restara apenas o ulti" +
    "mo bloco.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prefixo: (00 - <<prefixo>> - nome):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesfazer);
            this.groupBox1.Controls.Add(this.btnLimparEOrdenar);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Location = new System.Drawing.Point(421, 341);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(285, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrefixo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNovoAgrupador);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(421, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(285, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tratamentos especiais:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Novo agrupador:";
            // 
            // txtNovoAgrupador
            // 
            this.txtNovoAgrupador.Location = new System.Drawing.Point(193, 44);
            this.txtNovoAgrupador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNovoAgrupador.MaxLength = 1;
            this.txtNovoAgrupador.Name = "txtNovoAgrupador";
            this.txtNovoAgrupador.Size = new System.Drawing.Size(78, 20);
            this.txtNovoAgrupador.TabIndex = 2;
            this.txtNovoAgrupador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNovoAgrupador.Leave += new System.EventHandler(this.txtNovoAgrupador_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkOrdenacao);
            this.groupBox3.Controls.Add(this.chkNumercao);
            this.groupBox3.Location = new System.Drawing.Point(421, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(285, 65);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenação e numeração:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.optTitle);
            this.groupBox4.Controls.Add(this.optUpper);
            this.groupBox4.Controls.Add(this.optLower);
            this.groupBox4.Controls.Add(this.optCapitalize);
            this.groupBox4.Location = new System.Drawing.Point(421, 120);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(285, 61);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Padrões e carácteres:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtSeparador);
            this.groupBox5.Location = new System.Drawing.Point(420, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(285, 103);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agrupadores:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQuantidade.Location = new System.Drawing.Point(422, 393);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(284, 25);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 454);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileListFinal);
            this.Controls.Add(this.fileListOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Opcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ":: Opções de Manipulação ::";
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileListOrigem;
        private System.Windows.Forms.ListBox fileListFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Button btnLimparEOrdenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optUpper;
        private System.Windows.Forms.RadioButton optLower;
        private System.Windows.Forms.RadioButton optCapitalize;
        private System.Windows.Forms.RadioButton optTitle;
        private System.Windows.Forms.CheckBox chkOrdenacao;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.CheckBox chkNumercao;
        private System.Windows.Forms.TextBox txtPrefixo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNovoAgrupador;
        private System.Windows.Forms.Label lblQuantidade;
    }
}