using DataAccess.Factories;
using DataAccess.RESTServices.GoogleBooks.Interfaces;
using Entities.GoogleBooks;
using log4net;
using Newtonsoft.Json;

namespace DataAccess.RESTServices.GoogleBooks.Services
{
    public class ConsumingGoogleQueryService : IConsumingGoogleBooksQueryService
    {
        private readonly ILog _logger;
        private readonly string apiURL = "https://www.googleapis.com/books/v1";
        private readonly HttpClient httpClient;

        public ConsumingGoogleQueryService()
        {
            httpClient = HttpClientFactory.ConfigClientGoogle();
            this._logger = LogManager.GetLogger(typeof(ConsumingGoogleQueryService));
        }

        public async Task<List<GoogleBooksEntityVolume>> GetVolumeByID(string bookID)
        {
            List<GoogleBooksEntityVolume> VolumeList = new List<GoogleBooksEntityVolume>();
            var response = await httpClient.GetAsync($"{apiURL}/volumes/{bookID}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                var volumeDeserialized = JsonConvert.DeserializeObject<GoogleBooksEntityVolume>(readResponseAsync);
                VolumeList.Add(volumeDeserialized);
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return VolumeList;
        }

        public async Task<GoogleBooksVolumeList> GetVolumesByKeyword(string keywordToSearch)
        {
            GoogleBooksVolumeList VolumeList = new GoogleBooksVolumeList();
            var response = await httpClient.GetAsync($"{apiURL}/volumes?q={keywordToSearch}&key=AIzaSyB4KTOc8pi8f7oqK3jO3J_SgcEntzaOyHA");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                var responseDeserialized = JsonConvert.DeserializeObject<GoogleBooksVolumeList>(readResponseAsync);
                VolumeList = responseDeserialized;
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return VolumeList;
        }
    }
}
