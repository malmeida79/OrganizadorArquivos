namespace OrganizadorArquivos
{
    partial class GestaoArquivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoArquivos));
            this.btnSelPasta = new System.Windows.Forms.Button();
            this.fbDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPastaSelecionada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkSubDir = new System.Windows.Forms.CheckBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.trvArquivos = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtTipoFile = new System.Windows.Forms.TextBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelPasta
            // 
            this.btnSelPasta.Location = new System.Drawing.Point(391, 57);
            this.btnSelPasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelPasta.Name = "btnSelPasta";
            this.btnSelPasta.Size = new System.Drawing.Size(96, 21);
            this.btnSelPasta.TabIndex = 0;
            this.btnSelPasta.Text = "Selecionar &Pasta";
            this.btnSelPasta.UseVisualStyleBackColor = true;
            this.btnSelPasta.Click += new System.EventHandler(this.btnSelPasta_Click);
            // 
            // lblPastaSelecionada
            // 
            this.lblPastaSelecionada.Location = new System.Drawing.Point(8, 17);
            this.lblPastaSelecionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPastaSelecionada.Name = "lblPastaSelecionada";
            this.lblPastaSelecionada.Size = new System.Drawing.Size(582, 17);
            this.lblPastaSelecionada.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPastaSelecionada);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(598, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasta Selecionada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(309, 466);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 21);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkSubDir
            // 
            this.chkSubDir.AutoSize = true;
            this.chkSubDir.Checked = true;
            this.chkSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubDir.Location = new System.Drawing.Point(493, 60);
            this.chkSubDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSubDir.Name = "chkSubDir";
            this.chkSubDir.Size = new System.Drawing.Size(114, 17);
            this.chkSubDir.TabIndex = 3;
            this.chkSubDir.Text = "I&ncluir sub pastas?";
            this.chkSubDir.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(235, 466);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(74, 21);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "L&istar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // trvArquivos
            // 
            this.trvArquivos.Location = new System.Drawing.Point(9, 84);
            this.trvArquivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trvArquivos.Name = "trvArquivos";
            this.trvArquivos.Size = new System.Drawing.Size(598, 345);
            this.trvArquivos.StateImageList = this.imgList;
            this.trvArquivos.TabIndex = 4;
            this.trvArquivos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvArquivos_NodeMouseDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "folder-drag-accept.ico");
            this.imgList.Images.SetKeyName(1, "folder-visiting-3.ico");
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(533, 506);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(74, 21);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtTipoFile
            // 
            this.txtTipoFile.Location = new System.Drawing.Point(165, 59);
            this.txtTipoFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoFile.Name = "txtTipoFile";
            this.txtTipoFile.Size = new System.Drawing.Size(217, 20);
            this.txtTipoFile.TabIndex = 6;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(8, 61);
            this.lblTipos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(148, 13);
            this.lblTipos.TabIndex = 7;
            this.lblTipos.Text = "Tipos (*.JPG|*.TXT|*.MP3|*...):";
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(457, 466);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(74, 21);
            this.btnSobre.TabIndex = 0;
            this.btnSobre.Text = "&Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackColor = System.Drawing.Color.Beige;
            this.btnOpcoes.Enabled = false;
            this.btnOpcoes.Location = new System.Drawing.Point(383, 466);
            this.btnOpcoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(74, 21);
            this.btnOpcoes.TabIndex = 0;
            this.btnOpcoes.Text = "&Opções ...";
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(531, 466);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(74, 21);
            this.btnAjuda.TabIndex = 0;
            this.btnAjuda.Text = "A&juda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(9, 432);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(598, 21);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Para acessar sub-pastas navegue pela arvore, clique duas vezes na pasta de intere" +
    "sse e depois em opções.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GestaoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 557);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.txtTipoFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.trvArquivos);
            this.Controls.Add(this.chkSubDir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelPasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Gestor de Arquivos ::";
            this.Load += new System.EventHandler(this.GestaoArquivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelPasta;
        private System.Windows.Forms.FolderBrowserDialog fbDiag;
        private System.Windows.Forms.Label lblPastaSelecionada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkSubDir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TreeView trvArquivos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtTipoFile;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label lblInfo;
    }
}

