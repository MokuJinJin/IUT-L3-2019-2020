using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using Contrat;
using Contrat.DTO;
using Service;
using webApp.Models;

namespace webApp.Controllers
{
    /// <summary>
    /// Controler qui permet d'accèder à l'API OMDB
    /// </summary>
    public class OmdbController : Controller
    {
        private IService _omdbService;
        private string _apiKey = "792ed516";


        /// <summary>
        /// Méthode par défaut
        /// </summary>
        /// <returns>Résultats de recherche OMDB : Film dont le nom contient 'Star Wars'</returns>
        public IActionResult Index()
        {

            _omdbService = new MonServiceOmdb(_apiKey);

            IRestResponse<DtoOmdbSearchResult> response = _omdbService.Search("Star Wars");
            
            // On renvoit que la propriété 'Data' qui contient l'instance de l'objet 'OmdbSearchResult'
            return View(response.Data);
        }

        public IActionResult Details(string imdbID)
        {

            _omdbService = new MonServiceOmdb(_apiKey);

            // On renvoit que la propriété 'Data' qui contient l'instance de l'objet 'OmdbSearchResult'
            return View(response.Data);
        }
    }
}