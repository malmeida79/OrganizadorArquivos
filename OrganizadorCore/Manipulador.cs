using System.Collections.Generic;
using OrganizadorDomain.Model;
using System.IO;
using System.Windows.Forms;
using OrganizadorLog;
using OrganizadorCross;
using System.Linq;
using System.Reflection;
using System;

namespace OrganizadorCore
{
    public class Manipulador
    {
        RegistroLog objLog;

        public Manipulador()
        {
            objLog = new RegistroLog();
        }

        ~Manipulador()
        {
            objLog = null;
        }

        /// <summary>
        /// Listagem de arquivos de uma pasta
        /// </summary>
        /// <param name="caminhoRaiz">Pasta a ser pesauisada: caso não informada assume o dir da aplicação</param>
        /// <param name="tipo">Tipo do arquivo: caso não informado assume *.*</param>
        /// <param name="subDiretorios">Verificar ou nao sub-diretorios.</param>
        /// <returns></returns>
        public List<Arquivo> ListarArquivos(ref string tipo, string caminhoRaiz = null, bool subDiretorios = false)
        {
            string[] filePaths;
            var tipoBusca = SearchOption.TopDirectoryOnly;

            // tramento para caso de nao ser passado ripo de arquivo
            if (!string.IsNullOrEmpty(tipo))
            {
                tipo = Util.CorrigeFiltroExtensoes(Util.RemoverAcentos(tipo.Replace(',', '|').Replace(':', '|').Replace(',', ';')));
            }
            else
            {
                tipo = "*.*";
            }

            // caminho raiz tratado
            caminhoRaiz = trataCaminhoRaiz(caminhoRaiz);

            // buscar arquivos e retornar lista
            var retorno = new List<Arquivo>();

            // se marcado subdiretorios então fazemos a busca recursiva
            if (subDiretorios)
            {
                tipoBusca = SearchOption.AllDirectories;
            }

            try
            {
                filePaths = tipo.Split('|').SelectMany(filter => Directory.GetFiles(caminhoRaiz, filter, tipoBusca)).ToArray();
            }
            catch (System.Exception ex)
            {
                objLog.gravarLog(ex.Message.ToString(), "ListaArquivos-Manipulador", EnumTipoLog.ErroCritico);
                throw new Exception(ex.Message.ToString());
            }

            foreach (var arqBuscado in filePaths)
            {
                FileInfo fileInfo = new FileInfo(arqBuscado);
                var arq = new Arquivo
                {
                    Nome = fileInfo.Name,
                    Extensao = fileInfo.Extension,
                    CaminhoFisico = fileInfo.FullName,
                    Tamanho = fileInfo.Length.ToString()
                };
                retorno.Add(arq);
            }

            return retorno;
        }

        /// <summary>
        /// Constroi Treenode na tela
        /// </summary>
        /// <param name="treeName">Nome do treenode</param>
        /// <param name="caminhoRaiz">Pasta a ser pesauisada: caso não informada assume o dir da aplicação</param>
        /// <param name="tipo">Tipo do arquivo: caso não informado assume *.*</param>
        /// <param name="subDiretorios">Verificar ou nao sub-diretorios.</param>
        public void CarregaTreeView(TreeView treeName, string caminhoRaiz = null, string tipo = null, bool subDiretorios = false)
        {
            // tramento para caso de nao ser passado ripo de arquivo
            tipo = (string.IsNullOrEmpty(tipo)) ? "*.*" : tipo;

            // caminho raiz tratado
            caminhoRaiz = trataCaminhoRaiz(caminhoRaiz);

            treeName.Nodes.Clear();
            treeName.BeginUpdate();
            treeName.Nodes.Add("Listagem");
            SetNode(treeName, caminhoRaiz, caminhoRaiz, tipo, subDiretorios);
            treeName.EndUpdate();
        }

        /// <summary>
        /// Carrega listbox com lista de nomes de arquivos
        /// </summary>
        /// <param name="lista">Listbox</param>
        /// <param name="ListarArquivos">Lista de arquivos</param>
        public void carregaListView(ListBox lista, List<Arquivo> ListarArquivos)
        {
            string nomeAnterior = string.Empty;
            int conta = 0;
            lista.Items.Clear();

            ListarArquivos.OrderBy(x => x.Nome);

            ListarArquivos.ForEach(x =>
            {
                if (string.IsNullOrEmpty(nomeAnterior) || nomeAnterior.ToLower().Trim() != x.Nome.ToLower().Trim())
                {
                    nomeAnterior = x.Nome;
                    conta = 0;
                    lista.Items.Add(x.Nome.Trim());
                }
                else
                {
                    conta++;
                    lista.Items.Add($"{x.Nome.Trim()} copy ({conta.ToString()})");
                }
            });
        }

