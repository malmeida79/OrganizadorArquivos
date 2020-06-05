using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrganizadorCross
{
    public static class Extensions
    {
        /// <summary>
        /// Clonador de listas
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listToClone">Lista a ser clonada</param>
        /// <returns></returns>
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

    }
}
