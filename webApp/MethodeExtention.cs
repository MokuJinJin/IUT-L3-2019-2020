using System.Collections.Generic;
using webApp.Models;

namespace webApp
{
    /// <summary>
    /// Classe statique qui contient des méthodes d'extentions
    /// </summary>
    public static class MethodeExtention
    {
        /// <summary>
        /// Méthode permettant de cumuler les valeurs MyProperty
        /// </summary>
        /// <param name="liste">Liste de IModel sur lequel on fait le cumul</param>
        /// <returns>Cumul des valeurs MyProperty</returns>
        public static int Comptage(this List<IModel> liste)
        {
            int compte = 0;
            foreach (var item in liste)
            {
                compte += item.MyProperty;
            }
            return compte;
        }
    }
}
