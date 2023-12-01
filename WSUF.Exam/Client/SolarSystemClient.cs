using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using WSUF.Exam.Model;

namespace WSUF.Exam.Client
{
    public class SolarSystemClient
    {
        private readonly HttpClient _httpClient;

        public SolarSystemClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            var baseAddress = configuration["SolarSystemApiBaseAddress"];
            if (string.IsNullOrWhiteSpace(baseAddress)) 
                throw new InvalidOperationException();

            _httpClient.BaseAddress = new Uri(baseAddress);
        }

        public List<SolarSystemBody>? GetAllBodies()
        {
            using var response = _httpClient.GetAsync("bodies").Result;

            if (!response.IsSuccessStatusCode) 
            {
                throw new InvalidOperationException();
            }

            var objectResponse = response.Content.ReadFromJsonAsync<SolarSystemApiGetBodiesResponse>().Result;

            return objectResponse?.Bodies;
        }
    }
}
