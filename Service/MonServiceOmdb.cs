using System;
using Contrat;
using Contrat.DTO;
using RestSharp;

namespace Service
{
    public class MonServiceOmdb : IService
    {

        public string ApiKey { get; private set; }
        private RestClient Client;

        public MonServiceOmdb(string apiKey)
        {
            ApiKey = apiKey;
            // Création du client REST pour interroger l'API
            Client = new RestClient(new Uri("http://omdbapi.com"));

            // Ajout de la Clé d'API car l'accès n'est pas ouvert à tous, il faut s'enregistrer sur le site.
            // Il existe une limite à 1000 requêtes par jour.
            // La clé présente dans cet exemple est à remplacer par la vôtre.
            Client.AddDefaultParameter("apikey", ApiKey);
        }


        public IRestResponse<DtoOmdbSearchResult> Search(string partialName)
        {
            
            // Construction de la requète REST
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddQueryParameter("s", partialName);

            // Résultat de la requète Automatiquement 'casté' dans l'objet de notre choix.
            // Le nom des propriétés de l'objet doivent être identique au nom des propriétés de l'objet JSON
            // pour faire un mapping automatique
            IRestResponse<DtoOmdbSearchResult> response = Client.Get<DtoOmdbSearchResult>(restRequest);

            return response;
        }

        public IRestResponse<DtoOmdbResultFull> Get(int imdbId)
        {
            // Construction de la requète REST
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddQueryParameter("i", imdbId.ToString());

            // Résultat de la requète Automatiquement 'casté' dans l'objet de notre choix.
            // Le nom des propriétés de l'objet doivent être identique au nom des propriétés de l'objet JSON
            // pour faire un mapping automatique
            IRestResponse<DtoOmdbResultFull> response = Client.Get<DtoOmdbResultFull>(restRequest);

            return response;
        }
    }
}
