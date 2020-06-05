using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizadorDomain.Model;
using OrganizadorCore;
using OrganizadorCross;

namespace OrganizadorArquivos
{

    public partial class Opcoes : Form
    {
        internal string _caminhoRaiz;
        internal List<Arquivo> _listaArquivosOriginal;
        internal List<Arquivo> _listaArquivosAlterada;

        public Opcoes(List<Arquivo> listaArquivos, string caminhoRaiz)
        {
            InitializeComponent();
            this._caminhoRaiz = caminhoRaiz;
            this._listaArquivosOriginal = listaArquivos;
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            this.Text = $":: {Application.ProductName} - Opções ::";

            ClonarLista();
            CarregaOrigem();
            CarregaFinal();

            if (_listaArquivosOriginal != null)
            {
                if (_listaArquivosOriginal.Count() > 0)
                {
                    lblQuantidade.Text = $"{_listaArquivosOriginal.Count().ToString()} arquivos.";
                }
                else
                {
                    lblQuantidade.Text = string.Empty;
                }
            }
            else
            {
                lblQuantidade.Text = string.Empty;
            }
        }

        private void btnLimparEOrdenar_Click(object sender, EventArgs e)
        {
            int numero = 1;
            ClonarLista();

            _listaArquivosAlterada.ForEach(x =>
            {
                if (!string.IsNullOrEmpty(txtSeparador.Text))
                {
                    var arr = x.Nome.Split(Convert.ToChar(txtSeparador.Text));
                    x.Nome = arr.Last().TrimStart();
                }

                if (optCapitalize.Checked)
                {
                    x.Nome = Util.TextoCapitalizado(x.Nome);
                }
                else if (optTitle.Checked)
                {
                    x.Nome = Util.TextoTipoTitulo(x.Nome);
                }
                else if (optLower.Checked)
                {
                    x.Nome = x.Nome.ToLower();
                }
                else if (optUpper.Checked)
                {
                    x.Nome = x.Nome.ToUpper();
                }
            });

            if (chkOrdenacao.Checked)
            {
                _listaArquivosAlterada = _listaArquivosAlterada.OrderBy(x => x.Nome).ToList();
            }

            // para nao atrapalhar a ordenacao precisamos executar de novo o looping para incluir o prefixo e 
            // a numeracao apos a lista estar ordenada
            if (!string.IsNullOrEmpty(txtPrefixo.Text) || chkNumercao.Checked)
            {
                _listaArquivosAlterada.ForEach(x =>
                {
                    if (!string.IsNullOrEmpty(txtPrefixo.Text))
                    {
                        x.Nome = $"{txtPrefixo.Text} - {x.Nome}";
                    }

                    if (chkNumercao.Checked)
                    {
                        x.Nome = $"{numero.ToString().PadLeft(2, '0')} - {x.Nome}";
                        numero++;
                    }

                    if (!string.IsNullOrEmpty(txtNovoAgrupador.Text) && !string.IsNullOrEmpty(txtSeparador.Text))
                    {
                        x.Nome = x.Nome.Replace(txtSeparador.Text, txtNovoAgrupador.Text);
                    }

                });
            }

            CarregaFinal();
        }

        internal void CarregaFinal()
        {
            var objArq = new Manipulador();
            objArq.carregaListView(fileListFinal, _listaArquivosAlterada);
            objArq = null;
        }

        internal void CarregaOrigem()
        {
            var objArq = new Manipulador();
            objArq.carregaListView(fileListOrigem, _listaArquivosOriginal);
            objArq = null;
        }

        internal void ClonarLista()
        {
            _listaArquivosAlterada = new List<Arquivo>();

            // clonando a lista inicial para nova onde teremos as alterações
            _listaArquivosOriginal.ForEach((x) =>
            {
                _listaArquivosAlterada.Add(new Arquivo
                {
                    Nome = x.Nome,
                    Extensao = x.Extensao,
                    Tamanho = x.Tamanho,
                    CaminhoFisico = x.CaminhoFisico
                });
            });
        }

        private void optTitle_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void optCapitalize_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void optLower_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void optUpper_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void chkOrdenacao_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            ClonarLista();
            CarregaFinal();
        }

        private void chkNumercao_CheckedChanged(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void txtSeparador_Leave(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void txtPrefixo_Leave(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }

        private void txtNovoAgrupador_Leave(object sender, EventArgs e)
        {
            btnLimparEOrdenar_Click(sender, e);
        }
    }
}
