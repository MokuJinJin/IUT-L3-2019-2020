using Contrat.DTO;
using RestSharp;

namespace Contrat
{
    public interface IService
    {
        IRestResponse<DtoOmdbSearchResult> Search(string partialName);

        IRestResponse<DtoOmdbResultFull> Get(int imdbId);
    }
}