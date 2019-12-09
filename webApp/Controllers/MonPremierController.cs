using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webApp.Models;

namespace webApp.Controllers
{
    /// <summary>
    /// Controler 'MonPremier'
    /// </summary>
    public class MonPremierController : Controller
    {
        /// <summary>
        /// Liste d'objet commun à tout le controller.
        /// On simule ici une donnée venant d'une autre source de donnée.
        /// </summary>
        public List<MaClasse> ListeClasses = new List<MaClasse>()
        {
            new MaClasse(){Chaine = "un", Entier = 1},
            new MaClasse(){Chaine = "deux", Entier = 2},
            new MaClasse(){Chaine = "trois", Entier = 3},
            new MaClasse(){Chaine = "quatre", Entier = 4},
            new MaClasse(){Chaine = "cinq", Entier = 5},
        };
        /// <summary>
        /// Méthode par défaut
        /// </summary>
        /// <returns>vue par défaut</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Méthode pour afficher la liste d'objet
        /// </summary>
        /// <returns>Liste d'objet</returns>
        public IActionResult Listing()
        {
            return View(ListeClasses);
        }
        /// <summary>
        /// Méthode associée à l'affichage des champs pour ajouter un élément à la liste.
        /// </summary>
        /// <returns>vue par défaut</returns>
        public IActionResult Ajouter()
        {
            return View();
        }
        /// <summary>
        /// Méthode faisant l'action d'ajout d'un objet à la liste
        /// </summary>
        /// <param name="classe">instance de l'objet à ajouter à la liste</param>
        /// <returns>Vue Listing</returns>
        public IActionResult Renseigner(MaClasse classe)
        {
            ListeClasses.Add(classe);
            return View("Listing", ListeClasses);
        }
    }
}
