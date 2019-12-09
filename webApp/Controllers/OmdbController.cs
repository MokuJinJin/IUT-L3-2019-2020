using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using webApp.Models;

namespace webApp.Controllers
{
    /// <summary>
    /// Controler qui permet d'accèder à l'API OMDB
    /// </summary>
    public class OmdbController : Controller
    {
        /// <summary>
        /// Méthode par défaut
        /// </summary>
        /// <returns>Résultats de recherche OMDB : Film dont le nom contient 'Totoro'</returns>
        public IActionResult Index()
        {
            // Création du client REST pour interroger l'API
            var client = new RestClient(new Uri("http://omdbapi.com"));
            
            // Ajout de la Clé d'API car l'accès n'est pas ouvert à tous, il faut s'enregistrer sur le site.
            // Il existe une limite à 1000 requêtes par jour.
            // La clé présente dans cet exemple est à remplacer par la vôtre.
            client.AddDefaultParameter("apikey", "your-api-key");

            // Construction de la requète REST
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddQueryParameter("s", "Totoro");

            // Résultat de la requète Automatiquement 'casté' dans l'objet de notre choix.
            // Le nom des propriétés de l'objet doivent être identique au nom des propriétés de l'objet JSON
            // pour faire un mapping automatique
            IRestResponse<OmdbSearchResult> response = client.Get<OmdbSearchResult>(restRequest);

            // On renvoit que la propriété 'Data' qui contient l'instance de l'objet 'OmdbSearchResult'
            return View(response.Data);
        }
    }
}