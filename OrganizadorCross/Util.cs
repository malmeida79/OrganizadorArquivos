using System;
using System.Text.RegularExpressions;

namespace OrganizadorCross
{
    public class Util
    {
        /// <summary>
        /// Remove caracteres especiais de uma string.
        /// </summary>
        /// <param name="valor">String com caracteres especiais</param>
        /// <returns>Parâmetro 'valor' sem caracteres especiais</returns>
        public static string RemoverCaracteresEspeciais(string valor)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(valor, String.Empty);
        }

        /// <summary>
        /// Função para remover acentos da string
        /// </summary>
        /// <param name="valor">String para receber tratamento</param>
        /// <returns>String tratada</returns>
        public static string RemoverAcentos(string valor)
        {
            valor = Regex.Replace(valor, "[ÁÀÂÃ]", "A");
            valor = Regex.Replace(valor, "[ÉÈÊ]", "E");
            valor = Regex.Replace(valor, "[Í]", "I");
            valor = Regex.Replace(valor, "[ÓÒÔÕ]", "O");
            valor = Regex.Replace(valor, "[ÚÙÛÜ]", "U");
            valor = Regex.Replace(valor, "[Ç]", "C");
            valor = Regex.Replace(valor, "[áàâã]", "a");
            valor = Regex.Replace(valor, "[éèê]", "e");
            valor = Regex.Replace(valor, "[í]", "i");
            valor = Regex.Replace(valor, "[óòôõ]", "o");
            valor = Regex.Replace(valor, "[úùûü]", "u");
            valor = Regex.Replace(valor, "[ç]", "c");
            return valor;
        }

        /// <summary>
        /// Tratamento para filtro de extensoes de arquivo (Permite "*","|" e ".")
        /// </summary>
        /// <param name="valor">String a ser tratada</param>
        /// <returns>string tratada</returns>
        public static string CorrigeFiltroExtensoes(string valor)
        {
            Regex r = new Regex("[^a-zA-Z0-9|*.]+", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(valor.Trim().Replace(".|", "").Replace("|.", "").Replace("||", "|").Replace(".*.", "*.").Replace("..", ".").Replace("**", "*"), String.Empty);
        }

        /// <summary>
        /// Texto capitalizado
        /// </summary>
        /// <param name="s">Texto a ser capitalizado</param>
        /// <returns>Primeira letra maiuscula</returns>
        public static string TextoCapitalizado(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            s = s.ToLower();

            char[] a = s.ToCharArray();

            a[0] = char.ToUpper(a[0]);

            return new string(a);
        }

        /// <summary>
        /// texto com primeira letra de cada palavra em maiusculo
        /// </summary>
        /// <param name="value">texto a ser convertido</param>
        /// <returns>Primeira letra de cada palavra da frase em maiusculo</returns>
        public static string TextoTipoTitulo(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            value = value.ToLower();

            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
