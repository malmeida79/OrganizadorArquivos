using System;
using System.Windows.Forms;
using OrganizadorCore;
using System.IO;
using OrganizadorLog;
using OrganizadorDomain.Model;
using OrganizadorCross;
using System.Collections.Generic;
using System.Drawing;

namespace OrganizadorArquivos
{
    public partial class GestaoArquivos : Form
    {
        RegistroLog objLog = new RegistroLog();
        List<Arquivo> listaArquivos;

        public GestaoArquivos()
        {
            InitializeComponent();
            var objArq = new Manipulador();
            lblPastaSelecionada.Text = objArq.BuscaUltimaPasta();
            txtTipoFile.Text = "*.mp3";
        }

        #region Metodos Internos

        private void limparTela()
        {
            fbDiag.SelectedPath = string.Empty;
            lblPastaSelecionada.Text = "";
            trvArquivos.Nodes.Clear();
            OpcoesAcoesCor(false);
        }

        private void OpcoesAcoesCor(bool ativo)
        {
            if (ativo)
            {
                btnOpcoes.BackColor = Color.LawnGreen;
            }
            else
            {
                btnOpcoes.BackColor = Color.Beige;
            }

            btnOpcoes.Enabled = ativo;
        }

        private void MontaLista(bool alteraTreView = true)
        {
            try
            {
                var objArq = new Manipulador();
                string tipo = txtTipoFile.Text;
                listaArquivos = objArq.ListarArquivos(ref tipo, lblPastaSelecionada.Text, subDiretorios: chkSubDir.Checked);

                objArq.SalvaUltimaPasta(lblPastaSelecionada.Text);

                if (listaArquivos == null)
                {
                    Messages.Alerta("Não existem arquivos na pasta selecionada.");
                    OpcoesAcoesCor(false);
                    return;
                }

                if (listaArquivos.Count <= 0)
                {
                    Messages.Alerta("Não existem arquivos na pasta selecionada.");
                    OpcoesAcoesCor(false);
                    return;
                }
                else
                {
                    OpcoesAcoesCor(true);

                    if (alteraTreView)
                    {
                        if (!string.IsNullOrEmpty(lblPastaSelecionada.Text))
                        {
                            if (Directory.Exists(lblPastaSelecionada.Text))
                            {
                                objArq.CarregaTreeView(trvArquivos, lblPastaSelecionada.Text, subDiretorios: chkSubDir.Checked, tipo: tipo);
                            }
                        }
                    }

                }

                objArq = null;

                if (tipo != "")
                {
                    txtTipoFile.Text = tipo;
                }
            }
            catch (Exception ex)
            {
                OpcoesAcoesCor(false);
                Messages.Erro(ex.Message.ToString());
                objLog.gravarLog(ex.Message.ToString(), "Listar-GestaoArquivos", EnumTipoLog.ErroCritico);
            }
        }

        #endregion

        #region Acoes

        private void GestaoArquivos_Load(object sender, EventArgs e)
        {
            this.Text = $":: {Application.ProductName} ::";
        }

        private void btnSelPasta_Click(object sender, EventArgs e)
        {
            using (fbDiag)
            {
                fbDiag.ShowDialog();
                lblPastaSelecionada.Text = fbDiag.SelectedPath;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MontaLista();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre frm = new Sobre();
            frm.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            Opcoes frmOpc = new Opcoes(listaArquivos, lblPastaSelecionada.Text);
            frmOpc.ShowDialog();
        }

        private void TrvArquivos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selecao = e.Node.FullPath.Replace(@"Listagem\", "").Replace(@"\\", @"\");
            if (selecao.ToLower() != "listagem")
            {
                // quando clicado no arquivo trataremos como pasta
                if (e.Node.FirstNode == null)
                {
                    selecao = selecao.Replace(e.Node.Text, "");
                }

                lblPastaSelecionada.Text = selecao;

                MontaLista(alteraTreView: false);
            }
        }

        #endregion
    }
}
