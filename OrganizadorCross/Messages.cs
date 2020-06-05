using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorCross
{
    public static class Messages
    {

        public static void Alerta(string texto, string titulo = "", MessageBoxButtons botao = MessageBoxButtons.OK)
        {
            if (titulo == "" || string.IsNullOrEmpty(titulo)) { titulo = $":: {Application.ProductName.ToString()} ::"; }
            MessageBox.Show(texto, titulo, botao, MessageBoxIcon.Information);
        }

        public static void Erro(string texto, string titulo = "", MessageBoxButtons botao = MessageBoxButtons.OK)
        {
            if (titulo == "" || string.IsNullOrEmpty(titulo)) { titulo = $":: {Application.ProductName.ToString()} ::"; }
            MessageBox.Show(texto, titulo, botao, MessageBoxIcon.Error);
        }

        public static void Sucesso(string texto, string titulo = "", MessageBoxButtons botao = MessageBoxButtons.OK)
        {
            if (titulo == "" || string.IsNullOrEmpty(titulo)) { titulo = $":: {Application.ProductName.ToString()} ::"; }
            MessageBox.Show(texto, titulo, botao, MessageBoxIcon.Exclamation);
        }

        public static bool Comfirma(string texto, string titulo = "")
        {
            var dialogResult = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (titulo == "" || string.IsNullOrEmpty(titulo)) { titulo = ":: Deseja realmente realizar a ação? ::"; }

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