        public void SalvaUltimaPasta(string ultimaPasta)
        {
            IniFile arquivoIni = new IniFile();
            arquivoIni.IniWriteString("ultimaPasta", ultimaPasta);
        }

        public string BuscaUltimaPasta()
        {
            IniFile arquivoIni = new IniFile();
            return arquivoIni.IniReadString("ultimaPasta");
        }

        #region Internos

        /// <summary>
        /// Tratamento de caminho raiz
        /// </summary>
        /// <param name="caminhoRaiz">Caminho a ser tratado, caso nao informado aprenseta o da aplicação</param>
        /// <returns></returns>
        internal string trataCaminhoRaiz(string caminhoRaiz)
        {
            objLog.gravarLog("Não foi informado uma pasta para pesquisa, usou-se a da própria aplicação.", "TrataCaminhoRaiz - Manipulador", EnumTipoLog.Warning);

            // tratamento para caso de não informado caminho raiz
            caminhoRaiz = (string.IsNullOrEmpty(caminhoRaiz)) ? Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) : caminhoRaiz;

            // se caminho raiz informado não existir, criar o mesmo.
            if (!Directory.Exists(caminhoRaiz))
            {
                throw new Exception("Pasta inválida !!!");
            }

            return caminhoRaiz;
        }

        /// <summary>
        /// Cria node no treenode
        /// </summary>
        /// <param name="treeName"></param>        
        /// <param name="root">Pasta a ser pesauisada: caso não informada assume o dir da aplicação</param>
        /// <param name="nodeText">Nome do nó</param>
        /// <param name="tipo">Tipo do arquivo: caso não informado assume *.*</param>
        /// <param name="subDiretorios">Verificar ou nao sub-diretorios.</param>
        internal void SetNode(TreeView treeName, string root, string nodeText, string tipo, bool subDiretorios)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(root);
            TreeNode node = new TreeNode();
            node.Text = nodeText;
            GetFiles(dirInfo, node, tipo);
            GetFolders(dirInfo, node, tipo, subDiretorios);
            treeName.Nodes[0].Nodes.Add(node);
        }

        /// <summary>
        /// Busca pastas para os nos
        /// </summary>
        /// <param name="d">Path diretorio</param>
        /// <param name="node">no a ser inserido</param>
        /// <param name="tipo">Tipo do arquivo: caso não informado assume *.*</param>
        /// <param name="subDiretorios">Verificar ou nao sub-diretorios.</param>
        internal void GetFolders(DirectoryInfo d, TreeNode node, string tipo, bool subDiretorios)
        {
            try
            {
                DirectoryInfo[] dInfo = d.GetDirectories();
                if (dInfo.Length > 0)
                {
                    TreeNode treeNode = new TreeNode();
                    foreach (DirectoryInfo dirSub in dInfo)
                    {
                        // somente se estiver ativo listar sub diretorios
                        if (subDiretorios)
                        {
                            treeNode = node.Nodes.Add(dirSub.Name);
                            GetFiles(dirSub, treeNode, tipo);
                            GetFolders(dirSub, treeNode, tipo, subDiretorios);
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                objLog.gravarLog(ex.Message.ToString(), "GetFolders-Manipulador", EnumTipoLog.ErroCritico);
            }
        }

        /// <summary>
        /// Busca arquivos para serem inseridos no node.
        /// </summary>
        /// <param name="d">Path diretorio</param>
        /// <param name="node">no a ser inserido</param>
        /// <param name="tipo">Tipo do arquivo: caso não informado assume *.*</param>
        internal void GetFiles(DirectoryInfo d, TreeNode node, string tipo)
        {
            FileInfo[] subfileInfo = tipo.Split('|').SelectMany(filter => d.GetFiles(filter)).ToArray();
            if (subfileInfo.Length > 0)
            {
                for (int j = 0; j < subfileInfo.Length; j++)
                {
                    node.Nodes.Add(subfileInfo[j].Name);
                }
            }
        }

        #endregion
    }
}

