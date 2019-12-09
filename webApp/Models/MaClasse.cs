using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
    /// <summary>
    /// Classe simple
    /// </summary>
    public class MaClasse
    {
        /// <summary>
        /// Valeur de type Entier
        /// </summary>
        public int Entier { get; set; }

        /// <summary>
        /// Proriété qui s'affiche différement dans la vue avec l'attribut 'Display'
        /// voir la vue 'MonPremier/Ajouter.cshtml'
        /// </summary>
        [Display(Name = "Mon jolie nom")]
        public string Chaine { get; set; }
    }
}
